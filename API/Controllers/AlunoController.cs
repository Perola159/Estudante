using Estudante.Entidade;
using Estudante.Service;
using Estudante.Service.Service_Interface;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _service;

        public AlunoController(IAlunoService config)
        {
            _service = config;
        }

        [HttpPost("Adicionar-Aluno")]
        public void AdicionarAluno(Aluno alun)
        {
            _service.Adicionar(alun);
        }

        [HttpGet("Listar-Aluno")]
        public List<Aluno> ListarAluno()
        {
            return _service.Listar();
        }

        [HttpPut("editar-Aluno")]
        public void EditarAluno(Aluno p)
        {
            _service.Editar(p);
        }


        [HttpDelete("deletar-Aluno")]
        public void DeletarAluno(int id)
        {
            _service.Remover(id);
        }
    }
}
