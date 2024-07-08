Imports System.Data.SqlClient

Public Class Register
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form1 As New Form1()
        Form1.Show()

        ' Mevcut formu kapat
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim User As New User()
        User.Show()

        ' Mevcut formu kapat
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' TextBox1 ve TextBox2'deki bilgileri alın
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Kullanıcı adı veya şifre boş mu kontrol et
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Kullanıcı adı veya şifre boş bırakılamaz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' SQL bağlantısını kurun
        Dim connectionString As String = "Server=DESKTOP-06LT5PF\SQLEXPRESS;Database=ElifEmlak;Trusted_Connection=True;"
        Using connection As New SqlConnection(connectionString)
            Try
                ' Bağlantıyı aç
                connection.Open()

                ' SQL sorgusunu hazırla
                Dim query As String = "INSERT INTO Users (usern, sifre) VALUES (@username, @password)"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    ' Sorguyu çalıştır ve sonuç al
                    Dim result As Integer = command.ExecuteNonQuery()

                    ' Sonucu kontrol et
                    If result > 0 Then
                        ' Kayıt başarılı
                        MessageBox.Show("Kayıt başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' İsterseniz kayıt sonrası işlemler burada yapılabilir.
                    Else
                        ' Kayıt başarısız
                        MessageBox.Show("Kayıt başarısız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Veritabanı bağlantı hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class