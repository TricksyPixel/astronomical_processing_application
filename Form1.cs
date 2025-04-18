// Author Name: Kiersti Collins, 30118758
// Team Name: Thi and Kier
// Sprint Number: 1
// Date: 16/04/2025
//
// Version: 1.0
// Program Name: Astronomical Processing
//
// Description: Application that displays neutrino data pulled from a local
// observatory over 24 hour intervals. Data is stored as an array and
// displayed. Users can sort the data numerically. Users can search the data
// and edit data manually.
//
// Inputs:      Search input, new value input
//
// Processes:   Randomize numbers to array (to simulate the data stream),
//              Binary Search, Modify Data, Bubble Sort
//
// Outputs:     Data array in listbox, Search results in Results listbox

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        // Modify Element Button.
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            // Modify specific data element.
            // Select hour by using DataListBox.SelectedIndex.
            // Take the selected hour element and user input value, then replace.
        }
        
        // Bubble Sort Button.
        private void SortButton_Click(object sender, EventArgs e)
        {
            // Run Bubble Sort here.
            // Once sorted, refresh DataListBox element with updated array.
        }

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

        // Custom close and minimize buttons.
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
