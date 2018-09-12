Public Class frmTutorialMenu

    Private Sub btn_tut_h2p_Click(sender As Object, e As EventArgs) Handles btn_tut_h2p.Click

        Me.Close()
        frmTutorialHowToPlay_Page1.Show()

    End Sub

    Private Sub btn_tut_PurchasePT_Click(sender As Object, e As EventArgs) Handles btn_tut_PurchasePT.Click

        Me.Close()
        frmTutorialHowToPurchasePT_Page1.Show()

    End Sub

    Private Sub btn_tut_save_Click(sender As Object, e As EventArgs) Handles btn_tut_save.Click

        Me.Close()
        frmTutorialHowToSave_Page1.Show()

    End Sub

    Private Sub btn_tut_Load_Click(sender As Object, e As EventArgs) Handles btn_tut_Load.Click

        Me.Close()
        frmTutorialHowToLoad_Page1.Show()

    End Sub

    Private Sub btn_Tut_exit_Click(sender As Object, e As EventArgs) Handles btn_Tut_exit.Click

        Me.Close()

    End Sub

End Class