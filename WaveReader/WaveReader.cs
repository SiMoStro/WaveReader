using System;
using System.Diagnostics;
using System.IO;

namespace WaveReader
{
    public class WaveReader
    {
        public event EventHandler PctReadUpdate;
        public int PctRead;
        private static readonly int BitsPerByte = 8;

        public WaveFileFormat WaveFileFormat { get; private set; }
        public FormatChunk Format { get; private set; }
        public FactChunk Fact { get; private set; }
        public Int32 Samples { get; private set; }
        public Int32 BytesPerSample { get; private set; }
        public double Duration { get; private set; }
        public ChannelData[] Channels { get; private set; }
        public string Error { get; private set; }

        private Int32 negativeMask;

        public WaveReader()
        {
            Format = new FormatChunk();
            WaveFileFormat = new WaveFileFormat();
            Fact = new FactChunk();
        }

        public bool Read(Stream stream)
        {
            using (BinaryReader binaryReader = new BinaryReader(stream))
            {
                while (stream.Position < stream.Length)
                {
                    string chunkID;
                    long remaining = stream.Length - stream.Position;
                    var data = binaryReader.ReadBytes(4);

                    chunkID = System.Text.Encoding.UTF8.GetString(data);
                    if (data[0] == 0) // Sometimes data segment ends with a parasite null byte
                    {
                        stream.Seek(-3, SeekOrigin.Current);
                        data = binaryReader.ReadBytes(4);
                        chunkID = System.Text.Encoding.UTF8.GetString(data);
                    }

                    if (stream.Position == stream.Length)
                    {
                        return true;
                    }

                    int chunkSize = binaryReader.ReadInt32();

                    Debug.WriteLine("Chunk ID: " + chunkID + "; chunk size: " + chunkSize + "; stream remaining size: " + remaining);
                    if (chunkID == "RIFF")
                    {
                        WaveFileFormat.Read(binaryReader);
                    }
                    else if (chunkID == "fmt ")
                    {
                        Format.Read(binaryReader, chunkSize);
                    }
                    else if (chunkID == "data")
                    {
                        if (Format.FormatCode != FormatCode.PCM)
                        {
                            Error = "Format is not PCM";
                            return false;
                        }
                        ReadDataChunk(binaryReader, chunkSize);
                    }
                    else if (chunkID == "bext")
                    { // Broadcast Extension
                        binaryReader.ReadBytes(chunkSize);
                    }
                    else if (chunkID == "JUNK")
                    { // 
                        binaryReader.ReadBytes(chunkSize);
                    }
                    else if (chunkID == "ResU")
                    { // 
                        binaryReader.ReadBytes(chunkSize);
                    }
                    else if (chunkID == "LIST")
                    { // 
                        binaryReader.ReadBytes(chunkSize);
                    }
                    else if (chunkID == "id3 ")
                    { // 
                        binaryReader.ReadBytes(chunkSize);
                    }
                    else
                    { // unknown chunk - skip it...
                        if (chunkSize < 0 || chunkSize > remaining)
                        {
                            Error = "Chunk size error";
                            return false;
                        }
                        binaryReader.ReadBytes(chunkSize);
                    }
                }
            }

            return true;
        }

        private void ReadDataChunk(BinaryReader br, Int32 size)
        {
            BytesPerSample = Format.AvgBytesPerSec / (Format.Channels * Format.SamplesPerSec);
            Samples = size / (BytesPerSample * Format.Channels);
            Duration = (double)Samples / Format.SamplesPerSec;
            Channels = new ChannelData[Format.Channels];

            negativeMask = 0;
            for (int i = 0; i < (32 - Format.BitsPerSample); i++)
            {
                negativeMask = (negativeMask << 1) | 1;
            }
            for (int i = 0; i < Format.BitsPerSample; i++)
            {
                negativeMask = (negativeMask << 1) | 0;
            }

            for (int c = 0; c < Format.Channels; c++)
            {
                Channels[c] = new ChannelData(Format, Samples);
                Channels[c].Name = "Channel " + c;
            }

            PctRead = 0;
            CastPctReadUpdate();
            int deltaPctUpd = Samples / 100;
            for (int s = 0; s < Samples; s++)
            {
                if (s % deltaPctUpd == 0)
                {
                    PctRead = s / deltaPctUpd;
                    CastPctReadUpdate();
                }
                for (int channel = 0; channel < Format.Channels; channel++)
                {
                    Channels[channel].Samples[s] = ReadSample(br);
                }
            }
        }

        private Int32 ReadSample(BinaryReader br)
        {
            int sampleNumOfBytes = (int)(Math.Ceiling((double)Format.BitsPerSample / 8));
            int msbMask = 1 << (Format.BitsPerSample - 1);
            int mask = 1;
            for (int i = 1; i < (Format.BitsPerSample - 1); i++) mask = (mask << 1) + 1;

            Int32 sample = 0;
            if (sampleNumOfBytes == 1)
            {
                sample = br.ReadByte();
            }
            else
            {
                byte[] bytes = br.ReadBytes(sampleNumOfBytes);
                Int32 tmp = 0;
                for (int b = bytes.Length - 1; b >= 0; b--)
                {
                    tmp = tmp << 8;
                    tmp |= bytes[b];
                }
                if (tmp == 0) return 0;

                int check = tmp & msbMask;
                if ((check != 0))
                { // negative value
                    tmp = negativeMask | tmp;
                }

                sample = tmp;
            }

            return sample;
        }

        private void CastPctReadUpdate()
        {
            if (PctReadUpdate == null) return;
            PctReadUpdate(this, EventArgs.Empty);
        }
    }
}
