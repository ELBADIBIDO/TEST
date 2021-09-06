Imports System.Globalization
Imports System.Threading
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class COM_personnel_cin
    Public v_cni As Long
    Public v_prime_qual As Boolean
    Public v_mode_pay As String
    Public mod_rech As String
    Dim CP As String = ""
    ' Dim da As New OleDbDataAdapter

    Private Sub COM_personnel_cin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        rb_nom_commence_pa.Checked = True
        activer(maform, gb_personnel)
        ref_dgv()
        charger_combobox(maform, "select lib_banque, id_banque from banque order by id_banque", cbx_banque, "lib_banque", "id_banque")
        charger_combobox(maform, "select lib_unite, id_unite from unite order by id_unite", cbx_unite, "lib_unite", "id_unite")
        charger_combobox(maform, "select cod_bat_a, cod_bat_n from bataillon  order by cod_bat_n", Cbx_bataillon, "cod_bat_a", "cod_bat_n")
        charger_combobox(maform, "select cod_grd_a, cod_grd_n from grade order by cod_grd_n", cbx_grade, "cod_grd_a", "cod_grd_n")
        charger_combobox(maform, " SELECT compagnie.cod_cie, compagnie.lib_cie FROM compagnie", cbx_cie_solde, "lib_cie", "cod_cie")
        charger_combobox(maform, "SELECT service.cod_serv, service.lib_serv FROM  service", Cbx_cie_sce, "lib_serv", "cod_serv")
        RB_Numeraire.Checked = True
        vider(maform, GroupBox_cle1)
        Txt_mat.Text = ""
        vider(maform, GroupBox_saisie1)
        vider(maform, GroupBox_saisie2)
        desactiver(maform, GroupBox_cle1)
        desactiver(maform, GroupBox_saisie1)
        desactiver(maform, GroupBox_saisie2)
        cbx_grade.SelectedIndex = 0
        cbx_sit_fam.SelectedItem = cbx_sit_fam.Items(0)
        cbx_position.SelectedItem = cbx_position.Items(0)
        Cbx_zone_aff.SelectedItem = Cbx_zone_aff.Items(0)
        cbx_taux_isamt.SelectedItem = cbx_taux_isamt.Items(0)
        cbx_grade_Validated(sender, e)
        dgw_personnel.Enabled = False
        v_prime_qual = False
        v_mode_pay = "NUMERAIRE"

        If Cbx_bataillon.Items.Count = 0 Then
            MsgBox("Procéder d'abord à la création de votre Bataillon de rattachement")
        Else
            Cbx_bataillon.SelectedItem = Cbx_bataillon.Items(0)
        End If

        If cbx_grade.Items.Count = 0 Then
            MsgBox("Procéder d'abord à la création de votre grade")
        Else
            cbx_grade.SelectedItem = cbx_grade.Items(0)
            cbx_grade_Validated(sender, e)
        End If
        If Cbx_bataillon.Items.Count = 0 Or cbx_grade.Items.Count = 0 Then
            cnn.Close()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        End If
        rb_nom_commence_pa.Checked = True
        activer(maform, gb_personnel)
    End Sub
    Private Sub ref_dgv()
        On Error Resume Next
        req = " SELECT   mat, som, nom, prenom, grade.cod_grd_a, bataillon.cod_bat_a,  compagnie.lib_cie,service.lib_serv, cni as cnie ,cni  " &
              " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n " &
              " = personnel.cod_grd_n) ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) ON " &
              " service.cod_serv = personnel.cod_serv order by cni"
        charger_grid_view(maform, req, dgw_personnel)
        dgw_personnel.Columns(9).Visible = False
        For ii = 0 To dgw_personnel.Rows.Count - 1
            dgw_personnel(8, ii).Value = dgw_personnel(8, ii).Value.ToString.Replace(".", "")
        Next
        dgw_personnel.Refresh()
    End Sub

    Private Sub tb_r_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_r.TextChanged
        If rb_recherche_par_mat.Checked Then
            req = " SELECT   mat, som, nom, prenom, grade.cod_grd_a, bataillon.cod_bat_a,  compagnie.lib_cie,service.lib_serv, cni as cnie ,cni" &
                  " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n " &
                  " = personnel.cod_grd_n) ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) ON " &
                  " service.cod_serv = personnel.cod_serv  " &
                  "  where mat like '" & tb_r.Text & "%'  order by cni "
        End If
        If rb_recherche_par_som.Checked Then
            req = " SELECT   mat, som, nom, prenom, grade.cod_grd_a, bataillon.cod_bat_a,  compagnie.lib_cie,service.lib_serv, cni as cnie ,cni " &
                  " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n " &
                  " = personnel.cod_grd_n) ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) ON " &
                  " service.cod_serv = personnel.cod_serv  " &
                  "  where som like '" & tb_r.Text & "%'  order by cni "
        End If
        If rb_nom_commence_pa.Checked Then
            req = " SELECT   mat, som, nom, prenom, grade.cod_grd_a, bataillon.cod_bat_a,  compagnie.lib_cie,service.lib_serv, cni as cnie ,cni" &
                  " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n " &
                  " = personnel.cod_grd_n) ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) ON " &
                  " service.cod_serv = personnel.cod_serv  " &
                  "  where nom like '" & tb_r.Text & "%'  order by cni "
        End If
        If RadioButton2.Checked Then
            req = " SELECT   mat, som, nom, prenom, grade.cod_grd_a, bataillon.cod_bat_a,  compagnie.lib_cie,service.lib_serv, cni as cnie ,cni" &
                  " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n " &
                  " = personnel.cod_grd_n) ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) ON " &
                  " service.cod_serv = personnel.cod_serv  " &
                  "  where cni like '" & tb_r.Text & "%'  order by cni "
        End If
        charger_grid_view(maform, req, dgw_personnel)
        dgw_personnel.Columns(9).Visible = False
        For ii = 0 To dgw_personnel.Rows.Count - 1
            dgw_personnel(8, ii).Value = dgw_personnel(8, ii).Value.ToString.Replace(".", "")
        Next
        dgw_personnel.Refresh()

    End Sub
    Private Sub rb_recherche_par_mat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recherche_par_mat.CheckedChanged
        tb_r.Enabled = True
        dgw_personnel.Enabled = True
        tb_r.Focus()
    End Sub
    Private Sub rb_recherche_par_som_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_recherche_par_som.CheckedChanged
        tb_r.Enabled = True
        dgw_personnel.Enabled = True
        tb_r.Focus()
    End Sub

    Private Sub rb_nom_commence_pa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_nom_commence_pa.CheckedChanged
        tb_r.Enabled = True
        tb_r.Focus()
        dgw_personnel.Enabled = True
    End Sub
    Private Sub ChB_prime_qual_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_prime_qual.CheckedChanged
        If ChB_prime_qual.Checked = True Then
            v_prime_qual = True
            ChB_prime_qual.Enabled = True
        End If
        If ChB_prime_qual.Checked = False Then
            ChB_prime_qual.Enabled = False
            v_prime_qual = False
        End If
    End Sub
    Private Sub RB_CCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CCP.CheckedChanged
        If RB_CCP.Checked = True Then
            RB_CCP.Checked = True
            v_mode_pay = "C.C.P"
            RB_banque.Checked = False
            RB_detache.Checked = False
            RB_Mandat.Checked = False
            RB_Numeraire.Checked = False
        End If
    End Sub
    Private Sub RB_banque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_banque.CheckedChanged
        If RB_banque.Checked = True Then
            RB_banque.Checked = True
            v_mode_pay = "BANQUE"
            RB_CCP.Checked = False
            RB_detache.Checked = False
            RB_Mandat.Checked = False
            RB_Numeraire.Checked = False
        End If
    End Sub
    Private Sub RB_detache_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_detache.CheckedChanged
        If RB_detache.Checked = True Then
            RB_detache.Checked = True
            v_mode_pay = "DETACHE"
            RB_CCP.Checked = False
            RB_banque.Checked = False
            RB_Mandat.Checked = False
            RB_Numeraire.Checked = False
        End If
    End Sub
    Private Sub RB_Mandat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Mandat.CheckedChanged
        If RB_Mandat.Checked = True Then
            v_mode_pay = "MANDAT"
            RB_Mandat.Checked = True
            RB_detache.Checked = False
            RB_CCP.Checked = False
            RB_banque.Checked = False
            RB_Numeraire.Checked = False
        End If
    End Sub
    Private Sub RB_Numeraire_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Numeraire.CheckedChanged
        If RB_Numeraire.Checked = True Then
            RB_Numeraire.Checked = True
            v_mode_pay = "NUMERAIRE"
            RB_Mandat.Checked = False
            RB_detache.Checked = False
            RB_CCP.Checked = False
            RB_banque.Checked = False
        End If
    End Sub
    Private Sub Btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_nouveau.Click
        op = "N"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        RadioButton1.Checked = False
        CP = ""
        activer(maform, GroupBox_cle1)
        desactiver(maform, gb_personnel)
        txt_cni.Focus()
    End Sub
    Private Sub Btn_quitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quitter.Click
        cnn.Close()
        Me.Close()
    End Sub
    Private Sub Btn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        dr.Close()
        charger_combobox(maform, " SELECT compagnie.cod_cie, compagnie.lib_cie FROM compagnie", cbx_cie_solde, "lib_cie", "cod_cie")
        charger_combobox(maform, "SELECT service.cod_serv, service.lib_serv FROM  service", Cbx_cie_sce, "lib_serv", "cod_serv")
        ref_dgv()
        vider(maform, GroupBox_cle1)
        vider(maform, GroupBox_saisie1)
        vider(maform, GroupBox_saisie2)
        ChB_prime_qual.Checked = False
        desactiver(maform, GroupBox_cle1)
        desactiver(maform, GroupBox_saisie1)
        desactiver(maform, GroupBox_saisie2)
        dgw_personnel.Enabled = False
        activer(maform, gb_personnel)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        CP = ""
        RadioButton1.Checked = False
    End Sub
    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        activer(maform, GroupBox_cle1)
        desactiver(maform, gb_personnel)
        RadioButton1.Checked = False
        CP = ""

    End Sub
    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click

        On Error Resume Next


        If double_mle(Txt_mat.Text, cbx_grade.SelectedValue) = False Then
            MsgBox("DOUBLANT SUR LE CHAMP MATRICULE")
            Return

        End If

        If v_mode_pay = "" Then
            MsgBox("Choisir au moins un mode de paiement")
            Return
        End If

        If Txt_nom.Text.Trim = "" Or txt_prenom.Text.Trim = "" Or Cbx_cie_sce.SelectedValue = 0 Or cbx_cie_solde.SelectedValue = 0 Or cbx_grade.SelectedValue = 0 Or Cbx_bataillon.SelectedValue = 0 Or cbx_sit_fam.Text = "" Then
            MsgBox("Champs marqués en * sont obligatoire")
            Return
        End If


        If Trim(txt_rib_ccp.Text) = "" And Trim(txt_rib_banque.Text) = "" Then
            MsgBox("Renseigner au moins un compte CCP au Bancaire valide avec 24 Chiffres")
            Return
        End If
        If Trim(txt_rib_ccp.Text) <> "" Then
            If Len(Trim(txt_rib_ccp.Text)) = 24 Then
                If Trim(txt_rib_ccp.Text).ToString.Substring(0, 5) <> "35081" Then
                    MsgBox("Taper un compte CCP valide avec 24 Chiffres")
                    Return
                End If
            Else
                MsgBox("Taper un compte CCP valide avec 24 Chiffres")
                Return
            End If
        End If

        If Trim(txt_rib_banque.Text) <> "" Then
            If Len(Trim(txt_rib_banque.Text)) = 24 Then
                If Trim(txt_rib_banque.Text).ToString.Substring(0, 5) = "35081" Then
                    MsgBox("Taper un compte bancaire valide avec 24 Chiffres")
                    Return
                End If
            Else
                MsgBox("Taper un compte bancaire valide avec 24 Chiffres")
                Return
            End If

        End If

        If Trim(txt_rib_ccp.Text) <> "" Then
            If double_compte(txt_rib_ccp.Text.Trim) = False Then
                MsgBox("Un compte CCP ne peut pas être affecté à deux militaires")
                Return
            End If
        End If
        If Trim(txt_rib_banque.Text) <> "" Then
            If double_rib_banque(txt_rib_banque.Text.Trim) = False Then
                MsgBox("Un compte banquaire ne peut pas être affecté à deux militaires")
                Return
            End If
        End If

        If op = "N" Then
            'begin


            Dim dr1 As OleDbDataReader

            dr1.Close()

            Dim req1 As String

            Dim cmd1 As New OleDbCommand


            req1 = " SELECT cni, mat, som, nom, prenom, personnel.cod_bat_n, personnel.cod_grd_n, personnel.cod_cie," &
                      " personnel.cod_serv, Pos_mil, echelle, echelon, iif(isnull(sit_fam),space(11), sit_fam),  nbr_enf,iif(isnull(zone_aff),space(2),zone_aff)," &
                      " iif(isnull(prime_qual),'false',prime_qual),iif(isnull(mode_pay),space(9),mode_pay),iif(isnull(rib_ccp),space(9),rib_ccp),id_banque,iif(isnull(rib_banque),space(27), rib_banque),id_unite, " &
                      " iif(isnull(adresse),space(40),adresse),taux_isamt " &
                      " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n = personnel.cod_grd_n)" &
                      " ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) " &
                      " ON service.cod_serv = personnel.cod_serv where  cni='" & "." & txt_cni.Text & "'"

            If cnn.State = ConnectionState.Closed Then

                cnn.Open()

            End If
            cmd1.CommandType = CommandType.Text
            cmd1.Connection = cnn
            cmd1.CommandText = req1
            dr1 = cmd1.ExecuteReader
            If dr1.HasRows Then
                dr1.Read()

                MsgBox("CARTE DEJA EXISTE")
                dr1.Close()
                Exit Sub


            End If








            'end










            ' req = "insert into personnel( cni, mat,som,prenom,nom,cod_bat_n,cod_grd_n,cod_cie,cod_serv,Pos_mil,echelle, echelon,sit_fam,nbr_enf," &
            '         "zone_aff,prime_qual,mode_pay,rib_ccp,id_banque,rib_banque,id_unite,adresse,taux_isamt) values ('" & CP + txt_cni.Text.ToUpper & "','" & Txt_mat.Text & "'," &
            'Val(Txt_som.Text) & ",'" & txt_prenom.Text.ToUpper & "','" & Txt_nom.Text.ToUpper & "'," & Cbx_bataillon.SelectedValue & "," &
            'cbx_grade.SelectedValue & "," & cbx_cie_solde.SelectedValue & "," & Cbx_cie_sce.SelectedValue & ",'" & cbx_position.Text & "'," &
            'Val(Cbx_echelle.Text) & "," & Val(Cbx_echelon.Text) & ",'" & cbx_sit_fam.Text & "'," & Val(txt_nbr_enf.Text) & ",'" &
            'Cbx_zone_aff.Text & "'," & v_prime_qual & ",'" & v_mode_pay & "','" & txt_rib_ccp.Text.ToUpper & "'," & Val(cbx_banque.SelectedValue) & ",'" & txt_rib_banque.Text & "'," &
            'Val(cbx_unite.SelectedValue) & ",'" & txt_adresse.Text.ToUpper & "'," & Val(cbx_taux_isamt.Text) & ")"
            If xyprofil = "utilisateur" Then
                req = "insert into personnel( cni, mat,som,prenom,nom,cod_bat_n,cod_grd_n,cod_cie,cod_serv,Pos_mil,echelle, echelon,sit_fam,nbr_enf," &
                    "zone_aff,prime_qual,mode_pay,rib_ccp,id_banque,rib_banque,id_unite,adresse,taux_isamt) values ('" & CP + txt_cni.Text.ToUpper & "','" & Txt_mat.Text & "'," &
           Val(Txt_som.Text) & ",'" & txt_prenom.Text.ToUpper & "','" & Txt_nom.Text.ToUpper & "'," & Cbx_bataillon.SelectedValue & "," &
           cbx_grade.SelectedValue & "," & cbx_cie_solde.SelectedValue & "," & Cbx_cie_sce.SelectedValue & ",'" & cbx_position.Text & "'," &
           Val(Cbx_echelle.Text) & "," & Val(Cbx_echelon.Text) & ",'" & cbx_sit_fam.Text & "'," & Val(txt_nbr_enf.Text) & ",'" &
           Cbx_zone_aff.Text & "'," & v_prime_qual & ",'" & v_mode_pay & "',''," & Val(cbx_banque.SelectedValue) & ",''," &
           Val(cbx_unite.SelectedValue) & ",'" & txt_adresse.Text.ToUpper & "'," & Val(cbx_taux_isamt.Text) & ")"
            ElseIf xyprofil = "administrateur" Then
                req = "insert into personnel( cni, mat,som,prenom,nom,cod_bat_n,cod_grd_n,cod_cie,cod_serv,Pos_mil,echelle, echelon,sit_fam,nbr_enf," &
                        "zone_aff,prime_qual,mode_pay,rib_ccp,id_banque,rib_banque,id_unite,adresse,taux_isamt) values ('" & CP + txt_cni.Text.ToUpper & "','" & Txt_mat.Text & "'," &
               Val(Txt_som.Text) & ",'" & txt_prenom.Text.ToUpper & "','" & Txt_nom.Text.ToUpper & "'," & Cbx_bataillon.SelectedValue & "," &
               cbx_grade.SelectedValue & "," & cbx_cie_solde.SelectedValue & "," & Cbx_cie_sce.SelectedValue & ",'" & cbx_position.Text & "'," &
               Val(Cbx_echelle.Text) & "," & Val(Cbx_echelon.Text) & ",'" & cbx_sit_fam.Text & "'," & Val(txt_nbr_enf.Text) & ",'" &
               Cbx_zone_aff.Text & "'," & v_prime_qual & ",'" & v_mode_pay & "','" & txt_rib_ccp.Text.ToUpper & "'," & Val(cbx_banque.SelectedValue) & ",'" & txt_rib_banque.Text & "'," &
               Val(cbx_unite.SelectedValue) & ",'" & txt_adresse.Text.ToUpper & "'," & Val(cbx_taux_isamt.Text) & ")"

            End If
        ElseIf op = "M" Then
            req = "update personnel set  mat='" & Txt_mat.Text & "', som=" & Val(Txt_som.Text) & ", prenom='" &
             txt_prenom.Text.ToUpper & "', nom='" & Txt_nom.Text.ToUpper &
              "', cod_bat_n=" & Cbx_bataillon.SelectedValue & ", cod_grd_n=" & cbx_grade.SelectedValue & ", cod_cie=" &
             cbx_cie_solde.SelectedValue & ", cod_serv=" & Cbx_cie_sce.SelectedValue & ", Pos_mil='" & cbx_position.Text & "',echelle =" &
             Val(Cbx_echelle.Text) & ", echelon=" & Val(Cbx_echelon.Text) & ", sit_fam='" & cbx_sit_fam.Text & "', nbr_enf =" & Val(txt_nbr_enf.Text) & ", zone_aff='" & Cbx_zone_aff.Text & "', prime_qual =" &
              v_prime_qual & ", mode_pay ='" & v_mode_pay & "', rib_ccp ='" & txt_rib_ccp.Text.ToUpper & "',id_banque=" & Val(cbx_banque.SelectedValue) & ", rib_banque ='" &
              txt_rib_banque.Text & "',id_unite=" & Val(cbx_unite.SelectedValue) & ", adresse ='" & txt_adresse.Text.ToUpper & "',  taux_isamt =" & Val(cbx_taux_isamt.Text) & " where cni='" & txt_cni.Text.ToUpper & "'"
        End If
        If xyprofil = "administrateur" And op = "M" Then

            enregistrer(req)
        ElseIf xyprofil = "utilisateur" And op = "M" Then
            MsgBox("VOUS N'AVEZ PAS LE DROIT DE PROCEDER A CETTE MODIFICATION ,CONTACTER L'ADMINISTRATEUR", vbInformation)
            Exit Sub
        End If
        If op = "N" Then
            If xyprofil = "administrateur" Then
                enregistrer(req)
            Else
                enregistrer(req)
                MsgBox("COMPTE CCP OU BANQUE DOIVENT ETRE MODIFIER PAR L'ADMINISTRATEUR")
            End If
        End If

        journal(Date.Now, xynom, xyatelier, req)
        Btn_Annuler_Click(sender, e)
        ref_dgv()
    End Sub
    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        If dgw_personnel.CurrentCell.RowIndex >= 0 Then
            op = "M"
            txt_cni.Text = dgw_personnel(8, dgw_personnel.CurrentCell.RowIndex).Value

            RadioButton1_Validated(sender, e)
        End If

    End Sub
    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        'req = "delete from personnel where cni= '" & v_cni & "'"
        'supprimer(req)
        'journal(Date.Now, xynom, xyatelier, req)

        'ref_dgv()
        'Btn_Annuler_Click(sender, e)
    End Sub




    Private Sub lecture(ByVal sender, ByVal e)
        On Error Resume Next
        dr.Close()

        Dim cni As String = ""
        cmd.CommandText = req

        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()



            cni = IIf(IsDBNull(dr(0)), "", dr(0))
            If cni.Substring(0, 1) = "." Then
                RadioButton1.Checked = True
                CP = "."
            Else
                RadioButton1.Checked = False
                CP = ""
            End If
            Txt_mat.Text = IIf(IsDBNull(dr(1)), "", dr(1))
            If op = "M" Then
                mlem = Txt_mat.Text
            End If

            Txt_som.Text = IIf(IsDBNull(dr(2)), 0, dr(2))
            Txt_nom.Text = IIf(IsDBNull(dr(3)), "", dr(3))
            txt_prenom.Text = IIf(IsDBNull(dr(4)), "", dr(4))
            Cbx_bataillon.SelectedValue = IIf(IsDBNull(dr(5)), 0, dr(5))
            cbx_grade.SelectedValue = IIf(IsDBNull(dr(6)), 0, dr(6))
            cbx_grade_Validated(sender, e)
            cbx_cie_solde.SelectedValue = IIf(IsDBNull(dr(7)), 0, dr(7))
            Cbx_cie_sce.SelectedValue = IIf(IsDBNull(dr(8)), 0, dr(8))
            cbx_position.Text = IIf(IsDBNull(dr(9)), "", dr(9))
            Cbx_echelle.Text = IIf(IsDBNull(dr(10)), 0, dr(10))
            Cbx_echelon.Text = IIf(IsDBNull(dr(11)), 0, dr(11))
            cbx_sit_fam.Text = IIf(IsDBNull(dr(12)), "", dr(12))
            txt_nbr_enf.Text = IIf(IsDBNull(dr(13)), 0, dr(13))
            Cbx_zone_aff.Text = IIf(IsDBNull(dr(14)), "", dr(14))
            ChB_prime_qual.Checked = IIf(IsDBNull(dr(15)), False, dr(15))
            v_mode_pay = IIf(IsDBNull(dr(16)), "", dr(16))
            txt_rib_ccp.Text = IIf(IsDBNull(dr(17)), "", dr(17))
            If op = "M" And xyprofil = "administrateur" Then
                ccpm = txt_rib_ccp.Text
            End If
            cbx_banque.SelectedValue = IIf(IsDBNull(dr(18)), 0, dr(18))
            txt_rib_banque.Text = IIf(IsDBNull(dr(19)), "", dr(19))
            If op = "M" Then
                ccpbm = txt_rib_banque.Text
            End If
            cbx_unite.SelectedValue = IIf(IsDBNull(dr(20)), "", dr(20))
            txt_adresse.Text = IIf(IsDBNull(dr(21)), "", dr(21))
            cbx_taux_isamt.Text = IIf(IsDBNull(dr(22)), 0, Val(dr(22)))
            cbx_grade_Validated(sender, e)
            ''txt_cni.Text = dr(0)
            ''Txt_mat.Text = dr(1)
            ''Txt_som.Text = dr(2)
            ''Txt_nom.Text = dr(3)
            ''txt_prenom.Text = dr(4)
            ''Cbx_bataillon.SelectedValue = dr(5)
            ''cbx_grade.SelectedValue = dr(6)
            ''cbx_grade_Validated(sender, e)
            ''cbx_cie_solde.SelectedValue = dr(7)
            ''Cbx_cie_sce.SelectedValue = dr(8)
            ''cbx_position.Text = dr(9)
            ''Cbx_echelle.Text = dr(10)
            ''Cbx_echelon.Text = dr(11)
            ''cbx_sit_fam.Text = dr(12)
            ''txt_nbr_enf.Text = dr(13)
            ''Cbx_zone_aff.Text = dr(14)
            ''ChB_prime_qual.Checked = dr(15)
            ''v_mode_pay = dr(16)
            ''txt_rib_ccp.Text = dr(17)
            ''cbx_banque.SelectedValue = dr(18)
            ''txt_rib_banque.Text = dr(19)
            ''cbx_unite.SelectedValue = dr(20)
            ''txt_adresse.Text = dr(21)
            ''cbx_taux_isamt.Text = Val(dr(22))
            'cbx_grade_Validated(sender, e)
            If CP = "." Then
                RadioButton1.Checked = True


            End If
            RB_CCP.Checked = False
            RB_banque.Checked = False
            RB_detache.Checked = False
            RB_Mandat.Checked = False
            RB_Numeraire.Checked = False
            If v_mode_pay = "C.C.P" Then
                RB_CCP.Checked = True
            End If
            If v_mode_pay = "BANQUE" Then
                RB_banque.Checked = True
            End If
            If v_mode_pay = "DETACHE" Then
                RB_detache.Checked = True
            End If
            If v_mode_pay = "MANDAT" Then
                RB_Mandat.Checked = True
            End If
            If v_mode_pay = "NUMERAIRE" Then
                RB_Numeraire.Checked = True
            End If
            If op = "N" Then
                MsgBox("Ce militaire existe déjà, Procéder à la modification ")
                Btn_Annuler_Click(sender, e)
            Else
                desactiver(maform, GroupBox_cle1)
                activer(maform, GroupBox_saisie1)
                activer(maform, GroupBox_saisie2)
                Btn_Supprimer.Enabled = True
                Btn_Enregistrer.Enabled = True
                Txt_mat.Focus()
            End If
        Else
            If op = "N" Then






                desactiver(maform, GroupBox_cle1)
                activer(maform, GroupBox_saisie1)
                activer(maform, GroupBox_saisie2)
                Btn_Enregistrer.Enabled = True
                Txt_mat.Focus()
            Else
                desactiver(maform, GroupBox_cle1)
                MsgBox("Militaire Inexistant")
                Btn_Annuler_Click(sender, e)
            End If
        End If
        dr.Close()



    End Sub


    Private Sub cbx_grade_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_grade.Validated

        Dim res_echelle, res_echelon As String
        res_echelle = Cbx_echelle.Text
        res_echelon = Cbx_echelon.Text
        Cbx_echelle.Items.Clear()
        Cbx_echelon.Items.Clear()
        If cbx_grade.SelectedValue >= 16 Then
            Dim echelle() As String = {1, 2}
            Cbx_echelle.Items.AddRange(echelle)
            Cbx_echelle.Text = 1
        Else
            Dim echelle() As String = {1, 2, 3, 4}
            Cbx_echelle.Items.AddRange(echelle)
            Cbx_echelle.Text = 1
        End If

        Select Case cbx_grade.SelectedValue
            Case 1 To 14
                Dim echelon() As String = {1, 2, 3, 4, 5, 6, 7, 8}
                Cbx_echelon.Items.AddRange(echelon)
                Cbx_echelon.Text = 1
            Case Is = 15
                Dim echelon() As String = {-2, 2, 3, 5, 9, 12, 15, 20}
                Cbx_echelon.Items.AddRange(echelon)
                Cbx_echelon.Text = -2
            Case Is >= 16
                Dim echelon() As String = {-2, 2, 3, 5, 9, 12, 15}
                Cbx_echelon.Items.AddRange(echelon)
                Cbx_echelon.Text = -2
        End Select
        Cbx_echelle.Text = res_echelle
        Cbx_echelon.Text = res_echelon
    End Sub

    Private Sub cbx_sit_fam_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbx_sit_fam.Validated
        If cbx_sit_fam.Text = "MARIE" Then
            txt_nbr_enf.Enabled = True
        Else
            If cbx_sit_fam.Text = "CELIBATAIRE" Then
                txt_nbr_enf.Text = 0
                txt_nbr_enf.Enabled = False
            Else
                txt_nbr_enf.Text = 0
                txt_nbr_enf.Enabled = True
            End If

        End If
    End Sub

    Private Sub Cbx_bataillon_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbx_bataillon.TextChanged
        Cbx_cie_sce.Select()
        cbx_cie_solde.Select()
    End Sub

    Private Sub Cbx_bataillon_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbx_bataillon.Validated
        charger_combobox(maform, " SELECT compagnie.cod_cie, compagnie.lib_cie FROM compagnie where cod_bat_n = " & Cbx_bataillon.SelectedValue, cbx_cie_solde, "lib_cie", "cod_cie")
        charger_combobox(maform, " SELECT service.cod_serv, service.lib_serv FROM  service where cod_bat_n= " & Cbx_bataillon.SelectedValue, Cbx_cie_sce, "lib_serv", "cod_serv")
        If Cbx_cie_sce.Items.Count = 0 Then
            MsgBox("Crée votre Compagnie de Service")

        End If
        If cbx_cie_solde.Items.Count = 0 Then
            MsgBox("Crée votre Compagnie de solde")
        End If
        If Cbx_cie_sce.Items.Count = 0 Or cbx_cie_solde.Items.Count = 0 Then
            Btn_Annuler_Click(sender, e)
        End If
    End Sub
    Private Sub dgw_personnel_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgw_personnel.DoubleClick
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)

        If dgw_personnel.CurrentCell.RowIndex >= 0 Then
            txt_cni.Text = dgw_personnel(9, dgw_personnel.CurrentCell.RowIndex).Value
            RadioButton1_Validated(sender, e)
        End If
    End Sub




    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        If RadioButton1.Checked = True Then
            CP = "."
        Else
            CP = ""
        End If
    End Sub


    Private Sub RadioButton1_Validated(sender As Object, e As EventArgs) Handles RadioButton1.Validated
        On Error Resume Next


        If txt_cni.Text <> "" Then
            desactiver(maform, GroupBox_cle1)

            dr.Close()

            'Dim dr1 As OleDbDataReader

            '  dr1.Close()

            'Dim req1 As String

            'Dim cmd1 As New OleDbCommand


            'req1 = " SELECT cni, mat, som, nom, prenom, personnel.cod_bat_n, personnel.cod_grd_n, personnel.cod_cie," &
            '      " personnel.cod_serv, Pos_mil, echelle, echelon, iif(isnull(sit_fam),space(11), sit_fam),  nbr_enf,iif(isnull(zone_aff),space(2),zone_aff)," &
            '      " iif(isnull(prime_qual),'false',prime_qual),iif(isnull(mode_pay),space(9),mode_pay),iif(isnull(rib_ccp),space(9),rib_ccp),id_banque,iif(isnull(rib_banque),space(27), rib_banque),id_unite, " &
            '      " iif(isnull(adresse),space(40),adresse),taux_isamt " &
            '      " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n = personnel.cod_grd_n)" &
            '      " ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) " &
            '      " ON service.cod_serv = personnel.cod_serv where  cni='" & txt_cni.Text & "'"

            'If cnn.State = ConnectionState.Closed Then

            '    cnn.Open()

            'End If
            'cmd1.CommandType = CommandType.Text
            'cmd1.Connection = cnn
            'cmd1.CommandText = req1
            'dr1 = cmd1.ExecuteReader
            'If dr1.HasRows Then
            '    dr1.Read()

            '    MsgBox("CARTE DEJA EXISTE")
            '    dr1.Close()
            '    Exit Sub


            'End If






            req = " SELECT cni, mat, som, nom, prenom, personnel.cod_bat_n, personnel.cod_grd_n, personnel.cod_cie," &
                  " personnel.cod_serv, Pos_mil, echelle, echelon, iif(isnull(sit_fam),space(11), sit_fam),  nbr_enf,iif(isnull(zone_aff),space(2),zone_aff)," &
                  " iif(isnull(prime_qual),'false',prime_qual),iif(isnull(mode_pay),space(9),mode_pay),iif(isnull(rib_ccp),space(9),rib_ccp),id_banque,iif(isnull(rib_banque),space(27), rib_banque),id_unite, " &
                  " iif(isnull(adresse),space(40),adresse),taux_isamt " &
                  " FROM service RIGHT JOIN (bataillon RIGHT JOIN (compagnie RIGHT JOIN (grade RIGHT JOIN personnel ON grade.cod_grd_n = personnel.cod_grd_n)" &
                  " ON compagnie.cod_cie = personnel.cod_cie) ON bataillon.cod_bat_n = personnel.cod_bat_n) " &
                  " ON service.cod_serv = personnel.cod_serv where  cni='" & CP + txt_cni.Text & "'"
            lecture(sender, e)
        Else
            MsgBox("taper un numero cni correct, composé de caracteres suivis des chiffres ")
            Btn_Annuler_Click(sender, e)
        End If
    End Sub

    Private Sub txt_cni_TextChanged(sender As Object, e As EventArgs) Handles txt_cni.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub

    Private Sub dgw_personnel_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw_personnel.CellContentClick

    End Sub

    Private Sub txt_cni_Validated(sender As Object, e As EventArgs) Handles txt_cni.Validated

    End Sub

    Private Sub txt_cni_Validating(sender As Object, e As CancelEventArgs) Handles txt_cni.Validating

    End Sub

    Private Sub Label36_Validated(sender As Object, e As EventArgs) Handles Label36.Validated

    End Sub

    Private Sub Label36_Validating(sender As Object, e As CancelEventArgs) Handles Label36.Validating

    End Sub
End Class