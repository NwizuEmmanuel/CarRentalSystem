<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PasswordFd = New TextBox()
        UsernameFd = New TextBox()
        LoginBtn = New Button()
        SignUpLink = New LinkLabel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' PasswordFd
        ' 
        PasswordFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordFd.Location = New Point(272, 155)
        PasswordFd.Name = "PasswordFd"
        PasswordFd.PasswordChar = "$"c
        PasswordFd.PlaceholderText = "password"
        PasswordFd.Size = New Size(264, 29)
        PasswordFd.TabIndex = 1
        ' 
        ' UsernameFd
        ' 
        UsernameFd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        UsernameFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameFd.Location = New Point(272, 108)
        UsernameFd.Name = "UsernameFd"
        UsernameFd.PlaceholderText = "username"
        UsernameFd.Size = New Size(262, 29)
        UsernameFd.TabIndex = 2
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = SystemColors.HotTrack
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(272, 207)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(264, 42)
        LoginBtn.TabIndex = 3
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' SignUpLink
        ' 
        SignUpLink.AutoSize = True
        SignUpLink.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpLink.Location = New Point(272, 269)
        SignUpLink.Name = "SignUpLink"
        SignUpLink.Size = New Size(64, 21)
        SignUpLink.TabIndex = 4
        SignUpLink.TabStop = True
        SignUpLink.Text = "Signup"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaptionText
        Label1.Font = New Font("Segoe Script", 21.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(306, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 48)
        Label1.TabIndex = 5
        Label1.Text = "Super Cars"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(798, 450)
        Controls.Add(Label1)
        Controls.Add(SignUpLink)
        Controls.Add(UsernameFd)
        Controls.Add(PasswordFd)
        Controls.Add(LoginBtn)
        Name = "Login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PasswordFd As TextBox
    Friend WithEvents UsernameFd As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents SignUpLink As LinkLabel
    Friend WithEvents Label1 As Label
End Class
