using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestInterview.Api.Model;

namespace TestInterview.Api.Data
{
    public interface IPerson
    {
        Task<PersonModel> GetById(int Id);
        Task<List<PersonModel>> Insert(PersonModel model);
        Task<List<PersonModel>> ListPerson();
    }
}
