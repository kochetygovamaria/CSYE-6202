using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;

namespace FinalProjectTest
{
    [TestFixture]

    public class WhenRunningFinalProject
    {
        #region ClassHelper Tests

        [Test]
        public void When_LoadPatients_CorrectPathEntered_ResultShouldBeBindingListPatients()
        {
            // prepare
            // var expected = null;

            // action
            var actual = ClassHelper.LoadPatients("patients.xml");

            // assert
            Assert.That(null, !Is.EqualTo(actual));
        }

        [Test]
        public void When_LoadPatients_WrongPathEntered_ResultShouldBeNull()
        {
            // prepare
            //var expected = null;

            // action
            var actual = ClassHelper.LoadPatients("asdf.xml"); // file does not exist

            // assert
            Assert.That(null, Is.EqualTo(actual));
        }

        #endregion

    }
}
