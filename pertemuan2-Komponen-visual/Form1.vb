Public Class Form1
    Private Sub txtNama_Click(sender As Object, e As EventArgs) Handles lblNama.Click

    End Sub

    Private Sub BtnTampilkan_Click(sender As Object, e As EventArgs) Handles BtnTampilkan.Click
        MessageBox.Show("Halo dunia" & vbCrLf &
            "Nama  : " & txtNama.Text & vbCrLf &
            "NIM   : " & txtNIM.Text & vbCrLf &
            "KOM   : " & txtKom.Text
                        )
    End Sub

    Private Sub TextNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles BtnHAPUS.Click
        txtNama.Clear()
        txtNIM.Clear()
        txtKom.Clear()

    End Sub

    Private Sub txtKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
