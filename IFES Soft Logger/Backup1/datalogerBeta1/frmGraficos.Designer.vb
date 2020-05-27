<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gráficos
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gráficos))
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.cmbReactor = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.NroensayoComboBox = New System.Windows.Forms.ComboBox
        Me.EnsayosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBiogasDataSet = New datalogerBeta1.dbBiogasDataSet
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel
        Me.grpX2 = New System.Windows.Forms.GroupBox
        Me.DescripcionComboBox1 = New System.Windows.Forms.ComboBox
        Me.txtUnidadX2 = New System.Windows.Forms.TextBox
        Me.txtCampoX2 = New System.Windows.Forms.TextBox
        Me.grpX1 = New System.Windows.Forms.GroupBox
        Me.DescripcionComboBox = New System.Windows.Forms.ComboBox
        Me.txtUnidadX1 = New System.Windows.Forms.TextBox
        Me.txtCampoX1 = New System.Windows.Forms.TextBox
        Me.btnVerGrafica = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.CamposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CamposTableAdapter = New datalogerBeta1.dbBiogasDataSetTableAdapters.CamposTableAdapter
        Me.TableAdapterManager = New datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager
        Me.EnsayosTableAdapter = New datalogerBeta1.dbBiogasDataSetTableAdapters.ensayosTableAdapter
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.svImage = New System.Windows.Forms.SaveFileDialog
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.EnsayosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.grpX2.SuspendLayout()
        Me.grpX1.SuspendLayout()
        CType(Me.CamposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Chart1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.98925!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.11828!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(640, 465)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 49)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(634, 351)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.AutoScroll = True
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.03226!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.96774!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.cmbReactor, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.NroensayoComboBox, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.GroupBox1, 5, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(634, 40)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'cmbReactor
        '
        Me.cmbReactor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbReactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReactor.FormattingEnabled = True
        Me.cmbReactor.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbReactor.Location = New System.Drawing.Point(254, 9)
        Me.cmbReactor.Name = "cmbReactor"
        Me.cmbReactor.Size = New System.Drawing.Size(78, 21)
        Me.cmbReactor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reactor"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ensayo"
        '
        'NroensayoComboBox
        '
        Me.NroensayoComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NroensayoComboBox.DataSource = Me.EnsayosBindingSource
        Me.NroensayoComboBox.DisplayMember = "nroensayo"
        Me.NroensayoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NroensayoComboBox.FormattingEnabled = True
        Me.NroensayoComboBox.Location = New System.Drawing.Point(66, 9)
        Me.NroensayoComboBox.Name = "NroensayoComboBox"
        Me.NroensayoComboBox.Size = New System.Drawing.Size(98, 21)
        Me.NroensayoComboBox.TabIndex = 4
        '
        'EnsayosBindingSource
        '
        Me.EnsayosBindingSource.DataMember = "ensayos"
        Me.EnsayosBindingSource.DataSource = Me.DbBiogasDataSet
        '
        'DbBiogasDataSet
        '
        Me.DbBiogasDataSet.DataSetName = "dbBiogasDataSet"
        Me.DbBiogasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(409, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 34)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(102, 11)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "2 Variables"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 11)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1 Variable"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 6
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71774!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.52897!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.3573!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.867413!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.93892!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.58966!))
        Me.TableLayoutPanel5.Controls.Add(Me.grpX2, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.grpX1, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.btnVerGrafica, 4, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Button1, 5, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 406)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(634, 56)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'grpX2
        '
        Me.grpX2.Controls.Add(Me.DescripcionComboBox1)
        Me.grpX2.Controls.Add(Me.txtUnidadX2)
        Me.grpX2.Controls.Add(Me.txtCampoX2)
        Me.grpX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpX2.Location = New System.Drawing.Point(185, 3)
        Me.grpX2.Name = "grpX2"
        Me.grpX2.Size = New System.Drawing.Size(181, 50)
        Me.grpX2.TabIndex = 1
        Me.grpX2.TabStop = False
        Me.grpX2.Text = "X 2"
        '
        'DescripcionComboBox1
        '
        Me.DescripcionComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescripcionComboBox1.FormattingEnabled = True
        Me.DescripcionComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.DescripcionComboBox1.Name = "DescripcionComboBox1"
        Me.DescripcionComboBox1.Size = New System.Drawing.Size(169, 21)
        Me.DescripcionComboBox1.TabIndex = 4
        '
        'txtUnidadX2
        '
        Me.txtUnidadX2.Location = New System.Drawing.Point(82, 46)
        Me.txtUnidadX2.Name = "txtUnidadX2"
        Me.txtUnidadX2.Size = New System.Drawing.Size(80, 20)
        Me.txtUnidadX2.TabIndex = 3
        Me.txtUnidadX2.Visible = False
        '
        'txtCampoX2
        '
        Me.txtCampoX2.Location = New System.Drawing.Point(6, 46)
        Me.txtCampoX2.Name = "txtCampoX2"
        Me.txtCampoX2.Size = New System.Drawing.Size(64, 20)
        Me.txtCampoX2.TabIndex = 2
        Me.txtCampoX2.Visible = False
        '
        'grpX1
        '
        Me.grpX1.Controls.Add(Me.DescripcionComboBox)
        Me.grpX1.Controls.Add(Me.txtUnidadX1)
        Me.grpX1.Controls.Add(Me.txtCampoX1)
        Me.grpX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpX1.Location = New System.Drawing.Point(3, 3)
        Me.grpX1.Name = "grpX1"
        Me.grpX1.Size = New System.Drawing.Size(176, 50)
        Me.grpX1.TabIndex = 0
        Me.grpX1.TabStop = False
        Me.grpX1.Text = "X 1"
        '
        'DescripcionComboBox
        '
        Me.DescripcionComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DescripcionComboBox.FormattingEnabled = True
        Me.DescripcionComboBox.Location = New System.Drawing.Point(6, 19)
        Me.DescripcionComboBox.Name = "DescripcionComboBox"
        Me.DescripcionComboBox.Size = New System.Drawing.Size(164, 21)
        Me.DescripcionComboBox.TabIndex = 4
        '
        'txtUnidadX1
        '
        Me.txtUnidadX1.Location = New System.Drawing.Point(99, 46)
        Me.txtUnidadX1.Name = "txtUnidadX1"
        Me.txtUnidadX1.Size = New System.Drawing.Size(72, 20)
        Me.txtUnidadX1.TabIndex = 3
        Me.txtUnidadX1.Visible = False
        '
        'txtCampoX1
        '
        Me.txtCampoX1.Location = New System.Drawing.Point(6, 46)
        Me.txtCampoX1.Name = "txtCampoX1"
        Me.txtCampoX1.Size = New System.Drawing.Size(72, 20)
        Me.txtCampoX1.TabIndex = 2
        Me.txtCampoX1.Visible = False
        '
        'btnVerGrafica
        '
        Me.btnVerGrafica.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVerGrafica.Location = New System.Drawing.Point(474, 9)
        Me.btnVerGrafica.Name = "btnVerGrafica"
        Me.btnVerGrafica.Size = New System.Drawing.Size(82, 37)
        Me.btnVerGrafica.TabIndex = 2
        Me.btnVerGrafica.Text = "Ver"
        Me.btnVerGrafica.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(562, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Guardar Imagen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CamposBindingSource
        '
        Me.CamposBindingSource.DataMember = "Campos"
        Me.CamposBindingSource.DataSource = Me.DbBiogasDataSet
        '
        'CamposTableAdapter
        '
        Me.CamposTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CamposTableAdapter = Me.CamposTableAdapter
        Me.TableAdapterManager.dataTableAdapter = Nothing
        Me.TableAdapterManager.datosanaliticosTableAdapter = Nothing
        Me.TableAdapterManager.ensayosTableAdapter = Me.EnsayosTableAdapter
        Me.TableAdapterManager.resultadosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'EnsayosTableAdapter
        '
        Me.EnsayosTableAdapter.ClearBeforeFill = True
        '
        'svImage
        '
        Me.svImage.DefaultExt = "jpg"
        Me.svImage.DereferenceLinks = False
        Me.svImage.FileName = "Graficas"
        Me.svImage.Filter = "Archivo de Imagenes (*.jpg)|*.jpg"
        '
        'Gráficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 465)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gráficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graficos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.EnsayosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.grpX2.ResumeLayout(False)
        Me.grpX2.PerformLayout()
        Me.grpX1.ResumeLayout(False)
        Me.grpX1.PerformLayout()
        CType(Me.CamposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmbReactor As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NroensayoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents grpX2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpX1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerGrafica As System.Windows.Forms.Button
    Friend WithEvents DbBiogasDataSet As datalogerBeta1.dbBiogasDataSet
    Friend WithEvents CamposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CamposTableAdapter As datalogerBeta1.dbBiogasDataSetTableAdapters.CamposTableAdapter
    Friend WithEvents TableAdapterManager As datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtUnidadX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCampoX2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidadX1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCampoX1 As System.Windows.Forms.TextBox
    Friend WithEvents DescripcionComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DescripcionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents EnsayosTableAdapter As datalogerBeta1.dbBiogasDataSetTableAdapters.ensayosTableAdapter
    Friend WithEvents EnsayosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents svImage As System.Windows.Forms.SaveFileDialog
End Class
