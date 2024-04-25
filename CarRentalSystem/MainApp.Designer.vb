<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
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
        CustomerControl = New TabControl()
        TabPage1 = New TabPage()
        CustomerPage = New TabPage()
        DataGridView1 = New DataGridView()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Button1 = New Button()
        CustomerControl.SuspendLayout()
        CustomerPage.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        TabPage5.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' CustomerControl
        ' 
        CustomerControl.Controls.Add(TabPage1)
        CustomerControl.Controls.Add(CustomerPage)
        CustomerControl.Controls.Add(TabPage3)
        CustomerControl.Controls.Add(TabPage4)
        CustomerControl.Controls.Add(TabPage5)
        CustomerControl.Dock = DockStyle.Fill
        CustomerControl.Location = New Point(0, 0)
        CustomerControl.Name = "CustomerControl"
        CustomerControl.SelectedIndex = 0
        CustomerControl.Size = New Size(800, 421)
        CustomerControl.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 393)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Car Registration"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' CustomerPage
        ' 
        CustomerPage.AutoScroll = True
        CustomerPage.Controls.Add(DataGridView1)
        CustomerPage.Controls.Add(FlowLayoutPanel4)
        CustomerPage.Location = New Point(4, 24)
        CustomerPage.Name = "CustomerPage"
        CustomerPage.Padding = New Padding(3)
        CustomerPage.Size = New Size(792, 393)
        CustomerPage.TabIndex = 1
        CustomerPage.Text = "Customer"
        CustomerPage.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(786, 242)
        DataGridView1.TabIndex = 7
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(TextBox2)
        FlowLayoutPanel4.Controls.Add(TextBox3)
        FlowLayoutPanel4.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel4.Controls.Add(TextBox1)
        FlowLayoutPanel4.Dock = DockStyle.Bottom
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(3, 245)
        FlowLayoutPanel4.Margin = New Padding(3, 10, 3, 3)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(786, 145)
        FlowLayoutPanel4.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(3, 10)
        TextBox2.Margin = New Padding(3, 10, 3, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Customer Name"
        TextBox2.Size = New Size(281, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(3, 46)
        TextBox3.Margin = New Padding(3, 10, 3, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Contact"
        TextBox3.Size = New Size(281, 23)
        TextBox3.TabIndex = 1
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(Button2)
        FlowLayoutPanel2.Controls.Add(Button3)
        FlowLayoutPanel2.Controls.Add(Button4)
        FlowLayoutPanel2.Location = New Point(3, 75)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(281, 45)
        FlowLayoutPanel2.TabIndex = 7
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(111, 3)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 5
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(192, 3)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 6
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(3, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 23)
        Button2.TabIndex = 4
        Button2.Text = "Add Customer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(290, 10)
        TextBox1.Margin = New Padding(3, 10, 3, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Address"
        TextBox1.Size = New Size(281, 59)
        TextBox1.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(792, 393)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Rental"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' TabPage4
        ' 
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.Size = New Size(792, 393)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Return"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(FlowLayoutPanel1)
        TabPage5.Location = New Point(4, 24)
        TabPage5.Name = "TabPage5"
        TabPage5.Padding = New Padding(3, 10, 3, 3)
        TabPage5.Size = New Size(792, 393)
        TabPage5.TabIndex = 4
        TabPage5.Text = "Log out"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Label1)
        FlowLayoutPanel1.Controls.Add(Button1)
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(8, 13)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(212, 100)
        FlowLayoutPanel1.TabIndex = 2
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 15)
        Label1.TabIndex = 0
        Label1.Text = "Log out from system here."
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 25)
        Button1.Margin = New Padding(3, 10, 3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MainApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 421)
        Controls.Add(CustomerControl)
        Name = "MainApp"
        Text = "Super Cars"
        CustomerControl.ResumeLayout(False)
        CustomerPage.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        TabPage5.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents CustomerControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CustomerPage As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel

End Class
