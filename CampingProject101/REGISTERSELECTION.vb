Public Class REGISTERSELECTION


    Private Sub ReturnToLogin_Click(sender As Object, e As EventArgs) Handles ReturnToLogin.Click
        Camping_Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnCamper_Click(sender As Object, e As EventArgs) Handles btnCamper.Click
        Camper_Registration.Show()
        Me.Hide()
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim passcode As String
        passcode = InputBox("In order to register as Staff, you must input a code given by an Admin.",
                            "Please Enter Admin Passcode", " ")
        If passcode = "252900" Then
            Staff_Registration.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please Enter Passcode")
        End If
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim passcode As String
        passcode = InputBox("In order to register as Staff, you must input a code given by an Admin.",
                            "Please Enter Admin Passcode", " ")
        If passcode = "252900" Then
            Admin_Registration.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please Enter Passcode")
        End If
    End Sub

    Private Sub REGISTERSELECTION_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class