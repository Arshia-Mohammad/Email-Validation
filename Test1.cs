using Microsoft.VisualStudio.TestTools.UnitTesting;
using Email_Validation;

namespace EmailTest_MSTest
{
    [TestClass]
    public class Test1
    {
        private EmailValidator _emailValidator;

        [TestInitialize]
        public void Setup()
        {
            _emailValidator = new EmailValidator();
        }

        [TestMethod]
        public void IsEmailValid_ForInvalidEmail()
        { 
            string input= "Invalid_email.com";
            bool result= _emailValidator.IsEmailValid(input);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsEmailValid_forValidEmail()
        {
            string input = "Valid@example.com";
            bool result = _emailValidator.IsEmailValid(input);
            Assert.IsTrue(result);
        }
    }
}
