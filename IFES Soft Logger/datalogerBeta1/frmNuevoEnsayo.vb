Public Class frmNuevoEnsayo

   

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim cmd1, cmd2, cmd3 As String
        Try
            cmd1 = "INSERT INTO datosanaliticos(ensayo,reactor,volreactor,volutilensayo,volumengas,dbo,dqo,solidototalesporc,solidototalesgr,solidosvolatilesporc,solidosvolatilesgr,cenizasporc,cenizasgr,ph,potencialredox,conductividad,ntotal,ctotal,relacioncn, sustrato, mathuporc,mathugr) values (" & ensayoActual & ",'1'," & txtVolumenReact1.Text & "," & txtVolUtil1.Text & "," & txtVolGas1.Text & "," & txtdbo1.Text & "," & txtdqo1.Text & "," & txtSolidosTporc1.Text & "," & txtSolidosTgr1.Text & "," & txtSolidosVolporc1.Text & "," & txtSolidosVolgr1.Text & "," & txtCenizasPorc1.Text & "," & txtCenizasgr1.Text & "," & txtPh1.Text & "," & txtRedox1.Text & "," & txtConductividad1.Text & "," & txtNtotal1.Text & "," & txtCtotal.Text & "," & txtRelacionCN.Text & ",'" & txtSustrato1.Text & "'," & txtMatHuporc1.Text & "," & txtMatHugr1.Text & ")"
            operacionSQL(cmd1)
            cmd2 = "INSERT INTO datosanaliticos(ensayo,reactor,volreactor,volutilensayo,volumengas,dbo,dqo,solidototalesporc,solidototalesgr,solidosvolatilesporc,solidosvolatilesgr,cenizasporc,cenizasgr,ph,potencialredox,conductividad,ntotal,ctotal,relacioncn, sustrato,mathuporc,mathugr) values (" & ensayoActual & ",'2'," & txtVolumenReact2.Text & "," & txtVolUtil2.Text & "," & txtVolGas2.Text & "," & txtdbo2.Text & "," & txtdqo2.Text & "," & txtSolidosTporc2.Text & "," & txtSolidosTgr2.Text & "," & txtSolidosVolporc2.Text & "," & txtSolidosVolgr2.Text & "," & txtCenizasPorc2.Text & "," & txtCenizasgr2.Text & "," & txtPh2.Text & "," & txtRedox2.Text & "," & txtConductividad2.Text & "," & txtNtotal2.Text & "," & txtCtotal2.Text & "," & txtRelacionCN2.Text & ",'" & txtSustrato2.Text & "'," & txtMatHuporc2.Text & "," & txtMatHugr2.Text & ")"
            operacionSQL(cmd2)
            cmd3 = "INSERT INTO datosanaliticos(ensayo,reactor,volreactor,volutilensayo,volumengas,dbo,dqo,solidototalesporc,solidototalesgr,solidosvolatilesporc,solidosvolatilesgr,cenizasporc,cenizasgr,ph,potencialredox,conductividad,ntotal,ctotal,relacioncn, sustrato,mathuporc,mathugr) values (" & ensayoActual & ",'3'," & txtVolumenReact3.Text & "," & txtVolUtil3.Text & "," & txtVolGas3.Text & "," & txtdbo3.Text & "," & txtdqo3.Text & "," & txtSolidosTporc3.Text & "," & txtSolidosTgr3.Text & "," & txtSolidosVolporc3.Text & "," & txtSolidosVolgr3.Text & "," & txtCenizasPorc3.Text & "," & txtCenizasgr3.Text & "," & txtPh3.Text & "," & txtRedox3.Text & "," & txtConductividad3.Text & "," & txtNtotal3.Text & "," & txtCtotal3.Text & "," & txtRelacionCN3.Text & ",'" & txtSustrato3.Text & "'," & txtMatHuporc3.Text & "," & txtMatHugr3.Text & ")"
            operacionSQL(cmd3)
            MessageBox.Show("Datos analiticos guardados con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)

            btnGuardar.Visible = False
            btnModificar.Visible = True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub refrescar()
        Try
            Dim datosanaliticos As New DataTable
            consulta(datosanaliticos, "SELECT * FROM datosanaliticos WHERE ensayo = " & ensayoActual & " and reactor = '1' ")
            If datosanaliticos.Rows.Count > 0 Then
                btnGuardar.Visible = False
                btnModificar.Visible = True
                txtVolumenReact1.Text = datosanaliticos.Rows(0)("volreactor").ToString
                txtVolUtil1.Text = datosanaliticos.Rows(0)("volutilensayo").ToString
                txtVolGas1.Text = datosanaliticos.Rows(0)("volumengas").ToString
                txtdbo1.Text = datosanaliticos.Rows(0)("dbo").ToString
                txtdqo1.Text = datosanaliticos.Rows(0)("dqo").ToString
                txtSolidosTporc1.Text = datosanaliticos.Rows(0)("solidototalesporc").ToString
                txtSolidosTgr1.Text = datosanaliticos.Rows(0)("solidototalesgr").ToString
                txtSolidosVolporc1.Text = datosanaliticos.Rows(0)("solidosvolatilesporc").ToString
                txtSolidosVolgr1.Text = datosanaliticos.Rows(0)("solidosvolatilesgr").ToString
                txtCenizasPorc1.Text = datosanaliticos.Rows(0)("cenizasporc").ToString
                txtCenizasgr1.Text = datosanaliticos.Rows(0)("cenizasgr").ToString
                txtPh1.Text = datosanaliticos.Rows(0)("ph").ToString
                txtRedox1.Text = datosanaliticos.Rows(0)("potencialredox").ToString
                txtConductividad1.Text = datosanaliticos.Rows(0)("conductividad").ToString
                txtNtotal1.Text = datosanaliticos.Rows(0)("ntotal").ToString
                txtCtotal.Text = datosanaliticos.Rows(0)("ctotal").ToString
                txtRelacionCN.Text = datosanaliticos.Rows(0)("relacioncn").ToString
                txtSustrato1.Text = datosanaliticos.Rows(0)("sustrato").ToString
                txtMatHugr1.Text = datosanaliticos.Rows(0)("mathugr").ToString
                txtMatHuporc1.Text = datosanaliticos.Rows(0)("mathuporc").ToString
            Else
                btnGuardar.Visible = True
                btnModificar.Visible = False
            End If
            datosanaliticos.Clear()
            consulta(datosanaliticos, "SELECT * FROM datosanaliticos WHERE ensayo = " & ensayoActual & " and reactor = '2' ")
            If datosanaliticos.Rows.Count > 0 Then
                btnGuardar.Visible = False
                txtVolumenReact2.Text = datosanaliticos.Rows(0)("volreactor").ToString
                txtVolUtil2.Text = datosanaliticos.Rows(0)("volutilensayo").ToString
                txtVolGas2.Text = datosanaliticos.Rows(0)("volumengas").ToString
                txtdbo2.Text = datosanaliticos.Rows(0)("dbo").ToString
                txtdqo2.Text = datosanaliticos.Rows(0)("dqo").ToString
                txtSolidosTporc2.Text = datosanaliticos.Rows(0)("solidototalesporc").ToString
                txtSolidosTgr2.Text = datosanaliticos.Rows(0)("solidototalesgr").ToString
                txtSolidosVolporc2.Text = datosanaliticos.Rows(0)("solidosvolatilesporc").ToString
                txtSolidosVolgr2.Text = datosanaliticos.Rows(0)("solidosvolatilesgr").ToString
                txtCenizasPorc2.Text = datosanaliticos.Rows(0)("cenizasporc").ToString
                txtCenizasgr2.Text = datosanaliticos.Rows(0)("cenizasgr").ToString
                txtPh2.Text = datosanaliticos.Rows(0)("ph").ToString
                txtRedox2.Text = datosanaliticos.Rows(0)("potencialredox").ToString
                txtConductividad2.Text = datosanaliticos.Rows(0)("conductividad").ToString
                txtNtotal2.Text = datosanaliticos.Rows(0)("ntotal").ToString
                txtCtotal2.Text = datosanaliticos.Rows(0)("ctotal").ToString
                txtRelacionCN2.Text = datosanaliticos.Rows(0)("relacioncn").ToString
                txtSustrato2.Text = datosanaliticos.Rows(0)("sustrato").ToString
                txtMatHugr2.Text = datosanaliticos.Rows(0)("mathugr").ToString
                txtMatHuporc2.Text = datosanaliticos.Rows(0)("mathuporc").ToString
            Else
                btnGuardar.Visible = True
                btnModificar.Visible = False
            End If
            datosanaliticos.Clear()
            consulta(datosanaliticos, "SELECT * FROM datosanaliticos WHERE ensayo = " & ensayoActual & " and reactor = '3' ")
            If datosanaliticos.Rows.Count > 0 Then
                btnGuardar.Visible = False
                txtVolumenReact3.Text = datosanaliticos.Rows(0)("volreactor").ToString
                txtVolUtil3.Text = datosanaliticos.Rows(0)("volutilensayo").ToString
                txtVolGas3.Text = datosanaliticos.Rows(0)("volumengas").ToString
                txtdbo3.Text = datosanaliticos.Rows(0)("dbo").ToString
                txtdqo3.Text = datosanaliticos.Rows(0)("dqo").ToString
                txtSolidosTporc3.Text = datosanaliticos.Rows(0)("solidototalesporc").ToString
                txtSolidosTgr3.Text = datosanaliticos.Rows(0)("solidototalesgr").ToString
                txtSolidosVolporc3.Text = datosanaliticos.Rows(0)("solidosvolatilesporc").ToString
                txtSolidosVolgr3.Text = datosanaliticos.Rows(0)("solidosvolatilesgr").ToString
                txtCenizasPorc3.Text = datosanaliticos.Rows(0)("cenizasporc").ToString
                txtCenizasgr3.Text = datosanaliticos.Rows(0)("cenizasgr").ToString
                txtPh3.Text = datosanaliticos.Rows(0)("ph").ToString
                txtRedox3.Text = datosanaliticos.Rows(0)("potencialredox").ToString
                txtConductividad3.Text = datosanaliticos.Rows(0)("conductividad").ToString
                txtNtotal3.Text = datosanaliticos.Rows(0)("ntotal").ToString
                txtCtotal3.Text = datosanaliticos.Rows(0)("ctotal").ToString
                txtRelacionCN3.Text = datosanaliticos.Rows(0)("relacioncn").ToString
                txtSustrato3.Text = datosanaliticos.Rows(0)("sustrato").ToString
                txtMatHugr3.Text = datosanaliticos.Rows(0)("mathugr").ToString
                txtMatHuporc3.Text = datosanaliticos.Rows(0)("mathuporc").ToString
            Else
                btnGuardar.Visible = True
                btnModificar.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub frmNuevoEnsayo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refrescar()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        refrescar()
    End Sub

    Private Sub TabPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        refrescar()
    End Sub

    Private Sub TabPage3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Click
        refrescar()
    End Sub

    
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim resp As Integer = MessageBox.Show("¿Desea Guardar los cambios realizados?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = vbYes Then
                Dim insert As String = "UPDATE datosanaliticos SET volreactor=" & txtVolumenReact1.Text & ", volutilensayo=" & txtVolUtil1.Text & ", volumengas= " & txtVolGas1.Text & ", dbo=" & txtdbo1.Text & ", dqo=" & txtdqo1.Text & ", solidototalesporc= " & txtSolidosTporc1.Text & ", solidototalesgr= " & txtSolidosTgr1.Text & ", solidosvolatilesporc=" & txtSolidosVolporc1.Text & ", solidosvolatilesgr= " & txtSolidosVolgr1.Text & ", cenizasporc=" & txtCenizasPorc1.Text & ", cenizasgr=" & txtCenizasgr1.Text & ", ph=" & txtPh1.Text & ", potencialredox= " & txtRedox1.Text & ", conductividad=" & txtConductividad1.Text & ", ntotal=" & txtNtotal1.Text & ", ctotal=" & txtCtotal.Text & ", relacioncn= " & txtRelacionCN.Text & ", sustrato='" & txtSustrato1.Text & "' WHERE ensayo = " & ensayoActual & " AND reactor = '1'"
                operacionSQL(insert)
                insert = "UPDATE datosanaliticos SET volreactor=" & txtVolumenReact2.Text & ", volutilensayo=" & txtVolUtil2.Text & ", volumengas= " & txtVolGas2.Text & ", dbo=" & txtdbo2.Text & ", dqo=" & txtdqo2.Text & ", solidototalesporc= " & txtSolidosTporc2.Text & ", solidototalesgr= " & txtSolidosTgr2.Text & ", solidosvolatilesporc=" & txtSolidosVolporc2.Text & ", solidosvolatilesgr= " & txtSolidosVolgr2.Text & ", cenizasporc=" & txtCenizasPorc2.Text & ", cenizasgr=" & txtCenizasgr2.Text & ", ph=" & txtPh2.Text & ", potencialredox= " & txtRedox2.Text & ", conductividad=" & txtConductividad2.Text & ", ntotal=" & txtNtotal2.Text & ", ctotal=" & txtCtotal2.Text & ", relacioncn= " & txtRelacionCN2.Text & ", sustrato='" & txtSustrato2.Text & "' WHERE ensayo = " & ensayoActual & " AND reactor = '2'"
                operacionSQL(insert)
                insert = "UPDATE datosanaliticos SET volreactor=" & txtVolumenReact3.Text & ", volutilensayo=" & txtVolUtil3.Text & ", volumengas= " & txtVolGas3.Text & ", dbo=" & txtdbo3.Text & ", dqo=" & txtdqo3.Text & ", solidototalesporc= " & txtSolidosTporc3.Text & ", solidototalesgr= " & txtSolidosTgr3.Text & ", solidosvolatilesporc=" & txtSolidosVolporc3.Text & ", solidosvolatilesgr= " & txtSolidosVolgr3.Text & ", cenizasporc=" & txtCenizasPorc3.Text & ", cenizasgr=" & txtCenizasgr3.Text & ", ph=" & txtPh3.Text & ", potencialredox= " & txtRedox3.Text & ", conductividad=" & txtConductividad3.Text & ", ntotal=" & txtNtotal3.Text & ", ctotal=" & txtCtotal3.Text & ", relacioncn= " & txtRelacionCN3.Text & ", sustrato='" & txtSustrato3.Text & "' WHERE ensayo = " & ensayoActual & " AND reactor = '3'"
                operacionSQL(insert)
                MessageBox.Show("Datos Guardados Con exito", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub txtNtotal1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNtotal1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtNtotal1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub




   
    Private Sub txtNtotal1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNtotal1.TextChanged
        Dim c, n, r As Double

        If txtCtotal.Text <> "" And txtNtotal1.Text <> "" Then
            c = txtCtotal.Text
            n = txtNtotal1.Text
            If c > 0 And n > 0 Then
                r = c / n
            Else
                r = 0
            End If
            txtRelacionCN.Text = r
        End If

    End Sub

    Private Sub txtNtotal2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNtotal2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtNtotal2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

 

    Private Sub txtNtotal2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNtotal2.TextChanged
        Dim c, n, r As Double

        If txtCtotal2.Text <> "" And txtNtotal2.Text <> "" Then
            c = txtCtotal2.Text
            n = txtNtotal2.Text
            If c > 0 And n > 0 Then
                r = c / n
            Else
                r = 0
            End If
            txtRelacionCN2.Text = r
        End If

    End Sub

    Private Sub txtCtotal2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtotal2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCtotal2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCtotal2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtotal2.TextChanged
        Dim c, n, r As Double

        If txtCtotal2.Text <> "" And txtNtotal2.Text <> "" Then
            c = txtCtotal2.Text
            n = txtNtotal2.Text
            If c > 0 And n > 0 Then
                r = c / n
            Else
                r = 0
            End If
            txtRelacionCN2.Text = r
        End If
    End Sub

    Private Sub txtCtotal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtotal.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCtotal.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCtotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtotal.TextChanged
        Dim c, n, r As Double

        If txtCtotal.Text <> "" And txtNtotal1.Text <> "" Then
            c = txtCtotal.Text
            n = txtNtotal1.Text
            If c > 0 And n > 0 Then
                r = c / n
            Else
                r = 0
            End If
            txtRelacionCN.Text = r
        End If
       
    End Sub

    Private Sub txtNtotal3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNtotal3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtNtotal3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNtotal3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNtotal3.TextChanged
        Dim c, n, r As Double

        If txtCtotal3.Text <> "" And txtNtotal3.Text <> "" Then
            c = txtCtotal3.Text
            n = txtNtotal3.Text
            If c > 0 And n > 0 Then
                r = c / n
            Else
                r = 0
            End If
            txtRelacionCN3.Text = r
        End If
    End Sub

    Private Sub txtCtotal3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtotal3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCtotal3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCtotal3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCtotal3.TextChanged
        Dim c, n, r As Double

        If txtCtotal3.Text <> "" And txtNtotal3.Text <> "" Then
            c = txtCtotal3.Text
            n = txtNtotal3.Text
            If c > 0 And n > 0 Then
                r = c / n
            Else
                r = 0
            End If
            txtRelacionCN3.Text = r
        End If
    End Sub

    Private Sub txtVolumenReact1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenReact1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolumenReact1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolumenReact1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVolumenReact1.TextChanged

    End Sub

    Private Sub txtVolumenReact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenReact2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolumenReact2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolumenReact3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolumenReact3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolumenReact3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCenizasgr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenizasgr1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCenizasgr1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCenizasgr2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenizasgr2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCenizasgr2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCenizasgr3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenizasgr3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCenizasgr3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCenizasPorc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenizasPorc1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCenizasPorc1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCenizasPorc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenizasPorc2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCenizasPorc2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCenizasPorc3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCenizasPorc3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCenizasPorc3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtConductividad1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConductividad1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtConductividad1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtConductividad2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConductividad2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtConductividad2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtConductividad3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConductividad3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtConductividad3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdbo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdbo1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtdbo1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdbo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdbo2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtdbo2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdbo3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdbo3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtdbo3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdqo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdqo1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtdqo1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdqo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdqo2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtdqo2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtdqo3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdqo3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtdqo3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMatHugr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatHugr1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtMatHugr1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMatHugr2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatHugr2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtMatHugr2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMatHugr3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatHugr3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtMatHugr3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMatHuporc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatHuporc1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtMatHuporc1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMatHuporc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatHuporc2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtMatHuporc2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMatHuporc3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMatHuporc3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtMatHuporc3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPh1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPh1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPh1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPh2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPh2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPh2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPh3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPh3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPh3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRedox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRedox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtRedox1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRedox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRedox2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtRedox2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRedox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRedox3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtRedox3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosTgr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosTgr1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTgr1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosTgr2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosTgr2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTgr2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosTgr3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosTgr3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTgr3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosTporc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosTporc1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTporc1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosTporc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosTporc2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTporc2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosTporc3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosTporc3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTporc3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosVolgr1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosVolgr1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosVolgr1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosVolgr2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosVolgr2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosVolgr2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosVolporc3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosVolporc3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosVolgr3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

   
    Private Sub txtVolGas1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolGas1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolGas1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolGas2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolGas2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolGas2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolGas3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolGas3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolGas3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosVolgr3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosVolgr3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosVolgr3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosVolporc1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosVolporc1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosVolporc1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSolidosVolporc2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSolidosVolporc2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtSolidosTporc2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolUtil1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolUtil1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolUtil1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolUtil2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolUtil2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolUtil2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolUtil3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolUtil3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVolUtil3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVolUtil1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVolUtil1.TextChanged
        txtVolGas1.Text = Val(txtVolumenReact1.Text) - Val(txtVolUtil1.Text)
    End Sub

    Private Sub txtVolUtil2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVolUtil2.TextChanged
        txtVolGas2.Text = Val(txtVolumenReact2.Text) - Val(txtVolUtil2.Text)
    End Sub

    Private Sub txtVolUtil3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVolUtil3.TextChanged
        txtVolGas3.Text = Val(txtVolumenReact3.Text) - Val(txtVolUtil3.Text)
    End Sub
End Class