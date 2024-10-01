Public Class Form1
    Dim alisfiyati, satisfiyati, karorani As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        alisfiyati = MaskedTextBox1.Text
        karorani = MaskedTextBox2.Text
        satisfiyati = ((alisfiyati * karorani) / 100) + alisfiyati
        Label3.Text = "Satış Fiyatı: " & satisfiyati
    End Sub
End Class
