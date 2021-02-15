Public Class frmFlagSelector
    Private Sub PicPuertoRico_Click(sender As Object, e As EventArgs) Handles PicPuertoRico.Click
        lblNamesOfFlags.Text = "Puerto Rico"
    End Sub

    Private Sub PicBrazil_Click(sender As Object, e As EventArgs) Handles PicBrazil.Click
        lblNamesOfFlags.Text = "Brazil"
    End Sub

    Private Sub PicFrance_Click(sender As Object, e As EventArgs) Handles PicFrance.Click
        lblNamesOfFlags.Text = "France"
    End Sub

    Private Sub PicAlemania_Click(sender As Object, e As EventArgs) Handles PicAlemania.Click
        lblNamesOfFlags.Text = "Alemania"
    End Sub

    Private Sub PicJapan_Click(sender As Object, e As EventArgs) Handles PicJapan.Click
        lblNamesOfFlags.Text = "Japan"
    End Sub

    Private Sub PicUnitedStates_Click(sender As Object, e As EventArgs) Handles PicUnitedStates.Click
        lblNamesOfFlags.Text = "United States"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
