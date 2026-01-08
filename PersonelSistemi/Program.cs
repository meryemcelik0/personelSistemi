using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelSistemi
{
    internal static class Program
    {
        public static string AktifKullaniciAd = "";
        public static string AktifRol = "";
        public static int AktifPersonelID = 0;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
