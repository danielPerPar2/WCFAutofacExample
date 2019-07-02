using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFAutofacExample.Common.Models;

namespace WCFAutofacExample.Web.Services
{
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        Student Add(Student student);

        [OperationContract]
        List<Student> GetAll();

        [OperationContract]
        Student GetById(int id);

        [OperationContract]
        Student Update(Student student);

        [OperationContract]
        Student Delete(int id);
    }   
}
