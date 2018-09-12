Public Module UpToDateVars

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


    Public Sub ModuleGiveVarsOut(ByRef prCurrency As Double, ByRef prCurrencyEarned As Double, ByRef pr10sPowerUpCost As Double, ByRef prMinutePowerUpCost As Double, ByRef prCurrencyEarnedPowerUpCost As Double, ByRef pr10sPowerUpOwned As UShort, ByRef prMinutePowerUpOwned As UShort, ByRef prCurrencyEarnedPowerUpOwned As UShort, ByRef prClicksRecorded As ULong, ByRef prPowerUpsRecorded As UInteger, ByRef pr10Secs As Byte, ByRef prMinute As Byte, ByRef pr5Mins As Short, ByRef pr10SecsPowerUp As UShort, ByRef prMinutePowerUp As Double)

        'Updates the values of variables in another form with the values from the module

        prCurrency = mdMeat
        prCurrencyEarned = mdBeatValue

        pr10sPowerUpCost = mdCostQS
        prMinutePowerUpCost = mdCostRP
        prCurrencyEarnedPowerUpCost = mdCostMRS

        pr10sPowerUpOwned = mdOwnedQS
        prMinutePowerUpOwned = mdOwnedRP
        prCurrencyEarnedPowerUpOwned = mdOwnedMRS

        prClicksRecorded = mdBeatsRecorded
        prPowerUpsRecorded = mdPowerTugsRecorded

        pr10Secs = md10Secs
        prMinute = mdMinute
        pr5Mins = md5MinCountdown

        pr10SecsPowerUp = mdRoseyPalms
        prMinutePowerUp = mdQuickScratch

    End Sub

    Public Sub GiveModuleChangedVars(ByVal prCurrency As Double, ByVal prCurrencyEarned As Double, ByVal pr10sPowerUpCost As Double, ByVal prMinutePowerUpCost As Double, ByVal prCurrencyEarnedPowerUpCost As Double, ByVal pr10sPowerUpOwned As UShort, ByVal prMinutePowerUpOwned As UShort, ByVal prCurrencyEarnedPowerUpOwned As UShort, ByVal prClicksRecorded As ULong, ByVal prPowerUpsRecorded As UInteger, ByVal pr10Secs As Byte, ByVal prMinute As Byte, ByVal pr5mins As Short, ByVal pr10SecsPowerUp As UShort, ByVal prMinutePowerUp As Double)

        'Updates the values of the variables in the module with the values from another form

        mdMeat = prCurrency
        mdBeatValue = prCurrencyEarned

        mdCostQS = pr10sPowerUpCost
        mdCostRP = prMinutePowerUpCost
        mdCostMRS = prCurrencyEarnedPowerUpCost

        mdOwnedQS = pr10sPowerUpOwned
        mdOwnedRP = prMinutePowerUpOwned
        mdOwnedMRS = prCurrencyEarnedPowerUpOwned

        mdBeatsRecorded = prClicksRecorded
        mdPowerTugsRecorded = prPowerUpsRecorded

        md10Secs = pr10Secs
        mdMinute = prMinute
        md5MinCountdown = pr5mins

        mdRoseyPalms = pr10SecsPowerUp
        mdQuickScratch = prMinutePowerUp

    End Sub

    Public Sub ModuleGiveVarsOut_BossBattle(ByRef prCurrency As Double, ByRef prBossHP As UShort, ByRef prAttackFromBoss As UShort, ByRef prAttackFromPlayer As UShort, ByRef prAttackFromPlayerCost As Double, ByRef prCost_GainAttackPowerUp As Double, ByRef prCost_ReduceAttackCostPowerUp As Double, ByRef prOwned_GainAttackPowerUp As UShort, ByRef prOwned_ReduceAttackCostPowerUp As UShort, ByRef prPowerUp_GainAttackPowerUp As UShort, ByRef prPowerUp_ReduceAttackCostPowerUp As Double)

        'Updates the values of variables in another form with the values from the module

        prCurrency = mdMeat

        prBossHP = md_HP_CarpalTunnel
        prAttackFromBoss = md_Attack_From_CarpalTunnel

        prAttackFromPlayer = md_Attack_From_Player
        prAttackFromPlayerCost = md_Cost_Attack_From_Player

        prCost_GainAttackPowerUp = md_Cost_HL
        prCost_ReduceAttackCostPowerUp = md_Cost_HBN

        prOwned_GainAttackPowerUp = md_Owned_HL
        prOwned_ReduceAttackCostPowerUp = md_Owned_HBN

        prPowerUp_GainAttackPowerUp = md_HandLotion
        prPowerUp_ReduceAttackCostPowerUp = md_HomeBrandNapkins

    End Sub

    Public Sub GiveModuleChangedVars_BossBattle(ByVal prCurrency As Double, ByVal prBossHP As UShort, ByVal prAttackFromBoss As UShort, ByVal prAttackFromPlayer As UShort, ByVal prAttackFromPlayerCost As Double, ByVal prCost_GainAttackPowerUp As Double, ByVal prCost_ReduceAttackCostPowerUp As Double, ByVal prOwned_GainAttackPowerUp As UShort, ByVal prOwned_ReduceAttackCostPowerUp As UShort, ByVal prPowerUp_GainAttackPowerUp As UShort, ByVal prPowerUp_ReduceAttackCostPowerUp As Double)

        'Updates the values of the variables in the module with the values from another form

        mdMeat = prCurrency

        md_HP_CarpalTunnel = prBossHP
        md_Attack_From_CarpalTunnel = prAttackFromBoss

        md_Attack_From_Player = prAttackFromPlayer
        md_Cost_Attack_From_Player = prAttackFromPlayerCost

        md_Cost_HL = prCost_GainAttackPowerUp
        md_Cost_HBN = prCost_ReduceAttackCostPowerUp

        md_Owned_HL = prOwned_GainAttackPowerUp
        md_Owned_HBN = prOwned_ReduceAttackCostPowerUp

        md_HandLotion = prPowerUp_GainAttackPowerUp
        md_HomeBrandNapkins = prPowerUp_ReduceAttackCostPowerUp

    End Sub

    Public Sub ModuleGiveChangedArray(ByRef prAchList As ArrayList)

        'Updates the contents of the ArrayList in another form with the values from the module

        prAchList = mdAchList

    End Sub

    Public Sub GiveModuleChangedArray(ByVal prAchList As ArrayList)

        'Updates the contents of the ArrayList in the module with the values from another form

        mdAchList = prAchList

    End Sub

End Module
