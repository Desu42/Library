using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
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
            //Application.Run(new login());
            //Application.Run(new add_books());
            //Application.Run(new issue_books());
            //Application.Run(new return_books());
            //Application.Run(new books_stock());
            //Application.Run(new view_books());


            //Application.Run(new add_student_info());
            Application.Run(new view_student_info());
        }
    }
}
