Imports System.IO

Public Class Form1
    Dim mL, mH, mTime, mFinite, mAlive, mGenerations, mSeed As Integer
    Dim mUniverse(,), mScratchpad(,) As Cells
    Dim mGrid As Grid
    Dim WithEvents time As Timer
    Dim mStream As FileStream
    Dim mRand As Random
    Dim mNeighborArray() As Point = {New Point(-1, -1), New Point(-1, 0), New Point(-1, 1), New Point(0, -1), New Point(0, 1), New Point(1, -1), New Point(1, 0), New Point(1, 1)}

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mL = 100
        mH = 100
        mTime = 20
        time = New Timer

        mAlive = 0
        mFinite = 1
        mSeed = 123456789

        ReDim mUniverse(mL + 1, mH + 1)
        ReDim mScratchpad(mL + 1, mH + 1)


        For i As Integer = 0 To mUniverse.GetLength(0) - 1
            For j As Integer = 0 To mUniverse.GetLength(1) - 1
                mUniverse(i, j) = New Cells
                mUniverse(i, j).GridLimit(mL, mH)
                mUniverse(i, j).CellPoint = New Point(i, j)
                mScratchpad(i, j) = New Cells
                mScratchpad(i, j).GridLimit(mL, mH)
                mScratchpad(i, j).CellPoint = New Point(i, j)
            Next
        Next

        mGrid = New Grid(mL, mH)
        ToolStripStatusLabel1.Text = "Generations: " + mGenerations.ToString
        ToolStripStatusLabel2.Text = "Interval: " + mTime.ToString
        ToolStripStatusLabel3.Text = "Living Cells: " + mAlive.ToString
        ToolStripStatusLabel4.Text = "Seed: " + mSeed.ToString
        time.Interval = mTime
        time.Enabled = False
        PauseToolStripButton.Enabled = False
        ''pauseToolStripMenuItem.Enabled = False;

    End Sub

    Private Sub Time_Tick(sender As Object, ByVal e As EventArgs) Handles time.Tick, StepToolStripButton.Click
        mScratchpad = mUniverse
        mAlive = 0

        '' Reset neighbot count and tally living cells
        For i As Integer = 0 To mScratchpad.GetLength(0) - 1
            For j As Integer = 0 To mScratchpad.GetLength(1) - 1
                mScratchpad(i, j).Neighbors = 0

                If (mScratchpad(i, j).IsAlive) Then
                    mAlive += 1
                End If
            Next
        Next

        '' Check and count living neighbors
        For i As Integer = 0 To mScratchpad.GetLength(0) - 1
            For j As Integer = 0 To mScratchpad.GetLength(1) - 1
                Dim mNeighbors As Integer = 0

                Select Case mFinite
                    Case 0
                        For n As Integer = 0 To mNeighborArray.Length - 1
                            Dim coordX, coordY As Integer
                            coordX = i + mNeighborArray(n).X
                            coordY = j + mNeighborArray(n).Y

                            If (coordX >= 0) AndAlso (coordY >= 0) AndAlso (coordX < mScratchpad.GetLength(0)) AndAlso (coordY < mScratchpad.GetLength(1)) Then
                                If (mScratchpad(coordX, coordY).IsAlive) Then
                                    mNeighbors += 1
                                End If
                            End If
                        Next
                    Case 1
                        For n As Integer = 0 To mNeighborArray.Length - 1
                            Dim coordX, coordY As Integer
                            coordX = i + mNeighborArray(n).X
                            coordY = j + mNeighborArray(n).Y

                            If (coordX < 0) Or (coordX >= mScratchpad.GetLength(0)) Then
                                coordX = (coordX + mL) Mod mL
                            End If

                            If (coordY < 0) Or (coordY >= mScratchpad.GetLength(1)) Then
                                coordY = (coordY + mH) Mod mH
                            End If

                            If (mScratchpad(coordX, coordY).IsAlive) Then
                                mNeighbors += 1
                            End If
                        Next
                End Select
                mScratchpad(i, j).Neighbors += mNeighbors
            Next
        Next

        For i As Integer = 0 To mScratchpad.GetLength(0) - 1
            For j As Integer = 0 To mScratchpad.GetLength(1) - 1
                If (mScratchpad(i, j).Neighbors < 2) Then
                    mScratchpad(i, j).IsAlive = False
                End If
                If (mScratchpad(i, j).Neighbors > 3) Then
                    mScratchpad(i, j).IsAlive = False
                End If
                If (Not mScratchpad(i, j).IsAlive) AndAlso (mScratchpad(i, j).Neighbors = 3) Then
                    mScratchpad(i, j).IsAlive = True
                End If
            Next
        Next

        mUniverse = mScratchpad
        mGenerations += 1

        ToolStripStatusLabel1.Text = "Generations: " + mGenerations.ToString
        ToolStripStatusLabel3.Text = "Living Cells: " + mAlive.ToString

        GraphicsPanel1.Invalidate()
    End Sub

    Private Sub GraphicsPanel1_Click(sender As Object, e As MouseEventArgs) Handles GraphicsPanel1.MouseClick
        Dim tmp As New Point

        If (e.Button = MouseButtons.Left) Then
            tmp = mGrid.CheckLocation(e.Location)

            For i As Integer = 0 To mUniverse.GetLength(0) - 1
                For j As Integer = 0 To mUniverse.GetLength(1) - 1
                    If (tmp.X = i) AndAlso (tmp.Y = j) Then
                        mUniverse(i, j).IsAlive = Not mUniverse(i, j).IsAlive

                        If (mUniverse(i, j).IsAlive) Then
                            mAlive += 1
                        Else
                            mAlive -= 1
                        End If
                    End If
                Next
            Next
        End If

        ToolStripStatusLabel3.Text = "Living Cells: " + mAlive.ToString
        GraphicsPanel1.Invalidate()
    End Sub

    Private Sub GraphicsPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GraphicsPanel1.Paint
        mGrid.DrawGrid(GraphicsPanel1, e.Graphics)

        Dim mHeight As Single = Convert.ToSingle(GraphicsPanel1.ClientSize.Width) / mL
        Dim mWidth As Single = Convert.ToSingle(GraphicsPanel1.ClientSize.Height) / mH

        For i As Integer = 0 To mUniverse.GetLength(0) - 1
            For j As Integer = 0 To mUniverse.GetLength(1) - 1
                Dim iOff As Single = i * mHeight
                Dim jOff As Single = j * mWidth

                Dim b As Brush = New SolidBrush(mUniverse(i, j).Color)

                If (mUniverse(i, j).IsAlive) Then
                    e.Graphics.FillRectangle(b, iOff - mGrid.RectWidth, jOff - mGrid.RectHeight, mGrid.RectWidth, mGrid.RectHeight)
                End If
            Next
        Next

    End Sub

    Private Sub PlayToolStripButton_Click(sender As Object, e As EventArgs) Handles PlayToolStripButton.Click
        time.Enabled = True
        PlayToolStripButton.Enabled = False
        PauseToolStripButton.Enabled = True
        StepToolStripButton.Enabled = False
    End Sub

    Private Sub PauseToolStripButton_Click(sender As Object, e As EventArgs) Handles PauseToolStripButton.Click
        time.Enabled = False
        PlayToolStripButton.Enabled = True
        PauseToolStripButton.Enabled = False
        StepToolStripButton.Enabled = True
    End Sub

    Private Sub RandToolStripButton_Click(sender As Object, e As EventArgs) Handles RandToolStripButton.Click
        Dim filePath As String = Application.StartupPath
        filePath += "\Cells\"

        Dim files = Directory.GetFiles(filePath, "*.cells")
        Dim fRand As New Random

        mStream = New FileStream(files(fRand.Next(files.Length)), FileMode.Open)

        NewToolStripButton_Click(sender, e)

        ReadFile(mStream)

        mUniverse = mScratchpad
        ToolStripStatusLabel3.Text = "Living Cells: " + mAlive.ToString

        GraphicsPanel1.Invalidate()
    End Sub

    Private Sub ReadFile(stream As FileStream)
        Dim fReader As New StreamReader(mStream)
        Dim nLine = 0, nRow = 0, hRowOffset = 0, hStartOffset = 0

        While Not fReader.EndOfStream
            hRowOffset = 0
            Dim line As String = fReader.ReadLine()

            If Not line.Contains("!") Then
                hStartOffset += 1
                hRowOffset += line.Length
            End If
        End While

        mAlive = 0
        fReader.DiscardBufferedData()
        fReader.BaseStream.Seek(0, SeekOrigin.Begin)

        While Not fReader.EndOfStream
            Dim line As String = fReader.ReadLine()

            Dim lStart As Integer = (mL / 2) - (line.Length / 2)
            Dim hStart As Integer = (mH / 2) - (hStartOffset / 2)

            nRow = 0

            For Each c As Char In line
                If line.Contains("!") Then
                    Exit For
                End If

                Try
                    Select Case c
                        Case "."
                            mScratchpad(lStart + nRow, hStart + nLine).IsAlive = False
                            nRow += 1
                        Case "O"
                            mScratchpad(lStart + nRow, hStart + nLine).IsAlive = True
                            nRow += 1
                            mAlive += 1
                    End Select
                Catch ex As IndexOutOfRangeException
                    MessageBox.Show(("IndexOutOfRangeException: Grid is too small!\n" + "Your grid size is: " + mL.ToString + ", " + mH.ToString + "\nIt should be larger than " + hRowOffset.ToString + ", " + hStartOffset.ToString), "Error: IndexOutOfRange", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit While
                End Try
            Next
            nLine += 1
        End While

        fReader.Close()
        stream.Close()
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        mGenerations = 0
        ReDim mUniverse(mL + 1, mH + 1)
        ReDim mScratchpad(mL + 1, mH + 1)

        For i As Integer = 0 To mUniverse.GetLength(0) - 1
            For j As Integer = 0 To mUniverse.GetLength(1) - 1
                mUniverse(i, j) = New Cells
                mUniverse(i, j).GridLimit(mL, mH)
                mUniverse(i, j).CellPoint = New Point(i, j)
                mUniverse(i, j).IsAlive = False
                mScratchpad(i, j) = New Cells
                mScratchpad(i, j).GridLimit(mL, mH)
                mScratchpad(i, j).CellPoint = New Point(i, j)
                mScratchpad(i, j).IsAlive = False
            Next
        Next

        mGrid = New Grid(mL, mH)
        ToolStripStatusLabel1.Text = "Generations: " + mGenerations.ToString
        ToolStripStatusLabel2.Text = "Interval: " + mTime.ToString
        ToolStripStatusLabel3.Text = "Living Cells: " + mAlive.ToString
        time.Enabled = False
        PauseToolStripButton.Enabled = False
        PlayToolStripButton.Enabled = True
        StepToolStripButton.Enabled = True

        GraphicsPanel1.Invalidate()
    End Sub

End Class
