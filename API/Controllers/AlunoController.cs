using Estudante.Entidade;
using Estudante.Service;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoService _service;

        public AlunoController(IConfiguration config)
        {
            _service = new AlunoService(config);
            

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

    }
}
