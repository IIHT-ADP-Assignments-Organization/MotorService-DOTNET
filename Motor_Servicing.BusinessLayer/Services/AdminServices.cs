using Motor_Servicing.BusinessLayer.Interafces;
using Motor_Servicing.DataLayer.NHibernateConfiguration;
using Motor_Servicing.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Motor_Servicing.BusinessLayer.Services
{
    public class AdminServices : IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }
        public int AddServices(services services)
        {
            services ObjServices = new services();
            return ObjServices.ServiceId;
        }

        public Slot AllotSlot(int CustomerId)
        {
            Slot ObjSlot = new Slot();
            return ObjSlot;
        }

        public bool DeleteSlot(int CustomerId)
        {
            return true;
        }

        public services EditServices(services services)
        {
            services ObjServices = new services();
            return ObjServices;
        }

        public Slot EditSlot(int CustomerId)
        {
            Slot ObjSlot = new Slot();
            return ObjSlot;
        }

        public services GetServices(int serviceId)
        {
            services ObjServices = new services();
            return ObjServices;
        }

        public bool Login(string UserName, string Password)
        {
            return true;
        }

        public Customer ViewCustomer(int CustomerId)
        {
            Customer customer = new Customer();
            return customer;
        }

        public services ViewServices(int ServicesId)
        {
            services ObjServices = new services();
            return ObjServices;
        }

        public services ViewServices()
        {
            services ObjServices = new services();
            return ObjServices;
        }

        public Slot ViewSlot(int CustomerId)
        {
            Slot ObjSlot = new Slot();
            return ObjSlot;
        }
    }
}
