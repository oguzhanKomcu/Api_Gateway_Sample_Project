using Movie.API.Infrastructure;
using Movie.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.API.Services
{
    public class MovieService : IMovieService
    {
        public MovieDTO GetByIdMovie(int Id)
        {
            return new MovieDTO()
            {
                Id = Id,
                Name = "Instraller",
                DirectorFullName = "Cristopher NOLAN",
                Genre = "Science Fiction",
                Rating = "8.5"



            };
        }
    }
}
