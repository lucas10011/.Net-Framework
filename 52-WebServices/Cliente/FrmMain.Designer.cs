namespace Cliente
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnInvocarWebService = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 58);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(185, 20);
            this.txtResultado.TabIndex = 0;
            // 
            // btnInvocarWebService
            // 
            this.btnInvocarWebService.Location = new System.Drawing.Point(12, 12);
            this.btnInvocarWebService.Name = "btnInvocarWebService";
            this.btnInvocarWebService.Size = new System.Drawing.Size(75, 23);
            this.btnInvocarWebService.TabIndex = 1;
            this.btnInvocarWebService.Text = "Invocar";
            this.btnInvocarWebService.UseVisualStyleBackColor = true;
            this.btnInvocarWebService.Click += new System.EventHandler(this.btnInvocarWebService_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 191);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnInvocarWebService);
            this.Controls.Add(this.txtResultado);
            this.Name = "FrmMain";
            this.Text = "Cliente Web Service";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnInvocarWebService;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

