Imports System.Data.SqlClient

Public Class AdminAddUser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' İsim, soyisim, TC ve doğum tarihi alanlarını al
        Dim isim As String = TextBox1.Text.Trim()
        Dim soyisim As String = TextBox2.Text.Trim()
        Dim tc As String = MaskedTextBox1.Text.Replace("_", "").Trim()
        Dim dogumTarihi As Date = DateTimePicker1.Value

        ' Alanların boş olup olmadığını kontrol et
        If String.IsNullOrWhiteSpace(isim) OrElse String.IsNullOrWhiteSpace(soyisim) OrElse String.IsNullOrWhiteSpace(tc) Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' TC'nin doğru formatta olduğunu ve 11 karakterden oluştuğunu kontrol et
        If tc.Length <> 11 OrElse Not IsNumeric(tc) Then
            MessageBox.Show("TC kimlik numarası 11 haneli ve sadece rakamlardan oluşmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Doğum tarihini kontrol et ve kullanıcının 18 yaşından büyük olduğunu doğrula
        Dim yas As Integer = Date.Now.Year - dogumTarihi.Year
        If Date.Now < dogumTarihi.AddYears(18) Then
            MessageBox.Show("Kullanıcı 18 yaşından küçük olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Bağlantı dizesi
        Dim connectionString As String = "Server=DESKTOP-06LT5PF\SQLEXPRESS;Database=ElifEmlak;Trusted_Connection=True;"

        ' SQL sorgusu
        Dim query As String = "INSERT INTO Kullanicilar (isim, soyisim, tc, dg) VALUES (@isim, @soyisim, @tc, @dg)"

        ' Bağlantı ve komut nesnelerini kullanma
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Parametreleri ekle
                command.Parameters.AddWithValue("@isim", isim)
                command.Parameters.AddWithValue("@soyisim", soyisim)
                command.Parameters.AddWithValue("@tc", tc)
                command.Parameters.AddWithValue("@dg", dogumTarihi)

                ' Bağlantıyı aç ve komutu çalıştır
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Bağlantıyı kapat
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub
End Class