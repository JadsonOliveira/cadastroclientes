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
    public partial class Frmconsulta : Form
    {
        public Frmconsulta()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            try
            {
                String Stringcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Jadson.Oliveira\Documents\Base2.accdb";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL = "Select * from clientes";

                OleDbDataAdapter adapter = new OleDbDataAdapter(SQL, conn);

                DataSet ds = new DataSet();

                adapter.Fill(ds, "clientes");

                DgResultado.DataSource = ds.Tables["clientes"];



            }


            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }
        }

        private void DgResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AbrirTelaAlterar();

        }

        private void AbrirTelaAlterar()
        {
            FrmCadCliente frm = new FrmCadCliente();
            frm.Codigo = DgResultado.SelectedCells[0].Value.ToString();
            frm.Nome.Text = DgResultado.SelectedCells[1].Value.ToString();
            frm.Email.Text = DgResultado.SelectedCells[2].Value.ToString();
            frm.Telefone.Text = DgResultado.SelectedCells[3].Value.ToString();
            frm.Endereco.Text = DgResultado.SelectedCells[4].Value.ToString();
            frm.DataNasc.Text = DgResultado.SelectedCells[5].Value.ToString();
            frm.BtnCad.Visible = false;
            frm.btnalteracao.Visible = true;
            frm.ShowDialog();
        }

        private void BtnAlteracao2_Click(object sender, EventArgs e)
        {
            AbrirTelaAlterar();
            BtnConsulta_Click(sender, e);
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String Stringcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Jadson.Oliveira\Documents\Base.accdb";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();
                String cod = DgResultado.SelectedCells[0].Value.ToString();
                String SQL = "Delete from clientes where codigo =  " +cod;

                OleDbCommand cmd = new OleDbCommand(SQL, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados apagados com sucesso");

                BtnConsulta_Click(sender, e);

              
            }
            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
