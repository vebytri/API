using API.Context;
using API.Models;
using API.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly MyContext conn;
        //public PersonRepository()
        //{
        //}

        public PersonRepository(MyContext conn)
        {
            this.conn = conn;
        }

        public int Delete(int nik)
        {
            //Person person = null;
            //int _isDeleted = 0;

            //person = conn.Persons
            //.Where(s => s.NIK == nik)
            //        .FirstOrDefault<Person>();

            //if (person != null)
            //{
            //    conn.Entry<Person>(person).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;

            //    conn.SaveChanges();
            //    _isDeleted = 1;
            //}

            //return _isDeleted;
            Person person = null;
            person =conn.Persons.Find(nik);
            if (person != null)
            {
                conn.Remove(person);
                conn.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
            


        }

        public IEnumerable<Person> Get()
        {
            return conn.Persons.ToList();
        }

        public Person Get(int nik)
        {
            //var findPerson = conn.Persons.ToList();
            //foreach (var item in findPerson)
            //{
            //    if (item.NIK == nik)
            //    {
            //        return item;
            //        break;
            //    }
            //}

            //Person person = null;
            //person = conn.Persons.Where(x => x.NIK == nik).FirstOrDefault<Person>();
           // return person;
            return conn.Persons.Find(nik);
        }

        public int Insert(Person person)
        {
            conn.Persons.Add(person);
            var result = conn.SaveChanges();
            return result;
        }

        public int Update(Person person)
        {
            //if (person != null)
            //{
            //    conn.Entry<Person>(person).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //    conn.SaveChanges();
            //}
            //Person temp = conn.Persons.Find(person.NIK);
            //temp.FirstName = person.FirstName;
            //temp.LastName = person.LastName;
            //temp.Email = person.Email;
            //temp.BirthDate = person.BirthDate;
            //temp.Phone = person.Phone;
            //temp.Salary = person.Salary;
            var temp = conn.Persons.Single(p => p.NIK == person.NIK);
            if (person.FirstName!="")
            {
            temp.FirstName = person.FirstName;
            }
            if (person.LastName!="")
            {
            temp.LastName = person.LastName;
            }
            if (person.Email!="")
            {
            temp.Email = person.Email;
            }
            if (person.BirthDate!=null)
            {
            temp.BirthDate = person.BirthDate;
            }
            if (person.Phone!="")
            {
            temp.Phone = person.Phone;
            }
            if (person.Salary!=null)
            {
            temp.Salary = person.Salary;
            }
            var result=conn.SaveChanges();
            return result;
        }
    }
}
