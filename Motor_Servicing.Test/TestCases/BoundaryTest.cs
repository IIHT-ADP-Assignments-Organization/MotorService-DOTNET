using Motor_Servicing.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Xunit;

namespace Motor_Servicing.Test.TestCases
{
   public class BoundaryTest
    {
        [Fact]
        public void Boundary_Testfor_ValidEmail()
        {
            //Action
            var customer = new Customer()
            {

                Email = "abc@gmail.com",

            };

            bool isEmail = Regex.IsMatch(customer.Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            //Assert
            Assert.True(isEmail);
        }

        [Fact]
        public void Boundary_Testfor_ValidContactNumber()
        {
            //Action
            var customer = new Customer()
            {


                PhoneNumber = "12345678"
            };

            //Assert
            Assert.Equal(10, customer.PhoneNumber.ToString().Length);
        }


        [Fact]
        public void BoundaryTest_ForPassword_LengthforCustomer()
        {
            var customer = new Customer()
            {

                Password = "12345678"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = customer.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForPassword_LengthforAdmin()
        {
            var admin = new Admin()
            {

                Password = "12345678"
            };
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = admin.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_LengthforCustomer()
        {
            //Arrange
            var customer = new Customer()
            {

                UserName = "Rose",

            };
            var MinLength = 2;
            var MaxLength = 50;

            //Action
            var actualLength = customer.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_LengthforAdmin()
        {
            //Arrange
            var admin = new Admin()
            {

                UserName = "Rose",

            };
            var MinLength = 2;
            var MaxLength = 50;

            //Action
            var actualLength = admin.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }
    }
}
