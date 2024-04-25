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
        SplitContainer1 = New SplitContainer()
        deleteCarBtn = New Button()
        updateCarBtn = New Button()
        addCarBtn = New Button()
        colorFd = New TextBox()
        modelFd = New TextBox()
        brandFd = New TextBox()
        plateNumberFd = New TextBox()
        DataGridView2 = New DataGridView()
        CustomerPage = New TabPage()
        DataGridView1 = New DataGridView()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        customerName = New TextBox()
        contact = New TextBox()
        searchNameFd = New TextBox()
        address = New TextBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        addCustomerBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        TabPage3 = New TabPage()
        TabPage4 = New TabPage()
        TabPage5 = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Button1 = New Button()
        searchBrandFd = New TextBox()
        CustomerControl.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
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
        TabPage1.Controls.Add(SplitContainer1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(792, 393)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Car Registration"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(3, 3)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.Controls.Add(searchBrandFd)
        SplitContainer1.Panel1.Controls.Add(deleteCarBtn)
        SplitContainer1.Panel1.Controls.Add(updateCarBtn)
        SplitContainer1.Panel1.Controls.Add(addCarBtn)
        SplitContainer1.Panel1.Controls.Add(colorFd)
        SplitContainer1.Panel1.Controls.Add(modelFd)
        SplitContainer1.Panel1.Controls.Add(brandFd)
        SplitContainer1.Panel1.Controls.Add(plateNumberFd)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(DataGridView2)
        SplitContainer1.Size = New Size(786, 387)
        SplitContainer1.SplitterDistance = 296
        SplitContainer1.TabIndex = 2
        ' 
        ' deleteCarBtn
        ' 
        deleteCarBtn.Location = New Point(203, 147)
        deleteCarBtn.Name = "deleteCarBtn"
        deleteCarBtn.Size = New Size(75, 23)
        deleteCarBtn.TabIndex = 6
        deleteCarBtn.Text = "Delete"
        deleteCarBtn.UseVisualStyleBackColor = True
        ' 
        ' updateCarBtn
        ' 
        updateCarBtn.Location = New Point(99, 147)
        updateCarBtn.Name = "updateCarBtn"
        updateCarBtn.Size = New Size(75, 23)
        updateCarBtn.TabIndex = 5
        updateCarBtn.Text = "Update"
        updateCarBtn.UseVisualStyleBackColor = True
        ' 
        ' addCarBtn
        ' 
        addCarBtn.Location = New Point(5, 147)
        addCarBtn.Name = "addCarBtn"
        addCarBtn.Size = New Size(75, 23)
        addCarBtn.TabIndex = 4
        addCarBtn.Text = "Add"
        addCarBtn.UseVisualStyleBackColor = True
        ' 
        ' colorFd
        ' 
        colorFd.CharacterCasing = CharacterCasing.Lower
        colorFd.Location = New Point(5, 108)
        colorFd.Name = "colorFd"
        colorFd.PlaceholderText = "Color"
        colorFd.Size = New Size(231, 23)
        colorFd.TabIndex = 3
        ' 
        ' modelFd
        ' 
        modelFd.CharacterCasing = CharacterCasing.Upper
        modelFd.Location = New Point(5, 79)
        modelFd.Name = "modelFd"
        modelFd.PlaceholderText = "Model"
        modelFd.Size = New Size(231, 23)
        modelFd.TabIndex = 2
        ' 
        ' brandFd
        ' 
        brandFd.CharacterCasing = CharacterCasing.Upper
        brandFd.Location = New Point(5, 50)
        brandFd.Name = "brandFd"
        brandFd.PlaceholderText = "Brand"
        brandFd.Size = New Size(231, 23)
        brandFd.TabIndex = 1
        ' 
        ' plateNumberFd
        ' 
        plateNumberFd.CharacterCasing = CharacterCasing.Upper
        plateNumberFd.Location = New Point(5, 21)
        plateNumberFd.Name = "plateNumberFd"
        plateNumberFd.PlaceholderText = "Plate number"
        plateNumberFd.Size = New Size(231, 23)
        plateNumberFd.TabIndex = 0
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.Location = New Point(0, 0)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(486, 387)
        DataGridView2.TabIndex = 0
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
        FlowLayoutPanel4.Controls.Add(searchNameFd)
        FlowLayoutPanel4.Controls.Add(address)
        FlowLayoutPanel4.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel4.Dock = DockStyle.Bottom
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
        contact.Location = New Point(290, 10)
        contact.Margin = New Padding(3, 10, 3, 3)
        contact.Name = "contact"
        contact.PlaceholderText = "Contact"
        contact.Size = New Size(281, 23)
        contact.TabIndex = 1
        ' 
        ' searchNameFd
        ' 
        searchNameFd.Location = New Point(577, 10)
        searchNameFd.Margin = New Padding(3, 10, 3, 3)
        searchNameFd.Name = "searchNameFd"
        searchNameFd.PlaceholderText = "Search name"
        searchNameFd.Size = New Size(188, 23)
        searchNameFd.TabIndex = 8
        ' 
        ' address
        ' 
        address.Location = New Point(3, 46)
        address.Margin = New Padding(3, 10, 3, 3)
        address.Multiline = True
        address.Name = "address"
        address.PlaceholderText = "Address"
        address.Size = New Size(281, 59)
        address.TabIndex = 1
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(addCustomerBtn)
        FlowLayoutPanel2.Controls.Add(updateBtn)
        FlowLayoutPanel2.Controls.Add(deleteBtn)
        FlowLayoutPanel2.Location = New Point(290, 39)
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
        ' searchBrandFd
        ' 
        searchBrandFd.Location = New Point(5, 193)
        searchBrandFd.Name = "searchBrandFd"
        searchBrandFd.PlaceholderText = "Search Brand"
        searchBrandFd.Size = New Size(169, 23)
        searchBrandFd.TabIndex = 7
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
        TabPage1.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel1.PerformLayout()
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents searchNameFd As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents colorFd As TextBox
    Friend WithEvents modelFd As TextBox
    Friend WithEvents brandFd As TextBox
    Friend WithEvents plateNumberFd As TextBox
    Friend WithEvents deleteCarBtn As Button
    Friend WithEvents updateCarBtn As Button
    Friend WithEvents addCarBtn As Button
    Friend WithEvents searchBrandFd As TextBox

End Class
