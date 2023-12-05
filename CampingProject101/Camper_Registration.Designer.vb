<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Camper_Registration
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
        txtUsername = New TextBox()
        CamperRegister = New Button()
        txtFullName = New TextBox()
        txtPhoneNum = New TextBox()
        txtBirthday = New TextBox()
        txtAge = New TextBox()
        txtAddress = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtPassword = New TextBox()
        txtconfirmPassword = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        CRegisterBack = New Button()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(36, 49)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(236, 23)
        txtUsername.TabIndex = 0
        ' 
        ' CamperRegister
        ' 
        CamperRegister.Location = New Point(273, 290)
        CamperRegister.Margin = New Padding(3, 2, 3, 2)
        CamperRegister.Name = "CamperRegister"
        CamperRegister.Size = New Size(117, 39)
        CamperRegister.TabIndex = 1
        CamperRegister.Text = "Register"
        CamperRegister.UseVisualStyleBackColor = True
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(36, 112)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(236, 23)
        txtFullName.TabIndex = 2
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(36, 217)
        txtPhoneNum.Margin = New Padding(3, 2, 3, 2)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(236, 23)
        txtPhoneNum.TabIndex = 3
        ' 
        ' txtBirthday
        ' 
        txtBirthday.Location = New Point(36, 182)
        txtBirthday.Margin = New Padding(3, 2, 3, 2)
        txtBirthday.Name = "txtBirthday"
        txtBirthday.Size = New Size(236, 23)
        txtBirthday.TabIndex = 4
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(36, 146)
        txtAge.Margin = New Padding(3, 2, 3, 2)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(236, 23)
        txtAge.TabIndex = 5
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(36, 250)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(236, 23)
        txtAddress.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(276, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 21)
        Label1.TabIndex = 7
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(276, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 21)
        Label2.TabIndex = 8
        Label2.Text = "Full Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(276, 146)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 21)
        Label3.TabIndex = 9
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(276, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 21)
        Label4.TabIndex = 10
        Label4.Text = "Birthday (YYYY-MM-DD)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(276, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 21)
        Label5.TabIndex = 11
        Label5.Text = "Phone Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(276, 250)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 21)
        Label6.TabIndex = 12
        Label6.Text = "Address"
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(36, 80)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(114, 23)
        txtPassword.TabIndex = 13
        ' 
        ' txtconfirmPassword
        ' 
        txtconfirmPassword.Location = New Point(276, 80)
        txtconfirmPassword.Margin = New Padding(3, 2, 3, 2)
        txtconfirmPassword.Name = "txtconfirmPassword"
        txtconfirmPassword.PasswordChar = "*"c
        txtconfirmPassword.Size = New Size(114, 23)
        txtconfirmPassword.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(165, 80)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 21)
        Label7.TabIndex = 15
        Label7.Text = "Password"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(414, 80)
        Label8.Name = "Label8"
        Label8.Size = New Size(137, 21)
        Label8.TabIndex = 16
        Label8.Text = "Confirm Password"
        ' 
        ' CRegisterBack
        ' 
        CRegisterBack.Location = New Point(36, 307)
        CRegisterBack.Margin = New Padding(3, 2, 3, 2)
        CRegisterBack.Name = "CRegisterBack"
        CRegisterBack.Size = New Size(127, 22)
        CRegisterBack.TabIndex = 17
        CRegisterBack.Text = "Return to Login"
        CRegisterBack.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(27, 15)
        Label9.Name = "Label9"
        Label9.Size = New Size(143, 21)
        Label9.TabIndex = 18
        Label9.Text = "CAMPER REGISTER"
        ' 
        ' Camper_Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(700, 338)
        Controls.Add(Label9)
        Controls.Add(CRegisterBack)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(txtconfirmPassword)
        Controls.Add(txtPassword)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtAddress)
        Controls.Add(txtAge)
        Controls.Add(txtBirthday)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtFullName)
        Controls.Add(CamperRegister)
        Controls.Add(txtUsername)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Camper_Registration"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Camper_Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents CamperRegister As Button
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtBirthday As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtconfirmPassword As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CRegisterBack As Button
    Friend WithEvents Label9 As Label
End Class
