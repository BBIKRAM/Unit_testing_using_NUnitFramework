using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.ModelAccess;

namespace ControllerTests
{
    public class Mock_TestClass
    {
        [TestFixture]
        public class UnitTest
        {
            [Test]
            public void TestMethod2()
            {
                Mock<checkEmployee> chk = new Mock<checkEmployee>();
                chk.Setup(x => x.checkEmp()).Returns(true);

                processEmployee obje = new processEmployee();
                Assert.AreEqual(obje.insertEmployee(chk.Object), true);
            }
        }
    }
}
