Public Class Preferences

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        '' Set dialog result for buttons
        OKButton.DialogResult = DialogResult.OK
        CancelButton.DialogResult = DialogResult.Cancel


    End Sub

    Public Sub SetValues(_ms As Integer, _width As Integer, _height As Integer, _gColor As Color, _bColor As Color, _cColor As Color, _universe As Integer)
        MSUD.Value = _ms
        UWUD.Value = _width
        UHUD.Value = _height
        Grid_Button.BackColor = _gColor
        BG_Button.BackColor = _bColor
        Cell_Button.BackColor = _cColor

        If _universe = 0 Then
            finiteRB.Checked = True
        Else
            toroidRB.Checked = True
        End If

    End Sub

    Private Sub BG_Button_Click(sender As Object, e As EventArgs) Handles BG_Button.Click
        Dim color As New ColorDialog()

        If (color.ShowDialog() = DialogResult.OK) Then
            BG_Button.BackColor = color.Color
        End If
    End Sub

    Private Sub Grid_Button_Click(sender As Object, e As EventArgs) Handles Grid_Button.Click
        Dim color As New ColorDialog()

        If (color.ShowDialog() = DialogResult.OK) Then
            Grid_Button.BackColor = color.Color
        End If
    End Sub

    Private Sub Cell_Button_Click(sender As Object, e As EventArgs) Handles Cell_Button.Click
        Dim color As New ColorDialog()

        If (color.ShowDialog() = DialogResult.OK) Then
            Cell_Button.BackColor = color.Color
        End If
    End Sub

    ''' <summary>
    ''' Get the time interval
    ''' </summary>
    ''' <returns></returns>
    Public Function Interval() As Integer
        Return MSUD.Value
    End Function

    ''' <summary>
    ''' Get the width of the universe
    ''' </summary>
    ''' <returns></returns>
    Public Function UniverseWidth() As Integer
        Return UWUD.Value
    End Function

    ''' <summary>
    ''' Get the height of the universe
    ''' </summary>
    ''' <returns></returns>
    Public Function UniverseHeight() As Integer
        Return UHUD.Value
    End Function

    ''' <summary>
    ''' Get the grid color
    ''' </summary>
    ''' <returns></returns>
    Public Function GridColor() As Color
        Return Grid_Button.BackColor
    End Function

    ''' <summary>
    ''' Get the background color
    ''' </summary>
    ''' <returns></returns>
    Public Function BackgoundColor() As Color
        Return BG_Button.BackColor
    End Function

    ''' <summary>
    ''' Get the cell color
    ''' </summary>
    ''' <returns></returns>
    Public Function CellColor() As Color
        Return Cell_Button.BackColor
    End Function

    ''' <summary>
    ''' Get the universe type (infinite or toroidal
    ''' </summary>
    ''' <returns></returns>
    Public Function UniverseType() As Integer
        Return If(finiteRB.Checked, 0, 1)
    End Function

End Class