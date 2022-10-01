using Movie.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.API.Infrastructure
{
    public interface IMovieService
    {
        MovieDTO GetByIdMovie(int Id);
    }
}
