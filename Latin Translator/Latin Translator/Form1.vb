﻿Public Class Form1

    Private Sub lblCenter_Click(sender As Object, e As EventArgs) Handles lblCenter.Click

    End Sub

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblLeft.Visible = True
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblCenter.Visible = True
    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblRight.Visible = True
    End Sub

    Private Sub lblLeft_Click(sender As Object, e As EventArgs) Handles lblLeft.Click

    End Sub

    Private Sub lblRight_Click(sender As Object, e As EventArgs) Handles lblRight.Click

    End Sub
End Class
