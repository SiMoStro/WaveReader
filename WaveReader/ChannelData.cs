using System;

namespace WaveReader
{
    public class ChannelData
    {
        private Int32 samplesCount;
        public Int32[] Samples;
        public string Name;
        public SamplesAnalyzer Analyzer;

        public Int32 RefValue { get; }

        public ChannelData(FormatChunk formatChunk, Int32 samples)
        {
            RefValue = 0;
            for (int b = 0; b < formatChunk.BitsPerSample - 1; b++)
            {
                RefValue = (RefValue << 1) | 1;
            }

            Int32 bytesPerSample = formatChunk.AvgBytesPerSec / (formatChunk.Channels * formatChunk.SamplesPerSec);
            samplesCount = samples;
            Samples = new Int32[samplesCount];
            Analyzer = new SamplesAnalyzer();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
