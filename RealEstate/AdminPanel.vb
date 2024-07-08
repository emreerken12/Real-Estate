Public Class AdminPanel
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AdmninAddHome As New AdminAddHome()
        AdminAddHome.Show()

        ' Mevcut formu kapat
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AdminAddUser As New AdminAddUser()
        AdminAddUser.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim AdminHireHome As New AdminHireHome()
        AdminHireHome.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class