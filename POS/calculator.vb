Option Explicit On

Public Class calculator

    Dim Operand1 As Double
    Dim Operand2 As Double
    Dim [Operator] As String

    Dim hasDecimal As Boolean
    Dim tmpValue As Double
    Private Sub cmd1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd0.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmdDecimal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDecimal.Click
        If InStr(txtInput.Text, ".") > 0 Then
            Exit Sub
        Else
            txtInput.Text = txtInput.Text & "."
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "+"
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Dim Result As Double
        Operand2 = Val(txtInput.Text)

        Select Case [Operator]
            Case "+"
                Result = Math.Round((Operand1 + Operand2), 2) * -1
                txtInput.Text = Result.ToString()
            Case "-"
                Result = Math.Round((Operand1 - Operand2), 2) * -1
                txtInput.Text = Result.ToString()
            Case "/"
                Result = Math.Round((Operand1 / Operand2), 2) * -1
                txtInput.Text = Result.ToString()
            Case "*"
                Result = Math.Round((Operand1 * Operand2), 2) * -1
                txtInput.Text = Result.ToString()

        End Select

        txtInput.Text = Result.ToString()

    End Sub

    Private Sub CmdClearAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClearAll.Click
        txtInput.Text = ""

    End Sub


    Private Sub cmd7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd7.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd8.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd9.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd4.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd5.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub

    Private Sub cmd6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd6.Click
        txtInput.Text = txtInput.Text & sender.text

    End Sub

    Private Sub cmd2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2.Click
        txtInput.Text = txtInput.Text & sender.text


    End Sub

    Private Sub cmd3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd3.Click
        txtInput.Text = txtInput.Text & sender.text
    End Sub

    Private Sub cmdDivide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDivide.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "/"

    End Sub

    Private Sub cmdMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMultiply.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "*"
    End Sub

    Private Sub CmdSubstraction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdsubstraction.Click
        Operand1 = Val(txtInput.Text)
        txtInput.Text = ""
        txtInput.Focus()
        [Operator] = "-"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    'Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
    'If e.KeyCode = Keys.Add Then
    '       Operand1 = Val(Microsoft.VisualBasic.Left(txtInput.Text, Len(txtInput.Text) - 1))
    '      txtInput.Text = ""
    '     txtInput.Focus()
    '    [Operator] = "+"
    'ElseIf e.KeyChar = ChrW(Keys.Subtract) Then
    ' Cmdsubstraction.PerformClick()
    'ElseIf e.KeyChar = ChrW(Keys.Divide) Then
    ' cmdDivide.PerformClick()
    'ElseIf e.KeyChar = ChrW(Keys.Multiply) Then
    'cmdMultiply.PerformClick()
    'End If
    'End Sub
End Class