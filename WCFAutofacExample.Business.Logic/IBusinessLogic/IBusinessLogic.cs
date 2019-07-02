using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAutofacExample.Business.Logic.IBusinessLogic
{
    public interface IBusinessLogic<T>
    {
        T Add(T t);
        List<T> GetAll();
        T GetById(int id);
        T Update(T t);
        T Delete(int id);
    }
}
