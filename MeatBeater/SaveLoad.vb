Public Module SaveLoad
    Dim lcFileName As String
    Dim Savefile As String

    Public Sub SaveFileAs(ByVal prCurrency, ByVal prCurrencyEarned, ByVal prPowerUpCost1, ByVal prPowerUpOwned1, ByVal prPowerUpValue1, ByVal prPowerUpCost2, ByVal prPowerUpOwned2, ByVal prPowerUpValue2, ByVal prPowerUpCost3, ByVal prPowerUpOwned3, ByVal prBossHP, ByVal prBossAttack, ByVal prPlayerAttack, ByVal prPlayerAttackCost, ByVal prBossPowerUpCost1, ByVal prBossPowerUpCost2, ByVal prBossPowerUpOwned1, ByVal prBossPowerUpOwned2, ByVal prBossPowerUpValue1, ByVal prBossPowerUpValue2, ByVal prClicksRecorded, ByVal prPowerUpsRecorded)

        'Creates a text file with the values of the variables from the form that calls this subtask

        lcFileName = InputBox("Enter a file name to save as :

All files will be saved in your Documents folder", "Save Game", "Type name here.")

        lcFileName = "\" & lcFileName & ".txt"

        If lcFileName = "" Then

            lcFileName = "placeholder"

        Else

            Savefile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & lcFileName

            My.Computer.FileSystem.WriteAllText(Savefile,
                           prCurrency & ",", False)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prCurrencyEarned & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpCost1 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpOwned1 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpValue1 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpCost2 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpOwned2 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpValue2 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpCost3 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpOwned3 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossHP & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossAttack & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPlayerAttack & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossPowerUpCost1 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossPowerUpCost2 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossPowerUpOwned1 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossPowerUpOwned2 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossPowerUpValue1 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prBossPowerUpValue2 & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prClicksRecorded & ",", True)
            My.Computer.FileSystem.WriteAllText(Savefile,
                           prPowerUpsRecorded, True)

        End If

    End Sub

    Public Sub LoadFile(ByRef prCurrency, ByRef prCurrencyEarned, ByRef prPowerUpCost1, ByRef prPowerUpOwned1, ByRef prPowerUpValue1, ByRef prPowerUpCost2, ByRef prPowerUpOwned2, ByRef prPowerUpValue2, ByRef prPowerUpCost3, ByRef prPowerUpOwned3, ByRef prBossHP, ByRef prBossAttack, ByRef prPlayerAttack, ByRef prPlayerAttackCost, ByRef prBossPowerUpCost1, ByRef prBossPowerUpCost2, ByRef prBossPowerUpOwned1, ByRef prBossPowerUpOwned2, ByRef prBossPowerUpValue1, ByRef prBossPowerUpValue2, ByRef prClicksRecorded, ByRef prPowerUpsRecorded)

        'looks for a file to load that matches the name that the user enters

        lcFileName = InputBox("Enter your saved file name :

All saved files are located within your Documents folder", "Load Game", "Type name here.")

        lcFileName = "\" & lcFileName & ".txt"

        Savefile = My.Computer.FileSystem.SpecialDirectories.MyDocuments & lcFileName

        Using MyReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(Savefile)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")

            Dim currentRow As String()

            While Not MyReader.EndOfData
                Try
                    currentRow = MyReader.ReadFields()

                    Dim currentField As Decimal

                    Dim VairablesInSaveFileCounter As Integer = 0


                    For Each currentField In currentRow
                        Select Case VairablesInSaveFileCounter
                            Case 0
                                prCurrency = currentField
                            Case 1
                                prCurrencyEarned = currentField
                            Case 2
                                prPowerUpCost1 = currentField
                            Case 3
                                prPowerUpOwned1 = currentField
                            Case 4
                                prPowerUpValue1 = currentField
                            Case 5
                                prPowerUpCost2 = currentField
                            Case 6
                                prPowerUpOwned2 = currentField
                            Case 7
                                prPowerUpValue2 = currentField
                            Case 8
                                prPowerUpCost3 = currentField
                            Case 9
                                prPowerUpOwned3 = currentField
                            Case 10
                                prBossHP = currentField
                            Case 11
                                prBossAttack = currentField
                            Case 12
                                prPlayerAttack = currentField
                            Case 13
                                prPlayerAttackCost = currentField
                            Case 14
                                prBossPowerUpCost1 = currentField
                            Case 15
                                prBossPowerUpCost2 = currentField
                            Case 16
                                prBossPowerUpOwned1 = currentField
                            Case 17
                                prBossPowerUpOwned2 = currentField
                            Case 18
                                prBossPowerUpValue1 = currentField
                            Case 19
                                prBossPowerUpValue2 = currentField
                            Case 20
                                prClicksRecorded = currentField
                            Case 21
                                prPowerUpsRecorded = currentField


                            Case Else
                                MessageBox.Show("Corrupt file")


                        End Select
                        VairablesInSaveFileCounter = VairablesInSaveFileCounter + 1

                    Next

                Catch ex As Microsoft.VisualBasic.
                            FileIO.MalformedLineException
                    MsgBox("Line " & ex.Message &
                    "is not valid and will be skipped.")
                End Try


            End While
        End Using

    End Sub

End Module
