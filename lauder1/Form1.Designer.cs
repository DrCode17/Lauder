namespace lauder1
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
            this.OK_btn = new System.Windows.Forms.Button();
            this.koszon_lbl = new System.Windows.Forms.Label();
            this.szam1_tb = new System.Windows.Forms.TextBox();
            this.szam2_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_btn
            // 
            this.OK_btn.Location = new System.Drawing.Point(649, 398);
            this.OK_btn.Name = "OK_btn";
            this.OK_btn.Size = new System.Drawing.Size(75, 23);
            this.OK_btn.TabIndex = 0;
            this.OK_btn.Text = "OK";
            this.OK_btn.UseVisualStyleBackColor = true;
            this.OK_btn.Click += new System.EventHandler(this.OK_btn_Click);
            // 
            // koszon_lbl
            // 
            this.koszon_lbl.AutoSize = true;
            this.koszon_lbl.Location = new System.Drawing.Point(48, 23);
            this.koszon_lbl.Name = "koszon_lbl";
            this.koszon_lbl.Size = new System.Drawing.Size(10, 16);
            this.koszon_lbl.TabIndex = 1;
            this.koszon_lbl.Text = " ";
            // 
            // szam1_tb
            // 
            this.szam1_tb.Location = new System.Drawing.Point(90, 152);
            this.szam1_tb.Name = "szam1_tb";
            this.szam1_tb.Size = new System.Drawing.Size(100, 22);
            this.szam1_tb.TabIndex = 2;
            // 
            // szam2_tb
            // 
            this.szam2_tb.Location = new System.Drawing.Point(233, 152);
            this.szam2_tb.Name = "szam2_tb";
            this.szam2_tb.Size = new System.Drawing.Size(100, 22);
            this.szam2_tb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.szam2_tb);
            this.Controls.Add(this.szam1_tb);
            this.Controls.Add(this.koszon_lbl);
            this.Controls.Add(this.OK_btn);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Első óra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_btn;
        private System.Windows.Forms.Label koszon_lbl;
        private System.Windows.Forms.TextBox szam1_tb;
        private System.Windows.Forms.TextBox szam2_tb;
    }
}

