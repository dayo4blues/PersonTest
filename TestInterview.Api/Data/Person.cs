using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestInterview.Api.Model;

namespace TestInterview.Api.Data
{
    public class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfbirth { get; set; }
        public int Age { get; set; }


        public async Task<PersonModel> GetById(int Id)
        {
            return Persons.FirstOrDefault(x => x.Id == Id);
        }

        public async Task<List<PersonModel>> Insert(PersonModel model)
        {            
            Persons.Add(new PersonModel { Id = model.Id, Age = model.Age, DateOfbirth = model.DateOfbirth, Name = model.Name });
            return Persons;
        }

        public async Task<List<PersonModel>> ListPerson()
        {
            return Persons;
        }

        

        private List<PersonModel> Persons = new List<PersonModel>();
    }
}
