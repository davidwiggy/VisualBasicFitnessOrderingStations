'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This form the shopping cart form. This form allows the user to see all the products that have add to their shopping cart. It  *
'            :  also allows the user to remove products from the shopping cart or update the quantity. Once the user presses the submit button*
'            :  the form updates the database with the purchase information.                                                                  *
'**********************************************************************************************************************************************
Imports System.Data.OleDb

Public Class ShoppingCart

    Dim connect As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = phase2db.accdb")
    Dim command As New OleDbCommand()
    Dim sql As String
    Dim equipName As String()
    Dim invenId As String()
    Dim numOrder As String()
    Dim dateOrder As String()
    Dim orderAmount As String()
    Dim gridFlag As Boolean
    Dim checkBoxSelection As Integer = -1

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form and call functions to load grid.  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub ShoppingCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gridFlag = False
        pnlGridHolder.Left = CInt((Me.Width - pnlGridHolder.Width) / 2)
        pnlGridHolder.Top = CInt((Me.Height - pnlGridHolder.Height) / 2.2)

        pnlbtnHolder.Left = CInt((Me.Width - pnlbtnHolder.Width) / 2)
        pnlbtnHolder.Top = CInt((Me.Height - pnlbtnHolder.Height) / 1)

        lblShoppingCart.Top = CInt(Me.Height / 8.2)
        lblShoppingCart.Left = CInt(Me.Width / 2.5)
        loadArrays()
        loadDataGrid()
        txtbxTotal.Text = FormatCurrency(getTotal().ToString)
    End Sub

    '*************************************************************************************************
    'Purpose     : To get the total from all the purchases.                                          *
    'Passed In   : Nothing                                                                           *
    'Returned    : Total amount of purchase.                                                         *
    '*************************************************************************************************
    Private Function getTotal() As Double
        Dim total As Double

        For x As Integer = 0 To orderAmount.Length - 1
            total = total + CDbl(orderAmount(x))
        Next

        If customerRating = 1 And total > 500.0 Then
            total = total - (total * 0.05)
        ElseIf customerRating = 2 And total > 500.0 Then
            total = total - (total * 0.025)
        End If

        Return total
    End Function

    '*************************************************************************************************
    'Purpose     : To load the datagrid from the arrays.                                             *
    'Passed In   : Nothing.                                                                          *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub loadDataGrid()
        DataGridView1.Rows.Clear()

        Dim equipmentName As New DataGridViewTextBoxColumn
        With equipmentName
            .ReadOnly = True
            .HeaderText = "Equipment Name"
            .Name = "equipmentName"
            .Width = 150
        End With

        Dim inventoryId As New DataGridViewTextBoxColumn
        With inventoryId
            .ReadOnly = True
            .HeaderText = "Model Number"
            .Name = "modelNum"
            .Width = 150
        End With

        Dim numPur As New DataGridViewTextBoxColumn
        With numPur
            .ReadOnly = True
            .HeaderText = "Quantity"
            .Name = "quantity"
            .Width = 150
        End With

        Dim amount As New DataGridViewTextBoxColumn
        With amount
            .ReadOnly = True
            .HeaderText = "Order Amount"
            .Name = "orderAmount"
            .Width = 150
        End With

        Dim checkColumn As New DataGridViewCheckBoxColumn
        With checkColumn
            .HeaderText = "Update Quantity"
            .Name = "checkColumn"
            .Width = 150
        End With

        Dim buttons As New DataGridViewButtonColumn
        With buttons
            .ReadOnly = False
            .HeaderText = "Remove Item"
            .UseColumnTextForButtonValue = True
            .Text = "Double Click To Remove"
            .Name = "Remove Item"
            .Width = 200
        End With

        If gridFlag = False Then
            DataGridView1.Columns.Insert(0, equipmentName)
            DataGridView1.Columns.Insert(1, inventoryId)
            DataGridView1.Columns.Insert(2, numPur)
            DataGridView1.Columns.Insert(3, amount)
            DataGridView1.Columns.Insert(4, buttons)
            DataGridView1.Columns.Insert(5, checkColumn)
            gridFlag = True
        End If

        For i As Integer = 0 To equipName.Length - 1
            DataGridView1.Rows.Add(New String() _
               {equipName(i), invenId(i), numOrder(i), FormatCurrency(orderAmount(i))})
        Next

        DataGridView1.Columns("equipmentName").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns("modelNum").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns("quantity").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns("orderAmount").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    '*************************************************************************************************
    'Purpose     : To monitor a double click on the datagridview and remove products.                *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        For x As Integer = 0 To equipName.Length - 1
            If e.RowIndex = x And e.ColumnIndex = 4 Then
                removeArrayItems(e)
            End If
        Next

        loadArrays()
        loadDataGrid()
        txtbxTotal.Text = FormatCurrency(getTotal().ToString)
    End Sub

    '*************************************************************************************************
    'Purpose     : To get the checkbox selection and call the uncheck function.                      *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.ColumnIndex = DataGridView1.Columns("checkColumn").Index Then
            If checkboxSelection = e.RowIndex Then
                checkboxSelection = -1
            Else
                DataGridViewCheckBoxColumn_Uncheck()
                checkboxSelection = e.RowIndex
                loadComboBox()
            End If
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To uncheck the old checked box selection.                                         *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub DataGridViewCheckBoxColumn_Uncheck()
        For Each row As DataGridViewRow In DataGridView1.Rows
            Dim cell As DataGridViewCheckBoxCell = CType(row.Cells("checkColumn"), DataGridViewCheckBoxCell)
            cell.Value = cell.FalseValue
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To load the quantities combo box.                                                 *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub loadComboBox()
        cmbbxQuantity.Items.Clear()
        cmbbxQuantity.ResetText()

        Dim numOnHand As Integer
        Dim equipmentName As String = DataGridView1.Rows(checkBoxSelection).Cells(0).Value.ToString

        If equipmentName = "Treadmill" Then
            numOnHand = CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
        ElseIf equipmentName = "Elliptical" Then
            numOnHand = CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
        ElseIf equipmentName = "Rowing Machine" Then
            numOnHand = CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
        ElseIf equipmentName = "Stationary Bike" Then
            numOnHand = CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
        ElseIf equipmentName = "StairMaster" Then
            numOnHand = CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
        ElseIf equipmentName = "TreadClimber" Then
            numOnHand = CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
        End If

        For x As Integer = 1 To numOnHand - 1
            cmbbxQuantity.Items.Add(x)
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To update module quantities and update listarrays.                                *
    'Passed In   : e                                                                                 *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub removeArrayItems(e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Update the database With the new Quantity
        updateModuleQuantities(CInt(DataGridView1.Rows(e.RowIndex).Cells(2).Value), CStr(DataGridView1.Rows(e.RowIndex).Cells(0).Value))

        Dim index As Integer = equipment_name.IndexOf(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        equipment_name.Remove(DataGridView1.Rows(e.RowIndex).Cells(0).Value)
        inven_id.Remove(DataGridView1.Rows(e.RowIndex).Cells(1).Value)
        number_ordered.RemoveAt(index)
        date_ordered.RemoveAt(index)
        amount_of_order.RemoveAt(index)
    End Sub

    '*************************************************************************************************
    'Purpose     : To update the module quantities.                                                  *
    'Passed In   : num, equipmentName                                                                *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub updateModuleQuantities(num As Integer, equipmentName As String)
        If equipmentName = "Treadmill" Then
            treadmillQuantity += num
        ElseIf equipmentName = "Elliptical" Then
            ellipticalQuantity += num
        ElseIf equipmentName = "Rowing Machine" Then
            rowQuantity += num
        ElseIf equipmentName = "Stationary Bike" Then
            bikeQuantity += num
        ElseIf equipmentName = "StairMaster" Then
            stairQuantity += num
        ElseIf equipmentName = "TreadClimber" Then
            climberQuantity += num
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To update the database table transactions.                                        *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub updateDatabaseTransactions()
        For x As Integer = 0 To DataGridView1.RowCount - 1
            connect.Open()
            sql = "INSERT INTO transactions " &
                  "(cust_id, inven_id, number_ordered, date_ordered, [Amount of Order]) " &
                  "VALUES (@CUSTID, @MODELNUM, @NUMORDERED, @DATE, @AMOUNT)"

            Dim index As Integer = equipment_name.IndexOf(DataGridView1.Rows(x).Cells(0).Value)
            command = New OleDbCommand(sql, connect)

            command.Parameters.AddWithValue("@CUSTID", custId)
            command.Parameters.AddWithValue("@MODELNUM", DataGridView1.Rows(x).Cells(1).Value)
            command.Parameters.AddWithValue("@NUMORDERED", DataGridView1.Rows(x).Cells(2).Value)
            command.Parameters.AddWithValue("@DATE", date_ordered(index))
            command.Parameters.AddWithValue("@AMOUNT", DataGridView1.Rows(x).Cells(3).Value)

            Try
                Dim count As Integer = command.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error updating file TRANSACTIONS")
            End Try

            connect.Close()
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To update the database products table quantity.                                   *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub updateDatabaseQuantity()
        For x As Integer = 0 To DataGridView1.RowCount - 1
            connect.Open()

            Dim equipmentName As String = DataGridView1.Rows(x).Cells(0).Value.ToString
            sql = "UPDATE inventory SET num_on_hand = @newValue WHERE [Equipment Name] = @EQUIP"

            Dim newVal As Integer

            If equipmentName = "Treadmill" Then
                newVal = treadmillQuantity
            ElseIf equipmentName = "Elliptical" Then
                newVal = ellipticalQuantity
            ElseIf equipmentName = "Rowing Machine" Then
                newVal = rowQuantity
            ElseIf equipmentName = "Stationary Bike" Then
                newVal = bikeQuantity
            ElseIf equipmentName = "StairMaster" Then
                newVal = stairQuantity
            ElseIf equipmentName = "TreadClimber" Then
                newVal = climberQuantity
            End If

            command = New OleDbCommand(sql, connect)
            command.Parameters.AddWithValue("newValue", newVal)
            command.Parameters.AddWithValue("@EQUIP", equipmentName)

            Try
                Dim count As Integer = command.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error updating file")
            End Try

            connect.Close()
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To update the database customer due amount in the customers table.                *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub updateCustomerAmount()
        connect.Open()
        Dim oldAmount As Double

        sql = "SELECT [Amount Due] FROM Customer WHERE cust_id = @ID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@ID", custId)

        Dim reader As OleDbDataReader = command.ExecuteReader()

        Try
            reader.Read()
        Catch ex As Exception
            MessageBox.Show("Error reading File")
        End Try

        If reader.HasRows Then
            oldAmount = CDbl(reader("Amount Due"))
        End If

        Dim newAmount = oldAmount + CDbl(txtbxTotal.Text)

        sql = "UPDATE Customer SET [Amount Due] = @DUE WHERE cust_id = @ID"

        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@DUE", newAmount)
        command.Parameters.AddWithValue("@ID", custId)

        Try
            Dim count As Integer = command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error updating")
        End Try
        connect.Close()
    End Sub

    '*************************************************************************************************
    'Purpose     : To load the local arrays from the module listarrays.                              *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub loadArrays()
        Erase equipName
        Erase invenId
        Erase numOrder
        Erase dateOrder
        Erase orderAmount

        equipName = CType(equipment_name.ToArray(GetType(String)), String())
        invenId = CType(inven_id.ToArray(GetType(String)), String())
        numOrder = CType(number_ordered.ToArray(GetType(String)), String())
        dateOrder = CType(date_ordered.ToArray(GetType(String)), String())
        orderAmount = CType(amount_of_order.ToArray(GetType(String)), String())
    End Sub

    '*************************************************************************************************
    'Purpose     : To cancel the order and add the quantities back to the module quantities.         *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim intUserRespones As Integer
        intUserRespones = MsgBox("Are you sure you would like to cancel the order?",
                                 MsgBoxStyle.YesNo)
        If intUserRespones = 6 Then

            For x As Integer = 0 To DataGridView1.RowCount - 1
                'Update the Module Quantities
                updateModuleQuantities(CInt(DataGridView1.Rows(x).Cells(2).Value), CStr(DataGridView1.Rows(x).Cells(0).Value))
            Next
            clearArrayList()
            WelcomeForm.Show()
            Me.Dispose()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To remove the items from the listarray.                                           *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub clearArrayList()
        For x As Integer = 0 To DataGridView1.RowCount - 1
            Dim index As Integer = equipment_name.IndexOf(DataGridView1.Rows(x).Cells(0).Value)
            equipment_name.Remove(DataGridView1.Rows(x).Cells(0).Value)
            inven_id.Remove(DataGridView1.Rows(x).Cells(1).Value)
            number_ordered.RemoveAt(index)
            date_ordered.RemoveAt(index)
            amount_of_order.RemoveAt(index)
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To load another form and dispose this one.                                        *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AccountTransactions.Show()
        Me.Dispose()
    End Sub

    '*************************************************************************************************
    'Purpose     : To submit the order to the database and load another form.                        *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim intUserRespones As Integer
        intUserRespones = MsgBox("Are you sure you would like to order these products?",
                                 MsgBoxStyle.YesNo)
        If intUserRespones = 6 Then
            updateDatabaseTransactions()
            updateDatabaseQuantity()
            updateCustomerAmount()
            clearArrayList()
            AccountTransactions.Show()
            Me.Dispose()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To update the quantities of the orders.                                           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If checkBoxSelection <> -1 Then
            If cmbbxQuantity.SelectedIndex <> -1 Then
                Dim equipmentName As String = DataGridView1.Rows(checkBoxSelection).Cells(0).Value.ToString
                Dim price As Double = CDbl(DataGridView1.Rows(checkBoxSelection).Cells(3).Value) / CDbl(DataGridView1.Rows(checkBoxSelection).Cells(2).Value)
                Dim temp As Integer

                If equipmentName = "Treadmill" Then
                    treadmillQuantity += CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value) - CInt(cmbbxQuantity.Text)
                    temp = Array.IndexOf(equipName, DataGridView1.Rows(checkBoxSelection).Cells(0).Value)
                    number_ordered(temp) = cmbbxQuantity.Text
                ElseIf equipmentName = "Elliptical" Then
                    ellipticalQuantity += CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value) - CInt(cmbbxQuantity.Text)
                    temp = Array.IndexOf(equipName, DataGridView1.Rows(checkBoxSelection).Cells(0).Value)
                    number_ordered(temp) = cmbbxQuantity.Text
                ElseIf equipmentName = "Rowing Machine" Then
                    rowQuantity += CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value) - CInt(cmbbxQuantity.Text)
                    temp = Array.IndexOf(equipName, DataGridView1.Rows(checkBoxSelection).Cells(0).Value)
                    number_ordered(temp) = cmbbxQuantity.Text
                ElseIf equipmentName = "Stationary Bike" Then
                    bikeQuantity += CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value) - CInt(cmbbxQuantity.Text)
                    temp = Array.IndexOf(equipName, DataGridView1.Rows(checkBoxSelection).Cells(0).Value)
                    number_ordered(temp) = cmbbxQuantity.Text
                ElseIf equipmentName = "StairMaster" Then
                    stairQuantity += CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value) - CInt(cmbbxQuantity.Text)
                    temp = Array.IndexOf(equipName, DataGridView1.Rows(checkBoxSelection).Cells(0).Value)
                    number_ordered(temp) = cmbbxQuantity.Text
                ElseIf equipmentName = "TreadClimber" Then
                    climberQuantity += CInt(DataGridView1.Rows(checkBoxSelection).Cells(2).Value) - CInt(cmbbxQuantity.Text)
                    temp = Array.IndexOf(equipName, DataGridView1.Rows(checkBoxSelection).Cells(0).Value)
                    number_ordered(temp) = cmbbxQuantity.Text
                End If

                amount_of_order(temp) = CStr(price * CDbl(cmbbxQuantity.Text))
                loadArrays()
                loadDataGrid()
                txtbxTotal.Text = FormatCurrency(getTotal().ToString)
            Else
                MessageBox.Show("You must select a quantity")
            End If
        Else
            MessageBox.Show("You must select a product")
        End If
    End Sub
End Class