using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineChart
{
    public class LineChartValues
    {
        public string Label { get; set; }
        public int Value { get; set; }

        public LineChartValues(string label, int value)
        {
            Label = label;
            Value = value;
        }
    }
}
