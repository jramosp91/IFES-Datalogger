Public Class frmCarga

    Private Sub frmCarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.data' Puede moverla o quitarla según sea necesario.
        Me.DataTableAdapter.Fill(Me.DbBiogasDataSet.data)
       
        actualizardatos()
    End Sub
    Private Sub txtCauAct_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Val(txtCauIni.Text) > 0 Then
            txtMedicion.Text = Val(txtCauAct.Text) - Val(txtCauIni.Text)
        Else
            txtMedicion.Text = 0
        End If

    End Sub
    Private Sub borrarDatos()
        txtCauAct.Clear()
        txtCO.Clear()
        txtCH.Clear()
        txtH.Clear()
        txtHs.Clear()
        txtObservacion.Clear()
        txtTemp2.Clear()
        txtPH2.Clear()
        txtVel.Clear()
        txtTensiónC.Clear()
        txtPresion.Clear()
        txtTempL.Clear()
    End Sub


    Private Sub DataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)

    End Sub

    Private Sub actualizardatos()
        If ensayoActual > 0 Then
            btnGuard.Enabled = True
            'Dim datos As New DataTable
            'consulta(datos, "SELECT TOP 1 * FROM data WHERE ensayo = " & ensayoActual & " ORDER BY Id DESC")
            'If datos.Rows.Count > 0 Then
            '    txtCauIni.Text = datos.Rows(0)("caudalAct").ToString
            'Else
            '    txtCauIni.Text = 0
            'End If

        Else
            txtCauIni.Text = 0
            btnGuard.Enabled = False
            ensayoActual = ""

        End If
        Dim fechaini As Date
        Dim hora As Date
        If cmbReactor.Text <> "" Then
            Dim datos As New DataTable
            consulta(datos, "SELECT TOP 1 * FROM data WHERE ensayo = " & ensayoActual & " and reactor ='" & cmbReactor.Text & "' ORDER BY Id DESC")
            If datos.Rows.Count > 0 Then
                txtCauIni.Text = datos.Rows(0)("caudalAct").ToString
                txtAcumAnt.Text = datos.Rows(0)("biogastotal").ToString
            Else
                txtCauIni.Text = 0
            End If
        End If

        Dim ensayos As New DataTable
        consulta(ensayos, "SELECT * FROM ensayos WHERE estado = true")
        If ensayos.Rows.Count > 0 Then
            fechaini = ensayos.Rows(0)("fechainicio").ToString
            txtFechaInicio.Text = fechaini.ToString("dd/MM/yyyy")
            hora = ensayos.Rows(0)("horainicio").ToString
            txtHorainicio.Text = hora.ToString("hh:mm:ss tt")
        End If

        txtFecha.Text = Date.Today
        txtHora.Text = TimeOfDay
        Dim ini, fin As Date
        Dim res
        If txtFechaInicio.Text <> "" And txtFecha.Text <> "" Then
            ini = txtFechaInicio.Text
            fin = txtFecha.Text
            res = DateDiff(DateInterval.Day, ini, fin)
            txtTiempoEnsayo.Text = res
        End If
        
    End Sub

    Private Sub btnGuard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuard.Click
        Dim resp As Integer = MessageBox.Show("¿Desea registrar los datos ingresados?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If resp = vbYes Then
            If cmbReactor.Text <> "" And txtVel.Text <> "" And txtTensiónC.Text <> "" And txtCauIni.Text <> "" And txtCauAct.Text <> "" And txtCO.Text <> "" And txtCH.Text <> "" And txtHs.Text <> "" And txtH.Text <> "" And txtTemp2.Text <> "" And txtPH2.Text <> "" Then
                Dim cmd As String

                cmd = "INSERT INTO data (reactor,fecha,hora,ensayo,velocidad,caudalAct,medDiaria,biogasTotal,co2,ch4,h2s,h2,temperatura,ph,observaciones,presionlinea,templinea,tension) values('" & cmbReactor.Text & "','" & txtFecha.Text & "','" & txtHora.Text & "'," & ensayoActual & "," & txtVel.Text & "," & txtCauAct.Text & "," & txtMedicion.Text & "," & txtAcum.Text & "," & IIf(txtCO.Text = 0, "null", txtCO.Text) & "," & IIf(txtCH.Text = 0, "null", txtCH.Text) & "," & IIf(txtHs.Text = 0, "null", txtHs.Text) & "," & IIf(txtH.Text = 0, "null", txtH.Text) & "," & txtTemp2.Text & "," & txtPH2.Text & ",'" & txtObservacion.Text & "','" & txtPresion.Text & "','" & txtTempL.Text & "','" & txtTensiónC.Text & "')"
                ' MessageBox.Show(cmd)
                operacionSQL(cmd)

                Me.Validate()
                Me.DataBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)
                Me.DataTableAdapter.Fill(Me.DbBiogasDataSet.data)
                DataBindingSource.Filter = "ensayo = " & ensayoActual
                borrarDatos()
                Dim datos As New DataTable
                consulta(datos, "SELECT TOP 1 * FROM data WHERE ensayo = " & ensayoActual & " ORDER BY Id DESC")
                If datos.Rows.Count > 0 Then
                    txtCauIni.Text = datos.Rows(0)("caudalAct").ToString
                Else
                    txtCauIni.Text = 0
                End If
            Else
                MessageBox.Show("Debe completar todos los campos requeridos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End If
    End Sub

    Private Sub txtCauAct_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCauAct.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCauAct.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCauAct_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCauAct.LostFocus
        If Val(txtCauAct.Text) < Val(txtCauIni.Text) Then
            MessageBox.Show("El caudal actual no puede ser menor al caudal inicial", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCauAct.Clear()
            txtCauAct.Focus()
        End If
    End Sub

    Private Sub txtCauAct_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCauAct.TextChanged
        txtMedicion.Text = Val(txtCauAct.Text) - Val(txtCauIni.Text)
        txtAcum.Text = Val(txtAcumAnt.Text) + Val(txtMedicion.Text)
    End Sub

    Private Sub txtCauIni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCauIni.TextChanged
        txtMedicion.Text = Val(txtCauAct.Text) - Val(txtCauIni.Text)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Form1.SerialPort1.IsOpen = True Then
            Select Case cmbReactor.Text
                Case "1"
                    txtTemp2.Text = a
                    txtPH2.Text = b
                    txtCauAct.Text = Val(txtCauIni.Text) + ritter_1

                Case "2"
                    txtTemp2.Text = c
                    txtPH2.Text = d
                    txtCauAct.Text = Val(txtCauIni.Text) + ritter_2

                Case "3"
                    txtTemp2.Text = ei
                    txtPH2.Text = f
                    txtCauAct.Text = Val(txtCauIni.Text) + ritter_3
                Case Else
            End Select
        End If
    End Sub

    Private Sub cmbReactor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReactor.SelectedIndexChanged
        actualizardatos()
    End Sub

    Private Sub txtVel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVel.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtVel.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVel.TextChanged

    End Sub

    Private Sub txtTensiónC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTensiónC.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtTensiónC.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTensiónC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTensiónC.TextChanged
        Dim rpm, frecuencia As Double
        frecuencia = Val(txtTensiónC.Text)
        rpm = frecuencia * 6.033
        txtVel.Text = Math.Round(rpm, 2)
    End Sub

    Private Sub txtCO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCO.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCO.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCO.TextChanged

    End Sub

    Private Sub txtCH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCH.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCH.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCH.TextChanged

    End Sub

    Private Sub txtHs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHs.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtHs.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtHs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHs.TextChanged

    End Sub

    Private Sub txtH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtH.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtH.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtH.TextChanged

    End Sub

    Private Sub txtPresion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPresion.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPresion.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPresion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPresion.TextChanged

    End Sub

    Private Sub txtTempL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTempL.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtTempL.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTempL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTempL.TextChanged

    End Sub

    Private Sub txtTemp2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTemp2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtTemp2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtTemp2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTemp2.TextChanged

    End Sub

    Private Sub txtPH2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPH2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtPH2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPH2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPH2.TextChanged

    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click

    End Sub
End Class