﻿Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Text
Imports DevExpress.XtraSplashScreen

Namespace SplashScreenManagerSample01
	Friend Class SplashImagePainter
		Implements ICustomImagePainter
		Shared Sub New()
			Painter = New SplashImagePainter()
		End Sub
		Protected Sub New()
		End Sub
		Private Shared privatePainter As SplashImagePainter
		Public Shared Property Painter() As SplashImagePainter
			Get
				Return privatePainter
			End Get
			Private Set(ByVal value As SplashImagePainter)
				privatePainter = value
			End Set
		End Property

		Private info As ViewInfo = Nothing
		Public ReadOnly Property ViewInfo() As ViewInfo
			Get
				If Me.info Is Nothing Then
					Me.info = New ViewInfo()
				End If
				Return Me.info
			End Get
		End Property

		#Region "Drawing"
		Public Sub Draw(ByVal cache As GraphicsCache, ByVal bounds As Rectangle) Implements ICustomImagePainter.Draw
			Dim pt As PointF = ViewInfo.CalcProgressLabelPoint(cache, bounds)
			cache.Graphics.DrawString(ViewInfo.Text, ViewInfo.ProgressLabelFont, ViewInfo.Brush, pt)
		End Sub
		#End Region
	End Class

	Friend Class ViewInfo
		Public Sub New()
			Counter = 1
			Stage = String.Empty
		End Sub

		Private privateCounter As Integer
		Public Property Counter() As Integer
			Get
				Return privateCounter
			End Get
			Set(ByVal value As Integer)
				privateCounter = value
			End Set
		End Property
		Private privateStage As String
		Public Property Stage() As String
			Get
				Return privateStage
			End Get
			Set(ByVal value As String)
				privateStage = value
			End Set
		End Property

		Public Function CalcProgressLabelPoint(ByVal cache As GraphicsCache, ByVal bounds As Rectangle) As PointF
			Const yOffset As Integer = 40
			Dim size As Size = TextUtils.GetStringSize(cache.Graphics, Text, ProgressLabelFont)
			Return New Point(bounds.Width / 2 - size.Width / 2, yOffset)
		End Function
		Private progressFont As Font = Nothing
		Public ReadOnly Property ProgressLabelFont() As Font
			Get
				If Me.progressFont Is Nothing Then
					Me.progressFont = New Font("Consolas", 10)
				End If
				Return Me.progressFont
			End Get
		End Property
		Private brush_Renamed As Brush = Nothing
		Public ReadOnly Property Brush() As Brush
			Get
				If Me.brush_Renamed Is Nothing Then
					Me.brush_Renamed = New SolidBrush(Color.Black)
				End If
				Return Me.brush_Renamed
			End Get
		End Property
		Public ReadOnly Property Text() As String
			Get
				Return String.Format("{0} - ({1}%)", Stage, Counter.ToString("D2"))
			End Get
		End Property
	End Class
End Namespace
