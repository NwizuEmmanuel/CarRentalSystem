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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        AppTabControl = New TabControl()
        RegPage = New TabPage()
        SplitContainer1 = New SplitContainer()
        RefreshCarBtn = New Button()
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
        address = New TextBox()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        addCustomerBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        Label8 = New Label()
        searchNameFd = New TextBox()
        RentalPage = New TabPage()
        SplitContainer2 = New SplitContainer()
        RentalCustomerIDTextbox = New TextBox()
        Label5 = New Label()
        RentalCarIDTextbox = New TextBox()
        DeleteRentalBtn = New Button()
        refreshBtn = New Button()
        CustomerNameSearch = New TextBox()
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
        ReturnTable = New DataGridView()
        Panel1 = New Panel()
        ReturnRefreshBtn = New Button()
        ReturnDueDateLabel = New Label()
        ReturnDeleteBtn = New Button()
        ReturnSaveBtn = New Button()
        ReturnFeeTextbox = New TextBox()
        Label14 = New Label()
        ReturnElapsedDayTextBox = New TextBox()
        Label13 = New Label()
        Label12 = New Label()
        ReturnDateDatepicker = New DateTimePicker()
        ReturnCustomerNameCombo = New ComboBox()
        Label11 = New Label()
        ReturnCustomerIDTextBox = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        ReturnCarIDTextbox = New TextBox()
        LogoutPage = New TabPage()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Label1 = New Label()
        LogoutBtn = New Button()
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
        ReturnPage.SuspendLayout()
        CType(ReturnTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        SplitContainer1.Panel1.Controls.Add(RefreshCarBtn)
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
        ' RefreshCarBtn
        ' 
        RefreshCarBtn.Location = New Point(5, 269)
        RefreshCarBtn.Name = "RefreshCarBtn"
        RefreshCarBtn.Size = New Size(75, 23)
        RefreshCarBtn.TabIndex = 8
        RefreshCarBtn.Text = "Refresh"
        RefreshCarBtn.UseVisualStyleBackColor = True
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
        deleteCarBtn.TextImageRelation = TextImageRelation.ImageBeforeText
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
        DataGridView1.Location = New Point(323, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(507, 495)
        DataGridView1.TabIndex = 7
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Controls.Add(customerName)
        FlowLayoutPanel4.Controls.Add(contact)
        FlowLayoutPanel4.Controls.Add(address)
        FlowLayoutPanel4.Controls.Add(FlowLayoutPanel2)
        FlowLayoutPanel4.Controls.Add(Label8)
        FlowLayoutPanel4.Controls.Add(searchNameFd)
        FlowLayoutPanel4.Dock = DockStyle.Left
        FlowLayoutPanel4.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel4.Location = New Point(3, 3)
        FlowLayoutPanel4.Margin = New Padding(3, 10, 3, 3)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(320, 495)
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
        ' address
        ' 
        address.Location = New Point(3, 82)
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
        FlowLayoutPanel2.Location = New Point(3, 147)
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
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(3, 225)
        Label8.Margin = New Padding(3, 30, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(154, 15)
        Label8.TabIndex = 9
        Label8.Text = "Search for customer names."
        ' 
        ' searchNameFd
        ' 
        searchNameFd.Location = New Point(3, 250)
        searchNameFd.Margin = New Padding(3, 10, 3, 3)
        searchNameFd.Name = "searchNameFd"
        searchNameFd.PlaceholderText = "Search name"
        searchNameFd.Size = New Size(188, 23)
        searchNameFd.TabIndex = 8
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
        SplitContainer2.Panel1.Controls.Add(RentalCustomerIDTextbox)
        SplitContainer2.Panel1.Controls.Add(Label5)
        SplitContainer2.Panel1.Controls.Add(RentalCarIDTextbox)
        SplitContainer2.Panel1.Controls.Add(DeleteRentalBtn)
        SplitContainer2.Panel1.Controls.Add(refreshBtn)
        SplitContainer2.Panel1.Controls.Add(CustomerNameSearch)
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
        ' RentalCustomerIDTextbox
        ' 
        RentalCustomerIDTextbox.Location = New Point(98, 76)
        RentalCustomerIDTextbox.Name = "RentalCustomerIDTextbox"
        RentalCustomerIDTextbox.Size = New Size(158, 23)
        RentalCustomerIDTextbox.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 173)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 15)
        Label5.TabIndex = 22
        Label5.Text = "Rental Fee"
        ' 
        ' RentalCarIDTextbox
        ' 
        RentalCarIDTextbox.Location = New Point(98, 47)
        RentalCarIDTextbox.Name = "RentalCarIDTextbox"
        RentalCarIDTextbox.Size = New Size(158, 23)
        RentalCarIDTextbox.TabIndex = 21
        ' 
        ' DeleteRentalBtn
        ' 
        DeleteRentalBtn.Location = New Point(128, 283)
        DeleteRentalBtn.Name = "DeleteRentalBtn"
        DeleteRentalBtn.Size = New Size(75, 23)
        DeleteRentalBtn.TabIndex = 20
        DeleteRentalBtn.Text = "Delete"
        DeleteRentalBtn.UseVisualStyleBackColor = True
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
        ' CustomerNameSearch
        ' 
        CustomerNameSearch.Location = New Point(3, 341)
        CustomerNameSearch.Name = "CustomerNameSearch"
        CustomerNameSearch.PlaceholderText = "Search Customer name"
        CustomerNameSearch.Size = New Size(183, 23)
        CustomerNameSearch.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(0, 129)
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
        customerNameCombo.Location = New Point(98, 126)
        customerNameCombo.Name = "customerNameCombo"
        customerNameCombo.Size = New Size(199, 23)
        customerNameCombo.TabIndex = 9
        ' 
        ' rentalSaveBtn
        ' 
        rentalSaveBtn.Location = New Point(3, 283)
        rentalSaveBtn.Name = "rentalSaveBtn"
        rentalSaveBtn.Size = New Size(75, 23)
        rentalSaveBtn.TabIndex = 8
        rentalSaveBtn.Text = "Save"
        rentalSaveBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(5, 245)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 15)
        Label3.TabIndex = 7
        Label3.Text = "Due Date"
        ' 
        ' RentalDueDate
        ' 
        RentalDueDate.Location = New Point(97, 237)
        RentalDueDate.Name = "RentalDueDate"
        RentalDueDate.Size = New Size(200, 23)
        RentalDueDate.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(5, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(31, 15)
        Label2.TabIndex = 5
        Label2.Text = "Date"
        ' 
        ' rentalDate
        ' 
        rentalDate.Location = New Point(97, 201)
        rentalDate.Name = "rentalDate"
        rentalDate.Size = New Size(200, 23)
        rentalDate.TabIndex = 4
        ' 
        ' RentalFeeFd
        ' 
        RentalFeeFd.Location = New Point(98, 172)
        RentalFeeFd.Name = "RentalFeeFd"
        RentalFeeFd.PlaceholderText = "Rental Fee"
        RentalFeeFd.Size = New Size(183, 23)
        RentalFeeFd.TabIndex = 3
        ' 
        ' rentalCustomerIdLabel
        ' 
        rentalCustomerIdLabel.AutoSize = True
        rentalCustomerIdLabel.Location = New Point(3, 84)
        rentalCustomerIdLabel.Name = "rentalCustomerIdLabel"
        rentalCustomerIdLabel.Size = New Size(73, 15)
        rentalCustomerIdLabel.TabIndex = 1
        rentalCustomerIdLabel.Text = "Customer ID"
        ' 
        ' rentalCarIdLabel
        ' 
        rentalCarIdLabel.AutoSize = True
        rentalCarIdLabel.Location = New Point(5, 50)
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
        ReturnPage.Controls.Add(ReturnTable)
        ReturnPage.Controls.Add(Panel1)
        ReturnPage.Location = New Point(4, 24)
        ReturnPage.Name = "ReturnPage"
        ReturnPage.Padding = New Padding(3)
        ReturnPage.Size = New Size(833, 501)
        ReturnPage.TabIndex = 3
        ReturnPage.Text = "Return"
        ReturnPage.UseVisualStyleBackColor = True
        ' 
        ' ReturnTable
        ' 
        ReturnTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ReturnTable.Dock = DockStyle.Fill
        ReturnTable.Location = New Point(408, 3)
        ReturnTable.Name = "ReturnTable"
        ReturnTable.Size = New Size(422, 495)
        ReturnTable.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ReturnRefreshBtn)
        Panel1.Controls.Add(ReturnDueDateLabel)
        Panel1.Controls.Add(ReturnDeleteBtn)
        Panel1.Controls.Add(ReturnSaveBtn)
        Panel1.Controls.Add(ReturnFeeTextbox)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(ReturnElapsedDayTextBox)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(ReturnDateDatepicker)
        Panel1.Controls.Add(ReturnCustomerNameCombo)
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(ReturnCustomerIDTextBox)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(ReturnCarIDTextbox)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(3, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(405, 495)
        Panel1.TabIndex = 0
        ' 
        ' ReturnRefreshBtn
        ' 
        ReturnRefreshBtn.Location = New Point(308, 12)
        ReturnRefreshBtn.Name = "ReturnRefreshBtn"
        ReturnRefreshBtn.Size = New Size(75, 23)
        ReturnRefreshBtn.TabIndex = 15
        ReturnRefreshBtn.Text = "Refresh"
        ReturnRefreshBtn.UseVisualStyleBackColor = True
        ' 
        ' ReturnDueDateLabel
        ' 
        ReturnDueDateLabel.AutoSize = True
        ReturnDueDateLabel.Location = New Point(5, 15)
        ReturnDueDateLabel.Name = "ReturnDueDateLabel"
        ReturnDueDateLabel.Size = New Size(55, 15)
        ReturnDueDateLabel.TabIndex = 14
        ReturnDueDateLabel.Text = "Due Date"
        ' 
        ' ReturnDeleteBtn
        ' 
        ReturnDeleteBtn.Location = New Point(116, 332)
        ReturnDeleteBtn.Name = "ReturnDeleteBtn"
        ReturnDeleteBtn.Size = New Size(75, 23)
        ReturnDeleteBtn.TabIndex = 13
        ReturnDeleteBtn.Text = "Delete"
        ReturnDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' ReturnSaveBtn
        ' 
        ReturnSaveBtn.Location = New Point(5, 332)
        ReturnSaveBtn.Name = "ReturnSaveBtn"
        ReturnSaveBtn.Size = New Size(75, 23)
        ReturnSaveBtn.TabIndex = 12
        ReturnSaveBtn.Text = "Save"
        ReturnSaveBtn.UseVisualStyleBackColor = True
        ' 
        ' ReturnFeeTextbox
        ' 
        ReturnFeeTextbox.Location = New Point(5, 286)
        ReturnFeeTextbox.Name = "ReturnFeeTextbox"
        ReturnFeeTextbox.Size = New Size(155, 23)
        ReturnFeeTextbox.TabIndex = 11
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(5, 268)
        Label14.Name = "Label14"
        Label14.Size = New Size(25, 15)
        Label14.TabIndex = 10
        Label14.Text = "Fee"
        ' 
        ' ReturnElapsedDayTextBox
        ' 
        ReturnElapsedDayTextBox.Location = New Point(3, 242)
        ReturnElapsedDayTextBox.Name = "ReturnElapsedDayTextBox"
        ReturnElapsedDayTextBox.Size = New Size(157, 23)
        ReturnElapsedDayTextBox.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(3, 224)
        Label13.Name = "Label13"
        Label13.Size = New Size(75, 15)
        Label13.TabIndex = 8
        Label13.Text = "Elapsed Days"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(5, 180)
        Label12.Name = "Label12"
        Label12.Size = New Size(31, 15)
        Label12.TabIndex = 7
        Label12.Text = "Date"
        ' 
        ' ReturnDateDatepicker
        ' 
        ReturnDateDatepicker.Location = New Point(5, 198)
        ReturnDateDatepicker.Name = "ReturnDateDatepicker"
        ReturnDateDatepicker.Size = New Size(200, 23)
        ReturnDateDatepicker.TabIndex = 6
        ' 
        ' ReturnCustomerNameCombo
        ' 
        ReturnCustomerNameCombo.AutoCompleteMode = AutoCompleteMode.Suggest
        ReturnCustomerNameCombo.AutoCompleteSource = AutoCompleteSource.ListItems
        ReturnCustomerNameCombo.FormattingEnabled = True
        ReturnCustomerNameCombo.Location = New Point(5, 154)
        ReturnCustomerNameCombo.Name = "ReturnCustomerNameCombo"
        ReturnCustomerNameCombo.Size = New Size(172, 23)
        ReturnCustomerNameCombo.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(5, 136)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 15)
        Label11.TabIndex = 4
        Label11.Text = "Customer Name"
        ' 
        ' ReturnCustomerIDTextBox
        ' 
        ReturnCustomerIDTextBox.Location = New Point(5, 110)
        ReturnCustomerIDTextBox.Name = "ReturnCustomerIDTextBox"
        ReturnCustomerIDTextBox.Size = New Size(157, 23)
        ReturnCustomerIDTextBox.TabIndex = 3
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(5, 92)
        Label10.Name = "Label10"
        Label10.Size = New Size(73, 15)
        Label10.TabIndex = 2
        Label10.Text = "Customer ID"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(5, 48)
        Label9.Name = "Label9"
        Label9.Size = New Size(39, 15)
        Label9.TabIndex = 1
        Label9.Text = "Car ID"
        ' 
        ' ReturnCarIDTextbox
        ' 
        ReturnCarIDTextbox.Location = New Point(5, 66)
        ReturnCarIDTextbox.Name = "ReturnCarIDTextbox"
        ReturnCarIDTextbox.Size = New Size(157, 23)
        ReturnCarIDTextbox.TabIndex = 0
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
        FlowLayoutPanel1.Controls.Add(LogoutBtn)
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
        ' LogoutBtn
        ' 
        LogoutBtn.Location = New Point(3, 25)
        LogoutBtn.Margin = New Padding(3, 10, 3, 3)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(75, 23)
        LogoutBtn.TabIndex = 1
        LogoutBtn.Text = "Log out"
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' MainApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(841, 529)
        Controls.Add(AppTabControl)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
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
        ReturnPage.ResumeLayout(False)
        CType(ReturnTable, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents LogoutBtn As Button
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
    Friend WithEvents CustomerNameSearch As TextBox
    Friend WithEvents refreshBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DeleteRentalBtn As Button
    Friend WithEvents RefreshCarBtn As Button
    Friend WithEvents ReturnTable As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ReturnCarIDTextbox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ReturnDateDatepicker As DateTimePicker
    Friend WithEvents ReturnCustomerNameCombo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ReturnCustomerIDTextBox As TextBox
    Friend WithEvents ReturnElapsedDayTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ReturnFeeTextbox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ReturnDeleteBtn As Button
    Friend WithEvents ReturnSaveBtn As Button
    Friend WithEvents ReturnDueDateLabel As Label
    Friend WithEvents ReturnRefreshBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents RentalCarIDTextbox As TextBox
    Friend WithEvents RentalCustomerIDTextbox As TextBox

End Class
