using Dapper.Contrib.Extensions;
using Estudante.Entidade;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante.Repository.Repository_Interface
{
    public interface IAlunoRepository
    {

        public void Adicionar(Aluno aluno);

        public List<Aluno> Listar();

        public void Remover(int id);

        public void Editar(Aluno aluno);

        public Aluno BuscarPorId(int id);
       
    }
}
