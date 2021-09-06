Imports System.Globalization
Imports System.Threading
Public Class COM_corps
    Public cod_corps_n As Long
    Public maci As CultureInfo = CultureInfo.CurrentCulture
    Public maciclone As CultureInfo = CType(maci.Clone(), Globalization.CultureInfo)

    Private Sub corps_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        maciclone.NumberFormat.NumberDecimalSeparator = "."
        Thread.CurrentThread.CurrentCulture = maciclone
        connection()
        maform = Me.Name
        vider(maform, GroupBox2)
        desactiver(maform, GroupBox2)

        req = " select cod_corps_n, cod_corps_a, lib_corps, typ_corps, rib_ccp, implantation,  cod_int, " &
              " nom_chefdecorps, nom_chefsadmin, nom_off_osm, nom_off_ord, nom_off_mat, nom_off_det  from corps"
        cbx_typ_corps.Text = cbx_typ_corps.Items(0)
        charger_grid_view(maform, req, DataGridView1)
        'DataGridView1.Columns(6).DefaultCellStyle.Format = "n2"
        'DataGridView1.Columns(7).DefaultCellStyle.Format = "n2"
        'DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.AllCells
        'DataGridView1.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight
        'DataGridView1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight

        charger_combobox(maform, "select cod_int,lib_int from intendance order by cod_int", cbx_int, "lib_int", "cod_int")

        If cbx_int.Items.Count = 0 Then
            MsgBox("Proceder d'abord à la création de votre intendance de rattachement")
            cnn.Close()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Else
            cbx_int.SelectedItem = cbx_int.Items(0)
        End If

    End Sub

    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub Btn_Modifier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        TabPage2.Show()
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Btn_nouveau_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_nouveau.Click
        op = "N"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)

        vider(maform, GroupBox2)
        activer(maform, GroupBox2)

        Btn_Enregistrer.Enabled = True
        Txt_cod_corps_a.Focus()
    End Sub

    Private Sub Btn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        vider(maform, GroupBox2)
        'txt_avoir_num.Text = Format$("0,00")
        'txt_avoir_ccp.Text = Format$("0,00")
        desactiver(maform, GroupBox2)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If op = "M" Then
            req = "update corps set  cod_corps_a='" & Txt_cod_corps_a.Text & "', lib_corps='" & Txt_lib_corps.Text & "', typ_corps='" & cbx_typ_corps.Text & "', rib_ccp = '" & txt_ccp_corps.Text &
                "', implantation = '" & txt_implantation.Text & "', cod_int = " & cbx_int.SelectedValue & ", nom_chefdecorps ='" & txt_nom_chefdecorps.Text & "', nom_chefsadmin ='" &
                txt_nom_chefsadmin.Text & "', nom_off_osm ='" & txt_nom_off_osm.Text & "', nom_off_ord ='" & txt_nom_off_ord.Text & "', nom_off_mat ='" &
                txt_nom_off_mat.Text & "', nom_off_det ='" & txt_nom_off_det.Text & "' where cod_corps_n=" & cod_corps_n & ""

        Else
            req = "insert into  corps( cod_corps_a,lib_corps,typ_corps,rib_ccp,implantation,cod_int,nom_chefdecorps,nom_chefsadmin,nom_off_osm,nom_off_ord,nom_off_mat,nom_off_det) values ('" &
              Txt_cod_corps_a.Text & "','" & Txt_lib_corps.Text & "','" & cbx_typ_corps.Text & "','" & txt_ccp_corps.Text & "','" & txt_implantation.Text & "'," &
              cbx_int.SelectedValue & ",'" & txt_nom_chefdecorps.Text & "','" &
                txt_nom_chefsadmin.Text & "','" & txt_nom_off_osm.Text & "','" & txt_nom_off_ord.Text & "','" & txt_nom_off_mat.Text & "','" & txt_nom_off_det.Text & "')"
        End If
        enregistrer(req)

        req = "select cod_corps_n, cod_corps_a, lib_corps, typ_corps, rib_ccp, implantation,  cod_int, " &
            "nom_chefdecorps, nom_chefsadmin, nom_off_osm, nom_off_ord, nom_off_mat, nom_off_det  from corps"

        charger_grid_view(maform, req, DataGridView1)

        desactiver(maform, GroupBox2)
        vider(maform, GroupBox2)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)

    End Sub



    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        req = "delete from  corps where cod_corps_n=" & cod_corps_n & ""
        supprimer(req)
        desactiver(maform, GroupBox2)
        req = "select cod_corps_n, cod_corps_a, lib_corps, typ_corps, rib_ccp, implantation, cod_int, " &
           "nom_chefdecorps, nom_chefsadmin, nom_off_osm, nom_off_ord, nom_off_mat, nom_off_det  from corps"
        charger_grid_view(maform, req, DataGridView1)
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        vider(maform, GroupBox2)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        If DataGridView1.CurrentCell.RowIndex >= 0 Then
            op = "M"
            cod_corps_n = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            Txt_cod_corps_a.Text = DataGridView1(1, DataGridView1.CurrentCell.RowIndex).Value.ToString
            Txt_lib_corps.Text = DataGridView1(2, DataGridView1.CurrentCell.RowIndex).Value.ToString.Replace("''", "'")
            cbx_typ_corps.Text = DataGridView1(3, DataGridView1.CurrentCell.RowIndex).Value.ToString.Replace("''", "'")
            txt_ccp_corps.Text = DataGridView1(4, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_implantation.Text = DataGridView1(5, DataGridView1.CurrentCell.RowIndex).Value.ToString.Replace("''", "'")
            cbx_int.SelectedValue = DataGridView1(6, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_nom_chefdecorps.Text = DataGridView1(7, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_nom_chefsadmin.Text = DataGridView1(8, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_nom_off_osm.Text = DataGridView1(9, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_nom_off_ord.Text = DataGridView1(10, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_nom_off_mat.Text = DataGridView1(11, DataGridView1.CurrentCell.RowIndex).Value.ToString
            txt_nom_off_det.Text = DataGridView1(12, DataGridView1.CurrentCell.RowIndex).Value.ToString
            TabPage1.Show()

            activer(maform, GroupBox2)
            etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
            Btn_Supprimer.Enabled = True
            Btn_Enregistrer.Enabled = True
            Btn_Annuler.Enabled = True
        End If
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)

    End Sub






    Private Sub Txt_cod_corps_a_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_cod_corps_a.Validated
        If Txt_cod_corps_a.Text = "" Then

            Btn_Annuler_Click(sender, e)
            MsgBox("Créer votre corps")

        Else
            Txt_lib_corps.Focus()

        End If
    End Sub
End Class
