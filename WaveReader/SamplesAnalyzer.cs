using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WaveReader
{
    public class SamplesAnalyzer
    {
        #region [private] variables

        private Int32 min;
        private Int32 max;
        private double avgNonZero;
        private double avg;
        private Int32 maxValue;
        private double rms;
        private Int32 zeroSamples;
        private Int32 nonZeroSamples;
        private double zeroSamplesPct;
        private double nonZeroSamplesPct;
        private Int32 totalSamples;

        #endregion

        #region [public] Properties

        [Description("Minimum sample value")]
        public Int32 Min
        {
            get { return min; }
        }

        [Description("Maximum sample value")]
        public Int32 Max
        {
            get { return max; }
        }

        [Description("Average samples value (global)")]
        public double Avg
        {
            get { return avg; }
        }

        [Description("Average non-zero samples value")]
        public double AvgNonZero
        {
            get { return avgNonZero; }
        }

        [Description("Minimum sample value in dB")]
        public double Min_dB
        {
            get
            {
                return 20 * Math.Log10(((double)Math.Abs(min)) / maxValue);
            }
        }

        [Description("Maximum sample value in dB")]
        public double Max_dB
        {
            get
            {
                return 20 * Math.Log10(((double)Math.Abs(max)) / maxValue);
            }
        }

        [Description("Root Mean Square value")]
        public double RMS
        {
            get
            {
                return rms;
            }
        }

        [Description("Root Mean Square value in dB")]
        public double RMS_dB
        {
            get
            {
                return 20 * Math.Log10(((double)rms) / maxValue);
            }
        }

        [Description("Zero values count")]
        public Int32 ZeroSamples
        {
            get { return zeroSamples; }
        }

        [Description("Non-Zero values count")]
        public Int32 NonZeroSamples
        {
            get { return nonZeroSamples; }
        }

        [Description("Non-Zero values count")]
        public Int32 SamplesCount
        {
            get { return totalSamples; }
        }

        [Description("Zero values count (percentage)")]
        public double ZeroSamplesPct
        {
            get { return zeroSamplesPct; }
        }

        [Description("Non-Zero values count (percentage)")]
        public double NonZeroSamplesPct
        {
            get { return nonZeroSamplesPct; }
        }

        #endregion

        public SamplesAnalyzer(){}

        public void Analyze(ChannelData data)
        {
            if (data == null || data.Samples.Length == 0) return;
            maxValue = data.RefValue;
            totalSamples = data.Samples.Length;
            nonZeroSamples = 0;
            Int32 s;
            for (Int32 i = 0; i < totalSamples; i++)
            {
                s = data.Samples[i];
                avg = ((avg * i) + s) / (i + 1);
                rms += (((double)s) * s);

                if (s == 0)
                {
                    zeroSamples++;
                    continue;
                }

                avgNonZero = ((avgNonZero * nonZeroSamples) + s) / (nonZeroSamples + 1);
                nonZeroSamples++;

                if (s < 0)
                {
                    if (min == 0 || (s < min)) { min = s; }
                }
                else
                {
                    if (max == 0 || (s > max)) { max = s; }
                }
            }

            rms = Math.Sqrt(rms / totalSamples);
            zeroSamplesPct = ((double)zeroSamples) / totalSamples;
            nonZeroSamplesPct = ((double)nonZeroSamples) / totalSamples;
        }
    }
}
