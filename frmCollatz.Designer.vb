<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollatz
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnLoopCollatz = New System.Windows.Forms.Button()
        Me.lbxSingleCollatz = New System.Windows.Forms.ListBox()
        Me.lblN = New System.Windows.Forms.Label()
        Me.lblIteration = New System.Windows.Forms.Label()
        Me.txtNextIteration = New System.Windows.Forms.TextBox()
        Me.btnNextN = New System.Windows.Forms.Button()
        Me.btnFirst20 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(58, 19)
        Me.txtInput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(184, 26)
        Me.txtInput.TabIndex = 0
        '
        'btnLoopCollatz
        '
        Me.btnLoopCollatz.Location = New System.Drawing.Point(13, 130)
        Me.btnLoopCollatz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoopCollatz.Name = "btnLoopCollatz"
        Me.btnLoopCollatz.Size = New System.Drawing.Size(170, 35)
        Me.btnLoopCollatz.TabIndex = 1
        Me.btnLoopCollatz.Text = "Iterate From Value"
        Me.btnLoopCollatz.UseVisualStyleBackColor = True
        '
        'lbxSingleCollatz
        '
        Me.lbxSingleCollatz.ColumnWidth = 20
        Me.lbxSingleCollatz.FormattingEnabled = True
        Me.lbxSingleCollatz.ItemHeight = 20
        Me.lbxSingleCollatz.Location = New System.Drawing.Point(249, 14)
        Me.lbxSingleCollatz.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lbxSingleCollatz.Name = "lbxSingleCollatz"
        Me.lbxSingleCollatz.Size = New System.Drawing.Size(178, 664)
        Me.lbxSingleCollatz.TabIndex = 2
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(18, 25)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(33, 20)
        Me.lblN.TabIndex = 3
        Me.lblN.Text = "N ="
        '
        'lblIteration
        '
        Me.lblIteration.AutoSize = True
        Me.lblIteration.Location = New System.Drawing.Point(18, 58)
        Me.lblIteration.Name = "lblIteration"
        Me.lblIteration.Size = New System.Drawing.Size(117, 20)
        Me.lblIteration.TabIndex = 4
        Me.lblIteration.Text = "Next Iteration ="
        '
        'txtNextIteration
        '
        Me.txtNextIteration.Location = New System.Drawing.Point(142, 55)
        Me.txtNextIteration.Name = "txtNextIteration"
        Me.txtNextIteration.Size = New System.Drawing.Size(100, 26)
        Me.txtNextIteration.TabIndex = 5
        '
        'btnNextN
        '
        Me.btnNextN.Location = New System.Drawing.Point(13, 87)
        Me.btnNextN.Name = "btnNextN"
        Me.btnNextN.Size = New System.Drawing.Size(170, 35)
        Me.btnNextN.TabIndex = 6
        Me.btnNextN.Text = "Get Next N"
        Me.btnNextN.UseVisualStyleBackColor = True
        '
        'btnFirst20
        '
        Me.btnFirst20.Location = New System.Drawing.Point(13, 173)
        Me.btnFirst20.Name = "btnFirst20"
        Me.btnFirst20.Size = New System.Drawing.Size(170, 70)
        Me.btnFirst20.TabIndex = 7
        Me.btnFirst20.Text = "Get First 20 Iterations"
        Me.btnFirst20.UseVisualStyleBackColor = True
        '
        'frmCollatz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 692)
        Me.Controls.Add(Me.btnFirst20)
        Me.Controls.Add(Me.btnNextN)
        Me.Controls.Add(Me.txtNextIteration)
        Me.Controls.Add(Me.lblIteration)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lbxSingleCollatz)
        Me.Controls.Add(Me.btnLoopCollatz)
        Me.Controls.Add(Me.txtInput)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCollatz"
        Me.Text = "Collatz Conjecture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnLoopCollatz As Button
    Friend WithEvents lbxSingleCollatz As ListBox
    Friend WithEvents lblN As Label
    Friend WithEvents lblIteration As Label
    Friend WithEvents txtNextIteration As TextBox
    Friend WithEvents btnNextN As Button
    Friend WithEvents btnFirst20 As Button
End Class
