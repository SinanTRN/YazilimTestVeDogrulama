using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class CustomerController
    {
        public class ActionResult { }
        public class NotFound : ActionResult { }
        public class Ok : ActionResult { }

        public ActionResult GetCustomer(int id)
        {
            if (id == 0) return new NotFound();
            else return new Ok();
        }
    }
}
