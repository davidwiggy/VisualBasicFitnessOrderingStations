'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the Store Profile form. This form states the mission of the store. It only contains one button that takes the user    *
'            :  back to the general store information form.                                                                                   *
'**********************************************************************************************************************************************

Public Class StoreProfile

    Public statement As String = "Here at Cardio Plus our mission is to make your world a healthier and happier place. There have been numerous" +
                                 " studies that suggest working out leads to a happier life, well we didn’t need a study to know this we see every" +
                                 " day in the life’s of our customers. This is why we want your business, to help you get to a better place in your" +
                                 " life, to feel better, to look better, and to just be better. We carry six of the most innovative types of cardio" +
                                 " equipment that will help you achieve your goals.  So, help us make a positive impact in your live. We guarantee" +
                                 " you the best cardio equipment at the best prices possible. "

    '*************************************************************************************************
    'Purpose     : To hide this form and make general store info form show.                          *
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
    Private Sub StoreProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.2)
        lblMission.Top = CInt(Me.Height / 6)
        rtxtbox1.Top = CInt(Me.Height / 3)
        rtxtbox1.Text = statement
    End Sub
End Class