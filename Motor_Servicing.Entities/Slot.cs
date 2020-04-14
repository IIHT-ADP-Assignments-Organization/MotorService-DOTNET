using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.Entities
{
    public class Slot
    {
        public virtual int UserId { get; set; }
        public virtual int SlotId { get; set; }
        public virtual int SlotNumber { get; set; }
        public virtual DateTime SlotTime { get; set; }
    }
}
