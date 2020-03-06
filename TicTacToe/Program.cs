using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
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
            Application.Run(new StartForm());
        }
    }
}


// 1. сократить код, который повторяется (с помощью методов)
// 2. заюзать тернарный оператор где короткие ифы, если можно
// 3. сократить большую логику в ифах где код не одинаковый, сокращение чисто для того чтоб ифы выглядели красиво и компактно