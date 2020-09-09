using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineChart
{
    public partial class LineChartControl : UserControl
    {
        public LineChartValues[] Data { get; set; }

        public LineChartControl()
        {
            InitializeComponent();
            ResizeRedraw = true;

            Data = new[]
            {
                new LineChartValues("room no", 5),
                new LineChartValues("room no", 7),
                new LineChartValues("room no", 9)
            };
        }

        public LineChartControl(LineChartValues[] data)
        {
            InitializeComponent();
            ResizeRedraw = true;
            Data = data;
        }

        private void LineChartControl_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = e.ClipRectangle;

            float scalingFactorX = (float) (rectangle.Width / Data.Length);
            float scalingFactorY = (float) (rectangle.Height / 10);

            Pen pen = new Pen(new SolidBrush(Color.Black));
            pen.StartCap = LineCap.ArrowAnchor;

            Pen pen2 = new Pen(new SolidBrush(Color.Black));
            pen2.EndCap = LineCap.RoundAnchor;

            graphics.DrawLine(pen, 0, 0, 0, rectangle.Height);
            graphics.DrawLine(pen, 0, rectangle.Height - 0.5f, rectangle.Width - 0.5f,
                rectangle.Height - 0.5f);

            for (int i = 0; i < Data.Length - 1; i++)
            {
                graphics.DrawLine(pen2,
                    i * scalingFactorX,
                    rectangle.Height - (Data[i].Value * scalingFactorY),
                    (i + 1) * scalingFactorX,
                    rectangle.Height - (Data[i + 1].Value * scalingFactorY));
            }
        }
    }
}
