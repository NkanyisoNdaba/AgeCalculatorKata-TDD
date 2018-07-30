using System;

namespace AgeCalculatorKata
{
    public  class AgeCalculatorTest
    {
        public class AgeCalculator
        {
            public int CalculatorAge(DateTime birthDate, DateTime targetDate)
            {
                var age = targetDate.Year - birthDate.Year;
                var month = targetDate.Month;

                if (ItsNotABirthday(birthDate, age, month))
                {
                    return 0;
                } 
                return age;
            }

            //public string CalculateBirthWeek(DateTime birthDate, DateTime targetDate)
            //{
            //    if (targetDate.Month == birthDate.Month)
            //    {
            //        if (targetDate.Day == birthDate.Day)
            //        {
            //            return targetDate.DayOfWeek;
            //        }
            //    }
                
            //}

            private static bool ItsNotABirthday(DateTime birthDate, int age, int month)
            {
                return age < 0 || month != birthDate.Month && month < birthDate.Month;
            }
        }
    }
}
