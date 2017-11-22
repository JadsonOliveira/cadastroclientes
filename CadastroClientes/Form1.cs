using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            

            FrmCadCliente Frm = new FrmCadCliente();
            Frm.MdiParent = this;
            Frm.Show();




        }

       

        public void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            Frmconsulta frm = new Frmconsulta();
            frm.MdiParent = this;
            frm.Show();

        }

    }
}
