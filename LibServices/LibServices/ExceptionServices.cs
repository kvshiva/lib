using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibServices
{
    public class ExceptionServices:Exception
    {
        public string message { get; set; }
        public ExceptionServices(string message)
        {
            this.message = message;
        }
    }
}
