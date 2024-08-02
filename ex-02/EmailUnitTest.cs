using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex_02
{
    public class EmailUnitTest
    {
        [Theory]
        [InlineData("guilherme@email.com")]
        [InlineData("guilhermejfsdogjdfjgid")]
        public void ValidateEmailTest(string email)
        {

            String theEmailPattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                       + "@"
                       + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z";

            bool result = Regex.IsMatch(email, theEmailPattern);

            Assert.True(result);
        }
    }
}
