using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroClientes
{
    public class ClienteDB
    {
        public string TxtNome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Codigo { get; set; }

        public ClienteDB(string nome, string telefone, string email, string dataNasc, string endereco, string codigo)
        {
            this.TxtNome = nome;
            this.Telefone = telefone;
            this.Email = email;
            this.DataNasc = dataNasc;
            this.Endereco = endereco;
            this.Codigo = codigo;
        }

        public void Alterar()
        {
            try
            {
                String Stringcon = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\Users\Jadson.Oliveira\Documents\Base2.accdb";
                OleDbConnection conn = new OleDbConnection(Stringcon);
                conn.Open();

                String SQL;

                SQL = @"Update clientes set Nome = '" + TxtNome + "',";
                SQL += @"Update clientes set Telefone = '" + Telefone + "',";
                SQL += @"Update clientes set Email = '" + Email+ "',";
                SQL += @"Update clientes set DataNasc = '" + DataNasc + "',";
                SQL += @"Update clientes set Endereco = '" + Endereco + "' ";
                SQL += @"where Codigo = " + Codigo;

               OleDbCommand cmd = new OleDbCommand(SQL, conn);

                cmd.ExecuteNonQuery();

                conn.Close();

            }
            catch (Exception erro)
            {
            }
        }
    }
}
