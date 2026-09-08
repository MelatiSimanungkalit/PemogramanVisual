Public Class FormPajak

    Private namaUser As String
    Private roleUser As String
    Private formLogin As Form1

    Public Sub New(nama As String, role As String, login As Form1)
        InitializeComponent()
        namaUser = nama
        roleUser = role
        formLogin = login
    End Sub

    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim pendapatan As Double

        If Not Double.TryParse(txtPendapatan.Text.Trim(), pendapatan) Then
            MessageBox.Show("Masukkan pendapatan dengan angka yang benar", "Pajak", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        Dim persenPajak As Double

        If pendapatan > 100000000 Then
            persenPajak = 0.3
        ElseIf pendapatan > 30000000 Then
            persenPajak = 0.2
        ElseIf pendapatan > 5000000 Then
            persenPajak = 0.1
        Else
            persenPajak = 0
        End If

        Dim jumlahPajak As Double = pendapatan * persenPajak
        Dim pendapatanBersih As Double = pendapatan - jumlahPajak

        MessageBox.Show(
            "Pajak (" & (persenPajak * 100) & "%) : Rp " & jumlahPajak.ToString("N0") & vbCrLf &
            "Pendapatan Bersih : Rp " & pendapatanBersih.ToString("N0"),
            "Hasil Perhitungan Pajak",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        formLogin.Show()
    End Sub

End Class