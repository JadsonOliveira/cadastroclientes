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

        public String Codigo;


        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        public void BtnConsulta_Click(object sender, EventArgs e)
        {
            CarregarClientes();
        }

        public void CarregarClientes()
        {
            try
            {
                String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jadson.Oliveira\Documents\Base.mdb";
                var conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL = "Select * from clientes";

                var adapter = new OleDbDataAdapter(SQL, conn);

                var ds = new DataSet();

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

        public void AlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmCadCliente();
            Codigo = DgResultado.SelectedCells[0].Value.ToString();
            frm.Nome.Text = DgResultado.SelectedCells[1].Value.ToString();
            frm.Email.Text = DgResultado.SelectedCells[2].Value.ToString();
            frm.Telefone.Text = DgResultado.SelectedCells[3].Value.ToString();
            frm.Endereco.Text = DgResultado.SelectedCells[4].Value.ToString();
            frm.DataNasc.Text = DgResultado.SelectedCells[5].Value.ToString();
            frm.BtnCad.Visible = false;
            frm.btnalteracao.Visible = true;
            frm.ShowDialog();

        }

        
        
            FrmCadCliente frm = new FrmCadCliente();
            
        

        public void BtnAlteracao2_Click(object sender, EventArgs e)
        {
            try
            {
                String Stringcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Jadson.Oliveira\Documents\Base.mdb";
                var conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL;

                SQL = "update clientes set nome = '" + frm.Nome + "',";
                SQL += "telefone '" + frm.Telefone + "',";
                SQL += "Email '" + frm.Email + "',";
                SQL += "Endereco '" + frm.Endereco + "',";
                SQL += "DataNasc '" + frm.DataNasc + "',";
                SQL += "where Codigo '" + Codigo + "',";





                var cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrados com Sucesso !!!!");
                frm.Nome.Clear();
                frm.Telefone.Clear();
                frm.DataNasc.Clear();
                frm.Email.Clear();
                frm.Endereco.Clear();

                conn.Close();

            }
            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String Stringcon = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Jadson.Oliveira\Documents\Base.mdb";
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

        private void Frmconsulta_Load(object sender, EventArgs e)
        {
            CarregarClientes();
        }
    }
}
