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
        Me.txtInput.Location = New System.Drawing.Point(39, 12)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(124, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnLoopCollatz
        '
        Me.btnLoopCollatz.Location = New System.Drawing.Point(9, 84)
        Me.btnLoopCollatz.Name = "btnLoopCollatz"
        Me.btnLoopCollatz.Size = New System.Drawing.Size(113, 23)
        Me.btnLoopCollatz.TabIndex = 1
        Me.btnLoopCollatz.Text = "Iterate From Value"
        Me.btnLoopCollatz.UseVisualStyleBackColor = True
        '
        'lbxSingleCollatz
        '
        Me.lbxSingleCollatz.ColumnWidth = 20
        Me.lbxSingleCollatz.FormattingEnabled = True
        Me.lbxSingleCollatz.Location = New System.Drawing.Point(166, 9)
        Me.lbxSingleCollatz.Name = "lbxSingleCollatz"
        Me.lbxSingleCollatz.Size = New System.Drawing.Size(120, 433)
        Me.lbxSingleCollatz.TabIndex = 2
        '
        'lblN
        '
        Me.lblN.AutoSize = True
        Me.lblN.Location = New System.Drawing.Point(12, 16)
        Me.lblN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblN.Name = "lblN"
        Me.lblN.Size = New System.Drawing.Size(24, 13)
        Me.lblN.TabIndex = 3
        Me.lblN.Text = "N ="
        '
        'lblIteration
        '
        Me.lblIteration.AutoSize = True
        Me.lblIteration.Location = New System.Drawing.Point(12, 38)
        Me.lblIteration.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIteration.Name = "lblIteration"
        Me.lblIteration.Size = New System.Drawing.Size(79, 13)
        Me.lblIteration.TabIndex = 4
        Me.lblIteration.Text = "Next Iteration ="
        '
        'txtNextIteration
        '
        Me.txtNextIteration.Enabled = False
        Me.txtNextIteration.Location = New System.Drawing.Point(95, 36)
        Me.txtNextIteration.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNextIteration.Name = "txtNextIteration"
        Me.txtNextIteration.Size = New System.Drawing.Size(68, 20)
        Me.txtNextIteration.TabIndex = 5
        '
        'btnNextN
        '
        Me.btnNextN.Location = New System.Drawing.Point(9, 57)
        Me.btnNextN.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNextN.Name = "btnNextN"
        Me.btnNextN.Size = New System.Drawing.Size(113, 23)
        Me.btnNextN.TabIndex = 6
        Me.btnNextN.Text = "Get Next N"
        Me.btnNextN.UseVisualStyleBackColor = True
        '
        'btnFirst20
        '
        Me.btnFirst20.Location = New System.Drawing.Point(9, 112)
        Me.btnFirst20.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnFirst20.Name = "btnFirst20"
        Me.btnFirst20.Size = New System.Drawing.Size(113, 46)
        Me.btnFirst20.TabIndex = 7
        Me.btnFirst20.Text = "Get First 20 Iterations"
        Me.btnFirst20.UseVisualStyleBackColor = True
        '
        'frmCollatz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFirst20)
        Me.Controls.Add(Me.btnNextN)
        Me.Controls.Add(Me.txtNextIteration)
        Me.Controls.Add(Me.lblIteration)
        Me.Controls.Add(Me.lblN)
        Me.Controls.Add(Me.lbxSingleCollatz)
        Me.Controls.Add(Me.btnLoopCollatz)
        Me.Controls.Add(Me.txtInput)
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
