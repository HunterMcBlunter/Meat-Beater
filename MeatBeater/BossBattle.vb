Public Module BossBattle

    Public Sub ShowHealthBars(ByRef prCurrencyLabel As String, ByRef prCurrency As Double, ByRef prBossHPLabel As String, ByRef prBossHP As UShort) 'Shows the updated values for the currency/health bar of the player and health bar of the boss

        prCurrencyLabel = prCurrency

        prBossHPLabel = prBossHP

    End Sub

    Public Sub AttackFromPlayer(ByRef prCurrency As Double, ByRef prPlayerAttack As UShort, ByVal prPlayerAttackCost As Double, ByRef prBossHP As UShort) 'Attacks the boss, subtracts the attack damage from the boss and subtracts the cost of attack from the players health

        prCurrency = prCurrency - prPlayerAttackCost

        prBossHP = prBossHP - prPlayerAttack

    End Sub

    Public Sub AttackFromBoss(ByRef prCurrency As Double, ByRef prBossAttack As UShort) 'Subtracts from the players health/currency based on the bosses attack

        prCurrency = prCurrency - prBossAttack

    End Sub

End Module
