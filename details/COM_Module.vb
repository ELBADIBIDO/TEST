Imports System.Data.OleDb
Imports System.Globalization
Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.IO

Module Module1

    Public cnn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|datadirectory|\\EFFICTIF.accdb;jet OLEDB:database password=1")

    Public cmd As New OleDbCommand
    Public dr As OleDbDataReader
    Public transac As OleDbTransaction
    Public app_version As String = "DII-Trésorerie version R1 du 2021-2022"
    Public op As String
    Public maform As String
    Public req As String
    Public reponse As String
    Public vind_dep As String
    Public vnud_annee, vnud_mois As Integer
    Public xyprofil, xynom As String
    Public xyatelier As String
    Public cultureFR As CultureInfo = New CultureInfo("fr-FR")
    Public cno As String
    Public info As String
    Public mle As String = ""
    Public mlem As String = ""
    Public ccpm As String = ""
    Public ccpbm As String = ""
    Public CP As String
    Public nbrenf As Integer = 0
    Public SEX As String = ""
    Public CPP As String = ""

    Sub Main()
        Dim reponse As String
        connection()
        req = "select distinct nom from utilisateur"
        cmd.CommandText = req
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            cnn.Close()
            dr.Close()
            Dim fCOM_MDItresorier As New COM_MDItresorier
            fCOM_MDItresorier.ShowDialog()

        Else
            cnn.Close()
            dr.Close()
            reponse = MsgBox("vous devez creér au moins un utilisateur ?", vbYesNo + vbCritical, "attention")
            If reponse = vbYes Then
                Dim fcom_administration_utilisateur As New com_administration_utilisateur
                fcom_administration_utilisateur.StartPosition = FormStartPosition.CenterScreen
                fcom_administration_utilisateur.ShowDialog()

            End If
        End If
    End Sub
    Public Function verif_reg(ByVal xan As Integer, ByVal xmois As Integer, ByVal xnum_reg As Integer, ByVal xnum_cheque As String, ByVal inserer As Boolean, ByVal indemenite As String) As String
        ' """""""""""" vérification des registres par indemnite '""""""""""""""""""""

        On Error Resume Next
        dr.Close()
        req = "SELECT an , mois, num_reg , statut from cheque WHERE an=" & xan & " AND moIs=" & xmois &
        " AND  num_reg=" & xnum_reg & " AND v_indeminite='" & indemenite & "'"
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Return dr(3).ToString
        Else
            If inserer = True Then
                Dim cmd1 As New OleDbCommand
                cmd1.Connection = cnn
                cmd1.CommandText = "INSERT INTO cheque (an, mois, num_reg , statut ,num_cheque ,v_indeminite) VALUES (" & xan &
                    ", " & xmois & "," & xnum_reg & ", 'OUI' ,'" & xnum_cheque & "' , '" & indemenite & "') "
                cmd1.ExecuteNonQuery()
                Return "exist"
            Else
                Return "supp"

            End If
        End If
        dr.Close()
    End Function

    Public Sub connection()
        cmd.Connection = cnn
        cmd.CommandType = CommandType.Text
        Try
            cnn.Open()
            If cnn.State <> ConnectionState.Open Then
                MsgBox("Erreur de connection", 0 + 48, "erreur")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub charger_grid_view(ByVal maform As String, ByVal req As String, ByVal gv As DataGridView)
        Try
            cmd.CommandText = req
            dr = cmd.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            With maform
                gv.DataSource = dt
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dr.Close()
    End Sub
    Public Sub charger_combobox(ByVal maform As String, ByVal req As String, ByVal cb As ComboBox, ByVal aff As String, ByVal valeur As String)
        Try
            cmd.CommandText = req
            dr = cmd.ExecuteReader
            Dim dt As New DataTable
            dt.Load(dr)
            With maform
                cb.DataSource = dt
                cb.ValueMember = valeur
                cb.DisplayMember = aff
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        dr.Close()
    End Sub

    Public Sub vider(ByVal maform As String, ByVal mongroupbox As GroupBox)
        With maform
            For Each ctl As Control In mongroupbox.Controls
                If TypeOf ctl Is TextBox Then
                    ctl.Text = Nothing
                End If
                If TypeOf ctl Is MaskedTextBox Then
                    ctl.Text = ""
                End If
            Next
        End With
    End Sub

    Public Sub activer(ByVal maform As String, ByVal mongroupbox As GroupBox)
        With maform
            For Each ctl As Control In mongroupbox.Controls
                ctl.Enabled = True
            Next
        End With
    End Sub

    Public Sub desactiver(ByVal maform As String, ByVal mongroupbox As GroupBox)
        With maform
            For Each ctl As Control In mongroupbox.Controls
                ctl.Enabled = False
            Next
        End With
    End Sub

    Public Sub enregistrer(ByVal req As String)

        dr.Close()

        Try
            cmd.CommandText = req
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub journal(ByVal xdate As Date, ByVal xnom As String, ByVal xatelier As String, ByVal xrequete As String)


        Try
            dr.Close()
            xrequete = replacer_virg_etoile(xrequete)
            Dim longueur As Integer = xrequete.Length
            Dim longueur_extract As Integer = 0
            Dim l As Integer = 0
            Dim L1 As Integer = 0
            Dim xreq As String = ""
            For xi = 0 To xrequete.Length - 1 Step 255

                If longueur - longueur_extract > 255 Then
                    xreq = xrequete.Substring(xi, 255).ToString()
                Else
                    l = longueur - longueur_extract
                    xreq = xrequete.Substring(longueur_extract, longueur - longueur_extract)
                End If
                L1 = xrequete.Length
                longueur_extract = longueur_extract + 255
                req = "insert into espion (dat_op, nom, atelier, requete) " &
                      "values ('" & xdate & "','" & xynom & "','" & xyatelier & "','" & xreq & "')"
                cmd.CommandText = req
                cmd.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub supprimer(ByVal req As String)
        Try
            Dim reponse As String
            reponse = MsgBox("Voulez - vous supprimer cet enregistrement ?", vbYesNo + vbCritical, "Suppression")
            If reponse = vbYes Then
                cmd.CommandText = req
                cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub historique_texte(ByVal xreq As String)
        'If File.Exists("C:\Windows\System32\xwhfic.txt") Then
        '    MsgBox("Exist")
        'Else
        '    MsgBox("Not Exist")
        'End If
        'Dim monStreamWriter As StreamWriter = New StreamWriter("C:\Windows\System32\xwhfic.txt", True)
        'Try
        '    monStreamWriter.WriteLine(xreq)
        '    monStreamWriter.Close()

        'Catch ex As Exception
        '    monStreamWriter.Write(ex.Message)
        'End Try

    End Sub
    Public Function double_mle(ByVal mle As String, ByVal xgrade As Integer) As Boolean
        On Error Resume Next
        dr.Close()

        If mle = "      -  -  -" And (xgrade >= 1 And xgrade <= 9) Then
            Return True

        End If

        If op = "M" Then
            req = " SELECT mat, cod_grd_n  FROM personnel where mat = '" & mle & "' and mat<>'" & mlem & "' and cod_grd_n BETWEEN 10 and 21"
        Else
            req = " SELECT mat, cod_grd_n  FROM personnel where mat = '" & mle & "' and cod_grd_n BETWEEN 10 and 21"

        End If
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Return False
        Else
            Return True
        End If

        dr.Close()
        Return False
    End Function
    Public Function double_rib_banque(ByVal xrib_banque As String) As Boolean
        On Error Resume Next
        dr.Close()
        If op = "M" Then
            req = " SELECT rib_banque  FROM personnel where rib_banque = '" & xrib_banque & "' and rib_banque <> '" & ccpbm & "'"
        Else
            req = " SELECT rib_banque  FROM personnel where rib_banque = '" & xrib_banque & "'"


        End If
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Return False
        Else
            Return True
        End If

        dr.Close()

    End Function
    Sub ecriture_adresse_mac(ByVal xadresse As String)

        Dim p1 As String

        If Directory.Exists("c:\users") Then
            p1 = "c:\users\myAppData86"
        Else
            p1 = "d:\users\myAppData86"

        End If

        If Not Directory.Exists(P1) Then
            My.Computer.FileSystem.CreateDirectory(P1)
        End If
        Dim monStreamWriter As StreamWriter = New StreamWriter(p1 & "aaclient11.txt", True)
        Try
            monStreamWriter.WriteLine(xadresse)
            monStreamWriter.Close()
        Catch ex As Exception
            monStreamWriter.Write(ex.Message)
        End Try
    End Sub

    Public Function lecture_adresse_mac(ByVal xadresse As String) As String
        If Not File.Exists("%APPDATA\aaclient11.txt") Then
            Return ""
        End If

        Dim monStreamReader As StreamReader = New StreamReader("%APPDATA\aaclient11.txt", True)
        Dim ligne As String
        Try
            ligne = monStreamReader.ReadLine()
            monStreamReader.Close()
            Return ligne
        Catch ex As Exception
            monStreamReader.Close()
            Return ""
        End Try

    End Function

    Public Function convertir_chaine_ascii(ByVal xchaine As String) As String
        Dim chaine_ascii As String = ""
        For i = 0 To Len(xchaine) - 1
            chaine_ascii = chaine_ascii & Asc(xchaine.Substring(i, 1)).ToString
        Next
        Return chaine_ascii
    End Function
    Public Function convertir_ascii_chaine(ByVal xchaine As String) As String
        Dim chaine_ascii As String = ""
        For i = 0 To Len(xchaine) - 1 Step 2
            chaine_ascii = chaine_ascii & Chr(Val(xchaine.Substring(i, 2)))
        Next
        Return chaine_ascii
    End Function


    Public Sub etat_bout1(ByVal maform As String, ByVal btn_nouveau As Button, ByVal btn_modifier As Button, ByVal btn_supprimer As Button, ByVal btn_annuler As Button, ByVal btn_enregistrer As Button)
        With maform
            btn_nouveau.Enabled = False
            btn_modifier.Enabled = False
            btn_annuler.Enabled = True
            btn_supprimer.Enabled = False
            btn_enregistrer.Enabled = False
        End With
    End Sub

    Public Sub etat_bout2(ByVal maform As String, ByVal btn_nouveau As Button, ByVal btn_modifier As Button, ByVal btn_supprimer As Button, ByVal btn_annuler As Button, ByVal btn_enregistrer As Button)
        With maform
            btn_nouveau.Enabled = True
            btn_modifier.Enabled = True
            btn_supprimer.Enabled = False
            btn_annuler.Enabled = False
            btn_enregistrer.Enabled = False
        End With
    End Sub

    Public Sub TextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "."c Then
            CType(sender, TextBox).SelectedText = ","c
            e.Handled = True
        End If
    End Sub


    Public Sub mask_decimal(ByVal w As MaskedTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char
        ch = e.KeyChar
        Dim y As String
        y = w.Text
        If ch = Convert.ToChar(46) And w.Text.IndexOf(".") <> -1 Then
            e.Handled = True
            Return
        End If
        Dim z As String
        If ch = Convert.ToChar(45) Then
            If w.Text = Nothing Then
                Return
            Else
                e.Handled = True
                Return
            End If
        End If

        If ch = Convert.ToChar(46) Then

            If w.Text = Nothing Then
                e.Handled = True
                Return
            Else
                z = Convert.ToChar(45)
                If w.Text = z.ToString Then
                    e.Handled = True
                    Return
                End If
            End If

        End If

        If ch = Convert.ToChar(45) And w.Text.IndexOf("-") <> -1 Then
            e.Handled = True
            Return
        End If
        If (Char.IsDigit(ch) = False And ch <> Convert.ToChar(8) And ch <> Convert.ToChar(46)) Then
            e.Handled = True
        End If

        If w.Text.Contains(".") And ch <> Convert.ToChar(8) Then
            If w.Text.Split(".")(1).Length = 2 Then
                e.Handled = True
            End If
        End If
    End Sub

    Public Sub mask_entier(ByVal w As TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(48) Then
            If Mid(w.Text, 1, 1) = "" Then
                MsgBox("zéro en premier impossible")
                e.Handled = True
                Return
            End If
        End If

        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(8), Chr(9)
                e.Handled = False
            Case Else
                MsgBox("Taper un numérique")
                e.Handled = True
        End Select
    End Sub

    Public Sub mask_entier_mtb(ByVal w As MaskedTextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(48) Then
            If Mid(w.Text, 1, 1) = "" Then
                MsgBox("zéro en premier impossible")
                e.Handled = True
                Return
            End If
        End If

        Select Case e.KeyChar
            Case Chr(48) To Chr(57), Chr(8), Chr(9)
                e.Handled = False
            Case Else
                MsgBox("Taper un numérique")
                e.Handled = True
        End Select
    End Sub
    Public Sub sauvegarde()
        My.Computer.FileSystem.CopyFile("tresorerie.accdb",
                                        Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) & "\tresorerie.accdb",
                                        Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
    End Sub
    Public Function Address_mac()
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

    Public Function replacer_virg_etoile(ByVal xreq As String) As String
        xreq = xreq.Replace("'", "$")
        Return xreq.Replace(",", "*")
    End Function
    Public Function nombreTolettre(ByVal nb_dec As Double) As String
        MsgBox(nb_dec.ToString)

        If nb_dec > 999999999999.99 Then
            MsgBox("trop grand")
            Return ("trop grand")
        End If

        Dim i As Integer = 1
        Dim j As Integer = 1
        Dim nb_cent As Integer
        Dim nb_ucent As Integer
        Dim nb_udiz As Integer
        Dim nbretolet, ch_cent, ch_diz, le_s, le_et, le_moins As String
        nbretolet = ""
        ch_cent = ""
        ch_diz = ""
        le_s = ""
        le_et = ""
        le_moins = ""
        If nb_dec < 0.0 Then
            nb_dec = Math.Abs(nb_dec)
            le_moins = "Moins "
        End If
        Dim nb_ent(3) As Double
        nb_ent(1) = Fix(nb_dec)
        nb_ent(2) = Val(Right(nb_dec.ToString("###,###,###,##0.00"), 2))

        Dim tabdh() As String = {"", "Dh", "Centime"}
        Dim tabdiv() = {1000000000, 1000000, 1000, 1}
        Dim tab00() As String = {"", "Milliard", "Million", "Mille", ""}
        Dim tab01() As String = {"", "Un", "Deux", "Trois", "Quatre", "Cinq", "Six", "Sept",
           "Huit", "Neuf", "Dix", "Onze", "Douze", "Treize", "Quatorze", "Quinze",
           "Seize", "Dix-sept", "Dix-huit", "Dix-neuf"}
        Dim tab10() As String = {"", "", "Vingt", "Trente", "Quarante", "Cinquante",
            "Soixante", "Soixante", "Quatre-vingt", "Quatre-vingt"}


        For j = 1 To 2
            If nb_ent(j) > 1 Then
                le_s = "s"
            Else
                le_s = ""
            End If
            For i = 1 To 4
                ch_cent = ""
                ch_diz = ""
                If nb_ent(j) = 0 Then
                    nbretolet = LTrim(nbretolet) & " Zéro "
                    Exit For
                End If
                nb_cent = Int(nb_ent(j) / tabdiv(i - 1))
                If nb_cent <> 0 Then
                    nb_ucent = Int(nb_cent / 100)
                    If nb_ucent <> 0 Then
                        If nb_ucent <> 1 Then
                            ch_cent = tab01(nb_ucent) & " Cents"
                        Else
                            ch_cent = " Cent"
                        End If

                    End If
                    nb_udiz = nb_cent - nb_ucent * 100
                    If nb_udiz <> 0 Then
                        If nb_udiz = 21 Or nb_udiz = 31 Or nb_udiz = 41 Or nb_udiz = 51 Or nb_udiz = 61 Or nb_udiz = 71 Or nb_udiz = 81 Or nb_udiz = 91 Then
                            le_et = " et "
                        Else
                            le_et = " "
                        End If
                        Select Case nb_udiz
                            Case 1 To 19
                                ch_diz = tab01(nb_udiz)
                            Case 20, 30, 40, 50, 60
                                ch_diz = tab10(nb_udiz / 10)
                            Case 61 To 79
                                ch_diz = tab10(6) & le_et & tab01(nb_udiz - 60)
                            Case 81 To 99
                                ch_diz = tab10(8) & le_et & tab01(nb_udiz - 80)
                            Case Else
                                Dim x, y As Integer
                                x = Int(nb_udiz / 10)
                                y = nb_udiz - (x * 10)
                                ch_diz = tab10(x) & le_et & tab01(y)
                        End Select

                    End If
                    If nb_cent = 1 And i = 3 Then ''éliminer un mille 
                        ch_diz = ""
                    End If
                    nb_ent(j) = nb_ent(j) - (nb_cent * CDbl(tabdiv(i - 1)))
                    nbretolet = LTrim(nbretolet) & " " & ch_cent & " " & ch_diz & " " & tab00(i)
                End If

                If nb_ent(j) = 0 Then
                    Exit For
                End If
            Next
            nbretolet = Trim(nbretolet) & " " & tabdh(j) & le_s
        Next
        Return LTrim(le_moins) & nbretolet
    End Function
    Public Sub selectionner(ByVal ctl As Object)
        If (TypeOf ctl Is TextBox Or TypeOf ctl Is MaskedTextBox) Then
            ctl.SelectionStart = 0
            ctl.SelectionLength = Len(ctl.Text)
        End If
    End Sub

    Public Sub init_tb(ByVal ctl As Object)

        If TypeOf ctl Is TextBox Then
            ctl.Text = Nothing
        ElseIf TypeOf ctl Is MaskedTextBox Then
            ctl.Text = 0
            ctl.TextAlign = HorizontalAlignment.Right
        End If
    End Sub
    Public Function convertir_date_pv(ByVal xdate) As String
        Return "L'an " & (xdate.Value.Date.Year).ToString & ", le " & (xdate.Value.Date.day).ToString & " " & MonthName(xdate.Value.Date.Month)
    End Function
    Public Function convertir_date_chaine(ByVal xdate) As String
        If DateTime.TryParse(xdate.ToString(), Date.Now) Then
            Return xdate.ToString()
        Else
            Return "null"
        End If
    End Function
    Public Function conv_prem_char_maj(ByVal xchaine) As String
        Return Char.ToUpper(xchaine.chars(0)) + xchaine.substring(1, xchaine.length - 1)
    End Function
    Public Function verfier_caractere_ou_numerique(ByVal xchaine As String) As Boolean
        If xchaine = "" Then
            Return False
        End If
        For i = 0 To Len(xchaine.ToString) - 1
            Select Case Asc(xchaine.ToString.Substring(i, 1))

                Case 48 To 57, 65 To 90, 97 To 122

                Case Else
                    Return False
            End Select
        Next
        Return True
    End Function

    Public Function convertir_mois_en_lettre(ByVal xmois As Integer) As String
        Dim xmois_lettre As String = ""
        Select Case xmois
            Case 1
                xmois_lettre = "JANVIER"
            Case 2
                xmois_lettre = "FEVRIER"
            Case 3
                xmois_lettre = "MARS"
            Case 4
                xmois_lettre = "AVRIL"
            Case 5
                xmois_lettre = "MAI"
            Case 6
                xmois_lettre = "JUIN"
            Case 7
                xmois_lettre = "JUILLET"
            Case 8
                xmois_lettre = "AOUT"
            Case 9
                xmois_lettre = "SEPTEMBRE"
            Case 10
                xmois_lettre = "OCTOBRE"
            Case 11
                xmois_lettre = "NOVEMBRE"
            Case 12
                xmois_lettre = "DECEMBRE"
            Case Else
                xmois_lettre = ""
        End Select
        Return xmois_lettre
    End Function

    Public Function double_emploi(ByRef xdep As Date, ByRef xret As Date, ByVal xcni As String, ByVal xan As Integer, ByVal xmois As Integer, ByVal xnum_reg As Integer, ByVal xordre As Integer, ByVal xop As String) As String
        On Error Resume Next
        dr.Close()
        xdep = Format(xdep, "dd/MM/yyyy")
        xret = Format(xret, "dd/MM/yyyy")
        Dim xcpt As Integer = 0
        Dim xchaine As String = ""
        'absence(temporaire)
        req = "SELECT  an, mois, num_reg, ordre from ind_temp where (( #" & Format(xdep, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (#" & _
                Format(xret, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (dat_dep between  #" & Format(xdep, "MM/dd/yyyy") & _
                "# and #" & Format(xret, "MM/dd/yyyy") & "#) or (dat_ret between  #" & Format(xdep, "MM/dd/yyyy") & "# and #" & _
                Format(xret, "MM/dd/yyyy") & "#))  and (cni ='" & xcni & "')"
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            If xop = "N" Then
                dr.Read()
                xchaine = "absence temporaire année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                dr.Close()
                Return xchaine
            Else
                While dr.Read
                    If (dr(0) = xan And dr(1) = xmois And dr(2) = xnum_reg And dr(3) = xordre) Then
                        xcpt = xcpt + 1
                    Else
                        xchaine = xchaine & " " & "absence temporaire année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                    End If

                End While
                If xchaine <> "" Then
                    dr.Close()
                    Return xchaine
                End If
            End If
        End If
        dr.Close()

        ' absence journalière
        req = "SELECT  an, mois, num_reg, ordre from ind_jour where (( #" & Format(xdep, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (#" & _
            Format(xret, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (dat_dep between  #" & Format(xdep, "MM/dd/yyyy") & _
            "# and #" & Format(xret, "MM/dd/yyyy") & "#) or (dat_ret between  #" & Format(xdep, "MM/dd/yyyy") & "# and #" & _
            Format(xret, "MM/dd/yyyy") & "#)) and (cni ='" & xcni & "')"
        cmd.CommandText = req
        dr = cmd.ExecuteReader

        If dr.HasRows Then
            If xop = "N" Then
                dr.Read()
                xchaine = "indemnité journalière année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                dr.Close()
                Return xchaine
            Else
                While dr.Read
                    If (dr(0) = xan And dr(1) = xmois And dr(2) = xnum_reg And dr(3) = xordre) Then
                        xcpt = xcpt + 1
                    Else
                        xchaine = xchaine & " " & "indemnité journalière année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                    End If

                End While
                If xchaine <> "" Then
                    dr.Close()
                    Return xchaine
                End If
            End If
        End If
        dr.Close()

        ' absence excéptionnelle

        req = "SELECT  an, mois, num_reg, ordre from ind_excep where (( #" & Format(xdep, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (#" & _
            Format(xret, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (dat_dep between  #" & Format(xdep, "MM/dd/yyyy") & _
            "# and #" & Format(xret, "MM/dd/yyyy") & "#) or (dat_ret between  #" & Format(xdep, "MM/dd/yyyy") & "# and #" & _
            Format(xret, "MM/dd/yyyy") & "#)) and (cni ='" & xcni & "')"
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            If xop = "N" Then
                dr.Read()
                xchaine = "registre indemnité exceptionnalle année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                dr.Close()
                Return xchaine
            Else
                While dr.Read
                    If (dr(0) = xan And dr(1) = xmois And dr(2) = xnum_reg And dr(3) = xordre) Then
                        xcpt = xcpt + 1
                    Else
                        xchaine = xchaine & " " & "registre indemnité exceptionnalle année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                    End If

                End While
                If xchaine <> "" Then
                    dr.Close()
                    Return xchaine
                End If
            End If
        End If
        dr.Close()

        ' absence gardiennage
        req = "SELECT  an, mois, num_reg, ordre from ind_gard where (( #" & Format(xdep, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (#" & _
            Format(xret, "MM/dd/yyyy") & "# between dat_dep and dat_ret) or (dat_dep between  #" & Format(xdep, "MM/dd/yyyy") & _
            "# and #" & Format(xret, "MM/dd/yyyy") & "#) or (dat_ret between  #" & Format(xdep, "MM/dd/yyyy") & "# and #" & _
            Format(xret, "MM/dd/yyyy") & "#)) and (cni ='" & xcni & "')"
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            If xop = "N" Then
                dr.Read()
                xchaine = "registre indemnité gardiennage année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                dr.Close()
                Return xchaine
            Else
                While dr.Read
                    If (dr(0) = xan And dr(1) = xmois And dr(2) = xnum_reg And dr(3) = xordre) Then
                        xcpt = xcpt + 1
                    Else
                        xchaine = xchaine & " " & "registre indemnité gardiennage année " & dr(0) & " mois " & dr(1) & " registre " & dr(2) & " ordre " & dr(3)
                    End If

                End While
                If xchaine <> "" Then
                    dr.Close()
                    Return xchaine
                End If
            End If
        End If
        dr.Close()

        If xcpt < 2 Then
            Return "OK"
        Else
            Return xchaine
        End If


    End Function

    Public Function double_compte(ByVal xrib_ccp As String) As Boolean
        On Error Resume Next
        dr.Close()
        'dr.Close()
        'req = " SELECT count(*) FROM personnel p " &
        '    " where (p.cni <>'" & xcni & "' And ((p.rib_ccp = '" & xrib_ccp & "' and p.rib_ccp <>'') " &
        '    " or (p.rib_banque='" & xrib_banque & "' and p.rib_banque<>''" & ")))"
        'cmd.CommandText = req
        'Dim cpt As Int32 = Convert.ToInt32(cmd.ExecuteScalar)
        'Return cpt
        If op = "M" Then
            req = " SELECT rib_ccp  FROM personnel where rib_ccp = '" & xrib_ccp & "' and rib_ccp <> '" & ccpm & "' "
        Else
            req = " SELECT rib_ccp  FROM personnel where rib_ccp = '" & xrib_ccp & "'"

        End If
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            Return False
        Else
            Return True
        End If

        dr.Close()


    End Function

    Public Function je_suis_au_dernier_regisrte(ByVal xind_dep As String, ByVal xan As Integer, ByVal xmois As Integer, ByVal xnum_reg As Integer) As Boolean
        Dim xxan, xxmois, xxnum_reg As Integer
        req = "select an, mois, num_reg from " & xind_dep & " where (((an*12)+mois)*10000)+num_reg>" & (((xan * 12) + xmois) * 10000) + xnum_reg
        cmd.CommandText = req
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            dr.Read()
            xxan = dr(0)
            xxmois = dr(1)
            xxnum_reg = dr(2)
            dr.Close()
            Return False
        Else
            dr.Close()
            Return True
        End If

    End Function


    Public Function format_cin(ByVal xcin As String) As String
        Dim xcin_a, xcin_n, xcaract As String
        xcin = xcin.ToUpper
        xcin_n = ""
        xcin_a = ""
        For i = 0 To Len(xcin.Trim) - 1
            xcaract = xcin.Substring(i, 1)
            If Asc(xcaract) >= 48 And Asc(xcaract) <= 57 Then
                xcin_n = xcin_n.Trim + xcaract.Trim
            Else
                xcin_a = xcin_a.Trim + xcaract.Trim
            End If
        Next
        'If xcin_a <> "" And xcin_n <> "" Then
        Return xcin_a.Trim + Str(Val(xcin_n.Trim)).Trim
        'Else
        '    Return ""
        'End If
    End Function
    

    Public Function montant_registre(ByVal xnud_annee As Integer, ByVal xnud_mois As Integer, ByVal xtxt_n_reg As Integer, ByVal xind_dep As String) As Decimal

        On Error Resume Next
        dr.Close()
        Dim xmontant_registre As Decimal
        xmontant_registre = 0
        Select Case xind_dep
            Case "temp"
                req = " SELECT SUM ((dat_ret-dat_dep + 1) * taux_temp) as txt_mt_reg FROM ind_temp " &
                    "where (ind_temp.an = " & xnud_annee & " And ind_temp.mois = " & xnud_mois &
                    " And ind_temp.num_reg = " & xtxt_n_reg & ") GROUP BY an, mois, num_reg"
            Case "jour"

                req = " SELECT sum(int(((taux_jour*nbjrs_n)+(tauxr_jour*nbjrs_r)+(ind_jour.part*(taux_jour/3)))*100)/100) as txt_mt_reg,an, mois, num_reg " &
                   "FROM ind_jour where ind_jour.an = " & xnud_annee & " And ind_jour.mois = " & xnud_mois & " And ind_jour.num_reg = " & xtxt_n_reg & " GROUP BY an, mois, num_reg"

            Case "gard"
                req = " SELECT SUM ((dat_ret-dat_dep + 1) * taux_gard) as txt_mt_reg FROM ind_gard " &
                    "where (ind_gard.an = " & xnud_annee & " And ind_gard.mois = " & xnud_mois &
                    " And ind_gard.num_reg = " & xtxt_n_reg & ") GROUP BY an, mois, num_reg"
            Case "excep"
                req = " SELECT SUM ((dat_ret-dat_dep + 1) * taux_excep) as txt_mt_reg FROM ind_excep " &
                    "where (ind_excep.an = " & xnud_annee & " And ind_excep.mois = " & xnud_mois &
                    " And ind_excep.num_reg = " & xtxt_n_reg & ") GROUP BY an, mois, num_reg"
            Case "kilo"
                req = " SELECT SUM (mont_kilo) as txt_mt_reg FROM ind_kilo " &
                    "where (ind_kilo.an = " & xnud_annee & " And ind_kilo.mois = " & xnud_mois &
                    " And ind_kilo.num_reg = " & xtxt_n_reg & ") GROUP BY an, mois, num_reg"
            Case "resid"
                '**----------------calcul montant de registre-------------------
                req = " SELECT ind_resid.an, ind_resid.mois, ind_resid.num_reg, ind_resid.ordre, personnel.mat, personnel.som," &
                          " personnel.prenom, personnel.nom, iif(isnull(ind_resid.echelle),0,ind_resid.echelle), iif(isnull(ind_resid.echelon),0,ind_resid.echelon), ind_resid.sit_fam, ind_resid.cod_grd_n," &
                          " grade.cod_grd_a, personnel.rib_ccp, personnel.mode_pay, ind_resid.ref_dep, ind_resid.taux_ij, ind_resid.indice," &
                          " ind_resid.dat_ref, ind_resid.dat_mut, ind_resid.garnison_dep, ind_resid.garnison_arriv, personnel.cni, " &
                          " ind_resid.unite_dep, ind_resid.sex_enf1, ind_resid.sex_enf2, ind_resid.sex_enf3, ind_resid.sex_enf4," &
                          " ind_resid.sex_enf5, ind_resid.sex_enf6, ind_resid.dat_nais_enf1, ind_resid.dat_nais_enf2, ind_resid.dat_nais_enf3, " &
                          " ind_resid.dat_nais_enf4,ind_resid.dat_nais_enf5, ind_resid.dat_nais_enf6," &
                          " iif(isnull(ind_resid.tarif_1_4_mvf1),0,ind_resid.tarif_1_4_mvf1),iif(isnull(ind_resid.tarif_1_2_epvf1),0,ind_resid.tarif_1_2_epvf1), ind_resid.ville_vf1_dep, ind_resid.ville_vf1_arriv, iif(isnull(ind_resid.nbre_km_vf1),0,ind_resid.nbre_km_vf1)," &
                          " iif(isnull(ind_resid.tarif_1_4_mvf2),0,ind_resid.tarif_1_4_mvf2), iif(isnull(ind_resid.tarif_1_2_epvf2),0,ind_resid.tarif_1_2_epvf2), ind_resid.ville_vf2_dep, ind_resid.ville_vf2_arriv, iif(isnull(ind_resid.nbre_km_vf2),0,ind_resid.nbre_km_vf2)," &
                          " iif(isnull(ind_resid.tarif_car1),0,ind_resid.tarif_car1), ind_resid.ville_vr1_dep, ind_resid.ville_vr1_arriv, iif(isnull(ind_resid.nbre_km_vr1),0,ind_resid.nbre_km_vr1)," &
                          " iif(isnull(ind_resid.tarif_car2),0,ind_resid.tarif_car2), ind_resid.ville_vr2_dep, ind_resid.ville_vr2_arriv, iif(isnull(ind_resid.nbre_km_vr2),0,ind_resid.nbre_km_vr2), " &
                          " ind_resid.loge, ind_resid.dossier, iif(isnull(ind_resid.solde_base),0,ind_resid.solde_base)" &
                          " FROM (personnel INNER JOIN ind_resid ON personnel.cni = ind_resid.cni) INNER JOIN grade " &
                          " ON ind_resid.cod_grd_n = grade.cod_grd_n " &
                          " where (ind_resid.an=" & xnud_annee & " and ind_resid.mois =" & xnud_mois & " and  ind_resid.num_reg = " & xtxt_n_reg & " ) order by ind_resid.ordre"

        End Select

        cmd.CommandText = req
        dr = cmd.ExecuteReader
        xmontant_registre = 0

        Select Case xind_dep
            Case "temp", "jour", "gard", "excep", "kilo"
                dr.Read()
                If dr.HasRows Then
                    xmontant_registre = dr(0)
                Else
                    xmontant_registre = 0
                End If
            Case "resid"

                While dr.Read
                    Dim vdtp_enf_1, vdtp_enf_2, vdtp_enf_3, vdtp_enf_4, vdtp_enf_5, vdtp_enf_6 As String
                    ' Calcul du nombre des enfants
                    vdtp_enf_1 = convertir_date_chaine(IIf(IsDBNull(dr(30)), " ", dr(30)))
                    vdtp_enf_2 = convertir_date_chaine(IIf(IsDBNull(dr(31)), " ", dr(31)))
                    vdtp_enf_3 = convertir_date_chaine(IIf(IsDBNull(dr(32)), " ", dr(32)))
                    vdtp_enf_4 = convertir_date_chaine(IIf(IsDBNull(dr(33)), " ", dr(33)))
                    vdtp_enf_5 = convertir_date_chaine(IIf(IsDBNull(dr(34)), " ", dr(34)))
                    vdtp_enf_6 = convertir_date_chaine(IIf(IsDBNull(dr(35)), " ", dr(35)))

                    Dim xnbr_enf_m4, xnbr_enf_4a10, xnbr_enf_10a21, xnbr_enf_f_p21, xnbr_enf_p10, xnbr_enf_0a10, xtot_nbr_enf, xtranche As Integer
                    Dim montableau() As String = {vdtp_enf_1, vdtp_enf_2, vdtp_enf_3, vdtp_enf_4, vdtp_enf_5, vdtp_enf_6}
                    xnbr_enf_m4 = calcul_age(montableau, dr(19), 0, 1460)
                    xnbr_enf_4a10 = calcul_age(montableau, dr(19), 1460, 3650)
                    xnbr_enf_10a21 = calcul_age(montableau, dr(19), 3650, 7665)
                    xnbr_enf_f_p21 = calcul_age(montableau, dr(19), 7665, 40000)
                    xnbr_enf_p10 = xnbr_enf_10a21 + xnbr_enf_f_p21
                    xnbr_enf_0a10 = xnbr_enf_m4 + xnbr_enf_4a10
                    xtot_nbr_enf = xnbr_enf_m4 + xnbr_enf_4a10 + xnbr_enf_10a21 + xnbr_enf_f_p21

                    ' Calcul de l'indemnité kilometrique----------voie ferrée
                    Dim xdecvf1, xdecvf2, xdecvf3, xdecvf4, xdecvf5, xdecvf6, xdecvf7, xdecvf8, xdecvf As Decimal
                    calcul_ikvf(xdecvf1, xdecvf2, xdecvf3, xdecvf4, xnbr_enf_4a10, xnbr_enf_10a21, xnbr_enf_f_p21, dr(10), dr(36), dr(37))
                    'calcul_ikvf(xdecvf1, xdecvf2, xdecvf3, xdecvf4, xnbr_enf_4a10, xnbr_enf_10a21, xnbr_enf_f_p21, dr(10), vdtp_enf_5, vdtp_enf_6)
                    calcul_ikvf(xdecvf5, xdecvf6, xdecvf7, xdecvf8, xnbr_enf_4a10, xnbr_enf_10a21, xnbr_enf_f_p21, dr(10), dr(41), dr(42))
                    xdecvf = xdecvf1 + xdecvf2 + xdecvf3 + xdecvf4 + xdecvf5 + xdecvf6 + xdecvf7 + xdecvf8

                    ' Calcul de l'indemnité kilometrique----------voie routière
                    Dim xdecvr, xdecvr1, xdecvr2, xdecvr3, xdecvr4 As Decimal
                    calcul_ikvr(xdecvr1, xdecvr2, xnbr_enf_m4, xnbr_enf_4a10, xnbr_enf_10a21, xnbr_enf_f_p21, dr(10), dr(46))
                    calcul_ikvr(xdecvr3, xdecvr4, xnbr_enf_m4, xnbr_enf_4a10, xnbr_enf_10a21, xnbr_enf_f_p21, dr(10), dr(50))
                    xdecvr = xdecvr1 + xdecvr2 + xdecvr3 + xdecvr4

                    ' Calcul du frais d'emballage et du transport du mobilier
                    Dim xtaux_femb, xfemb, xfemb_m, xfemb_ep, xfemb_enf As Decimal
                    xtranche = calcul_tranches(dr(40) + dr(45) + dr(49) + dr(53))
                    calcul_frais_emballage(xfemb_m, xfemb_ep, xfemb_enf, xtaux_femb, xtot_nbr_enf, dr(10), dr(11), xtranche, dr(55))
                    xfemb = xfemb_m + xfemb_ep + xfemb_enf


                    ' Calcul de l'indémnité journaliere dite attendte de mobilier
                    Dim xdec_ij, xdec_ij_m, xdec_ij_ep, xdec_ij_enf As Decimal
                    calcul_att_du_mobilier(xdec_ij_m, xdec_ij_ep, xdec_ij_enf, xtot_nbr_enf, dr(10), dr(11), dr(16), xtranche)
                    xdec_ij = xdec_ij_m + xdec_ij_ep + xdec_ij_enf


                    ' Calcul de l'indémnité spéciale ou changement de résidence
                    Dim xdec_is, xdec_is_m, xdec_is_ep, xdec_is_enf As Decimal
                    Dim xobs_is As String
                    xobs_is = ""
                    ' xsolde_base = calcul_solde_base(dr(11), dr(8), dr(9), dr(16))
                    'calcul_ind_spec_ch_resid(xdec_is_m, xdec_is_ep, xdec_is_enf, xobs_is, xtot_nbr_enf, dr(11), dr(10), dr(55), xtranche, dr(15), dr(55))
                    calcul_ind_spec_ch_resid(xdec_is_m, xdec_is_ep, xdec_is_enf, xobs_is, xtot_nbr_enf, dr(11), dr(10), dr(56), xtranche, dr(16), dr(55))

                    xdec_is = xdec_is_m + xdec_is_ep + xdec_is_enf
                    xmontant_registre = xmontant_registre + xdecvr + xdecvf + xfemb + xdec_ij + xdec_is
                End While
        End Select

        dr.Close()
        Return xmontant_registre
    End Function

    Public Function nombre_milit(ByRef xreq As String) As Integer
        On Error Resume Next
        dr.Close()
        Dim xtot_n_ord As Integer
        cmd.CommandText = xreq
        dr = cmd.ExecuteReader
        dr.Read()
        If IsDBNull(dr(0)) Then
            xtot_n_ord = 0
        Else
            xtot_n_ord = dr(0)
        End If
        dr.Close()
        Return xtot_n_ord
    End Function

    Public Function calcul_age(ByVal xtableau As Array, ByVal xdat_mut As Date, ByVal xage_min As Integer, ByVal xage_max As Integer) As Integer
        Dim xnbr As Integer = 0
        For xi = 0 To UBound(xtableau)
            If xtableau(xi) <> "null" Then
                If DateDiff(DateInterval.Day, xtableau(xi), xdat_mut) >= xage_min And DateDiff(DateInterval.Day, xtableau(xi), xdat_mut) < xage_max Then
                    xnbr = xnbr + 1
                End If
            End If
        Next
        Return xnbr

    End Function




    Public Sub calcul_ikvf(ByRef xdecvf_m As Decimal, ByRef xdecvf_ep As Decimal, ByRef xdecvf_p10 As Decimal, ByRef xdecvf_4a10 As Decimal, ByVal x4a10 As Integer, ByVal x10a21 As Integer, ByVal xfp21 As Integer, ByVal xsit_fam As String, ByVal xt1_4mvf As Decimal, ByVal xt1_2epvf As Decimal)
        xdecvf_m = 0
        xdecvf_ep = 0
        xdecvf_p10 = 0
        xdecvf_4a10 = 0
        If xsit_fam = "MARIE" Then
            xdecvf_m = xt1_4mvf
            xdecvf_ep = xt1_2epvf
            xdecvf_p10 = (x10a21 * xt1_2epvf) + (xfp21 * xt1_2epvf)
            xdecvf_4a10 = (x4a10 * xt1_4mvf)

        ElseIf xsit_fam = "CELIBATAIRE" Then
            xdecvf_m = xt1_4mvf
            xdecvf_ep = 0
            xdecvf_p10 = 0
            xdecvf_4a10 = 0
            'xmontant_ikvf = Math.Truncate(xmontant_ikvf * 100) / 100

        Else ' ----------veuf   ou    divorcé---------------------
            xdecvf_m = xt1_4mvf
            xdecvf_ep = 0
            xdecvf_p10 = (x10a21 * xt1_2epvf) + (xfp21 * xt1_2epvf)
            xdecvf_4a10 = (x4a10 * xt1_4mvf)
            ' xmontant_ikvf = Math.Truncate(xmontant_ikvf * 100) / 100
        End If
    End Sub

    Public Sub calcul_ikvr(ByRef xdecvr_m As Decimal, ByRef xdecvr_fam As Decimal, ByVal xm4 As Integer, ByVal x4a10 As Integer, ByVal x10a21 As Integer, ByVal xfp21 As Integer, ByVal xsit_fam As String, ByVal xt_vr As Decimal)
        xdecvr_m = 0
        xdecvr_fam = 0
        If xsit_fam = "MARIE" Then
            xdecvr_m = xt_vr
            xdecvr_fam = ((xm4 + x4a10 + x10a21 + xfp21) * xt_vr) + xt_vr
        ElseIf xsit_fam = "CELIBATAIRE" Then
            xdecvr_m = xt_vr
            xdecvr_fam = 0
        Else ' ----------veuf   ou    divorcé---------------------
            xdecvr_m = xt_vr
            xdecvr_fam = (xm4 + x4a10 + x10a21 + xfp21) * xt_vr
        End If
    End Sub

    Public Function calcul_tranches(ByVal xdistance As Integer) As Integer
        Dim xtranche As Integer = 0
        If xdistance <> 0 Then
            xtranche = Math.Round(Int(xdistance / 600), 2)
        Else
            xtranche = 0
        End If
        If xdistance Mod 600 <> 0 Then
            xtranche = xtranche + 1
        End If
        Return xtranche
    End Function
    Public Sub calcul_frais_emballage(ByRef xfemb_m As Decimal, ByRef xfemb_ep As Decimal, ByRef xfemb_enf As Decimal, ByRef xtaux_femb As Decimal, ByVal xtot_nbre_enf As Integer, ByVal xsit_fam As String, ByVal xcod_grd_n As Integer, ByVal xtranche As Integer, ByVal xdossier As String)
        xfemb_m = 0
        xfemb_ep = 0
        xfemb_enf = 0
        xtaux_femb = 0
        If xdossier = "COMPLET" Then
            If xsit_fam = "MARIE" Then
                Select Case xcod_grd_n
                    Case Is <= 9
                        xtaux_femb = 600
                    Case 10 To 15
                        xtaux_femb = 400
                    Case Is > 15
                        xtaux_femb = 200
                End Select
                xfemb_m = xtaux_femb * xtranche
                xfemb_ep = xtaux_femb * xtranche
                xfemb_enf = xtot_nbre_enf * xtaux_femb * xtranche
            ElseIf xsit_fam = "CELIBATAIRE" Then
                Select Case xcod_grd_n
                    Case Is <= 9
                        xtaux_femb = 300
                    Case 10 To 22
                        xtaux_femb = 200
                End Select
                xfemb_m = xtaux_femb * xtranche
                xfemb_ep = 0
                xfemb_enf = 0
            Else
                Select Case xcod_grd_n
                    Case Is <= 9
                        xtaux_femb = 600
                    Case 10 To 15
                        xtaux_femb = 400
                    Case Is > 15
                        xtaux_femb = 200
                End Select
                xfemb_m = xtaux_femb * xtranche
                xfemb_ep = 0
                xfemb_enf = xtot_nbre_enf * xtaux_femb * xtranche
            End If
        End If
    End Sub

    Public Sub calcul_att_du_mobilier(ByRef xdec_ij_m As Decimal, ByRef xdec_ij_ep As Decimal, ByRef xdec_ij_enf As Decimal, ByVal xtot_nbre_enf As Integer, ByVal xsit_fam As String, ByVal xcod_grd_n As Integer, ByVal xtaux_ij As Decimal, ByVal xtranche As Integer)
        xdec_ij_m = 0
        xdec_ij_ep = 0
        xdec_ij_enf = 0


        If xsit_fam = "MARIE" Then
            xdec_ij_m = (xtranche * xtaux_ij)
            xdec_ij_ep = (Math.Round((0.5 * xtaux_ij), 2) * xtranche)
            xdec_ij_enf = (xtot_nbre_enf * Math.Round((0.25 * xtaux_ij), 2) * xtranche)

        ElseIf xsit_fam = "CELIBATAIRE" Then
            xdec_ij_m = (xtranche * xtaux_ij)
        Else ' ----------veuf   ou    divorcé---------------------
            xdec_ij_m = (xtranche * xtaux_ij)
            xdec_ij_enf = (xtot_nbre_enf * Math.Round((0.25 * xtaux_ij), 2) * xtranche)
        End If
    End Sub

    Public Sub calcul_ind_spec_ch_resid(ByRef xdec_is_m As Decimal, ByRef xdec_is_ep As Decimal, ByRef xdec_is_enf As Decimal, ByRef xobs_is As String, ByVal xtot_nbr_enf As Integer, ByVal xcod_grd_n As Integer, ByVal xsit_fam As String, ByVal xsolde_base As Decimal, ByVal xtranche As Integer, ByVal xtaux_ij As Decimal, ByVal xdossier As String)
        xdec_is_m = 0
        xdec_is_ep = 0
        xdec_is_enf = 0
        xobs_is = "2 Jrs/SB"

        If xdossier = "COMPLET" Then
            If xtot_nbr_enf > 3 Then
                xtot_nbr_enf = 3
            End If

            If xsit_fam = "MARIE" Then
                xdec_is_m = Math.Round((xsolde_base / 30) * 2, 2)
                xdec_is_ep = Math.Round((xsolde_base / 30) * 2, 2)
                xdec_is_enf = (xtot_nbr_enf * Math.Round((xsolde_base / 30) * 2, 2))

            ElseIf xsit_fam = "CELIBATAIRE" Then
                xdec_is_m = Math.Round((xsolde_base / 30) * 2, 2)
                xdec_is_ep = 0
                xdec_is_enf = 0
            Else ' ----------veuf   ou    divorcé---------------------
                xdec_is_m = Math.Round((xsolde_base / 30) * 2, 2)
                xdec_is_ep = 0
                xdec_is_enf = (xtot_nbr_enf * Math.Round((xsolde_base / 30) * 2, 2))
            End If

            If xcod_grd_n > 15 And xsit_fam = "CELIBATAIRE" Then
                xdec_is_m = xtranche * xtaux_ij
                xdec_is_ep = 0
                xdec_is_enf = 0
                xobs_is = Trim(xtaux_ij.ToString) & " x " & Trim(xtranche.ToString)

            End If
        End If
    End Sub

    Public Function calcul_solde_base(ByVal xcod_grd_n As Integer, ByVal xechelle As Integer, ByVal xechelon As Integer, ByVal xindice As Integer) As Decimal

        On Error Resume Next
        dr.Close()
        Dim xsolde_base As Decimal = 0
        If xcod_grd_n > 15 Then
            req = "SELECT bareme_ssp.solde_base FROM bareme_ssp" &
            " WHERE bareme_ssp.cod_grd_n=" & xcod_grd_n & " and bareme_ssp.echelle= " & xechelle & " and bareme_ssp.echelon=" & xechelon

            cmd.CommandText = req

            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                xsolde_base = dr(0)
            End If
            dr.Close()
        Else '-----le grade SOLDE MENSUELLE
            If Val(xindice) > 0 Then
                If Val(xindice) < 150 Then
                    xsolde_base = Math.Round(((100 * 98.85) + ((Val(xindice) - 100) * 79.6)) / 12, 3)
                Else
                    xsolde_base = Math.Round(((100 * 98.85) + (50 * 79.62) + (50.92 * (Val(xindice) - 150))) / 12, 3)
                End If
            Else
                xsolde_base = 0
            End If

        End If
        xsolde_base = Math.Truncate(xsolde_base * 100) / 100
        Return xsolde_base
    End Function


End Module
