'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the more information form. The user is allowed to fill out a form with name, address, phone, and comments. All user   *
'            :  entered information is validated. Then if the user selects the submit button and all the form has been completely filled out  *
'            :  the information is wrote to an xml file.                                                                                      *         
'**********************************************************************************************************************************************
Imports System.Xml
Public Class MoreInfoForm

    Public validfirst As Boolean = False
    Public validlast As Boolean = False
    Public validCity As Boolean = False
    Public validZip As Boolean = False
    Public validService As Boolean = False
    Public validState As Boolean = False
    Public validPhone As Boolean = False
    Public validAddress As Boolean = False

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub MoreInfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)
        lblRequest.Top = CInt(Me.Height / 8)
        lblRequest.Left = CInt(Me.Width / 4)
        pnlForm.Top = CInt(Me.Height / 5.1)
        pnlForm.Left = CInt(Me.Width / 3.5)
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make general store information form visiable.               *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnGeneralStoreInfo_Click(sender As Object, e As EventArgs) Handles btnGeneralStoreInfo.Click
        GeneralStoreInfo.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To write the user information to an xml file, only if the form is filled out      *
    '            : completely and correctly.                                                         *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If validfirst = True And validlast = True And validCity = True And validZip = True And validAddress = True And validService = True And validState = True And validPhone = True Then
            ErrorProvider1.Clear()

            If Not IO.File.Exists("POSSCUST.XML") Then

                Const path As String = "POSSCUST.XML"
                Dim settings As New XmlWriterSettings
                settings.Indent = True
                settings.IndentChars = ("    ")

                Dim xmlOut As XmlWriter = XmlWriter.Create(path, settings)

                'Writing the start of the document
                xmlOut.WriteStartDocument()
                xmlOut.WriteStartElement("Customers")

                xmlOut.WriteStartElement("Customer")
                xmlOut.WriteElementString("FirstName", txtFirstName.Text)
                xmlOut.WriteElementString("LastName", txtLastName.Text)
                xmlOut.WriteElementString("Address", txtAddress.Text)
                xmlOut.WriteElementString("City", txtCity.Text)
                xmlOut.WriteElementString("State", cmboxState.Text)
                xmlOut.WriteElementString("Zip", txtZip.Text)
                xmlOut.WriteElementString("PhoneNumber", txtPhone.Text)
                xmlOut.WriteElementString("Service", cmboxService.Text)
                xmlOut.WriteElementString("Comments", rtxtComments.Text)

                xmlOut.WriteEndElement()
                xmlOut.Close()
                MessageBox.Show("Record wrote to new file.")
            Else
                Dim xmlDoc As New XmlDocument()
                xmlDoc.Load("POSSCUST.XML")
                Dim root As XmlNode = xmlDoc.DocumentElement

                Dim elem As XmlElement = xmlDoc.CreateElement("Customer")
                Dim firstName As XmlElement = xmlDoc.CreateElement("FirstName")
                Dim lastName As XmlElement = xmlDoc.CreateElement("LastName")
                Dim address As XmlElement = xmlDoc.CreateElement("Address")
                Dim city As XmlElement = xmlDoc.CreateElement("City")
                Dim state As XmlElement = xmlDoc.CreateElement("State")
                Dim zip As XmlElement = xmlDoc.CreateElement("Zip")
                Dim phone As XmlElement = xmlDoc.CreateElement("PhoneNumber")
                Dim service As XmlElement = xmlDoc.CreateElement("Service")
                Dim comments As XmlElement = xmlDoc.CreateElement("Comments")

                firstName.InnerText = txtFirstName.Text
                lastName.InnerText = txtLastName.Text
                address.InnerText = txtAddress.Text
                city.InnerText = txtCity.Text
                state.InnerText = cmboxState.Text
                zip.InnerText = txtZip.Text
                phone.InnerText = txtPhone.Text
                service.InnerText = cmboxService.Text
                comments.InnerText = rtxtComments.Text

                root.AppendChild(elem)
                elem.AppendChild(firstName)
                elem.AppendChild(lastName)
                elem.AppendChild(address)
                elem.AppendChild(city)
                elem.AppendChild(state)
                elem.AppendChild(zip)
                elem.AppendChild(phone)
                elem.AppendChild(service)
                elem.AppendChild(comments)

                xmlDoc.Save("POSSCUST.XML")
                MessageBox.Show("Record wrote to EXISTING file.")
            End If
        Else
            MessageBox.Show("You Must Fill out the form completely.")
            ErrorProvider1.SetError(btnSubmit, "You must fill out form completely.")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the first name entry.                                                 *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtFirstName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtFirstName.Validating
        If txtFirstName.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtFirstName, "You must enter a name.")
            MessageBox.Show("You must enter a First Name.")
        Else
            ErrorProvider1.Clear()
            validfirst = True
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the last name entry.                                                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtLastName_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtLastName.Validating
        If txtLastName.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtLastName, "You must enter a name.")
            MessageBox.Show("You must enter a Last name.")
        Else
            validlast = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the city      entry.                                                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtCity_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtCity.Validating
        If txtCity.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtCity, "You must enter a city.")
            MessageBox.Show("You must enter a city.")
        Else
            validCity = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the address entry.                                                    *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtAddress_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAddress.Validating
        If txtAddress.Text.Length = 0 Then
            e.Cancel = True
            ErrorProvider1.SetError(txtAddress, "You must enter a address.")
            MessageBox.Show("You must enter an address.")
        Else
            validAddress = True
            ErrorProvider1.Clear()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the zip code entry.                                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtZip_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtZip.Validating
        If IsNumeric(txtZip.Text) Then
            If txtZip.Text.Length = 5 Then
                ErrorProvider1.Clear()
                e.Cancel = False
                validZip = True
            Else
                e.Cancel = True
                ErrorProvider1.SetError(txtZip, "Must be a five digit Number.")
                MessageBox.Show("Zip Code must be a five digit number.")
            End If
        Else
            e.Cancel = True
            ErrorProvider1.SetError(txtZip, "Must be a numeric number.")
            MessageBox.Show("You must enter a numeric number.")
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the phone entry.                                                      *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub txtPhone_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPhone.Validating
        If IsNumeric(txtPhone.Text) Then
            If txtPhone.Text.Length = 10 Then
                ErrorProvider1.Clear()
                e.Cancel = False
                validPhone = True
            Else
                e.Cancel = True
                ErrorProvider1.SetError(txtPhone, "Must be a ten digit Number.")
                MessageBox.Show("Patient number must be a ten digit number.")
            End If
        Else
            e.Cancel = True
            ErrorProvider1.SetError(txtPhone, "Must be a numeric number.")
            MessageBox.Show("You must enter a numeric number.")
        End If
    End Sub

    '****************************************************************************************************
    'Purpose     : To monitor the state of the service combo box and set a boolean if selection is made.*
    'Passed In   : sender, e                                                                            * 
    'Returned    : Nothing                                                                              *
    '****************************************************************************************************
    Private Sub cmboxService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxService.SelectedIndexChanged
        validService = True
    End Sub

    '*************************************************************************************************
    'Purpose     : To monitor the state combo box and set a boolean if selection is made.            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub cmboxState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxState.SelectedIndexChanged
        validState = True
    End Sub

    '*************************************************************************************************
    'Purpose     : To clear the instructions if the user enters a comment.                           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub rtxtComments_GotFocus(sender As Object, e As EventArgs) Handles rtxtComments.GotFocus
        rtxtComments.Text = ""
    End Sub

    '*************************************************************************************************
    'Purpose     : To validate the length of the comments entry.                                     *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub rtxtComments_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles rtxtComments.Validating
        If rtxtComments.Text.Length > 250 Then
            ErrorProvider1.SetError(rtxtComments, "Comments must be less than 250 characters")
            MessageBox.Show("Comments must be less than 250 characters.")
            e.Cancel = True
        Else
            e.Cancel = False
            ErrorProvider1.Clear()
        End If
    End Sub
End Class