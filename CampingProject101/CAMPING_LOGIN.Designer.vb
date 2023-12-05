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
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        btnRegisterScreen = New Button()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(121, 293)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(176, 37)
        btnLogin.TabIndex = 0
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(168, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 32)
        Label1.TabIndex = 2
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(25, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 32)
        Label2.TabIndex = 4
        Label2.Text = "PASSWORD"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(168, 147)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 27)
        TextBox2.TabIndex = 3
        ' 
        ' btnRegisterScreen
        ' 
        btnRegisterScreen.Location = New Point(121, 345)
        btnRegisterScreen.Name = "btnRegisterScreen"
        btnRegisterScreen.Size = New Size(176, 37)
        btnRegisterScreen.TabIndex = 5
        btnRegisterScreen.Text = "Register"
        btnRegisterScreen.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(237, 409)
        Label3.Name = "Label3"
        Label3.Size = New Size(199, 32)
        Label3.TabIndex = 6
        Label3.Text = "PLACEHOLDER UI"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(181, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(194, 32)
        Label4.TabIndex = 7
        Label4.Text = "CAMPING LOGIN"
        ' 
        ' Camping_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(470, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btnRegisterScreen)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(btnLogin)
        Name = "Camping_Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CAMPING LOGIN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnRegisterScreen As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
