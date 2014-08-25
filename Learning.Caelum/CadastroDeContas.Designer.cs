namespace Caelum.CaixaEletronico
{
	partial class CadastroDeContas
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
			this.titularConta = new System.Windows.Forms.TextBox();
			this.numeroConta = new System.Windows.Forms.TextBox();
			this.CadastrarBtn = new System.Windows.Forms.Button();
			this.cboContas = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// titularConta
			// 
			this.titularConta.Location = new System.Drawing.Point(75, 44);
			this.titularConta.Name = "titularConta";
			this.titularConta.Size = new System.Drawing.Size(100, 20);
			this.titularConta.TabIndex = 0;
			// 
			// numeroConta
			// 
			this.numeroConta.Location = new System.Drawing.Point(75, 83);
			this.numeroConta.Name = "numeroConta";
			this.numeroConta.Size = new System.Drawing.Size(100, 20);
			this.numeroConta.TabIndex = 1;
			// 
			// CadastrarBtn
			// 
			this.CadastrarBtn.Location = new System.Drawing.Point(198, 221);
			this.CadastrarBtn.Name = "CadastrarBtn";
			this.CadastrarBtn.Size = new System.Drawing.Size(75, 23);
			this.CadastrarBtn.TabIndex = 2;
			this.CadastrarBtn.Text = "Cadastrar";
			this.CadastrarBtn.UseVisualStyleBackColor = true;
			this.CadastrarBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// cboContas
			// 
			this.cboContas.FormattingEnabled = true;
			this.cboContas.Location = new System.Drawing.Point(75, 13);
			this.cboContas.Name = "cboContas";
			this.cboContas.Size = new System.Drawing.Size(121, 21);
			this.cboContas.TabIndex = 3;
			// 
			// CadastroDeContas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.cboContas);
			this.Controls.Add(this.CadastrarBtn);
			this.Controls.Add(this.numeroConta);
			this.Controls.Add(this.titularConta);
			this.Name = "CadastroDeContas";
			this.Text = "CadastroDeContas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox titularConta;
		private System.Windows.Forms.TextBox numeroConta;
		private System.Windows.Forms.Button CadastrarBtn;
		private System.Windows.Forms.ComboBox cboContas;
	}
}