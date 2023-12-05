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
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 32)
        Label4.TabIndex = 8
        Label4.Text = "REGISTER OPTION"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 64)
        Label1.TabIndex = 9
        Label1.Text = "PLEASE SELECT " & vbCrLf & "REGISTRY TYPE"
        ' 
        ' btnCamper
        ' 
        btnCamper.Location = New Point(16, 207)
        btnCamper.Name = "btnCamper"
        btnCamper.Size = New Size(176, 37)
        btnCamper.TabIndex = 10
        btnCamper.Text = "New Camper"
        btnCamper.UseVisualStyleBackColor = True
        ' 
        ' btnAdmin
        ' 
        btnAdmin.Location = New Point(16, 293)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(176, 37)
        btnAdmin.TabIndex = 11
        btnAdmin.Text = "New Admin"
        btnAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnStaff
        ' 
        btnStaff.Location = New Point(16, 250)
        btnStaff.Name = "btnStaff"
        btnStaff.Size = New Size(176, 37)
        btnStaff.TabIndex = 12
        btnStaff.Text = "New Staff"
        btnStaff.UseVisualStyleBackColor = True
        ' 
        ' ReturnToLogin
        ' 
        ReturnToLogin.Location = New Point(12, 385)
        ReturnToLogin.Name = "ReturnToLogin"
        ReturnToLogin.Size = New Size(108, 37)
        ReturnToLogin.TabIndex = 13
        ReturnToLogin.Text = "Back"
        ReturnToLogin.UseVisualStyleBackColor = True
        ' 
        ' REGISTERSELECTION
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(378, 450)
        Controls.Add(ReturnToLogin)
        Controls.Add(btnStaff)
        Controls.Add(btnAdmin)
        Controls.Add(btnCamper)
        Controls.Add(Label1)
        Controls.Add(Label4)
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
