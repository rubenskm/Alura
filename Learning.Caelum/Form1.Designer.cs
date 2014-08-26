namespace Caelum.CaixaEletronico
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
			this.textoTitular = new System.Windows.Forms.TextBox();
			this.comboContas = new System.Windows.Forms.ComboBox();
			this.destinoDaTrans = new System.Windows.Forms.ComboBox();
			this.SaqueBtn = new System.Windows.Forms.Button();
			this.DepositoBtn = new System.Windows.Forms.Button();
			this.TransferenciaBtn = new System.Windows.Forms.Button();
			this.textoSaldo = new System.Windows.Forms.TextBox();
			this.textoValor = new System.Windows.Forms.TextBox();
			this.textoNumero = new System.Windows.Forms.TextBox();
			this.cadastrarBtn = new System.Windows.Forms.Button();
			this.btnRemover = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textoTitular
			// 
			this.textoTitular.Location = new System.Drawing.Point(85, 48);
			this.textoTitular.Name = "textoTitular";
			this.textoTitular.Size = new System.Drawing.Size(100, 20);
			this.textoTitular.TabIndex = 0;
			// 
			// comboContas
			// 
			this.comboContas.FormattingEnabled = true;
			this.comboContas.Location = new System.Drawing.Point(85, 12);
			this.comboContas.Name = "comboContas";
			this.comboContas.Size = new System.Drawing.Size(121, 21);
			this.comboContas.TabIndex = 1;
			this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
			// 
			// destinoDaTrans
			// 
			this.destinoDaTrans.FormattingEnabled = true;
			this.destinoDaTrans.Location = new System.Drawing.Point(85, 167);
			this.destinoDaTrans.Name = "destinoDaTrans";
			this.destinoDaTrans.Size = new System.Drawing.Size(121, 21);
			this.destinoDaTrans.TabIndex = 2;
			// 
			// SaqueBtn
			// 
			this.SaqueBtn.Location = new System.Drawing.Point(197, 214);
			this.SaqueBtn.Name = "SaqueBtn";
			this.SaqueBtn.Size = new System.Drawing.Size(75, 23);
			this.SaqueBtn.TabIndex = 3;
			this.SaqueBtn.Text = "Saque";
			this.SaqueBtn.UseVisualStyleBackColor = true;
			this.SaqueBtn.Click += new System.EventHandler(this.SaqueBtn_Click);
			// 
			// DepositoBtn
			// 
			this.DepositoBtn.Location = new System.Drawing.Point(97, 214);
			this.DepositoBtn.Name = "DepositoBtn";
			this.DepositoBtn.Size = new System.Drawing.Size(75, 23);
			this.DepositoBtn.TabIndex = 4;
			this.DepositoBtn.Text = "Depósito";
			this.DepositoBtn.UseVisualStyleBackColor = true;
			this.DepositoBtn.Click += new System.EventHandler(this.DepositoBtn_Click);
			// 
			// TransferenciaBtn
			// 
			this.TransferenciaBtn.Location = new System.Drawing.Point(3, 214);
			this.TransferenciaBtn.Name = "TransferenciaBtn";
			this.TransferenciaBtn.Size = new System.Drawing.Size(88, 23);
			this.TransferenciaBtn.TabIndex = 5;
			this.TransferenciaBtn.Text = "Transferência";
			this.TransferenciaBtn.UseVisualStyleBackColor = true;
			this.TransferenciaBtn.Click += new System.EventHandler(this.TransferenciaBtn_Click);
			// 
			// textoSaldo
			// 
			this.textoSaldo.Location = new System.Drawing.Point(85, 100);
			this.textoSaldo.Name = "textoSaldo";
			this.textoSaldo.Size = new System.Drawing.Size(100, 20);
			this.textoSaldo.TabIndex = 6;
			// 
			// textoValor
			// 
			this.textoValor.Location = new System.Drawing.Point(85, 126);
			this.textoValor.Name = "textoValor";
			this.textoValor.Size = new System.Drawing.Size(100, 20);
			this.textoValor.TabIndex = 7;
			// 
			// textoNumero
			// 
			this.textoNumero.Location = new System.Drawing.Point(85, 74);
			this.textoNumero.Name = "textoNumero";
			this.textoNumero.Size = new System.Drawing.Size(100, 20);
			this.textoNumero.TabIndex = 8;
			// 
			// cadastrarBtn
			// 
			this.cadastrarBtn.Location = new System.Drawing.Point(3, 243);
			this.cadastrarBtn.Name = "cadastrarBtn";
			this.cadastrarBtn.Size = new System.Drawing.Size(98, 23);
			this.cadastrarBtn.TabIndex = 9;
			this.cadastrarBtn.Text = "CadastrarConta";
			this.cadastrarBtn.UseVisualStyleBackColor = true;
			this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
			// 
			// btnRemover
			// 
			this.btnRemover.Location = new System.Drawing.Point(119, 243);
			this.btnRemover.Name = "btnRemover";
			this.btnRemover.Size = new System.Drawing.Size(95, 23);
			this.btnRemover.TabIndex = 10;
			this.btnRemover.Text = "RemoverConta";
			this.btnRemover.UseVisualStyleBackColor = true;
			this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 275);
			this.Controls.Add(this.btnRemover);
			this.Controls.Add(this.cadastrarBtn);
			this.Controls.Add(this.textoNumero);
			this.Controls.Add(this.textoValor);
			this.Controls.Add(this.textoSaldo);
			this.Controls.Add(this.TransferenciaBtn);
			this.Controls.Add(this.DepositoBtn);
			this.Controls.Add(this.SaqueBtn);
			this.Controls.Add(this.destinoDaTrans);
			this.Controls.Add(this.comboContas);
			this.Controls.Add(this.textoTitular);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textoTitular;
		private System.Windows.Forms.ComboBox comboContas;
		private System.Windows.Forms.ComboBox destinoDaTrans;
		private System.Windows.Forms.Button SaqueBtn;
		private System.Windows.Forms.Button DepositoBtn;
		private System.Windows.Forms.Button TransferenciaBtn;
		private System.Windows.Forms.TextBox textoSaldo;
		private System.Windows.Forms.TextBox textoValor;
		private System.Windows.Forms.TextBox textoNumero;
		private System.Windows.Forms.Button cadastrarBtn;
		private System.Windows.Forms.Button btnRemover;
	}
}