'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This form is the accounts transactions form. The user can add products to the shopping cart.                                  *
'**********************************************************************************************************************************************
Imports System.Data.OleDb

Public Class AccountTransactions

    Dim connect As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = phase2db.accdb")
    Dim checkboxSelection As Integer = -1
    Dim command As New OleDbCommand()
    Dim sql As String

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form and call functions to load grid.  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub AccountTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 1.95)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 2)
        pnbtnHolder.Left = CInt((Me.Width - pnbtnHolder.Width) / 2)
        pnbtnHolder.Top = CInt((Me.Height - pnbtnHolder.Height) / 1.15)

        lblTransactions.Top = CInt(Me.Height / 8)
        lblTransactions.Left = CInt(Me.Width / 3)

        setQuantities()
        datagridbuild()
        customerRating = getCustRating()
    End Sub

    '*************************************************************************************************
    'Purpose     : To load the quantities combo box.                                                 *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub loadComboBox()
        cmbQuantities.Items.Clear()
        cmbQuantities.ResetText()

        Dim numOnHand As Integer
        Dim equipmentName As String = getEquipmentName()

        If equipmentName = "Treadmill" Then
            numOnHand = treadmillQuantity
        ElseIf equipmentName = "Elliptical" Then
            numOnHand = ellipticalQuantity
        ElseIf equipmentName = "Rowing Machine" Then
            numOnHand = rowQuantity
        ElseIf equipmentName = "Stationary Bike" Then
            numOnHand = bikeQuantity
        ElseIf equipmentName = "StairMaster" Then
            numOnHand = stairQuantity
        ElseIf equipmentName = "TreadClimber" Then
            numOnHand = climberQuantity
        End If

        For x As Integer = 1 To numOnHand
            cmbQuantities.Items.Add(x)
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To build the dataGridView.                                                        *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub datagridbuild()
        connect.Open()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)

        Dim da As New OleDbDataAdapter("Select [Model Number], [Equipment Name], Price FROM inventory", connect)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns("Model Number").Width = 175
        DataGridView1.Columns("Model Number").ReadOnly = True
        DataGridView1.Columns("Equipment Name").Width = 175
        DataGridView1.Columns("Equipment Name").ReadOnly = True
        DataGridView1.Columns("Price").Width = 100
        DataGridView1.Columns("Price").ReadOnly = True
        DataGridView1.Columns("Price").DefaultCellStyle.Format = "c"

        Dim checkColumn As New DataGridViewCheckBoxColumn
        With checkColumn
            .HeaderText = "Add to Cart"
            .Name = "checkColumn"
            .Width = 125
        End With

        Dim buttons As New DataGridViewButtonColumn
        With buttons
            .HeaderText = "More Information"
            .UseColumnTextForButtonValue = False
            .Name = "moreInfo"
            .Width = 150
        End With

        DataGridView1.Columns.Insert(3, buttons)
        DataGridView1.Rows(0).Cells(3).Value = "Treadmill Information"
        DataGridView1.Rows(1).Cells(3).Value = "StairMaster Information"
        DataGridView1.Rows(2).Cells(3).Value = "Elliptical Information"
        DataGridView1.Rows(3).Cells(3).Value = "Bike Information"
        DataGridView1.Rows(4).Cells(3).Value = "Rowing Information"
        DataGridView1.Rows(5).Cells(3).Value = "TreadClimber Information"
        DataGridView1.Columns.Insert(4, checkColumn)

        DataGridView1.Columns("Model Number").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns("Equipment Name").SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns("Price").SortMode = DataGridViewColumnSortMode.NotSortable

        connect.Close()
    End Sub

    '*************************************************************************************************
    'Purpose     : To get the name of the equipment that has been selected by the checkbox.          *
    'Passed In   : Nothing                                                                           *
    'Returned    : The name of the equipment selection.                                              *
    '*************************************************************************************************
    Private Function getEquipmentName() As String
        Dim name As String
        If checkboxSelection = 0 Then
            name = "Treadmill"
        ElseIf checkboxSelection = 1 Then
            name = "StairMaster"
        ElseIf checkboxSelection = 2 Then
            name = "Elliptical"
        ElseIf checkboxSelection = 3 Then
            name = "Stationary Bike"
        ElseIf checkboxSelection = 4 Then
            name = "Rowing Machine"
        Else
            name = "TreadClimber"
        End If
        Return name
    End Function

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
    'Purpose     : To call the product info form and set the moreinfo variable.                      *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Ignore clicks that are not on button cells. 
        moreInfo = ""
        If e.RowIndex = 0 And e.ColumnIndex = 3 Then
            moreInfo = "TreadMill"
        ElseIf e.RowIndex = 1 And e.ColumnIndex = 3 Then
            moreInfo = "StairMaster"
        ElseIf e.RowIndex = 2 And e.ColumnIndex = 3 Then
            moreInfo = "Elliptical"
        ElseIf e.RowIndex = 3 And e.ColumnIndex = 3 Then
            moreInfo = "Stationary Bike"
        ElseIf e.RowIndex = 4 And e.ColumnIndex = 3 Then
            moreInfo = "Rowing Machine"
        ElseIf e.RowIndex = 5 And e.ColumnIndex = 3 Then
            moreInfo = "TreadClimber"
        End If

        If String.IsNullOrEmpty(moreInfo) Then

        Else
            ProductInfo.Show()
            Me.Hide()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To add the selected products to the module listarray.                             *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If checkboxSelection = -1 Then
            MessageBox.Show("Sorry you must pick a product for purchasing.")
        ElseIf cmbQuantities.SelectedItem Is Nothing Then
            MessageBox.Show("Sorry you must pick a quantity for purchasing.")
        Else
            If equipment_name.IndexOf(DataGridView1.Rows(checkboxSelection).Cells(1).Value) = -1 Then ' Looking for match
                equipment_name.Add(DataGridView1.Rows(checkboxSelection).Cells(1).Value)
                inven_id.Add(DataGridView1.Rows(checkboxSelection).Cells(0).Value)
                number_ordered.Add(cmbQuantities.Text)
                updateQuantities()
                Dim todaysdate As String = String.Format("{0:MM/dd/yyyy}", DateTime.Now)
                date_ordered.Add(todaysdate)
                amount_of_order.Add(getTotal())
                MessageBox.Show("Order added to shopping cart.")
                checkboxSelection = -1
            Else
                Dim index As Integer = equipment_name.IndexOf(DataGridView1.Rows(checkboxSelection).Cells(1).Value)
                Dim oldOrderedNum As Integer = CInt(number_ordered(index))
                Dim oldamountTotal As Double = CDbl(amount_of_order(index))
                Dim newAmount As String = CStr(CDbl(getTotal()) + oldamountTotal)

                number_ordered(index) = CStr(oldOrderedNum + CInt(cmbQuantities.Text))
                amount_of_order(index) = newAmount
                updateQuantities()

                MessageBox.Show("Order added to shopping cart.")
            End If
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To update the module quantities on the products.                                  *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub updateQuantities()
        Dim equipmentName As String = getEquipmentName()

        If equipmentName = "Treadmill" Then
            treadmillQuantity -= CInt(cmbQuantities.Text)
        ElseIf equipmentName = "Elliptical" Then
            ellipticalQuantity -= CInt(cmbQuantities.Text)
        ElseIf equipmentName = "Rowing Machine" Then
            rowQuantity -= CInt(cmbQuantities.Text)
        ElseIf equipmentName = "Stationary Bike" Then
            bikeQuantity -= CInt(cmbQuantities.Text)
        ElseIf equipmentName = "StairMaster" Then
            stairQuantity -= CInt(cmbQuantities.Text)
        ElseIf equipmentName = "TreadClimber" Then
            climberQuantity -= CInt(cmbQuantities.Text)
        End If

    End Sub

    '*************************************************************************************************
    'Purpose     : To set the module quantites from the database.                                    *
    'Passed In   : Nothing                                                                           *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub setQuantities()
        Dim name As String = "Treadmill"

        For x As Integer = 0 To 5
            connect.Open()
            sql = "SELECT num_on_hand FROM inventory WHERE [Equipment Name] = @EQUIPMENT"
            command = New OleDbCommand(sql, connect)
            Dim equipmentName As String = getEquipmentName()

            command.Parameters.AddWithValue("@EQUIPMENT", name)
            Dim reader As OleDbDataReader = command.ExecuteReader()

            Try
                reader.Read()
            Catch ex As Exception
                MessageBox.Show("Error reading File")
            End Try

            If reader.HasRows Then
                If x = 0 Then
                    treadmillQuantity = CInt(reader("num_on_hand"))
                    name = "Elliptical"
                ElseIf x = 1 Then
                    ellipticalQuantity = CInt(reader("num_on_hand"))
                    name = "Rowing Machine"
                ElseIf x = 2 Then
                    rowQuantity = CInt(reader("num_on_hand"))
                    name = "Stationary Bike"
                ElseIf x = 3 Then
                    bikeQuantity = CInt(reader("num_on_hand"))
                    name = "StairMaster"
                ElseIf x = 4 Then
                    stairQuantity = CInt(reader("num_on_hand"))
                    name = "TreadClimber"
                ElseIf x = 5 Then
                    climberQuantity = CInt(reader("num_on_hand"))
                End If
            End If
            connect.Close()
        Next
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the amount of the purchases                                                *
    'Passed In   : Nothing                                                                           *
    'Returned    : The amount of the purchase.                                                       *
    '*************************************************************************************************
    Private Function getTotal() As String
        Dim purchaseAmount As String = CStr(CDbl(DataGridView1.Rows(checkboxSelection).Cells(2).Value) * CDbl(cmbQuantities.Text))
        Return purchaseAmount
    End Function

    '*************************************************************************************************
    'Purpose     : To get the customer rating from the database for the discount.                    *
    'Passed In   : Nothing                                                                           *
    'Returned    : The customer rating.                                                              *
    '*************************************************************************************************
    Private Function getCustRating() As Integer
        connect.Open()
        sql = "SELECT cust_rating FROM Customer WHERE cust_id = @ID"
        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@ID", custId)
        Dim rating As Integer = 0
        Dim reader As OleDbDataReader = command.ExecuteReader()

        Try
            reader.Read()
        Catch ex As Exception
            MessageBox.Show("Error reading File")
        End Try

        If reader.HasRows Then
            rating = CInt(reader("cust_rating"))
        End If

        connect.Close()
        Return rating
    End Function

    '*************************************************************************************************
    'Purpose     : To show the next form and hide this one.                                          *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        AccountMenu.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To show the next form and hide this one.                                          *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnShoppingCart_Click(sender As Object, e As EventArgs) Handles btnShoppingCart.Click
        ShoppingCart.Show()
        Me.Hide()
    End Sub
End Class