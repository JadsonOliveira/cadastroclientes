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
    public partial class FrmCadCliente : Form
    {
        internal Form1 mdiparent;

        

        public FrmCadCliente()
        {
            InitializeComponent();
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String Stringcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Jadson.Oliveira\Documents\Base.mdb";
                var conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL;

                SQL = "Insert Into clientes(Nome,DataNasc,Telefone,Email,Endereco)Values ";
                SQL += "('"+Nome.Text+"','"+DataNasc.Text+"', '"+Telefone.Text+"','"+Email.Text+"', '"+Endereco.Text+"')";

                var cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrados com Sucesso !!!!");
                Nome.Clear();
                Telefone.Clear();
                DataNasc.Clear();
                Email.Clear();
                Endereco.Clear();

                conn.Close();

            }
            catch (Exception erro)
            
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void btnalteracao_Click(object sender, EventArgs e)
        {
            try
            {
                String Stringcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Jadson.Oliveira\Documents\Base.mdb";
                var conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL;

                SQL = "update clientes(Nome,DataNasc,Telefone,Email,Endereco)Values ";
                SQL += "('" + Nome.Text + "','" + DataNasc.Text + "', '" + Telefone.Text + "','" + Email.Text + "', '" + Endereco.Text + "')";

                var cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Cadastrados com Sucesso !!!!");
                Nome.Clear();
                Telefone.Clear();
                DataNasc.Clear();
                Email.Clear();
                Endereco.Clear();

                conn.Close();

            }
            catch (Exception erro)

            {
                MessageBox.Show(erro.Message);
            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
