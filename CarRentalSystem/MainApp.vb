Imports MySql.Data.MySqlClient

Public Class MainApp
    Private connectionString As String = "server=localhost;user=root;database=car_rental"

    Private Sub AddCustomer()
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

    Private Sub LoadTable()

    End Sub

    Private Sub ClearForm()
        customerName.Clear()
        address.Clear()
        contact.Clear()
    End Sub
    Private Sub addCustomerBtn_Click(sender As Object, e As EventArgs) Handles addCustomerBtn.Click
        AddCustomer()
        ClearForm()
    End Sub
End Class
