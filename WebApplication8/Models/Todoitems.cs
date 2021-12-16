using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class Todoitems
    {



        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)] //we need Date only

        public DateTime ReleaseDate { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }




    }
}

