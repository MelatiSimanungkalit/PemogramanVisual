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
        pbFoto = New PictureBox()
        lblRole = New Label()
        cbRole = New ComboBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNIM = New Label()
        txtNIM = New TextBox()
        btnLogin = New Button()
        CType(pbFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pbFoto
        ' 
        pbFoto.Location = New Point(363, 51)
        pbFoto.Name = "pbFoto"
        pbFoto.Size = New Size(125, 135)
        pbFoto.SizeMode = PictureBoxSizeMode.Zoom
        pbFoto.TabIndex = 0
        pbFoto.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(296, 211)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(58, 20)
        lblRole.TabIndex = 1
        lblRole.Text = "Role    :"
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Items.AddRange(New Object() {"Staff", "Manager"})
        cbRole.Location = New Point(352, 208)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(151, 28)
        cbRole.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(298, 246)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(352, 245)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(125, 27)
        txtNama.TabIndex = 4
        ' 
        ' lblNIM
        ' 
        lblNIM.AutoSize = True
        lblNIM.Location = New Point(301, 287)
        lblNIM.Name = "lblNIM"
        lblNIM.Size = New Size(52, 20)
        lblNIM.TabIndex = 5
        lblNIM.Text = "NIM   :"
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(353, 288)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(125, 27)
        txtNIM.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(363, 342)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(txtNIM)
        Controls.Add(lblNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(cbRole)
        Controls.Add(lblRole)
        Controls.Add(pbFoto)
        Name = "Form1"
        Text = "Form1"
        CType(pbFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pbFoto As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents cbRole As ComboBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNIM As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents btnLogin As Button

End Class
