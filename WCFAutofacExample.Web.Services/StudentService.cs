using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WCFAutofacExample.Business.Logic.IBusinessLogic;
using WCFAutofacExample.Common.Models;

namespace WCFAutofacExample.Web.Services.StudentServiceImp
{
    public class StudentService : IStudentService
    {
        //Inyectar referencia al business object en el constructor
        private IBusinessLogic<Student> studentBO;

        public StudentService(IBusinessLogic<Student> studentBO)
        {
            if(studentBO == null)
            {
                string message = "studentBO is null";
                //log.Error(message);
                throw new ArgumentNullException(message);
            }
            this.studentBO = studentBO;
        }
        public Student Add(Student student)
        {
            Console.WriteLine("dummy Add()");
            return studentBO.Add(student);
        }

        public Student Delete(int id)
        {
            Console.WriteLine("dummy Delete()");
            return studentBO.Delete(id);
        }

        public List<Student> GetAll()
        {
            Console.WriteLine("dummy GetAll()");
            return studentBO.GetAll();
        }

        public Student GetById(int id)
        {
            Console.WriteLine("dummy GetById()");
            return studentBO.GetById(id);
        }

        public Student Update(Student student)
        {
            Console.WriteLine("dummy Update()");
            return studentBO.Update(student);
        }
    }
}