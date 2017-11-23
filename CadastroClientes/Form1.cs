using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

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



            var frm = new FrmCadCliente();
            frm.MdiParent = this;
            frm.Show();



        }

      


        public void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Frmconsulta frm = new Frmconsulta();
            frm.MdiParent = this;
            frm.Show();

        }


        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)

        {
            Frmconsulta frm = new Frmconsulta();
            frm.MdiParent = this;
            frm.Show();


            try
            {
                String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jadson.Oliveira\Documents\Base.mdb";
                var conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL = "Select * from clientes";

                var adapter = new OleDbDataAdapter(SQL, conn);

                var ds = new DataSet();

                adapter.Fill(ds, "clientes");

                frm.DgResultado.DataSource = ds.Tables["clientes"];
            }
            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }
        }

        public void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Frmconsulta();
            frm.Show();
        }
    }
}
