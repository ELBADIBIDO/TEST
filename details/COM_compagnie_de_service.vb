
Public Class COM_compagnie_de_service
    Dim req_dgv_g As String
    Private Sub COM_comagnie_de_service_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connection()
        maform = Me.Name
        req_dgv_g = "SELECT service.cod_serv, service.lib_serv, bataillon.cod_bat_a FROM service INNER JOIN bataillon ON service.cod_bat_n = bataillon.cod_bat_n order by cod_serv "
        charger_combobox(maform, "select cod_bat_a, cod_bat_n from bataillon  order by cod_bat_n", Cbx_bataillon, "cod_bat_a", "cod_bat_n")
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        op = "N"
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 100
        DataGridView1.Columns(2).Width = 100

        If Cbx_bataillon.Items.Count = 0 Then
            MsgBox("Proceder d'abord à la création de votre bataillon")
            cnn.Close()
            Me.BeginInvoke(New MethodInvoker(AddressOf Me.Close))
        Else
            Cbx_bataillon.SelectedItem = Cbx_bataillon.Items(0)
        End If
    End Sub

    Private Sub tb_r_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_r.TextChanged
        req = "SELECT service.cod_serv, service.lib_serv, bataillon.cod_bat_a " & _
            "FROM service INNER JOIN bataillon ON service.cod_bat_n = bataillon.cod_bat_n where lib_serv like '" & tb_r.Text & "%' order by cod_serv "
        charger_grid_view(maform, req, DataGridView1)
    End Sub

    Private Sub DataGridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        Btn_Annuler_Click(sender, e)
        op = "M"
        If DataGridView1.CurrentCell.RowIndex >= 0 Then
            txt_cod_serv.Text = DataGridView1(0, DataGridView1.CurrentCell.RowIndex).Value
            txt_cod_serv_Validated(sender, e)
            activer(maform, GroupBox2)
            desactiver(maform, GroupBox4)
            etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
            Btn_Supprimer.Enabled = True
            Btn_Enregistrer.Enabled = True
            Btn_Annuler.Enabled = True
        End If
    End Sub

    Private Sub Txt_lib_service_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_lib_serv.TextChanged
        If Txt_lib_serv.Text.Length <> 0 Then

            Btn_Enregistrer.Enabled = True
        Else
            Btn_Enregistrer.Enabled = False
        End If
    End Sub

    Private Sub Btn_Annuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Annuler.Click
        'op = "N"
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        activer(maform, GroupBox4)
        desactiver(maform, GroupBox2)
        etat_bout2(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        Txt_lib_serv.Focus()
    End Sub

    Private Sub Btn_nouveau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_nouveau.Click
        op = "N"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox1)
        activer(maform, GroupBox2)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        Txt_lib_serv.Focus()
    End Sub

    Private Sub Btn_Modifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Modifier.Click
        op = "M"
        etat_bout1(maform, Btn_nouveau, Btn_Modifier, Btn_Supprimer, Btn_Annuler, Btn_Enregistrer)
        desactiver(maform, GroupBox4)
        vider(maform, GroupBox1)
        vider(maform, GroupBox2)
        txt_cod_serv.Enabled = True
        txt_cod_serv.Focus()
    End Sub

    Private Sub Btn_Enregistrer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enregistrer.Click
        If op = "M" Then
            req = "update service set  lib_serv='" & Txt_lib_serv.Text.ToUpper & "', cod_bat_n=" & Cbx_bataillon.SelectedValue & " where cod_serv=" & txt_cod_serv.Text
        Else
            req = "insert into service (lib_serv, cod_bat_n) values ('" & Txt_lib_serv.Text.ToUpper & "', " & Cbx_bataillon.SelectedValue & " )"
        End If
        op = "N"
        enregistrer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        Btn_Annuler_Click(sender, e)
    End Sub

    Private Sub txt_cod_serv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_cod_serv.KeyPress
        mask_entier(sender, e)
    End Sub


    Private Sub txt_cod_serv_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_cod_serv.Validated
        dr.Close()
        If txt_cod_serv.Text <> "" Then
            desactiver(maform, GroupBox1)
            cmd.CommandText = "SELECT service.cod_serv, service.lib_serv, service.cod_bat_n FROM service INNER JOIN bataillon ON service.cod_bat_n = bataillon.cod_bat_n  where cod_serv=" & txt_cod_serv.Text
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                Txt_lib_serv.Text = dr(1)
                Cbx_bataillon.SelectedValue = dr(2)
                If op = "N" Then
                    MsgBox("Cette  Service existe déja")
                    Btn_Annuler_Click(sender, e)
                Else
                    activer(maform, GroupBox2)
                    Txt_lib_serv.SelectionStart = 0
                    Txt_lib_serv.SelectionLength = Len(Txt_lib_serv.Text)
                    Txt_lib_serv.Focus()
                    Btn_Supprimer.Enabled = True
                    Btn_Enregistrer.Enabled = True
                End If
            Else
                If op = "M" Then
                    Btn_Annuler_Click(sender, e)
                    MsgBox("Cette  Service n'existe pas")
                Else
                    Btn_Enregistrer.Enabled = True
                    activer(maform, GroupBox2)
                    Txt_lib_serv.Focus()
                End If
            End If
            dr.Close()
        End If
    End Sub

    Private Sub Btn_Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Supprimer.Click
        req = "delete * from service where cod_serv=" & txt_cod_serv.Text & ""
        supprimer(req)
        charger_grid_view(maform, req_dgv_g, DataGridView1)
        Btn_Annuler_Click(sender, e)
        op = "N"
    End Sub

    Private Sub Btn_quiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_quiter.Click
        cnn.Close()
        Me.Close()
    End Sub


End Class