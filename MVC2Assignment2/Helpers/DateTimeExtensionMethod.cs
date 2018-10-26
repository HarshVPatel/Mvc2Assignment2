using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC2Assignment2.Helpers
{
    public static class DateTimeExtensionMethod
    {
     
        static public int Age(this DateTime dateOfBirth)
        {
            dateOfBirth = new DateTime(1998, 10, 12);

            if (DateTime.Today.Month < dateOfBirth.Month ||
            DateTime.Today.Month == dateOfBirth.Month &&
             DateTime.Today.Day < dateOfBirth.Day)
            {
                return DateTime.Today.Year - dateOfBirth.Year - 1;
            }
            else
                return DateTime.Today.Year - dateOfBirth.Year;
        }

     
    }
}