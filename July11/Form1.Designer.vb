<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstbxFirstHalf = New System.Windows.Forms.ListBox()
        Me.lstbxSecondHalf = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lstbxMultiplied = New System.Windows.Forms.ListBox()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.lstbxAdded = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstbxFirstHalf
        '
        Me.lstbxFirstHalf.FormattingEnabled = True
        Me.lstbxFirstHalf.Location = New System.Drawing.Point(91, 44)
        Me.lstbxFirstHalf.Name = "lstbxFirstHalf"
        Me.lstbxFirstHalf.Size = New System.Drawing.Size(120, 264)
        Me.lstbxFirstHalf.TabIndex = 0
        '
        'lstbxSecondHalf
        '
        Me.lstbxSecondHalf.FormattingEnabled = True
        Me.lstbxSecondHalf.Location = New System.Drawing.Point(288, 44)
        Me.lstbxSecondHalf.Name = "lstbxSecondHalf"
        Me.lstbxSecondHalf.Size = New System.Drawing.Size(120, 264)
        Me.lstbxSecondHalf.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(446, 44)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Click"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstbxMultiplied
        '
        Me.lstbxMultiplied.FormattingEnabled = True
        Me.lstbxMultiplied.Location = New System.Drawing.Point(91, 328)
        Me.lstbxMultiplied.Name = "lstbxMultiplied"
        Me.lstbxMultiplied.Size = New System.Drawing.Size(120, 264)
        Me.lstbxMultiplied.TabIndex = 3
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(446, 82)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(135, 23)
        Me.btnMultiply.TabIndex = 4
        Me.btnMultiply.Text = "Multiply and Add"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'lstbxAdded
        '
        Me.lstbxAdded.FormattingEnabled = True
        Me.lstbxAdded.Location = New System.Drawing.Point(288, 328)
        Me.lstbxAdded.Name = "lstbxAdded"
        Me.lstbxAdded.Size = New System.Drawing.Size(120, 264)
        Me.lstbxAdded.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 604)
        Me.Controls.Add(Me.lstbxAdded)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.lstbxMultiplied)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstbxSecondHalf)
        Me.Controls.Add(Me.lstbxFirstHalf)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstbxFirstHalf As System.Windows.Forms.ListBox
    Friend WithEvents lstbxSecondHalf As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lstbxMultiplied As System.Windows.Forms.ListBox
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents lstbxAdded As System.Windows.Forms.ListBox

End Class
