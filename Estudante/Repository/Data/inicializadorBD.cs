using System.Data.SQLite;

namespace Estudante.Repository.Data
{
    public class inicializadorBD
    {

        private const string ConnectionString = "Data Source=Supermercado.db";

        public static void Inicializar()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Estudantes(
                 Altura REAL NOT NULL
                 Peso REAL NOT NULL
                 Idade INTEGER NOT NULL
                 Nome TEXT NOT NULL,
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                );";
            }

        }
    }
}
