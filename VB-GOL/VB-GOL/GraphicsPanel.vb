Public Class GraphicsPanel
    Inherits Panel

    ''' <summary>
    ''' Constructor
    ''' </summary>
    Public Sub New()
        MyBase.New()

        '' Create a double-buffered graphics panel that redraws when resized
        DoubleBuffered = True
        SetStyle(ControlStyles.ResizeRedraw, True)

    End Sub

End Class
