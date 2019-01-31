Public Class Grid

    Dim mRows, mColumns, mRowIndex, mColumnIndex As Integer
    Dim mRowOffset, mColumnOffset As Single
    Dim mColor As Color
    Dim mCorner1, mCorner2, mCorner3, mCorner4 As PointF

    ''' <summary>
    ''' Constructor for the Grid class
    ''' </summary>
    ''' <param name="_column">The number of columns to assign</param>
    ''' <param name="_row">The number of rows to assign</param>
    Public Sub New(_column As Integer, _row As Integer)
        mRows = _row
        mColumns = _column
        mColor = Color.DarkGray
    End Sub

#Region "Properties"
    ''' <summary>
    ''' Get or set the number of rows in this grid
    ''' </summary>
    ''' <returns></returns>
    Public Property Rows As Integer
        Get
            Return mRows
        End Get
        Set(value As Integer)
            mRows = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set the number of columns in this grid
    ''' </summary>
    ''' <returns></returns>
    Public Property Columns As Integer
        Get
            Return mColumns
        End Get
        Set(value As Integer)
            mColumns = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set the grid color
    ''' </summary>
    ''' <returns></returns>
    Public Property Color As Color
        Get
            Return mColor
        End Get
        Set(value As Color)
            mColor = value
        End Set
    End Property

#End Region

#Region "Accessors"
    ''' <summary>
    ''' Get the corner point
    ''' </summary>
    ''' <returns></returns>
    Public Function Corner() As PointF
        Return mCorner1
    End Function

    ''' <summary>
    ''' Get the width of a cell
    ''' </summary>
    ''' <returns></returns>
    Public Function RectWidth() As Single
        Return (mCorner3.X - mCorner1.X)
    End Function

    ''' <summary>
    ''' Get the height of a cell
    ''' </summary>
    ''' <returns></returns>
    Public Function RectHeight() As Single
        Return (mCorner2.Y - mCorner1.Y)
    End Function

    ''' <summary>
    ''' Get the row index
    ''' </summary>
    ''' <returns></returns>
    Public Function RowIndex() As Integer
        Return mRowIndex
    End Function

    ''' <summary>
    ''' Get the column index
    ''' </summary>
    ''' <returns></returns>
    Public Function ColumnIndex() As Integer
        Return mColumnIndex
    End Function

    ''' <summary>
    ''' Get the row offset
    ''' </summary>
    ''' <returns></returns>
    Public Function RowOffset() As Single
        Return mRowOffset
    End Function

    ''' <summary>
    ''' Get the column offset
    ''' </summary>
    ''' <returns></returns>
    Public Function ColumnOffset() As Single
        Return mColumnOffset
    End Function

#End Region

    ''' <summary>
    ''' Draw the grid to the panel
    ''' </summary>
    ''' <param name="g">Target graphics panel</param>
    ''' <param name="e">GDI Drawing Surface</param>
    Public Sub DrawGrid(g As GraphicsPanel, e As Graphics)
        mRowOffset = Convert.ToSingle(g.ClientSize.Height) / mRows
        mColumnOffset = Convert.ToSingle(g.ClientSize.Width) / mColumns

        For i As Integer = 1 To mRows
            e.DrawLine(New Pen(mColor), 0, i * mRowOffset, g.ClientSize.Width, i * mRowOffset)
            CheckLocation(New Point(i, i))
        Next

        For i As Integer = 1 To mColumns
            e.DrawLine(New Pen(mColor), i * mColumnOffset, 0, i * mColumnOffset, g.ClientSize.Height)
            CheckLocation(New Point(i, i))
        Next

    End Sub

    ''' <summary>
    ''' Calculates the location of a point
    ''' </summary>
    ''' <param name="p">The point to calculate</param>
    ''' <returns></returns>
    Public Function CheckLocation(p As Point) As Point

        Dim rPoint As New Point()

        For i As Integer = 1 To mRows
            If (p.Y > mRowOffset * (i - 1)) AndAlso (p.Y < mRowOffset * i) Then
                mCorner1.Y = mRowOffset * (i - 1)
                mCorner2.Y = mRowOffset * i
                mCorner3.Y = mRowOffset * (i - 1)
                mCorner4.Y = mRowOffset * i
                mRowIndex = (i - 1)
                rPoint.Y = i
            End If
        Next

        For i As Integer = 1 To mColumns
            If (p.X > mColumnOffset * (i - 1)) AndAlso (p.X < mColumnOffset * i) Then
                mCorner1.X = mColumnOffset * (i - 1)
                mCorner2.X = mColumnOffset * (i - 1)
                mCorner3.X = mColumnOffset * i
                mCorner4.X = mColumnOffset * i
                mColumnIndex = (i - 1)
                rPoint.X = i
            End If
        Next

        Return rPoint
    End Function

End Class
