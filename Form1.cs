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
        public astronomical_processing_application()
        {
            InitializeComponent();
        }
    }
}
