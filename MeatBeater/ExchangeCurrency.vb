Module ExchangeCurrency

    Public Sub EarnCurrency(ByRef prCurrencyOwned, ByVal prCurrencyEarned) 'When the user earns currency

        prCurrencyOwned = prCurrencyOwned + prCurrencyEarned

    End Sub

    Public Sub PurchasePowerTug(ByRef prCurrency, ByVal prPowerTugCost) 'When the user spends currency on a power tug

        prCurrency = prCurrency - prPowerTugCost

    End Sub

    Public Sub GainPowerTug(ByRef prNumberOfPowerTugOwned) 'When the user gains a power tug

        prNumberOfPowerTugOwned = prNumberOfPowerTugOwned + 1

    End Sub

    Public Sub PowerTugIncreaseCost(ByRef prPowerTugCost) 'When the power tug increases in cost

        prPowerTugCost = prPowerTugCost * 2.0

    End Sub


End Module
