Public Class UserPanel
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim UserSelectHome As New UserSelectHome()
        UserSelectHome.Show()

        ' Mevcut formu kapat
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserHireForm As New UserHireForm()
        UserHireForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim UserAddUser As New UserAddUser()
        UserAddUser.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Hide()
    End Sub
End Class