Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = False ' hide picture
        Label1.Text = CStr(Int(Rnd() * 10)) ' pick numbers
        Label2.Text = CStr(Int(Rnd() * 10))
        Label3.Text = CStr(Int(Rnd() * 10))
        ' if any number is 7 display picture and beep
        If (Label1.Text = "7") Or (Label2.Text = "7") Or (Label3.Text = "7") Then
            PictureBox1.Visible = True
            MsgBox("Selamat Anda Menang")
            Beep()
        Else
            MsgBox("Maaf Anda Belum Beruntung, Coba Lagi")
        End If
    End Sub
End Class
