namespace Assignment14
{
    partial class AddRoomForm
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
            this.gbRoom = new System.Windows.Forms.GroupBox();
            this.lbRoomId = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.tbRoomId = new System.Windows.Forms.TextBox();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.epRoomId = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRoomId)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRoom
            // 
            this.gbRoom.Controls.Add(this.btnAdd);
            this.gbRoom.Controls.Add(this.cbRoomType);
            this.gbRoom.Controls.Add(this.tbRoomId);
            this.gbRoom.Controls.Add(this.lbRoomType);
            this.gbRoom.Controls.Add(this.lbRoomId);
            this.gbRoom.Location = new System.Drawing.Point(12, 12);
            this.gbRoom.Name = "gbRoom";
            this.gbRoom.Size = new System.Drawing.Size(339, 184);
            this.gbRoom.TabIndex = 0;
            this.gbRoom.TabStop = false;
            this.gbRoom.Text = "Add room";
            // 
            // lbRoomId
            // 
            this.lbRoomId.AutoSize = true;
            this.lbRoomId.Location = new System.Drawing.Point(16, 36);
            this.lbRoomId.Name = "lbRoomId";
            this.lbRoomId.Size = new System.Drawing.Size(77, 20);
            this.lbRoomId.TabIndex = 0;
            this.lbRoomId.Text = "RoomID: ";
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(20, 76);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(94, 20);
            this.lbRoomType.TabIndex = 1;
            this.lbRoomType.Text = "Room type: ";
            // 
            // tbRoomId
            // 
            this.tbRoomId.Location = new System.Drawing.Point(99, 36);
            this.tbRoomId.Name = "tbRoomId";
            this.tbRoomId.Size = new System.Drawing.Size(100, 26);
            this.tbRoomId.TabIndex = 2;
            this.tbRoomId.Validating += new System.ComponentModel.CancelEventHandler(this.tbRoomId_Validating);
            this.tbRoomId.Validated += new System.EventHandler(this.tbRoomId_Validated);
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
            this.cbRoomType.Location = new System.Drawing.Point(121, 76);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 28);
            this.cbRoomType.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(186, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 53);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add room";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // epRoomId
            // 
            this.epRoomId.ContainerControl = this;
            // 
            // AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 208);
            this.Controls.Add(this.gbRoom);
            this.Name = "AddRoom";
            this.Text = "AddRoom";
            this.gbRoom.ResumeLayout(false);
            this.gbRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epRoomId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRoom;
        private System.Windows.Forms.Label lbRoomId;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.TextBox tbRoomId;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider epRoomId;
    }
}