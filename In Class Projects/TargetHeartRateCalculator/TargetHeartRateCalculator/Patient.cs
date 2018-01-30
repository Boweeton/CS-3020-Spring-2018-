using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetHeartRateCalculator
{
    class Patient
    {
        // ------------------------------
        #region Fields

        

        #endregion
        // ------------------------------
        #region Properties

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public int PatientBirthYear { get; set; }
        public int CurrentYear { get; set; }

        #endregion
        // ------------------------------
        #region Constructors

        public Patient()
        {
            PatientFirstName = string.Empty;
            PatientLastName = string.Empty;
            PatientBirthYear = 0;
        }

        public Patient(string newFirstName, string newLastName, int newPatientBirthYear)
        {
            PatientFirstName = newFirstName;
            PatientLastName = newLastName;
            PatientBirthYear = newPatientBirthYear;
            CurrentYear = DateTime.Now.Year;
        }

        #endregion
        // ------------------------------
        #region Methods

        public int FindPatientAgeInYears()
        {
            return CurrentYear - PatientBirthYear;
        }

        public int FindMaxHeartRate()
        {
            return 220 - FindPatientAgeInYears();
        }

        public string FindTargetMinAndMaxHeartRates()
        {
            double minRate = FindMaxHeartRate() * .5;
            double maxRate = FindMaxHeartRate() * .85;

            return $"You should keep your heart rate between {minRate:f1} BPM and {maxRate:f1} BPM";
        }

        #endregion
        // ------------------------------
    }
}
