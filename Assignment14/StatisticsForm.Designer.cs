namespace Assignment14
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lineChartControl1 = new LineChart.LineChartControl(_values);
            this.SuspendLayout();
            // 
            // lineChartControl1
            // 
            this.lineChartControl1.Location = new System.Drawing.Point(13, 13);
            this.lineChartControl1.Name = "lineChartControl1";
            this.lineChartControl1.Size = new System.Drawing.Size(775, 425);
            this.lineChartControl1.TabIndex = 0;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineChartControl1);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private LineChart.LineChartControl lineChartControl1;
    }
}