using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAutofacExample.Infrastructure.Repository.IRepository
{
    public interface IRead<T>
    {
        List<T> GetAll();
        T GetById(int id);
    }
}
