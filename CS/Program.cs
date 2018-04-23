using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace SplashScreenManagerSample01 {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Image image = GetImage();
            // Show splash image
            SplashScreenManager.ShowImage(image, true, true, SplashImagePainter.Painter);

            Application.Run(new Form1());
        }
        static Image GetImage() {
            Assembly asm = typeof(Program).Assembly;
            return new Bitmap(asm.GetManifestResourceStream("SplashScreenManagerSample01.Images.DefSplashImage.png"));
        }
    }
}
