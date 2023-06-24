using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScribbleSyncClient
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
            //Application.Run(new Form_Initial());
            Application.Run(new Form_Login());
            //Application.Run(new Form_Control());
            //Application.Run(new Form_Note());
            //Application.Run(new Form_List_Note());
            //Application.Run(new Form_Change_Profile());
            //Application.Run(new Form_Share());
            //Application.Run(new Form1());
        }
    }
}
