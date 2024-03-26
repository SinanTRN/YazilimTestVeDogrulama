using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class ErrorLogger
    {
        public string LastError {  get; set; }

        public void Log(string message) 
        {
            //null,""," " olabilir
            if (String.IsNullOrWhiteSpace(message)) throw new ArgumentNullException();
            LastError = message;        
        }
    }
}
