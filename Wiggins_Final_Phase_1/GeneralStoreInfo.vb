'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the general store information form. This form allows the user access to all other forms in the program.               *
'**********************************************************************************************************************************************

Public Class GeneralStoreInfo

    '*************************************************************************************************
    'Purpose     : To hide this form and make store profile form visible.                            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        StoreProfile.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make welcome form visible.                                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnWelcome_Click(sender As Object, e As EventArgs) Handles btnWelcome.Click
        WelcomeForm.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub GeneralStoreInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)
        lblGeneralStore.Top = CInt(Me.Height / 6)
        lblGeneralStore.Left = CInt(Me.Width / 3) - 100
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make accounts form visible.                                 *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        AccountsForm.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make product info form visible.                             *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnProductInfo_Click(sender As Object, e As EventArgs) Handles btnProductInfo.Click
        ProductInfo.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To hide this form and make more info form visible.                                *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnRequest_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        MoreInfoForm.Show()
        Me.Hide()
    End Sub
End Class