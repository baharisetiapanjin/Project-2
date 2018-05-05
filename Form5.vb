Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b, c, i, faktor, fibbo, pangkat As Integer
        a = TextBox1.Text

        faktor = 1
        For i = 1 To a
            faktor = i * faktor
            TextBox2.Text = faktor
        Next

        fibbo = 0
        b = 1
        c = -1
        For i = 0 To a
            fibbo = b + c
            c = b
            b = fibbo
            TextBox3.Text = fibbo
        Next

        pangkat = 1
        For i = 1 To a
            pangkat = a * a
            TextBox4.Text = pangkat
        Next

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Focus()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub
End Class