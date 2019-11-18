using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using WaveReader;

namespace WavInfo
{
    public class CustomPanel : Panel
    {
        Bitmap bmp;

        public CustomPanel()
        {
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.DoubleBuffer, true);
        }

        public void PlotPoints(ChannelData data)
        {
            RefreshWave(data);
            Invalidate();
        }

        private void RefreshWave(ChannelData data)
        {
            if (data == null || data.Samples == null || data.Samples.Length == 0)
            {
                bmp = null;
                return;
            }
            bmp = new Bitmap(1200, 800);
            Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.LightSteelBlue);
            
            float x = 0;
            float y = bmp.Height / 2;
            float prevX, prevY;
            int delta = (data.Samples.Length / bmp.Width) / 20;
            if (delta <= 0) delta = 1;

            for (int i = 0; i < data.Samples.Length; i += delta)
            {
                prevX = x;
                prevY = y;
                y = ((float)Math.Abs(data.Samples[i] - data.RefValue)) * bmp.Height / (2 * data.RefValue);
                x = ((float)bmp.Width) / data.Samples.Length * i;
                g.DrawLine(Pens.DarkBlue, new PointF(prevX, prevY), new PointF(x, y));
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (bmp == null)
            {
                e.Graphics.Clear(BackColor);
                return;
            }
            e.Graphics.DrawImage(bmp, new Rectangle(0, 0, Width, Height));
        }
    }
}
