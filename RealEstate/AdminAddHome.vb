Imports System.Data.SqlClient

Public Class AdminAddHome
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Bağlantı dizesi
        Dim connectionString As String = "Server=DESKTOP-06LT5PF\SQLEXPRESS;Database=ElifEmlak;Trusted_Connection=True;"

        ' SQL sorgusu (kullanicilarid olmadan)
        Dim query As String = "INSERT INTO Evler (adres, metrekare, fiyat) VALUES (@adres, @metrekare, @fiyat)"

        ' Bağlantı ve komut nesnelerini kullanma
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' Parametreleri ekle
                command.Parameters.AddWithValue("@adres", TextBox1.Text)
                command.Parameters.AddWithValue("@metrekare", MaskedTextBox1.Text)
                command.Parameters.AddWithValue("@fiyat", MaskedTextBox2.Text)

                ' Bağlantıyı aç ve komutu çalıştır
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Kayıt başarıyla eklendi.")
                Catch ex As Exception
                    MessageBox.Show("Bir hata oluştu: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub
End Class