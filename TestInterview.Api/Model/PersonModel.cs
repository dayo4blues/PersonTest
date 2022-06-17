using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestInterview.Api.Model
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfbirth { get; set; }
        public int Age { get; set; }
    }
}
