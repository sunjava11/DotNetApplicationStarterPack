using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetApplicationStarterPack.sunjava1.General
{
    public static class PersonalInformationPack
    {

        public static int GetAge(this DateTime dateOfBirth)
        {
            DateTime today = DateTime.Now;
            int ageYears = today.Year - dateOfBirth.Year;

            if (dateOfBirth.Date > today.AddYears(-ageYears))
            {
                ageYears--;
            }
            return ageYears;
        }
    }
}