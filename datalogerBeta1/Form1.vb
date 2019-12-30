Imports System.IO
Public Class Form1
    Dim minutos, segundos As Double
    Dim datosf As New DataTable
    Private Sub btnConect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConect.Click
        If ComboBox1.Text <> "" Then
            SerialPort1.PortName = ComboBox1.Text
            SerialPort1.Open()
            Timer1.Enabled = True
            btnConect.Enabled = False
            Button1.Enabled = True
        Else
            MessageBox.Show("Selecciona un puerto de comunicación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then
                a = SerialPort1.ReadTo("A")
                b = SerialPort1.ReadTo("B")
                c = SerialPort1.ReadTo("C")
                d = SerialPort1.ReadTo("D")
                ei = SerialPort1.ReadTo("E")
                f = SerialPort1.ReadTo("F")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            txtTemp.Text = a
            txtPH.Text = b
            temperatura2.Text = c
            ph2.Text = d
            txtTemReac3.Text = ei
            txtPh3.Text = f
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        promedios.Enabled = True
    End Sub

 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.data' Puede moverla o quitarla según sea necesario.
        Me.DataTableAdapter.Fill(Me.DbBiogasDataSet.data)
        For Each port As String In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(port)
        Next
        Dim ensayos As New DataTable
        consulta(ensayos, "SELECT * FROM ensayos WHERE estado = true")
        If ensayos.Rows.Count > 0 Then
            MessageBox.Show("Existen ensayos activos", "Ensayos Activos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnEnsayoNew.Enabled = False
            btnCargaDatos.Enabled = True
            btnDatosAnal.Enabled = True
            'btnGuard.Enabled = True
            ensayoActual = ensayos.Rows(0)("nroensayo").ToString
            fechaensayo = ensayos.Rows(0)("fechainicio").ToString
            DataBindingSource.Filter = "ensayo = '" & ensayoActual & "'"
            ToolStripStatusLabel1.Text = "ENSAYO ACTIVO"
            ToolStripStatusLabel2.Text = "INICIADO EN: "
            ToolStripStatusLabel3.Text = FormatDateTime(ensayos.Rows(0)("fechainicio").ToString, DateFormat.ShortDate) & " " & FormatDateTime(ensayos.Rows(0)("horainicio").ToString, DateFormat.LongTime)
            ToolStripStatusLabel4.Text = "ENSAYO NRO: " & ensayoActual

        Else
            btnEnsayoNew.Enabled = True

            btnDatosAnal.Enabled = False
            ensayoActual = 0
            ToolStripStatusLabel1.Text = "SIN ENSAYOS ACTIVOS"
        End If
        If ensayoActual > 0 Then
            DataBindingSource.Filter = "reactor ='" & ComboBox2.Text & "' and ensayo =" & ensayoActual
        Else
            DataBindingSource.Filter = "reactor =''"
        End If
    End Sub

    Private Sub TableLayoutPanel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If SerialPort1.IsOpen = True Then
                SerialPort1.Close()
                Timer1.Enabled = False
                btnConect.Enabled = True
                Button1.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

   

   

    
    Private Sub DataBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DataBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)

    End Sub

   
   


    Private Sub promedios_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles promedios.Tick
        Dim tiempensayo As Integer
        Dim promedios As New DataTable
        Dim cmd As String = "SELECT ensayo, AVG(velocidad) as vel,AVG(ch4) as ch4, AVG(co2) as co2, AVG(h2s) as h2s, AVG(h2) as h2, SUM(medDiaria) as totGas, AVG(medDiaria) as promGas, AVG(temperatura) as promtemp1,AVG(templinea) as templinea, AVG(presionlinea) as presionlinea,AVG(tension) as tension, AVG(ph) as promph from data where ensayo = " & ensayoActual & " and reactor = '1' group by ensayo"
        Dim flujo1, flujo2, flujo3 As New DataTable
        consulta(promedios, cmd)
        If promedios.Rows.Count > 0 Then
            txtVelprom.Text = Math.Round(Val(promedios.Rows(0)("vel").ToString), 2)
            txtTempLinea.Text = Math.Round(Val(promedios.Rows(0)("templinea").ToString), 2)
            txtPresionlinea.Text = Math.Round(Val(promedios.Rows(0)("presionlinea").ToString), 2)
            txtTension1.Text = Math.Round(Val(promedios.Rows(0)("tension").ToString), 2)
            txtCh4prom.Text = Math.Round(Val(promedios.Rows(0)("ch4").ToString), 2)
            txtCo2prom.Text = Math.Round(Val(promedios.Rows(0)("co2").ToString), 2)
            txtH2sprom.Text = Math.Round(Val(promedios.Rows(0)("h2s").ToString), 2)
            txtH2prom.Text = Math.Round(Val(promedios.Rows(0)("h2").ToString), 2)
            'txtTotalGas.Text = promedios.Rows(0)("totGas").ToString
            'txtPromgas.Text = promedios.Rows(0)("promGas").ToString
            txtTemp.Text = Math.Round(Val(promedios.Rows(0)("promtemp1").ToString), 2)
            txtPH.Text = Math.Round(Val(promedios.Rows(0)("promph").ToString), 2)
            tiempensayo = DateDiff(DateInterval.Day, fechaensayo, Date.Today)
            txtTiempo.Text = tiempensayo
            consulta(flujo1, "SELECT SUM(medDiaria) as flujototal FROM data WHERE ensayo = " & ensayoActual & " and reactor = '1' group by ensayo")
            If flujo1.Rows.Count > 0 Then
                Dim flujot1 As Double = IIf(flujo1.Rows(0)("flujototal").ToString <> "", flujo1.Rows(0)("flujototal").ToString, 0)
                txtPromgas.Text = flujot1 / (tiempensayo)
                txtTotalGas.Text = flujot1
                consulta(datosf, "SELECT TOP 1 * FROM data WHERE ensayo = " & ensayoActual & " and reactor ='1' ORDER BY Id DESC")
                If datosf.Rows.Count > 0 Then
                    txtflujo.Text = datosf.Rows(0)("caudalAct").ToString
                    datosf.Clear()
                Else
                    txtflujo.Text = 0
                End If
            End If
        End If
        Dim promedios2 As New DataTable
        Dim cmd2 As String = "SELECT ensayo, AVG(velocidad) as vel,AVG(ch4) as ch4, AVG(co2) as co2, AVG(h2s) as h2s, AVG(h2) as h2, SUM(medDiaria) as totGas, AVG(medDiaria) as promGas, AVG(temperatura) as promtemp1,AVG(templinea) as templinea, AVG(presionlinea) as presionlinea,AVG(tension) as tension, AVG(ph) as promph from data where ensayo = " & ensayoActual & " and reactor = '2' group by ensayo"

        consulta(promedios2, cmd2)
        If promedios2.Rows.Count > 0 Then
            velocidad2.Text = promedios2.Rows(0)("vel").ToString
            templ2.Text = promedios2.Rows(0)("templinea").ToString
            presion2.Text = promedios2.Rows(0)("presionlinea").ToString
            tension2.Text = promedios2.Rows(0)("tension").ToString
            ch42.Text = promedios2.Rows(0)("ch4").ToString
            co22.Text = promedios2.Rows(0)("co2").ToString
            h2s2.Text = promedios2.Rows(0)("h2s").ToString
            h22.Text = promedios2.Rows(0)("h2").ToString
            'produccion2.Text = promedios2.Rows(0)("totGas").ToString
            'producido2.Text = promedios2.Rows(0)("promGas").ToString
            temperatura2.Text = promedios2.Rows(0)("promtemp1").ToString
            ph2.Text = promedios2.Rows(0)("promph").ToString
            txtTiempo2.Text = tiempensayo
            consulta(flujo2, "SELECT SUM(medDiaria) as flujototal FROM data WHERE ensayo = " & ensayoActual & " and reactor = '2' group by ensayo")
            If flujo2.Rows.Count > 0 Then
                Dim flujot2 As Double = IIf(flujo2.Rows(0)("flujototal").ToString <> "", flujo2.Rows(0)("flujototal").ToString, 0)
                produccion2.Text = flujot2 / (tiempensayo)

                producido2.Text = flujot2
                consulta(datosf, "SELECT TOP 1 * FROM data WHERE ensayo = " & ensayoActual & " and reactor ='2' ORDER BY Id DESC")
                If datosf.Rows.Count > 0 Then
                    txtFlujo2.Text = datosf.Rows(0)("caudalAct").ToString
                    datosf.Clear()
                Else
                    txtFlujo2.Text = 0
                End If
            End If
        End If
        Dim promedios3 As New DataTable
        Dim cmd3 As String = "SELECT ensayo, AVG(velocidad) as vel,AVG(ch4) as ch4, AVG(co2) as co2, AVG(h2s) as h2s, AVG(h2) as h2, SUM(medDiaria) as totGas, AVG(medDiaria) as promGas, AVG(temperatura) as promtemp1,AVG(templinea) as templinea, AVG(presionlinea) as presionlinea,AVG(tension) as tension, AVG(ph) as promph from data where ensayo = " & ensayoActual & " and reactor = '3' group by ensayo"

        consulta(promedios3, cmd3)
        If promedios3.Rows.Count > 0 Then
            txtvelocidad3.Text = promedios2.Rows(0)("vel").ToString
            txtTempGas3.Text = promedios2.Rows(0)("templinea").ToString
            txtPresion3.Text = promedios2.Rows(0)("presionlinea").ToString
            txtTension3.Text = promedios2.Rows(0)("tension").ToString
            txtch43.Text = promedios2.Rows(0)("ch4").ToString
            txtco23.Text = promedios2.Rows(0)("co2").ToString
            txth2s3.Text = promedios2.Rows(0)("h2s").ToString
            txth23.Text = promedios2.Rows(0)("h2").ToString
            txtProducion3.Text = promedios2.Rows(0)("totGas").ToString
            txtProducido3.Text = promedios2.Rows(0)("promGas").ToString
            txtTemReac3.Text = promedios2.Rows(0)("promtemp1").ToString
            txtPh3.Text = promedios2.Rows(0)("promph").ToString
            txtTiempo3.Text = tiempensayo
            consulta(flujo3, "SELECT SUM(medDiaria) as flujototal FROM data WHERE ensayo = " & ensayoActual & " and reactor = '3' group by ensayo")
            If flujo3.Rows.Count > 0 Then
                Dim flujot3 As Double = IIf(flujo3.Rows(0)("flujototal").ToString <> "", flujo3.Rows(0)("flujototal").ToString, 0)
                txtProducion3.Text = flujot3 / (tiempensayo)

                txtProducido3.Text = flujot3

                consulta(datosf, "SELECT TOP 1 * FROM data WHERE ensayo = " & ensayoActual & " and reactor ='3' ORDER BY Id DESC")
                If datosf.Rows.Count > 0 Then
                    txtFlujo3.Text = datosf.Rows(0)("caudalAct").ToString
                    datosf.Clear()
                Else
                    txtFlujo3.Text = 0
                End If
            End If
        End If
    End Sub

    Private Sub btnEnsayoNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnsayoNew.Click
        Dim resp As Byte = MessageBox.Show("¿Desea Generar un Nuevo Ensayo?", "Nuevo Ensayo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If resp = vbYes Then
            frmLecturaInicial.Show()
            'Dim oper As String = "INSERT INTO ensayos(fechainicio,horainicio,estado) VALUES('" & Date.Today & "','" & TimeOfDay & "',true)"
            'operacionSQL(oper)
            'consulta(consult, "SELECT * FROM ensayos WHERE estado = true")
            'If consult.Rows.Count > 0 Then
            '    ensayoActual = consult.Rows(0)("nroensayo").ToString
            '    ToolStripStatusLabel4.Text = "ENSAYO NRO: " & ensayoActual

            'End If
            'frmNuevoEnsayo.Show()
            'btnEnsayoNew.Enabled = False
            'btnEnsayoEnd.Enabled = True
            'btnDatosAnal.Enabled = True

        End If
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

  


   

    Private Sub btnCargaDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargaDatos.Click
        frmCarga.Show()
    End Sub

    


    Private Sub btnDatosAnal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosAnal.Click
        frmNuevoEnsayo.Show()
    End Sub

    Private Sub btnResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResult.Click
        frmResultados.Show()
    End Sub

    Private Sub TableLayoutPanel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tblGraficas As New DataTable
        Dim fec As Date
        If Chart5.Series.Count > 0 Then
            Chart5.Series.Clear()
            Chart5.ChartAreas.Clear()
        End If


        If ensayoActual > 0 Then
            consulta(tblGraficas, "SELECT fecha, avg(co2)as co2x, avg(ch4) as ch4x, avg(h2s) as h2sx, avg(h2) as h2x from data where ensayo = " & ensayoActual & " and reactor='" & cmbReactorG.Text & "' group by fecha")
            If tblGraficas.Rows.Count > 0 Then
                With Chart5
                    .ChartAreas.Add("ChartAre0")
                    .Series.Add("CO2 (%)")
                    .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                    .Series(0).Color = Color.Red
                    .Series(0).YAxisType = DataVisualization.Charting.AxisType.Primary
                    .Series(0).IsValueShownAsLabel = True

                    .Series.Add("CH4 (%)")
                    .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                    .Series(1).Color = Color.Blue
                    .Series(1).YAxisType = DataVisualization.Charting.AxisType.Primary
                    .Series(1).IsValueShownAsLabel = True

                    .Series.Add("H2S (ppm)")
                    .Series(2).ChartType = DataVisualization.Charting.SeriesChartType.Line
                    .Series(2).Color = Color.Green
                    .Series(2).YAxisType = DataVisualization.Charting.AxisType.Secondary
                    .Series(2).IsValueShownAsLabel = True

                    .Series.Add("H2 (ppm)")
                    .Series(3).ChartType = DataVisualization.Charting.SeriesChartType.Line
                    .Series(3).Color = Color.Magenta
                    .Series(3).YAxisType = DataVisualization.Charting.AxisType.Secondary
                    .Series(3).IsValueShownAsLabel = True

                    .Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                    .Series(0).MarkerSize = 10
                    .Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                    .Series(1).MarkerSize = 10
                    .Series(2).MarkerStyle = DataVisualization.Charting.MarkerStyle.Star10
                    .Series(2).MarkerSize = 10
                    .Series(3).MarkerStyle = DataVisualization.Charting.MarkerStyle.Cross
                    .Series(3).MarkerSize = 10
                    .ChartAreas(0).AxisY.Title = "PORCENTAJE %"
                    .ChartAreas(0).AxisY2.Title = "PPM"
                    .ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Blue

                    For i = 0 To tblGraficas.Rows.Count - 1 Step 1
                        fec = tblGraficas.Rows(i)("fecha").ToString
                        .Series(0).Points.AddXY(fec, tblGraficas.Rows(i)("co2x").ToString)
                        .Series(1).Points.AddXY(fec, tblGraficas.Rows(i)("ch4x").ToString)
                        .Series(2).Points.AddXY(fec, tblGraficas.Rows(i)("h2sx").ToString)
                        .Series(3).Points.AddXY(fec, tblGraficas.Rows(i)("h2x").ToString)

                    Next
                End With
            Else
                MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tblGraficas As New DataTable
        Dim fec As Date
        If Chart5.Series.Count > 0 Then
            Chart5.Series.Clear()
            Chart5.ChartAreas.Clear()
        End If


        If ensayoActual > 0 Then
            consulta(tblGraficas, "SELECT fecha, avg(temperatura)as temp, avg(ph) as phx  from data where ensayo = " & ensayoActual & " and reactor='" & cmbReactorG.Text & "' group by fecha")

            If tblGraficas.Rows.Count > 0 Then
                Chart5.ChartAreas.Add("ChartArea0")
                Chart5.Series.Add("Temperatura °C")
                Chart5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(0).Color = Color.Red
                Chart5.Series(0).YAxisType = DataVisualization.Charting.AxisType.Primary
                Chart5.Series(0).IsValueShownAsLabel = True

                Chart5.Series.Add("PH")
                Chart5.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(1).Color = Color.Blue
                Chart5.Series(1).YAxisType = DataVisualization.Charting.AxisType.Secondary
                Chart5.Series(1).IsValueShownAsLabel = True

                Chart5.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                Chart5.Series(0).MarkerSize = 10
                Chart5.Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart5.Series(1).MarkerSize = 10
                Chart5.ChartAreas(0).AxisY.Title = "TEMPERATURA °C"
                Chart5.ChartAreas(0).AxisY2.Title = "PH"
                Chart5.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Blue

                For i = 0 To tblGraficas.Rows.Count - 1 Step 1
                    fec = tblGraficas.Rows(i)("fecha").ToString
                    Chart5.Series(0).Points.AddXY(fec, tblGraficas.Rows(i)("temp").ToString)
                    Chart5.Series(1).Points.AddXY(fec, tblGraficas.Rows(i)("phx").ToString)
                Next

            Else
                MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim tblGraficas As New DataTable
        Dim fec As Date
        If Chart5.Series.Count > 0 Then
            Chart5.Series.Clear()
            Chart5.ChartAreas.Clear()
        End If


        If ensayoActual > 0 Then
            consulta(tblGraficas, "SELECT fecha, avg(templinea)as temp, avg(presionlinea) as presion  from data where ensayo = " & ensayoActual & " and reactor='" & cmbReactorG.Text & "' group by fecha")
            If tblGraficas.Rows.Count > 0 Then
                Chart5.ChartAreas.Add("ChartArea0")
                Chart5.Series.Add("Temperatura °C")
                Chart5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(0).Color = Color.Red
                Chart5.Series(0).YAxisType = DataVisualization.Charting.AxisType.Primary
                Chart5.Series(0).IsValueShownAsLabel = True

                Chart5.Series.Add("Presión (mbar)")
                Chart5.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(1).Color = Color.Blue
                Chart5.Series(1).YAxisType = DataVisualization.Charting.AxisType.Secondary
                Chart5.Series(1).IsValueShownAsLabel = True

                Chart5.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                Chart5.Series(0).MarkerSize = 10
                Chart5.Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart5.Series(1).MarkerSize = 10
                Chart5.ChartAreas(0).AxisY.Title = "TEMPERATURA °C"
                Chart5.ChartAreas(0).AxisY2.Title = "PRESIÓN (mbar)"
                Chart5.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Blue

                For i = 0 To tblGraficas.Rows.Count - 1 Step 1
                    fec = tblGraficas.Rows(i)("fecha").ToString
                    Chart5.Series(0).Points.AddXY(fec, tblGraficas.Rows(i)("temp").ToString)
                    Chart5.Series(1).Points.AddXY(fec, tblGraficas.Rows(i)("presion").ToString)


                Next

            Else
                MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim tblGraficas As New DataTable
        Dim fec As Date
        If Chart5.Series.Count > 0 Then
            Chart5.Series.Clear()
            Chart5.ChartAreas.Clear()
        End If


        If ensayoActual > 0 Then
            consulta(tblGraficas, "SELECT fecha, SUM(meddiaria)as medicion, avg(temperatura) as tempx from data where ensayo = " & ensayoActual & " and reactor='" & cmbReactorG.Text & "' group by fecha")
            If tblGraficas.Rows.Count > 0 Then
                Chart5.ChartAreas.Add("ChartArea0")
                Chart5.Series.Add("Producción diaria (Lts/día)")
                Chart5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(0).Color = Color.Red
                Chart5.Series(0).IsValueShownAsLabel = True

                Chart5.Series.Add("Temperatura °C")
                Chart5.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(1).Color = Color.Green
                Chart5.Series(1).YAxisType = DataVisualization.Charting.AxisType.Secondary
                Chart5.Series(1).IsValueShownAsLabel = True



                Chart5.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                Chart5.Series(0).MarkerSize = 10
                Chart5.Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart5.Series(1).MarkerSize = 10
                Chart5.ChartAreas(0).AxisY.Title = "BIOGAS PRODUCIDO (Lts/Día)"
                Chart5.ChartAreas(0).AxisY2.Title = "Temperatura °C)"
                Chart5.ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Blue

                For i = 0 To tblGraficas.Rows.Count - 1 Step 1
                    fec = tblGraficas.Rows(i)("fecha").ToString
                    Chart5.Series(0).Points.AddXY(fec, tblGraficas.Rows(i)("medicion").ToString)
                    Chart5.Series(1).Points.AddXY(fec, tblGraficas.Rows(i)("tempx").ToString)

                Next

            Else
                MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Me.Validate()
        Me.DataBindingSource.EndEdit()
        Me.DataTableAdapter.Fill(Me.DbBiogasDataSet.data)
        Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)
        If ensayoActual > 0 Then
            DataBindingSource.Filter = "reactor =" & ComboBox2.Text & " and ensayo =" & ensayoActual

        Else
            DataBindingSource.Filter = "reactor =0"
        End If
        Dim ensayos As New DataTable
        Dim sustratos As New DataTable
        If ComboBox2.Text <> "" Then
            consulta(ensayos, "SELECT responsable FROM ensayos WHERE nroensayo =" & ensayoActual)
            If ensayos.Rows.Count > 0 Then
                txtResp.Text = ensayos.Rows(0)("responsable").ToString
                consulta(sustratos, "SELECT * FROM datosanaliticos WHERE ensayo =" & ensayoActual & " and reactor = '" & ComboBox2.Text & "'")
                If sustratos.Rows.Count > 0 Then
                    txtSustrat.Text = sustratos.Rows(0)("sustrato").ToString()
                End If
            End If
            ensayos.Dispose()
            sustratos.Dispose()
        End If



    End Sub

    Private Sub cmbReactorG_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReactorG.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        frmConsulta.Show()
    End Sub

    
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim tblGraficas As New DataTable
        Dim fec As Date
        If Chart5.Series.Count > 0 Then
            Chart5.Series.Clear()
            Chart5.ChartAreas.Clear()
        End If


        If ensayoActual > 0 Then
            consulta(tblGraficas, "SELECT fecha, SUM(meddiaria)as medicion, avg(ph) as phx from data where ensayo = " & ensayoActual & " and reactor='" & cmbReactorG.Text & "' group by fecha")
            If tblGraficas.Rows.Count > 0 Then
                Chart5.ChartAreas.Add("ChartArea0")
                Chart5.Series.Add("Producción diaria (Lts/día)")
                Chart5.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(0).Color = Color.Red
                Chart5.Series(0).IsValueShownAsLabel = True

                Chart5.Series.Add("PH")
                Chart5.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                Chart5.Series(1).Color = Color.Blue
                Chart5.Series(1).YAxisType = DataVisualization.Charting.AxisType.Secondary
                Chart5.Series(1).IsValueShownAsLabel = True

                Chart5.Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                Chart5.Series(0).MarkerSize = 10
                Chart5.Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                Chart5.Series(1).MarkerSize = 10

                Chart5.ChartAreas(0).AxisY.Title = "BIOGAS PRODUCIDO (Lts/Día)"
                Chart5.ChartAreas(0).AxisY2.Title = "PH"

                For i = 0 To tblGraficas.Rows.Count - 1 Step 1
                    fec = tblGraficas.Rows(i)("fecha").ToString
                    Chart5.Series(0).Points.AddXY(fec, tblGraficas.Rows(i)("medicion").ToString)
                    Chart5.Series(1).Points.AddXY(fec, tblGraficas.Rows(i)("phx").ToString)
                Next

            Else
                MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmUsuarios.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Gráficos.Show()
    End Sub

    Private Sub Form1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        promedios.Enabled = False
    End Sub


    Private Sub RitterConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RitterConnect.Click
        If ComboBox1.Text <> "" Then
            SerialPortRitter.PortName = ComboBox1.Text
            SerialPortRitter.Open()
            TimerRitter.Enabled = True
            RitterConnect.Enabled = False
            RitterDisconnect.Enabled = True
        Else
            MessageBox.Show("Selecciona un puerto de comunicación para los Ritters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RitterDisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RitterDisconnect.Click
        Try
            If SerialPortRitter.IsOpen = True Then
                SerialPortRitter.Close()
                TimerRitter.Enabled = False
                RitterConnect.Enabled = True
                RitterDisconnect.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TimerRitter_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRitter.Tick
        Try
            txtflujo.Text = ritter_1
            txtFlujo2.Text = ritter_2
            txtFlujo3.Text = ritter_3
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SerialPortRitter_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortRitter.DataReceived
        Try
            If SerialPortRitter.IsOpen Then
                ritter_1 = SerialPortRitter.ReadTo("ritter_1")
                ritter_2 = SerialPortRitter.ReadTo("ritter_2")
                ritter_3 = SerialPortRitter.ReadTo("ritter_3")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class
