using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.Entities
{
    public class services
    {
        public virtual int ServiceId { get; set; }
        public virtual string ServiceName { get; set; }
        public virtual string ServiceType { get; set; }
        public virtual double ServiceFees { get; set; }
      
    }
}
