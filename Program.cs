using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Windown_form
{
    class Program
    {
        static void Main(string[] args)
        {
            MainForm mainform = new MainForm();
            mainform.ShowDialog();

            Console.ReadKey();
        }
    }
}
