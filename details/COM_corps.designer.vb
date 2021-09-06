<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COM_corps
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_quiter = New System.Windows.Forms.Button()
        Me.Btn_Modifier = New System.Windows.Forms.Button()
        Me.Btn_nouveau = New System.Windows.Forms.Button()
        Me.Btn_Supprimer = New System.Windows.Forms.Button()
        Me.Btn_Annuler = New System.Windows.Forms.Button()
        Me.Btn_Enregistrer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txt_cod_corps_a = New System.Windows.Forms.TextBox()
        Me.Lab_Compt_Num = New System.Windows.Forms.Label()
        Me.cbx_typ_corps = New System.Windows.Forms.ComboBox()
        Me.cbx_int = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_nom_off_det = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_nom_off_mat = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_nom_off_ord = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_nom_off_osm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_nom_chefsadmin = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_nom_chefdecorps = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_implantation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ccp_corps = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_lib_corps = New System.Windows.Forms.TextBox()
        Me.Lab_Inti = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1160, 648)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1152, 617)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Saisie"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Btn_quiter)
        Me.GroupBox3.Controls.Add(Me.Btn_Modifier)
        Me.GroupBox3.Controls.Add(Me.Btn_nouveau)
        Me.GroupBox3.Controls.Add(Me.Btn_Supprimer)
        Me.GroupBox3.Controls.Add(Me.Btn_Annuler)
        Me.GroupBox3.Controls.Add(Me.Btn_Enregistrer)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(86, 506)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(974, 90)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Btn_quiter
        '
        Me.Btn_quiter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_quiter.ForeColor = System.Drawing.Color.Maroon
        Me.Btn_quiter.Location = New System.Drawing.Point(795, 24)
        Me.Btn_quiter.Name = "Btn_quiter"
        Me.Btn_quiter.Size = New System.Drawing.Size(133, 43)
        Me.Btn_quiter.TabIndex = 17
        Me.Btn_quiter.Text = "Quitter"
        Me.Btn_quiter.UseVisualStyleBackColor = True
        '
        'Btn_Modifier
        '
        Me.Btn_Modifier.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_Modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modifier.Location = New System.Drawing.Point(179, 24)
        Me.Btn_Modifier.Name = "Btn_Modifier"
        Me.Btn_Modifier.Size = New System.Drawing.Size(111, 44)
        Me.Btn_Modifier.TabIndex = 18
        Me.Btn_Modifier.Text = "Modifier"
        Me.Btn_Modifier.UseVisualStyleBackColor = False
        '
        'Btn_nouveau
        '
        Me.Btn_nouveau.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Btn_nouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nouveau.Location = New System.Drawing.Point(28, 23)
        Me.Btn_nouveau.Name = "Btn_nouveau"
        Me.Btn_nouveau.Size = New System.Drawing.Size(111, 44)
        Me.Btn_nouveau.TabIndex = 6
        Me.Btn_nouveau.Text = "Nouveau"
        Me.Btn_nouveau.UseVisualStyleBackColor = False
        '
        'Btn_Supprimer
        '
        Me.Btn_Supprimer.Enabled = False
        Me.Btn_Supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Supprimer.Location = New System.Drawing.Point(458, 24)
        Me.Btn_Supprimer.Name = "Btn_Supprimer"
        Me.Btn_Supprimer.Size = New System.Drawing.Size(111, 43)
        Me.Btn_Supprimer.TabIndex = 14
        Me.Btn_Supprimer.Text = "Supprimer"
        Me.Btn_Supprimer.UseVisualStyleBackColor = True
        '
        'Btn_Annuler
        '
        Me.Btn_Annuler.Enabled = False
        Me.Btn_Annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Annuler.Location = New System.Drawing.Point(628, 24)
        Me.Btn_Annuler.Name = "Btn_Annuler"
        Me.Btn_Annuler.Size = New System.Drawing.Size(111, 43)
        Me.Btn_Annuler.TabIndex = 15
        Me.Btn_Annuler.Text = "Annuler"
        Me.Btn_Annuler.UseVisualStyleBackColor = True
        '
        'Btn_Enregistrer
        '
        Me.Btn_Enregistrer.Enabled = False
        Me.Btn_Enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Enregistrer.Location = New System.Drawing.Point(309, 24)
        Me.Btn_Enregistrer.Name = "Btn_Enregistrer"
        Me.Btn_Enregistrer.Size = New System.Drawing.Size(111, 43)
        Me.Btn_Enregistrer.TabIndex = 16
        Me.Btn_Enregistrer.Text = "Enregistrer"
        Me.Btn_Enregistrer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txt_cod_corps_a)
        Me.GroupBox2.Controls.Add(Me.Lab_Compt_Num)
        Me.GroupBox2.Controls.Add(Me.cbx_typ_corps)
        Me.GroupBox2.Controls.Add(Me.cbx_int)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_nom_off_det)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_nom_off_mat)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_nom_off_ord)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_nom_off_osm)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_nom_chefsadmin)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_nom_chefdecorps)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_implantation)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_ccp_corps)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Txt_lib_corps)
        Me.GroupBox2.Controls.Add(Me.Lab_Inti)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(84, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1012, 475)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Txt_cod_corps_a
        '
        Me.Txt_cod_corps_a.Enabled = False
        Me.Txt_cod_corps_a.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cod_corps_a.Location = New System.Drawing.Point(238, 40)
        Me.Txt_cod_corps_a.MaxLength = 15
        Me.Txt_cod_corps_a.Name = "Txt_cod_corps_a"
        Me.Txt_cod_corps_a.Size = New System.Drawing.Size(217, 22)
        Me.Txt_cod_corps_a.TabIndex = 0
        '
        'Lab_Compt_Num
        '
        Me.Lab_Compt_Num.AutoSize = True
        Me.Lab_Compt_Num.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Compt_Num.Location = New System.Drawing.Point(26, 41)
        Me.Lab_Compt_Num.Name = "Lab_Compt_Num"
        Me.Lab_Compt_Num.Size = New System.Drawing.Size(49, 18)
        Me.Lab_Compt_Num.TabIndex = 0
        Me.Lab_Compt_Num.Text = "Corps"
        '
        'cbx_typ_corps
        '
        Me.cbx_typ_corps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_typ_corps.FormattingEnabled = True
        Me.cbx_typ_corps.Items.AddRange(New Object() {"BATAILLON", "BRIGADE", "REGIMENT"})
        Me.cbx_typ_corps.Location = New System.Drawing.Point(236, 96)
        Me.cbx_typ_corps.Name = "cbx_typ_corps"
        Me.cbx_typ_corps.Size = New System.Drawing.Size(219, 26)
        Me.cbx_typ_corps.TabIndex = 2
        '
        'cbx_int
        '
        Me.cbx_int.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_int.FormattingEnabled = True
        Me.cbx_int.Location = New System.Drawing.Point(236, 185)
        Me.cbx_int.Name = "cbx_int"
        Me.cbx_int.Size = New System.Drawing.Size(222, 26)
        Me.cbx_int.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(30, 281)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(162, 18)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Chef de corps de l'unité"
        '
        'txt_nom_off_det
        '
        Me.txt_nom_off_det.Enabled = False
        Me.txt_nom_off_det.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_off_det.Location = New System.Drawing.Point(236, 420)
        Me.txt_nom_off_det.MaxLength = 50
        Me.txt_nom_off_det.Name = "txt_nom_off_det"
        Me.txt_nom_off_det.Size = New System.Drawing.Size(362, 22)
        Me.txt_nom_off_det.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 421)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 18)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "Officier trésorier"
        '
        'txt_nom_off_mat
        '
        Me.txt_nom_off_mat.Enabled = False
        Me.txt_nom_off_mat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_off_mat.Location = New System.Drawing.Point(236, 392)
        Me.txt_nom_off_mat.MaxLength = 50
        Me.txt_nom_off_mat.Name = "txt_nom_off_mat"
        Me.txt_nom_off_mat.Size = New System.Drawing.Size(362, 22)
        Me.txt_nom_off_mat.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(30, 393)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(147, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Officier des matériels"
        '
        'txt_nom_off_ord
        '
        Me.txt_nom_off_ord.Enabled = False
        Me.txt_nom_off_ord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_off_ord.Location = New System.Drawing.Point(236, 365)
        Me.txt_nom_off_ord.MaxLength = 50
        Me.txt_nom_off_ord.Name = "txt_nom_off_ord"
        Me.txt_nom_off_ord.Size = New System.Drawing.Size(362, 22)
        Me.txt_nom_off_ord.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Officier d'ordinaire"
        '
        'txt_nom_off_osm
        '
        Me.txt_nom_off_osm.Enabled = False
        Me.txt_nom_off_osm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_off_osm.Location = New System.Drawing.Point(236, 336)
        Me.txt_nom_off_osm.MaxLength = 50
        Me.txt_nom_off_osm.Name = "txt_nom_off_osm"
        Me.txt_nom_off_osm.Size = New System.Drawing.Size(362, 22)
        Me.txt_nom_off_osm.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(30, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Officier de Sécurité Militaire"
        '
        'txt_nom_chefsadmin
        '
        Me.txt_nom_chefsadmin.Enabled = False
        Me.txt_nom_chefsadmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_chefsadmin.Location = New System.Drawing.Point(237, 307)
        Me.txt_nom_chefsadmin.MaxLength = 50
        Me.txt_nom_chefsadmin.Name = "txt_nom_chefsadmin"
        Me.txt_nom_chefsadmin.Size = New System.Drawing.Size(361, 22)
        Me.txt_nom_chefsadmin.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(31, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 18)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Chef des Sces administratifs"
        '
        'txt_nom_chefdecorps
        '
        Me.txt_nom_chefdecorps.Enabled = False
        Me.txt_nom_chefdecorps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nom_chefdecorps.Location = New System.Drawing.Point(236, 280)
        Me.txt_nom_chefdecorps.MaxLength = 50
        Me.txt_nom_chefdecorps.Name = "txt_nom_chefdecorps"
        Me.txt_nom_chefdecorps.Size = New System.Drawing.Size(362, 22)
        Me.txt_nom_chefdecorps.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Intendance de Ratachement"
        '
        'txt_implantation
        '
        Me.txt_implantation.Enabled = False
        Me.txt_implantation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_implantation.Location = New System.Drawing.Point(236, 157)
        Me.txt_implantation.MaxLength = 15
        Me.txt_implantation.Name = "txt_implantation"
        Me.txt_implantation.Size = New System.Drawing.Size(220, 22)
        Me.txt_implantation.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Implantation"
        '
        'txt_ccp_corps
        '
        Me.txt_ccp_corps.Enabled = False
        Me.txt_ccp_corps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ccp_corps.Location = New System.Drawing.Point(236, 129)
        Me.txt_ccp_corps.MaxLength = 24
        Me.txt_ccp_corps.Name = "txt_ccp_corps"
        Me.txt_ccp_corps.Size = New System.Drawing.Size(220, 22)
        Me.txt_ccp_corps.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RIP C.C.P"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Type"
        '
        'Txt_lib_corps
        '
        Me.Txt_lib_corps.Enabled = False
        Me.Txt_lib_corps.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_lib_corps.Location = New System.Drawing.Point(236, 68)
        Me.Txt_lib_corps.MaxLength = 50
        Me.Txt_lib_corps.Name = "Txt_lib_corps"
        Me.Txt_lib_corps.Size = New System.Drawing.Size(478, 22)
        Me.Txt_lib_corps.TabIndex = 1
        '
        'Lab_Inti
        '
        Me.Lab_Inti.AutoSize = True
        Me.Lab_Inti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Inti.Location = New System.Drawing.Point(26, 69)
        Me.Lab_Inti.Name = "Lab_Inti"
        Me.Lab_Inti.Size = New System.Drawing.Size(49, 18)
        Me.Lab_Inti.TabIndex = 0
        Me.Lab_Inti.Text = "Libellé"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightGray
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1152, 617)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Affichage"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1080, 593)
        Me.DataGridView1.TabIndex = 0
        '
        'COM_corps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "COM_corps"
        Me.Text = "CORPS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_quiter As System.Windows.Forms.Button
    Friend WithEvents Btn_Modifier As System.Windows.Forms.Button
    Friend WithEvents Btn_nouveau As System.Windows.Forms.Button
    Friend WithEvents Btn_Supprimer As System.Windows.Forms.Button
    Friend WithEvents Btn_Annuler As System.Windows.Forms.Button
    Friend WithEvents Btn_Enregistrer As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_lib_corps As System.Windows.Forms.TextBox
    Friend WithEvents Lab_Inti As System.Windows.Forms.Label
    Friend WithEvents Lab_Compt_Num As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Txt_cod_corps_a As System.Windows.Forms.TextBox
    Friend WithEvents txt_implantation As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_ccp_corps As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbx_int As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_off_det As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_off_mat As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_off_ord As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_off_osm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_chefsadmin As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_nom_chefdecorps As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbx_typ_corps As System.Windows.Forms.ComboBox

End Class
