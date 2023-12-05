Public Class Staff_Registration
    Private Sub StaffRegister_Click(sender As Object, e As EventArgs) Handles StaffRegister.Click
        For Each Item As Control In Me.Controls
            If (TypeOf Item Is TextBox) Then
                If (Item.Text = "") Then
                    MsgBox("All Fields are required")
                    Return
                End If
            End If
        Next
        Staff_Registry()
    End Sub

    Private Sub SRegisterBack_Click(sender As Object, e As EventArgs) Handles SRegisterBack.Click
        Me.Hide()
        Camping_Login.Show()
    End Sub
End Class