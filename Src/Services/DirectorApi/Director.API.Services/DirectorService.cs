using Director.API.Infrastructore;
using Director.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Director.Api.Services
{
    public class DirectorService : IDirectorService
    {
        
        public DirectorDTO GetByIdDirector(int Id)
        {
            return new DirectorDTO()
            {

                Id = Id,
                FirstName = "Cristopher",
                LastName = "NOLAN"

            };
        }
    }
}
