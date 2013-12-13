'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the login if form. If the user attempts to login more than 3 unsuccesfully the program is killed.                     *
'**********************************************************************************************************************************************
Imports System.Data.OleDb

Public Class LoginForm

    Dim connect As New OleDbConnection("provider = Microsoft.ace.OLEDB.12.0;Data Source = phase2db.accdb")
    Dim command As New OleDbCommand()
    Dim sql As String
    Dim ct As Integer
    Private Sub btnBackLoginForm_Click(sender As Object, e As EventArgs) Handles btnBackLoginForm.Click
        Me.Hide()
        WelcomeForm.Show()
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form.                                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)
        lblLogin.Left = CInt(Me.Width / 3.8)
        lblLogin.Top = CInt(Me.Height / 7)

        lblID.Top = CInt(Me.Height / 2.5)
        lblID.Left = CInt(Me.Width / 4)
        txtbxID.Top = CInt(Me.Height / 2.5)
        txtbxID.Left = CInt(Me.Width / 2.4)

        lblPin.Top = CInt(Me.Height / 2.2)
        lblPin.Left = CInt(Me.Width / 3.6)
        txtbxPin.Top = CInt(Me.Height / 2.2)
        txtbxPin.Left = CInt(Me.Width / 2.4)
    End Sub

    '*************************************************************************************************
    'Purpose     : To login the user into his/her account or add to the login attempts.              *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnSubmitLoginForm_Click(sender As Object, e As EventArgs) Handles btnSubmitLoginForm.Click
        connect.Open()
        sql = "SELECT * FROM customer WHERE cust_id = @ID AND cust_pin = @PIN"

        command = New OleDbCommand(sql, connect)
        command.Parameters.AddWithValue("@ID", txtbxID.Text)
        command.Parameters.AddWithValue("@PIN", txtbxPin.Text)

        Dim reader As OleDbDataReader = command.ExecuteReader()

        Try
            reader.Read()
        Catch ex As Exception
            MessageBox.Show("Error reading File")
        End Try

        If reader.HasRows Then
            custId = CInt(txtbxID.Text)
            custPin = CInt(txtbxPin.Text)
            ct = 0
            Me.Hide()
            AccountMenu.Show()
        Else
            MessageBox.Show("Customer not found")
            ct = ct + 1
        End If

        connect.Close()
    End Sub

    '*************************************************************************************************
    'Purpose     : To check login attempts if its greater than 3 the program is destroyed.           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub LoginForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If ct > 2 Then
            MessageBox.Show("Sorry you have excited the login attempts")
            WelcomeForm.Dispose()
        End If
    End Sub
End Class