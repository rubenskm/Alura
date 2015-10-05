using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsumindoServico.ClientService;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ClienteServiceClient();
                var cliente = new Cliente();
                cliente.CPF = txtCPF.Text;
                cliente.Nome = txtNome.Text;
                service.Add(cliente);

                MessageBox.Show("Cliente adicionado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                var service = new ClienteServiceClient();
                var result = service.Search(txtNome.Text);

                if (result != null)
                {
                    txtCPF.Text = result.CPF;
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
