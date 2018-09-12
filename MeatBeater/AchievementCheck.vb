Public Module AchievementCheck

    'Group 1 (Beat Achievements)
    Dim mdAchievement_100Beats As Boolean = False
    Dim mdAchievement_500Beats As Boolean = False
    Dim mdAchievement_1000Beats As Boolean = False

    'Group 2 (Power up Achievements)
    Dim mdAchievement_5Upgrades As Boolean = False
    Dim mdAchievement_10Upgrades As Boolean = False
    Dim mdAchievement_50Upgrades As Boolean = False

    'Group 3 (Meat Value Achievements)
    Dim mdAchievement_1500MeatValue As Boolean = False
    Dim mdAchievement_5000MeatValue As Boolean = False
    Dim mdAchievement_10000MeatValue As Boolean = False

    Dim mdAchList As New ArrayList()

    Public Sub BeatAchievements(ByVal prClicksRecorded As ULong) 'Checks how many times the user has clicked the meat, and distributes achievements based on whether the user meets certain criterias

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        If prClicksRecorded >= 100 And mdAchievement_100Beats = False Then
            mdAchievement_100Beats = True

            Dim lcBeatAch1 As String = "Farmers Catalogue - Beat Your Meat 100 Times"

            mdAchList.Add(lcBeatAch1)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Farmers Catalogue

Beat your Meat 100 Times", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcBeatAch1)

        End If

        If prClicksRecorded >= 500 And mdAchievement_500Beats = False Then
            mdAchievement_500Beats = True

            Dim lcBeatAch2 As String = "Uncle Stans Box o' Mags - Beat Your Meat 500 Times"

            mdAchList.Add(lcBeatAch2)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Uncle Stans Box o' Mags

Beat your Meat 500 Times", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcBeatAch2)

        End If

        If prClicksRecorded >= 1000 And mdAchievement_1000Beats = False Then
            mdAchievement_1000Beats = True

            Dim lcBeatAch3 As String = "Uncle Stans Box o' Mags - Beat Your Meat 500 Times"

            mdAchList.Add(lcBeatAch3)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("World Wide Web

Beat your Meat 1000 Times", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcBeatAch3)

        End If

    End Sub



    Public Sub PowerUpAchievements(ByVal prPowerUpsRecorded As UInteger) 'Checks how many achievements the user has purchased, and distributes achievements based on whether the user meets certain criterias

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        If prPowerUpsRecorded >= 5 And mdAchievement_5Upgrades = False Then
            mdAchievement_5Upgrades = True

            Dim lcPowerUpAch1 As String = "After Breakup - Purchase 5 Power Tugs"

            mdAchList.Add(lcPowerUpAch1)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("After Breakup

Purchase 5 Power Tugs", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcPowerUpAch1)

        End If

        If prPowerUpsRecorded >= 10 And mdAchievement_10Upgrades = False Then
            mdAchievement_10Upgrades = True

            Dim lcPowerUpAch2 As String = "Rise of the Machines...And something else - Purchase 10 Power Tugs"

            mdAchList.Add(lcPowerUpAch2)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Rise of the Machines....And something else

Purchase 10 Power Tugs", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcPowerUpAch2)

        End If

        If prPowerUpsRecorded >= 50 And mdAchievement_50Upgrades = False Then
            mdAchievement_50Upgrades = True

            Dim lcPowerUpAch3 As String = "Humans just don't do it for me anymore - Purchase 50 Power Tugs"

            mdAchList.Add(lcPowerUpAch3)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Humans just don't do it for me anymore

Purchase 50 Power Tugs", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcPowerUpAch3)

        End If

    End Sub


    Public Sub MeatValueAchievements(ByVal prCurrency As Double) 'Checks the users current meat value, and distributes achievements if the user meats certain criterias

        UpToDateVars.ModuleGiveChangedArray(mdAchList)

        If prCurrency >= 1500 And mdAchievement_1500MeatValue = False Then
            mdAchievement_1500MeatValue = True

            Dim lcMeatValueAch1 As String = "Blurry Vision - Beat your Meat 1500 times without Spending Anything"

            mdAchList.Add(lcMeatValueAch1)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Blurry Vision

Beat your Meat 1500 times without Spending Anything", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcMeatValueAch1)

        End If

        If prCurrency >= 5000 And mdAchievement_5000MeatValue = False Then
            mdAchievement_5000MeatValue = True

            Dim lcMeatValueAch2 As String = "Rejected Guinness World Record Attempt - Beat your Meat 5000 times without Spending Anything"

            mdAchList.Add(lcMeatValueAch2)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Rejected Guinness World Record Attempt

Beat your Meat 5000 times without Spending Anything", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcMeatValueAch2)

        End If

        If prCurrency >= 10000 And mdAchievement_10000MeatValue = False Then
            mdAchievement_10000MeatValue = True

            Dim lcMeatValueAch3 As String = "Average University Student - Beat your Meat 10000 times without Spending Anything"

            mdAchList.Add(lcMeatValueAch3)

            UpToDateVars.GiveModuleChangedArray(mdAchList)

            MessageBox.Show("Average University Student

Beat your Meat 10,000 times without Spending Anything", "Achievement Unlocked!")

            frmMeatBeater.list_Ach.Items.Add(lcMeatValueAch3)

        End If

    End Sub

End Module
