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
        AppTabControl = New TabControl()
        RegPage = New TabPage()
        SplitContainer1 = New SplitContainer()
        searchBrandFd = New TextBox()
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
        RentalPage = New TabPage()
        SplitContainer2 = New SplitContainer()
        CustomerNameSearch = New TextBox()
        CustomerIdFd = New TextBox()
        Label7 = New Label()
        returnBtn = New Button()
        ReturnDatePicker = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        RentalCarListSearch = New TextBox()
        Label4 = New Label()
        customerNameCombo = New ComboBox()
        rentalSaveBtn = New Button()
        Label3 = New Label()
        RentalDueDate = New DateTimePicker()
        Label2 = New Label()
        rentalDate = New DateTimePicker()
        RentalFeeFd = New TextBox()
        rentalCustomerIdLabel = New Label()
        rentalCarIdLabel = New Label()
        SplitContainer3 = New SplitContainer()
        RentalTable = New DataGridView()
        RentalCarListlTable = New DataGridView()
        ReturnPage = New TabPage()
        LogoutPage = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        Button1 = New Button()
        refreshBtn = New Button()
        AppTabControl.SuspendLayout()
        RegPage.SuspendLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CustomerPage.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel4.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        RentalPage.SuspendLayout()
        CType(SplitContainer2, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(SplitContainer3, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer3.Panel1.SuspendLayout()
        SplitContainer3.Panel2.SuspendLayout()
        SplitContainer3.SuspendLayout()
        CType(RentalTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(RentalCarListlTable, ComponentModel.ISupportInitialize).BeginInit()
        LogoutPage.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' AppTabControl
        ' 
        AppTabControl.Controls.Add(RegPage)
        AppTabControl.Controls.Add(CustomerPage)
        AppTabControl.Controls.Add(RentalPage)
        AppTabControl.Controls.Add(ReturnPage)
        AppTabControl.Controls.Add(LogoutPage)
        AppTabControl.Dock = DockStyle.Fill
        AppTabControl.Location = New Point(0, 0)
        AppTabControl.Name = "AppTabControl"
        AppTabControl.SelectedIndex = 0
        AppTabControl.Size = New Size(841, 529)
        AppTabControl.TabIndex = 0
        ' 
        ' RegPage
        ' 
        RegPage.Controls.Add(SplitContainer1)
        RegPage.Location = New Point(4, 24)
        RegPage.Name = "RegPage"
        RegPage.Padding = New Padding(3)
        RegPage.Size = New Size(833, 501)
        RegPage.TabIndex = 0
        RegPage.Text = "Car Registration"
        RegPage.UseVisualStyleBackColor = True
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
        SplitContainer1.Size = New Size(827, 495)
        SplitContainer1.SplitterDistance = 311
        SplitContainer1.TabIndex = 2
        ' 
        ' searchBrandFd
        ' 
        searchBrandFd.Location = New Point(5, 193)
        searchBrandFd.Name = "searchBrandFd"
        searchBrandFd.PlaceholderText = "Search Brand"
        searchBrandFd.Size = New Size(169, 23)
        searchBrandFd.TabIndex = 7
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
        DataGridView2.Size = New Size(512, 495)
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
        CustomerPage.Size = New Size(833, 501)
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
        DataGridView1.Size = New Size(827, 350)
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
        FlowLayoutPanel4.Location = New Point(3, 353)
        FlowLayoutPanel4.Margin = New Padding(3, 10, 3, 3)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(827, 145)
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
        ' RentalPage
        ' 
        RentalPage.Controls.Add(SplitContainer2)
        RentalPage.Location = New Point(4, 24)
        RentalPage.Name = "RentalPage"
        RentalPage.Padding = New Padding(3)
        RentalPage.Size = New Size(833, 501)
        RentalPage.TabIndex = 2
        RentalPage.Text = "Rental"
        RentalPage.UseVisualStyleBackColor = True
        ' 
        ' SplitContainer2
        ' 
        SplitContainer2.Dock = DockStyle.Fill
        SplitContainer2.Location = New Point(3, 3)
        SplitContainer2.Name = "SplitContainer2"
        ' 
        ' SplitContainer2.Panel1
        ' 
        SplitContainer2.Panel1.Controls.Add(refreshBtn)
        SplitContainer2.Panel1.Controls.Add(CustomerNameSearch)
        SplitContainer2.Panel1.Controls.Add(CustomerIdFd)
        SplitContainer2.Panel1.Controls.Add(Label7)
        SplitContainer2.Panel1.Controls.Add(returnBtn)
        SplitContainer2.Panel1.Controls.Add(ReturnDatePicker)
        SplitContainer2.Panel1.Controls.Add(Label6)
        SplitContainer2.Panel1.Controls.Add(Label5)
        SplitContainer2.Panel1.Controls.Add(RentalCarListSearch)
        SplitContainer2.Panel1.Controls.Add(Label4)
        SplitContainer2.Panel1.Controls.Add(customerNameCombo)
        SplitContainer2.Panel1.Controls.Add(rentalSaveBtn)
        SplitContainer2.Panel1.Controls.Add(Label3)
        SplitContainer2.Panel1.Controls.Add(RentalDueDate)
        SplitContainer2.Panel1.Controls.Add(Label2)
        SplitContainer2.Panel1.Controls.Add(rentalDate)
        SplitContainer2.Panel1.Controls.Add(RentalFeeFd)
        SplitContainer2.Panel1.Controls.Add(rentalCustomerIdLabel)
        SplitContainer2.Panel1.Controls.Add(rentalCarIdLabel)
        ' 
        ' SplitContainer2.Panel2
        ' 
        SplitContainer2.Panel2.Controls.Add(SplitContainer3)
        SplitContainer2.Size = New Size(827, 495)
        SplitContainer2.SplitterDistance = 354
        SplitContainer2.TabIndex = 0
        ' 
        ' CustomerNameSearch
        ' 
        CustomerNameSearch.Location = New Point(5, 263)
        CustomerNameSearch.Name = "CustomerNameSearch"
        CustomerNameSearch.PlaceholderText = "Search Customer name"
        CustomerNameSearch.Size = New Size(183, 23)
        CustomerNameSearch.TabIndex = 18
        ' 
        ' CustomerIdFd
        ' 
        CustomerIdFd.Location = New Point(102, 359)
        CustomerIdFd.Name = "CustomerIdFd"
        CustomerIdFd.Size = New Size(200, 23)
        CustomerIdFd.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(5, 362)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 16
        Label7.Text = "Customer ID"
        ' 
        ' returnBtn
        ' 
        returnBtn.Location = New Point(5, 427)
        returnBtn.Name = "returnBtn"
        returnBtn.Size = New Size(75, 23)
        returnBtn.TabIndex = 15
        returnBtn.Text = "Return"
        returnBtn.UseVisualStyleBackColor = True
        ' 
        ' ReturnDatePicker
        ' 
        ReturnDatePicker.Location = New Point(102, 388)
        ReturnDatePicker.Name = "ReturnDatePicker"
        ReturnDatePicker.Size = New Size(200, 23)
        ReturnDatePicker.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(5, 394)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 15)
        Label6.TabIndex = 13
        Label6.Text = "Returned Date"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(5, 334)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 15)
        Label5.TabIndex = 12
        Label5.Text = "Return Section"
        ' 
        ' RentalCarListSearch
        ' 
        RentalCarListSearch.Location = New Point(5, 292)
        RentalCarListSearch.Name = "RentalCarListSearch"
        RentalCarListSearch.PlaceholderText = "Search Car"
        RentalCarListSearch.Size = New Size(183, 23)
        RentalCarListSearch.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(5, 77)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 15)
        Label4.TabIndex = 10
        Label4.Text = "Customer name"
        ' 
        ' customerNameCombo
        ' 
        customerNameCombo.AutoCompleteMode = AutoCompleteMode.Append
        customerNameCombo.AutoCompleteSource = AutoCompleteSource.ListItems
        customerNameCombo.FormattingEnabled = True
        customerNameCombo.Location = New Point(103, 74)
        customerNameCombo.Name = "customerNameCombo"
        customerNameCombo.Size = New Size(199, 23)
        customerNameCombo.TabIndex = 9
        ' 
        ' rentalSaveBtn
        ' 
        rentalSaveBtn.Location = New Point(5, 231)
        rentalSaveBtn.Name = "rentalSaveBtn"
        rentalSaveBtn.Size = New Size(75, 23)
        rentalSaveBtn.TabIndex = 8
        rentalSaveBtn.Text = "Save"
        rentalSaveBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 189)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 7
        Label3.Text = "Due Date"
        ' 
        ' RentalDueDate
        ' 
        RentalDueDate.Location = New Point(66, 183)
        RentalDueDate.Name = "RentalDueDate"
        RentalDueDate.Size = New Size(200, 23)
        RentalDueDate.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 5
        Label2.Text = "Date"
        ' 
        ' rentalDate
        ' 
        rentalDate.Location = New Point(59, 145)
        rentalDate.Name = "rentalDate"
        rentalDate.Size = New Size(200, 23)
        rentalDate.TabIndex = 4
        ' 
        ' RentalFeeFd
        ' 
        RentalFeeFd.Location = New Point(5, 106)
        RentalFeeFd.Name = "RentalFeeFd"
        RentalFeeFd.PlaceholderText = "Rental Fee"
        RentalFeeFd.Size = New Size(183, 23)
        RentalFeeFd.TabIndex = 3
        ' 
        ' rentalCustomerIdLabel
        ' 
        rentalCustomerIdLabel.AutoSize = True
        rentalCustomerIdLabel.Location = New Point(5, 48)
        rentalCustomerIdLabel.Name = "rentalCustomerIdLabel"
        rentalCustomerIdLabel.Size = New Size(73, 15)
        rentalCustomerIdLabel.TabIndex = 1
        rentalCustomerIdLabel.Text = "Customer ID"
        ' 
        ' rentalCarIdLabel
        ' 
        rentalCarIdLabel.AutoSize = True
        rentalCarIdLabel.Location = New Point(5, 17)
        rentalCarIdLabel.Name = "rentalCarIdLabel"
        rentalCarIdLabel.Size = New Size(39, 15)
        rentalCarIdLabel.TabIndex = 0
        rentalCarIdLabel.Text = "Car ID"
        ' 
        ' SplitContainer3
        ' 
        SplitContainer3.Dock = DockStyle.Fill
        SplitContainer3.Location = New Point(0, 0)
        SplitContainer3.Name = "SplitContainer3"
        SplitContainer3.Orientation = Orientation.Horizontal
        ' 
        ' SplitContainer3.Panel1
        ' 
        SplitContainer3.Panel1.Controls.Add(RentalTable)
        ' 
        ' SplitContainer3.Panel2
        ' 
        SplitContainer3.Panel2.Controls.Add(RentalCarListlTable)
        SplitContainer3.Size = New Size(469, 495)
        SplitContainer3.SplitterDistance = 245
        SplitContainer3.TabIndex = 2
        ' 
        ' RentalTable
        ' 
        RentalTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RentalTable.Dock = DockStyle.Fill
        RentalTable.Location = New Point(0, 0)
        RentalTable.Name = "RentalTable"
        RentalTable.Size = New Size(469, 245)
        RentalTable.TabIndex = 1
        ' 
        ' RentalCarListlTable
        ' 
        RentalCarListlTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        RentalCarListlTable.Dock = DockStyle.Fill
        RentalCarListlTable.Location = New Point(0, 0)
        RentalCarListlTable.Name = "RentalCarListlTable"
        RentalCarListlTable.Size = New Size(469, 246)
        RentalCarListlTable.TabIndex = 0
        ' 
        ' ReturnPage
        ' 
        ReturnPage.Location = New Point(4, 24)
        ReturnPage.Name = "ReturnPage"
        ReturnPage.Padding = New Padding(3)
        ReturnPage.Size = New Size(833, 501)
        ReturnPage.TabIndex = 3
        ReturnPage.Text = "Return"
        ReturnPage.UseVisualStyleBackColor = True
        ' 
        ' LogoutPage
        ' 
        LogoutPage.Controls.Add(FlowLayoutPanel1)
        LogoutPage.Location = New Point(4, 24)
        LogoutPage.Name = "LogoutPage"
        LogoutPage.Padding = New Padding(3, 10, 3, 3)
        LogoutPage.Size = New Size(833, 501)
        LogoutPage.TabIndex = 4
        LogoutPage.Text = "Log out"
        LogoutPage.UseVisualStyleBackColor = True
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
        ' refreshBtn
        ' 
        refreshBtn.Location = New Point(238, 17)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(75, 23)
        refreshBtn.TabIndex = 19
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = True
        ' 
        ' MainApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(841, 529)
        Controls.Add(AppTabControl)
        Name = "MainApp"
        Text = "Super Cars"
        AppTabControl.ResumeLayout(False)
        RegPage.ResumeLayout(False)
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
        RentalPage.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel1.PerformLayout()
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        SplitContainer3.Panel1.ResumeLayout(False)
        SplitContainer3.Panel2.ResumeLayout(False)
        CType(SplitContainer3, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer3.ResumeLayout(False)
        CType(RentalTable, ComponentModel.ISupportInitialize).EndInit()
        CType(RentalCarListlTable, ComponentModel.ISupportInitialize).EndInit()
        LogoutPage.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents AppTabControl As TabControl
    Friend WithEvents RegPage As TabPage
    Friend WithEvents CustomerPage As TabPage
    Friend WithEvents RentalPage As TabPage
    Friend WithEvents ReturnPage As TabPage
    Friend WithEvents LogoutPage As TabPage
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
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents RentalCarListlTable As DataGridView
    Friend WithEvents rentalCustomerIdLabel As Label
    Friend WithEvents rentalCarIdLabel As Label
    Friend WithEvents rentalDate As DateTimePicker
    Friend WithEvents RentalFeeFd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RentalDueDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents RentalTable As DataGridView
    Friend WithEvents customerNameCombo As ComboBox
    Friend WithEvents rentalSaveBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents RentalCarListSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents returnBtn As Button
    Friend WithEvents ReturnDatePicker As DateTimePicker
    Friend WithEvents CustomerIdFd As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CustomerNameSearch As TextBox
    Friend WithEvents refreshBtn As Button

End Class
