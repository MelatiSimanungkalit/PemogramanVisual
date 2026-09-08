<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPerulangan
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
        lblNilaiAwal = New Label()
        txtNilaiAwal = New TextBox()
        lblNilaiAkhir = New Label()
        txtNilaiAkhir = New TextBox()
        lstHasil = New ListBox()
        btnInput = New Button()
        SuspendLayout()
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(299, 91)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(84, 20)
        lblNilaiAwal.TabIndex = 0
        lblNilaiAwal.Text = "Nilai Awal :"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(298, 124)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(125, 27)
        txtNilaiAwal.TabIndex = 1
        ' 
        ' lblNilaiAkhir
        ' 
        lblNilaiAkhir.AutoSize = True
        lblNilaiAkhir.Location = New Point(298, 175)
        lblNilaiAkhir.Name = "lblNilaiAkhir"
        lblNilaiAkhir.Size = New Size(85, 20)
        lblNilaiAkhir.TabIndex = 2
        lblNilaiAkhir.Text = "Nilai Akhir :"
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(296, 209)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(125, 27)
        txtNilaiAkhir.TabIndex = 3
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(296, 310)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(150, 104)
        lstHasil.TabIndex = 4
        ' 
        ' btnInput
        ' 
        btnInput.Location = New Point(305, 261)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(94, 29)
        btnInput.TabIndex = 5
        btnInput.Text = "Input"
        btnInput.UseVisualStyleBackColor = True
        ' 
        ' FrmPerulangan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnInput)
        Controls.Add(lstHasil)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(lblNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(lblNilaiAwal)
        Name = "FrmPerulangan"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents lblNilaiAkhir As Label
    Friend WithEvents txtNilaiAkhir As TextBox
    Friend WithEvents lstHasil As ListBox
    Friend WithEvents btnInput As Button

End Class
