<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COM_UNITE
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
        Me.txt_id_unite = New System.Windows.Forms.TextBox()
        Me.Btn_quiter = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.Btn_nouveau = New System.Windows.Forms.Button()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_Enregistrer = New System.Windows.Forms.Button()
        Me.Txt_lib_unite = New System.Windows.Forms.TextBox()
        Me.Lab_Inti = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_r = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_ccp_unite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_id_unite
        '
        Me.txt_id_unite.Enabled = False
        Me.txt_id_unite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id_unite.Location = New System.Drawing.Point(156, 28)
        Me.txt_id_unite.Name = "txt_id_unite"
        Me.txt_id_unite.Size = New System.Drawing.Size(88, 22)
        Me.txt_id_unite.TabIndex = 7
        '
        'Btn_quiter
        '
        Me.Btn_quiter.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_quiter.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_quiter.Location = New System.Drawing.Point(269, 179)
        Me.Btn_quiter.Name = "Btn_quiter"
        Me.Btn_quiter.Size = New System.Drawing.Size(161, 63)
        Me.Btn_quiter.TabIndex = 17
        Me.Btn_quiter.Text = "Quitter"
        Me.Btn_quiter.UseVisualStyleBackColor = True
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Modifier.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modifier.Location = New System.Drawing.Point(269, 101)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Modifier.TabIndex = 18
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'Btn_nouveau
        '
        Me.Btn_nouveau.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_nouveau.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nouveau.Location = New System.Drawing.Point(13, 27)
        Me.Btn_nouveau.Name = "Btn_nouveau"
        Me.Btn_nouveau.Size = New System.Drawing.Size(161, 63)
        Me.Btn_nouveau.TabIndex = 6
        Me.Btn_nouveau.Text = "Nouvelle"
        Me.Btn_nouveau.UseVisualStyleBackColor = False
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.Enabled = False
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supprimer.Location = New System.Drawing.Point(14, 101)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Supprimer.TabIndex = 14
        Me.Btn_Supprimer.Text = "Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Enabled = False
        Me.Btn_Annuler.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.Location = New System.Drawing.Point(14, 179)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Annuler.TabIndex = 15
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.Enabled = False
        Me.Btn_Enregistrer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(269, 27)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Enregistrer.TabIndex = 16
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = True
        '
        'Txt_lib_unite
        '
        Me.Txt_lib_unite.Enabled = False
        Me.Txt_lib_unite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lib_unite.Location = New System.Drawing.Point(121, 12)
        Me.Txt_lib_unite.MaxLength = 20
        Me.Txt_lib_unite.Name = "Txt_lib_unite"
        Me.Txt_lib_unite.Size = New System.Drawing.Size(314, 22)
        Me.Txt_lib_unite.TabIndex = 0
        '
        'Lab_Inti
        '
        Me.Lab_Inti.AutoSize = True
        Me.Lab_Inti.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Inti.Location = New System.Drawing.Point(27, 15)
        Me.Lab_Inti.Name = "Lab_Inti"
        Me.Lab_Inti.Size = New System.Drawing.Size(48, 20)
        Me.Lab_Inti.TabIndex = 0
        Me.Lab_Inti.Text = "Libellé"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.Location = New System.Drawing.Point(13, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 322)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_r
        '
        Me.tb_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_r.Location = New System.Drawing.Point(127, 36)
        Me.tb_r.Name = "tb_r"
        Me.tb_r.Size = New System.Drawing.Size(188, 22)
        Me.tb_r.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_id_unite)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(467, 81)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Code unité"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_ccp_unite)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Txt_lib_unite)
        Me.GroupBox2.Controls.Add(Me.Lab_Inti)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 102)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(467, 81)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'Txt_ccp_unite
        '
        Me.Txt_ccp_unite.Enabled = False
        Me.Txt_ccp_unite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ccp_unite.Location = New System.Drawing.Point(121, 46)
        Me.Txt_ccp_unite.MaxLength = 24
        Me.Txt_ccp_unite.Name = "Txt_ccp_unite"
        Me.Txt_ccp_unite.Size = New System.Drawing.Size(181, 22)
        Me.Txt_ccp_unite.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RIB de l'unité"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_Supprimer)
        Me.GroupBox3.Controls.Add(Me.Btn_Enregistrer)
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.Btn_quiter)
        Me.GroupBox3.Controls.Add(Me.Btn_nouveau)
        Me.GroupBox3.Controls.Add(Me.Btn_Modifier)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 187)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(467, 251)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.tb_r)
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(482, 21)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(401, 417)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recherche"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(80, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Unité"
        '
        'COM_UNITE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(894, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "COM_UNITE"
        Me.Text = "Codification des unités des FAR"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_quiter As System.Windows.Forms.Button
    Friend WithEvents Btn_Modifier As System.Windows.Forms.Button
    Friend WithEvents Btn_nouveau As System.Windows.Forms.Button
    Friend WithEvents Btn_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents Btn_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents Txt_lib_unite As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Inti As System.Windows.Forms.Label
    Friend WithEvents txt_id_unite As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tb_r As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_ccp_unite As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
