using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NumberManipulator
{
    public static class Helper
    {
        public static List<Double> ConvertStringToList(string inputOutputText, ref Label lblError)
        {
            bool errorFound = false;
            string textboxInput = inputOutputText;

            ValidationCheck(textboxInput, ref errorFound, ref lblError);

            if (!errorFound)
            {
                List<Double> list = textboxInput.Split(',').Select(Double.Parse).ToList();

                return list;
            }
            else
                return null;
        }

        private static void ValidationCheck(string textboxInput, ref bool errorFound, ref Label lblError)
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
    }
}
