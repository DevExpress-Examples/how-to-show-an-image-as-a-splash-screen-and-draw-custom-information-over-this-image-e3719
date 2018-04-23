Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen

Namespace SplashScreenManagerSample01
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			LongInitialization()
		End Sub
		Protected Sub LongInitialization()
			BaseInitialization()
			LoadFonts()
			LoadTextures()
		End Sub
		
		Private Sub BaseInitialization()
			' Set progress stage to be displayed by SplashImagePainter
			SplashImagePainter.Painter.ViewInfo.Stage = "Initialization"
			For i As Integer = 1 To 100
				System.Threading.Thread.Sleep(20)

				' Change progress to be displayed by SplashImagePainter
				SplashImagePainter.Painter.ViewInfo.Counter = i
				'Force SplashImagePainter to repaint information
				SplashScreenManager.Default.Invalidate()
			Next i
		End Sub
		Private Sub LoadFonts()
			' Set progress stage to be displayed by SplashImagePainter
			SplashImagePainter.Painter.ViewInfo.Stage = "Loading Fonts"
			For i As Integer = 1 To 100
				System.Threading.Thread.Sleep(20)

				' Change progress to be displayed by SplashImagePainter
				SplashImagePainter.Painter.ViewInfo.Counter = i
				'Force SplashImagePainter to repaint information
				SplashScreenManager.Default.Invalidate()
			Next i
		End Sub
		Private Sub LoadTextures()
			' Set progress stage to be displayed by SplashImagePainter
			SplashImagePainter.Painter.ViewInfo.Stage = "Loading Textures"
			For i As Integer = 1 To 100
				System.Threading.Thread.Sleep(20)

				' Change progress to be displayed by SplashImagePainter
				SplashImagePainter.Painter.ViewInfo.Counter = i
				'Force SplashImagePainter to repaint information
				SplashScreenManager.Default.Invalidate()
			Next i
		End Sub
		'

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			' Close splash image
			SplashScreenManager.HideImage()
		End Sub
	End Class
End Namespace
