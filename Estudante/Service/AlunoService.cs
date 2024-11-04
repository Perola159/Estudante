using Estudante.Entidade;
using Estudante.Repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante.Service
{
    public class AlunoService
    {
        private readonly AlunoRepository repository;
        public AlunoService(IConfiguration _config)
        {
            repository = new AlunoRepository(_config);
        }
        public void Adicionar(Aluno aluno)
        {
            repository.Adicionar(aluno);
        }

        public List<Aluno> Listar()
        {
            return repository.Listar();
        }
    }
}
