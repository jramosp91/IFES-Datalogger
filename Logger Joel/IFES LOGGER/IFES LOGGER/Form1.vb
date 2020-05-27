Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports Excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml



Public Class IFESLOGGER
    Dim FilePathAndName As String
    Dim Temp1, PH1, Temp2, PH2, Temp3, PH3 As String
    Dim ritter_1, ritter_2, ritter_3 As String
    Dim tmr As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        BotonDesconectar.Enabled = False
        BotonConectar.Enabled = False
        BotonEmpezarEnsayo.Enabled = False
        BotonTerminarEnsayo.Enabled = False
        CSVExport.Enabled = False
        CSVExport2.Enabled = False
        CSVExport3.Enabled = False

        With DataGridReactor1
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("PH", "PH")
            .Columns.Add("Temperatura", "Temperatura")
            .Columns.Add("Ritter", "Ritter")
            .Columns.Add("Fecha", "Fecha")
        End With

        With DataGridReactor2
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("PH", "PH")
            .Columns.Add("Temperatura", "Temperatura")
            .Columns.Add("Ritter", "Ritter")
            .Columns.Add("Fecha", "Fecha")
        End With

        With DataGridReactor3
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("PH", "PH")
            .Columns.Add("Temperatura", "Temperatura")
            .Columns.Add("Ritter", "Ritter")
            .Columns.Add("Fecha", "Fecha")
        End With


    End Sub

    Private Sub BotonEscanear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonEscanear.Click

        BoxLogger.Items.Clear()
        BoxRitter.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        Dim x As Integer

        myPort = IO.Ports.SerialPort.GetPortNames()
        BoxLogger.Items.AddRange(myPort)
        BoxRitter.Items.AddRange(myPort)

        i = BoxLogger.Items.Count
        i = i - i

        x = BoxRitter.Items.Count
        x = x - x


        Try
            BoxLogger.SelectedIndex = i
            BotonConectar.Enabled = True
        Catch ex As Exception
            MsgBox("No se detecto nada conectado", MsgBoxStyle.Critical, "Atencion!")
            BoxLogger.Text = ""
            BoxLogger.Items.Clear()
            BotonConectar.Enabled = False
            BotonEmpezarEnsayo.Enabled = False
            Return
        End Try

        Try
            BoxRitter.SelectedIndex = x
            BotonConectar.Enabled = True
        Catch ex As Exception
            MsgBox("No se detecto nada conectado", MsgBoxStyle.Critical, "Atencion!")
            BoxRitter.Text = ""
            BoxRitter.Items.Clear()
            BotonConectar.Enabled = False
            BotonEmpezarEnsayo.Enabled = False
            Return

        End Try


    End Sub

    Private Sub BotonConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonConectar.Click

        If BoxLogger.SelectedItem = BoxRitter.SelectedItem Then
            MsgBox("Verificar que los puertos sean diferentes", MsgBoxStyle.Critical, "Atencion!")
        Else
            If SerialPort1.IsOpen = False Then

                SerialPort1.BaudRate = 9600
                SerialPort1.PortName = BoxLogger.SelectedItem
                SerialPort1.Open()
                TimerSerial1.Start()
            End If

            If SerialPort2.IsOpen = False Then
                SerialPort2.BaudRate = 9600
                SerialPort2.PortName = BoxRitter.SelectedItem
                SerialPort2.Open()
                TimerSerial2.Start()
            End If

            BoxLogger.Enabled = False 'Item box del COM del Logger
            BoxRitter.Enabled = False 'Item box del COM del Ritter

            Label1.Enabled = False
            Label2.Enabled = False

            BotonEscanear.Enabled = False
            BotonConectar.Enabled = False
            BotonDesconectar.Enabled = True
            BotonEmpezarEnsayo.Enabled = True
            BotonMuestreo.Enabled = True

            PictureBoxEstadoConec.Image = My.Resources.greendot
            LabelStatus.Text = "Status : Conectado"
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Try
            If SerialPort1.IsOpen Then

                Temp1 = SerialPort1.ReadTo("A")
                PH1 = SerialPort1.ReadTo("B")
                Temp2 = SerialPort1.ReadTo("C")
                PH2 = SerialPort1.ReadTo("D")
                Temp3 = SerialPort1.ReadTo("E")
                PH3 = SerialPort1.ReadTo("F")


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub SerialPort2_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived
        Try
            If SerialPort2.IsOpen Then

                ritter_1 = SerialPort2.ReadTo("H")
                ritter_2 = SerialPort2.ReadTo("I")
                ritter_3 = SerialPort2.ReadTo("J")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub BotonDesconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonDesconectar.Click

        PictureBoxEstadoConec.Image = My.Resources.botonrojo
        PictureBoxEstadoConec.Visible = True
        LabelStatus.Text = "Status : Desconectado"
        LabelEnsayo.Text = "Ensayo: Terminado"

        BoxLogger.Enabled = True
        BoxRitter.Enabled = True

        Label1.Enabled = True

        BotonEscanear.Enabled = True
        BotonConectar.Enabled = True
        BotonDesconectar.Enabled = False

        'Apagado de Seriales
        SerialPort2.WriteLine("+")
        TimerSerial1.Stop()
        TimerSerial2.Stop()
        TimerDataLogRecord1.Stop()
        SerialPort1.Close()
        SerialPort2.Close()


        BotonEmpezarEnsayo.Enabled = False
        BotonTerminarEnsayo.Enabled = False
        BotonMuestreo.Enabled = False
    End Sub

    Private Sub BotonEmpezarEnsayo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonEmpezarEnsayo.Click
        BotonEmpezarEnsayo.Enabled = False
        BotonTerminarEnsayo.Enabled = True
        BotonMuestreo.Enabled = True


        Dim p As Integer
        p = ComboBox1.Items.Count()
        p = p - p
        ComboBox1.SelectedIndex = p

        TimerDataLogRecord1.Interval = ComboBox1.SelectedItem * 600000
        TimerDataLogRecord1_Tick(Nothing, Nothing)

            LabelMuestreo.Text = "Muestreo cada: " + ComboBox1.SelectedItem + " Minutos"

            LabelEnsayo.Text = "Ensayo: En Progreso"
            TimerDataLogRecord1.Start()

    End Sub

    Private Sub BotonTerminarEnsayo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonTerminarEnsayo.Click
        BotonEmpezarEnsayo.Enabled = True
        BotonTerminarEnsayo.Enabled = False
        LabelEnsayo.Text = "Ensayo: Finalizado"
        SerialPort2.WriteLine("+")
        TimerDataLogRecord1.Stop()
        CSVExport.Enabled = True
        CSVExport2.Enabled = True
        CSVExport3.Enabled = True
        tmr = 0
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TimerDataLogRecord1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerDataLogRecord1.Tick
        Dim DT As DateTime = Now

        DataGridReactor1.Rows.Add(New String() {DataGridReactor1.RowCount, Temp1, PH1, ritter_1, DT.ToString("yyyy-MM-dd HH:mm:ss")})
        Me.DataGridReactor1.FirstDisplayedScrollingRowIndex = Me.DataGridReactor1.RowCount - 1

        DataGridReactor2.Rows.Add(New String() {DataGridReactor2.RowCount, Temp2, PH2, ritter_2, DT.ToString("yyyy-MM-dd HH:mm:ss")})
        Me.DataGridReactor2.FirstDisplayedScrollingRowIndex = Me.DataGridReactor2.RowCount - 1

        DataGridReactor3.Rows.Add(New String() {DataGridReactor3.RowCount, Temp3, PH3, ritter_3, DT.ToString("yyyy-MM-dd HH:mm:ss")})
        Me.DataGridReactor3.FirstDisplayedScrollingRowIndex = Me.DataGridReactor2.RowCount - 1

    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        DataGridReactor1.Rows.Clear()
        DataGridReactor2.Rows.Clear()
        DataGridReactor3.Rows.Clear()

    End Sub
    Private Sub BotonMuestreo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonMuestreo.Click
        TimerDataLogRecord1.Interval = ComboBox1.SelectedItem * 60000
        LabelMuestreo.Text = "Muestreo cada: " + ComboBox1.SelectedItem + " Minutos"
    End Sub
    ''Constructor de CSV

    Private Sub ExportToExcel(ByVal DGV As DataGridView)
        Dim fs As New StreamWriter(FilePathAndName, False)
        With fs
            .WriteLine("<?xml version=""1.0""?>")
            .WriteLine("<?mso-application progid=""Excel.Sheet""?>")
            .WriteLine("<Workbook xmlns=""urn:schemas-microsoft-com:office:spreadsheet"">")
            .WriteLine("    <Styles>")
            .WriteLine("        <Style ss:ID=""hdr"">")
            .WriteLine("            <Alignment ss:Horizontal=""Center""/>")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""11"" ss:Bold=""1""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""ksg"">")
            .WriteLine("            <Alignment ss:Vertical=""Bottom""/>")
            .WriteLine("            <Borders/>")
            .WriteLine("            <Font ss:FontName=""Calibri""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("        <Style ss:ID=""isi"">")
            .WriteLine("            <Borders>")
            .WriteLine("                <Border ss:Position=""Bottom"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Left"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Right"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("                <Border ss:Position=""Top"" ss:LineStyle=""Continuous"" ss:Weight=""1""/>")
            .WriteLine("            </Borders>")
            .WriteLine("            <Font ss:FontName=""Calibri"" ss:Size=""10""/>") 'SET FONT
            .WriteLine("        </Style>")
            .WriteLine("    </Styles>")

            If DGV.Name = "Reactor 1" Then
                .WriteLine("    <Worksheet ss:Name=""Reactor 1"">") 'Nombre de Sheet
                .WriteLine("        <Table>")
                .WriteLine("            <Column ss:Width=""27.75""/>") 'No
                .WriteLine("            <Column ss:Width=""93""/>") 'PH
                .WriteLine("            <Column ss:Width=""84""/>") 'Temp
                .WriteLine("            <Column ss:Width=""100""/>") 'Ritter
                .WriteLine("            <Column ss:Width=""84""/>") 'Fecha
            ElseIf DGV.Name = "Reactor 2" Then
                .WriteLine("    <Worksheet ss:Name=""Reactor 2"">")
                .WriteLine("        <Table>")
                .WriteLine("            <Column ss:Width=""27.75""/>")
                .WriteLine("            <Column ss:Width=""93""/>")
                .WriteLine("            <Column ss:Width=""84""/>")
                .WriteLine("            <Column ss:Width=""100""/>")
                .WriteLine("            <Column ss:Width=""84""/>")

            ElseIf DGV.Name = "Reactor 3" Then
                .WriteLine("    <Worksheet ss:Name=""Reactor 3"">")
                .WriteLine("        <Table>")
                .WriteLine("            <Column ss:Width=""27.75""/>")
                .WriteLine("            <Column ss:Width=""93""/>")
                .WriteLine("            <Column ss:Width=""84""/>")
                .WriteLine("            <Column ss:Width=""100""/>")
                .WriteLine("            <Column ss:Width=""84""/>")

            End If

            'AUTO SET HEADER
            .WriteLine("            <Row ss:StyleID=""ksg"">")
            For i As Integer = 0 To DGV.Columns.Count - 1 'SET HEADER
                Application.DoEvents()
                .WriteLine("            <Cell ss:StyleID=""hdr"">")
                .WriteLine("                <Data ss:Type=""String"">{0}</Data>", DGV.Columns.Item(i).HeaderText)
                .WriteLine("            </Cell>")
            Next
            .WriteLine("            </Row>")
            For intRow As Integer = 0 To DGV.RowCount - 1
                Application.DoEvents()
                .WriteLine("        <Row ss:StyleID=""ksg"" ss:utoFitHeight =""0"">")
                For intCol As Integer = 0 To DGV.Columns.Count - 1
                    Application.DoEvents()
                    .WriteLine("        <Cell ss:StyleID=""isi"">")
                    .WriteLine("            <Data ss:Type=""String"">{0}</Data>", DGV.Item(intCol, intRow).Value)
                    .WriteLine("        </Cell>")
                Next
                .WriteLine("        </Row>")
            Next
            .WriteLine("        </Table>")
            .WriteLine("    </Worksheet>")
            .WriteLine("</Workbook>")
            .Close()
        End With
    End Sub

    Private Sub CSVExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSVExport.Click

        If DataGridReactor1.RowCount = 0 Then Return 'Si no hay datos no genera

        'Cambio de Texto del Boton
        CSVExport.Text = "Exportando Reactor 1"
        CSVExport.Enabled = False
        Application.DoEvents()

        'Creacion de tabla temporal para generar CSV
        Dim DGV As New DataGridView
        With DGV
            .AllowUserToAddRows = False
            .Name = "Reactor 1"
            .Visible = False
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("PH", "PH")
            .Columns.Add("Temperatura", "Temperatura")
            .Columns.Add("Ritter", "Ritter")
            .Columns.Add("Fecha", "Fecha")
        End With

        'Copia de datos de tabla actual a temporal
        With DataGridReactor1
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    Application.DoEvents()
                    DGV.Rows.Add(IIf(i = 0, 1, i + 1), .Rows(i).Cells("PH").Value, _
                                 .Rows(i).Cells("Temperatura").Value, .Rows(i).Cells("Ritter").Value, _
                                 .Rows(i).Cells("Fecha").Value)
                Next
            End If
        End With

        'Creacion del nombre del archivo
        Dim path As String = Application.StartupPath
        Dim react As String = "\" + "Reactor 1"
        Dim armado As String = path + react
        System.IO.Directory.CreateDirectory(armado)

        FilePathAndName = armado & "\" & "Reactor 1-" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        'Limpieza de Variables
        ExportToExcel(DGV)
        DGV.Dispose()
        DGV = Nothing
       
        CSVExport.Text = "Exportar Reactor 1"
        CSVExport.Enabled = True
        MsgBox("Reporte Generado" & vbCrLf & "Se genero en: " & FilePathAndName, MsgBoxStyle.Information, "Information")

    End Sub

    Private Sub CSVExport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSVExport2.Click
        CSVExport2.Text = "Exportando Reactor 2"
        CSVExport2.Enabled = False
        Application.DoEvents()

        Dim DGV As New DataGridView

        With DGV
            .AllowUserToAddRows = False
            .Name = "Reactor 2"
            .Visible = False
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("PH", "PH")
            .Columns.Add("Temperatura", "Temperatura")
            .Columns.Add("Ritter", "Ritter")
            .Columns.Add("Fecha", "Fecha")
        End With


        With DataGridReactor2
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    Application.DoEvents()
                    DGV.Rows.Add(IIf(i = 0, 1, i + 1), .Rows(i).Cells("PH").Value, _
                                 .Rows(i).Cells("Temperatura").Value, .Rows(i).Cells("Ritter").Value, _
                                 .Rows(i).Cells("Fecha").Value)
                Next
            End If
        End With

        Dim path As String = Application.StartupPath
        Dim react As String = "\" + "Reactor 2"
        Dim armado As String = path + react
        System.IO.Directory.CreateDirectory(armado)



        FilePathAndName = armado & "\" & "Reactor 2-" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        ExportToExcel(DGV)
      
        DGV.Dispose()
   
        DGV = Nothing
        MsgBox("Reporte Generado" & vbCrLf & "Se genero en: " & FilePathAndName, MsgBoxStyle.Information, "Information")
        CSVExport2.Text = "Exportar Reactor 2"
        CSVExport2.Enabled = True

    End Sub

    Private Sub CSVExport3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSVExport3.Click

        CSVExport3.Text = "Exportando Reactor 3"
        CSVExport3.Enabled = False
        Application.DoEvents()

        Dim DGV As New DataGridView 'Reactor 1
        

        With DGV
            .AllowUserToAddRows = False
            .Name = "Reactor 3"
            .Visible = False
            .Columns.Clear()
            .Columns.Add("No", "No")
            .Columns.Add("PH", "PH")
            .Columns.Add("Temperatura", "Temperatura")
            .Columns.Add("Ritter", "Ritter")
            .Columns.Add("Fecha", "Fecha")
        End With

        With DataGridReactor3
            If .Rows.Count > 0 Then
                For i As Integer = 0 To .Rows.Count - 1
                    Application.DoEvents()
                    DGV.Rows.Add(IIf(i = 0, 1, i + 1), .Rows(i).Cells("PH").Value, _
                                 .Rows(i).Cells("Temperatura").Value, .Rows(i).Cells("Ritter").Value, _
                                 .Rows(i).Cells("Fecha").Value)
                Next
            End If
        End With

        Dim path As String = Application.StartupPath
        Dim react As String = "\" + "Reactor 3"
        Dim armado As String = path + react
        System.IO.Directory.CreateDirectory(armado)


        FilePathAndName = armado & "\" & "Reactor 3-" & Now.Day & "-" & Now.Month & "-" & Now.Year & ".xls"
        If File.Exists(FilePathAndName) Then File.Delete(FilePathAndName)

        ExportToExcel(DGV)
       
        DGV.Dispose()
        DGV = Nothing
        MsgBox("Reporte Generado" & vbCrLf & "Se genero en: " & FilePathAndName, MsgBoxStyle.Information, "Information")
        CSVExport3.Text = "Exportar Reactor 3"
        CSVExport3.Enabled = True

    End Sub
End Class