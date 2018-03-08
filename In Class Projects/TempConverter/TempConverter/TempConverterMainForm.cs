using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempConverter
{
    public partial class TempConverterMainForm : Form
    {
        public TempConverterMainForm()
        {
            InitializeComponent();
        }

        #region EventMethods

        void OnTempConverterMainFormLoad(object sender, EventArgs e)
        {
            // Populate the choice boxes
            sourceUnitComboBox.DataSource = Enum.GetValues(typeof(TemperatureUnits));
            targetUnitComboBox.DataSource = Enum.GetValues(typeof(TemperatureUnits));

            sourceUnitComboBox.SelectedIndex = (int)TemperatureUnits.Fahrenheit;
            targetUnitComboBox.SelectedIndex = (int)TemperatureUnits.Celsius;
        }

        void OnRunConversionButtonClick(object sender, EventArgs e)
        {
            // Conversion Constants
            decimal fToCFactor = 0;

            // Validate the source box
            if (!double.TryParse(sourceDataBox.Text, out double _))
            {
                sourceDataBox.Text = string.Empty;
                targetDataBox.Text = string.Empty;
            }
            else
            {
                // Calculate the conversion
                double sourceData= double.Parse(sourceDataBox.Text);
                double targetDataCalculation;

                switch (sourceUnitComboBox.SelectedIndex)
                {
                    case (int)TemperatureUnits.Celsius when targetUnitComboBox.SelectedIndex == (int)TemperatureUnits.Fahrenheit:

                        // Celsius to Fahrenheit
                        // F = (C * 9/5) + 32
                        targetDataCalculation = (sourceData * (9.0 / 5.0)) + 32;
                        break;
                    case (int)TemperatureUnits.Fahrenheit when targetUnitComboBox.SelectedIndex == (int)TemperatureUnits.Celsius:

                        // Fahrenheit to Celsius
                        // C = (F - 32) * 5/9
                        targetDataCalculation = (sourceData - 32) * (5.0 / 9.0);
                        break;
                    default:
                        targetDataCalculation = sourceData;
                        break;
                }

                // Update the target box
                targetDataBox.Text = $"{targetDataCalculation:F2}";
            }
        }

        #endregion

        #region HelperMethods



        #endregion
    }
}
