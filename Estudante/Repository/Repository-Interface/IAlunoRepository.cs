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
        
    }
}
