Public Class Form1

    Private Sub lblJoke_Click(sender As Object, e As EventArgs) Handles lblJoke.Click

    End Sub


    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblJoke.Visible = True

    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lblJoke.Text = ("A pineapple")
    End Sub
End Class
