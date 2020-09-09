using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LineChart;

namespace Assignment14
{
    public partial class StatisticsForm : Form
    {
        private LineChartValues[] _values;

        public StatisticsForm(LineChartValues[] values)
        {
            _values = values;
            InitializeComponent();
        }
    }
}
