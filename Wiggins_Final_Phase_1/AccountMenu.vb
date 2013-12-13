'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This form is the menu for user accounts. The user can go to account transactions, or account inquiry, or go back to the       *
'            :  welcome screen.                                                                                                               *
'**********************************************************************************************************************************************

Public Class AccountMenu

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub AccountMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)

        lblAccountMenu.Left = CInt(Me.Width / 2.8)
        lblAccountMenu.Top = CInt(Me.Height / 7)
    End Sub

    '*************************************************************************************************
    'Purpose     : A event listener that displays the next form and hides this one.                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnInquiry_Click(sender As Object, e As EventArgs) Handles btnInquiry.Click
        AccountInquiryForm.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : A event listener that displays the next form and hides this one.                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WelcomeForm.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : A event listener that displays the next form and hides this one.                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnTransAction_Click(sender As Object, e As EventArgs) Handles btnTransAction.Click
        AccountTransactions.Show()
        Me.Hide()
    End Sub
End Class