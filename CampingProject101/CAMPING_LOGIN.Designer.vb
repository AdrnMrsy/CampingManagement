<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Camping_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnLogin = New Button()
        txtuser = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtpass = New TextBox()
        btnRegisterScreen = New Button()
        Label3 = New Label()
        Label4 = New Label()
        checkhide = New CheckBox()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(106, 220)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(154, 28)
        btnLogin.TabIndex = 0
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' txtuser
        ' 
        txtuser.Location = New Point(147, 68)
        txtuser.Margin = New Padding(3, 2, 3, 2)
        txtuser.Name = "txtuser"
        txtuser.Size = New Size(235, 23)
        txtuser.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(22, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 25)
        Label1.TabIndex = 2
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(22, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 25)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(147, 110)
        txtpass.Margin = New Padding(3, 2, 3, 2)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(235, 23)
        txtpass.TabIndex = 3
        txtpass.UseSystemPasswordChar = True
        ' 
        ' btnRegisterScreen
        ' 
        btnRegisterScreen.Location = New Point(106, 259)
        btnRegisterScreen.Margin = New Padding(3, 2, 3, 2)
        btnRegisterScreen.Name = "btnRegisterScreen"
        btnRegisterScreen.Size = New Size(154, 28)
        btnRegisterScreen.TabIndex = 5
        btnRegisterScreen.Text = "Register"
        btnRegisterScreen.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(207, 307)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 25)
        Label3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(158, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 25)
        Label4.TabIndex = 7
        Label4.Text = "CAMPING LOGIN"
        ' 
        ' checkhide
        ' 
        checkhide.AutoSize = True
        checkhide.Location = New Point(147, 151)
        checkhide.Name = "checkhide"
        checkhide.Size = New Size(84, 19)
        checkhide.TabIndex = 8
        checkhide.Text = " View/Hide"
        checkhide.UseVisualStyleBackColor = True
        ' 
        ' Camping_Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(411, 338)
        Controls.Add(checkhide)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnRegisterScreen)
        Controls.Add(Label2)
        Controls.Add(txtpass)
        Controls.Add(Label1)
        Controls.Add(txtuser)
        Controls.Add(btnLogin)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Camping_Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CAMPING LOGIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnRegisterScreen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents checkhide As CheckBox
End Class
