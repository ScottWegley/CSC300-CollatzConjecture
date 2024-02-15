Public Class frmCollatz

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

    Private Sub btnNextN_Click(sender As Object, e As EventArgs) Handles btnNextN.Click
        Dim intInput As Integer
        Try
            intInput = CInt(txtInput.Text)
        Catch ex As Exception
            MsgBox("Your input to the Collatz Conjecture must be an Integer")
            Return
        End Try

        txtNextIteration.Text = iterateCollatz(intInput)
    End Sub

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

    Private Sub btnFirst20_Click(sender As Object, e As EventArgs) Handles btnFirst20.Click
        Dim intInput As Integer
        Try
            intInput = CInt(txtInput.Text)
        Catch ex As Exception
            MsgBox("Your input to the Collatz Conjecture must be an Integer")
            Return
        End Try

        lbxSingleCollatz.Items.Clear()

        Dim iterations = 0
        Dim n = intInput
        lbxSingleCollatz.Items.Add("Iteration" & vbTab & "N")
        lbxSingleCollatz.Items.Add(iterations & vbTab & n)

        While iterateCollatz(n) <> 1 And iterations < 19
            iterations = iterations + 1
            n = iterateCollatz(n)
            lbxSingleCollatz.Items.Add(iterations & vbTab & n)
        End While

        lbxSingleCollatz.Items.Add(iterations + 1 & vbTab & iterateCollatz(n))
    End Sub
End Class
