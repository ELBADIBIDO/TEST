Imports System.Globalization
Imports System.Threading
Public Class com_administration_utilisateur
    Public maCI As CultureInfo = CultureInfo.CurrentCulture
    Public maCIclone As CultureInfo = CType(maCI.Clone(), Globalization.CultureInfo)

    Dim req_dgv_ut As String
    Dim sauv_pwd As String
    Dim sauv_id_user As Integer
    Dim bol_den, bol_imp, bol_ssp, bol_sm, bol_dep As Boolean


    Private Sub com_administration_utilisateur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        maCIclone.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture = maCIclone

        connection()
        maform = Me.Name
        req = "select  id_user, nom, pwd from utilisateur where profil='administrateur'"
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        sauv_pwd = ""
        If dr.HasRows Then
            dr.Read()
            sauv_id_user = dr(0)
            Txt_nom.Text = IIf(IsDBNull(dr(1)), "", dr(1))
            sauv_pwd = IIf(IsDBNull(dr(2)), "", dr(2))
            Txt_nom.Enabled = False
            txt_pwd.Enabled = True
            txt_confirmer.Visible = False
            lab_confirmer2.Visible = False
            lab_confirmer2.Visible = False
            Btn_Enregistrer.Visible = False
            op = "M"
        Else
            op = "N"
            Txt_nom.Enabled = True
            txt_pwd.Enabled = True
            txt_confirmer.Enabled = True
            Btn_Enregistrer.Visible = True
        End If
        dr.Close()
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

    End Sub


    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub


    Private Sub TabControl1_Selected(ByVal sender As Object, ByVal e As System.Windows.Forms.TabControlEventArgs) Handles TabControl1.Selected
        If TabControl1.SelectedIndex = 1 Then
            If sauv_pwd <> txt_pwd.Text.ToUpper Or sauv_pwd = "" Then
                MsgBox("Crér un Administrateur ou Taper le mot de passe administrateur valide")
                TabControl1.SelectedIndex = 0
            Else
                req_dgv_ut = "select  id_user, nom, pwd from utilisateur where profil='utilisateur'"
                charger_grid_view(maform, req_dgv_ut, DataGridView2)
                txt_nom_user.Focus()
            End If
        End If
    End Sub


    Private Sub btn_retirer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_retirer.Click
        Try
            

            If DataGridView2.Rows.Count > 1 Then
                If DataGridView2.CurrentCell.RowIndex >= 0 Then
                    transac = cnn.BeginTransaction
                    cmd.Transaction = transac
                    sauv_id_user = DataGridView2(0, DataGridView2.CurrentCell.RowIndex).Value
                    req = "delete  from utilisateur  where id_user=" & sauv_id_user
                    supprimer(req)
                    journal(Date.Now, xynom, xyatelier, req)

                    transac.Commit()
                    transac.Dispose()

                    charger_grid_view(maform, req_dgv_ut, DataGridView2)
                End If
            Else
                MsgBox("rien à supprimer, SVP  choisir une ligne ")
            End If
        Catch ex As Exception
            transac.Rollback()
            transac.Dispose()
            MsgBox(ex.ToString)

        End Try
        
    End Sub

    Private Sub btn_ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ajouter.Click
        Try
            transac = cnn.BeginTransaction
            cmd.Transaction = transac

            If Len(txt_pwd_user.Text) < 8 Then
                MsgBox("choisir un mot de passe d'au moins 8 caractères")
                Return
            End If


            If txt_nom_user.Text <> "" And txt_pwd_user.Text <> "" And txt_pwd_user.Text = txt_pwd_confirmer_user.Text Then
                    req = "select * from utilisateur  where nom='" & txt_nom_user.Text.ToUpper & "'"
                    cmd.CommandText = req
                    dr = cmd.ExecuteReader
                    If dr.HasRows Then
                        MsgBox("attention nom double")
                        dr.Close()
                    Else
                        dr.Close()

                        req = "insert into utilisateur (nom,pwd,profil)" &
                        "values ('" & txt_nom_user.Text.ToUpper & "','" & txt_pwd_user.Text.ToUpper & "','utilisateur')"
                        enregistrer(req)
                        'journal(Date.Now, xynom, xyatelier, req)
                        transac.Commit()
                        transac.Dispose()


                        charger_grid_view(maform, req_dgv_ut, DataGridView2)
                        dr.Close()
                        txt_nom_user.Text = ""
                        txt_pwd_user.Text = ""
                        txt_pwd_confirmer_user.Text = ""

                    End If
                Else
                    MsgBox("Remplir tous les champs")
                End If

        Catch ex As Exception
            transac.Rollback()
            transac.Dispose()
            MsgBox(ex.ToString)

        End Try
        
    End Sub

    Private Sub txt_confirmer_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_confirmer.Validated
        If Txt_nom.Text <> "" And txt_pwd.Text <> "" And txt_pwd.Text = txt_confirmer.Text Then
            Btn_Enregistrer.Enabled = True

        Else
            Btn_Enregistrer.Enabled = False
        End If
    End Sub

    Private Sub txt_pwd_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_pwd.Validated
        txt_confirmer_Validated(sender, e)
        Dim resultat As Integer
        If op = "M" Then
            cmd.CommandText = "select count(*) from utilisateur  where nom='" & Txt_nom.Text.ToUpper & "'and pwd='" & txt_pwd.Text & "'"
            resultat = cmd.ExecuteScalar
            If resultat = 0 Then

                MsgBox(" Mot de passe administrateur invalide")
                TabControl1.SelectedTab = TabPage1
            Else
                TabControl1.SelectedTab = TabPage2
            End If

        End If
    End Sub

    Private Sub Txt_nom_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_nom.Validated
        txt_confirmer_Validated(sender, e)
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If Len(txt_pwd.Text) < 8 Then
            MsgBox("choisir un mot de passe d'au moins 8 caractères")
            Return
        End If
        req = "insert into utilisateur (nom,pwd,profil,bol_den,bol_ssp,bol_sm,bol_imp,bol_dep)" & _
                "values ('" & Txt_nom.Text.ToUpper & "','" & txt_pwd.Text.ToUpper & "','administrateur'," & True & "," & True & "," & True & "," & True & "," & True & ")"
        enregistrer(req)
        journal(Date.Now, xynom, xyatelier, req)

        Btn_Enregistrer.Enabled = False
        
        sauv_pwd = txt_pwd.Text
        Txt_nom.Enabled = False
        txt_pwd.Enabled = True
        txt_confirmer.Visible = False
        lab_confirmer2.Visible = False
        lab_confirmer2.Visible = False
        Btn_Enregistrer.Visible = False
        
    End Sub
End Class