Imports System.Data.SqlClient

Public Class UserHireForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Güncellenecek evin ID'si ve kullanıcı ID'si
        Dim evId As Integer
        Dim kullanicilarid As Integer

        ' Evin ID'sini kontrol etme
        If Not Integer.TryParse(TextBox1.Text, evId) Then
            MessageBox.Show("Evin ID'si tam sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Kullanıcı ID'sini kontrol etme
        If Not Integer.TryParse(TextBox2.Text, kullanicilarid) Then
            MessageBox.Show("Kullanıcı ID'si tam sayı olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Bağlantı dizesi
        Dim connectionString As String = "Server=DESKTOP-06LT5PF\SQLEXPRESS;Database=ElifEmlak;Trusted_Connection=True;"

        ' SQL sorgusu (kullanıcı ID'sini güncellemek için)
        Dim query As String = "UPDATE Evler SET kullanicilarid = @kullanicilarid WHERE id = @id"

        ' Bağlantı ve komut nesnelerini kullanma
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Parametreleri ekle
                command.Parameters.AddWithValue("@kullanicilarid", kullanicilarid)
                command.Parameters.AddWithValue("@id", evId)

                ' Bağlantıyı aç ve komutu çalıştır
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Kullanıcı ID başarıyla güncellendi.")
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " & ex.Message)
                Finally
                    ' Bağlantıyı kapat
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' TC kimlik numarasını al
        Dim tc As String = MaskedTextBox1.Text.Replace("_", "").Trim()

        ' TC kimlik numarasının doğruluğunu kontrol et
        If tc.Length <> 11 OrElse Not IsNumeric(tc) Then
            MessageBox.Show("Lütfen geçerli bir TC kimlik numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Bağlantı dizesi
        Dim connectionString As String = "Server=DESKTOP-06LT5PF\SQLEXPRESS;Database=ElifEmlak;Trusted_Connection=True;"

        ' SQL sorgusu: TC kimlik numarasına göre kullanıcı ID'sini getir
        Dim query As String = "SELECT id FROM Kullanicilar WHERE tc = @tc"

        ' Kullanıcı ID'si
        Dim kullaniciId As Integer = -1 ' Varsayılan olarak -1, bulunamadığı durumda

        ' Bağlantı ve komut nesnelerini kullanma
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Parametreyi ekleyin
                command.Parameters.AddWithValue("@tc", tc)

                ' Bağlantıyı aç ve sorguyu çalıştır
                Try
                    connection.Open()
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        kullaniciId = Convert.ToInt32(result)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        ' Kullanıcı ID'sini kontrol edin
        If kullaniciId <> -1 Then
            Label4.Text = "Kullanıcı bulundu. Kullanıcı ID: " & kullaniciId.ToString()
        Else
            MessageBox.Show("Bu TC kimlik numarasına sahip bir kullanıcı bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim UserPanel As New UserPanel()
        UserPanel.Show()
        Me.Hide()
    End Sub
End Class