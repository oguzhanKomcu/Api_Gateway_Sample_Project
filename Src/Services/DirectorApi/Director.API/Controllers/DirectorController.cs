using Director.API.Infrastructore;
using Director.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Director.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorService directorService;

        public DirectorController(IDirectorService directorService)
        {
            this.directorService = directorService;
        }


        [HttpGet("{Id}")]
        public DirectorDTO GetByIdDirector(int Id)
        {
            return directorService.GetByIdDirector(Id);
        }

    }
}
