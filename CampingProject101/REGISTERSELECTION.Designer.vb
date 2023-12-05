<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTERSELECTION
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        Label1 = New Label()
        btnCamper = New Button()
        btnAdmin = New Button()
        btnStaff = New Button()
        ReturnToLogin = New Button()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(10, 7)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 25)
        Label4.TabIndex = 8
        Label4.Text = "REGISTER OPTION"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(10, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 50)
        Label1.TabIndex = 9
        Label1.Text = "PLEASE SELECT " & vbCrLf & "REGISTRY TYPE"
        ' 
        ' btnCamper
        ' 
        btnCamper.Location = New Point(14, 155)
        btnCamper.Margin = New Padding(3, 2, 3, 2)
        btnCamper.Name = "btnCamper"
        btnCamper.Size = New Size(154, 28)
        btnCamper.TabIndex = 10
        btnCamper.Text = "New Camper"
        btnCamper.UseVisualStyleBackColor = True
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(14, 220)
        btnAdmin.Margin = New Padding(3, 2, 3, 2)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(154, 28)
        btnAdmin.TabIndex = 11
        btnAdmin.Text = "New Admin"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnStaff
        ' 
        btnStaff.Location = New Point(14, 188)
        btnStaff.Margin = New Padding(3, 2, 3, 2)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(154, 28)
        btnStaff.TabIndex = 12
        btnStaff.Text = "New Staff"
        btnStaff.UseVisualStyleBackColor = True
        ' 
        ' ReturnToLogin
        ' 
        ReturnToLogin.Location = New Point(10, 289)
        ReturnToLogin.Margin = New Padding(3, 2, 3, 2)
        ReturnToLogin.Name = "ReturnToLogin"
        ReturnToLogin.Size = New Size(94, 28)
        ReturnToLogin.TabIndex = 13
        ReturnToLogin.Text = "Back"
        ReturnToLogin.UseVisualStyleBackColor = True
        ' 
        ' REGISTERSELECTION
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(331, 338)
        Controls.Add(ReturnToLogin)
        Controls.Add(btnStaff)
        Controls.Add(btnAdmin)
        Controls.Add(btnCamper)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Margin = New Padding(3, 2, 3, 2)
        Name = "REGISTERSELECTION"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REGISTERSELECTION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCamper As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnStaff As Button
    Friend WithEvents ReturnToLogin As Button
End Class
