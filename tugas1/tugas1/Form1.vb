Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRole.SelectedIndex = -1 ' kosongkan, jangan ada pilihan default
    End Sub

    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
        If cbRole.Text = "Staff" Then
            pbFoto.Image = Image.FromFile(Application.StartupPath & "\Asset\staff.jpg")
        Else
            pbFoto.Image = Image.FromFile(Application.StartupPath & "\Asset\manager.jpg")
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbRole.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Role terlebih dahulu")
            cbRole.Focus()
            Return
        End If

        Dim nim As Integer
        If Not Integer.TryParse(txtNIM.Text, nim) Then
            txtNIM.Focus()
            Return
        End If

        If cbRole.Text = "Staff" AndAlso txtNama.Text.Trim().ToLower() = "nadya" AndAlso nim = 241712051 Then
            Dim formPajak As New FormPajak(txtNama.Text.Trim(), cbRole.Text, Me)
            formPajak.Show()
            Me.Hide()
        ElseIf cbRole.Text = "Manager" AndAlso txtNama.Text.Trim().ToLower() = "shata diyaul haq" AndAlso nim = 241712061 Then
            Dim formPajak As New FormPajak(txtNama.Text.Trim(), cbRole.Text, Me)
            formPajak.Show()
            Me.Hide()
        Else
            MessageBox.Show("Masukkan Akun dengan Benar")
            Return
        End If

        txtNama.Clear()
        txtNIM.Clear()
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
        End If
    End Sub

End Class