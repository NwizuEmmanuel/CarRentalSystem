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
        SplitContainer1 = New SplitContainer()
        PictureBox1 = New PictureBox()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PasswordFd
        ' 
        PasswordFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PasswordFd.Location = New Point(17, 85)
        PasswordFd.Name = "PasswordFd"
        PasswordFd.PasswordChar = "$"c
        PasswordFd.PlaceholderText = "password"
        PasswordFd.Size = New Size(318, 29)
        PasswordFd.TabIndex = 1
        ' 
        ' UsernameFd
        ' 
        UsernameFd.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        UsernameFd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UsernameFd.Location = New Point(17, 27)
        UsernameFd.Name = "UsernameFd"
        UsernameFd.PlaceholderText = "username"
        UsernameFd.Size = New Size(318, 29)
        UsernameFd.TabIndex = 2
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = SystemColors.Control
        LoginBtn.Cursor = Cursors.Hand
        LoginBtn.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LoginBtn.Location = New Point(17, 132)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(113, 32)
        LoginBtn.TabIndex = 3
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' SignUpLink
        ' 
        SignUpLink.AutoSize = True
        SignUpLink.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SignUpLink.Location = New Point(17, 181)
        SignUpLink.Name = "SignUpLink"
        SignUpLink.Size = New Size(64, 21)
        SignUpLink.TabIndex = 4
        SignUpLink.TabStop = True
        SignUpLink.Text = "Signup"
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(PictureBox1)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(SignUpLink)
        SplitContainer1.Panel2.Controls.Add(PasswordFd)
        SplitContainer1.Panel2.Controls.Add(LoginBtn)
        SplitContainer1.Panel2.Controls.Add(UsernameFd)
        SplitContainer1.Size = New Size(578, 307)
        SplitContainer1.SplitterDistance = 192
        SplitContainer1.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(192, 307)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(578, 307)
        Controls.Add(SplitContainer1)
        MaximizeBox = False
        Name = "Login"
        Text = "Login"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PasswordFd As TextBox
    Friend WithEvents UsernameFd As TextBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents SignUpLink As LinkLabel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents PictureBox1 As PictureBox
End Class
