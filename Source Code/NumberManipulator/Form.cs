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

        private int GetMaxValueIndex(List<Double> list)
        {
            int i = 1;
            double largestItem = list[0];
            int largestItemIndex = 0;
            double item = 0.0;

            while (i < list.Count)
            {
                item = list[i];

                if (item > largestItem)
                {
                    largestItem = item;
                    largestItemIndex = i;
                }

                i++;
            }
           
            return largestItemIndex;
        }

        public int GetMinValueIndex(List<Double> list)
        {
            int i = 1;
            double smallestItem = list[0];
            int smallestItemIndex = 0;
            double item = 0.0;

            while (i < list.Count)
            {
                item = list[i];

                if (item < smallestItem)
                {
                    smallestItem = item;
                    smallestItemIndex = i;
                }

                i++;
            }

            return smallestItemIndex;
        }

        public List<Double> NormaliseList(List<Double> list)
        {
            List<Double> sortedList = InsertionSort(list);

            for (int i = 0; i < sortedList.Count; i++)
            {
                sortedList[i] = i - 1;
            }

            return sortedList;
        }

        public List<Double> InsertionSort(List<Double> list)
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

            return list;
        }

        #endregion

        #region Helper Functions

        public List<Double> ConvertStringToList()
        {
            bool errorFound = false;
            string textboxInput = txtInputOutput.Text;

            ValidationCheck(textboxInput, ref errorFound);

            if (!errorFound)
            {
                List<Double> list = textboxInput.Split(',').Select(Double.Parse).ToList();

                return list;
            }
            else
                return null;
        }

        public void ValidationCheck(string textboxInput, ref bool errorFound)
        {
            string errorMessage = "";

            if (string.IsNullOrWhiteSpace(textboxInput))
            {
                errorMessage = "Error: Please input a list of numbers";
                errorFound = true;
            }

            if (errorFound)
            {
                lblError.Visible = true;
                lblError.Text = errorMessage;
            }
            else
                lblError.Visible = false;
        }

        #endregion

        #region UI Functions

        private void btnMaxValue_Click_1(object sender, EventArgs e)
        {
            List<Double> list = ConvertStringToList();

            if (list != null)
            {
                lblSmallestLargestNumber.Text = GetMaxValueIndex(list).ToString();

                lblLargest.Visible = true;
                lblSmallest.Visible = false;
            }
        }

        private void btnMinValue_Click_1(object sender, EventArgs e)
        {
            List<Double> list = ConvertStringToList();

            if (list != null)
            {
                lblSmallestLargestNumber.Text = GetMinValueIndex(list).ToString();

                lblLargest.Visible = false;
                lblSmallest.Visible = true;
            }
        }

        private void btnNormalise_Click_1(object sender, EventArgs e)
        {
            lblLargest.Visible = false;
            lblSmallest.Visible = false;
            lblSmallestLargestNumber.Visible = false;

            List<Double> list = ConvertStringToList();

            if (list != null)
            {
                string outputString = string.Join(",", NormaliseList(list).ToArray());

                txtInputOutput.Text = outputString;
            }
        }

        private void btnSortAscending_Click_1(object sender, EventArgs e)
        {
            lblLargest.Visible = false;
            lblSmallest.Visible = false;
            lblSmallestLargestNumber.Visible = false;

            List<Double> list = ConvertStringToList();

            if (list != null)
            {
                string outputString = string.Join(",", InsertionSort(list).ToArray());

                txtInputOutput.Text = outputString;
            }
        }

        #endregion
    }
}