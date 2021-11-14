namespace BulkSMS
{
    partial class Home
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
            this.buttonSingleSMS = new System.Windows.Forms.Button();
            this.buttonBulkSMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSingleSMS
            // 
            this.buttonSingleSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSingleSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSingleSMS.Location = new System.Drawing.Point(33, 72);
            this.buttonSingleSMS.Name = "buttonSingleSMS";
            this.buttonSingleSMS.Size = new System.Drawing.Size(100, 100);
            this.buttonSingleSMS.TabIndex = 0;
            this.buttonSingleSMS.Text = "Single Number";
            this.buttonSingleSMS.UseVisualStyleBackColor = true;
            this.buttonSingleSMS.Click += new System.EventHandler(this.buttonSingleSMS_Click);
            // 
            // buttonBulkSMS
            // 
            this.buttonBulkSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBulkSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBulkSMS.Location = new System.Drawing.Point(139, 72);
            this.buttonBulkSMS.Name = "buttonBulkSMS";
            this.buttonBulkSMS.Size = new System.Drawing.Size(100, 100);
            this.buttonBulkSMS.TabIndex = 1;
            this.buttonBulkSMS.Text = "Bulk Number";
            this.buttonBulkSMS.UseVisualStyleBackColor = true;
            this.buttonBulkSMS.Click += new System.EventHandler(this.buttonBulkSMS_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonBulkSMS);
            this.Controls.Add(this.buttonSingleSMS);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSingleSMS;
        private System.Windows.Forms.Button buttonBulkSMS;
    }
}