namespace CadastroClientes
{
  partial class FrmCadastroClientes
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.txtCodigo = new System.Windows.Forms.TextBox();
      this.txtNome = new System.Windows.Forms.TextBox();
      this.txtTelefone = new System.Windows.Forms.TextBox();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.btnGravar = new System.Windows.Forms.Button();
      this.btnAbrir = new System.Windows.Forms.Button();
      this.btnLimpar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Código";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 73);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Nome";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 113);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Telefone";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(26, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(32, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Email";
      // 
      // txtCodigo
      // 
      this.txtCodigo.Location = new System.Drawing.Point(93, 23);
      this.txtCodigo.Name = "txtCodigo";
      this.txtCodigo.Size = new System.Drawing.Size(100, 20);
      this.txtCodigo.TabIndex = 4;
      // 
      // txtNome
      // 
      this.txtNome.Location = new System.Drawing.Point(93, 65);
      this.txtNome.Name = "txtNome";
      this.txtNome.Size = new System.Drawing.Size(225, 20);
      this.txtNome.TabIndex = 5;
      // 
      // txtTelefone
      // 
      this.txtTelefone.Location = new System.Drawing.Point(93, 105);
      this.txtTelefone.Name = "txtTelefone";
      this.txtTelefone.Size = new System.Drawing.Size(136, 20);
      this.txtTelefone.TabIndex = 6;
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(93, 148);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(189, 20);
      this.txtEmail.TabIndex = 7;
      // 
      // btnGravar
      // 
      this.btnGravar.Location = new System.Drawing.Point(29, 188);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(75, 23);
      this.btnGravar.TabIndex = 8;
      this.btnGravar.Text = "Gravar";
      this.btnGravar.UseVisualStyleBackColor = true;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // btnAbrir
      // 
      this.btnAbrir.Location = new System.Drawing.Point(127, 188);
      this.btnAbrir.Name = "btnAbrir";
      this.btnAbrir.Size = new System.Drawing.Size(75, 23);
      this.btnAbrir.TabIndex = 9;
      this.btnAbrir.Text = "Abrir";
      this.btnAbrir.UseVisualStyleBackColor = true;
      this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
      // 
      // btnLimpar
      // 
      this.btnLimpar.Location = new System.Drawing.Point(221, 188);
      this.btnLimpar.Name = "btnLimpar";
      this.btnLimpar.Size = new System.Drawing.Size(75, 23);
      this.btnLimpar.TabIndex = 10;
      this.btnLimpar.Text = "Limpar";
      this.btnLimpar.UseVisualStyleBackColor = true;
      this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
      // 
      // FrmCadastroClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(348, 231);
      this.Controls.Add(this.btnLimpar);
      this.Controls.Add(this.btnAbrir);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtTelefone);
      this.Controls.Add(this.txtNome);
      this.Controls.Add(this.txtCodigo);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FrmCadastroClientes";
      this.Text = "Cadastro de Clientes";
      this.Load += new System.EventHandler(this.FrmCadastroClientes_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtCodigo;
    private System.Windows.Forms.TextBox txtNome;
    private System.Windows.Forms.TextBox txtTelefone;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.Button btnAbrir;
    private System.Windows.Forms.Button btnLimpar;
  }
}

