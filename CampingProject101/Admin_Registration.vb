Public Class Admin_Registration
    Private Sub AdminRegister_Click(sender As Object, e As EventArgs) Handles AdminRegister.Click
        For Each Item As Control In Me.Controls
            If (TypeOf Item Is TextBox) Then
                If (Item.Text = "") Then
                    MsgBox("All Fields are required")
                    Return
                End If
            End If
        Next
        Admin_Registry()
    End Sub

    Private Sub ARegisterBack_Click(sender As Object, e As EventArgs) Handles ARegisterBack.Click
        Me.Hide()
        Camping_Login.Show()
    End Sub
End Class