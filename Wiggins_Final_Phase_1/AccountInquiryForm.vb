'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the account inquiry form. This form shows the current users account information. It also allows the user to update    *
'            :  the customer information. It also validates the information that the users enters. Once the information is entered correctly  *
'            :  and press the submit button the form updates the database with the new information.                                           *
'**********************************************************************************************************************************************
Imports System.Data.OleDb

Public Class AccountInquiryForm

    Dim connect As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = phase2db.accdb")
    Dim command As New OleDbCommand()
    Dim sql As String
    Dim validadd As Boolean = False
    Dim validname As Boolean = False
    Dim validstate As Boolean = False
    Dim validzip As Boolean = False
    Dim validcity As Boolean = False
    Dim updatevalue As String

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form, and set textboxes.               *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub AccountInquiryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelBtns.Left = CInt((Me.Width - panelBtns.Width) / 2)
        panelBtns.Top = CInt((Me.Height - panelBtns.Height) / 1.1)

        panelcustInfo.Left = CInt((Me.Width - panelcustInfo.Width) / 2.5)
        panelcustInfo.Top = CInt((Me.Height - panelcustInfo.Height) / 3.8)

        panelUpdate.Left = CInt((Me.Width - panelcustInfo.Width) / 2.5)
        panelUpdate.Top = CInt((Me.Height - panelcustInfo.Height) / 1.7)


        lblAccountInquiryForm.Left = CInt(Me.Width / 2.8)
        lblAccountInquiryForm.Top = CInt(Me.Height / 7)

        updateForm()
    End Sub

    '*************************************************************************************************
    'Purpose     : A event listener that displays the last form and hides this one.                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnBackInquiryForm_Click(sender As Object, e As EventArgs) Handles btnBackInquiryForm.Click
        AccountMenu.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the name entry.                                                       *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtbxNameUp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtbxNameUp.Validating
        If txtbxNameUp.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtbxNameUp, "You must enter a name.")
            MessageBox.Show("You must enter a First Name.")
        Else
            validname = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the address entry.                                                    *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtbxAddUp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtbxAddUp.Validating
        If txtbxAddUp.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtbxAddUp, "You must enter a address.")
            MessageBox.Show("You must enter an address.")
        Else
            validadd = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the city      entry.                                                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtbxCityUp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtbxCityUp.Validating
        If txtbxCityUp.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtbxCityUp, "You must enter a city.")
            MessageBox.Show("You must enter a city.")
        Else
            validcity = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the zip code entry.                                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtbxZipUp_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtbxZipUp.Validating
        If IsNumeric(txtbxZipUp.Text) Then
            If txtbxZipUp.Text.Length = 5 Then
                ErrorProvider1.Clear()
                e.Cancel = False
            Else
                e.Cancel = True
                ErrorProvider1.SetError(txtbxZipUp, "Must be a five digit Number.")
                MessageBox.Show("Zip code must be a five digit number.")
            End If
        Else
            validzip = True
            e.Cancel = True
            ErrorProvider1.SetError(txtbxZipUp, "Must be a numeric number.")
            MessageBox.Show("You must enter a numeric number.")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the sql statement, updatevalue, and call updatebase()                      *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnSubmitInquiryForm_Click(sender As Object, e As EventArgs) Handles btnSubmitInquiryForm.Click
        Dim name As Integer
        Dim address As Integer
        Dim city As Integer
        Dim state As Integer
        Dim zip As Integer

        If validname = True Then
            sql = "UPDATE Customer SET cust_name = @newValue WHERE cust_id = @ID"
            updatevalue = txtbxNameUp.Text
            name = updateDatabase()
        End If
        If validadd = True Then
            sql = "UPDATE Customer SET cust_address = @newValue WHERE cust_id = @ID"
            updatevalue = txtbxAddUp.Text
            address = updateDatabase()
        End If
        If validcity = True Then
            sql = "UPDATE Customer SET cust_city = @newValue WHERE cust_id = @ID"
            updatevalue = txtbxCityUp.Text
            city = updateDatabase()
        End If
        If validstate = True Then
            sql = "UPDATE Customer SET cust_state = @newValue WHERE cust_id = @ID"
            updatevalue = cmboxState.Text
            state = updateDatabase()
        End If
        If validzip = True Then
            sql = "UPDATE Customer SET cust_zip = @newValue WHERE cust_id = @ID"
            updatevalue = txtbxZipUp.Text
            zip = updateDatabase()
        End If

        If name = 1 Or address = 1 Or city = 1 Or state = 1 Or zip = 1 Then
            updateForm()
            MessageBox.Show("File updated")
        Else
            MessageBox.Show("Problem updating file")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate that a state has been selected.                                       *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub cmboxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxState.SelectedIndexChanged
        validstate = True
    End Sub

    '*************************************************************************************************
    'Purpose     : To update database with new information.                                          *
    'Passed In   : Nothing                                                                           *
    'Returned    : An integer                                                                        *
    '*************************************************************************************************
    Private Function updateDatabase() As Integer
        connect.Open()
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("newValue", updatevalue)
        command.Parameters.AddWithValue("@ID", custId)
        Try
            Dim count As Integer = command.ExecuteNonQuery()

            If count > 0 Then
                connect.Close()
                Return count
            Else
                connect.Close()
                Return count
            End If
        Catch ex As Exception
            connect.Close()
            Return 0
            MessageBox.Show("Error updating file")
        End Try
    End Function

    '*************************************************************************************************
    'Purpose     : To get data from database and set textboxes.                                      *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub updateForm()
        connect.Open()
        sql = "SELECT * FROM customer WHERE cust_id = @ID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@ID", custId)

        Dim reader As OleDbDataReader = command.ExecuteReader()

        Try
            reader.Read()
        Catch ex As Exception
            MessageBox.Show("Error reading File")
        End Try

        If reader.HasRows Then
            txtbxCustID.Text = custId.ToString
            txtbxName.Text = reader("cust_name").ToString
            txtbxAddress.Text = reader("cust_address").ToString
            txtbxCity.Text = reader("cust_city").ToString
            txtbxState.Text = reader("cust_state").ToString
            txtbxZip.Text = reader("cust_zip").ToString
            txtbxAmountOwed.Text = FormatCurrency(reader("Amount Due").ToString)

        Else
            MessageBox.Show("Customer not found")
        End If
        connect.Close()
    End Sub

End Class