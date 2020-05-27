Public Class frmConsulta

    Private Sub EnsayosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.EnsayosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)

    End Sub

    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.data' Puede moverla o quitarla según sea necesario.
        Me.DataTableAdapter.Fill(Me.DbBiogasDataSet.data)
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.ensayos' Puede moverla o quitarla según sea necesario.
        Me.EnsayosTableAdapter.Fill(Me.DbBiogasDataSet.ensayos)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If NroensayoComboBox.Text <> "" Then
            generador_rpt1(NroensayoComboBox.Text, "rpt3.rpt", "cons3")
            generador_rpt2(NroensayoComboBox.Text, "rpt2.rpt", "cons2")
            generador_rpt3(NroensayoComboBox.Text, "rpt1.rpt", "cons1")
            Me.Close()
        End If
    End Sub

    Private Sub NroensayoComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NroensayoComboBox.SelectedIndexChanged
        Dim ensayos As New DataTable
        Dim sustratos As New DataTable
        If NroensayoComboBox.Text <> "" Then
            consulta(ensayos, "SELECT responsable FROM ensayos WHERE nroensayo =" & NroensayoComboBox.Text)
            If ensayos.Rows.Count > 0 Then
                txtResponsable.Text = ensayos.Rows(0)("responsable").ToString
                consulta(sustratos, "SELECT * FROM datosanaliticos WHERE ensayo =" & NroensayoComboBox.Text)
                If sustratos.Rows.Count > 0 Then
                    For i = 0 To sustratos.Rows.Count - 1 Step 1
                        Select Case sustratos.Rows(i)("reactor").ToString
                            Case 1
                                txtReactor1.Text = sustratos.Rows(i)("sustrato").ToString
                            Case 2
                                txtReactor2.Text = sustratos.Rows(i)("sustrato").ToString
                            Case 3
                                txtReactor3.Text = sustratos.Rows(i)("sustrato").ToString
                        End Select
                    Next
                End If
            End If
            ensayos.Dispose()
            sustratos.Dispose()
        End If


    End Sub
End Class