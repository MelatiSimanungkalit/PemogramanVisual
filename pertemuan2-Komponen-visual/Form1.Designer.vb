<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNama = New Label()
        txtNama = New TextBox()
        LblNIM = New Label()
        txtNIM = New TextBox()
        LblKOM = New Label()
        txtKom = New TextBox()
        BtnTampilkan = New Button()
        BtnHAPUS = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(155, 69)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(60, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "NAMA :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(214, 66)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 1
        ' 
        ' LblNIM
        ' 
        LblNIM.AutoSize = True
        LblNIM.Location = New Point(155, 114)
        LblNIM.Name = "LblNIM"
        LblNIM.Size = New Size(44, 20)
        LblNIM.TabIndex = 2
        LblNIM.Text = "NIM :"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(214, 111)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(125, 27)
        txtNIM.TabIndex = 3
        ' 
        ' LblKOM
        ' 
        LblKOM.AutoSize = True
        LblKOM.Location = New Point(155, 153)
        LblKOM.Name = "LblKOM"
        LblKOM.Size = New Size(48, 20)
        LblKOM.TabIndex = 4
        LblKOM.Text = "KOM :"
        ' 
        ' txtKom
        ' 
        txtKom.Location = New Point(215, 153)
        txtKom.Name = "txtKom"
        txtKom.Size = New Size(125, 27)
        txtKom.TabIndex = 5
        ' 
        ' BtnTampilkan
        ' 
        BtnTampilkan.Location = New Point(218, 207)
        BtnTampilkan.Name = "BtnTampilkan"
        BtnTampilkan.Size = New Size(94, 29)
        BtnTampilkan.TabIndex = 6
        BtnTampilkan.Text = "Tampilkan"
        BtnTampilkan.UseVisualStyleBackColor = True
        ' 
        ' BtnHAPUS
        ' 
        BtnHAPUS.Location = New Point(332, 210)
        BtnHAPUS.Name = "BtnHAPUS"
        BtnHAPUS.Size = New Size(94, 29)
        BtnHAPUS.TabIndex = 7
        BtnHAPUS.Text = "HAPUS"
        BtnHAPUS.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(305, 264)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 8
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 521)
        Controls.Add(btnKeluar)
        Controls.Add(BtnHAPUS)
        Controls.Add(BtnTampilkan)
        Controls.Add(txtKom)
        Controls.Add(LblKOM)
        Controls.Add(txtNIM)
        Controls.Add(LblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Name = "Form1"
        Text = "profile mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents LblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents LblKOM As Label
    Friend WithEvents txtKom As TextBox
    Friend WithEvents BtnTampilkan As Button
    Friend WithEvents BtnHAPUS As Button
    Friend WithEvents btnKeluar As Button

End Class
