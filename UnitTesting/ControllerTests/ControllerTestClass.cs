using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using NUnit.Framework;
using UnitTesting.Controllers;
using UnitTesting.Models;


namespace ControllerTests
{
    [TestFixture]
    public class ControllerTestClass
    {
        /// <summary>
        /// Test the Action metjod returning Specific Index View
        /// </summary>
        [Test]
        public void Test_Department_Index()
        {
            //Arrange
            var obj = new DepartmentController();
            //Act
            var actResult = obj.Index() as ViewResult;
            //Assert
            Assert.That(actResult.ViewName, Is.EqualTo("Index"));
        }

        [Test]
        public void Test_Department_Create_View()
        {
            //Arrange
            var obj = new DepartmentController();
            //Act
            var actresult =obj.Create() as ViewResult ;
            //Assert
            Assert.That(actresult.ViewName , Is.EqualTo("Create"));
        }

        /// <summary>
        /// Testing the RedirectToRoute to Check for the Redirect
        /// to Index Action
        /// </summary>

        [Test]
        public void Test_Department_CreateRedirect()
        {
            //Arrange
            var obj = new DepartmentController();

            //Act
            RedirectToRouteResult result = obj.Create(new Department()
            {
                DeptNo = 4,
                Dname = "Bikram(updated)",
                Location = "Greenland(Updated)"
            }) as RedirectToRouteResult;

            //Assert
            Assert.That(result.RouteValues["action"], Is.EqualTo("Index"));

        }
        [Test]
        [TestCase(4)]
        public void Test_Department_Delete(int a)
        {
            //Arrange
            var obj = new DepartmentController();
            //Act
            RedirectToRouteResult result = obj.Delete(a) as RedirectToRouteResult;
            //Assert
            Assert.That(result.RouteValues["action"], Is.EqualTo("Index"));

        }

        [Test]
        [TestCase(1)]
        public void Test_Department_EditView(int a)
        {
            //Arrange
            var obj = new DepartmentController();
            //Act
            var result = obj.Edit(a) as ViewResult ;
            //Assert
            Assert.That(result.ViewName, Is.EqualTo("Create"));
        }

        [Test]
        [TestCase(3,"Bikram","greenland")]
        [TestCase(2,"bebit","rampur")]
        [TestCase(5,"gaurav","kanpur")]
        public void Test_Department_EditRedirect( int a,string b,string c)
        {
            //Arrange
            var obj = new DepartmentController();
            //Act
            RedirectToRouteResult result = obj.Edit(new Department()
            {
                DeptNo = a,
                Dname = b,
                Location = c
            }) as RedirectToRouteResult;

            //Assert
            Assert.That(result.RouteValues["action"], Is.EqualTo("Index"));

        }


    }


}
