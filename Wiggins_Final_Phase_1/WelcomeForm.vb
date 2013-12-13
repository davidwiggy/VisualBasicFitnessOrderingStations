'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This program simulates automated ordering stations in a lobby of a store. The program contians six forms for user interaction.*
'            :  The program has a form for the store mission statement, a form for product information, a form for types of accounts offered  *
'            :  by the store, and a form for request of more information. This is the Welcome form, which contains buttons to end the program *
'            :  or access the general store information form.                                                                                 *
'**********************************************************************************************************************************************

Public Class WelcomeForm

    '*************************************************************************************************
    'Purpose     : To dispose of the program.                                                        *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim intUserRespones As Integer
        intUserRespones = MsgBox("Thank you for using Cardio Plus." & vbCrLf & "Are you sure you would like to exit the program?",
                                 MsgBoxStyle.YesNo)
        If intUserRespones = 6 Then
            Me.Dispose()
        End If

    End Sub

    Private Sub btnAccountAccess_Click(sender As Object, e As EventArgs) Handles btnAccountAccess.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)
        lblWelcome.Left = CInt(Me.Width / 4)
        lblWelcome.Top = CInt(Me.Height / 6)
    End Sub

    '*************************************************************************************************
    'Purpose     : A event listener that displays the next form and hides this one.                  *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        GeneralStoreInfo.Show()
        Me.Hide()
    End Sub
End Class
