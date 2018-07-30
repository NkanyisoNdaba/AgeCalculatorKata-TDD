using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static AgeCalculatorKata.AgeCalculatorTest;

namespace AgeCalculatorTests
{
    [TestFixture]
    public  class AgeCalculatorTest
    {
        [TestCase("2018,06,04")]
        [TestCase("2019,06,04")]
        [TestCase("2020,06,04")]
        public void CalculateAge_GivenATargetDateSimilarToBirthDate_ShouldReturnZero(DateTime targetDate)
        {
            //Arrange
            var ageResult = new AgeCalculator();
            DateTime birthDate = new DateTime(targetDate.Year,03,05);
            
            //Act
            var actual = ageResult.CalculatorAge(birthDate,targetDate);

            //Assert
            Assert.AreEqual(0,actual);
        }

        [TestCase("2019,03,28", 1)]
        [TestCase("2020,03,28", 2)]    
        [TestCase("2021,03,28", 3)]    
        [TestCase("2099,03,28", 81)]    
        public void CalculateAge_GivenABirthDateIn2018AndTargetDateFrom2019To2099_ShouldReturnAge(DateTime targetDate, int expected)
        {
            //Arrange
            var ageResult = CreateAgeCalculator();
            DateTime birthDate = new DateTime(2018, 03, 28);
            
            //Act
            var actual = ageResult.CalculatorAge(birthDate, targetDate);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CalculateAge_GivenABirthDateGreaterThanTargetDate_ShouldReturnZero()
        {
            //Arrange
            var ageResult = new AgeCalculator();
            DateTime birthDate = new DateTime(2018,03, 05);
            DateTime targetDate = new DateTime(2015, 03, 05);

            //Act
            var actual = ageResult.CalculatorAge(birthDate, targetDate);

            //Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void CalculateAge_GivenABirthDateOfDifferentYearAndDiffirentMonthAsTargetDate_ShouldReturnZero()
        {
            //Arrange
            var ageResult = new AgeCalculator();
            DateTime birthDate = new DateTime(2018, 03, 05);
            DateTime targetDate = new DateTime(2019, 01, 05);

            //Act
            var actual = ageResult.CalculatorAge(birthDate, targetDate);

            //Assert
            Assert.AreEqual(0, actual);
        }

        //[TestCase("2017-09-09","September 3 2017")]
        //public void CalculateAge_GivenABirthDate_ShouldReturnStartDateOfBirthDayWeek(DateTime birthdate,string expected)
        //{
        //    //Arrange
        //    var ageResult = new AgeCalculator();          
        //    DateTime targetDate = new DateTime(2017, 09, 09);

        //    //Act
        //    var actual = ageResult.CalculateBirthWeek(birthdate, targetDate);

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        private static AgeCalculator CreateAgeCalculator()
        {
            return new AgeCalculator();
        }

    }
 }

