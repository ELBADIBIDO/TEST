Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports WindowsApplication1.MAJCNIE
Public Class COM_MDItresorier
    Dim appDataPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    'Dim macc As String = getMacAddress()

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private Sub cache_menu()
        Pict_cache_gen.Visible = True
        Pict_menu.Visible = False
        GB_login.Visible = False
        'PictureBox1.Visible = False
        'Pict_gif.Visible = False
        Bt_quitter.Visible = False
        Label4.Visible = False
    End Sub
    Private Sub visible_menu()
        Pict_cache_gen.Visible = False
        Pict_menu.Visible = True
        GB_login.Visible = True
        'PictureBox1.Visible = True
        'Pict_gif.Visible = True
        Label4.Visible = True
    End Sub
    Private Sub Btn_quitter_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Bbtn_seconnecter1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_seconnecter1.Click

        On Error Resume Next
        dr.Close()

        'If xyatelier = "" Then
        '    MsgBox("Choisir un atelier de travail")
        '    Return
        'End If
        xynom = ""
        xyprofil = ""
        connection()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select nom, profil from utilisateur  where pwd='" & txt_motdepasse.Text.ToUpper & "'" &
        " and nom='" & cb_login.SelectedValue & "'"
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            dr.Read()
            'Call verification()
            xynom = dr(0)
            xyprofil = dr(1)

            If dr(1) = True Then
                        dr.Close()
                        cnn.Close()

                        Menu_ssp.Visible = True
                        If xyprofil = "administrateur" Then
                            ' JOURNALISATIONToolStripMenuItem.Visible = True
                        End If
                        cache_menu()
                    Else
                        MsgBox("Accès impossible à cet atelier..!!! ")
                    End If


        Else
            MsgBox("Mot de passe incorrect..!!! réessayez")
        End If
        txt_motdepasse.Text = ""
        dr.Close()
        cnn.Close()

    End Sub


    Private Sub MDItresorier_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        'Select Case xyatelier

        '    Case "SSP"
        Menu_ssp.Visible = True

        'End Select

    End Sub


    Private Sub MDIprincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name

        '------------------------------------
        'Dim ad1, ad2, ad3, ad4 As String
        'ad1 = Address_mac()
        'ad3 = convertir_chaine_ascii(ad1)
        'ad2 = ""
        'ad4 = convertir_ascii_chaine(ad3)
        'req = "select IIF(isnull(nom),'',nom) from espion"
        'cmd.CommandText = req
        'dr = cmd.ExecuteReader
        'If dr.HasRows Then
        '    dr.Read()
        '    ad2 = dr(0)
        'End If
        'dr.Close()
        ' ad5 = lecture_adresse_mac(ad1)

        'If ad2 = "" Then
        '    req = "insert into espion (nom) values ('" & ad1 & "')"
        '    enregistrer(req)
        '    '    ecriture_adresse_mac(ad1)
        'Else
        '    'If ad2 <> ad1 Or ad1 <> ad5 Then
        '    If ad2 <> ad1 Then
        '        MsgBox("Application non installée sur ce poste")
        '        Button3_Click(sender, e)
        '        Return
        '    Else
        '        '--------------------------
        '        'req = "select distinct nom from utilisateur"
        '        'charger_combobox(maform, req, cb_login, "nom", "nom")
        '        'txt_motdepasse.Focus()
        '        'cnn.Close()
        '        'Menu_den.Visible = False
        '        'Menu_dep.Visible = False
        '        'Menu_imp.Visible = False
        '        'Menu_sm.Visible = False
        '        'Menu_ssp.Visible = False
        '        'Pict_cache_gen.Enabled = True
        '        ''----------------------------------
        '    End If
        'End If

        req = "select distinct nom from utilisateur"
        charger_combobox(maform, req, cb_login, "nom", "nom")
        txt_motdepasse.Focus()

        cnn.Close()

        Menu_ssp.Visible = False
        Pict_cache_gen.Visible = True
    End Sub

    Private Sub MDItresorier_MdiChildActivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MdiChildActivate


        Menu_ssp.Visible = False

    End Sub


    Private Sub btn_den_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_MouseLeave(sender, e)
    End Sub

    Private Sub btn_den_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        btn_MouseMove(sender, e)
    End Sub
    Private Sub btn_ssp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_MouseLeave(sender, e)
    End Sub

    Private Sub btn_ssp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        btn_MouseMove(sender, e)
    End Sub

    Private Sub btn_sm_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_MouseLeave(sender, e)
    End Sub

    Private Sub btn_sm_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        btn_MouseMove(sender, e)
    End Sub
    Private Sub btn_dep_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_MouseLeave(sender, e)
    End Sub

    Private Sub btn_dep_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        btn_MouseMove(sender, e)
    End Sub

    Private Sub btn_imp_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        btn_MouseLeave(sender, e)
    End Sub

    Private Sub btn_imp_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        btn_MouseMove(sender, e)
    End Sub

    Private Sub btn_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.Height = 180
        sender.Width = 120
    End Sub
    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        sender.Height = 160
        sender.Width = 120
    End Sub





    Private Sub AvoirCorpsDeTroupeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_corps As New COM_corps
        fen_corps.MdiParent = Me
        fen_corps.StartPosition = FormStartPosition.CenterScreen
        fen_corps.Show()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        xyatelier = ""
        visible_menu()
        Bt_quitter.Visible = True
    End Sub


    Private Sub cb_login_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_login.Validated
        txt_motdepasse.Focus()
    End Sub


    Private Sub PersonnelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If xyprofil = "administrateur" Then
        Pict_cache_gen.Visible = False
        Dim fen_COM_personnel As New COM_personnel_cin
        fen_COM_personnel.MdiParent = Me
        fen_COM_personnel.StartPosition = FormStartPosition.CenterScreen
        fen_COM_personnel.Show()
        'Else
        '    MsgBox("Vous devez être administrateur de la base pour accedez au personnel")
        'End If

    End Sub

    Private Sub SeDéconnecterToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        xyatelier = ""
        visible_menu()
        Bt_quitter.Visible = True
    End Sub


    Private Sub PersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonnelToolStripMenuItem.Click
        'If xyprofil = "administrateur" Then
        Pict_cache_gen.Visible = False
        Dim fen_COM_personnel As New COM_personnel_cin
        fen_COM_personnel.MdiParent = Me
        fen_COM_personnel.StartPosition = FormStartPosition.CenterScreen
        fen_COM_personnel.Show()
        'Else
        '    MsgBox("Vous devez être administrateur de la base pour accedez au personnel")
        'End I
    End Sub

    Private Sub AjoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjoutToolStripMenuItem.Click
        Pict_cache_gen.Visible = False
        Dim fen_COM_corps As New COM_corps
        fen_COM_corps.MdiParent = Me
        fen_COM_corps.StartPosition = FormStartPosition.CenterScreen
        fen_COM_corps.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Pict_cache_gen.Visible = False
        Dim fen_COM_compagnie_de_solde As New COM_compagnie_de_solde
        fen_COM_compagnie_de_solde.MdiParent = Me
        fen_COM_compagnie_de_solde.StartPosition = FormStartPosition.CenterScreen
        fen_COM_compagnie_de_solde.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Pict_cache_gen.Visible = False
        Dim fen_COM_comagnie_de_service As New COM_compagnie_de_service
        fen_COM_comagnie_de_service.MdiParent = Me
        fen_COM_comagnie_de_service.StartPosition = FormStartPosition.CenterScreen
        fen_COM_comagnie_de_service.Show()
    End Sub


    Private Sub SeDéconnecterToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeDéconnecterToolStripMenuItem4.Click

        visible_menu()
        Bt_quitter.Visible = True
        Menu_ssp.Visible = False

        xyatelier = ""
    End Sub


    Private Sub BataillonDuCorpsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BataillonDuCorpsToolStripMenuItem.Click
        Pict_cache_gen.Visible = False
        Dim fen_COM_bataillon As New COM_bataillon
        fen_COM_bataillon.MdiParent = Me
        fen_COM_bataillon.StartPosition = FormStartPosition.CenterScreen
        fen_COM_bataillon.Show()
    End Sub

    Private Sub CorpsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_corps As New COM_corps
        fen_COM_corps.MdiParent = Me
        fen_COM_corps.StartPosition = FormStartPosition.CenterScreen
        fen_COM_corps.Show()
    End Sub

    Private Sub BataillonToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_bataillon As New COM_bataillon
        fen_COM_bataillon.MdiParent = Me
        fen_COM_bataillon.StartPosition = FormStartPosition.CenterScreen
        fen_COM_bataillon.Show()
    End Sub

    Private Sub CompagnieDeSoldeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_compagnie_de_solde As New COM_compagnie_de_solde
        fen_COM_compagnie_de_solde.MdiParent = Me
        fen_COM_compagnie_de_solde.StartPosition = FormStartPosition.CenterScreen
        fen_COM_compagnie_de_solde.Show()
    End Sub

    Private Sub CompagnieDeServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_comagnie_de_service As New COM_compagnie_de_service
        fen_COM_comagnie_de_service.MdiParent = Me
        fen_COM_comagnie_de_service.StartPosition = FormStartPosition.CenterScreen
        fen_COM_comagnie_de_service.Show()
    End Sub

    Private Sub IntendanceDeRattachementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntendanceDeRattachementToolStripMenuItem.Click
        Pict_cache_gen.Visible = False
        Dim fen_com_intendance As New com_intendance
        fen_com_intendance.MdiParent = Me
        fen_com_intendance.StartPosition = FormStartPosition.CenterScreen
        fen_com_intendance.Show()
    End Sub

    Private Sub IntendanceDeRattachementToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_com_intendance As New com_intendance
        fen_com_intendance.MdiParent = Me
        fen_com_intendance.StartPosition = FormStartPosition.CenterScreen
        fen_com_intendance.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim reponse As String
        ' If cb_login.Items.Count = 0 Then
        reponse = MsgBox("vous devez creér au moins un utilisateur ?", vbYesNo + vbCritical, "attention")
        If reponse = vbYes Then
            Dim fcom_administration_utilisateur As New com_administration_utilisateur
            fcom_administration_utilisateur.MdiParent = Me
            fcom_administration_utilisateur.StartPosition = FormStartPosition.CenterScreen
            fcom_administration_utilisateur.ShowDialog()
        End If
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        xyatelier = ""
        visible_menu()
        Bt_quitter.Visible = True
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_quitter.Click
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub btn_den_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xyatelier = "DENIERS"

        GB_login.Visible = True

        txt_motdepasse.Focus()
    End Sub

    Private Sub btn_sm_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xyatelier = "SM"

        GB_login.Visible = True
        activer(maform, GB_login)
        txt_motdepasse.Focus()
    End Sub

    Private Sub btn_imp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xyatelier = "IMPAYES"

        GB_login.Visible = True
        activer(maform, GB_login)
        txt_motdepasse.Focus()
    End Sub

    Private Sub btn_ssp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xyatelier = "SSP"

        GB_login.Visible = True
        activer(maform, GB_login)
        txt_motdepasse.Focus()
    End Sub

    Private Sub btn_dep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        xyatelier = "DEPLACEMENT"

        activer(maform, GB_login)
        txt_motdepasse.Focus()
    End Sub

    Private Sub SeDéconnecterToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        xyatelier = ""
        visible_menu()
        Bt_quitter.Visible = True
    End Sub


    Private Sub GestionDesUtilisateursToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Pict_cache_gen.Visible = False
        Dim fen_com_administration_utilisateur As New com_administration_utilisateur
        fen_com_administration_utilisateur.MdiParent = Me
        fen_com_administration_utilisateur.StartPosition = FormStartPosition.CenterScreen
        fen_com_administration_utilisateur.Show()

    End Sub

    Private Sub ModificationDesMotsDePasseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_modifier_mot_passe As New COM_modifier_mot_passe
        fen_COM_modifier_mot_passe.MdiParent = Me
        fen_COM_modifier_mot_passe.StartPosition = FormStartPosition.CenterScreen
        fen_COM_modifier_mot_passe.Show()
    End Sub

    Private Sub UnitéDeRattachementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitéDeRattachementToolStripMenuItem.Click
        Pict_cache_gen.Visible = False
        Dim fen_COM_UNITE As New COM_UNITE
        fen_COM_UNITE.MdiParent = Me
        fen_COM_UNITE.StartPosition = FormStartPosition.CenterScreen
        fen_COM_UNITE.Show()
    End Sub

    Private Sub UnitéDeRatachementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_UNITE As New COM_UNITE
        fen_COM_UNITE.MdiParent = Me
        fen_COM_UNITE.StartPosition = FormStartPosition.CenterScreen
        fen_COM_UNITE.Show()
    End Sub

    Private Sub SauvegardeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sauvegarde()
    End Sub


    Private Sub CompagnieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GestionDesUtilisaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Pict_cache_gen.Visible = False
        Dim fen_com_administration_utilisateur As New com_administration_utilisateur
        fen_com_administration_utilisateur.MdiParent = Me
        fen_com_administration_utilisateur.StartPosition = FormStartPosition.CenterScreen
        fen_com_administration_utilisateur.Show()
    End Sub

    Private Sub GestionDesUtilisateursToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Pict_cache_gen.Visible = False
        Dim fen_com_administration_utilisateur As New com_administration_utilisateur
        fen_com_administration_utilisateur.MdiParent = Me
        fen_com_administration_utilisateur.StartPosition = FormStartPosition.CenterScreen
        fen_com_administration_utilisateur.Show()
    End Sub



    Private Sub GestionDesUtilisateursToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestionDesUtilisateursToolStripMenuItem3.Click

        Pict_cache_gen.Visible = False
        Dim fen_com_administration_utilisateur As New com_administration_utilisateur
        fen_com_administration_utilisateur.MdiParent = Me
        fen_com_administration_utilisateur.StartPosition = FormStartPosition.CenterScreen
        fen_com_administration_utilisateur.Show()
    End Sub

    Private Sub ModificationDesMotsDePasseToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_modifier_mot_passe As New COM_modifier_mot_passe
        fen_COM_modifier_mot_passe.MdiParent = Me
        fen_COM_modifier_mot_passe.StartPosition = FormStartPosition.CenterScreen
        fen_COM_modifier_mot_passe.Show()
    End Sub

    Private Sub ModificationDesMotsDePasseToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_modifier_mot_passe As New COM_modifier_mot_passe
        fen_COM_modifier_mot_passe.MdiParent = Me
        fen_COM_modifier_mot_passe.StartPosition = FormStartPosition.CenterScreen
        fen_COM_modifier_mot_passe.Show()
    End Sub

    Private Sub ModificationDesMotsDePasseToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificationDesMotsDePasseToolStripMenuItem4.Click
        Pict_cache_gen.Visible = False
        Dim fen_COM_modifier_mot_passe As New COM_modifier_mot_passe
        fen_COM_modifier_mot_passe.MdiParent = Me
        fen_COM_modifier_mot_passe.StartPosition = FormStartPosition.CenterScreen
        fen_COM_modifier_mot_passe.Show()
    End Sub

    Private Sub ModificationDesMotsDePasseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_modifier_mot_passe As New COM_modifier_mot_passe
        fen_COM_modifier_mot_passe.MdiParent = Me
        fen_COM_modifier_mot_passe.StartPosition = FormStartPosition.CenterScreen
        fen_COM_modifier_mot_passe.Show()
    End Sub


    Private Sub SauvegardeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If xyprofil = "administrateur" Then
        Pict_cache_gen.Visible = False
        Dim fen_COM_personnel As New COM_personnel_cin
        fen_COM_personnel.MdiParent = Me
        fen_COM_personnel.StartPosition = FormStartPosition.CenterScreen
        fen_COM_personnel.Show()
        'Else
        '    MsgBox("Vous devez être administrateur de la base pour accedez au personnel")
        'End If

    End Sub

    Private Sub SauvegardeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sauvegarde()
    End Sub

    Private Sub SauvegardeToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sauvegarde()
    End Sub

    Private Sub SauvegardeToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SauvegardeToolStripMenuItem4.Click
        sauvegarde()
    End Sub


    Private Sub MAJPersonnelToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If xyprofil = "administrateur" Then
            Pict_cache_gen.Visible = False
            Dim fen_COM_personnel As New COM_personnel_cin
            fen_COM_personnel.MdiParent = Me
            fen_COM_personnel.StartPosition = FormStartPosition.CenterScreen
            fen_COM_personnel.Show()
        Else
            MsgBox("Vous devez être administrateur de la base pour accedez au personnel")
        End If
    End Sub





    Private Sub MAJDuPersonnelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Pict_cache_gen.Visible = False
        Dim fen_COM_personnel As New COM_personnel_cin
        fen_COM_personnel.MdiParent = Me
        fen_COM_personnel.StartPosition = FormStartPosition.CenterScreen
        fen_COM_personnel.Show()

    End Sub

    'Sub verification()

    '    If My.Computer.FileSystem.FileExists(appDataPath & "\syso.txt") Then

    '        File.SetAttributes(appDataPath & "\syso.txt", FileAttributes.Normal)

    '    End If
    '    If cnn.State = ConnectionState.Closed Then
    '        connection()
    '    End If

    '    Dim mac As String
    '    Dim pt As String

    '    Dim tmac As String
    '    Dim tpt As String

    '    tmac = "monmac"
    '    tpt = "monchemin"

    '    mac = getMacAddress()


    '    pt = Directory.GetCurrentDirectory()





    '    If cnn.State = ConnectionState.Closed Then
    '        connection()


    '    End If

    '    Dim rd As OleDbDataReader
    '    req = "Select mac from tr"
    '    Dim cmd2 = New OleDbCommand(req, cnn)
    '    Try
    '        rd = cmd2.ExecuteReader()


    '        If rd.HasRows Then

    '            Dim req4 As String

    '            req4 = "Select mac, pathe,pate from tr"
    '            Dim cmd4 = New OleDbCommand(req4, cnn)
    '            rd = cmd4.ExecuteReader()


    '            While rd.Read()
    '                If rd(0).ToString() <> mac Then

    '                    MsgBox("ERREUR DANS L'APPLICATION ADRESSE MAC")

    '                    Me.Close()
    '                End If

    '                If rd(1).ToString() <> pt Then

    '                    MsgBox("ERREUR DANS L'APPLICATION CHEMIN")
    '                    Me.Close()
    '                    Exit Sub
    '                End If

    '                If My.Computer.FileSystem.FileExists(appDataPath & "\syso.txt") Then

    '                    Dim Data As New IO.StreamReader(appDataPath & "\syso.txt")
    '                    Dim Ligne As String
    '                    '   Do
    '                    Ligne = Data.ReadLine()
    '                    Data.Close()

    '                    If Convert.ToInt32(Ligne) <> Convert.ToInt32(rd(2).ToString()) Then

    '                        MsgBox("ERREUR DANS L'APPLICATION BASE DE DONNEES")
    '                        Me.Close()
    '                        Exit Sub


    '                    Else
    '                        Dim vali As Integer
    '                        vali = Convert.ToInt32(rd(2).ToString()) + 1
    '                        Using fs As New FileStream(appDataPath & "\syso.txt", FileMode.Create, FileAccess.Write)
    '                            Using sw As New StreamWriter(fs)

    '                                sw.WriteLine((vali).ToString)
    '                                'sw.Close()
    '                            End Using

    '                        End Using

    '                        If cnn.State = ConnectionState.Closed Then
    '                            connection()
    '                        End If
    '                        Dim reqo3 = "Update tr SET pate ='" & vali.ToString & "'"
    '                        Dim cmd3 = New OleDbCommand(reqo3, cnn)

    '                        cmd3.ExecuteNonQuery()





    '                    End If


    '                End If

    '                Exit While
    '            End While



    '            ' End If


    '            rd.Close()
    '        Else



    '            Dim req3
    '            req3 = "insert into tr (mac,pathe) values ('" & mac & "','" & pt & "')"
    '            Dim cmd3 = New OleDbCommand(req3, cnn)

    '            Try

    '                cmd3.ExecuteNonQuery()
    '            Catch ex3 As Exception

    '            End Try





    '        End If

    '    Catch ex As Exception
    '        'If dlab = False Then

    '        If cnn.State = ConnectionState.Closed Then
    '            cnn.Open()
    '        End If

    '        If My.Computer.FileSystem.FileExists(appDataPath & "\syso.txt") Then
    '            MsgBox("Erreur Copie De la Base De Données")

    '            Me.Close()

    '        End If
    '        req = "CREATE TABLE tr (mac varchar(255),pathe varchar(255),pate varchar(255))"        ' enregistrer(req2)

    '        Dim cmd1 = New OleDbCommand(req, cnn)

    '        Try

    '            cmd1.ExecuteNonQuery()
    '        Catch ex2 As Exception

    '        End Try

    '        Dim ptt As String = "10"
    '        Dim req3
    '        req3 = "insert into tr (mac,pathe,pate) values ('" & mac & "','" & pt & "','" & ptt & "')"


    '        Dim cmd3 = New OleDbCommand(req3, cnn)

    '        Try

    '            cmd3.ExecuteNonQuery()


    '        Catch ex3 As Exception

    '        End Try

    '        Using fs As New FileStream(appDataPath & "\syso.txt", FileMode.Append, FileAccess.Write)
    '            Using sw As New StreamWriter(fs)

    '                sw.WriteLine(ptt)
    '                'sw.Close()
    '            End Using

    '        End Using

    '        MsgBox("Veuillez reconnecter")
    '        Me.Close()





    '    End Try

    '    If My.Computer.FileSystem.FileExists(appDataPath & "\syso.txt") Then

    '        File.SetAttributes(appDataPath & "\syso.txt", FileAttributes.Hidden)

    '    End If

    'End Sub

    Private Function getMacAddress() As String
        Try
            Dim adapters As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
            Dim adapter As NetworkInterface
            Dim myMac As String = String.Empty

            For Each adapter In adapters
                Select Case adapter.NetworkInterfaceType

                    Case NetworkInterfaceType.Tunnel, NetworkInterfaceType.Loopback, NetworkInterfaceType.Ppp
                    Case Else
                        If Not adapter.GetPhysicalAddress.ToString = String.Empty And Not adapter.GetPhysicalAddress.ToString = "00000000000000E0" Then
                            myMac = adapter.GetPhysicalAddress.ToString
                            Exit For
                        End If
                End Select
            Next adapter
            Return myMac
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub DeplaceTempToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub SAUVEGARDEToolStripMenuItem5_Click(sender As Object, e As EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_bataillon As New COM_bataillon
        fen_COM_bataillon.MdiParent = Me
        fen_COM_bataillon.StartPosition = FormStartPosition.CenterScreen
        fen_COM_bataillon.Show()
    End Sub

    Private Sub COMPAGNIEToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Pict_cache_gen.Visible = False
        Dim fen_COM_comagnie_de_service As New COM_compagnie_de_service
        fen_COM_comagnie_de_service.MdiParent = Me
        fen_COM_comagnie_de_service.StartPosition = FormStartPosition.CenterScreen
        fen_COM_comagnie_de_service.Show()
    End Sub

    Private Sub MAJDELACNIEToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Pict_cache_gen.Visible = False
        CPP = ""
        MAJCNIE.MdiParent = Me
        MAJCNIE.StartPosition = FormStartPosition.CenterScreen
        MAJCNIE.Show()
    End Sub


    Private Sub MAJDELACNIEToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Dim a As String

        a = InputBox("VEUILLEZ INSERER CODE DE MODIFICATION CNIE")
        If a = "OUJDA2021INT" Then
            Pict_cache_gen.Visible = False
            CPP = "OUI"
            MAJCNIE.MdiParent = Me
            MAJCNIE.StartPosition = FormStartPosition.CenterScreen
            MAJCNIE.Show()

        Else
            CPP = ""
            MsgBox("CODE ERRONNE")

        End If

    End Sub

    Private Sub InitialisationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InitialisationsToolStripMenuItem.Click

    End Sub

    Private Sub BanqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BanqueToolStripMenuItem.Click
        Pict_cache_gen.Visible = False
        Dim fen_DEN_banque As New COM_banque
        fen_DEN_banque.MdiParent = Me
        fen_DEN_banque.StartPosition = FormStartPosition.CenterScreen
        fen_DEN_banque.Show()
    End Sub

    'Private Sub JOURNALISATIONToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    Pict_cache_gen.Visible = False
    '    Dim fen_journalisation As New DEP_journalisation
    '    fen_journalisation.MdiParent = Me
    '    fen_journalisation.StartPosition = FormStartPosition.CenterScreen
    '    fen_journalisation.Show()
    'End Sub

    'Private Sub JOURNALISATIONToolStripMenuItem1_Click(sender As Object, e As EventArgs)
    '    Pict_cache_gen.Visible = False
    '    Dim fen_journalisation As New DEP_journalisation
    '    fen_journalisation.MdiParent = Me
    '    fen_journalisation.StartPosition = FormStartPosition.CenterScreen
    '    fen_journalisation.Show()
    'End Sub



End Class
