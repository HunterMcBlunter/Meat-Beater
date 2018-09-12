Public Class frmMeatBeater

    'Main Game Variables
    Dim mdMeat As Double = 0 'Records The value of the users Meat and the Currency for the game
    Dim mdBeatValue As Double = 1.0 'Records How much the user gets added to their currency when they click on the Meat

    Dim mdCostQS As Double = 15 'Records the Cost of the +0.1 every 10 seconds power up
    Dim mdCostRP As Double = 150 'Records the Cost of the +2 every second power up
    Dim mdCostMRS As Double = 1500 'Records the Cost of the x2 click value power up

    Dim mdOwnedQS As UShort = 0 'Records How many units of the +addition every 10 seconds power up that the user owns
    Dim mdOwnedRP As UShort = 0 'Records How many units of the +addition every second power up that the user owns
    Dim mdOwnedMRS As UShort = 0 'Records How many units of the x2 Click value power up that the user owns

    Dim mdBeatsRecorded As ULong = 0 'Records how many times the user has clicked on the Meat
    Dim mdPowerTugsRecorded As UInteger = 0 'Records how many power ups the user has purchased

    Dim md10Secs As Byte = 0 'Records the value for the 10 seconds counter
    Dim mdMinute As Byte = 0 'Records the value for the 1 Minute counter
    Dim md5MinCountdown As Short = 300 'Records the value for the 5 minute countdown

    Dim mdRoseyPalms As UShort = 0 'Records the value of the +addition every 10 seconds power up
    Dim mdQuickScratch As Double = 0 'Records the value of the +addition every second power up

    Dim mdAchList As New ArrayList() 'Records and holds achievements

    'Boss Battle Variables
    Dim md_HP_CarpalTunnel As UShort = 100 'Records the HP of the Boss
    Dim md_Attack_From_CarpalTunnel As UShort = 1 'Records how much the boss attacks for

    Dim md_Attack_From_Player As UShort = 1 'Records how much the player attacks for
    Dim md_Cost_Attack_From_Player As Double = 1.0 'Records how much it costs for the player to attack for

    Dim md_Cost_HL As Double = 50 'Records the cost of the +addition to users attack power up
    Dim md_Cost_HBN As Double = 0.5 'Records the cost of the -subtraction to the cost of the users attack power up

    Dim md_Owned_HL As UShort = 0 'Records how many units the user owns of the +addition to users attack power up
    Dim md_Owned_HBN As UShort = 0 'Records how many units the user owns of the -subtraction to the cost of the users attack power up

    Dim md_HandLotion As UShort = 0 'Records the Value of the  +addition to users attack power up
    Dim md_HomeBrandNapkins As Double = 0 'Records the value of the -subtraction to the cost of the users attack power up

    Private Sub frmMeatBeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'When the application starts up, and the main form loads

        Timer5Mins.Interval = 1000 '5 Minute Timer ticks once a Second

        Timer5Mins.Start() '5 Minute Timer begins

        TimerMinute.Interval = 1000 '1 Minute Timer ticks once a Second

        TimerMinute.Start() '1 Minute timer begins

        Timer10Secs.Interval = 1000 '10 Second Timer ticks once a Second

        Timer10Secs.Start() '10 second timer begins

        HideObjects.HidePowerTug(lblQSTitle, btnPowerTug_QS, lbl_QS_NumberOwned, lbl_QS_BPS, lblQSDesc)

        HideObjects.HidePowerTug(lblRPTitle, btnPowerTugs_RP, lbl_RP_NumberOwned, lbl_RP_BPS, lblRPDesc)

        HideObjects.HidePowerTug(lblMRSTitle, btnPowerTugs_MRS, lbl_MRS_NumberOwned, lbl_MRS_BPS, lblMRSDesc)

    End Sub

    Private Sub pbMeat_MouseDown(sender As Object, e As MouseEventArgs) Handles pbMeat.MouseDown  'When the user clicks on the meat

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        My.Computer.Audio.Play(My.Resources.beat_click,
                               AudioPlayMode.Background) 'Plays the beat_click.wav file from the resources of the program

        ExchangeCurrency.EarnCurrency(mdMeat, mdBeatValue)

        SetValue.RecordClicks(mdBeatsRecorded)

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        AchievementCheck.BeatAchievements(mdBeatsRecorded)

        UpToDateVars.GiveModuleChangedArray(mdAchList)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub btnPowerTug_QS_Click(sender As Object, e As EventArgs) Handles btnPowerTug_QS.Click  'When the user purchases the Quick Scratch (0.1 Beats every 10 Seconds) Upgrade

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        ExchangeCurrency.PurchasePowerTug(mdMeat, mdCostQS)

        SetValue.RecordPowerUps(mdPowerTugsRecorded)

        SetValue.TimerToZero(md10Secs)

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        AchievementCheck.PowerUpAchievements(mdPowerTugsRecorded)

        UpToDateVars.GiveModuleChangedArray(mdAchList)

        mdQuickScratch = mdQuickScratch + 0.1 'Increases the value of the +addition every 10 seconds power up by 0.1

        ExchangeCurrency.GainPowerTug(mdOwnedQS)

        ExchangeCurrency.PowerTugIncreaseCost(mdCostQS)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        lbl_QS_BPS.Text = "Beats Per 10 Seconds:" & mdQuickScratch 'Updates the beats per 10 second label to show the user how effective the power up currently is

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub btnPowerTugs_RP_Click(sender As Object, e As EventArgs) Handles btnPowerTugs_RP.Click 'When the user purchases the Rosey Palms (2 Beats per Second) Upgrade

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        ExchangeCurrency.PurchasePowerTug(mdMeat, mdCostRP)

        SetValue.RecordPowerUps(mdPowerTugsRecorded)

        SetValue.TimerToZero(mdMinute)

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        AchievementCheck.PowerUpAchievements(mdPowerTugsRecorded)

        UpToDateVars.GiveModuleChangedArray(mdAchList)

        mdRoseyPalms = mdRoseyPalms + 2 'Increases the value of the +addition every 1 second power up by 2

        ExchangeCurrency.GainPowerTug(mdOwnedRP)

        ExchangeCurrency.PowerTugIncreaseCost(mdCostRP)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        lbl_RP_BPS.Text = "Beats Per Second:" & mdRoseyPalms 'Updates the beats per second label to show the user how effective the power up currently is

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub btnPowerTugs_MRS_Click(sender As Object, e As EventArgs) Handles btnPowerTugs_MRS.Click 'When the user purchases the Mr. Socko (Doubles the Beat Value per Click) Upgrade

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        ExchangeCurrency.PurchasePowerTug(mdMeat, mdCostMRS)

        SetValue.RecordPowerUps(mdPowerTugsRecorded)

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        AchievementCheck.PowerUpAchievements(mdPowerTugsRecorded)

        UpToDateVars.GiveModuleChangedArray(mdAchList)

        mdBeatValue = mdBeatValue * 2 'Increases the amount that the user gets when they click on the meat by 2x

        ExchangeCurrency.GainPowerTug(mdOwnedMRS)

        ExchangeCurrency.PowerTugIncreaseCost(mdCostMRS)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub txtMeatCheat_TextChanged(sender As Object, e As EventArgs) Handles txtMeatCheat.TextChanged  'Whenever the cheat zone has been used

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        Try
            mdMeat = txtMeatCheat.Text 'Tries to convert whatever the user has entered into the value of the Meat Variable
            UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)
            UpdateScreen()
            CheckBeats()
        Catch
            txtMeatCheat.Text = 0 'If the program cannot convert whatever the user has entered, the program will set it back to 0
        End Try


    End Sub

    Private Sub CheckBeats() 'Checks how many Beats the user owns and compares them to the cost of power tugs

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        CurrencyCheck.PowerTugCost(mdMeat, mdCostQS, lblQSTitle, btnPowerTug_QS, lbl_QS_NumberOwned, lbl_QS_BPS, lblQSDesc)
        CurrencyCheck.PowerTugCost(mdMeat, mdCostRP, lblRPTitle, btnPowerTugs_RP, lbl_RP_NumberOwned, lbl_RP_BPS, lblRPDesc)
        CurrencyCheck.PowerTugCost(mdMeat, mdCostMRS, lblMRSTitle, btnPowerTugs_MRS, lbl_MRS_NumberOwned, lbl_MRS_BPS, lblMRSDesc)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

    End Sub

    Private Sub UpdateScreen() ' Updates the label with number of Beats
        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        ShowObjects.UpdateScreen(lblMeatBeaten.Text, mdMeat, lbl_QS_NumberOwned.Text, mdOwnedQS, btnPowerTug_QS.Text, mdCostQS)

        ShowObjects.UpdateScreen(lblMeatBeaten.Text, mdMeat, lbl_MRS_NumberOwned.Text, mdOwnedMRS, btnPowerTugs_MRS.Text, mdCostMRS)

        ShowObjects.UpdateScreen(lblMeatBeaten.Text, mdMeat, lbl_RP_NumberOwned.Text, mdOwnedRP, btnPowerTugs_RP.Text, mdCostRP)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

    End Sub

    Private Sub Timer5Mins_Tick(sender As Object, e As EventArgs) Handles Timer5Mins.Tick

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        md5MinCountdown = md5MinCountdown - 1 'Counts down from 300 in increments of 1 per second, to represent a 5 minute timer

        lbl_Timer_Carpal.Text = md5MinCountdown 'Updates the 5 minute countdown label with whatever is left every second

        AchievementCheck.PowerUpAchievements(mdPowerTugsRecorded)

        AchievementCheck.BeatAchievements(mdBeatsRecorded)

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpToDateVars.GiveModuleChangedArray(mdAchList)

        If md5MinCountdown = 0 Then 'If the countdown reaches 0

            md5MinCountdown = 300 'Timer goes back to 5 minutes

            UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

            lbl_Timer_Carpal.Text = md5MinCountdown 'Timer redisplays 5 minutes

            Timer10Secs.Stop() '10 Second Timer Stops

            TimerMinute.Stop() '1 Minute Timer Stops

            Timer5Mins.Stop() '5 Minute Timer Stops

            MessageBox.Show("You've been beating your meat too much lately, now you must face the wrath of Carpal Tunnel", "Stop beating for just a minute son", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Me.Hide() 'Main form is hidden in the background

            frmCarpalTunnelBossBattle.Show() 'Boss Battle Form appears

        End If

    End Sub

    Private Sub TimerMinute_Tick(sender As Object, e As EventArgs) Handles TimerMinute.Tick 'To keep track of and update Per Second power tugs

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        mdMinute = mdMinute + 1 'Counts minutes in increments of one
        ExchangeCurrency.EarnCurrency(mdMeat, mdRoseyPalms) 'Gives the user the +addition a second power up value as currency
        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)
        UpdateScreen()
        CheckBeats()

        If mdMinute = 60 Then
            mdMinute = 0 'Sets the counter back to 0 when it reaches 60
        End If

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

    End Sub

    Private Sub Timer10Secs_Tick(sender As Object, e As EventArgs) Handles Timer10Secs.Tick 'To keep track of and update Per 10 Second power tugs

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        md10Secs = md10Secs + 1 'Counts up to 10 seconds in increments of 1 a second

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        If md10Secs = 10 Then
            ExchangeCurrency.EarnCurrency(mdMeat, mdQuickScratch) 'Gives the user the +addition every 10 seconds power up value as currency
            UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)
            UpdateScreen()
            CheckBeats()
            md10Secs = 0 'Sets the counter back to 0
        End If

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click 'Takes all necessary variables and converts them into a save file

        SaveLoad.SaveFileAs(mdMeat, mdBeatValue, mdCostQS, mdOwnedQS, mdQuickScratch, mdCostRP, mdOwnedRP, mdRoseyPalms, mdCostMRS, mdOwnedMRS, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins, mdBeatsRecorded, mdPowerTugsRecorded)

    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click 'Takes values from save file and changes variables current values to match them

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        SaveLoad.LoadFile(mdMeat, mdBeatValue, mdCostQS, mdOwnedQS, mdQuickScratch, mdCostRP, mdOwnedRP, mdRoseyPalms, mdCostMRS, mdOwnedMRS, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins, mdBeatsRecorded, mdPowerTugsRecorded)

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub btnTutorial_Click(sender As Object, e As EventArgs) Handles btnTutorial.Click 'Opens up the tutorial menu

        frmTutorialMenu.Show()

    End Sub

End Class
