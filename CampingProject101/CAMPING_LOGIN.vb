Public Class Camping_Login
    Private Sub Camping_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()
    End Sub

    Private Sub btnRegisterScreen_Click(sender As Object, e As EventArgs) Handles btnRegisterScreen.Click
        REGISTERSELECTION.Show()
        Me.Hide()
    End Sub
End Class
