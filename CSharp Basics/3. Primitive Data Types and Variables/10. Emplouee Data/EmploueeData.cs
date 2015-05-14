using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Emplouee_Data
{
    class EmploueeData
    {
        static void Main(string[] args)
        {
            string firstName = "Stoyan";
            string lastName = "Stoyanov";
            byte age = 41;
            bool gender = true;
            long personalID = 8306112507;
            int uniqEmploueeNumber = 27569999;
            Console.WriteLine("Full emplouee name is: {1}, {0};", firstName, lastName);
            Console.WriteLine("Emplouee's age is: {0}, and sex is: {1};", age, gender ? "male" : "female");
            Console.WriteLine("Emplouee's personalID is: {0};", personalID);
            Console.WriteLine("Unique emplouee number is: {0};", uniqEmploueeNumber);
        }
    }
}
