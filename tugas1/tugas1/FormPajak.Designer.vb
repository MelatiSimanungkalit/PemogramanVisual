<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblInfo1 = New Label()
        lblInfo2 = New Label()
        lblInfo3 = New Label()
        lblMasukkanPendapatan = New Label()
        lblRp = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblInfo1
        ' 
        lblInfo1.AutoSize = True
        lblInfo1.Location = New Point(239, 109)
        lblInfo1.Name = "lblInfo1"
        lblInfo1.Size = New Size(268, 20)
        lblInfo1.TabIndex = 0
        lblInfo1.Text = "Pendapatan lebih dari 5 juta, 10% Pajak"
        ' 
        ' lblInfo2
        ' 
        lblInfo2.AutoSize = True
        lblInfo2.Location = New Point(239, 150)
        lblInfo2.Name = "lblInfo2"
        lblInfo2.Size = New Size(276, 20)
        lblInfo2.TabIndex = 1
        lblInfo2.Text = "Pendapatan lebih dari 30 juta, 20% Pajak"
        ' 
        ' lblInfo3
        ' 
        lblInfo3.AutoSize = True
        lblInfo3.Location = New Point(239, 196)
        lblInfo3.Name = "lblInfo3"
        lblInfo3.Size = New Size(284, 20)
        lblInfo3.TabIndex = 2
        lblInfo3.Text = "Pendapatan lebih dari 100 juta, 30% Pajak"
        ' 
        ' lblMasukkanPendapatan
        ' 
        lblMasukkanPendapatan.AutoSize = True
        lblMasukkanPendapatan.Location = New Point(288, 257)
        lblMasukkanPendapatan.Name = "lblMasukkanPendapatan"
        lblMasukkanPendapatan.Size = New Size(156, 20)
        lblMasukkanPendapatan.TabIndex = 3
        lblMasukkanPendapatan.Text = "Masukkan Pendapatan"
        ' 
        ' lblRp
        ' 
        lblRp.AutoSize = True
        lblRp.Location = New Point(277, 299)
        lblRp.Name = "lblRp"
        lblRp.Size = New Size(30, 20)
        lblRp.TabIndex = 4
        lblRp.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(309, 301)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(125, 27)
        txtPendapatan.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(325, 345)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(94, 29)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(325, 391)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(94, 29)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' FormPajak
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblRp)
        Controls.Add(lblMasukkanPendapatan)
        Controls.Add(lblInfo3)
        Controls.Add(lblInfo2)
        Controls.Add(lblInfo1)
        Name = "FormPajak"
        Text = "FormPajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblInfo1 As Label
    Friend WithEvents lblInfo2 As Label
    Friend WithEvents lblInfo3 As Label
    Friend WithEvents lblMasukkanPendapatan As Label
    Friend WithEvents lblRp As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
