using Xunit;
using Email_Validation;

namespace EmailValidation_Using_xUnitTest
{
    
    public class UnitTest1
    {
        private readonly EmailValidator validate=new EmailValidator();
        [Fact]
        public void EmailValidation_forInvalidEmail()
        {
            string input="no-at-symbol.com";
            bool result=validate.IsEmailValid(input);
            Assert.False(result);
        }

        [Fact]
        public void EmailValidation_forValidEmail()
        {
            string input = "test@example.co";
            bool result = validate.IsEmailValid(input);
            Assert.True(result);
        }

    }
}