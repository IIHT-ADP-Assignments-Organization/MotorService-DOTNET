using Motor_Servicing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.BusinessLayer.Interafces
{
   public interface IAdminServices
    {
        bool Login(string UserName, string Password);
        int AddServices(services services);
        services ViewServices(int ServicesId);
        services EditServices(services services);
        services GetServices(int serviceId);
        Slot EditSlot(int CustomerId);
        Slot AllotSlot(int CustomerId);
        bool DeleteSlot(int CustomerId);
        Slot ViewSlot(int CustomerId);
        Customer ViewCustomer(int CustomerId);

        services ViewServices();
    }
}
