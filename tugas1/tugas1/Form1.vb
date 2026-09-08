Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.SelectedIndex = 0
        cbRole_SelectedIndexChanged(sender, e)
    End Sub


    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        Dim namaFile As String = cbRole.SelectedItem.ToString().ToLower() & ".jpg"
        Dim filePath As String = Path.Combine(Application.StartupPath, "Asset", namaFile)

        If File.Exists(filePath) Then
            pbFoto.Image = Image.FromFile(filePath)
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()


        If String.IsNullOrEmpty(nama) OrElse String.IsNullOrEmpty(nim) Then
            MessageBox.Show("Masukkan akun dengan benar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim nimAngka As Long
        If Not Long.TryParse(nim, nimAngka) Then
            MessageBox.Show("Masukkan NIM dengan benar", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNIM.Focus()
            Return
        End If

        Dim formPajak As New FormPajak(nama, cbRole.SelectedItem.ToString(), Me)
        formPajak.Show()
        Me.Hide()

        txtNama.Clear()
        txtNIM.Clear()
    End Sub

    Private Sub pbFoto_Click(sender As Object, e As EventArgs) Handles pbFoto.Click

    End Sub
End Class