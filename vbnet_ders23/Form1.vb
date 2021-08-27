
Public Class Form1

    Dim indirilecekyer As String
    Dim dosya As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New FolderBrowserDialog()
        a.ShowDialog()
        indirilecekyer = a.SelectedPath
        TextBox2.Text = indirilecekyer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If indirilecekyer = "" Then
            MsgBox("Lütfen indirilecek yeri seçin")
        Else
            Label1.Text = "İNDİRİLİYOR... BEKLEYİN!"
            Label1.BackColor = Color.Orange

            dosya = indirilecekyer & "\" & TextBox3.Text & TextBox1.Text.Substring(TextBox1.Text.Length - 4, 4)

            My.Computer.Network.DownloadFile(TextBox1.Text, dosya)

            Label1.Text = "İNDİRME TAMAMLANDI, DOSYAYI AÇMAK İÇİN TIKLA"
            Label1.BackColor = Color.Green
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.BackColor = Color.Green Then
            Try
                Process.Start(dosya)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
