using Dapper.Contrib.Extensions;
using Estudante.Entidade;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante.Repository
{
    public  class AlunoRepository
    {
        private readonly string ConnectionString;
        public AlunoRepository(IConfiguration connectioString)
        {
            ConnectionString = connectioString.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Aluno aluno)
        {
            using var connection = new SQLiteConnection(ConnectionString);
            connection.Insert<Aluno>(aluno);
        }

        public List<Aluno> Listar()
        {
            using var connection = new SQLiteConnection(ConnectionString);
            return connection.GetAll<Aluno>().ToList();
        }
    }
} 
