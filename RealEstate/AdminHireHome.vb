Imports System.Data.SqlClient

Public Class AdminHireHome
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

    Private Sub AdminHireHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ElifEmlakDataSet3.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.KullanicilarTableAdapter1.Fill(Me.ElifEmlakDataSet3.Kullanicilar)
        'TODO: Bu kod satırı 'ElifEmlakDataSet2.Kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.KullanicilarTableAdapter.Fill(Me.ElifEmlakDataSet2.Kullanicilar)
        'TODO: Bu kod satırı 'ElifEmlakDataSet1.Users' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.UsersTableAdapter.Fill(Me.ElifEmlakDataSet1.Users)
        'TODO: Bu kod satırı 'ElifEmlakDataSet.Evler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EvlerTableAdapter.Fill(Me.ElifEmlakDataSet.Evler)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminPanel As New AdminPanel()
        AdminPanel.Show()
        Me.Hide()
    End Sub
End Class
