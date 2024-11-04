using Dapper;
using System.Data.SQLite;

namespace Estudante.Repository.Data
{
    public static class inicializadorBD
    {
        public static void Inicializar()
        {
            using var connection = new SQLiteConnection("Data Source=Escola.db");

            string commandoSQL = @"   
                 CREATE TABLE IF NOT EXISTS Alunos( 
                 Id INTEGER PRIMARY KEY AUTOINCREMENT,
                 Nome TEXT NOT NULL,
                 Altura REAL NOT NULL,
                 Peso REAL NOT NULL,
                 Idade INTEGER NOT NULL
                );";

            connection.Execute(commandoSQL);

        }
    }   
}
