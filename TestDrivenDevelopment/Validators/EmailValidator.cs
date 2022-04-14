using System.Text.RegularExpressions;

namespace TestDrivenDevelopment.Validators
{
    public class EmailValidator
    {
        const string EmailValidatorRegex = "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$";

        public bool IsValid(string input)
        {
            throw new NotImplementedException();
        }
    }
}
