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
        customerName = New TextBox()
        contact = New TextBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        addCustomerBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        address = New TextBox()
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
        FlowLayoutPanel4.Controls.Add(customerName)
        FlowLayoutPanel4.Controls.Add(contact)
        FlowLayoutPanel4.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel4.Controls.Add(address)
        FlowLayoutPanel4.Dock = DockStyle.Bottom
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(3, 245)
        FlowLayoutPanel4.Margin = New Padding(3, 10, 3, 3)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(786, 145)
        FlowLayoutPanel4.TabIndex = 3
        ' 
        ' customerName
        ' 
        customerName.Location = New Point(3, 10)
        customerName.Margin = New Padding(3, 10, 3, 3)
        customerName.Name = "customerName"
        customerName.PlaceholderText = "Customer Name"
        customerName.Size = New Size(281, 23)
        customerName.TabIndex = 1
        ' 
        ' contact
        ' 
        contact.Location = New Point(3, 46)
        contact.Margin = New Padding(3, 10, 3, 3)
        contact.Name = "contact"
        contact.PlaceholderText = "Contact"
        contact.Size = New Size(281, 23)
        contact.TabIndex = 1
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(addCustomerBtn)
        FlowLayoutPanel2.Controls.Add(updateBtn)
        FlowLayoutPanel2.Controls.Add(deleteBtn)
        FlowLayoutPanel2.Location = New Point(3, 75)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(281, 45)
        FlowLayoutPanel2.TabIndex = 7
        ' 
        ' addCustomerBtn
        ' 
        addCustomerBtn.Location = New Point(3, 3)
        addCustomerBtn.Name = "addCustomerBtn"
        addCustomerBtn.Size = New Size(102, 23)
        addCustomerBtn.TabIndex = 4
        addCustomerBtn.Text = "Add Customer"
        addCustomerBtn.UseVisualStyleBackColor = True
        ' 
        ' updateBtn
        ' 
        updateBtn.Location = New Point(111, 3)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(75, 23)
        updateBtn.TabIndex = 5
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = True
        ' 
        ' deleteBtn
        ' 
        deleteBtn.Location = New Point(192, 3)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(75, 23)
        deleteBtn.TabIndex = 6
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = True
        ' 
        ' address
        ' 
        address.Location = New Point(290, 10)
        address.Margin = New Padding(3, 10, 3, 3)
        address.Multiline = True
        address.Name = "address"
        address.PlaceholderText = "Address"
        address.Size = New Size(281, 59)
        address.TabIndex = 1
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
    Friend WithEvents address As TextBox
    Friend WithEvents customerName As TextBox
    Friend WithEvents addCustomerBtn As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents contact As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel

End Class
