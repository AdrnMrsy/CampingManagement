Imports Org.BouncyCastle.Asn1.X509.Qualified

Public Class Camper_Registration


    Private Sub CRegisterBack_Click(sender As Object, e As EventArgs) Handles CRegisterBack.Click
        Me.Hide()
        Camping_Login.Show()
    End Sub

    Private Sub CamperRegister_Click(sender As Object, e As EventArgs) Handles CamperRegister.Click
        For Each Item As Control In Me.Controls
            If (TypeOf Item Is TextBox) Then
                If (Item.Text = "") Then
                    MsgBox("All Fields are required")
                    Return
                End If
                
            End If
        Next
        Camper_Registry()
    End Sub
End Class