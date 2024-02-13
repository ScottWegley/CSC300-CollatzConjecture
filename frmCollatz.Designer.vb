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
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(13, 13)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(113, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnLoopCollatz
        '
        Me.btnLoopCollatz.Location = New System.Drawing.Point(13, 40)
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
        Me.lbxSingleCollatz.Location = New System.Drawing.Point(133, 13)
        Me.lbxSingleCollatz.Name = "lbxSingleCollatz"
        Me.lbxSingleCollatz.Size = New System.Drawing.Size(120, 433)
        Me.lbxSingleCollatz.TabIndex = 2
        '
        'frmCollatz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
