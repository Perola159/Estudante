using Estudante.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante.Service.Service_Interface
{
    public interface IAlunoService
    {
        public void Adicionar(Aluno aluno);
        public List<Aluno> Listar();
        public void Editar(Aluno editAluno);


        public void Remover(int id);

    }
}
