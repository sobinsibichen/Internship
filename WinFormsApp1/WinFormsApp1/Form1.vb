Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim password As String
        username = TextBox1.Text
        password = TextBox2.Text
        If (username.Equals("transpace") And password.Equals("isro")) Then
            MessageBox.Show("LOGIN SUCCESSFULL")
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("LOGIN ERROR")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
