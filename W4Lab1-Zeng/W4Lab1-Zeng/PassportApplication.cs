using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2Lab_Zeng
{
    class PassportApplication
    {

        public PassportApplication(string surname, string givenname, bool sex, string dateofbirth, string city, string country, string province, bool returnpassport)
        {
            Surname = surname;
            Givenname = givenname;
            Sex = sex;
            DateOfBirth = dateofbirth;
            City = city;
            Country = country;
            Province = province;
            ReturnPassPort = returnpassport;
        }

        public string Surname { get; set; }
        public string Givenname { get; set; }
        public bool Sex { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public bool ReturnPassPort { get; set; }

        public override string ToString()
        {
            return Surname + "  " + Givenname + "  " + (Sex? "Female" : "Male") + "  " + DateOfBirth + "  " + City + "  " + Country + "  " + Province + "  " + (ReturnPassPort? "True":"False");
        }
    }
}
