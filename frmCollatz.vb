Public Class frmCollatz
    ' Completed Collatz Conjecture Project for CSC300

    Const intLoopLimit As Integer = 10000

    Private Function iterateCollatz(ByVal intN As Integer) As Integer
        If intN = 0 Then Return 0

        If intN Mod 2 = 0 Then
            Return intN / 2
        Else
            Return 3 * intN + 1
        End If
    End Function

    Private Function loopCollatz(ByVal intN As Integer, ByRef lbxOutput As ListBox) As Integer
        Dim intLoopCount As Integer = 0
        Dim intCurrentCollatz As Integer = intN

        lbxOutput.Items.Clear()
        lbxOutput.Items.Add("Iteration" & vbTab & "N")
        lbxOutput.Items.Add(intLoopCount & vbTab & intCurrentCollatz)

        While intCurrentCollatz <> 1 And intLoopCount <= intLoopLimit
            intCurrentCollatz = iterateCollatz(intCurrentCollatz)
            intLoopCount = intLoopCount + 1
            lbxOutput.Items.Add(intLoopCount & vbTab & intCurrentCollatz)
        End While

        If intLoopCount > intLoopLimit Then Return -1

        MsgBox(intN & " Reaches 1 By the Collatz Conjecture After " & intLoopCount & " Iterations")

        Return intLoopCount
    End Function

    Private Sub btnLoopCollatz_Click(sender As Object, e As EventArgs) Handles btnLoopCollatz.Click
        Dim intInput As Integer
        Try
            intInput = CInt(txtInput.Text)
        Catch ex As Exception
            MsgBox("Your input to the Collatz Conjecture must be an Integer")
            Return
        End Try

        loopCollatz(intInput, lbxSingleCollatz)

    End Sub
End Class
