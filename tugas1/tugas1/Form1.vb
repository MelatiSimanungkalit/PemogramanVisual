Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.SelectedIndex = 0 ' default pilihan pertama
        cbRole_SelectedIndexChanged(sender, e) ' panggil manual biar gambar langsung muncul
    End Sub

    ' Ganti gambar setiap Role berubah
    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        Dim namaFile As String = cbRole.SelectedItem.ToString().ToLower() & ".jpg"
        Dim filePath As String = Path.Combine(Application.StartupPath, "Asset", namaFile)

        If File.Exists(filePath) Then
            pbFoto.Image = Image.FromFile(filePath)
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        ' Validasi Nama & NIM tidak boleh kosong
        If String.IsNullOrEmpty(nama) OrElse String.IsNullOrEmpty(nim) Then
            MessageBox.Show("Masukkan akun dengan benar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validasi NIM harus angka semua
        Dim nimAngka As Long
        If Not Long.TryParse(nim, nimAngka) Then
            MessageBox.Show("Masukkan NIM dengan benar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Kalau valid, buka Form Pajak
        Dim formPajak As New FormPajak(nama, cbRole.SelectedItem.ToString())
        formPajak.Show()
        Me.Hide()
    End Sub

End Class