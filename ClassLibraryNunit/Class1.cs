using FinalProject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryNunit
{
    [TestFixture]

    public class WhenUsingNunitTest
    {
        [Test]
        
        public void When_UserEnteredSentinelValue_WhiteSpaceEntered_ResultShouldBeFalse()
        {
            // prepare
            var expected = false;

            // action
            var actual = Patient.UserEnteredSentinelValue(" ");

            // assert
           Assert.That(expected, Is.EqualTo(actual));
        }

       
      



    }
}
