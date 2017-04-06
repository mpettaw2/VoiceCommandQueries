namespace VRecognition
{
    partial class Form1
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
            this.gridStuff = new System.Windows.Forms.DataGridView();
            this.checkEnable = new System.Windows.Forms.CheckBox();
            this.serv = new System.Windows.Forms.TextBox();
            this.dbText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridStuff)).BeginInit();
            this.SuspendLayout();
            // 
            // gridStuff
            // 
            this.gridStuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStuff.Location = new System.Drawing.Point(27, 118);
            this.gridStuff.Name = "gridStuff";
            this.gridStuff.Size = new System.Drawing.Size(518, 324);
            this.gridStuff.TabIndex = 0;
            // 
            // checkEnable
            // 
            this.checkEnable.AutoSize = true;
            this.checkEnable.Location = new System.Drawing.Point(456, 458);
            this.checkEnable.Name = "checkEnable";
            this.checkEnable.Size = new System.Drawing.Size(89, 17);
            this.checkEnable.TabIndex = 2;
            this.checkEnable.Text = "checkEnable";
            this.checkEnable.UseVisualStyleBackColor = true;
            this.checkEnable.CheckedChanged += new System.EventHandler(this.checkEnable_CheckedChanged);
            // 
            // serv
            // 
            this.serv.Location = new System.Drawing.Point(102, 36);
            this.serv.Name = "serv";
            this.serv.Size = new System.Drawing.Size(100, 20);
            this.serv.TabIndex = 3;
            this.serv.Text = "LAPTOP-38MBSCBD\\\\LISASQL";
            // 
            // dbText
            // 
            this.dbText.Location = new System.Drawing.Point(102, 62);
            this.dbText.Name = "dbText";
            this.dbText.Size = new System.Drawing.Size(100, 20);
            this.dbText.TabIndex = 4;
            this.dbText.Text = "AdventureWorks2012";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Database";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 487);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbText);
            this.Controls.Add(this.serv);
            this.Controls.Add(this.checkEnable);
            this.Controls.Add(this.gridStuff);
            this.Name = "Form1";
            this.Text = "VoiceRecg";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridStuff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridStuff;
        private System.Windows.Forms.CheckBox checkEnable;
        private System.Windows.Forms.TextBox serv;
        private System.Windows.Forms.TextBox dbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

