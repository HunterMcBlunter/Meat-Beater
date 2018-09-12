Module ShowObjects

    Public Sub UpdateScreen(ByRef prCurrencyLabel As String, ByVal prCurrency As Double, ByRef prPowerTugOwnedLabel As Object, ByVal prPowerTugOwned As UShort, ByRef prPowerTugCostLabel As Object, ByVal PowerTugCost As Double) 'Updates currency, number of object owned and cost of object

        prCurrencyLabel = prCurrency

        prPowerTugOwnedLabel = "Number Owned:" & prPowerTugOwned

        prPowerTugCostLabel = "Cost in Beats:" & PowerTugCost

    End Sub

    Public Sub ShowPowerTug(prPowerTugTitle, prPowerTugButt, prPowerTugNumberOwnedLbl, prPowerTugBPSLbl, prPowerTugDesc) 'Shows a specified power tug

        prPowerTugTitle.Show()
        prPowerTugButt.Show()
        prPowerTugNumberOwnedLbl.Show()
        prPowerTugBPSLbl.Show()
        prPowerTugDesc.Show()

    End Sub

    Public Sub ShowHealth(ByRef prCurrencyLabel As String, ByVal prCurrency As Double, ByRef prBossHPLabel As String, ByVal prBossHP As UShort) 'Shows the health bars of both the player and the boss

        prCurrencyLabel = prCurrency

        prBossHPLabel = prBossHP

    End Sub

End Module
