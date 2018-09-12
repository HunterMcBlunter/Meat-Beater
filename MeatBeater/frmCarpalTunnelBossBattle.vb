Public Class frmCarpalTunnelBossBattle

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

    Private Sub frmCarpalTunnelBossBattle_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'When the boss battle form opens up

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        BossBattle.ShowHealthBars(lblMeatBeaten.Text, mdMeat, lblHP_CarpalTunnel.Text, md_HP_CarpalTunnel)

        TimerCarpalTunnel.Interval = 1000 'Sets the boss battle timer to count in 1 second increments

        TimerCarpalTunnel.Start() 'Starts the boss battle timer

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub pbCarpalTunnel_MouseDown(sender As Object, e As MouseEventArgs) Handles pbCarpalTunnel.MouseDown 'When the user clicks on the Boss

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        My.Computer.Audio.Play(My.Resources.beat_click,
                               AudioPlayMode.Background) 'Plays the beat_click.wav file from the resources

        Try
            BossBattle.AttackFromPlayer(mdMeat, md_Attack_From_Player, md_Cost_Attack_From_Player, md_HP_CarpalTunnel) 'Tries to attack the boss

        Catch 'If the Bosses health is at 0 or if the users attack deals enough to take the bosses health under 0

            TimerCarpalTunnel.Stop() 'Stops the boss battle timer
            MessageBox.Show("Well done son, you've managed to overcome Carpal Tunnel.

However, at the rate that you're beating your meat, expect him to come again very soon.", "You have Beaten Carpal Tunnel!", MessageBoxButtons.OK, MessageBoxIcon.Information)

            UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

            md_HP_CarpalTunnel = 100 'Resets the bosses health to 100

            UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

            Me.Close() 'Closes the boss battle form

            frmMeatBeater.Show() 'Reshows the main form

            frmMeatBeater.Timer10Secs.Enabled = True 'Begins the 10 second timer in the main form
            frmMeatBeater.TimerMinute.Enabled = True 'Begins the minute timer in the main form
            frmMeatBeater.Timer5Mins.Enabled = True 'Begins the 5 minute timer in the main form

        End Try

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpdateScreen()

        CheckBeats()

        If mdMeat <= 0 Then 'If the users health/currency is 0 or under

            TimerCarpalTunnel.Stop() 'Stops the boss battle timer

            MessageBox.Show("Unfortunately, Carpal Tunnel has completely taken over your hand and has destroyed any chance of you ever Beating your Meat again.

You did good son, but not good enough. It's Game Over.", "Game Over.", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Application.Exit() 'Game ends and the application closes

        End If

    End Sub

    Private Sub btnPowerTug_HBN_Click(sender As Object, e As EventArgs) Handles btnPowerTug_HBN.Click 'When the user clicks on to purchase the reduction of attack cost power up

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        ExchangeCurrency.PurchasePowerTug(mdMeat, md_Cost_HBN)

        ExchangeCurrency.GainPowerTug(md_Owned_HBN)

        md_Cost_Attack_From_Player = md_Cost_Attack_From_Player - 0.01 'reduces the cost of the attack towards the boss by 0.01

        md_Cost_HBN = md_Cost_HBN + 0.5 'Increases the cost of the power up by 0.5

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub btnPowerTug_HL_Click(sender As Object, e As EventArgs) Handles btnPowerTug_HL.Click 'When the user clicks on to purchase the increase attack damage towards boss power up

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        ExchangeCurrency.PurchasePowerTug(mdMeat, md_Cost_HL)

        ExchangeCurrency.GainPowerTug(md_Owned_HL)

        md_Attack_From_Player = md_Attack_From_Player + 1 'Increases the players attack damage by 1

        md_Cost_HL = md_Cost_HL + 50 'Increases the cost of the power up by 50

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpdateScreen()

        CheckBeats()

    End Sub

    Private Sub TimerCarpalTunnel_Tick(sender As Object, e As EventArgs) Handles TimerCarpalTunnel.Tick 'On every tick of the boss battle timer

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        BossBattle.AttackFromBoss(mdMeat, md_Attack_From_CarpalTunnel)

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)
        UpdateScreen()

        UpToDateVars.GiveModuleChangedArray(mdAchList)

        UpdateScreen()

        CheckBeats()

        If mdMeat <= 0 Then 'If the users health/currency is 0 or under

            TimerCarpalTunnel.Stop() 'Stops the boss battle timer

            MessageBox.Show("Unfortunately, Carpal Tunnel has completely taken over your hand and has destroyed any chance of you ever Beating your Meat again.

You did good son, but not good enough. It's Game Over.", "Game Over.", MessageBoxButtons.OK, MessageBoxIcon.Stop)

            Application.Exit() 'Game ends and the application closes

        End If

    End Sub

    Private Sub UpdateScreen() ' Updates the label with number of Beats

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        ShowObjects.UpdateScreen(lblMeatBeaten.Text, mdMeat, lbl_HL_NumberOwned.Text, md_Owned_HL, btnPowerTug_HL.Text, md_Cost_HL)

        ShowObjects.UpdateScreen(lblMeatBeaten.Text, mdMeat, lbl_HBN_NumberOwned.Text, md_Owned_HBN, btnPowerTug_HBN.Text, md_Cost_HBN)

        ShowObjects.ShowHealth(lblMeatBeaten.Text, mdMeat, lblHP_CarpalTunnel.Text, md_HP_CarpalTunnel)

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

    End Sub

    Private Sub CheckBeats() 'Checks how many Beats the user owns and compares them to the cost of power tugs

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        CurrencyCheck.PowerTugCost(mdMeat, md_Cost_HL, lbl_HL_Title, btnPowerTug_HL, lbl_HL_NumberOwned, lbl_BPS_HL, lbl_HL_Desc)
        CurrencyCheck.PowerTugCost(mdMeat, md_Cost_HBN, lbl_HBN_Title, btnPowerTug_HBN, lbl_HBN_NumberOwned, lbl_BPS_HBN, lbl_HBN_Desc)

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click 'Takes all necessary variables and converts them into a save file

        SaveLoad.SaveFileAs(mdMeat, mdBeatValue, mdCostQS, mdOwnedQS, mdQuickScratch, mdCostRP, mdOwnedRP, mdRoseyPalms, mdCostMRS, mdOwnedMRS, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins, mdBeatsRecorded, mdPowerTugsRecorded)

    End Sub

    Private Sub btn_Load_Click(sender As Object, e As EventArgs) Handles btn_Load.Click 'Takes values from save file and changes variables current values to match them

        UpToDateVars.ModuleGiveVarsOut(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpToDateVars.ModuleGiveVarsOut_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        SaveLoad.LoadFile(mdMeat, mdBeatValue, mdCostQS, mdOwnedQS, mdQuickScratch, mdCostRP, mdOwnedRP, mdRoseyPalms, mdCostMRS, mdOwnedMRS, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins, mdBeatsRecorded, mdPowerTugsRecorded)

        UpToDateVars.GiveModuleChangedVars_BossBattle(mdMeat, md_HP_CarpalTunnel, md_Attack_From_CarpalTunnel, md_Attack_From_Player, md_Cost_Attack_From_Player, md_Cost_HL, md_Cost_HBN, md_Owned_HL, md_Owned_HBN, md_HandLotion, md_HomeBrandNapkins)

        UpToDateVars.GiveModuleChangedVars(mdMeat, mdBeatValue, mdCostQS, mdCostRP, mdCostMRS, mdOwnedQS, mdOwnedRP, mdOwnedMRS, mdBeatsRecorded, mdPowerTugsRecorded, md10Secs, mdMinute, md5MinCountdown, mdRoseyPalms, mdQuickScratch)

        UpdateScreen()

        CheckBeats()

    End Sub

End Class