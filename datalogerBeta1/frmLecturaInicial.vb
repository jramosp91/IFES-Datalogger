Public Class frmLecturaInicial

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtRect1.Text <> "" And txtReact2.Text <> "" And txtReact3.Text <> "" Then
            Dim consult As New DataTable
            Dim cmd As String
            Dim oper As String = "INSERT INTO ensayos(fechainicio,horainicio,estado,responsable) VALUES('" & Date.Today & "','" & TimeOfDay & "',true,'" & cmbPersona.Text & "')"
            operacionSQL(oper)
            consulta(consult, "SELECT * FROM ensayos WHERE estado = true")
            fechaensayo = Date.Today
            If consult.Rows.Count > 0 Then
                ensayoActual = consult.Rows(0)("nroensayo").ToString
                Form1.ToolStripStatusLabel4.Text = "ENSAYO NRO: " & ensayoActual
                cmd = "INSERT INTO data (reactor,fecha,hora,ensayo,velocidad,caudalAct,medDiaria,biogasTotal,co2,ch4,h2s,h2,temperatura,ph,observaciones,presionlinea,templinea,tension) values('1','" & Date.Today & "','" & TimeOfDay & "'," & ensayoActual & ",null," & txtRect1.Text & ",0,0,null,null,null,null,null,null,'LECTURA INICIAL DE CAUDALIMETRO',null,null,null)"
                ' MessageBox.Show(cmd)
                operacionSQL(cmd)
                cmd = ""
                cmd = "INSERT INTO data (reactor,fecha,hora,ensayo,velocidad,caudalAct,medDiaria,biogasTotal,co2,ch4,h2s,h2,temperatura,ph,observaciones,presionlinea,templinea,tension) values('2','" & Date.Today & "','" & TimeOfDay & "'," & ensayoActual & ",null," & txtReact2.Text & ",0,0,null,null,null,null,null,null,'LECTURA INICIAL DE CAUDALIMETRO',null,null,null)"
                ' MessageBox.Show(cmd)
                operacionSQL(cmd)
                cmd = ""
                cmd = "INSERT INTO data (reactor,fecha,hora,ensayo,velocidad,caudalAct,medDiaria,biogasTotal,co2,ch4,h2s,h2,temperatura,ph,observaciones,presionlinea,templinea,tension) values('3','" & Date.Today & "','" & TimeOfDay & "'," & ensayoActual & ",null," & txtReact3.Text & ",0,0,null,null,null,null,null,null,'LECTURA INICIAL DE CAUDALIMETRO',null,null,null)"
                ' MessageBox.Show(cmd)
                operacionSQL(cmd)
                cmd = ""
                MessageBox.Show("Ensayo generado con el nro: " & ensayoActual & ", a continuación cargue los datos analiticos del ensayo", "Ensayo Nuevo Creado", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
            frmNuevoEnsayo.Show()
            Form1.btnEnsayoNew.Enabled = False
            Form1.btnCargaDatos.Enabled = True
            Form1.btnDatosAnal.Enabled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmLecturaInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DbBiogasDataSet.usuarios)

    End Sub

    Private Sub txtRect1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRect1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtRect1.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRect1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRect1.TextChanged

    End Sub

    Private Sub txtReact2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReact2.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtReact2.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtReact2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReact2.TextChanged

    End Sub

    Private Sub txtReact3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReact3.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtReact3.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class