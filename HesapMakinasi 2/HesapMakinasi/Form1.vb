Imports System.Linq.Expressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sayi1, sayi2 As Double
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            If topla_btn.Checked = True Then
                Label3.Text = sayi1 + sayi2
            ElseIf cikart_btn.Checked = True Then
                Label3.Text = sayi1 - sayi2
            ElseIf carp_btn.Checked = True Then
                Label3.Text = sayi1 * sayi2
            Else
                Label3.Text = sayi1 / sayi2
            End If
        Catch ex As Exception
            MsgBox("Lütfen sayısal bir değer giriniz", MsgBoxStyle.Critical, "Uyarı")
        End Try
    End Sub
End Class
