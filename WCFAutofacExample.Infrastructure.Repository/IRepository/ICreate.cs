using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFAutofacExample.Infrastructure.Repository.IRepository
{
    public interface ICreate<T>
    {
        T Add(T t);
    }
}
