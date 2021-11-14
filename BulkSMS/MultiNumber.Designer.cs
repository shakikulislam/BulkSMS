namespace BulkSMS
{
    partial class MultiNumber
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxModemList = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.dataGridViewNumberList = new System.Windows.Forms.DataGridView();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBrows = new System.Windows.Forms.Button();
            this.textBoxWorksheet = new System.Windows.Forms.TextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumberList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Modem";
            // 
            // comboBoxModemList
            // 
            this.comboBoxModemList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModemList.FormattingEnabled = true;
            this.comboBoxModemList.Location = new System.Drawing.Point(179, 12);
            this.comboBoxModemList.Name = "comboBoxModemList";
            this.comboBoxModemList.Size = new System.Drawing.Size(343, 21);
            this.comboBoxModemList.TabIndex = 14;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(600, 272);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 13;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Message";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(400, 107);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(275, 159);
            this.richTextBoxMessage.TabIndex = 9;
            this.richTextBoxMessage.Text = "";
            // 
            // dataGridViewNumberList
            // 
            this.dataGridViewNumberList.AllowUserToAddRows = false;
            this.dataGridViewNumberList.AllowUserToDeleteRows = false;
            this.dataGridViewNumberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNumberList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sl,
            this.name,
            this.number,
            this.status});
            this.dataGridViewNumberList.Location = new System.Drawing.Point(12, 99);
            this.dataGridViewNumberList.Name = "dataGridViewNumberList";
            this.dataGridViewNumberList.ReadOnly = true;
            this.dataGridViewNumberList.Size = new System.Drawing.Size(321, 174);
            this.dataGridViewNumberList.TabIndex = 16;
            this.dataGridViewNumberList.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewNumberList_RowPostPaint);
            // 
            // sl
            // 
            this.sl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sl.HeaderText = "#";
            this.sl.Name = "sl";
            this.sl.ReadOnly = true;
            this.sl.Width = 39;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 60;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.number.HeaderText = "Number";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Width = 69;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 62;
            // 
            // buttonBrows
            // 
            this.buttonBrows.Location = new System.Drawing.Point(12, 47);
            this.buttonBrows.Name = "buttonBrows";
            this.buttonBrows.Size = new System.Drawing.Size(80, 23);
            this.buttonBrows.TabIndex = 17;
            this.buttonBrows.Text = "Brows Excel";
            this.buttonBrows.UseVisualStyleBackColor = true;
            this.buttonBrows.Click += new System.EventHandler(this.buttonBrows_Click);
            // 
            // textBoxWorksheet
            // 
            this.textBoxWorksheet.Location = new System.Drawing.Point(93, 73);
            this.textBoxWorksheet.Name = "textBoxWorksheet";
            this.textBoxWorksheet.Size = new System.Drawing.Size(100, 20);
            this.textBoxWorksheet.TabIndex = 18;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(199, 71);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 19;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "SheetName";
            // 
            // MultiNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxWorksheet);
            this.Controls.Add(this.buttonBrows);
            this.Controls.Add(this.dataGridViewNumberList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxModemList);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxMessage);
            this.Name = "MultiNumber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Multi Number / Bulk SMS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNumberList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModemList;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.DataGridView dataGridViewNumberList;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button buttonBrows;
        private System.Windows.Forms.TextBox textBoxWorksheet;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
    }
}