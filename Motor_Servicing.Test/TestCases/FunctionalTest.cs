using Motor_Servicing.BusinessLayer.Services;
using Motor_Servicing.DataLayer.NHibernateConfiguration;
using Motor_Servicing.Entities;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Motor_Servicing.Test.TestCases
{
   public class FunctionalTest
    {
        private readonly AdminServices _AdminServices;
        private readonly CustomerSevices _CustomerSevices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FunctionalTest()
        {
           _AdminServices = new AdminServices(_session);
           _CustomerSevices = new CustomerSevices(_session);
        }

        [Fact]
        public void Test_for_Register()
        {
            Customer customer = new Customer()
            {
                UserId = 1,
                Address = "aa",
                Email = "aa@gmail.com",
                Password = "1234",
               
                PhoneNumber = "11111",
               
                UserName = "ss"

            };
            var Result = _CustomerSevices.SignUp(customer);
            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_LoginForCustomer()
        {
            Customer customer = new Customer()
            {
               
                Password = "",
               

                UserName = "ss"

            };
            var Result = _CustomerSevices.Login(customer.UserName,customer.Password);
            Assert.True(Result);
        }


        [Fact]
        public void Test_for_ConfirmSlot()
        {
            Slot slot = new Slot()
            {
                SlotId=1,
                SlotNumber=1,
                SlotTime=DateTime.Now,
                UserId=1,
               

            };
            var Result = _CustomerSevices.ConfirmSlot(slot);
            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_AddTOCart()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };

            Customer customer = new Customer()
            {
                UserId = 1
            };
            var Result = _CustomerSevices.AddTOCart(services,customer.UserId);
            var GetCart = Result.ToString();
            Assert.NotNull(GetCart);
        }

        [Fact]
        public void Test_for_CheckOut()
        {
            Slot slot = new Slot()
            {
                SlotId = 1,
              
            };

            Customer customer = new Customer()
            {
                UserId = 1
            };
            var Result = _CustomerSevices.CheckOut(slot.SlotId, customer.UserId);
          
            Assert.True(Result);
        }

        [Fact]
        public void Test_for_MakePayment()
        {
            Payment payment = new Payment()
            {
                Amount = 11,
                PaymentId = 1,
                PaymentType = "",
                UserId = 1
            };
            var Result = _CustomerSevices.MakePayment(payment);

            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_ViewServices()
        {
            
            var Result = _CustomerSevices.ViewServices();

            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_SelectServices()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };
            var Result = _CustomerSevices.SelectServices(services.ServiceId);

            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_SearchServices()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };
            var Result = _CustomerSevices.SearchServices(services);
            var GetServices = _CustomerSevices.GetServices(services);

            Assert.Equal(GetServices,Result);
        }

        [Fact]
        public void Test_for_LoginForAdmin()
        {
            Admin admin = new Admin()
            {
                AdminId = 1,
                UserName = "",
                Password = ""
            };
            var Result = _AdminServices.Login(admin.UserName,admin.Password);
           

            Assert.True( Result);
        }

        [Fact]
        public void Test_for_AddServices()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };

            
            var Result = _AdminServices.AddServices(services);
            var GetService = Result.ToString();
            Assert.NotNull(GetService);
        }

        [Fact]
        public void Test_for_ViewServicesforAdmin()
        {
            services services = new services()
            {
                ServiceId = 22,
                
            };


            var Result = _AdminServices.ViewServices(services.ServiceId);
            
            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_EditServices()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };


            var Result = _AdminServices.EditServices(services);
            var GetServices = _AdminServices.GetServices(services.ServiceId);

            Assert.Equal(GetServices,Result);
        }

        [Fact]
        public void Test_for_EditSlot()
        {
            Customer customer = new Customer()
            {
                UserId = 1,
            };


            var Result = _AdminServices.EditSlot(customer.UserId);
            var GetSlot = _AdminServices.ViewSlot(customer.UserId);

            Assert.Equal(GetSlot, Result);
        }


        [Fact]
        public void Test_for_AllotSlot()
        {
            Customer customer = new Customer()
            {
                UserId = 1,
            };


            var Result = _AdminServices.AllotSlot(customer.UserId);
           

            Assert.NotNull( Result);
        }

        [Fact]
        public void Test_for_DeleteSlot()
        {
            Customer customer = new Customer()
            {
                UserId = 1,
            };


            var Result = _AdminServices.DeleteSlot(customer.UserId);


            Assert.True(Result);
        }

        [Fact]
        public void Test_for_ViewSlot()
        {
            Customer customer = new Customer()
            {
                UserId = 1,
            };


            var Result = _AdminServices.ViewSlot(customer.UserId);


            Assert.NotNull(Result);
        }

        [Fact]
        public void Test_for_ViewCustomer()
        {
            Customer customer = new Customer()
            {
                UserId = 1,
            };


            var Result = _AdminServices.ViewCustomer(customer.UserId);


            Assert.NotNull(Result);
        }

       

    }
}
