namespace Assignment14
{
    partial class AddReservationForm
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExisting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(12, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(159, 84);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New Client";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExisting
            // 
            this.btnExisting.Location = new System.Drawing.Point(177, 12);
            this.btnExisting.Name = "btnExisting";
            this.btnExisting.Size = new System.Drawing.Size(153, 84);
            this.btnExisting.TabIndex = 1;
            this.btnExisting.Text = "Existing Client";
            this.btnExisting.UseVisualStyleBackColor = true;
            this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
            // 
            // AddReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 116);
            this.Controls.Add(this.btnExisting);
            this.Controls.Add(this.btnNew);
            this.Name = "AddReservationForm";
            this.Text = "AddReservation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExisting;
    }
}