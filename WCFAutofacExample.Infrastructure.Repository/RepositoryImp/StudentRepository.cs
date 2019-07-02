using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAutofacExample.Common.Models;
using WCFAutofacExample.Infrastructure.Repository.IRepository;

namespace WCFAutofacExample.Infrastructure.Repository.RepositoryImp
{
    public class StudentRepository : IRepository<Student>
    {
        public Student Add(Student t)
        {
            Console.WriteLine("dummy Add()");
            return new Student();
        }

        public Student Delete(int id)
        {
            Console.WriteLine("dummy Delete()");
            return new Student();
        }

        public List<Student> GetAll()
        {
            Console.WriteLine("dummy GetAll()");
            return new List<Student>();
        }

        public Student GetById(int id)
        {
            Console.WriteLine("dummy GetById()");
            return new Student();
        }

        public Student Update(Student t)
        {
            Console.WriteLine("dummy Update()");
            return new Student();
        }
    }
}
