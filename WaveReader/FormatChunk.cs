using System;
using System.IO;

namespace WaveReader
{
    public class FormatChunk
    {
        private Int32 _chunkSize;

        public Int32 ChunkSize // can be 16, 18 or 40
        {
            get { return _chunkSize; }
        }

        private FormatCode _formatCode;
        public FormatCode FormatCode // FormatCode
        {
            get { return _formatCode; }
        }

        public Int16 _channels;
        public Int16 Channels
        {
            get { return _channels; }
        }

        private Int32 _samplesPerSec;
        public Int32 SamplesPerSec
        {
            get { return _samplesPerSec; }
        }

        public Int32 AvgBytesPerSec;
        public Int16 BlockAlign;
        public Int16 BitsPerSample;

        public Int16 ExtSize; // 0 or 22

        public Int16 ValidBitsPerSample;
        public Int32 ChannelMask;
        public byte[] SubFormat;

        internal void Read(BinaryReader br, Int32 size)
        {
            _chunkSize = size;
            _formatCode = (FormatCode)br.ReadInt16();
            _channels = br.ReadInt16();
            _samplesPerSec = br.ReadInt32();
            AvgBytesPerSec = br.ReadInt32();
            BlockAlign = br.ReadInt16();
            BitsPerSample = br.ReadInt16();

            if (ChunkSize == 18)
            {
                ExtSize = br.ReadInt16();
                if (ExtSize == 22)
                {
                    ValidBitsPerSample = br.ReadInt16();
                    ChannelMask = br.ReadInt32();
                    SubFormat = br.ReadBytes(16);
                }
            }
        }
    }
}
