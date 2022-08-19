using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting.Controllers;

namespace ControllerTests
{
    [TestFixture]
    public class CalculatorTestClass
    {

        [Test, Order(3)]
        //[Test]
            public void AddMethodTest()
            {
                //Arrange
                Calculator add = new Calculator();
                //Act
                int result = add.Add(15, 10);
                //Assert
                Assert.That(result, Is.EqualTo(25));
            }

            [Test]
            [TestCase(15,20,35)]
            [TestCase(15,15,30)]
            [TestCase(15,10,55)]
            public void Add_Method_Test(int num1,int num2,int ExpectedResult)
            {
                //Arrange
                Calculator add = new Calculator();
                //Act
                int result= add.Add(num1,num2); 
                //Assert
                Assert.That(result, Is.EqualTo(ExpectedResult));
            } 

            [Test]
            [TestCase(15,20, ExpectedResult=35)]
            [TestCase(15,15, ExpectedResult=30)]
            [TestCase(15,40, ExpectedResult=25)]
            public int Add_Method_test1(int num1,int num2)
            {

                Calculator add = new Calculator();
                
                return add.Add(num1,num2); 
                
            }
                    
            [Test]
            [TestCase(15,20,TestName ="15+20",  ExpectedResult=35)]
            [TestCase(15,15,TestName ="15+215", ExpectedResult =30)]
            [TestCase(15,40,TestName ="15+40",  ExpectedResult =25)]
            public int Add_Method_test2(int num1,int num2)
            {

                Calculator add = new Calculator();
                
                return add.Add(num1,num2); 
                
            }

        }
    }
