<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COM_compagnie_de_solde
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
        Me.txt_cod_cie = New System.Windows.Forms.TextBox()
        Me.Btn_quiter = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.Btn_nouveau = New System.Windows.Forms.Button()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_Enregistrer = New System.Windows.Forms.Button()
        Me.Txt_lib_cie = New System.Windows.Forms.TextBox()
        Me.Lab_Inti = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tb_r = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbx_type_cie = New System.Windows.Forms.ComboBox()
        Me.Cbx_bataillon = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_cod_cie
        '
        Me.txt_cod_cie.Enabled = False
        Me.txt_cod_cie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_cie.Location = New System.Drawing.Point(125, 23)
        Me.txt_cod_cie.Name = "txt_cod_cie"
        Me.txt_cod_cie.Size = New System.Drawing.Size(88, 22)
        Me.txt_cod_cie.TabIndex = 7
        '
        'Btn_quiter
        '
        Me.Btn_quiter.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_quiter.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_quiter.Location = New System.Drawing.Point(306, 166)
        Me.Btn_quiter.Name = "Btn_quiter"
        Me.Btn_quiter.Size = New System.Drawing.Size(161, 63)
        Me.Btn_quiter.TabIndex = 17
        Me.Btn_quiter.Text = "Quitter"
        Me.Btn_quiter.UseVisualStyleBackColor = True
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Modifier.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_Modifier.Location = New System.Drawing.Point(306, 92)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Modifier.TabIndex = 18
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'Btn_nouveau
        '
        Me.Btn_nouveau.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_nouveau.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_nouveau.Location = New System.Drawing.Point(35, 18)
        Me.Btn_nouveau.Name = "Btn_nouveau"
        Me.Btn_nouveau.Size = New System.Drawing.Size(161, 63)
        Me.Btn_nouveau.TabIndex = 6
        Me.Btn_nouveau.Text = "Nouvelle"
        Me.Btn_nouveau.UseVisualStyleBackColor = False
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.Enabled = False
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_Supprimer.Location = New System.Drawing.Point(35, 92)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Supprimer.TabIndex = 14
        Me.Btn_Supprimer.Text = "Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Enabled = False
        Me.Btn_Annuler.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_Annuler.Location = New System.Drawing.Point(35, 166)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Annuler.TabIndex = 15
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.Enabled = False
        Me.Btn_Enregistrer.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(306, 18)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(161, 63)
        Me.Btn_Enregistrer.TabIndex = 16
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = True
        '
        'Txt_lib_cie
        '
        Me.Txt_lib_cie.Enabled = False
        Me.Txt_lib_cie.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lib_cie.Location = New System.Drawing.Point(124, 18)
        Me.Txt_lib_cie.MaxLength = 40
        Me.Txt_lib_cie.Name = "Txt_lib_cie"
        Me.Txt_lib_cie.Size = New System.Drawing.Size(241, 22)
        Me.Txt_lib_cie.TabIndex = 0
        '
        'Lab_Inti
        '
        Me.Lab_Inti.AutoSize = True
        Me.Lab_Inti.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Lab_Inti.Location = New System.Drawing.Point(31, 20)
        Me.Lab_Inti.Name = "Lab_Inti"
        Me.Lab_Inti.Size = New System.Drawing.Size(48, 20)
        Me.Lab_Inti.TabIndex = 3
        Me.Lab_Inti.Text = "Libellé"
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
        Me.DataGridView1.Size = New System.Drawing.Size(358, 334)
        Me.DataGridView1.TabIndex = 0
        '
        'tb_r
        '
        Me.tb_r.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_r.Location = New System.Drawing.Point(82, 28)
        Me.tb_r.Name = "tb_r"
        Me.tb_r.Size = New System.Drawing.Size(205, 22)
        Me.tb_r.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cod_cie)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(16, 21)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(493, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Code compagnie"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbx_type_cie)
        Me.GroupBox2.Controls.Add(Me.Cbx_bataillon)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Txt_lib_cie)
        Me.GroupBox2.Controls.Add(Me.Lab_Inti)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(493, 120)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cbx_type_cie
        '
        Me.cbx_type_cie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_type_cie.Enabled = False
        Me.cbx_type_cie.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbx_type_cie.FormattingEnabled = True
        Me.cbx_type_cie.Items.AddRange(New Object() {"SM", "SSP", "SMNR", "APPELE", "RAPPELE", "AUTRE"})
        Me.cbx_type_cie.Location = New System.Drawing.Point(124, 48)
        Me.cbx_type_cie.Name = "cbx_type_cie"
        Me.cbx_type_cie.Size = New System.Drawing.Size(170, 21)
        Me.cbx_type_cie.TabIndex = 1
        '
        'Cbx_bataillon
        '
        Me.Cbx_bataillon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbx_bataillon.Enabled = False
        Me.Cbx_bataillon.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_bataillon.FormattingEnabled = True
        Me.Cbx_bataillon.Location = New System.Drawing.Point(125, 78)
        Me.Cbx_bataillon.Name = "Cbx_bataillon"
        Me.Cbx_bataillon.Size = New System.Drawing.Size(170, 21)
        Me.Cbx_bataillon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(31, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bataillon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(31, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Type"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_Supprimer)
        Me.GroupBox3.Controls.Add(Me.Btn_Enregistrer)
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.Btn_quiter)
        Me.GroupBox3.Controls.Add(Me.Btn_nouveau)
        Me.GroupBox3.Controls.Add(Me.Btn_Modifier)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 204)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(493, 237)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.tb_r)
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Demi Cond", 11.25!)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox4.Location = New System.Drawing.Point(513, 26)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(370, 415)
        Me.GroupBox4.TabIndex = 22
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Recherche"
        '
        'COM_compagnie_de_solde
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
        Me.Name = "COM_compagnie_de_solde"
        Me.Text = "Codification des Compagnies"
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
    Friend WithEvents Txt_lib_cie As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Inti As System.Windows.Forms.Label
    Friend WithEvents txt_cod_cie As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tb_r As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Cbx_bataillon As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_type_cie As System.Windows.Forms.ComboBox
End Class
