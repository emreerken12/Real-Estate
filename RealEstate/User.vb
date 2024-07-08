Imports System.Data.SqlClient

Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Register As New Register()
        Register.Show()

        ' Mevcut formu kapat
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Form1 As New Form1()
        Form1.Show()

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
                Dim query As String = "SELECT COUNT(1) FROM Users WHERE usern = @username AND sifre = @password"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)

                    ' Sorguyu çalıştır ve sonuç al
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' Sonucu kontrol et
                    If count = 1 Then
                        ' Giriş başarılı
                        MessageBox.Show("Giriş yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' İsterseniz giriş sonrası işlemler burada yapılabilir.
                        Dim UserPanel As New UserPanel
                        UserPanel.Show()
                        Me.Hide()
                    Else
                        ' Giriş başarısız
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Veritabanı bağlantı hatası: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class