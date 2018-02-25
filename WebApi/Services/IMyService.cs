using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public interface IMyService
    {
        string GetSomeStuff(int id);
        IEnumerable<string> GetAllStuff();
    }
}
