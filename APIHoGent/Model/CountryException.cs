using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIHoGent.Model
{
    public class CountryException: Exception
    {
        public CountryException(string msg) : base(msg)
        {

        }
    }
}
