using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Services
{
    public class MyService2 : IMyService
    {
        public IEnumerable<string> GetAllStuff()
        {
            return new string[] { "value1ąę", "value2ŚĆ" };
        }

        public string GetSomeStuff(int id)
        {
            var stuff = $"Stuff from MyService2. Id=={id.ToString()}";

            return stuff;
        }
    }
}