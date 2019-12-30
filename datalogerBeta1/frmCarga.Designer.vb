<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarga
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarga))
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtObservacion = New System.Windows.Forms.TextBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtHora = New System.Windows.Forms.TextBox
        Me.txtVel = New System.Windows.Forms.TextBox
        Me.txtTensiónC = New System.Windows.Forms.TextBox
        Me.txtCauIni = New System.Windows.Forms.TextBox
        Me.txtCauAct = New System.Windows.Forms.TextBox
        Me.txtCO = New System.Windows.Forms.TextBox
        Me.txtCH = New System.Windows.Forms.TextBox
        Me.txtHs = New System.Windows.Forms.TextBox
        Me.txtH = New System.Windows.Forms.TextBox
        Me.txtTiempoEnsayo = New System.Windows.Forms.TextBox
        Me.btnGuard = New System.Windows.Forms.Button
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtTemp2 = New System.Windows.Forms.TextBox
        Me.txtPH2 = New System.Windows.Forms.TextBox
        Me.txtMedicion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbReactor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPresion = New System.Windows.Forms.TextBox
        Me.txtTempL = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFechaInicio = New System.Windows.Forms.TextBox
        Me.txtHorainicio = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtAcumAnt = New System.Windows.Forms.TextBox
        Me.txtAcum = New System.Windows.Forms.TextBox
        Me.DbBiogasDataSet = New datalogerBeta1.dbBiogasDataSet
        Me.DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New datalogerBeta1.dbBiogasDataSetTableAdapters.dataTableAdapter
        Me.TableAdapterManager = New datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.40059!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.59941!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Label14, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label15, 4, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Label18, 0, 6)
        Me.TableLayoutPanel4.Controls.Add(Me.Label19, 0, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Label20, 0, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.Label22, 0, 11)
        Me.TableLayoutPanel4.Controls.Add(Me.Label23, 0, 13)
        Me.TableLayoutPanel4.Controls.Add(Me.Label24, 0, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.Label25, 0, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.Label26, 0, 16)
        Me.TableLayoutPanel4.Controls.Add(Me.Label27, 0, 17)
        Me.TableLayoutPanel4.Controls.Add(Me.Label28, 0, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.Label29, 0, 19)
        Me.TableLayoutPanel4.Controls.Add(Me.Label30, 0, 20)
        Me.TableLayoutPanel4.Controls.Add(Me.Label31, 4, 11)
        Me.TableLayoutPanel4.Controls.Add(Me.txtObservacion, 4, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.txtFecha, 1, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txtHora, 1, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.txtVel, 1, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTensiónC, 1, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.txtCauIni, 1, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.txtCauAct, 1, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.txtCO, 1, 17)
        Me.TableLayoutPanel4.Controls.Add(Me.txtCH, 1, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.txtHs, 1, 19)
        Me.TableLayoutPanel4.Controls.Add(Me.txtH, 1, 20)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTiempoEnsayo, 4, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.btnGuard, 4, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.Label32, 3, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Label33, 3, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTemp2, 4, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.txtPH2, 4, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.txtMedicion, 2, 14)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cmbReactor, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 0, 22)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 23)
        Me.TableLayoutPanel4.Controls.Add(Me.Label4, 0, 24)
        Me.TableLayoutPanel4.Controls.Add(Me.txtPresion, 1, 23)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTempL, 1, 24)
        Me.TableLayoutPanel4.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtFechaInicio, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txtHorainicio, 0, 4)
        Me.TableLayoutPanel4.Controls.Add(Me.Label7, 2, 8)
        Me.TableLayoutPanel4.Controls.Add(Me.Label6, 2, 7)
        Me.TableLayoutPanel4.Controls.Add(Me.Label8, 2, 17)
        Me.TableLayoutPanel4.Controls.Add(Me.Label9, 2, 18)
        Me.TableLayoutPanel4.Controls.Add(Me.Label10, 2, 19)
        Me.TableLayoutPanel4.Controls.Add(Me.Label11, 2, 20)
        Me.TableLayoutPanel4.Controls.Add(Me.Label12, 2, 23)
        Me.TableLayoutPanel4.Controls.Add(Me.Label13, 2, 24)
        Me.TableLayoutPanel4.Controls.Add(Me.Label16, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label17, 3, 23)
        Me.TableLayoutPanel4.Controls.Add(Me.Label34, 3, 22)
        Me.TableLayoutPanel4.Controls.Add(Me.txtAcumAnt, 2, 12)
        Me.TableLayoutPanel4.Controls.Add(Me.txtAcum, 3, 12)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 26
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(827, 518)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(107, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Fecha/Hora Incio"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(562, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 13)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Tiempo de Ensayo (Días)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Agitador"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Velocidad (rpm)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 154)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 6
        Me.Label20.Text = "Frecuencia (Hz)"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label22, 2)
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 215)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(183, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Medición Caudalimetro Anterior"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label23, 2)
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 259)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(175, 13)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Medición Caudalimetro Actual"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 233)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Litros"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 276)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(78, 13)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Litros              *"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(3, 313)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(109, 13)
        Me.Label26.TabIndex = 12
        Me.Label26.Text = "Calidad de Biogas"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 331)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 13)
        Me.Label27.TabIndex = 13
        Me.Label27.Text = "CO2 (%)"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 355)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 13)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "CH4(%)"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 379)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(57, 13)
        Me.Label29.TabIndex = 15
        Me.Label29.Text = "H2S (ppm)"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 403)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(50, 13)
        Me.Label30.TabIndex = 16
        Me.Label30.Text = "H2 (ppm)"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(562, 215)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(91, 13)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "Observaciones"
        '
        'txtObservacion
        '
        Me.txtObservacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacion.Location = New System.Drawing.Point(562, 236)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.TableLayoutPanel4.SetRowSpan(Me.txtObservacion, 5)
        Me.txtObservacion.Size = New System.Drawing.Size(262, 92)
        Me.txtObservacion.TabIndex = 14
        '
        'txtFecha
        '
        Me.txtFecha.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(140, 57)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(158, 20)
        Me.txtFecha.TabIndex = 19
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHora
        '
        Me.txtHora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHora.Enabled = False
        Me.txtHora.Location = New System.Drawing.Point(140, 83)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(158, 20)
        Me.txtHora.TabIndex = 20
        Me.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVel
        '
        Me.txtVel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVel.Enabled = False
        Me.txtVel.Location = New System.Drawing.Point(140, 132)
        Me.txtVel.Name = "txtVel"
        Me.txtVel.Size = New System.Drawing.Size(158, 20)
        Me.txtVel.TabIndex = 2
        Me.txtVel.Text = "0"
        Me.txtVel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTensiónC
        '
        Me.txtTensiónC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTensiónC.Location = New System.Drawing.Point(140, 157)
        Me.txtTensiónC.Name = "txtTensiónC"
        Me.txtTensiónC.Size = New System.Drawing.Size(158, 20)
        Me.txtTensiónC.TabIndex = 3
        Me.txtTensiónC.Text = "0"
        Me.txtTensiónC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCauIni
        '
        Me.txtCauIni.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCauIni.Enabled = False
        Me.txtCauIni.Location = New System.Drawing.Point(140, 236)
        Me.txtCauIni.Name = "txtCauIni"
        Me.txtCauIni.Size = New System.Drawing.Size(158, 20)
        Me.txtCauIni.TabIndex = 4
        Me.txtCauIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCauAct
        '
        Me.txtCauAct.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCauAct.Location = New System.Drawing.Point(140, 279)
        Me.txtCauAct.Name = "txtCauAct"
        Me.txtCauAct.Size = New System.Drawing.Size(158, 20)
        Me.txtCauAct.TabIndex = 5
        Me.txtCauAct.Text = "0"
        Me.txtCauAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCO
        '
        Me.txtCO.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCO.Location = New System.Drawing.Point(140, 334)
        Me.txtCO.Name = "txtCO"
        Me.txtCO.Size = New System.Drawing.Size(158, 20)
        Me.txtCO.TabIndex = 6
        Me.txtCO.Text = "0"
        Me.txtCO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCH
        '
        Me.txtCH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCH.Location = New System.Drawing.Point(140, 358)
        Me.txtCH.Name = "txtCH"
        Me.txtCH.Size = New System.Drawing.Size(158, 20)
        Me.txtCH.TabIndex = 7
        Me.txtCH.Text = "0"
        Me.txtCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHs
        '
        Me.txtHs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHs.Location = New System.Drawing.Point(140, 382)
        Me.txtHs.Name = "txtHs"
        Me.txtHs.Size = New System.Drawing.Size(158, 20)
        Me.txtHs.TabIndex = 8
        Me.txtHs.Text = "0"
        Me.txtHs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtH
        '
        Me.txtH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtH.Location = New System.Drawing.Point(140, 406)
        Me.txtH.Name = "txtH"
        Me.txtH.Size = New System.Drawing.Size(158, 20)
        Me.txtH.TabIndex = 9
        Me.txtH.Text = "0"
        Me.txtH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTiempoEnsayo
        '
        Me.txtTiempoEnsayo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTiempoEnsayo.Enabled = False
        Me.txtTiempoEnsayo.Location = New System.Drawing.Point(562, 57)
        Me.txtTiempoEnsayo.Name = "txtTiempoEnsayo"
        Me.txtTiempoEnsayo.Size = New System.Drawing.Size(262, 20)
        Me.txtTiempoEnsayo.TabIndex = 30
        Me.txtTiempoEnsayo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGuard
        '
        Me.btnGuard.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuard.Location = New System.Drawing.Point(562, 358)
        Me.btnGuard.Name = "btnGuard"
        Me.TableLayoutPanel4.SetRowSpan(Me.btnGuard, 2)
        Me.btnGuard.Size = New System.Drawing.Size(262, 42)
        Me.btnGuard.TabIndex = 15
        Me.btnGuard.Text = "Guardar"
        Me.btnGuard.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(480, 129)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(74, 13)
        Me.Label32.TabIndex = 32
        Me.Label32.Text = "Temperatura *"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(480, 154)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 13)
        Me.Label33.TabIndex = 33
        Me.Label33.Text = "PH *"
        '
        'txtTemp2
        '
        Me.txtTemp2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTemp2.Location = New System.Drawing.Point(562, 132)
        Me.txtTemp2.Name = "txtTemp2"
        Me.txtTemp2.Size = New System.Drawing.Size(262, 20)
        Me.txtTemp2.TabIndex = 12
        Me.txtTemp2.Text = "0"
        Me.txtTemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPH2
        '
        Me.txtPH2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPH2.Location = New System.Drawing.Point(562, 157)
        Me.txtPH2.Name = "txtPH2"
        Me.txtPH2.Size = New System.Drawing.Size(262, 20)
        Me.txtPH2.TabIndex = 13
        Me.txtPH2.Text = "0"
        Me.txtPH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMedicion
        '
        Me.txtMedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedicion.Enabled = False
        Me.txtMedicion.Location = New System.Drawing.Point(304, 279)
        Me.txtMedicion.Name = "txtMedicion"
        Me.txtMedicion.Size = New System.Drawing.Size(170, 20)
        Me.txtMedicion.TabIndex = 36
        Me.txtMedicion.Text = "0"
        Me.txtMedicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Reactor"
        '
        'cmbReactor
        '
        Me.cmbReactor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbReactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReactor.FormattingEnabled = True
        Me.cmbReactor.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbReactor.Location = New System.Drawing.Point(140, 3)
        Me.cmbReactor.Name = "cmbReactor"
        Me.cmbReactor.Size = New System.Drawing.Size(158, 21)
        Me.cmbReactor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 435)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Biogas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 452)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Presión (mbar)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Temperatura"
        '
        'txtPresion
        '
        Me.txtPresion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPresion.Location = New System.Drawing.Point(140, 455)
        Me.txtPresion.Name = "txtPresion"
        Me.txtPresion.Size = New System.Drawing.Size(158, 20)
        Me.txtPresion.TabIndex = 10
        Me.txtPresion.Text = "0"
        Me.txtPresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTempL
        '
        Me.txtTempL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTempL.Location = New System.Drawing.Point(140, 481)
        Me.txtTempL.Name = "txtTempL"
        Me.txtTempL.Size = New System.Drawing.Size(158, 20)
        Me.txtTempL.TabIndex = 11
        Me.txtTempL.Text = "0"
        Me.txtTempL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Fecha/Hora Actual"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaInicio.Enabled = False
        Me.txtFechaInicio.Location = New System.Drawing.Point(3, 57)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Size = New System.Drawing.Size(131, 20)
        Me.txtFechaInicio.TabIndex = 45
        Me.txtFechaInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHorainicio
        '
        Me.txtHorainicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHorainicio.Enabled = False
        Me.txtHorainicio.Location = New System.Drawing.Point(3, 83)
        Me.txtHorainicio.Name = "txtHorainicio"
        Me.txtHorainicio.Size = New System.Drawing.Size(131, 20)
        Me.txtHorainicio.TabIndex = 46
        Me.txtHorainicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 154)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 13)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(304, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(304, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(304, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 452)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(304, 478)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(304, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label17, 2)
        Me.Label17.Location = New System.Drawing.Point(480, 452)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(219, 13)
        Me.Label17.TabIndex = 56
        Me.Label17.Text = "(*) Campos Obligatorios, debe llenar los datos"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.TableLayoutPanel4.SetColumnSpan(Me.Label34, 2)
        Me.Label34.Location = New System.Drawing.Point(480, 435)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(157, 13)
        Me.Label34.TabIndex = 58
        Me.Label34.Text = "Ingrese Solo Valores Numericos"
        '
        'txtAcumAnt
        '
        Me.txtAcumAnt.Location = New System.Drawing.Point(304, 236)
        Me.txtAcumAnt.Name = "txtAcumAnt"
        Me.txtAcumAnt.Size = New System.Drawing.Size(85, 20)
        Me.txtAcumAnt.TabIndex = 59
        Me.txtAcumAnt.Visible = False
        '
        'txtAcum
        '
        Me.txtAcum.Location = New System.Drawing.Point(480, 236)
        Me.txtAcum.Name = "txtAcum"
        Me.txtAcum.Size = New System.Drawing.Size(76, 20)
        Me.txtAcum.TabIndex = 60
        Me.txtAcum.Visible = False
        '
        'DbBiogasDataSet
        '
        Me.DbBiogasDataSet.DataSetName = "dbBiogasDataSet"
        Me.DbBiogasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataBindingSource
        '
        Me.DataBindingSource.DataMember = "data"
        Me.DataBindingSource.DataSource = Me.DbBiogasDataSet
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dataTableAdapter = Me.DataTableAdapter
        Me.TableAdapterManager.datosanaliticosTableAdapter = Nothing
        Me.TableAdapterManager.ensayosTableAdapter = Nothing
        Me.TableAdapterManager.resultadosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 518)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Datos"
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents txtVel As System.Windows.Forms.TextBox
    Friend WithEvents txtTensiónC As System.Windows.Forms.TextBox
    Friend WithEvents txtCauIni As System.Windows.Forms.TextBox
    Friend WithEvents txtCauAct As System.Windows.Forms.TextBox
    Friend WithEvents txtCO As System.Windows.Forms.TextBox
    Friend WithEvents txtCH As System.Windows.Forms.TextBox
    Friend WithEvents txtHs As System.Windows.Forms.TextBox
    Friend WithEvents txtH As System.Windows.Forms.TextBox
    Friend WithEvents txtTiempoEnsayo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuard As System.Windows.Forms.Button
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtTemp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPH2 As System.Windows.Forms.TextBox
    Friend WithEvents txtMedicion As System.Windows.Forms.TextBox
    Friend WithEvents DbBiogasDataSet As datalogerBeta1.dbBiogasDataSet
    Friend WithEvents DataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTableAdapter As datalogerBeta1.dbBiogasDataSetTableAdapters.dataTableAdapter
    Friend WithEvents TableAdapterManager As datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReactor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPresion As System.Windows.Forms.TextBox
    Friend WithEvents txtTempL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaInicio As System.Windows.Forms.TextBox
    Friend WithEvents txtHorainicio As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtAcumAnt As System.Windows.Forms.TextBox
    Friend WithEvents txtAcum As System.Windows.Forms.TextBox
End Class
