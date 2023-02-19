<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.tbFile = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.rtbOutput = New System.Windows.Forms.RichTextBox()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(85, 143)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(532, 36)
        Me.btnHitung.TabIndex = 14
        Me.btnHitung.Text = "Hitung Rata-Rata Nilai"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(457, 81)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(160, 36)
        Me.btnBrowse.TabIndex = 13
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'tbFile
        '
        Me.tbFile.Location = New System.Drawing.Point(85, 83)
        Me.tbFile.MinimumSize = New System.Drawing.Size(340, 36)
        Me.tbFile.Name = "tbFile"
        Me.tbFile.ReadOnly = True
        Me.tbFile.Size = New System.Drawing.Size(340, 36)
        Me.tbFile.TabIndex = 12
        '
        'lblOutput
        '
        Me.lblOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(7, 242)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(98, 27)
        Me.lblOutput.TabIndex = 11
        Me.lblOutput.Text = "Output:"
        '
        'rtbOutput
        '
        Me.rtbOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbOutput.Location = New System.Drawing.Point(12, 272)
        Me.rtbOutput.MinimumSize = New System.Drawing.Size(4, 226)
        Me.rtbOutput.Name = "rtbOutput"
        Me.rtbOutput.ReadOnly = True
        Me.rtbOutput.Size = New System.Drawing.Size(880, 226)
        Me.rtbOutput.TabIndex = 10
        Me.rtbOutput.Text = ""
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(7, 86)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(50, 27)
        Me.lblFile.TabIndex = 9
        Me.lblFile.Text = "File"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 15.88235!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(137, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(624, 37)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "Aplikasi Perhitungan Rata-Rata Nilai Siswa"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 510)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.tbFile)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.rtbOutput)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.17647!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "Main"
        Me.Text = "Aplikasi Perhitungan Rata-Rata Nilai Siswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents tbFile As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents rtbOutput As RichTextBox
    Friend WithEvents lblFile As Label
    Friend WithEvents lblTitle As Label
End Class
