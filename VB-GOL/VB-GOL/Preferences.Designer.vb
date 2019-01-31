<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Preferences
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Cell_Button = New System.Windows.Forms.Button()
        Me.Grid_Button = New System.Windows.Forms.Button()
        Me.BG_Button = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.toroidRB = New System.Windows.Forms.RadioButton()
        Me.finiteRB = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.MSUD = New System.Windows.Forms.NumericUpDown()
        Me.UWUD = New System.Windows.Forms.NumericUpDown()
        Me.UHUD = New System.Windows.Forms.NumericUpDown()
        Me.label10 = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MSUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UWUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UHUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(291, 156)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.label12)
        Me.TabPage1.Controls.Add(Me.label11)
        Me.TabPage1.Controls.Add(Me.label10)
        Me.TabPage1.Controls.Add(Me.UHUD)
        Me.TabPage1.Controls.Add(Me.UWUD)
        Me.TabPage1.Controls.Add(Me.MSUD)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(283, 130)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "General"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Cell_Button)
        Me.TabPage2.Controls.Add(Me.Grid_Button)
        Me.TabPage2.Controls.Add(Me.BG_Button)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(283, 130)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Cell_Button
        '
        Me.Cell_Button.Location = New System.Drawing.Point(107, 82)
        Me.Cell_Button.Name = "Cell_Button"
        Me.Cell_Button.Size = New System.Drawing.Size(38, 32)
        Me.Cell_Button.TabIndex = 5
        Me.Cell_Button.UseVisualStyleBackColor = True
        '
        'Grid_Button
        '
        Me.Grid_Button.Location = New System.Drawing.Point(107, 44)
        Me.Grid_Button.Name = "Grid_Button"
        Me.Grid_Button.Size = New System.Drawing.Size(38, 32)
        Me.Grid_Button.TabIndex = 4
        Me.Grid_Button.UseVisualStyleBackColor = True
        '
        'BG_Button
        '
        Me.BG_Button.Location = New System.Drawing.Point(107, 6)
        Me.BG_Button.Name = "BG_Button"
        Me.BG_Button.Size = New System.Drawing.Size(38, 32)
        Me.BG_Button.TabIndex = 3
        Me.BG_Button.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Living Cell Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grid Color"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Background Color"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(283, 130)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Universe"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.toroidRB)
        Me.GroupBox1.Controls.Add(Me.finiteRB)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 65)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Universe Type"
        '
        'toroidRB
        '
        Me.toroidRB.AutoSize = True
        Me.toroidRB.Location = New System.Drawing.Point(6, 38)
        Me.toroidRB.Name = "toroidRB"
        Me.toroidRB.Size = New System.Drawing.Size(108, 17)
        Me.toroidRB.TabIndex = 1
        Me.toroidRB.TabStop = True
        Me.toroidRB.Text = "Toroidal Universe"
        Me.toroidRB.UseVisualStyleBackColor = True
        '
        'finiteRB
        '
        Me.finiteRB.AutoSize = True
        Me.finiteRB.Location = New System.Drawing.Point(6, 15)
        Me.finiteRB.Name = "finiteRB"
        Me.finiteRB.Size = New System.Drawing.Size(95, 17)
        Me.finiteRB.TabIndex = 0
        Me.finiteRB.TabStop = True
        Me.finiteRB.Text = "Finite Universe"
        Me.finiteRB.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(13, 162)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(204, 162)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'MSUD
        '
        Me.MSUD.Location = New System.Drawing.Point(113, 6)
        Me.MSUD.Name = "MSUD"
        Me.MSUD.Size = New System.Drawing.Size(80, 20)
        Me.MSUD.TabIndex = 0
        '
        'UWUD
        '
        Me.UWUD.Location = New System.Drawing.Point(113, 32)
        Me.UWUD.Name = "UWUD"
        Me.UWUD.Size = New System.Drawing.Size(80, 20)
        Me.UWUD.TabIndex = 1
        '
        'UHUD
        '
        Me.UHUD.Location = New System.Drawing.Point(113, 58)
        Me.UHUD.Name = "UHUD"
        Me.UHUD.Size = New System.Drawing.Size(80, 20)
        Me.UHUD.TabIndex = 2
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(8, 8)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(90, 13)
        Me.label10.TabIndex = 3
        Me.label10.Text = "Time Interval (ms)"
        '
        'label11
        '
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(8, 34)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(80, 13)
        Me.label11.TabIndex = 4
        Me.label11.Text = "Universe Width"
        '
        'label12
        '
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(8, 60)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(83, 13)
        Me.label12.TabIndex = 5
        Me.label12.Text = "Universe Height"
        '
        'Preferences
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 197)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preferences"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MSUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UWUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UHUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Cell_Button As Button
    Friend WithEvents Grid_Button As Button
    Friend WithEvents BG_Button As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents toroidRB As RadioButton
    Friend WithEvents finiteRB As RadioButton
    Friend WithEvents label12 As Label
    Friend WithEvents label11 As Label
    Friend WithEvents label10 As Label
    Friend WithEvents UHUD As NumericUpDown
    Friend WithEvents UWUD As NumericUpDown
    Friend WithEvents MSUD As NumericUpDown
End Class
