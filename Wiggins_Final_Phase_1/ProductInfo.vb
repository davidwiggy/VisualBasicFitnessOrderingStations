'**********************************************************************************************************************************************
'Program     :  Wiggins_Final_Phase_1                                                                                                         *
'Programmer  :  Timothy Wiggins                                                                                                               *
'Purpose     :  This is the product information form. This form allows the user to make a selection using a combo box. Then the image is set  *
'            :  and a description of that product is display as well.                                                                         *
'**********************************************************************************************************************************************

Public Class ProductInfo

    Public treadmill As String = "Treadmills are used for basic impact exercise running, jogging, and even walking. This model " +
                                 "treadmill offered has the ability to change speed, up to 12 mph, and increase or decrease " +
                                 "incline. This model also has a remote heart rate monitor."

    Public stairmaster As String = "Stairmasters are used to simulate climbing of steps/stairs. Stairmasters work directly against " +
                                   "gravity and use your body weight in the work out. This type of cardio workout is extremely " +
                                   "efficient and will greatly increase your cardiovascular condition in no time. However, this " +
                                   "type of workout is not for the faint of heart, but if you are looking for a work out that will " +
                                   "WORK you out then this is for you."

    Public elliptical As String = "Ellipticals are great non impact cardio machines. If you have bad knees or other bad joints then " +
                                  "this machine is for you. With this model elliptical there is virtually no impact on any of your " +
                                  "joints. What does this mean for you? Well, it means you get a great workout with little to no damage " +
                                  "on your joints. This machine allows you to increase or decrease resistances at the touch of a button, " +
                                  "giving you a greater or easier workout. However, we do suggest that you supplement your workout with " +
                                  "one of our other machines to get the needed impact that fosters bone growth."

    Public bike As String = "Stationary bikes are a great way for you good workout while sitting down. There are a ton of different models; " +
                            "however, our model is unique in the fact that it has a variety of settings that can meet the needs of any " +
                            "individual. You can adjust the sit height, resistance of the workout, and you move the sit forward or " +
                            "backwards to meet your needs, these are just a few of the things this model can do. Get a great workout all " +
                            "while riding a bike."

    Public rowing As String = "Rowing machines simulate the rowing motion of rowing a boat. This is one of the best cardiovascular workouts " +
                              "in the gym if used correctly. Our rowing machine is top notch. It comes with a full 10 year warranty. This " +
                              "model has been awarded the cardiovascular award by cardio plus for the best cardiovascular workout. When used " +
                              "with motivation this machine packs a punch. You get a full body workout when used correctly. "

    Public climber As String = "Treadclimber is another great way to shed the pounds. The treadclimber features independent treadmills, which " +
                               "is controlled by the strikes of your foot. We recommend treadclimber for more advanced workout enthusiast. "

    '*************************************************************************************************
    'Purpose     : To hide this form and make general store info visible.                            *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub btnGeneralStore_Click(sender As Object, e As EventArgs) Handles btnGeneralStore.Click
        GeneralStoreInfo.Show()
        Me.Dispose()
    End Sub

    Private Sub btnBackToTransactions_Click(sender As Object, e As EventArgs) Handles btnBackToTransactions.Click
        If custId = 0 Then
            LoginForm.Show()
            Me.Dispose()
        Else
            Me.Dispose()
            AccountTransactions.Show()
        End If
    End Sub

    '*************************************************************************************************
    'Purpose     : To set the position of the controls on the form                                   *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing, however, controls positions are set                                      *
    '*************************************************************************************************
    Private Sub ProductInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Left = CInt((Me.Width - Panel1.Width) / 2)
        Panel1.Top = CInt((Me.Height - Panel1.Height) / 1.05)
        lblProductInfo.Top = CInt(Me.Height / 10)
        lblProductSelection.Top = CInt(Me.Height / 5)
        cmbProducts.Top = CInt(Me.Height / 4.5)
        rtxtbox1.Top = CInt(Me.Height / 2.2)
        rtxtbox1.Left = CInt(Me.Width / 3.7)
        pbProduct.Top = CInt(Me.Height / 2.3)
        pbProduct.Left = CInt(Me.Width / 6)
        lblmodel.Top = CInt(Me.Height / 2.6)
        lblmodel.Left = CInt(Me.Width / 3.7)
        lblPrice.Top = CInt(Me.Height / 2.4)
        lblPrice.Left = CInt(Me.Width / 3.7)
        lblModelSetter.Top = CInt(Me.Height / 2.6)
        lblModelSetter.Left = CInt(Me.Width / 3.2)
        lblPriceSetter.Top = CInt(Me.Height / 2.4)
        lblPriceSetter.Left = CInt(Me.Width / 3.2)

        If moreInfo = "TreadMill" Then
            cmbProducts.Text = "Treadmill"
        ElseIf moreInfo = "StairMaster" Then
            cmbProducts.Text = "StairMaster"
        ElseIf moreInfo = "Elliptical" Then
            cmbProducts.Text = "Elliptical"
        ElseIf moreInfo = "Stationary Bike" Then
            cmbProducts.Text = "Stationary Bike"
        ElseIf moreInfo = "Rowing Machine" Then
            cmbProducts.Text = "Rowing Machine"
        ElseIf moreInfo = "TreadClimber" Then
            cmbProducts.Text = "TreadClimber"
        End If

    End Sub

    '*************************************************************************************************
    'Purpose     : To place the correct image on screen based on user selection. The richtext box is *
    '            : and a couple of labels are set as well.                                           *
    'Passed In   : sender, e                                                                         *
    'Returned    : Nothing                                                                           *
    '*************************************************************************************************
    Private Sub cmbProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProducts.SelectedIndexChanged

        If cmbProducts.Text = "Treadmill" Then
            pbProduct.Image = My.Resources.treadmill
            rtxtbox1.Text = treadmill
            lblModelSetter.Text = "TM3244"
            lblPriceSetter.Text = FormatCurrency("544.33")
        ElseIf cmbProducts.Text = "StairMaster" Then
            pbProduct.Image = My.Resources.stairmaster
            rtxtbox1.Text = stairmaster
            lblModelSetter.Text = "SM3332"
            lblPriceSetter.Text = FormatCurrency("444.99")
        ElseIf cmbProducts.Text = "Elliptical" Then
            pbProduct.Image = My.Resources.elliptical
            rtxtbox1.Text = elliptical
            lblModelSetter.Text = "EL9993"
            lblPriceSetter.Text = FormatCurrency("354.99")
        ElseIf cmbProducts.Text = "Stationary Bike" Then
            pbProduct.Image = My.Resources.stationarybike
            rtxtbox1.Text = bike
            lblModelSetter.Text = "SB5677"
            lblPriceSetter.Text = FormatCurrency("259.97")
        ElseIf cmbProducts.Text = "Rowing Machine" Then
            pbProduct.Image = My.Resources.rowing
            rtxtbox1.Text = rowing
            lblModelSetter.Text = "RM8843"
            lblPriceSetter.Text = FormatCurrency("456.99")
        ElseIf cmbProducts.Text = "Treadclimber" Then
            pbProduct.Image = My.Resources.treadclimber
            rtxtbox1.Text = climber
            lblModelSetter.Text = "TC1112"
            lblPriceSetter.Text = FormatCurrency("599.22")
        End If
    End Sub
End Class