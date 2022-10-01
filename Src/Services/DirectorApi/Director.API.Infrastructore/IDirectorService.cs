using Director.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Director.API.Infrastructore
{
    public interface IDirectorService
    {
        public DirectorDTO GetByIdDirector(int Id);

    }
}
