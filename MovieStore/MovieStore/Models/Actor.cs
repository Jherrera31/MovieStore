using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieStore.Infrastructure;
namespace MovieStore.Models
{
    public class Actor: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}