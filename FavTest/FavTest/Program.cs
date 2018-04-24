using FavTest.Models;
using FavTest.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FavTest
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

            MenuForm menuform = new MenuForm();
            Model model = new Model();
            //xxx xxx = new xxx();
            MenuFormPresenter presenter = new MenuFormPresenter(model, menuform);

            //Presenter presenter = new Presenter(model, menuform);
            Application.Run(menuform);
        }
    }
}
