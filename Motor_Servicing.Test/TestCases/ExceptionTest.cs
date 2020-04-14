using Motor_Servicing.BusinessLayer.Services;
using Motor_Servicing.DataLayer.NHibernateConfiguration;
using Motor_Servicing.Entities;
using Motor_Servicing.Test.Exceptions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Motor_Servicing.Test.TestCases
{
  public  class ExceptionTest
    {
        private readonly AdminServices _AdminServices;
        private readonly CustomerSevices _CustomerSevices;

        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public ExceptionTest()
        {
            _AdminServices = new AdminServices(_session);
            _CustomerSevices = new CustomerSevices(_session);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFoundforCustomer()
        {
            Customer user = new Customer()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _CustomerSevices.Login(user.UserName, user.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserNotFoundforAdmin()
        {
            Admin admin = new Admin()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _AdminServices.Login(admin.UserName, admin.Password));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ServicesNotFound()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };
            //Assert
            var ex = Assert.Throws<ServicesNotFoundException>(() => _CustomerSevices.SearchServices(services));
            Assert.Equal("Services Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_UserCannotblank()
        {
            Customer user = new Customer()
            {
                UserName = "abc",
                Password = ""

            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _CustomerSevices.SignUp(user));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ServicesDetailsCannotblank()
        {
            services services = new services()
            {
                ServiceFees = 22,
                ServiceId = 1,
                ServiceName = "",
                ServiceType = ""
            };
            //Assert
            var ex = Assert.Throws<FieldscannotEmptyException>(() => _AdminServices.AddServices(services));
            Assert.Equal("Fields can not be blank ", ex.Messages);
        }
    }
}
