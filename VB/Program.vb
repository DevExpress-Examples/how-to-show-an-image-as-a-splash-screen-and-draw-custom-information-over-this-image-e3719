Imports System
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace SplashScreenManagerSample01

    Friend Module Program

        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Dim image As Image = GetImage()
            ' Show splash image
            SplashScreenManager.ShowImage(image, True, True, SplashImagePainter.Painter)
            Application.Run(New Form1())
        End Sub

        Private Function GetImage() As Image
            Dim asm As Assembly = GetType(Program).Assembly
            Return New Bitmap(asm.GetManifestResourceStream("SplashScreenManagerSample01.Images.DefSplashImage.png"))
        End Function
    End Module
End Namespace
