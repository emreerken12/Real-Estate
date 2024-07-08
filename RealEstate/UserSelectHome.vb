Public Class UserSelectHome
    Private Sub UserSelectHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'ElifEmlakDataSet4.Evler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.EvlerTableAdapter.Fill(Me.ElifEmlakDataSet4.Evler)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim UserPanel As New UserPanel()
        UserPanel.Show()
        Me.Hide()
    End Sub
End Class