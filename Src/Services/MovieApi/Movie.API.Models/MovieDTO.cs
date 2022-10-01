using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.API.Models
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Rating { get; set; }
        public string  Genre { get; set; }

        public string DirectorFullName { get; set; }


    }
}
