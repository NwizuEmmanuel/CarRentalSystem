<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignUp))
        UsernameFd = New TextBox()
        PasswordFd = New TextBox()
        EmailFd = New TextBox()
        SignUpBtn = New Button()
        LoginLink = New LinkLabel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' UsernameFd
        ' 
        UsernameFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameFd.Location = New Point(281, 102)
        UsernameFd.Name = "UsernameFd"
        UsernameFd.PlaceholderText = "username"
        UsernameFd.Size = New Size(235, 29)
        UsernameFd.TabIndex = 0
        ' 
        ' PasswordFd
        ' 
        PasswordFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordFd.Location = New Point(281, 172)
        PasswordFd.Name = "PasswordFd"
        PasswordFd.PasswordChar = "$"c
        PasswordFd.PlaceholderText = "password"
        PasswordFd.Size = New Size(235, 29)
        PasswordFd.TabIndex = 1
        ' 
        ' EmailFd
        ' 
        EmailFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailFd.Location = New Point(281, 137)
        EmailFd.Name = "EmailFd"
        EmailFd.PlaceholderText = "email"
        EmailFd.Size = New Size(235, 29)
        EmailFd.TabIndex = 2
        ' 
        ' SignUpBtn
        ' 
        SignUpBtn.BackColor = SystemColors.HotTrack
        SignUpBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpBtn.Location = New Point(281, 233)
        SignUpBtn.Name = "SignUpBtn"
        SignUpBtn.Size = New Size(235, 36)
        SignUpBtn.TabIndex = 3
        SignUpBtn.Text = "Signup"
        SignUpBtn.UseVisualStyleBackColor = False
        ' 
        ' LoginLink
        ' 
        LoginLink.AutoSize = True
        LoginLink.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginLink.Location = New Point(281, 283)
        LoginLink.Name = "LoginLink"
        LoginLink.Size = New Size(53, 21)
        LoginLink.TabIndex = 4
        LoginLink.TabStop = True
        LoginLink.Text = "Log in"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe Script", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(325, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 40)
        Label1.TabIndex = 5
        Label1.Text = "Super Cars"
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(LoginLink)
        Controls.Add(SignUpBtn)
        Controls.Add(EmailFd)
        Controls.Add(PasswordFd)
        Controls.Add(UsernameFd)
        Name = "SignUp"
        Text = "SignUp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents UsernameFd As TextBox
    Friend WithEvents PasswordFd As TextBox
    Friend WithEvents EmailFd As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents LoginLink As LinkLabel
    Friend WithEvents Label1 As Label
End Class
