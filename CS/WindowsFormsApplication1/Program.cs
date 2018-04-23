using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace WindowsFormsApplication1 {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set the Office 2007 Blue skin
            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.UseWindowsXPTheme = false;
            UserLookAndFeel.Default.Style = LookAndFeelStyle.Skin;
            UserLookAndFeel.Default.SkinName = "Office 2007 Blue";

            Application.Run(new Form1());
        }
    }
}
