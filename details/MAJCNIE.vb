
Imports System.Data.OleDb
Imports WindowsApplication1.COM_MDItresorier
Public Class MAJCNIE
    Dim frm As New Form1
    Dim cine As String = ""
    Dim cinee As String = ""
    Dim a As Boolean = False
    Public MAJCINE As String = ""
    Private Sub MAJCNIE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()

        GroupBox1.Visible = False
        TXT_NVCNIE.Enabled = False
        Label2.Enabled = False


    End Sub



    Private Sub TXT_NVCNIE_Validated(sender As Object, e As EventArgs) Handles TXT_NVCNIE.Validated

        If TXT_NVCNIE.Text <> "" Then
            If CPP = "OUI" Then
                cine = TXT_NVCNIE.Text
            Else
                cine = "." & TXT_NVCNIE.Text
            End If

            cmd.CommandText = "Select g.cod_grd_a , p.nom , p.prenom  FROM personnel
               p inner join grade g on p.cod_grd_n=g.cod_grd_n  where cni='" & cine & "'"
            dr = cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()
                    MsgBox("CNIE EXISTANTE ")
                    TXT_NVCNIE.Text = ""
                    TXT_NVCNIE.Focus()

                Else
                    GroupBox1.Visible = True

                End If
                dr.Close()
            Else
                TXT_NVCNIE.Text = ""
            TXT_NVCNIE.Select()
        End If
        dr.Close()


    End Sub


    Public Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        On Error Resume Next
        dr.Close()
        cine = ""
        If TextBox1.Text <> "" Then
            If CPP = "OUI" Then
                cine = TextBox1.Text
            Else
                cine = "." & TextBox1.Text
            End If

            cmd.CommandText = "Select g.cod_grd_a , p.nom , p.prenom FROM personnel
               p inner join grade g on p.cod_grd_n=g.cod_grd_n  where cni='" & cine & "'"
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                GRADE.Text = dr(0).ToString.ToUpper & "   " & dr(1).ToString.ToUpper & "  " & dr(2).ToString.ToUpper
                Label2.Visible = True
                TXT_NVCNIE.Visible = True
            Else
                dr.Close()
                MsgBox("CNIE INEXISTANTE")
                MAJCINE = "MAJCINE"
                frm.MdiParent = Me
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.Show()
                TextBox1.Text = ""
                TextBox1.Select()
                TextBox1.Text = cno

                Return
            End If
            dr.Close()
        Else
            TextBox1.Text = ""
            TextBox1.Select()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TXT_NVCNIE.Enabled = True
        Label2.Enabled = True
        If a = True Then
            TextBox1.Clear()
            a = False
        End If
    End Sub

    Private Sub TXT_NVCNIE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NVCNIE.TextChanged
        If TXT_NVCNIE.Text = Nothing Then
            GroupBox1.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            dr.Close()

        If CPP = "OUI" Then
            cine = TextBox1.Text
            cinee = TXT_NVCNIE.Text
        Else
            cine = "." & TextBox1.Text
                cinee = TXT_NVCNIE.Text
            End If

        req = "update personnel set cni='" & cinee.ToUpper & "' where cni='" & cine.ToUpper & "'"
            enregistrer(req)
            journal(Date.Now, xynom, xyatelier, req)
            GRADE.Text = ""
        Catch ex As Exception

        End Try


        'Try
        '    req = "update feuille_emarg set cni='" & TXT_NVCNIE.Text.ToUpper & "' where cni='" & cine.ToUpper & "'"
        '    enregistrer(req)

        '    'Catch ex As Exception

        '    'End Try
        '    Try
        '    req = "update billeteur set cni='" & TXT_NVCNIE.Text.ToUpper & "' where cni='" & cine.ToUpper & "'"
        '    enregistrer(req)


        '    'Catch ex As Exception

        '    'End Try


        GroupBox1.Visible = False
        TXT_NVCNIE.Clear()
        TextBox1.Clear()
        Label2.Enabled = False
        TXT_NVCNIE.Enabled = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = "." Then
            MsgBox("ERREUR SAISIE")
            TextBox1.Text = ""
            a = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TXT_NVCNIE.Text = ""
        GRADE.Text = ""
        GroupBox1.Visible = False
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cnn.Close()
        Me.Close()
        End
        COM_MDItresorier.Close()


    End Sub

End Class