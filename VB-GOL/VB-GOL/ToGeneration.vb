Public Class ToGeneration

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        OKButton.DialogResult = DialogResult.OK
        CancelButton.DialogResult = DialogResult.Cancel

        NumericUpDown1.Maximum = 10000
    End Sub


    ''' <summary>
    ''' Get the amount of generations fo run for
    ''' </summary>
    ''' <returns></returns>
    Public Function GetGeneration() As Integer
        Return NumericUpDown1.Value
    End Function
End Class