using Estudante.Entidade;
using Estudante.Repository;
using Estudante.Repository.Repository_Interface;
using Estudante.Service.Service_Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudante.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly  IAlunoRepository repository;
        public AlunoService(IAlunoRepository _config)
        {
            repository = _config;
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
