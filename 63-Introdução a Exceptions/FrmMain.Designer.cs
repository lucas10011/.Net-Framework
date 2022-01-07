namespace WinApp
{
    partial class FrmMain
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
            this.btnInvocar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnInvocar
            // 
            this.btnInvocar.Location = new System.Drawing.Point(21, 23);
            this.btnInvocar.Name = "btnInvocar";
            this.btnInvocar.Size = new System.Drawing.Size(75, 23);
            this.btnInvocar.TabIndex = 0;
            this.btnInvocar.Text = "Invocar";
            this.btnInvocar.UseVisualStyleBackColor = true;
            this.btnInvocar.Click += new System.EventHandler(this.btnInvocar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(361, 225);
            this.listBox1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 317);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnInvocar);
            this.Name = "FrmMain";
            this.Text = "Exceptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInvocar;
        private System.Windows.Forms.ListBox listBox1;
    }
}

