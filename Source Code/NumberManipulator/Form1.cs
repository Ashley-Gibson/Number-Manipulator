using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberManipulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /********** Task Functions **********/

        // Returns the first index where the maximum value occurs in the list
        public static int getMaxValueIndex(List<Double> list)
        {
            // Skip first item in loop
            int i = 1;

            // Initially extract first item in the List as the Largest
            double largestItem = list[0];

            double item = 0.0;

            // Loop until all items in the List have been processed
            while (i < list.Count)
            {
                // Extract current item in the List
                item = list[i];

                // If current item is larger than the previously largest item - set the new largest item
                if (item > largestItem)
                    largestItem = item;

                i++;
            }
           
            // Round to the correct Integer
            return (int)Math.Round(largestItem);
        }

        // Returns the first index where the minimum element occurs in the list
        public static int getMinValueIndex(List<Double> list)
        {
            // Skip first item in loop
            int i = 1;

            // Initially extract first item in the List as the Smallest
            double smallestItem = list[0];

            double item = 0.0;

            // Loop until all items in the List have been processed
            while (i < list.Count)
            {
                // Extract current item in the List
                item = list[i];

                // If current item is smaller than the previously smallest item - set the new smallest item
                if (item < smallestItem)
                    smallestItem = item;

                i++;
            }

            // Round to the correct Integer
            return (int)Math.Round(smallestItem);
        }

        // Changes the range of values in the list to be in the range -1 to 1 - *Only works with EXACTLY 3 numbers*
        public void normalize(List<Double> list)
        {
            // Decide which of 3 numbers is largest and smallest and assign their values between -1 and 1
            if (list[0] > list[1] && list[0] > list[2])
            {
                list[0] = 1;

                if (list[1] > list[2])
                {
                    list[1] = 0;
                    list[2] = -1;
                }
                else
                {
                    list[1] = -1;
                    list[2] = 0;
                }
            }
            else if (list[1] > list[0] && list[1] > list[2])
            {
                list[1] = 1;

                if (list[0] > list[2])
                {
                    list[0] = 0;
                    list[2] = -1;
                }
                else
                {
                    list[0] = -1;
                    list[2] = 0;
                }
            }
            else if (list[2] > list[0] && list[2] > list[1])
            {
                list[2] = 1;

                if (list[0] > list[1])
                {
                    list[0] = 0;
                    list[1] = -1;
                }
                else
                {
                    list[0] = -1;
                    list[1] = 0;
                }
            }

            // Convert List back to a String and set the textbox value
            // Join function appends List items together with a comma separation
            string outputString = string.Join(",", list.ToArray());

            textBox1.Text = outputString;
        }

        /*
        // Changes the range of values in the list to be in the range -1 to 1 - Intended to work with any number of values
        public void normalize2(List<Double> list)
        {
            // Create 2D array of a copy of the List and its position in terms of value
            double[][] listArray = { };

            int i = 0;

            while (i < listCount)
            {
                listArray[i][0] = list[i];  // Set 1 dimension to be the List values

                // If the current item is greater than the last one
                if (listArray[i][0] > listArray[i - 1][0] && i > 0)
                    listArray[i][1] = listArray[i - 1][1] + 1;        // Set the other dimension to be each value's position in terms of value

                i++;
            }

            int listCount = list.Count;

            double interval = 0.0;

            // Determine an interval based on the range -1 to 1 (2 difference) divided by the number of values in the List 
            // If values 
            if (listCount > 3)
                interval = 2.0 / listCount;
            else
                interval = 2.0 / (listCount - 1);

            double normalizedItem = interval;
            int i = 0;

            // Loops through items in the list and adds an increment of the interval
            while (i < listCount)
            {
                list[i] = normalizedItem;
                normalizedItem += interval;
            }

            // Convert List back to a String and set the textbox value to be this string
            // Join function appends List items together with a comma separation
            string outputString = string.Join(",", list.ToArray());

            textBox1.Text = outputString;
        }
        */

        // Reorders the values into ascending order using a sorting algorithm
        public void sort(List<Double> list)
        {
            // Chosen algorithm: Insertion Sort
            int previousItem;
            double itemToProcess;

            // For each item in the list (skipping the first item)
            for (int listItem = 1; listItem < list.Count; listItem++)
            {
                // Extract each item in the List each loop
                itemToProcess = list[listItem];

                // Set a counter for the previous item
                previousItem = listItem - 1;

                // While the previous item is greater than the current item (and the List previousItem counter doesn't go out of bounds)
                while(previousItem >= 0 && list[previousItem] > itemToProcess)
                {
                    // Set the next item to the previous item if its greater than the current item
                    list[previousItem + 1] = list[previousItem];

                    // Decrement the List previousItem counter
                    previousItem--;
                }

                // Reset the current item 
                list[previousItem + 1] = itemToProcess;
            }

            // Convert List back to a String and set the textbox value
            // Join function appends List items together with a comma separation
            string outputString = string.Join(",", list.ToArray());

            textBox1.Text = outputString;
        }

        /********** Additional Functions *********/
        
        // Converts the string from the input textbox to a List<Double>
        public List<Double> convertStringToList()
        {
            bool errorFound = false;
            string textboxInput = textBox1.Text;

            // Validation checks before converting to a List - errorFound parameter passed by reference as opposed to global variable for optimisation
            validationCheck(textboxInput, ref errorFound);

            if (!errorFound)
            {
                // Splits the String into items seperated by a comma then converts each Double item to a List
                List<Double> list = textboxInput.Split(',').Select(Double.Parse).ToList();

                return list;
            }
            else
                return null;
        }

        // Validation checks
        public void validationCheck(string textboxInput, ref bool errorFound)
        {
            string errorMessage = "";

            // Check if the string is not empty
            if (string.IsNullOrWhiteSpace(textboxInput))
            {
                errorMessage = "Error: Please input a list of numbers";
                errorFound = true;
            }

            // If an error has been found then show the error message label and output the error message
            if (errorFound)
            {
                errorTextbox.Visible = true;
                errorTextbox.Text = errorMessage;
            }
            // If an error has not been found then clear any possible previous error message from showing
            else
                errorTextbox.Visible = false;
        }

        /********** Button Click functions **********/

        private void MaxValueButton_Click_1(object sender, EventArgs e)
        {
            // Get the latest version of the textbox and convert it to a List
            List<Double> list = convertStringToList();

            if (list != null)
            {
                // Set the output label with the Highest value
                label2.Text = getMaxValueIndex(list).ToString();

                // Show and Hide the correct Labels
                largestLabel.Visible = true;
                smallestLabel.Visible = false;
            }
        }

        private void MinValueButton_Click_1(object sender, EventArgs e)
        {
            // Get the latest version of the textbox and convert it to a List
            List<Double> list = convertStringToList();

            if (list != null)
            {
                // Set the output label with the Smallest value
                label2.Text = getMinValueIndex(list).ToString();

                // Show and Hide the correct Labels
                largestLabel.Visible = false;
                smallestLabel.Visible = true;
            }
        }

        private void NormalizeButton_Click_1(object sender, EventArgs e)
        {
            // Hide non-applicable Labels
            largestLabel.Visible = false;
            smallestLabel.Visible = false;
            label2.Visible = false;

            // Get the latest version of the textbox and convert it to a List
            List<Double> list = convertStringToList();

            if (list != null)
                normalize(list);
        }

        private void SortButton_Click_1(object sender, EventArgs e)
        {
            // Disable non-applicable Labels
            largestLabel.Visible = false;
            smallestLabel.Visible = false;
            label2.Visible = false;

            // Get the latest version of the textbox and convert it to a List
            List<Double> list = convertStringToList();

            if (list != null)
                sort(list);
        }

        /********** Unused functions **********/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void largestLabel_Click(object sender, EventArgs e)
        {

        }

        private void smallestLabel_Click(object sender, EventArgs e)
        {

        }

        private void errorTextbox_Click(object sender, EventArgs e)
        {

        }
    }
}