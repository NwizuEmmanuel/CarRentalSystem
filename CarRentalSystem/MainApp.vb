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
        Dim query As String = "insert into car (plate_number, brand, model, color) values (@v1, @v2, @v3, @v4)"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", plateNumberFd.Text)
                command.Parameters.AddWithValue("@v2", brandFd.Text)
                command.Parameters.AddWithValue("@v3", modelFd.Text)
                command.Parameters.AddWithValue("@v4", colorFd.Text)

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

    Private Sub AddRental()
        If String.IsNullOrWhiteSpace(RentalCarIDTextbox.Text) Or String.IsNullOrWhiteSpace(RentalCustomerIDTextbox.Text) Or String.IsNullOrWhiteSpace(customerNameCombo.Text) Or String.IsNullOrWhiteSpace(RentalFeeFd.Text) Or String.IsNullOrWhiteSpace(rentalDate.Text) Or String.IsNullOrWhiteSpace(RentalDueDate.Text) Then
            MessageBox.Show("complete the form.")
            Exit Sub
        End If
        Dim query As String = "insert into rental (car_id, customer_id, customer_name, rental_fee, date, due_date) values (@v1, @v2, @v3, @v4, @v5, @v6)"
        Dim query2 As String = $"update car set available='no' where car_id={rentalCarId}"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", rentalCarId)
                command.Parameters.AddWithValue("@v2", rentalCustomerId)
                command.Parameters.AddWithValue("@v3", customerNameCombo.Text)
                command.Parameters.AddWithValue("@v4", RentalFeeFd.Text)
                command.Parameters.AddWithValue("@v5", DateTime.Parse(rentalDate.Text))
                command.Parameters.AddWithValue("@v6", DateTime.Parse(RentalDueDate.Text))

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
        RentalFeeFd.Clear()
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
        If String.IsNullOrWhiteSpace(plateNumberFd.Text) Or String.IsNullOrWhiteSpace(brandFd.Text) Or String.IsNullOrWhiteSpace(modelFd.Text) Or String.IsNullOrWhiteSpace(colorFd.Text) Then
            MessageBox.Show("Select car from table.")
            Exit Sub
        End If

        Dim query As String = "update car set plate_number=@v1, brand=@v2, model=@v3, color=@v4 where car_id=@v5"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", plateNumberFd.Text)
                command.Parameters.AddWithValue("@v2", brandFd.Text)
                command.Parameters.AddWithValue("@v3", modelFd.Text)
                command.Parameters.AddWithValue("@v4", colorFd.Text)
                command.Parameters.AddWithValue("@v5", carIdValue)

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
        If String.IsNullOrWhiteSpace(plateNumberFd.Text) Or String.IsNullOrWhiteSpace(brandFd.Text) Or String.IsNullOrWhiteSpace(modelFd.Text) Or String.IsNullOrWhiteSpace(colorFd.Text) Then
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
            plateNumberValue = selectedRow.Cells("plate_number").Value
            brandValue = selectedRow.Cells("brand").Value
            modelValue = selectedRow.Cells("model").Value
            carColorValue = selectedRow.Cells("color").Value

            plateNumberFd.Text = plateNumberValue
            brandFd.Text = brandValue
            modelFd.Text = modelValue
            colorFd.Text = carColorValue
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

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        LoadRentalCarListData()
        LoadRentalData()
        LoadDataToCombo()
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub RefreshCarBtn_Click(sender As Object, e As EventArgs) Handles RefreshCarBtn.Click
        LoadCarData()
    End Sub

    Private Sub AddReturnCars()
        Dim query As String = "insert into rental_return (car_id, customer_id, customer_name, date, elapsed_days, fee)" & "
 values (@v1, @v2, @v3, @v4, @v5, @v6)"
        Dim query2 As String = "update car set available='yes'"
        Dim query3 As String = "delete from rental where customer_id=@v1"
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@v1", ReturnCarIDTextbox.Text)
                command.Parameters.AddWithValue("@v2", ReturnCustomerIDTextBox.Text)
                command.Parameters.AddWithValue("@v3", ReturnCustomerNameCombo.Text)
                command.Parameters.AddWithValue("@v4", DateTime.Parse(ReturnDateDatepicker.Text))
                command.Parameters.AddWithValue("@v5", ReturnElapsedDayTextBox.Text)
                command.Parameters.AddWithValue("@v6", ReturnFeeTextbox.Text)

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Added successfully.")
                    Using command2 As New MySqlCommand(query2, connection)
                        Try
                            command2.ExecuteNonQuery()
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using

            Using command3 As New MySqlCommand(query3, connection)
                command3.Parameters.AddWithValue("@v1", ReturnCustomerIDTextBox.Text)

                Try
                    command3.ExecuteNonQuery()
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

    Private Sub ReturnRefreshBtn_Click(sender As Object, e As EventArgs) Handles ReturnRefreshBtn.Click
        LoadReturnData()
        LoadReturnCustomerNameCombo()
    End Sub

    Private Sub DeleteRentalBtn_Click(sender As Object, e As EventArgs) Handles DeleteRentalBtn.Click
        Dim id As Integer
        If RentalTable.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = RentalTable.SelectedRows(0)

            id = Convert.ToInt32(selectedRow.Cells("rental_id").Value)
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
        LoadRentalData()
    End Sub
End Class
