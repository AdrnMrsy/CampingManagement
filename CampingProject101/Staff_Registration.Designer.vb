<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff_Registration
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
        txtusername = New TextBox()
        Label1 = New Label()
        txtpassword = New TextBox()
        txtconfirmpassword = New TextBox()
        txtfullname = New TextBox()
        txtage = New TextBox()
        txtbirthday = New TextBox()
        txtphonenum = New TextBox()
        txtaddress = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SRegisterBack = New Button()
        StaffRegister = New Button()
        SuspendLayout()
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(21, 60)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(250, 27)
        txtusername.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(21, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 28)
        Label1.TabIndex = 1
        Label1.Text = "STAFF REGISTER"
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(21, 105)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(126, 27)
        txtpassword.TabIndex = 2
        ' 
        ' txtconfirmpassword
        ' 
        txtconfirmpassword.Location = New Point(270, 106)
        txtconfirmpassword.Name = "txtconfirmpassword"
        txtconfirmpassword.Size = New Size(126, 27)
        txtconfirmpassword.TabIndex = 3
        ' 
        ' txtfullname
        ' 
        txtfullname.Location = New Point(21, 149)
        txtfullname.Name = "txtfullname"
        txtfullname.Size = New Size(250, 27)
        txtfullname.TabIndex = 4
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(21, 194)
        txtage.Name = "txtage"
        txtage.Size = New Size(250, 27)
        txtage.TabIndex = 5
        ' 
        ' txtbirthday
        ' 
        txtbirthday.Location = New Point(21, 244)
        txtbirthday.Name = "txtbirthday"
        txtbirthday.Size = New Size(250, 27)
        txtbirthday.TabIndex = 6
        ' 
        ' txtphonenum
        ' 
        txtphonenum.Location = New Point(21, 293)
        txtphonenum.Name = "txtphonenum"
        txtphonenum.Size = New Size(250, 27)
        txtphonenum.TabIndex = 7
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(21, 343)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(250, 27)
        txtaddress.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(290, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 28)
        Label2.TabIndex = 9
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(153, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 28)
        Label3.TabIndex = 10
        Label3.Text = "Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(402, 106)
        Label4.Name = "Label4"
        Label4.Size = New Size(183, 28)
        Label4.TabIndex = 11
        Label4.Text = "Confirm Password"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(290, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 28)
        Label5.TabIndex = 12
        Label5.Text = "Full Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(290, 194)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 28)
        Label6.TabIndex = 13
        Label6.Text = "Age"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(290, 244)
        Label7.Name = "Label7"
        Label7.Size = New Size(246, 28)
        Label7.TabIndex = 14
        Label7.Text = "Birthday (YYYY-MM-DD)"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(290, 293)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 28)
        Label8.TabIndex = 15
        Label8.Text = "Phone Number"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(290, 339)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 28)
        Label9.TabIndex = 16
        Label9.Text = "Address"
        ' 
        ' SRegisterBack
        ' 
        SRegisterBack.Location = New Point(21, 400)
        SRegisterBack.Name = "SRegisterBack"
        SRegisterBack.Size = New Size(126, 29)
        SRegisterBack.TabIndex = 17
        SRegisterBack.Text = "Return To Login"
        SRegisterBack.UseVisualStyleBackColor = True
        ' 
        ' StaffRegister
        ' 
        StaffRegister.Location = New Point(270, 388)
        StaffRegister.Name = "StaffRegister"
        StaffRegister.Size = New Size(128, 53)
        StaffRegister.TabIndex = 18
        StaffRegister.Text = "Register"
        StaffRegister.UseVisualStyleBackColor = True
        ' 
        ' Staff_Registration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(StaffRegister)
        Controls.Add(SRegisterBack)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtaddress)
        Controls.Add(txtphonenum)
        Controls.Add(txtbirthday)
        Controls.Add(txtage)
        Controls.Add(txtfullname)
        Controls.Add(txtconfirmpassword)
        Controls.Add(txtpassword)
        Controls.Add(Label1)
        Controls.Add(txtusername)
        Name = "Staff_Registration"
        Text = "Staff_Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtconfirmpassword As TextBox
    Friend WithEvents txtfullname As TextBox
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtbirthday As TextBox
    Friend WithEvents txtphonenum As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents SRegisterBack As Button
    Friend WithEvents StaffRegister As Button
End Class
