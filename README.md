# Tugas Pertemuan 2: Aplikasi Profil Mahasiswa

## Komponen yang Dipelajari
Karena ini masih materi awal, *project* ini fokus buat ngebiasain diri pakai tiga komponen dasar di Visual Studio:

*   **Label:** Dipakai buat bikin teks judul yang statis, kayak tulisan "NAMA :", "NIM :", dan "KOM :".
*   **TextBox:** Ini kotak putih tempat *user* ngetik data. Di pengaturan *Properties*, namanya udah disesuaikan jadi `txtNama`, `txtNIM`, dan `txtKOM` biar gampang dipanggil di kodingan.
*   **Button:** Tombol buat ngeksekusi perintah. Ada tiga tombol yang dibuat:
    *   `Tampilkan`: Buat ngambil teks dari TextBox dan dimunculin ke layar.
    *   `HAPUS`: Buat ngosongin kembali semua TextBox.
    *   `Keluar`: Buat nutup program.

## Logika Kodingan
Biar aplikasinya bisa ngebaca data yang diketik dan ngegabunginnya jadi satu kalimat sapaan, kodingan di balik tombol **Tampilkan** dibuat kayak gini:

```vb
Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
    Dim pesan As String = "Halo Selamat Datang !" & vbCrLf &
                          "Nama : " & txtNama.Text & vbCrLf &
                          "NIM  : " & txtNIM.Text & vbCrLf &
                          "KOM  : " & txtKOM.Text

    MessageBox.Show(pesan)
End Sub
