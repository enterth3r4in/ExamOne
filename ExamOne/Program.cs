using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/**Exam One In Class
 * Author: Cody Miller

* Project Purpose: To calculate and display output stating a distance a vehicle can travel
* based on a given speed in 3 set time limits.

* Input:  This program accepts a number in miles per hour and button clicks

* Desired Output:  The calculations are performed and the distance the vehicle can travel in that time
* is displayed on the screen.

* Variables and Classes: Form partial class. doubles for the vehicle speed the user enters
* and the distance traveled as well as generic time variables to allow easier editing.

* Formulas: strings are concatenated to form coherent messages for output as well as the 
* distance being calculated

* Description of the main algorithm: The program runs until the user tells it to exit. It waits for a user to input 
* a speed and then calculates and displays the output.
 
* Testing: When 50 is entered, the 5 hour button should display 250 miles, the eight hour button should
* display 400 miles and the 12 hour button should display 600 miles

* February 8, 2016
**/

namespace ExamOne
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
