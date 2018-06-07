Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Not Matched Passwords,try again!")
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub
End Class
