Public Class Form1
    Dim sayi1, sayi2 As Integer
    Dim sonuc As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sayi1 = MaskedTextBox1.Text
        sayi2 = MaskedTextBox2.Text
        sonuc = sayi1 + sayi2
        Label3.Text = "Sonuç: " & sonuc
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sayi1 = MaskedTextBox1.Text
        sayi2 = MaskedTextBox2.Text
        sonuc = sayi1 - sayi2
        Label3.Text = "Sonuç: " & sonuc
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sayi1 = MaskedTextBox1.Text
        sayi2 = MaskedTextBox2.Text
        sonuc = sayi1 * sayi2
        Label3.Text = "Sonuç: " & sonuc
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        sayi1 = MaskedTextBox1.Text
        sayi2 = MaskedTextBox2.Text
        sonuc = sayi1 / sayi2
        Label3.Text = "Sonuç: " & sonuc
    End Sub

End Class
