Module Module1
    Public a, b, c, d, f, ei As String
    Public ritter_1, ritter_2, ritter_3 As String
    Public min1, min2, min3, min4, max1, max2, max3, max4 As Double
    Public uni1, uni2, uni3, uni4 As String
    Dim operacion As Boolean
    Public ensayoActual As Double
    Public fechaensayo As Date

    Public conexion As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\dbBiogas.accdb;Persist Security Info=True"

    Public Function MAPEO(ByVal ENTRADA As Double, ByVal valmin As Double, ByVal valmax As Double)

        Try
            Dim m, b, result As Double
            Dim v1 As Double = 4
            Dim v2 As Double = 20

            m = (v2 - v1) / (valmax - valmin)
            b = v1
            result = ((ENTRADA - b) / m) + valmin
            Return result
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message.ToString, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function
    Public Sub consulta(ByVal tabla As Object, ByVal consulta As String)
        Try
            Dim cn As New System.Data.OleDb.OleDbConnection(conexion)
            Dim da As New OleDb.OleDbDataAdapter(consulta, cn)
            Dim ds As New DataSet

            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                da.Fill(tabla)
            End If
        Catch ex As Exception
            MessageBox.Show("Error 01: En Conexion con Base de Datos Access " & ex.Message.ToString)

        End Try
    End Sub
    Public Sub operacionSQL(ByVal sqlsent As String)
        Try

            Dim sqlconnection1 As New System.Data.OleDb.OleDbConnection(conexion)
            Dim cmd As New System.Data.OleDb.OleDbCommand
            cmd.CommandType = System.Data.CommandType.Text
            'sentencia = "INSERT into [actividad] ([cod_rfid], [fecha], [hora] ) VALUES ('" & UCase(codigo) & "', '" & Today & "', '" & TimeOfDay & "' )"
            cmd.CommandText = sqlsent
            cmd.Connection = sqlconnection1
            sqlconnection1.Open()
            cmd.ExecuteNonQuery()
            sqlconnection1.Close()
            operacion = True
        Catch ex As Exception
            operacion = False
            MessageBox.Show("Error 02: en Operación " & ex.Message.ToString)
        End Try
    End Sub
    Public Sub generador_rpt1(ByVal id As String, ByVal reporte As String, ByVal tablas As String)
        'Try
        Dim patch As String
        Dim oCnn As New System.Data.OleDb.OleDbConnection  ' Objeto de conexion a la base de datos
        Dim daDatos As New OleDb.OleDbDataAdapter ' Objeto Adaptador para leer datos de la Base de datos
        Dim cmdExec As New OleDb.OleDbCommand ' objeto comando para ejecutar sentencias sql
        Dim dtDatos As New DataTable ' datatable para recibir los datos de la base de datos
        Dim sbQuery As String ' sentecia sql
        sbQuery = "SELECT * from " & tablas & " WHERE nroensayo = " & id      'sentecia q genera los datos a mostrar

        oCnn.ConnectionString = conexion
        oCnn.Open()
        cmdExec = oCnn.CreateCommand
        cmdExec.Connection = oCnn
        cmdExec.CommandText = sbQuery.ToString

        daDatos = New OleDb.OleDbDataAdapter(cmdExec)
        daDatos.Fill(dtDatos)
        oCnn.Close()
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte 
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        patch = Application.StartupPath & "\" & reporte
        CrReport.Load(patch)


        CrReport.SetDataSource(dtDatos)

        frmVisorRpt.CrystalReportViewer1.DisplayToolbar = True
        frmVisorRpt.CrystalReportViewer1.ReportSource = CrReport
        frmVisorRpt.CrystalReportViewer1.Zoom(80)
        frmVisorRpt.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub
    Public Sub generador_rpt2(ByVal id As String, ByVal reporte As String, ByVal tablas As String)
        'Try
        Dim patch As String
        Dim oCnn As New System.Data.OleDb.OleDbConnection  ' Objeto de conexion a la base de datos
        Dim daDatos As New OleDb.OleDbDataAdapter ' Objeto Adaptador para leer datos de la Base de datos
        Dim cmdExec As New OleDb.OleDbCommand ' objeto comando para ejecutar sentencias sql
        Dim dtDatos As New DataTable ' datatable para recibir los datos de la base de datos
        Dim sbQuery As String ' sentecia sql
        sbQuery = "SELECT * from " & tablas & " WHERE nroensayo = " & id      'sentecia q genera los datos a mostrar

        oCnn.ConnectionString = conexion
        oCnn.Open()
        cmdExec = oCnn.CreateCommand
        cmdExec.Connection = oCnn
        cmdExec.CommandText = sbQuery.ToString

        daDatos = New OleDb.OleDbDataAdapter(cmdExec)
        daDatos.Fill(dtDatos)
        oCnn.Close()
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte 
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        patch = Application.StartupPath & "\" & reporte
        CrReport.Load(patch)


        CrReport.SetDataSource(dtDatos)

        frmVisorRpt2.CrystalReportViewer1.DisplayToolbar = True
        frmVisorRpt2.CrystalReportViewer1.ReportSource = CrReport
        frmVisorRpt2.CrystalReportViewer1.Zoom(80)
        frmVisorRpt2.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub
    Public Sub generador_rpt3(ByVal id As String, ByVal reporte As String, ByVal tablas As String)
        'Try
        Dim patch As String
        Dim oCnn As New System.Data.OleDb.OleDbConnection  ' Objeto de conexion a la base de datos
        Dim daDatos As New OleDb.OleDbDataAdapter ' Objeto Adaptador para leer datos de la Base de datos
        Dim cmdExec As New OleDb.OleDbCommand ' objeto comando para ejecutar sentencias sql
        Dim dtDatos As New DataTable ' datatable para recibir los datos de la base de datos
        Dim sbQuery As String ' sentecia sql
        sbQuery = "SELECT * from " & tablas & " WHERE nroensayo = " & id      'sentecia q genera los datos a mostrar

        oCnn.ConnectionString = conexion
        oCnn.Open()
        cmdExec = oCnn.CreateCommand
        cmdExec.Connection = oCnn
        cmdExec.CommandText = sbQuery.ToString

        daDatos = New OleDb.OleDbDataAdapter(cmdExec)
        daDatos.Fill(dtDatos)
        oCnn.Close()
        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        ' Asigno el reporte 
        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        patch = Application.StartupPath & "\" & reporte
        CrReport.Load(patch)


        CrReport.SetDataSource(dtDatos)

        frmVisorRpt3.CrystalReportViewer1.DisplayToolbar = True
        frmVisorRpt3.CrystalReportViewer1.ReportSource = CrReport
        frmVisorRpt3.CrystalReportViewer1.Zoom(80)
        frmVisorRpt3.Show()
        'Catch ex As Exception
        '    MsgBox(ex.Message.ToString)
        'End Try
    End Sub
End Module

