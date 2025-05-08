// Author Name: Kiersti Collins, 30118758
// Team Name: Thi and Kier
// Sprint Number: 2
// Date: 1/05/2025
//
// Version: 1.1
// Program Name: Astronomical Processing
//
// Description: v1.0 - Application that displays neutrino data pulled from a local
// observatory over 24 hour intervals. Data is stored as an array and
// displayed. Users can sort the data numerically. Users can search the data
// and edit data manually.
//              v1.1 - Added ability to calculate the mid-extreme, mode, average,
//                     and the range of the data.
//                   - Added a sequential search.
//                   - GUI changes.
//
// Inputs:      Search input, new value input
//
// Processes:   v1.0 -  Randomize numbers to array (to simulate the data stream),
//                      Binary Search, Modify Data, Bubble Sort
//              v1.1 -  Sequential Search, Calculate mid-extreme, mode, average, range.
//
// Outputs:     v1.0 -  Data array in listbox, Search results in Results listbox.
//              v1.1 -  Calculation Results in listboxes for mid-extreme, mode, average, range.

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

namespace astronomical_processing_application
{
    public partial class astronomical_processing_application : Form
    {
        // Global attributes.

        // Create the array for storing data stream.
        static int max = 24;
        int[] dataArray = new int[max];

        // Start application.
        public astronomical_processing_application()
        {
            InitializeComponent();

            // Call FillArray method to fill array on startup.
            FillArray();

            // Call DisplayArray to display the neutrino data onto the DataListBox.
            DisplayArray();
        }

        // SEARCH DATA GROUP

        // Binary Search Button
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Sort the array if it's still out of order
            // to ensure binary search can run correctly.
            Array.Sort(dataArray);
            DisplayArray();

            // Run Binary Search.
            int mid;
            int min = 0;
            int max = dataArray.Length;
            int target;

            if (!(Int32.TryParse(SearchTextBox.Text, out target)))
            {
                MessageBox.Show("You must enter an integer number.");
                return;
            }
            while (min <= max)
            {
                mid = (min + max) / 2;

                if (dataArray[mid] == target)
                {
                    ResultsListBox.Items.Clear();
                    SearchTextBox.Clear();
                    ResultsListBox.Items.Add("Searching for: " + target);
                    ResultsListBox.Items.Add(" ");
                    ResultsListBox.Items.Add("Found search result at index: " + (mid + 1));
                    DataListBox.SetSelected(mid, true);
                    return;
                }
                else if (dataArray[mid] >= target)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            // If search result comes back unsuccessful, display this to user
            // in the Results ListBox.
            //ResultsListBox.Items.Clear();
            //ResultsListBox.Items.Add("Search result not found. Please try again.");
            MessageBox.Show("Search result not found. Please try again.");
            SearchTextBox.Clear();
        }// End Binary Search Button.

        // Sequential Search Button.
        private void SequentialSearchButton_Click(object sender, EventArgs e)
        {
            int target;
            int max = dataArray.Length;
            bool found = false;

            // Check for correct user input.
            if (!(Int32.TryParse(SearchTextBox.Text, out target)))
            {
                MessageBox.Show("You must enter an integer number.");
                return;
            }
            
            // Run sequential search.
            for (int x = 0; x < max; x++)
            {
                if (dataArray[x] == target)
                {
                    ResultsListBox.Items.Clear();
                    SearchTextBox.Clear();
                    ResultsListBox.Items.Add("Searching for: " + target);
                    ResultsListBox.Items.Add(" ");
                    ResultsListBox.Items.Add("Found search result at index: " + (x + 1));
                    DataListBox.SetSelected(x, true);
                    found = true;
                    return;
                }
            }
            if (!found)
            {
                MessageBox.Show("Search result not found. Please try again.");
                SearchTextBox.Clear();
            }
        }// End Sequential Search Button.

        // Modify Element Button.
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            // Modify specific data element.
            // Select element by using DataListBox.SelectedIndex.
            // Take the selected element and user input value (NewValueTextBox), then replace.
            int newValue;
            int selected = DataListBox.SelectedIndex;

            if (!(Int32.TryParse(NewValueTextBox.Text, out newValue)))
            {
                MessageBox.Show("You must enter an integer number.");
                return;
            }
            if (selected != -1)// Ensures an item has first been selected.
            {
                if (newValue >= 10 && newValue <= 90)
                {
                    dataArray[selected] = newValue;
                    DisplayArray();
                    return;
                }
                else
                {
                    MessageBox.Show("Please enter an integer number between 10 and 90.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No index selected. Please select which index you want to modify in the Data list first.");
                return;
            }
        }// End Modify Element Button.

        // SORT GROUP

        // Bubble Sort Button.
        private void SortButton_Click(object sender, EventArgs e)
        {
            // Run Bubble Sort here.
            int max = dataArray.Length;
            int temp = 0;

            for (int outer = 0; outer < max; outer++)
            {
                for (int inner = 0; inner < max - 1; inner++)
                {
                    if (dataArray[inner] > dataArray[inner + 1])
                    {
                        temp = dataArray[inner + 1];
                        dataArray[inner + 1] = dataArray[inner];
                        dataArray[inner] = temp;
                    }
                }
            }
            // Once sorted, refresh DataListBox element with updated array.
            DisplayArray();
        }// End Bubble Sort Button

        // CALCULATIONS GROUP

        // Run Mid-Extreme calculation.
        private void MidExtremeButton_Click(object sender, EventArgs e)
        {
            float smallest = dataArray[0];
            float largest = dataArray[0];
            float midExtreme;

            // Calculate the smallest, then largest array elements.
            for (int x = 0; x < max; x++)
            {
                if (dataArray[x] < smallest)
                {
                    smallest = dataArray[x];
                }
            }
            for (int x = 0; x < max; x++)
            {
                if (dataArray[x] > largest)
                {
                    largest = dataArray[x];
                }
            }

            // Calculate the mid-extreme and output result into the results listbox.
            midExtreme = (smallest + largest) / 2;

            MidExtremeResultsListBox.Items.Clear();
            MidExtremeResultsListBox.Items.Add("Smallest value: " + smallest);
            MidExtremeResultsListBox.Items.Add("Largest value: " + largest);
            MidExtremeResultsListBox.Items.Add("Mid-extreme: " + midExtreme);
        }// End Mid-Extreme Calculation.

        // Run Mode Calculation.
        private void ModeButton_Click(object sender, EventArgs e)
        {
            int element;
            int frequency = 1;
            int max = dataArray.Length;
            int mode = 0;
            int counter;

            // Calculate the mode.
            for (int i = 0; i < max; i++)
            {
                counter = 0;
                element = dataArray[i];
                for (int j = 0; j < max; j++)
                {
                    if (element == dataArray[j])
                    {
                        counter++;
                    }
                }
                if (counter >= frequency)
                {
                    frequency = counter;
                    mode = element;
                }
            }

            // Display the results into the Mode results textbox.
            ModeResultsListBox.Items.Clear();
            ModeResultsListBox.Items.Add("Mode: " + mode);
            ModeResultsListBox.Items.Add("Appearances: " + frequency);
        }// End Mode Calculation.

        // Run Average Calculation.
        private void AverageButton_Click(object sender, EventArgs e)
        {
            float average;
            float max = dataArray.Length;
            float currentIndex = dataArray[0];
            float additionResult = 0;

            for (int x = 0; x < max; x++)
            {
                currentIndex = dataArray[x];
                additionResult = currentIndex + additionResult;
            }

            average = additionResult / max;
            // Use the average as a 2 decimal point in a string.
            string twoDecimalAverage = $"{average:F2}";

            // Display the results into the Average results textbox.
            AverageResultsListBox.Items.Clear();
            AverageResultsListBox.Items.Add("Average: " + twoDecimalAverage);

        }// End Average Calculation.

        // Run Range Calculation.
        private void RangeButton_Click(object sender, EventArgs e)
        {
            int smallest = dataArray[0];
            int largest = dataArray[0];
            int range;

            // Get the smallest and largest results from the data array.
            for (int x = 1; x < max; x++)
            {
                if (dataArray[x] < smallest)
                {
                    smallest = dataArray[x];
                }
            }
            for (int x = 1; x < max; x++)
            {
                if (dataArray[x] > largest)
                {
                    largest = dataArray[x];
                }
            }

            // Calculate the difference between the largest and smallest to
            // get the range.
            range = largest - smallest;

            //Display results to the Range results textbox.
            RangeResultsListBox.Items.Clear();
            RangeResultsListBox.Items.Add("Range: " + range);
        }// End Range Calculation.

        // Method to fill the array with random numbers (to represent the
        // neutrino data stream pulled from the local observatory.
        private void FillArray()
        {
            // Create random number between 10 to 90
            Random rand = new Random();
            for (int i = 0; i < max; i++)
            {
                // Store random numbers between 10 and 90 into the array elements.
                dataArray[i] = rand.Next(10, 90);
            }
        }

        // Method to display the array to the DataListBox.
        private void DisplayArray()
        {
            DataListBox.Items.Clear();
            for (int i = 0; i < max; i++)
            {
                DataListBox.Items.Add(dataArray[i]);
            }
        }

        // Custom close and minimize buttons for borderless form.
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MinimizeButton_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        // Make window draggable from top panel.
        private bool mouseDown;
        private Point lastLocation;

        private void MouseDownPanel(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MouseMovePanel(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MouseUpPanel(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
