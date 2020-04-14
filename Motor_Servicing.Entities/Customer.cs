using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.Entities
{
   public class Customer
    {
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string PhoneNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual string Email { get; set; }
        public virtual string Password { get; set; }
    }
}
