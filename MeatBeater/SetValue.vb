Module SetValue

    Public Sub TimerToZero(ByRef prTime As Byte) 'Resets a timer back to zero

        prTime = 0

    End Sub

    Public Sub RecordClicks(ByRef prClicksRecorded As ULong) 'Records how many times the user has clicked on the meat

        prClicksRecorded = prClicksRecorded + 1

    End Sub

    Public Sub RecordPowerUps(ByRef prPowerUpsRecorded As UInteger) 'records how many power ups the user has purchased

        prPowerUpsRecorded = prPowerUpsRecorded + 1

    End Sub

End Module
