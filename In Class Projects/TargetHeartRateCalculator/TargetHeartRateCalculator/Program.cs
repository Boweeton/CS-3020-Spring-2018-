using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHeartRateCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient testPatient = new Patient();

            // Request First Name
            Console.Write("Enter your first name: ");
            testPatient.PatientFirstName = Console.ReadLine();

            // Request Last Name
            Console.Write("Enter your last name: ");
            testPatient.PatientLastName = Console.ReadLine();

            // What year were you born
            Console.Write("Enter your birth year: ");
            int.TryParse(Console.ReadLine(), out int n);
            testPatient.PatientBirthYear = n;

            testPatient.CurrentYear = 2018;

            // Report info
            Console.WriteLine($"\nHello {testPatient.PatientFirstName} {testPatient.PatientLastName}, your Max BPM is {testPatient.FindMaxHeartRate()}\n");
            Console.WriteLine($"{testPatient.FindTargetMinAndMaxHeartRates()}");
        }
    }
}
