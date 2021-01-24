///     Main class
///     
/// I certify that this material is my original 
/// work. No other person's has been used without 
/// due acknowledgement. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Class for Lab3B
/// </summary>
namespace HairSalon {

    /// <summary>
    /// Lab3B Class
    /// Runs application
    /// </summary>
    static class Lab {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();   // enables visual styles from Form1 classes
            Application.SetCompatibleTextRenderingDefault(false); // method application wide default
            Application.Run(new Form1()); // opens application
        }
    }
}