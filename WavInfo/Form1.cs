using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WaveReader;

namespace WavInfo
{
    public partial class FormMain : Form
    {
        WaveReader.WaveReader reader;

        public FormMain()
        {
            InitializeComponent();
        }

        private void w_menuOpen_Click(object sender, EventArgs e)
        {
            w_openFileDialog.Filter = "wave files|*.wav|all files|*.*";
            DialogResult res = w_openFileDialog.ShowDialog();
            if (res != DialogResult.OK) return;

            AnalyzeFile(w_openFileDialog.FileName);
        }

        void reader_PctReadUpdate(object sender, EventArgs e)
        {
            w_toolStripProgressBar.Value = reader.PctRead;
        }

        private void SetMsg(string msg)
        {
            w_toolStripStatusLabel.Text = msg;
        }

        private void AnalyzeFile(string filename)
        {
            FileStream stream = new FileStream(filename, FileMode.Open);

            SetMsg(@"loading...");

            reader = new WaveReader.WaveReader();
            reader.PctReadUpdate += new EventHandler(reader_PctReadUpdate);
            bool readResult = reader.Read(stream);
            
            
            if (reader.Format.Channels == 1)
            {
                reader.Channels[0].Analyzer.Analyze(reader.Channels[0]);
                w_cpChannelLeft.PlotPoints(reader.Channels[0]);
                w_tlpWaves.RowStyles[0].SizeType = SizeType.Percent;
                w_tlpWaves.RowStyles[0].Height = 100;
                w_tlpWaves.RowStyles[1].SizeType = SizeType.Percent;
                w_tlpWaves.RowStyles[1].Height = 0;
            }
            else if (reader.Format.Channels == 2)
            {
                reader.Channels[0].Analyzer.Analyze(reader.Channels[0]);
                reader.Channels[1].Analyzer.Analyze(reader.Channels[1]);
                w_cpChannelLeft.PlotPoints(reader.Channels[0]);
                w_cpChannelRight.PlotPoints(reader.Channels[1]);
                w_tlpWaves.RowStyles[0].SizeType = SizeType.Percent;
                w_tlpWaves.RowStyles[0].Height = 50;
                w_tlpWaves.RowStyles[1].SizeType = SizeType.Percent;
                w_tlpWaves.RowStyles[1].Height = 50;
            }

            w_toolStripProgressBar.Value = 0;

            w_leftChannelInfo.SelectedObject = reader.Channels[0].Analyzer;
            if(reader.Channels.Length > 1) w_rightChannelInfo.SelectedObject = reader.Channels[1].Analyzer;

            if (!readResult)
            {
                SetMsg(reader.Error);
            }
            else SetMsg(@"completed.");
            stream.Close();
        }
    }
}
