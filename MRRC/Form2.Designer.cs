namespace MRRC
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.reportRt = new System.Windows.Forms.RichTextBox();
            this.Reportbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportRt
            // 
            this.reportRt.Location = new System.Drawing.Point(12, 12);
            this.reportRt.Name = "reportRt";
            this.reportRt.Size = new System.Drawing.Size(801, 474);
            this.reportRt.TabIndex = 0;
            this.reportRt.Text = "";
            // 
            // Reportbtn
            // 
            this.Reportbtn.Location = new System.Drawing.Point(738, 492);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(75, 23);
            this.Reportbtn.TabIndex = 1;
            this.Reportbtn.Text = "Close";
            this.Reportbtn.UseVisualStyleBackColor = true;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 527);
            this.Controls.Add(this.Reportbtn);
            this.Controls.Add(this.reportRt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Report Generated";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox reportRt;
        private System.Windows.Forms.Button Reportbtn;
    }
}