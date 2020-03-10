using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace NumberManipulator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        #region Main Logic

        private static int getMaxValueIndex(List<Double> list)
        {
            int i = 1;
            double largestItem = list[0];
            double item = 0.0;

            while (i < list.Count)
            {
                item = list[i];

                if (item > largestItem)
                    largestItem = item;

                i++;
            }
           
            return (int)Math.Round(largestItem, 0);
        }

        public static int getMinValueIndex(List<Double> list)
        {
            int i = 1;
            double smallestItem = list[0];
            double item = 0.0;

            while (i < list.Count)
            {
                item = list[i];

                if (item < smallestItem)
                    smallestItem = item;

                i++;
            }

            return (int)Math.Round(smallestItem, 0);
        }

        public void normalise(List<Double> list)
        {
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

            string outputString = string.Join(",", list.ToArray());

            textBox1.Text = outputString;
        }

        public void sort(List<Double> list)
        {
            int previousItem;
            double itemToProcess;

            for (int listItem = 1; listItem < list.Count; listItem++)
            {
                itemToProcess = list[listItem];

                previousItem = listItem - 1;

                while(previousItem >= 0 && list[previousItem] > itemToProcess)
                {
                    list[previousItem + 1] = list[previousItem];

                    previousItem--;
                }

                list[previousItem + 1] = itemToProcess;
            }

            string outputString = string.Join(",", list.ToArray());

            textBox1.Text = outputString;
        }

        #endregion

        #region Helper Functions

        public List<Double> convertStringToList()
        {
            bool errorFound = false;
            string textboxInput = textBox1.Text;

            validationCheck(textboxInput, ref errorFound);

            if (!errorFound)
            {
                List<Double> list = textboxInput.Split(',').Select(Double.Parse).ToList();

                return list;
            }
            else
                return null;
        }

        public void validationCheck(string textboxInput, ref bool errorFound)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textboxInput))
            {
                errorMessage = "Error: Please input a list of numbers";
                errorFound = true;
            }

            if (errorFound)
            {
                errorTextbox.Visible = true;
                errorTextbox.Text = errorMessage;
            }
            else
                errorTextbox.Visible = false;
        }

        #endregion

        #region UI Functions

        private void MaxValueButton_Click_1(object sender, EventArgs e)
        {
            List<Double> list = convertStringToList();

            if (list != null)
            {
                label2.Text = getMaxValueIndex(list).ToString();

                largestLabel.Visible = true;
                smallestLabel.Visible = false;
            }
        }

        private void MinValueButton_Click_1(object sender, EventArgs e)
        {
            List<Double> list = convertStringToList();

            if (list != null)
            {
                label2.Text = getMinValueIndex(list).ToString();

                largestLabel.Visible = false;
                smallestLabel.Visible = true;
            }
        }

        private void NormalizeButton_Click_1(object sender, EventArgs e)
        {
            largestLabel.Visible = false;
            smallestLabel.Visible = false;
            label2.Visible = false;

            List<Double> list = convertStringToList();

            if (list != null)
                normalise(list);
        }

        private void SortButton_Click_1(object sender, EventArgs e)
        {
            largestLabel.Visible = false;
            smallestLabel.Visible = false;
            label2.Visible = false;

            List<Double> list = convertStringToList();

            if (list != null)
                sort(list);
        }

        #endregion

        #region Unused functions

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

        #endregion
    }
}