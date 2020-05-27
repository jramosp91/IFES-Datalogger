Public Class frmResultados
    Dim muestreo As New DataTable
    Dim datosanaliticos As New DataTable
    Dim sumagas, promch4 As New DataTable
    Dim vbiogasmh1, vbiogasmh2, vbiogassv1, vbiogassv2, vbiogasst1, vbiogasst2, vmetanomh1, vmetanomh2, vmetanosv1, vmetanosv2, vmetanoms1, vmetanoms2 As Double

    Dim totalgas, promedioch4, grmathu, grsolvol, soltot As Double
   
    Private Sub reinicio()
        totalgas = 0
        promedioch4 = 0
        grmathu = 0
        grsolvol = 0
        soltot = 0
        datosanaliticos.Clear()
        sumagas.Clear()
        muestreo.Clear()
        promch4.Clear()
    End Sub

   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            reinicio()
            consulta(muestreo, "SELECT * FROM data WHERE ensayo =" & ensayoActual & " and reactor='1'")
            consulta(datosanaliticos, "SELECT * FROM datosanaliticos WHERE ensayo = " & ensayoActual & " and reactor='1'")
            If muestreo.Rows.Count > 0 And datosanaliticos.Rows.Count > 0 Then
                txtReac1.Text = datosanaliticos.Rows(0)("sustrato").ToString
                grmathu = datosanaliticos.Rows(0)("mathugr").ToString
                grsolvol = datosanaliticos.Rows(0)("solidosvolatilesgr").ToString
                soltot = datosanaliticos.Rows(0)("solidototalesgr").ToString
                consulta(sumagas, "Select SUM(medDiaria) as totalgas FROM data WHERE ensayo=" & ensayoActual & " and reactor ='1'")
                totalgas = sumagas.Rows(0)("totalgas").ToString
                consulta(promch4, "SELECT AVG(ch4) as promch4 FROM data WHERE ensayo =" & ensayoActual & " and reactor ='1'")
                promedioch4 = IIf(promch4.Rows(0)("promch4").ToString <> "", promch4.Rows(0)("promch4").ToString, 0)
                biogasmh1.Text = Math.Round(totalgas / grmathu * 1000, 2)
                biogasmh2.Text = Math.Round(Val(biogasmh1.Text), 2)
                biogassv1.Text = Math.Round(totalgas / grsolvol * 1000, 2)
                biogassv2.Text = Math.Round(Val(biogassv1.Text), 2)
                biogasst1.Text = Math.Round(totalgas / soltot * 1000, 2)
                biogasst2.Text = Math.Round(Val(biogasst1.Text), 2)
                metanomh1.Text = Math.Round((promedioch4 / 100) * Val(biogasmh1.Text), 2)
                metanomh2.Text = Math.Round(Val(metanomh1.Text), 2)
                metanosv1.Text = Math.Round((promedioch4 / 100) * Val(biogassv1.Text), 2)
                metanosv2.Text = Math.Round(Val(metanosv1.Text), 2)
                metanoms1.Text = Math.Round((promedioch4 / 100) * Val(biogasst1.Text), 2)
                metanoms2.Text = Math.Round(Val(metanoms1.Text), 2)

            End If
            reinicio()
            consulta(muestreo, "SELECT * FROM data WHERE ensayo =" & ensayoActual & " and reactor='2'")
            consulta(datosanaliticos, "SELECT * FROM datosanaliticos WHERE ensayo = " & ensayoActual & " and reactor='2'")
            If muestreo.Rows.Count > 0 And datosanaliticos.Rows.Count > 0 Then
                txtReac2.Text = datosanaliticos.Rows(0)("sustrato").ToString
                grmathu = datosanaliticos.Rows(0)("mathugr").ToString
                grsolvol = datosanaliticos.Rows(0)("solidosvolatilesgr").ToString
                soltot = datosanaliticos.Rows(0)("solidototalesgr").ToString
                consulta(sumagas, "Select SUM(medDiaria) as totalgas FROM data WHERE ensayo=" & ensayoActual & " and reactor ='2'")
                totalgas = sumagas.Rows(0)("totalgas").ToString
                consulta(promch4, "SELECT AVG(ch4) as promch4 FROM data WHERE ensayo =" & ensayoActual & " and reactor ='2'")
                promedioch4 = IIf(promch4.Rows(0)("promch4").ToString <> "", promch4.Rows(0)("promch4").ToString, 0)
                biogasmh12.Text = Math.Round(totalgas / grmathu * 1000, 2)
                biogasmh22.Text = biogasmh12.Text
                biogassv12.Text = Math.Round(totalgas / grsolvol * 1000, 2)
                biogassv22.Text = Math.Round(Val(biogassv12.Text), 2)
                biogasst12.Text = Math.Round(totalgas / soltot * 1000, 2)
                biogasst22.Text = Math.Round(Val(biogasst12.Text), 2)
                metanomh12.Text = Math.Round((promedioch4 / 100) * Val(biogasmh12.Text), 2)
                metanomh22.Text = Math.Round(Val(metanomh1.Text), 2)
                metanosv12.Text = Math.Round((promedioch4 / 100) * Val(biogassv12.Text), 2)
                metanosv22.Text = Math.Round(Val(metanosv12.Text), 2)
                metanoms12.Text = Math.Round((promedioch4 / 100) * Val(biogasst12.Text), 2)
                metanoms22.Text = Math.Round(Val(metanoms12.Text), 2)
            End If
            reinicio()
            consulta(muestreo, "SELECT * FROM data WHERE ensayo =" & ensayoActual & " and reactor='3'")
            consulta(datosanaliticos, "SELECT * FROM datosanaliticos WHERE ensayo = " & ensayoActual & " and reactor='3'")
            If muestreo.Rows.Count > 0 And datosanaliticos.Rows.Count > 0 Then
                txtReac3.Text = datosanaliticos.Rows(0)("sustrato").ToString
                grmathu = datosanaliticos.Rows(0)("mathugr").ToString
                grsolvol = datosanaliticos.Rows(0)("solidosvolatilesgr").ToString
                soltot = datosanaliticos.Rows(0)("solidototalesgr").ToString
                consulta(sumagas, "Select SUM(medDiaria) as totalgas FROM data WHERE ensayo=" & ensayoActual & " and reactor ='3'")
                totalgas = sumagas.Rows(0)("totalgas").ToString
                consulta(promch4, "SELECT AVG(ch4) as promch4 FROM data WHERE ensayo =" & ensayoActual & " and reactor ='3'")
                promedioch4 = IIf(promch4.Rows(0)("promch4").ToString <> "", promch4.Rows(0)("promch4").ToString, 0)
                biogasmh13.Text = Math.Round(totalgas / grmathu * 1000, 2)
                biogasmh23.Text = Math.Round(Val(biogasmh13.Text), 2)
                biogassv13.Text = Math.Round(totalgas / grsolvol * 1000, 2)
                biogassv23.Text = Math.Round(Val(biogassv13.Text), 2)
                biogasst13.Text = Math.Round(totalgas / soltot * 1000, 2)
                biogasst23.Text = Math.Round(Val(biogasst13.Text), 2)
                metanomh13.Text = Math.Round((promedioch4 / 100) * Val(biogasmh13.Text), 2)
                metanomh23.Text = Math.Round(Val(metanomh1.Text), 2)
                metanosv13.Text = Math.Round((promedioch4 / 100) * Val(biogassv13.Text), 2)
                metanosv23.Text = Math.Round(Val(metanosv13.Text), 2)
                metanoms13.Text = Math.Round((promedioch4 / 100) * Val(biogasst13.Text), 2)
                metanoms23.Text = Math.Round(Val(metanoms13.Text), 2)
                Button2.Enabled = True
            End If


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim resp As Integer = MessageBox.Show("¿Desea finalizar el ensayo y guardar los resultado?", "Fin de Ensayo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Dim cmd As String
        If resp = vbYes Then

            limpiar()
            vbiogasmh1 = biogasmh1.Text
            vbiogasmh2 = biogasmh2.Text
            vbiogassv1 = biogassv1.Text
            vbiogassv2 = biogassv2.Text
            vbiogasst1 = biogasst1.Text
            vbiogasst2 = biogasst2.Text
            vmetanomh1 = metanomh1.Text
            vmetanomh2 = metanomh2.Text
            vmetanosv1 = metanosv1.Text
            vmetanosv2 = metanosv2.Text
            vmetanoms1 = metanoms1.Text
            vmetanoms2 = metanoms2.Text
            cmd = "INSERT INTO resultados(ensayo,reactor,biogasmh1,biogasmh2,biogassv1,biogassv2,biogasst1,biogasst2,metanomh1,metanomh2,metanosv1,metanosv2,metanoms1,metanoms2) VALUES (" & ensayoActual & ",'1'," & vbiogasmh1 & "," & vbiogasmh2 & "," & vbiogassv1 & "," & vbiogassv2 & ", " & vbiogasst1 & ", " & vbiogasst2 & ", " & vmetanomh1 & ", " & vmetanomh2 & ", " & vmetanosv1 & ", " & vmetanosv2 & ", " & vmetanoms1 & ", " & vmetanoms2 & " )"
            operacionSQL(cmd)
            limpiar()
            vbiogasmh1 = biogasmh12.Text
            vbiogasmh2 = biogasmh22.Text
            vbiogassv1 = biogassv12.Text
            vbiogassv2 = biogassv22.Text
            vbiogasst1 = biogasst12.Text
            vbiogasst2 = biogasst22.Text
            vmetanomh1 = metanomh12.Text
            vmetanomh2 = metanomh22.Text
            vmetanosv1 = metanosv12.Text
            vmetanosv2 = metanosv22.Text
            vmetanoms1 = metanoms12.Text
            vmetanoms2 = metanoms22.Text
            cmd = "INSERT INTO resultados(ensayo,reactor,biogasmh1,biogasmh2,biogassv1,biogassv2,biogasst1,biogasst2,metanomh1,metanomh2,metanosv1,metanosv2,metanoms1,metanoms2) VALUES (" & ensayoActual & ",'2'," & vbiogasmh1 & "," & vbiogasmh2 & "," & vbiogassv1 & "," & vbiogassv2 & ", " & vbiogasst1 & ", " & vbiogasst2 & ", " & vmetanomh1 & ", " & vmetanomh2 & ", " & vmetanosv1 & ", " & vmetanosv2 & ", " & vmetanoms1 & ", " & vmetanoms2 & " )"
            operacionSQL(cmd)
            limpiar()
            vbiogasmh1 = biogasmh13.Text
            vbiogasmh2 = biogasmh23.Text
            vbiogassv1 = biogassv13.Text
            vbiogassv2 = biogassv23.Text
            vbiogasst1 = biogasst13.Text
            vbiogasst2 = biogasst23.Text
            vmetanomh1 = metanomh13.Text
            vmetanomh2 = metanomh23.Text
            vmetanosv1 = metanosv13.Text
            vmetanosv2 = metanosv23.Text
            vmetanoms1 = metanoms13.Text
            vmetanoms2 = metanoms23.Text
            cmd = "INSERT INTO resultados(ensayo,reactor,biogasmh1,biogasmh2,biogassv1,biogassv2,biogasst1,biogasst2,metanomh1,metanomh2,metanosv1,metanosv2,metanoms1,metanoms2) VALUES (" & ensayoActual & ",'3'," & vbiogasmh1 & "," & vbiogasmh2 & "," & vbiogassv1 & "," & vbiogassv2 & ", " & vbiogasst1 & ", " & vbiogasst2 & ", " & vmetanomh1 & ", " & vmetanomh2 & ", " & vmetanosv1 & ", " & vmetanosv2 & ", " & vmetanoms1 & ", " & vmetanoms2 & " )"

            operacionSQL(cmd)
            biogasmh13.Clear()
            biogasmh23.Clear()
            biogassv13.Clear()
            biogassv23.Clear()
            biogasst13.Clear()
            biogasst23.Clear()
            metanomh13.Clear()
            metanomh23.Clear()
            metanosv13.Clear()
            metanosv23.Clear()
            metanoms13.Clear()
            metanoms23.Clear()



            Form1.btnCargaDatos.Enabled = False
            Form1.btnEnsayoNew.Enabled = True
            Form1.btnDatosAnal.Enabled = False
            'btnGuard.Enabled = False
            'Dim oper As String = "INSERT INTO ensayos(fechafin,horafin,estado) VALUES('" & Date.Today & "','" & TimeOfDay & "',true)"
            Dim oper As String = "UPDATE ensayos set fechafin='" & Date.Today & "', horafin='" & TimeOfDay & "',estado=false WHERE nroensayo =" & ensayoActual

            operacionSQL(oper)


            Form1.ToolStripStatusLabel4.Text = ""
            Form1.ToolStripStatusLabel1.Text = ""
            Form1.ToolStripStatusLabel2.Text = ""
            Form1.ToolStripStatusLabel3.Text = ""


            generador_rpt1(ensayoActual, "rpt3.rpt", "cons3")
            generador_rpt2(ensayoActual, "rpt2.rpt", "cons2")
            generador_rpt3(ensayoActual, "rpt1.rpt", "cons1")
            ensayoActual = 0
            Me.Close()
        End If
    End Sub
    Private Sub limpiar()
        vbiogasmh1 = 0
        vbiogasmh2 = 0
        vbiogassv1 = 0
        vbiogassv2 = 0
        vbiogasst1 = 0
        vbiogasst2 = 0
        vmetanomh1 = 0
        vmetanomh2 = 0
        vmetanosv1 = 0
        vmetanosv2 = 0
        vmetanoms1 = 0
        vmetanoms2 = 0
    End Sub
End Class