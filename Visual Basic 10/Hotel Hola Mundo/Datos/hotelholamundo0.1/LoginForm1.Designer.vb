<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class frmpantalladeinicio
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
    Friend WithEvents lpicinicio As System.Windows.Forms.PictureBox
    Friend WithEvents txtuser As System.Windows.Forms.TextBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents cmdok As System.Windows.Forms.Button
    Friend WithEvents cmdcancelar As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpantalladeinicio))
        Me.lpicinicio = New System.Windows.Forms.PictureBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.cmdok = New System.Windows.Forms.Button()
        Me.cmdcancelar = New System.Windows.Forms.Button()
        CType(Me.lpicinicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lpicinicio
        '
        Me.lpicinicio.Image = CType(resources.GetObject("lpicinicio.Image"), System.Drawing.Image)
        Me.lpicinicio.Location = New System.Drawing.Point(-4, 12)
        Me.lpicinicio.Name = "lpicinicio"
        Me.lpicinicio.Size = New System.Drawing.Size(335, 83)
        Me.lpicinicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lpicinicio.TabIndex = 0
        Me.lpicinicio.TabStop = False
        '
        'txtuser
        '
        Me.txtuser.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuser.ForeColor = System.Drawing.Color.Peru
        Me.txtuser.Location = New System.Drawing.Point(65, 122)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(220, 26)
        Me.txtuser.TabIndex = 1
        Me.txtuser.Text = "Username"
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Peru
        Me.txtpassword.Location = New System.Drawing.Point(65, 186)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(220, 26)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.Text = "passsssssss"
        '
        'cmdok
        '
        Me.cmdok.BackColor = System.Drawing.Color.Bisque
        Me.cmdok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdok.Location = New System.Drawing.Point(65, 235)
        Me.cmdok.Name = "cmdok"
        Me.cmdok.Size = New System.Drawing.Size(202, 32)
        Me.cmdok.TabIndex = 4
        Me.cmdok.Text = "&LOGIN"
        Me.cmdok.UseVisualStyleBackColor = False
        '
        'cmdcancelar
        '
        Me.cmdcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdcancelar.Location = New System.Drawing.Point(239, 300)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(69, 23)
        Me.cmdcancelar.TabIndex = 5
        Me.cmdcancelar.Text = "&Cancel"
        '
        'frmpantalladeinicio
        '
        Me.AcceptButton = Me.cmdok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.cmdcancelar
        Me.ClientSize = New System.Drawing.Size(332, 335)
        Me.Controls.Add(Me.cmdcancelar)
        Me.Controls.Add(Me.cmdok)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.lpicinicio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmpantalladeinicio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOTEL HOLA MUNDO"
        CType(Me.lpicinicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
