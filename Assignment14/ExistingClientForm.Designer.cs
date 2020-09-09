namespace Assignment14
{
    partial class ExistingClientForm
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
            this.tbClientID = new System.Windows.Forms.TextBox();
            this.lbClientID = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.lbFullName = new System.Windows.Forms.Label();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSubmit = new System.Windows.Forms.ErrorProvider(this.components);
            this.epClientId = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClientId)).BeginInit();
            this.SuspendLayout();
            // 
            // gbClient
            // 
            this.gbClient.Controls.Add(this.tbClientID);
            this.gbClient.Controls.Add(this.lbClientID);
            this.gbClient.Controls.Add(this.btnSubmit);
            this.gbClient.Controls.Add(this.dtpEndDate);
            this.gbClient.Controls.Add(this.dtpStartDate);
            this.gbClient.Controls.Add(this.lbEndDate);
            this.gbClient.Controls.Add(this.lbStartDate);
            this.gbClient.Controls.Add(this.cbRoomType);
            this.gbClient.Controls.Add(this.lbRoomType);
            this.gbClient.Controls.Add(this.tbFullName);
            this.gbClient.Controls.Add(this.lbFullName);
            this.gbClient.Location = new System.Drawing.Point(12, 12);
            this.gbClient.Name = "gbClient";
            this.gbClient.Size = new System.Drawing.Size(776, 435);
            this.gbClient.TabIndex = 1;
            this.gbClient.TabStop = false;
            this.gbClient.Text = "Existing Client";
            // 
            // tbClientID
            // 
            this.tbClientID.Location = new System.Drawing.Point(99, 40);
            this.tbClientID.Name = "tbClientID";
            this.tbClientID.Size = new System.Drawing.Size(100, 26);
            this.tbClientID.TabIndex = 17;
            this.tbClientID.Validating += new System.ComponentModel.CancelEventHandler(this.tbClientID_Validating);
            this.tbClientID.Validated += new System.EventHandler(this.tbClientID_Validated);
            // 
            // lbClientID
            // 
            this.lbClientID.AutoSize = true;
            this.lbClientID.Location = new System.Drawing.Point(6, 43);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(78, 20);
            this.lbClientID.TabIndex = 16;
            this.lbClientID.Text = "Client ID: ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(10, 260);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(142, 47);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(99, 209);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(294, 26);
            this.dtpEndDate.TabIndex = 14;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(99, 166);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(294, 26);
            this.dtpStartDate.TabIndex = 13;
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Location = new System.Drawing.Point(6, 209);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(77, 20);
            this.lbEndDate.TabIndex = 12;
            this.lbEndDate.Text = "End Date";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Location = new System.Drawing.Point(6, 166);
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
            this.cbRoomType.Location = new System.Drawing.Point(99, 117);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 28);
            this.cbRoomType.TabIndex = 10;
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(6, 120);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(86, 20);
            this.lbRoomType.TabIndex = 9;
            this.lbRoomType.Text = "Room type";
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(99, 78);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(100, 26);
            this.tbFullName.TabIndex = 8;
            this.tbFullName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFullName_Validating);
            this.tbFullName.Validated += new System.EventHandler(this.tbFullName_Validated);
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(6, 78);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(86, 20);
            this.lbFullName.TabIndex = 7;
            this.lbFullName.Text = "Full name: ";
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epSubmit
            // 
            this.epSubmit.ContainerControl = this;
            // 
            // epClientId
            // 
            this.epClientId.ContainerControl = this;
            // 
            // ExistingClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbClient);
            this.Name = "ExistingClientForm";
            this.Text = "ExistingClientForm";
            this.Load += new System.EventHandler(this.ExistingClientForm_Load);
            this.gbClient.ResumeLayout(false);
            this.gbClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epClientId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbClient;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.TextBox tbClientID;
        private System.Windows.Forms.Label lbClientID;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epSubmit;
        private System.Windows.Forms.ErrorProvider epClientId;
    }
}