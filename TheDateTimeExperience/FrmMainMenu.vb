Public Class FrmMainMenu
    Private Sub BtnDisplayDateTime_Click(sender As Object, e As EventArgs) Handles BtnDisplayDateTime.Click

        Dim frm As New FrmDisplayingDateTime
        frm.Show()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        If MessageBox.Show("Are you sure you want to exit?", "Really Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class