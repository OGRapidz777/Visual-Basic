'Autor Edwin M Alvarez Cintron '
'Date: Sunday november 22 2020 '
'Purpose: To Display the name of the Flags of Puerto Rico, Alemania, France, Brazil, Japan and United States'

Public Class FrmFlagSelector
    Private Sub PicPuertoRico_Click(sender As Object, e As EventArgs) Handles PicPuertoRico.Click
        'When Picture Box containing the Flag named PuertoRico is clicked, the label will display Puerto Rico'
        lblNamesOfFlags.Text = "Puerto Rico"
    End Sub

    Private Sub PicBrazil_Click(sender As Object, e As EventArgs) Handles PicBrazil.Click
        'When Picture Box containing the Flag named Brazil is clicked, the label will display Brazil'
        lblNamesOfFlags.Text = "Brazil"
    End Sub

    Private Sub PicFrance_Click(sender As Object, e As EventArgs) Handles PicFrance.Click
        'When Picture Box containing the Flag named France is clicked, the label will display France'
        lblNamesOfFlags.Text = "France"
    End Sub

    Private Sub PicAlemania_Click(sender As Object, e As EventArgs) Handles PicAlemania.Click
        'When Picture Box containing the Flag named Alemania is clicked, the label will display Alemania'
        lblNamesOfFlags.Text = "Alemania"
    End Sub

    Private Sub PicJapan_Click(sender As Object, e As EventArgs) Handles PicJapan.Click
        'When Picture Box containing the Flag named Japan is clicked, the label will display Japan'
        lblNamesOfFlags.Text = "Japan"
    End Sub

    Private Sub PicUnitedStates_Click(sender As Object, e As EventArgs) Handles PicUnitedStates.Click
        'When Picture Box containing the Flag named United States is clicked, the label will display United States'
        lblNamesOfFlags.Text = "United States"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'When this button is clicked it will end the execution of the program.'
        End
    End Sub
End Class
