using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFAutofacExample.Business.Logic.IBusinessLogic;
using WCFAutofacExample.Common.Models;
using WCFAutofacExample.Infrastructure.Repository.IRepository;

namespace WCFAutofacExample.Business.Logic.BusinessLogicImp
{
    public class StudentBusinessLogic : IBusinessLogic<Student>
    {
        //Inyectar una referencia al repositorio
        private IRepository<Student> studentRepository;

        public StudentBusinessLogic(IRepository<Student> repository)
        {
            if(repository == null)
            {
                string message = "student repository null";
                throw new NotImplementedException(message);
                //log.Error(message);
            }
            this.studentRepository = repository;
        }

        public Student Add(Student t)
        {
            Console.WriteLine("dummy Add()");
            return studentRepository.Add(new Student());
        }

        public Student Delete(int id)
        {
            Console.WriteLine("dummy Delete()");
            return studentRepository.Delete(id);
        }

        public List<Student> GetAll()
        {
            Console.WriteLine("dummy GetAll()");
            return studentRepository.GetAll();
        }

        public Student GetById(int id)
        {
            Console.WriteLine("dummy GetById()");
            return studentRepository.GetById(id);
        }

        public Student Update(Student t)
        {
            Console.WriteLine("dummy Update()");
            return studentRepository.Update(new Student());
        }
    }
}
