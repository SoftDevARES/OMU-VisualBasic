Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim boy, kilo, bki As Double

        boy = TextBox1.Text
        kilo = TextBox2.Text
        bki = kilo / (boy * boy)
        Label4.Text = Math.Round(bki, 1)

        If bki < 19 Then
            Label5.Text = "Zayıf"
            PictureBox1.ImageLocation = "indir.png"
        ElseIf bki < 25 Then
            Label5.Text = "Normal"
            PictureBox1.ImageLocation = "indir.png"
        ElseIf bki < 30 Then
            Label5.Text = " Hafif Kilolu"
            PictureBox1.ImageLocation = "indir.png"
        ElseIf bki < 35 Then
            Label5.Text = "1. Derece Obez"
            PictureBox1.ImageLocation = "indir.png"
        ElseIf bki < 40 Then
            Label5.Text = "2. Derece Obez"
            PictureBox1.ImageLocation = "indir.png"
        Else
            Label5.Text = "3. Derece Obez"
            PictureBox1.ImageLocation = "indir.png"
        End If

    End Sub
End Class
