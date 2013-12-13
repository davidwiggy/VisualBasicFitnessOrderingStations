'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the accounts form. This form allows the user to select retail or business account using a combo box. Then once a      *
'            :  selection is made a brief description of that type of account is placed on the screen.                                        *     
'**********************************************************************************************************************************************
Public Class AccountsForm

    Public retail As String = "A retail account is personal account that is more suited for an individual or a family. Some benefits of a retail " +
                              "account are a 5% discount when you have purchased more than $500 worth of goods. A retail account has a maximum " +
                              "credit limit up to %2,500. "
    Public business As String = "A business account is more suited for a business that is going to purchase more items than a family or individual. " +
                                "Some of the benefits of a business account are a 1% to 5% discount depending upon your status. Business accounts " +
                                "have a maximum credit limit up to $5,000."

    '*************************************************************************************************
    'Purpose     : To Hide this form and make general store form visible.                            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGeneralStore.Click
        GeneralStoreInfo.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub AccountsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)
        lblAccounts.Top = CInt(Me.Height / 6)
        rtxtbox1.Top = CInt(Me.Height / 2.5)
        lblAccountSelection.Top = CInt(Me.Height / 4)
        lblEligible.Top = CInt(Me.Height / 3)
        cmbAccountSelection.Top = CInt(Me.Height / 3.5)
    End Sub

    '*************************************************************************************************
    'Purpose     : To set contain, based on user selection, to the rich text box.                    *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub cmbAccountSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccountSelection.SelectedIndexChanged
        If cmbAccountSelection.Text = "Retail Account" Then
            rtxtbox1.Text = retail
        Else
            rtxtbox1.Text = business
        End If
    End Sub
End Class