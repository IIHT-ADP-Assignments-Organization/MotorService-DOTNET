using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.Entities
{
  public  class Payment
    {
        public virtual int PaymentId { get; set; }
        public virtual string PaymentType { get; set; }
        public virtual double Amount { get; set; }
        public virtual int UserId { get; set; }
    }
}
