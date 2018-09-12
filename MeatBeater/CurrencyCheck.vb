Module CurrencyCheck

    Public Sub PowerTugCost(prCurrency, prPowerTugCost, prPowerTugTitle, prPowerTugButt, prPowerTugNumberOwnedLbl, prPowerTugBPSLbl, prPowerTugDesc) 'Checks both currency and power tug cost to see if currency is high enough to afford the power tug. Shows the power tug if the currency is higher, hides the power tug if the currency is lower

        If prCurrency >= prPowerTugCost Then

            ShowObjects.ShowPowerTug(prPowerTugTitle, prPowerTugButt, prPowerTugNumberOwnedLbl, prPowerTugBPSLbl, prPowerTugDesc)

        ElseIf prCurrency < prPowerTugCost Then

            HideObjects.HidePowerTug(prPowerTugTitle, prPowerTugButt, prPowerTugNumberOwnedLbl, prPowerTugBPSLbl, prPowerTugDesc)

        End If


    End Sub

End Module
