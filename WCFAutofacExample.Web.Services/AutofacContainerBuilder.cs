using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using WCFAutofacExample.Business.Logic.BusinessLogicImp;
using WCFAutofacExample.Business.Logic.IBusinessLogic;
using WCFAutofacExample.Common.Models;
using WCFAutofacExample.Infrastructure.Repository.IRepository;
using WCFAutofacExample.Infrastructure.Repository.RepositoryImp;
using WCFAutofacExample.Web.Services.StudentServiceImp;

namespace WCFAutofacExample.Web.Services
{
    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
           
            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<StudentBusinessLogic>().As<IBusinessLogic<Student>>();
            builder.RegisterType<StudentRepository>().As <IRepository<Student>>();
           
            return builder.Build();
        }
    }
}