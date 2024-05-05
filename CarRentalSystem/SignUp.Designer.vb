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
        Panel1 = New Panel()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameFd
        ' 
        UsernameFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameFd.Location = New Point(15, 20)
        UsernameFd.Name = "UsernameFd"
        UsernameFd.PlaceholderText = "username"
        UsernameFd.Size = New Size(235, 29)
        UsernameFd.TabIndex = 0
        ' 
        ' PasswordFd
        ' 
        PasswordFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordFd.Location = New Point(15, 125)
        PasswordFd.Name = "PasswordFd"
        PasswordFd.PasswordChar = "$"c
        PasswordFd.PlaceholderText = "password"
        PasswordFd.Size = New Size(235, 29)
        PasswordFd.TabIndex = 1
        ' 
        ' EmailFd
        ' 
        EmailFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmailFd.Location = New Point(15, 72)
        EmailFd.Name = "EmailFd"
        EmailFd.PlaceholderText = "email"
        EmailFd.Size = New Size(235, 29)
        EmailFd.TabIndex = 2
        ' 
        ' SignUpBtn
        ' 
        SignUpBtn.BackColor = SystemColors.Control
        SignUpBtn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpBtn.Location = New Point(15, 173)
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
        LoginLink.Location = New Point(15, 223)
        LoginLink.Name = "LoginLink"
        LoginLink.Size = New Size(53, 21)
        LoginLink.TabIndex = 4
        LoginLink.TabStop = True
        LoginLink.Text = "Log in"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(UsernameFd)
        Panel1.Controls.Add(EmailFd)
        Panel1.Controls.Add(LoginLink)
        Panel1.Controls.Add(PasswordFd)
        Panel1.Controls.Add(SignUpBtn)
        Panel1.Location = New Point(218, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(316, 349)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 349)
        Panel2.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(200, 349)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(551, 373)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        Name = "SignUp"
        Text = "SignUp"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents UsernameFd As TextBox
    Friend WithEvents PasswordFd As TextBox
    Friend WithEvents EmailFd As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents LoginLink As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
