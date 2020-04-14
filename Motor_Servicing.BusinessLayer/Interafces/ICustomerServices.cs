using Motor_Servicing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.BusinessLayer.Interafces
{
    public interface ICustomerServices
    {
        Customer SignUp(Customer customer);
        bool Login(string UserName, string Password);
        Slot ConfirmSlot(Slot slot);
        int AddTOCart(services services, int UserId);
        bool CheckOut(int SlotId, int UserId);
        Payment MakePayment(Payment payment);
        services ViewServices();
        services SelectServices(int ServiceId);
        services SearchServices(services services);
        services GetServices(services services);


    }
}
