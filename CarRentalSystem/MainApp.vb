Imports System.IO
Imports MySql.Data.MySqlClient

Public Class MainApp
    Private connectionString As String = "server=localhost;user=root;database=car_rental"
    Dim idValue As Object
    Dim nameValue As Object
    Dim addressValue As Object
    Dim contactValue As Object

    ' For Car
    Dim carIdValue As Object
    Dim plateNumberValue As Object
    Dim brandValue As Object
    Dim modelValue As Object
    Dim carColorValue As Object

    ' For Rental
    Dim rentalCarId As Object
    Dim rentalCustomerId As Object

    Dim driverPhotoPath As String

    Dim globalDriverID As Object
    Dim carRating As Int32

    Private Sub AddCustomer()
        If String.IsNullOrWhiteSpace(customerName.Text) Or String.IsNullOrWhiteSpace(contact.Text) Or String.IsNullOrWhiteSpace(address.Text) Then
            MessageBox.Show("Empty/Incomplete Form.")
            Exit Sub
        End If
        Dim query As String = "insert into customer (customer_name, address, contact) values (@v1, @v2, @v3)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", customerName.Text)
                command.Parameters.AddWithValue("@v2", address.Text)
                command.Parameters.AddWithValue("@v3", contact.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Customer Added.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub AddCar()
        If String.IsNullOrWhiteSpace(plateNumberFd.Text) Or String.IsNullOrWhiteSpace(brandFd.Text) Or String.IsNullOrWhiteSpace(modelFd.Text) Or String.IsNullOrWhiteSpace(colorFd.Text) Then
            MessageBox.Show("Empty/Incomplete Form.")
            Exit Sub
        End If
        Dim query As String = "insert into car (plate_number, brand, model, color, car_description) values (@v1, @v2, @v3, @v4, @v5)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", plateNumberFd.Text)
                command.Parameters.AddWithValue("@v2", brandFd.Text)
                command.Parameters.AddWithValue("@v3", modelFd.Text)
                command.Parameters.AddWithValue("@v4", colorFd.Text)
                command.Parameters.AddWithValue("@v5", CarDescriptionTextBox.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Car Added.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Dim isPaid As String
    Private Sub AddRental()
        If String.IsNullOrWhiteSpace(RentalCarIDTextbox.Text) Or String.IsNullOrWhiteSpace(RentalCustomerIDTextbox.Text) Or String.IsNullOrWhiteSpace(customerNameCombo.Text) Or String.IsNullOrWhiteSpace(RentalUnitFeeFd.Text) Or String.IsNullOrWhiteSpace(CarRentalDatePicker.Text) Then
            MessageBox.Show("complete the form.")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(RentalUnitFeeFd.Text) Then
            MessageBox.Show("complete the form.")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(RentalDaysNumericUpDown.Value) Then
            MessageBox.Show("complete the form.")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(isPaid) Then
            MessageBox.Show("complete the form.")
            Exit Sub
        End If

        Dim query As String = "insert into rental (car_id, customer_id, customer_name, rental_fee, date, due_date, driver_name, paid) values (@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8)"
        Dim query2 As String = $"update car set available='no' where car_id={rentalCarId}"

        Dim rentalDate As DateTime = DateTime.Parse(CarRentalDatePicker.Text)
        Dim numberOfDays As Int32 = RentalDaysNumericUpDown.Value
        Dim dueDate As DateTime = rentalDate.AddDays(numberOfDays)

        Dim fee As Int32 = RentalUnitFeeFd.Text * numberOfDays

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", rentalCarId)
                command.Parameters.AddWithValue("@v2", rentalCustomerId)
                command.Parameters.AddWithValue("@v3", customerNameCombo.Text)
                command.Parameters.AddWithValue("@v4", fee)
                command.Parameters.AddWithValue("@v5", DateTime.Parse(CarRentalDatePicker.Text))
                command.Parameters.AddWithValue("@v6", dueDate)
                command.Parameters.AddWithValue("@v7", RentalDriverComboBox.Text)
                command.Parameters.AddWithValue("@v8", isPaid)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()

                    Using command2 As New MySqlCommand(query2, connection)
                        Try
                            command2.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End Using
                    MessageBox.Show("Rental Added.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using

        rentalCarId = String.Empty
        rentalCustomerId = String.Empty
        RentalUnitFeeFd.Clear()
    End Sub

    Private Sub UpdateCustomer()
        If String.IsNullOrWhiteSpace(customerName.Text) Or String.IsNullOrWhiteSpace(contact.Text) Or String.IsNullOrWhiteSpace(address.Text) Then
            MessageBox.Show("Select customer from table.")
            Exit Sub
        End If

        Dim query As String = "update customer set customer_name=@v1, address=@v2, contact=@v3 where customer_id=@v4"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", customerName.Text)
                command.Parameters.AddWithValue("@v2", address.Text)
                command.Parameters.AddWithValue("@v3", contact.Text)
                command.Parameters.AddWithValue("@v4", idValue)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Update complete.")
                Catch ex As Exception
                    MessageBox.Show("Update error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub UpdateCar()
        If String.IsNullOrWhiteSpace(plateNumberFd.Text) Or String.IsNullOrWhiteSpace(brandFd.Text) Or String.IsNullOrWhiteSpace(modelFd.Text) Or String.IsNullOrWhiteSpace(colorFd.Text) Or String.IsNullOrWhiteSpace(CarDescriptionTextBox.Text) Then
            MessageBox.Show("Select car from table.")
            Exit Sub
        End If

        Dim query As String = "update car set plate_number=@v1, brand=@v2, model=@v3, color=@v4, car_description=@v6 where car_id=@v5"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", plateNumberFd.Text)
                command.Parameters.AddWithValue("@v2", brandFd.Text)
                command.Parameters.AddWithValue("@v3", modelFd.Text)
                command.Parameters.AddWithValue("@v4", colorFd.Text)
                command.Parameters.AddWithValue("@v5", carIdValue)
                command.Parameters.AddWithValue("@v6", CarDescriptionTextBox.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Update complete.")
                Catch ex As Exception
                    MessageBox.Show("Update error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteCustomer()
        If String.IsNullOrWhiteSpace(customerName.Text) Or String.IsNullOrWhiteSpace(contact.Text) Or String.IsNullOrWhiteSpace(address.Text) Then
            MessageBox.Show("Select customer from table.")
            Exit Sub
        End If

        Dim query As String = "delete from customer where customer_id=@v1"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", idValue)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Delete complete.")
                Catch ex As Exception
                    MessageBox.Show("Delete error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DeleteCar()
        If String.IsNullOrWhiteSpace(plateNumberFd.Text) Or String.IsNullOrWhiteSpace(brandFd.Text) Or String.IsNullOrWhiteSpace(modelFd.Text) Or String.IsNullOrWhiteSpace(colorFd.Text) Or String.IsNullOrWhiteSpace(CarDescriptionTextBox.Text) Then
            MessageBox.Show("Select car from table.")
            Exit Sub
        End If

        Dim query As String = "delete from car where car_id=@v1"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", carIdValue)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Delete complete.")
                Catch ex As Exception
                    MessageBox.Show("Delete error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadCustomerData()
        Dim query As String = "select * from customer"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView1.ClearSelection()
                    DataGridView1.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadCarData()
        Dim query As String = "select * from car"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView2.ClearSelection()
                    DataGridView2.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadRentalCarListData()
        Dim query As String = "select * from car where available='yes'"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    RentalCarListlTable.ClearSelection()
                    RentalCarListlTable.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadDataToCombo()
        Dim query As String = "SELECT customer_name FROM customer"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)

                    customerNameCombo.DataSource = dataTable
                    customerNameCombo.DisplayMember = "customer_name"
                Catch ex As Exception
                    MessageBox.Show("Error loading data into ComboBox: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadRentalData()
        Dim query As String = "select * from rental"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    RentalTable.ClearSelection()
                    RentalTable.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ClearCustomerForm()
        customerName.Clear()
        address.Clear()
        contact.Clear()
    End Sub

    Private Sub ClearCarForm()
        plateNumberFd.Clear()
        brandFd.Clear()
        modelFd.Clear()
        colorFd.Clear()
        CarDescriptionTextBox.Clear()
    End Sub
    Private Sub addCustomerBtn_Click(sender As Object, e As EventArgs) Handles addCustomerBtn.Click
        AddCustomer()
        LoadCustomerData()
        ClearCustomerForm()
    End Sub

    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadCustomerData()
        LoadCarData()
        LoadRentalCarListData()
        LoadDataToCombo()
        LoadRentalData()
        LoadReturnCustomerNameCombo()
        LoadReturnData()
        LoadReturnCustomerNameCombo()
        LoadDriverData()
        LoadDriverNameToComboBox()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ' Access data from the selected row as needed
            idValue = selectedRow.Cells("customer_id").Value
            nameValue = selectedRow.Cells("customer_name").Value
            addressValue = selectedRow.Cells("address").Value
            contactValue = selectedRow.Cells("contact").Value

            customerName.Text = nameValue
            contact.Text = contactValue
            address.Text = addressValue
        End If
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        UpdateCustomer()
        LoadCustomerData()
        ClearCustomerForm()
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        DeleteCustomer()
        LoadCustomerData()
        ClearCustomerForm()
    End Sub

    Private Sub searchNameFd_TextChanged(sender As Object, e As EventArgs) Handles searchNameFd.TextChanged
        Dim query As String = $"select * from customer where customer_name like '%{searchNameFd.Text}%'"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView1.ClearSelection()
                    DataGridView1.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub addCarBtn_Click(sender As Object, e As EventArgs) Handles addCarBtn.Click
        AddCar()
        LoadCarData()
        ClearCarForm()
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
            ' Access data from the selected row as needed
            carIdValue = selectedRow.Cells("car_id").Value

            plateNumberFd.Text = selectedRow.Cells("plate_number").Value
            brandFd.Text = selectedRow.Cells("brand").Value
            modelFd.Text = selectedRow.Cells("model").Value
            colorFd.Text = selectedRow.Cells("color").Value
            CarDescriptionTextBox.Text = selectedRow.Cells("car_description").Value
        End If
    End Sub

    Private Sub updateCarBtn_Click(sender As Object, e As EventArgs) Handles updateCarBtn.Click
        UpdateCar()
        LoadCarData()
        ClearCarForm()
    End Sub

    Private Sub deleteCarBtn_Click(sender As Object, e As EventArgs) Handles deleteCarBtn.Click
        DeleteCar()
        LoadCarData()
        ClearCarForm()
    End Sub

    Private Sub searchBrandFd_TextChanged(sender As Object, e As EventArgs) Handles searchBrandFd.TextChanged
        Dim query As String = $"select * from car where brand like '%{searchBrandFd.Text}%'"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    DataGridView2.ClearSelection()
                    DataGridView2.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub customerNameCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customerNameCombo.SelectedIndexChanged
        Dim query As String = "select customer_id from customer where customer_name=@v1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", customerNameCombo.Text)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        rentalCustomerId = result.ToString()
                        RentalCustomerIDTextbox.Text = result.ToString()
                        'Else
                        '    MessageBox.Show("No data found.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub RentaCarListlTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RentalCarListlTable.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = RentalCarListlTable.Rows(e.RowIndex)
            ' Access data from the selected row as needed
            rentalCarId = selectedRow.Cells("car_id").Value

            RentalCarIDTextbox.Text = rentalCarId
        End If
    End Sub

    Private Sub rentalSaveBtn_Click(sender As Object, e As EventArgs) Handles rentalSaveBtn.Click
        AddRental()
        LoadRentalData()
        LoadRentalCarListData()
    End Sub

    Private Sub CustomerNameSearch_TextChanged(sender As Object, e As EventArgs) Handles CustomerNameSearch.TextChanged
        Dim query As String = $"select * from rental where customer_name like '%{CustomerNameSearch.Text}%'"

        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)
                    RentalTable.ClearSelection()
                    RentalTable.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs)
        LoadRentalCarListData()
        LoadRentalData()
        LoadDataToCombo()
        LoadDriverNameToComboBox()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub RefreshCarBtn_Click(sender As Object, e As EventArgs)
        LoadCarData()
    End Sub

    Private Sub AddReturnCars()
        If String.IsNullOrWhiteSpace(carRating) Then
            MessageBox.Show("Rate the car")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(ReturnPenaltyUnitFeeTextbox.Text) Then
            MessageBox.Show("Enter penalty unit fee")
            Exit Sub
        End If

        Dim query2 As String = "update car set available='yes'"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query2, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using

        Dim query3 As String = "update rental set returned = 'yes' where customer_id=@v1"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query3, connection)
                command.Parameters.AddWithValue("@v1", ReturnCustomerIDTextBox.Text)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using

        Dim query5 As String = "update rental set paid = 'yes' where customer_id = @id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query5, connection)
                command.Parameters.AddWithValue("@id", ReturnCustomerIDTextBox.Text)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
        Dim dueDateValue As DateTime
        Dim query6 As String = "select due_date from rental where customer_id = @id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query6, connection)
                command.Parameters.AddWithValue("@id", ReturnCustomerIDTextBox.Text)
                connection.Open()
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        dueDateValue = reader.GetDateTime("due_date")
                    End While
                End Using
            End Using
        End Using

        Dim difference As TimeSpan = dueDateValue - DateTime.Parse(ReturnDateDatepicker.Text)
        Dim totalDays As Int32 = difference.Days

        Dim penaltyFee As Int32 = Int32.Parse(ReturnPenaltyUnitFeeTextbox.Text) * totalDays

        Dim query As String = "insert into rental_return (car_id, customer_id, customer_name, date, elapsed_days, fee, car_rating)" & "
 values (@v1, @v2, @v3, @v4, @v5, @v6, @v7)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", ReturnCarIDTextbox.Text)
                command.Parameters.AddWithValue("@v2", ReturnCustomerIDTextBox.Text)
                command.Parameters.AddWithValue("@v3", ReturnCustomerNameCombo.Text)
                command.Parameters.AddWithValue("@v4", DateTime.Parse(ReturnDateDatepicker.Text))
                command.Parameters.AddWithValue("@v5", totalDays)
                command.Parameters.AddWithValue("@v6", penaltyFee)
                command.Parameters.AddWithValue("@v7", carRating)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Added successfully.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadReturnData()
        Dim query As String = "select * from rental_return"
        Using connecton As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connecton)
                Dim dataTable As New DataTable()

                Try
                    connecton.Open()
                    adapter.Fill(dataTable)
                    ReturnTable.ClearSelection()
                    ReturnTable.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub LoadReturnCustomerNameCombo()
        Dim query As String = "SELECT customer_name FROM rental"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)

                    ReturnCustomerNameCombo.DataSource = dataTable
                    ReturnCustomerNameCombo.DisplayMember = "customer_name"
                Catch ex As Exception
                    MessageBox.Show("Error loading data into ComboBox: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ReturnCustomerNameCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReturnCustomerNameCombo.SelectedIndexChanged
        Dim query As String = "select car_id from rental where customer_name=@v1"
        Dim query2 As String = "select customer_id from rental where customer_name=@v1"
        Dim query3 As String = "select due_date from rental where customer_name=@v1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", ReturnCustomerNameCombo.Text)

                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        ReturnCarIDTextbox.Text = result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving data: " & ex.Message)
                End Try
            End Using

            Using command2 As New MySqlCommand(query2, connection)
                command2.Parameters.AddWithValue("@v1", ReturnCustomerNameCombo.Text)

                Try
                    Dim result As Object = command2.ExecuteScalar()
                    If result IsNot Nothing Then
                        ReturnCustomerIDTextBox.Text = result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving data: " & ex.Message)
                End Try
            End Using

            Using command3 As New MySqlCommand(query3, connection)
                command3.Parameters.AddWithValue("@v1", ReturnCustomerNameCombo.Text)

                Try
                    Dim result As Object = command3.ExecuteScalar()
                    If result IsNot Nothing Then
                        ReturnDueDateLabel.Text = "Due Date: " & result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error retrieving data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ReturnSaveBtn_Click(sender As Object, e As EventArgs) Handles ReturnSaveBtn.Click
        AddReturnCars()
        LoadReturnData()
    End Sub

    Private Sub DeleteReturnCar()
        Dim id As Integer
        If ReturnTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = ReturnTable.SelectedRows(0)

            id = Convert.ToInt32(selectedRow.Cells("return_id").Value)
        End If

        Dim query As String = "delete from rental_return where return_id=@v1"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", id)
                connection.Open()
                Dim dialog As DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo)

                If dialog = DialogResult.Yes Then
                    Try
                        command.ExecuteNonQuery()
                        MessageBox.Show("Deleted Successfully.")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End Using
        End Using
    End Sub
    Private Sub ReturnDeleteBtn_Click(sender As Object, e As EventArgs) Handles ReturnDeleteBtn.Click
        DeleteReturnCar()
        LoadReturnData()
    End Sub

    Private Sub ReturnRefreshBtn_Click(sender As Object, e As EventArgs)
        LoadReturnData()
        LoadReturnCustomerNameCombo()
    End Sub

    Private Sub DeleteRentalBtn_Click(sender As Object, e As EventArgs) Handles DeleteRentalBtn.Click
        Dim id As Integer
        Dim car_id As Int32
        If RentalTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = RentalTable.SelectedRows(0)

            id = Convert.ToInt32(selectedRow.Cells("rental_id").Value)
            car_id = Convert.ToInt32(selectedRow.Cells("car_id").Value)
        End If

        Dim query As String = "delete from rental where rental_id=@v1"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", id)
                connection.Open()
                Dim dialog As DialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo)

                If dialog = DialogResult.Yes Then
                    Try
                        command.ExecuteNonQuery()
                        MessageBox.Show("Deleted Successfully.")
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try
                End If
            End Using
        End Using

        Dim query2 As String = $"update car set available = 'yes' where car_id = {car_id}"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query2, connection)
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
        LoadRentalData()
        LoadRentalCarListData()
    End Sub

    Private Sub LoadDriverData()
        Dim query As String = "SELECT driver_id, driver_name, driver_contact, driver_address FROM drivers"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(command)
                Dim dataTable As New DataTable()

                Try
                    connection.Open()
                    adapter.Fill(dataTable)

                    DriverDataGridView.ClearSelection()
                    DriverDataGridView.DataSource = dataTable
                Catch ex As Exception
                    MessageBox.Show("Error loading data into ComboBox: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub ClearDriverForm()
        DriverFullnameTextBox.Clear()
        DriverContactTextBox.Clear()
        DriverAddressTextBox.Clear()
        DriverPictureBox.Image = Image.FromFile("")
    End Sub

    Private Sub AddDriverBtn_Click(sender As Object, e As EventArgs) Handles AddDriverBtn.Click
        Dim imageByte As Byte() = File.ReadAllBytes(driverPhotoPath)
        Dim query As String = "INSERT INTO drivers (driver_name, driver_contact, driver_address, driver_photo) VALUES (@1, @2, @3, @4)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@1", DriverFullnameTextBox.Text)
                command.Parameters.AddWithValue("@2", DriverContactTextBox.Text)
                command.Parameters.AddWithValue("@3", DriverAddressTextBox.Text)
                command.Parameters.AddWithValue("@4", imageByte)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Driver Added.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
        LoadDriverData()
    End Sub

    Private Sub RefreshDriverDataBtn_Click(sender As Object, e As EventArgs)
        LoadDriverData()
    End Sub

    Private Sub UploadDriverPhotoBtn_Click(sender As Object, e As EventArgs) Handles UploadDriverPhotoBtn.Click
        Dim openFileDialog As New OpenFileDialog()

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            driverPhotoPath = openFileDialog.FileName
            DriverPictureBox.Image = Image.FromFile(driverPhotoPath)
        End If
    End Sub

    Private Sub ShowSelectedDriverPhoto(driverID As Object)
        Dim query As String = "select driver_photo from drivers where driver_id=@id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", driverID)

                Try
                    connection.Open()
                    Dim imageData As Byte() = DirectCast(command.ExecuteScalar(), Byte())

                    If imageData IsNot Nothing Then
                        Using stream As New MemoryStream(imageData)
                            Using image As Image = Image.FromStream(stream)
                                DriverPictureBox.Image = New Bitmap(image)
                            End Using
                        End Using
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub SetDriverDataForUpdate(driverID As Object, driverName As Object, driverContact As Object, driverAddress As Object)
        DriverFullnameTextBox.Text = driverName
        DriverContactTextBox.Text = driverContact
        DriverAddressTextBox.Text = driverAddress
        globalDriverID = driverID
    End Sub

    Private Sub DriverDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DriverDataGridView.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DriverDataGridView.Rows(e.RowIndex)
            ' Access data from the selected row as needed
            Dim driverID As Object = selectedRow.Cells("driver_id").Value
            Dim driverName As Object = selectedRow.Cells("driver_name").Value
            Dim driverContact As Object = selectedRow.Cells("driver_contact").Value
            Dim driverAddress As Object = selectedRow.Cells("driver_address").Value

            ShowSelectedDriverPhoto(driverID)
            SetDriverDataForUpdate(driverName:=driverName, driverContact:=driverContact, driverAddress:=driverAddress, driverID:=driverID)
        End If
    End Sub

    Private Sub DriverDeleteBtn_Click(sender As Object, e As EventArgs) Handles DriverDeleteBtn.Click
        Dim id As Integer
        If DriverDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DriverDataGridView.SelectedRows(0)

            id = Convert.ToInt32(selectedRow.Cells("driver_id").Value)
        Else
            MessageBox.Show("Select a row.")
            Exit Sub
        End If

        Dim query As String = "DELETE FROM drivers WHERE driver_id=@id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id", id)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Driver delete.")
                    LoadDriverData()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DriverUpdateBtn_Click(sender As Object, e As EventArgs) Handles DriverUpdateBtn.Click
        Dim query As String = "UPDATE drivers SET driver_name = @name, driver_contact = @contact, driver_address = @address WHERE driver_id = @id"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@name", DriverFullnameTextBox.Text)
                command.Parameters.AddWithValue("@contact", DriverContactTextBox.Text)
                command.Parameters.AddWithValue("@address", DriverAddressTextBox.Text)
                command.Parameters.AddWithValue("@id", globalDriverID)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Driver Data Updated.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub DriverUpdatePhotoBtn_Click(sender As Object, e As EventArgs) Handles DriverUpdatePhotoBtn.Click
        Dim id As Integer
        If DriverDataGridView.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DriverDataGridView.SelectedRows(0)

            id = Convert.ToInt32(selectedRow.Cells("driver_id").Value)
        Else
            MessageBox.Show("Select a row.")
            Exit Sub
        End If

        Dim openFileDialog As New OpenFileDialog()

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            driverPhotoPath = openFileDialog.FileName
            DriverPictureBox.Image = Image.FromFile(driverPhotoPath)
        End If

        Dim imageByte As Byte() = File.ReadAllBytes(driverPhotoPath)

        Dim query As String = "UPDATE drivers SET driver_photo = @photo WHERE driver_id = @id"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@photo", imageByte)
                command.Parameters.AddWithValue("@id", id)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Photo updated.")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Dim printContent As String
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim printFont As New Font("Arial", 12)
        Dim printLocation As New PointF(100, 100) ' Adjust the location where you want to start printing
        Dim printRect As New RectangleF(printLocation, e.PageBounds.Size)

        ' Draw the content of the file on the print document
        e.Graphics.DrawString(printContent, printFont, Brushes.Black, printRect)
    End Sub

    Private Sub OpenTCBtn_Click(sender As Object, e As EventArgs) Handles OpenTCBtn.Click
        Dim openFileDialog1 As New OpenFileDialog()

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog1.FileName
            printContent = selectedFilePath
            MessageBox.Show("Selected file: " & selectedFilePath)
        End If

        If File.Exists(printContent) Then
            printContent = File.ReadAllText(printContent)
            PrintDocument1.Print()
        Else
            MessageBox.Show("File not found.")
        End If
    End Sub

    Private Sub LoadDriverNameToComboBox()
        Dim query As String = "SELECT driver_name FROM drivers where driver_available = 'yes'"
        Using connection As New MySqlConnection(connectionString)
            Using adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable

                Try
                    connection.Open()
                    adapter.Fill(dataTable)

                    RentalDriverComboBox.DataSource = dataTable
                    RentalDriverComboBox.DisplayMember = "driver_name"
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub YesRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles YesRadioBtn.CheckedChanged
        isPaid = YesRadioBtn.Text
    End Sub

    Private Sub NoRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles NoRadioBtn.CheckedChanged
        isPaid = NoRadioBtn.Text
    End Sub

    Private Sub RateOneRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RateOneRadioBtn.CheckedChanged
        carRating = RateOneRadioBtn.Text
    End Sub

    Private Sub RateTwoRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RateTwoRadioBtn.CheckedChanged
        carRating = RateTwoRadioBtn.Text
    End Sub

    Private Sub RateThreeRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RateThreeRadioBtn.CheckedChanged
        carRating = RateThreeRadioBtn.Text
    End Sub

    Private Sub RateFourRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RateFourRadioBtn.CheckedChanged
        carRating = RateFourRadioBtn.Text
    End Sub

    Private Sub RateFiveRadioBtn_CheckedChanged(sender As Object, e As EventArgs) Handles RateFiveRadioBtn.CheckedChanged
        carRating = RateFiveRadioBtn.Text
    End Sub

    Private Sub AppTabControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AppTabControl.SelectedIndexChanged
        If AppTabControl.SelectedTab Is RegPage Then
            LoadCarData()
        ElseIf AppTabControl.SelectedTab Is CustomerPage Then
            LoadCustomerData()
        ElseIf AppTabControl.SelectedTab Is RentalPage Then
            LoadRentalCarListData()
            LoadRentalData()
            LoadDataToCombo()
            LoadDriverNameToComboBox()
        ElseIf AppTabControl.SelectedTab Is ReturnPage Then
            LoadReturnData()
            LoadReturnCustomerNameCombo()
        ElseIf AppTabControl.SelectedTab Is DriverPage Then
            LoadDriverData()
        End If
    End Sub
End Class
