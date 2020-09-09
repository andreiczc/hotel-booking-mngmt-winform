namespace Assignment14
{
    partial class NewClientForm
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
            this.gbClient = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.epStartDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEndDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSubmit = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epStartDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEndDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubmit)).BeginInit();
            this.SuspendLayout();
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
            this.gbClient.Controls.Add(this.tbFullName);
            this.gbClient.Controls.Add(this.lbFullName);
            this.gbClient.Location = new System.Drawing.Point(13, 13);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(453, 283);
            this.gbClient.TabIndex = 0;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "New client";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 219);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 47);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(99, 168);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(294, 26);
            this.dtpEndDate.TabIndex = 14;
            this.dtpEndDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpEndDate_Validating);
            this.dtpEndDate.Validated += new System.EventHandler(this.dtpEndDate_Validated);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(99, 125);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(294, 26);
            this.dtpStartDate.TabIndex = 13;
            this.dtpStartDate.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            this.dtpStartDate.Validated += new System.EventHandler(this.dtpStartDate_Validated);
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(6, 168);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(77, 20);
            this.lbEndDate.TabIndex = 12;
            this.lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(6, 125);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(83, 20);
            this.lbStartDate.TabIndex = 11;
            this.lbStartDate.Text = "Start Date";
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
            this.cbRoomType.Location = new System.Drawing.Point(99, 76);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 28);
            this.cbRoomType.TabIndex = 10;
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(6, 79);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(86, 20);
            this.lbRoomType.TabIndex = 9;
            this.lbRoomType.Text = "Room type";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(99, 37);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(100, 26);
            this.tbFullName.TabIndex = 8;
            this.tbFullName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFullName_Validating);
            this.tbFullName.Validated += new System.EventHandler(this.tbFullName_Validated);
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(6, 37);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(86, 20);
            this.lbFullName.TabIndex = 7;
            this.lbFullName.Text = "Full name: ";
            // 
            // epStartDate
            // 
            this.epStartDate.ContainerControl = this;
            // 
            // epEndDate
            // 
            this.epEndDate.ContainerControl = this;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epSubmit
            // 
            this.epSubmit.ContainerControl = this;
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 311);
            this.Controls.Add(this.gbClient);
            this.Name = "NewClientForm";
            this.Text = "Add a reservation";
            this.Load += new System.EventHandler(this.NewClientForm_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epStartDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEndDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubmit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.ErrorProvider epStartDate;
        private System.Windows.Forms.ErrorProvider epEndDate;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epSubmit;
    }
}