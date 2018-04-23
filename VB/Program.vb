Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace SplashScreenManagerSample01
	Friend NotInheritable Class Program
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			Dim image As Image = GetImage()
			' Show splash image
			SplashScreenManager.ShowImage(image, True, True, SplashImagePainter.Painter)

			Application.Run(New Form1())
		End Sub
		Private Shared Function GetImage() As Image
			Dim asm As System.Reflection.Assembly = GetType(Program).Assembly
			Return New Bitmap(asm.GetManifestResourceStream("DefSplashImage.png"))
		End Function
	End Class
End Namespace
