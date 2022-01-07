using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public class EProgramadorException: Exception
    {

    }

    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Estagiario(string tarefa)
        {
            Convert.ToDateTime(tarefa);
        }

        private void Programador(string tarefa)
        {
            Estagiario(tarefa);
        }

        private void Lider(string tarefa)
        {
            try
            {
                Programador(tarefa);
            }
            catch (FormatException E)
            {
                listBox1.Items.Add("Erro tratado pelo líder: " + E.Message);
                throw new EProgramadorException();
            }        
        }

        private void Gerente(string tarefa)
        {
            Lider(tarefa);
        }

        private void btnInvocar_Click(object sender, EventArgs e)
        {
            string tarefa = "criar aplicativo";
            Gerente(tarefa);
        }
    }
}
