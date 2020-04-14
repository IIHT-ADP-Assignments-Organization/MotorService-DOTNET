using Motor_Servicing.BusinessLayer.Interafces;
using Motor_Servicing.DataLayer.NHibernateConfiguration;
using Motor_Servicing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.BusinessLayer.Services
{
    public class CustomerSevices : ICustomerServices
    {
        private readonly IMapperSession _session;

        public CustomerSevices(IMapperSession session)
        {
            _session = session;
        }
        public int AddTOCart(services services, int UserId)
        {
            services ObjServices = new services();
            return ObjServices.ServiceId;
        }

        public bool CheckOut(int SlotId, int UserId)
        {
            return true;
        }

        public Slot ConfirmSlot(Slot slot)
        {
            Slot ObjSlot = new Slot();
            return ObjSlot;
        }

        public services GetServices(services services)
        {
            services ObjServices = new services();
            return ObjServices;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public Payment MakePayment(Payment payment)
        {
            Payment ObjPayment = new Payment();
            return ObjPayment;
        }

        public services SearchServices(services services)
        {
            throw new NotImplementedException();
        }

        public services SelectServices(int ServiceId)
        {
            services ObjServices = new services();
            return ObjServices;
        }

        public Customer SignUp(Customer customer)
        {
            Customer ObjCustomer = new Customer();
            return ObjCustomer;
        }

        public services ViewServices()
        {
            services ObjServices = new services();
            return ObjServices;
        }
    }
}
