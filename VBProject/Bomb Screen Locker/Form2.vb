Public Class Form2



    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_NOCLOSE As Integer = &H200
            cp.ClassStyle = cp.ClassStyle Or CS_NOCLOSE
            Return cp
        End Get
    End Property
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Form1.TextBox1.Text Then
            MsgBox("True Password,Unlocked!")
            Me.Close()
            Form1.Show()
        Else
            MsgBox("Wrong Password!")
            TextBox1.Clear()
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.TopMost = True
        Me.BringToFront()
        Me.Focus()

        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
        Me.Enabled = True
    End Sub
End Class