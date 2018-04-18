using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InClassChallenge3
{
    public partial class MainForm : Form
    {
        // Fields
        List<int> listOfIntegers = new List<int>();
        List<double> listOfDoubles = new List<double>();
        readonly Random rng = new Random();
        bool isOnInts;

        public MainForm()
        {
            InitializeComponent();
        }

        void OnMainForm_Load(object sender, EventArgs e)
        {

        }

        int Search<T>(T key, IReadOnlyList<T> list) where T : IComparable
        {
            // Search through the list for the key
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(key) == 0)
                {
                    return i;
                }
            }

            // Return -1 if the key never matches
            return -1;
        }

        void UpdateListBox<T>(List<T> list)
        {
            // Local declarations
            StringBuilder sb = new StringBuilder();

            // Build the string
            sb.AppendLine(list[0].ToString());
            for (int i = 1; i < list.Count; i++)
            {
                sb.AppendLine(list[i].ToString());
            }

            // Update the box value
            listValuesTextBox.Text = sb.ToString();
        }

        void OnGenerateIntsButton_Click(object sender, EventArgs e)
        {
            // Flush the list and find the list size
            listOfIntegers = new List<int>();
            int.TryParse(listSizeTextBox.Text, out int listSize);

            // Fill the list
            for (int i = 0; i < listSize; i++)
            {
                listOfIntegers.Add(rng.Next(0,1001));
            }

            // Update the list box and flip the bools
            UpdateListBox(listOfIntegers);
            isOnInts = true;
        }

        void OnGenerateDoublesButton_Click(object sender, EventArgs e)
        {
            // Flush the list and find the list size
            listOfDoubles = new List<double>();
            int.TryParse(listSizeTextBox.Text, out int listSize);

            // Fill the list
            for (int i = 0; i < listSize; i++)
            {
                listOfDoubles.Add(rng.Next(0, 101));
            }

            // Update the list box and flip the bools
            UpdateListBox(listOfDoubles);
            isOnInts = false;
        }

        void OnSearchButton_Click(object sender, EventArgs e)
        {
            // Find the key
            double.TryParse(searchTextBox.Text, out double key);

            // Find the index based on the current bool switch
            int index = isOnInts ? Search((int)key, listOfIntegers) : Search(key, listOfDoubles);

            // Update the results box
            searchResultsLabel.Text = index >=0 ? $"FirstIndex: {index}" : $"FirstIndex: (D.N.E.)";
        }
    }
}
