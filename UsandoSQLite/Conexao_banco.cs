//using System.Data.SQLite;
using MySql.Data.MySqlClient;
using System.Data; // para usar banco de dados importamos essas 2 libs

namespace UsandoSQLite
{

    public class Conexao_banco
    {
        //Variaveis globais
        //public static SQLiteDataAdapter adapter = null;
        public static DataTable dt = null;
        /*
         * algunhas maneiras de se conectar com o banco de dados sqlite3
         * --------------------------------------------------------------
            public static string banco = Environment.CurrentDirectory + @"\Banco\DataBase.db";
            public static string banco = System.AppDomain.CurrentDomain.BaseDirectory + @"\Banco\DataBase.db";
            public static string banco = Application.StartupPath + @"\Banco\DataBase.db";
            public string Conection_string = "Data Source = " + banco + "; Version = 3";
            public string Conection_string = "Data Source=DataBase.db; Version=3";
            public string Conection_string = Environment.CurrentDirectory + "Data Source=DataBase.db; Version=3";
            public string Conection_string = System.AppDomain.CurrentDomain.BaseDirectory + "Data Source=DataBase.db; Version=3";
        */

        /*
         Agora vamos se conectar com um banco de dados online
         url ou host => dbtesteluiz.mysql.uhserver.com
         password => l270815**
         DataBase => dbtesteluiz
         user =>     luiz_teste
        */

        string Conection_string = "SERVER=dbtesteluiz.mysql.uhserver.com; DATABASE=dbtesteluiz;                                     UID=luiz_teste; PWD=l270815**; PORT=";

        //public  SQLiteConnection conexao;  
        public MySqlConnection conexao;

        public string assunto { get; set; }
        public string assunto1 { get; set; }
        public string assunto2 { get; set; }
        public string turno { get; set; }
        public string turno1 { get; set; }
        public string turno2 { get; set; }
        public string operador { get; set; }
        public string operador1 { get; set; }
        public string operador2 { get; set; }



        //conectar ao banco de dados
        public void conectar()
        {
            //Comando usado para instanciar um objeto de conexão
            conexao = new MySqlConnection(Conection_string);
            conexao.Open();
        }

        //comando para fechar a conexão
        public void desconectar()
        {
            conexao = new MySqlConnection(Conection_string);
            conexao.Close();
            conexao.Dispose();
            //return conexao;
        }

        public void deletar(string chave)
        {
            conexao = new MySqlConnection(Conection_string);
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand(chave, conexao);
            cmd.Connection = conexao;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conexao.Close();
        }

        public void Salvar(string sql)
        {
            conexao = new MySqlConnection(Conection_string);
            conexao.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Connection = conexao;
            //cmd.CommandText= sql;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conexao.Close();
        }

        public void salvar_assunto(string sql)
        {
            conectar();
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Connection = conexao;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            desconectar();
        }

        public void Buscar_assunto(string sql)
        {
            conectar();
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Connection = conexao;
            MySqlDataReader dr = cmd.ExecuteReader();
            cmd.Dispose();

            while (dr.Read())
            {
                assunto = dr["Assunto"].ToString();
                operador = dr["Operador"].ToString();
                turno = dr["Turno"].ToString();
            }
        }

        public void Update(string sql)
        {
            conectar();
            MySqlCommand cmd = new MySqlCommand(sql, conexao);
            cmd.Connection = conexao;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public void Buscar_admin(string sql)
        {
            conectar();
            MySqlDataAdapter sda = new MySqlDataAdapter(sql, conexao);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                assunto = dt.Rows[0][0].ToString();
                operador = dt.Rows[0][1].ToString();
                turno = dt.Rows[0][2].ToString();
            }

            if (dt.Rows.Count >= 2)
            {
                assunto1 = dt.Rows[1][0].ToString();
                operador1 = dt.Rows[1][1].ToString();
                turno1 = dt.Rows[1][2].ToString();
            }

            if (dt.Rows.Count >= 3)
            {
                assunto2 = dt.Rows[2][0].ToString();
                operador2 = dt.Rows[2][1].ToString();
                turno2 = dt.Rows[2][2].ToString();
            }


        }
    }


}
