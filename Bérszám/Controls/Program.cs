using Bérszám.Forms;
using Bérszám.Model;
using Bérszám.Operation;

namespace Bérszám.Controls
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            /*Select<customers_table> a = new Select<customers_table>();
            List<customers_table> test = new List<customers_table>();
            test = a.Select_querry();
            String st = "10";
            holiday_table test3 = new holiday_table(3, new DateTime(1997,02,03), new DateTime(1997, 02, 03));
            Insert<holiday_table> test2= new Insert<holiday_table>(test3);
            
            List<holiday_table> c = new List<holiday_table>();
            c = new Select<holiday_table>().Select_querry();*/
            Application.Run(new FormMain());

        }
    }
}