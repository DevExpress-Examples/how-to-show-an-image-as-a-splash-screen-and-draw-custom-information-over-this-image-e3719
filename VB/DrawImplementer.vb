Imports System.Drawing
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils.Text
Imports DevExpress.XtraSplashScreen

Namespace SplashScreenManagerSample01

    Friend Class SplashImagePainter
        Inherits ICustomImagePainter

        Private Shared _Painter As SplashImagePainter

        Shared Sub New()
            Painter = New SplashImagePainter()
        End Sub

        Protected Sub New()
        End Sub

        Public Shared Property Painter As SplashImagePainter
            Get
                Return _Painter
            End Get

            Private Set(ByVal value As SplashImagePainter)
                _Painter = value
            End Set
        End Property

        Private info As ViewInfo = Nothing

        Public ReadOnly Property ViewInfo As ViewInfo
            Get
                If info Is Nothing Then info = New ViewInfo()
                Return info
            End Get
        End Property

#Region "Drawing"
        Public Sub Draw(ByVal cache As GraphicsCache, ByVal bounds As Rectangle)
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

        Public Property Counter As Integer

        Public Property Stage As String

        Public Function CalcProgressLabelPoint(ByVal cache As GraphicsCache, ByVal bounds As Rectangle) As PointF
            Const yOffset As Integer = 40
            Dim size As Size = TextUtils.GetStringSize(cache.Graphics, Text, ProgressLabelFont)
            Return New Point(bounds.Width / 2 - size.Width / 2, yOffset)
        End Function

        Private progressFont As Font = Nothing

        Public ReadOnly Property ProgressLabelFont As Font
            Get
                If progressFont Is Nothing Then progressFont = New Font("Consolas", 10)
                Return progressFont
            End Get
        End Property

        Private brushField As Brush = Nothing

        Public ReadOnly Property Brush As Brush
            Get
                If brushField Is Nothing Then brushField = New SolidBrush(Color.Black)
                Return brushField
            End Get
        End Property

        Public ReadOnly Property Text As String
            Get
                Return String.Format("{0} - ({1}%)", Stage, Counter.ToString("D2"))
            End Get
        End Property
    End Class
End Namespace
