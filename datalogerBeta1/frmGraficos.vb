Public Class Gráficos
    Dim ElForm As Bitmap
    Private Sub CamposBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CamposBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)

    End Sub

    Private Sub frmGraficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.ensayos' Puede moverla o quitarla según sea necesario.
        Me.EnsayosTableAdapter.Fill(Me.DbBiogasDataSet.ensayos)
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.Campos' Puede moverla o quitarla según sea necesario.
        Me.CamposTableAdapter.Fill(Me.DbBiogasDataSet.Campos)
        Dim dr As New DataTable
        consulta(dr, "SELECT * FROM Campos")
        If dr.Rows.Count > 0 Then
            For i = 0 To dr.Rows.Count - 1 Step 1
                DescripcionComboBox.Items.Add(dr.Rows(i)("descripcion").ToString)
                DescripcionComboBox1.Items.Add(dr.Rows(i)("descripcion").ToString)
            Next i
        End If
        If RadioButton1.Checked = True Then
            grpX2.Visible = False
        End If
        If RadioButton2.Checked = True Then
            grpX2.Visible = True
        End If
    End Sub
    Private Sub UNEJE(ByVal ensayo As String, ByVal reactor As String, ByVal GRAFICO As Object, ByVal Y1 As String, ByVal descy1 As String, ByVal UNIDADY1 As String)
        Dim tblgraficas As New DataTable
        Dim fec As Date
        If GRAFICO.Series.Count >= 0 Then
            GRAFICO.Series.Clear()
            GRAFICO.ChartAreas.Clear()
        End If
        consulta(tblgraficas, "SELECT fecha, avg(" & Y1 & ")as y1 from data where ensayo = " & ensayo & " and reactor='" & reactor & "' group by fecha")
        If tblgraficas.Rows.Count > 0 Then
            With GRAFICO
                .ChartAreas.Add("ChartArea0")
                .Series.Add(descy1 & " (" & UNIDADY1 & ")")
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                .Series(0).Color = Color.Red
                .Series(0).IsValueShownAsLabel = True

                .Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                .Series(0).MarkerSize = 10


                .ChartAreas(0).AxisY.Title = descy1
                .ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Blue
                For i = 0 To tblgraficas.Rows.Count - 1 Step 1
                    fec = tblgraficas.Rows(i)("fecha").ToString
                    .Series(0).Points.AddXY(fec, tblgraficas.Rows(i)("y1").ToString)

                Next
            End With
        Else
            MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub DOSEJES(ByVal ensayo As String, ByVal reactor As String, ByVal GRAFICO As Object, ByVal Y1 As String, ByVal descy1 As String, ByVal UNIDADY1 As String, ByVal Y2 As String, ByVal descy2 As String, ByVal UNIDADY2 As String)
        Dim tblgraficas As New DataTable
        Dim fec As Date
        If GRAFICO.Series.Count >= 0 Then
            GRAFICO.Series.Clear()
            GRAFICO.ChartAreas.Clear()
        End If
        consulta(tblgraficas, "SELECT fecha, avg(" & Y1 & ")as y1, avg(" & Y2 & ") as y2 from data where ensayo = " & ensayo & " and reactor='" & reactor & "' group by fecha")
        If tblgraficas.Rows.Count > 0 Then
            With GRAFICO
                .ChartAreas.Add("ChartArea0")
                .Series.Add(descy1 & " (" & UNIDADY1 & ")")
                .Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
                .Series(0).Color = Color.Red
                .Series(0).IsValueShownAsLabel = True

                .Series.Add(descy2 & " (" & UNIDADY2 & ")")
                .Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
                .Series(1).Color = Color.Blue
                .Series(1).YAxisType = DataVisualization.Charting.AxisType.Secondary
                .Series(1).IsValueShownAsLabel = True

                .Series(0).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
                .Series(0).MarkerSize = 10
                .Series(1).MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
                .Series(1).MarkerSize = 10

                .ChartAreas(0).AxisY.Title = descy1
                .ChartAreas(0).AxisY2.Title = descy2
                .ChartAreas(0).AxisY2.MajorGrid.LineColor = Color.Blue
                For i = 0 To tblgraficas.Rows.Count - 1 Step 1
                    fec = tblgraficas.Rows(i)("fecha").ToString
                    .Series(0).Points.AddXY(fec, tblgraficas.Rows(i)("y1").ToString)
                    .Series(1).Points.AddXY(fec, tblgraficas.Rows(i)("y2").ToString)
                Next
            End With
        Else
            MessageBox.Show("No existen datos cargados para este reactor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub btnVerGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerGrafica.Click
        Try
            If RadioButton1.Checked = True Then
                If DescripcionComboBox.Text <> "" Then
                    UNEJE(NroensayoComboBox.Text, cmbReactor.Text, Chart1, txtCampoX1.Text, DescripcionComboBox.Text, txtUnidadX1.Text)
                Else
                    MessageBox.Show("Debe seleccionar los campos a mostras para el eje Y1", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
            If RadioButton2.Checked = True Then
                If DescripcionComboBox.Text <> "" And DescripcionComboBox1.Text <> "" Then
                    DOSEJES(NroensayoComboBox.Text, cmbReactor.Text, Chart1, txtCampoX1.Text, DescripcionComboBox.Text, txtUnidadX1.Text, txtCampoX2.Text, DescripcionComboBox1.Text, txtUnidadX2.Text)
                Else
                    MessageBox.Show("Debe seleccionar los campos a mostrar para los ejes Y1 y Y2", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DescripcionComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionComboBox.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            consulta(dt, "SELECT * FROM Campos WHERE descripcion = '" & DescripcionComboBox.Text & "'")
            If dt.Rows.Count > 0 Then
                txtCampoX1.Text = dt.Rows(0)("campo").ToString
                txtUnidadX1.Text = dt.Rows(0)("unidad").ToString
            End If
            dt.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DescripcionComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescripcionComboBox1.SelectedIndexChanged
        Dim dt As New DataTable
        Try
            consulta(dt, "SELECT * FROM Campos WHERE descripcion = '" & DescripcionComboBox1.Text & "'")
            If dt.Rows.Count > 0 Then
                txtCampoX2.Text = dt.Rows(0)("campo").ToString
                txtUnidadX2.Text = dt.Rows(0)("unidad").ToString
            End If
            dt.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            grpX2.Visible = False
        Else
            grpX2.Visible = True
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            grpX2.Visible = False
        Else
            grpX2.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CopiarPantalla()

    End Sub
    Private Sub CopiarPantalla()
        ' Capturar todo el área del formulario

        Dim gr As Graphics = Me.CreateGraphics
        ' Tamaño de lo que queremos copiar
        Dim fSize As Size = Me.Size
        ' Creamos el bitmap con el área que vamos a capturar
        ' En este caso, con el tamaño del formulario actual
        Dim bm As New Bitmap(fSize.Width, fSize.Height, gr)
        ' Un objeto Graphics a partir del bitmap
        Dim gr2 As Graphics = Graphics.FromImage(bm)
        ' Copiar el área de la pantalla que ocupa el formulario
        gr2.CopyFromScreen(Me.Location.X, Me.Location.Y, 0, 0, fSize)

        ' Asignamos la imagen al PictureBox
        svImage.ShowDialog()
        If svImage.FileName <> "" Then
            bm.Save(svImage.FileName)
            MessageBox.Show("Grafica Guardada en " & svImage.FileName, "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    '    e.Graphics.DrawImage(ElForm, 0, 0)
    'End Sub
End Class