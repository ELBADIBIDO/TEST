<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class com_intendance
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_r = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Enregistrer = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_quiter = New System.Windows.Forms.Button()
        Me.Btn_nouveau = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_lib_int = New System.Windows.Forms.TextBox()
        Me.Lab_Inti = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cod_int = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.tb_r)
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(563, 16)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(316, 421)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recherche"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.Location = New System.Drawing.Point(7, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(304, 340)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_r
        '
        Me.tb_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_r.Location = New System.Drawing.Point(72, 37)
        Me.tb_r.Name = "tb_r"
        Me.tb_r.Size = New System.Drawing.Size(188, 22)
        Me.tb_r.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox3.Controls.Add(Me.Btn_Supprimer)
        Me.GroupBox3.Controls.Add(Me.Btn_Enregistrer)
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.Btn_quiter)
        Me.GroupBox3.Controls.Add(Me.Btn_nouveau)
        Me.GroupBox3.Controls.Add(Me.Btn_Modifier)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 149)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(539, 283)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.Enabled = False
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supprimer.ForeColor = System.Drawing.Color.Black
        Me.Btn_Supprimer.Location = New System.Drawing.Point(64, 113)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Supprimer.TabIndex = 14
        Me.Btn_Supprimer.Text = "Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = True
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.Enabled = False
        Me.Btn_Enregistrer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enregistrer.ForeColor = System.Drawing.Color.Black
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(312, 113)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Enregistrer.TabIndex = 16
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Enabled = False
        Me.Btn_Annuler.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.ForeColor = System.Drawing.Color.Black
        Me.Btn_Annuler.Location = New System.Drawing.Point(64, 196)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Annuler.TabIndex = 15
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'Btn_quiter
        '
        Me.Btn_quiter.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_quiter.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_quiter.Location = New System.Drawing.Point(312, 196)
        Me.Btn_quiter.Name = "Btn_quiter"
        Me.Btn_quiter.Size = New System.Drawing.Size(161, 63)
        Me.Btn_quiter.TabIndex = 17
        Me.Btn_quiter.Text = "Quitter"
        Me.Btn_quiter.UseVisualStyleBackColor = True
        '
        'Btn_nouveau
        '
        Me.Btn_nouveau.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_nouveau.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nouveau.ForeColor = System.Drawing.Color.Black
        Me.Btn_nouveau.Location = New System.Drawing.Point(66, 27)
        Me.Btn_nouveau.Name = "Btn_nouveau"
        Me.Btn_nouveau.Size = New System.Drawing.Size(161, 63)
        Me.Btn_nouveau.TabIndex = 6
        Me.Btn_nouveau.Text = "Nouvelle"
        Me.Btn_nouveau.UseVisualStyleBackColor = False
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Modifier.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modifier.ForeColor = System.Drawing.Color.Black
        Me.Btn_Modifier.Location = New System.Drawing.Point(312, 27)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Modifier.TabIndex = 18
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Controls.Add(Me.Txt_lib_int)
        Me.GroupBox2.Controls.Add(Me.Lab_Inti)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 65)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(539, 66)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Txt_lib_int
        '
        Me.Txt_lib_int.Enabled = False
        Me.Txt_lib_int.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lib_int.Location = New System.Drawing.Point(111, 23)
        Me.Txt_lib_int.MaxLength = 40
        Me.Txt_lib_int.Name = "Txt_lib_int"
        Me.Txt_lib_int.Size = New System.Drawing.Size(280, 22)
        Me.Txt_lib_int.TabIndex = 0
        '
        'Lab_Inti
        '
        Me.Lab_Inti.AutoSize = True
        Me.Lab_Inti.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Inti.ForeColor = System.Drawing.Color.Maroon
        Me.Lab_Inti.Location = New System.Drawing.Point(35, 0)
        Me.Lab_Inti.Name = "Lab_Inti"
        Me.Lab_Inti.Size = New System.Drawing.Size(48, 20)
        Me.Lab_Inti.TabIndex = 0
        Me.Lab_Inti.Text = "Libellé"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Controls.Add(Me.txt_cod_int)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(11, 6)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(539, 55)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Code Intendance"
        '
        'txt_cod_int
        '
        Me.txt_cod_int.Enabled = False
        Me.txt_cod_int.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_int.Location = New System.Drawing.Point(111, 23)
        Me.txt_cod_int.Name = "txt_cod_int"
        Me.txt_cod_int.Size = New System.Drawing.Size(88, 22)
        Me.txt_cod_int.TabIndex = 7
        '
        'com_intendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(890, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "com_intendance"
        Me.Text = "Codification Intendance de rattachement"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tb_r As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents Btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents Btn_quiter As System.Windows.Forms.Button
    Friend WithEvents Btn_nouveau As System.Windows.Forms.Button
    Friend WithEvents Btn_Modifier As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_lib_int As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Inti As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cod_int As System.Windows.Forms.TextBox
End Class
