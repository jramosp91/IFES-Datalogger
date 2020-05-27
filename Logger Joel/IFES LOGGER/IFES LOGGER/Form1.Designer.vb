<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IFESLOGGER
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IFESLOGGER))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxEstadoConec = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BoxRitter = New System.Windows.Forms.ComboBox()
        Me.BoxLogger = New System.Windows.Forms.ComboBox()
        Me.BotonDesconectar = New System.Windows.Forms.Button()
        Me.BotonConectar = New System.Windows.Forms.Button()
        Me.BotonEscanear = New System.Windows.Forms.Button()
        Me.GroupBoxControl = New System.Windows.Forms.GroupBox()
        Me.LabelEnsayo = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.BotonTerminarEnsayo = New System.Windows.Forms.Button()
        Me.BotonEmpezarEnsayo = New System.Windows.Forms.Button()
        Me.GroupExport = New System.Windows.Forms.GroupBox()
        Me.CSVExport3 = New System.Windows.Forms.Button()
        Me.CSVExport2 = New System.Windows.Forms.Button()
        Me.CSVExport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridReactor1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Temperatura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ritter = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureIFES = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridReactor2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridReactor3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerial2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDataLogRecord1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxMuestreo = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BotonMuestreo = New System.Windows.Forms.Button()
        Me.LabelMuestreo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxEstadoConec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxControl.SuspendLayout()
        Me.GroupExport.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridReactor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureIFES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridReactor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridReactor3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMuestreo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBoxEstadoConec)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.BoxRitter)
        Me.GroupBox1.Controls.Add(Me.BoxLogger)
        Me.GroupBox1.Controls.Add(Me.BotonDesconectar)
        Me.GroupBox1.Controls.Add(Me.BotonConectar)
        Me.GroupBox1.Controls.Add(Me.BotonEscanear)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conexion"
        '
        'PictureBoxEstadoConec
        '
        Me.PictureBoxEstadoConec.Image = Global.WindowsApplication1.My.Resources.Resources.botonrojo
        Me.PictureBoxEstadoConec.InitialImage = Global.WindowsApplication1.My.Resources.Resources.botonrojo
        Me.PictureBoxEstadoConec.Location = New System.Drawing.Point(277, 0)
        Me.PictureBoxEstadoConec.Name = "PictureBoxEstadoConec"
        Me.PictureBoxEstadoConec.Size = New System.Drawing.Size(13, 13)
        Me.PictureBoxEstadoConec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxEstadoConec.TabIndex = 1
        Me.PictureBoxEstadoConec.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(165, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(113, 13)
        Me.LabelStatus.TabIndex = 1
        Me.LabelStatus.Text = "Status: Desconectado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ritter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Logger"
        '
        'BoxRitter
        '
        Me.BoxRitter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxRitter.FormattingEnabled = True
        Me.BoxRitter.Location = New System.Drawing.Point(222, 59)
        Me.BoxRitter.Name = "BoxRitter"
        Me.BoxRitter.Size = New System.Drawing.Size(56, 21)
        Me.BoxRitter.TabIndex = 2
        '
        'BoxLogger
        '
        Me.BoxLogger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BoxLogger.FormattingEnabled = True
        Me.BoxLogger.Location = New System.Drawing.Point(222, 23)
        Me.BoxLogger.Name = "BoxLogger"
        Me.BoxLogger.Size = New System.Drawing.Size(56, 21)
        Me.BoxLogger.TabIndex = 2
        '
        'BotonDesconectar
        '
        Me.BotonDesconectar.Location = New System.Drawing.Point(79, 93)
        Me.BotonDesconectar.Name = "BotonDesconectar"
        Me.BotonDesconectar.Size = New System.Drawing.Size(137, 23)
        Me.BotonDesconectar.TabIndex = 1
        Me.BotonDesconectar.Text = "Desconectar"
        Me.BotonDesconectar.UseVisualStyleBackColor = True
        '
        'BotonConectar
        '
        Me.BotonConectar.Location = New System.Drawing.Point(16, 57)
        Me.BotonConectar.Name = "BotonConectar"
        Me.BotonConectar.Size = New System.Drawing.Size(137, 23)
        Me.BotonConectar.TabIndex = 1
        Me.BotonConectar.Text = "Conectar"
        Me.BotonConectar.UseVisualStyleBackColor = True
        '
        'BotonEscanear
        '
        Me.BotonEscanear.Location = New System.Drawing.Point(16, 21)
        Me.BotonEscanear.Name = "BotonEscanear"
        Me.BotonEscanear.Size = New System.Drawing.Size(137, 23)
        Me.BotonEscanear.TabIndex = 1
        Me.BotonEscanear.Text = "Escanear Puertos"
        Me.BotonEscanear.UseVisualStyleBackColor = True
        '
        'GroupBoxControl
        '
        Me.GroupBoxControl.Controls.Add(Me.LabelEnsayo)
        Me.GroupBoxControl.Controls.Add(Me.ButtonClear)
        Me.GroupBoxControl.Controls.Add(Me.BotonTerminarEnsayo)
        Me.GroupBoxControl.Controls.Add(Me.BotonEmpezarEnsayo)
        Me.GroupBoxControl.Location = New System.Drawing.Point(12, 146)
        Me.GroupBoxControl.Name = "GroupBoxControl"
        Me.GroupBoxControl.Size = New System.Drawing.Size(296, 85)
        Me.GroupBoxControl.TabIndex = 2
        Me.GroupBoxControl.TabStop = False
        Me.GroupBoxControl.Text = "Control"
        '
        'LabelEnsayo
        '
        Me.LabelEnsayo.AutoSize = True
        Me.LabelEnsayo.Location = New System.Drawing.Point(163, 0)
        Me.LabelEnsayo.Name = "LabelEnsayo"
        Me.LabelEnsayo.Size = New System.Drawing.Size(94, 13)
        Me.LabelEnsayo.TabIndex = 3
        Me.LabelEnsayo.Text = "Ensayo: Sin Iniciar"
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(6, 48)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(280, 23)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Borrar Datos"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'BotonTerminarEnsayo
        '
        Me.BotonTerminarEnsayo.Location = New System.Drawing.Point(149, 19)
        Me.BotonTerminarEnsayo.Name = "BotonTerminarEnsayo"
        Me.BotonTerminarEnsayo.Size = New System.Drawing.Size(137, 23)
        Me.BotonTerminarEnsayo.TabIndex = 1
        Me.BotonTerminarEnsayo.Text = "Terminar Ensayo"
        Me.BotonTerminarEnsayo.UseVisualStyleBackColor = True
        '
        'BotonEmpezarEnsayo
        '
        Me.BotonEmpezarEnsayo.Location = New System.Drawing.Point(6, 19)
        Me.BotonEmpezarEnsayo.Name = "BotonEmpezarEnsayo"
        Me.BotonEmpezarEnsayo.Size = New System.Drawing.Size(137, 23)
        Me.BotonEmpezarEnsayo.TabIndex = 1
        Me.BotonEmpezarEnsayo.Text = "Empezar Ensayo"
        Me.BotonEmpezarEnsayo.UseVisualStyleBackColor = True
        '
        'GroupExport
        '
        Me.GroupExport.Controls.Add(Me.CSVExport3)
        Me.GroupExport.Controls.Add(Me.CSVExport2)
        Me.GroupExport.Controls.Add(Me.CSVExport)
        Me.GroupExport.Location = New System.Drawing.Point(314, 13)
        Me.GroupExport.Name = "GroupExport"
        Me.GroupExport.Size = New System.Drawing.Size(177, 115)
        Me.GroupExport.TabIndex = 3
        Me.GroupExport.TabStop = False
        Me.GroupExport.Text = "Exportar"
        '
        'CSVExport3
        '
        Me.CSVExport3.Location = New System.Drawing.Point(6, 73)
        Me.CSVExport3.Name = "CSVExport3"
        Me.CSVExport3.Size = New System.Drawing.Size(156, 23)
        Me.CSVExport3.TabIndex = 5
        Me.CSVExport3.Text = "Exportar Reactor 3"
        Me.CSVExport3.UseVisualStyleBackColor = True
        '
        'CSVExport2
        '
        Me.CSVExport2.Location = New System.Drawing.Point(6, 44)
        Me.CSVExport2.Name = "CSVExport2"
        Me.CSVExport2.Size = New System.Drawing.Size(155, 23)
        Me.CSVExport2.TabIndex = 5
        Me.CSVExport2.Text = "Exportar Reactor 2"
        Me.CSVExport2.UseVisualStyleBackColor = True
        '
        'CSVExport
        '
        Me.CSVExport.Location = New System.Drawing.Point(7, 15)
        Me.CSVExport.Name = "CSVExport"
        Me.CSVExport.Size = New System.Drawing.Size(155, 23)
        Me.CSVExport.TabIndex = 5
        Me.CSVExport.Text = "Exportar Reactor 1"
        Me.CSVExport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridReactor1)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 326)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(625, 251)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reactor 1"
        '
        'DataGridReactor1
        '
        Me.DataGridReactor1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridReactor1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridReactor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridReactor1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.PH, Me.Temperatura, Me.Ritter, Me.Fecha})
        Me.DataGridReactor1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridReactor1.Name = "DataGridReactor1"
        Me.DataGridReactor1.ReadOnly = True
        Me.DataGridReactor1.Size = New System.Drawing.Size(613, 226)
        Me.DataGridReactor1.TabIndex = 7
        '
        'No
        '
        Me.No.FillWeight = 87.00552!
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.ReadOnly = True
        '
        'PH
        '
        Me.PH.FillWeight = 102.1809!
        Me.PH.HeaderText = "PH"
        Me.PH.Name = "PH"
        Me.PH.ReadOnly = True
        '
        'Temperatura
        '
        Me.Temperatura.FillWeight = 94.6491!
        Me.Temperatura.HeaderText = "Temperatura"
        Me.Temperatura.Name = "Temperatura"
        Me.Temperatura.ReadOnly = True
        '
        'Ritter
        '
        Me.Ritter.FillWeight = 76.14214!
        Me.Ritter.HeaderText = "Ritter"
        Me.Ritter.Name = "Ritter"
        Me.Ritter.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.FillWeight = 153.9998!
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'PictureIFES
        '
        Me.PictureIFES.Image = Global.WindowsApplication1.My.Resources.Resources.IfesLogoNuevo
        Me.PictureIFES.InitialImage = Global.WindowsApplication1.My.Resources.Resources.pastedImage
        Me.PictureIFES.Location = New System.Drawing.Point(314, 187)
        Me.PictureIFES.Name = "PictureIFES"
        Me.PictureIFES.Size = New System.Drawing.Size(329, 133)
        Me.PictureIFES.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureIFES.TabIndex = 6
        Me.PictureIFES.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridReactor2)
        Me.GroupBox3.Location = New System.Drawing.Point(658, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(625, 251)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Reactor 2"
        '
        'DataGridReactor2
        '
        Me.DataGridReactor2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridReactor2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridReactor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridReactor2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridReactor2.Location = New System.Drawing.Point(6, 19)
        Me.DataGridReactor2.Name = "DataGridReactor2"
        Me.DataGridReactor2.ReadOnly = True
        Me.DataGridReactor2.Size = New System.Drawing.Size(609, 226)
        Me.DataGridReactor2.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 87.00552!
        Me.DataGridViewTextBoxColumn1.HeaderText = "No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 102.1809!
        Me.DataGridViewTextBoxColumn2.HeaderText = "PH"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 94.6491!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Temperatura"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.FillWeight = 76.14214!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ritter"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.FillWeight = 153.9998!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGridReactor3)
        Me.GroupBox4.Location = New System.Drawing.Point(658, 326)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(625, 251)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reactor 3"
        '
        'DataGridReactor3
        '
        Me.DataGridReactor3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGridReactor3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridReactor3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridReactor3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.DataGridReactor3.Location = New System.Drawing.Point(6, 19)
        Me.DataGridReactor3.Name = "DataGridReactor3"
        Me.DataGridReactor3.ReadOnly = True
        Me.DataGridReactor3.Size = New System.Drawing.Size(609, 226)
        Me.DataGridReactor3.TabIndex = 7
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.FillWeight = 87.00552!
        Me.DataGridViewTextBoxColumn7.HeaderText = "No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.FillWeight = 102.1809!
        Me.DataGridViewTextBoxColumn8.HeaderText = "PH"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.FillWeight = 94.6491!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Temperatura"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.FillWeight = 76.14214!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Ritter"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.FillWeight = 153.9998!
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'SerialPort1
        '
        '
        'SerialPort2
        '
        '
        'TimerSerial1
        '
        Me.TimerSerial1.Interval = 1000
        '
        'TimerSerial2
        '
        Me.TimerSerial2.Interval = 1000
        '
        'TimerDataLogRecord1
        '
        Me.TimerDataLogRecord1.Interval = 900000
        '
        'GroupBoxMuestreo
        '
        Me.GroupBoxMuestreo.Controls.Add(Me.ComboBox1)
        Me.GroupBoxMuestreo.Controls.Add(Me.BotonMuestreo)
        Me.GroupBoxMuestreo.Location = New System.Drawing.Point(12, 231)
        Me.GroupBoxMuestreo.Name = "GroupBoxMuestreo"
        Me.GroupBoxMuestreo.Size = New System.Drawing.Size(233, 44)
        Me.GroupBoxMuestreo.TabIndex = 8
        Me.GroupBoxMuestreo.TabStop = False
        Me.GroupBoxMuestreo.Text = "Muestreo en Minutos"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"15", "20", "25", "30", "40", "60", "80", "120"})
        Me.ComboBox1.Location = New System.Drawing.Point(3, 16)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'BotonMuestreo
        '
        Me.BotonMuestreo.Location = New System.Drawing.Point(127, 15)
        Me.BotonMuestreo.Name = "BotonMuestreo"
        Me.BotonMuestreo.Size = New System.Drawing.Size(100, 23)
        Me.BotonMuestreo.TabIndex = 4
        Me.BotonMuestreo.Text = "Aceptar"
        Me.BotonMuestreo.UseVisualStyleBackColor = True
        '
        'LabelMuestreo
        '
        Me.LabelMuestreo.AutoSize = True
        Me.LabelMuestreo.Location = New System.Drawing.Point(12, 281)
        Me.LabelMuestreo.Name = "LabelMuestreo"
        Me.LabelMuestreo.Size = New System.Drawing.Size(136, 13)
        Me.LabelMuestreo.TabIndex = 6
        Me.LabelMuestreo.Text = "Muestreo cada: 15 Minutos"
        '
        'IFESLOGGER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 602)
        Me.Controls.Add(Me.LabelMuestreo)
        Me.Controls.Add(Me.GroupBoxMuestreo)
        Me.Controls.Add(Me.PictureIFES)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupExport)
        Me.Controls.Add(Me.GroupBoxControl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IFESLOGGER"
        Me.Text = "IFES DataLogger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxEstadoConec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxControl.ResumeLayout(False)
        Me.GroupBoxControl.PerformLayout()
        Me.GroupExport.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridReactor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureIFES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridReactor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridReactor3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMuestreo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BoxRitter As System.Windows.Forms.ComboBox
    Friend WithEvents BoxLogger As System.Windows.Forms.ComboBox
    Friend WithEvents BotonConectar As System.Windows.Forms.Button
    Friend WithEvents BotonEscanear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents BotonDesconectar As System.Windows.Forms.Button
    Friend WithEvents PictureBoxEstadoConec As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBoxControl As System.Windows.Forms.GroupBox
    Friend WithEvents LabelEnsayo As System.Windows.Forms.Label
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents BotonTerminarEnsayo As System.Windows.Forms.Button
    Friend WithEvents BotonEmpezarEnsayo As System.Windows.Forms.Button
    Friend WithEvents GroupExport As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureIFES As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridReactor1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridReactor2 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridReactor3 As System.Windows.Forms.DataGridView
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents SerialPort2 As System.IO.Ports.SerialPort
    Friend WithEvents TimerSerial1 As System.Windows.Forms.Timer
    Friend WithEvents TimerSerial2 As System.Windows.Forms.Timer
    Friend WithEvents TimerDataLogRecord1 As System.Windows.Forms.Timer
    Friend WithEvents No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Temperatura As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ritter As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxMuestreo As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BotonMuestreo As System.Windows.Forms.Button
    Friend WithEvents LabelMuestreo As System.Windows.Forms.Label
    Friend WithEvents CSVExport As System.Windows.Forms.Button
    Friend WithEvents CSVExport3 As System.Windows.Forms.Button
    Friend WithEvents CSVExport2 As System.Windows.Forms.Button

End Class
