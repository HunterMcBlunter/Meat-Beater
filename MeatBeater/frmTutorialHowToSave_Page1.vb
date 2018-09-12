Public Class frmTutorialHowToSave_Page1

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()
        frmTutorialMenu.Show()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Me.Close()
        frmTutorialHowToSave_Page2.Show()

    End Sub

End Class