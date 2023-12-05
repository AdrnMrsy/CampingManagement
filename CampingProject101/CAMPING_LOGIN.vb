Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Camping_Login
    Private Sub Camping_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectDbase()

    End Sub

    Private Sub btnRegisterScreen_Click(sender As Object, e As EventArgs) Handles btnRegisterScreen.Click
        REGISTERSELECTION.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If checkhide.Checked Then
            txtpass.UseSystemPasswordChar = False
        Else
            txtpass.UseSystemPasswordChar = True
        End If
        login()
    End Sub
End Class
