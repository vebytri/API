using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository.Interface
{
    interface IPersonRepository
    {
        IEnumerable<Person> Get(); //show all data
        Person Get(int nik); // show 1 data
        int Insert(Person person); // insert data
        int Update(Person person); //update data
        int Delete(int nik); // delete data


    }
}
