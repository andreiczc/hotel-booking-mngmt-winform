namespace Assignment14
{
    partial class UpdateForm
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
            this.components = new System.ComponentModel.Container();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.epSubmit = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(6, 35);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(86, 20);
            this.lbRoomType.TabIndex = 9;
            this.lbRoomType.Text = "Room type";
            // 
            // cbRoomType
            // 
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Single",
            "Couple",
            "Family",
            "Penthouse"});
            this.cbRoomType.Location = new System.Drawing.Point(99, 32);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 28);
            this.cbRoomType.TabIndex = 10;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(6, 81);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(83, 20);
            this.lbStartDate.TabIndex = 11;
            this.lbStartDate.Text = "Start Date";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(6, 124);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(77, 20);
            this.lbEndDate.TabIndex = 12;
            this.lbEndDate.Text = "End Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(99, 81);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(294, 26);
            this.dtpStartDate.TabIndex = 13;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(99, 124);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(294, 26);
            this.dtpEndDate.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 156);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 47);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.btnSubmit);
            this.gbClient.Controls.Add(this.dtpEndDate);
            this.gbClient.Controls.Add(this.dtpStartDate);
            this.gbClient.Controls.Add(this.lbEndDate);
            this.gbClient.Controls.Add(this.lbStartDate);
            this.gbClient.Controls.Add(this.cbRoomType);
            this.gbClient.Controls.Add(this.lbRoomType);
            this.gbClient.Location = new System.Drawing.Point(12, 8);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(426, 217);
            this.gbClient.TabIndex = 2;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Modify reservation";
            // 
            // epSubmit
            // 
            this.epSubmit.ContainerControl = this;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 237);
            this.Controls.Add(this.gbClient);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epSubmit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.ErrorProvider epSubmit;
    }
}