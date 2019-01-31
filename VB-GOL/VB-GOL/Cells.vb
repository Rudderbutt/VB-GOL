Public Class Cells

    Dim cState As Boolean
    Dim cPoint As Point
    Dim cGridLimits As Point
    Dim cColor As Color
    Dim cNeighbors As Integer


    ''' <summary>
    ''' Constructor for Cells class
    ''' </summary>
    Public Sub New()
        cState = False
        cPoint = New Point
        cGridLimits = New Point
        cColor = Color.Black
        cNeighbors = 0
    End Sub

#Region "Properties"

    ''' <summary>
    ''' Get or set the living state of this cell
    ''' </summary>
    ''' <returns></returns>
    Public Property IsAlive As Boolean
        Get
            Return cState
        End Get
        Set(value As Boolean)
            cState = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set the cell point
    ''' </summary>
    ''' <returns></returns>
    Public Property CellPoint As Point
        Get
            Return cPoint
        End Get
        Set(value As Point)
            cPoint = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set the cell color
    ''' </summary>
    ''' <returns></returns>
    Public Property Color As Color
        Get
            Return cColor
        End Get
        Set(value As Color)
            cColor = value
        End Set
    End Property

    ''' <summary>
    ''' Get or set the neighbor value of the cell
    ''' </summary>
    ''' <returns></returns>
    Public Property Neighbors As Integer
        Get
            Return cNeighbors
        End Get
        Set(value As Integer)
            cNeighbors = value
        End Set
    End Property

#End Region

    ''' <summary>
    ''' Method to set the max size of the grid area
    ''' </summary>
    ''' <param name="x">The X limit</param>
    ''' <param name="y">The Y limit</param>
    Public Sub GridLimit(x As Integer, y As Integer)
        cGridLimits.X = x
        cGridLimits.Y = y
    End Sub

End Class
