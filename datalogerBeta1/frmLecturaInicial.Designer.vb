<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLecturaInicial
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtReact2 = New System.Windows.Forms.TextBox()
        Me.txtReact3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRect1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbPersona = New System.Windows.Forms.ComboBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbBiogasDataSet = New datalogerBeta1.dbBiogasDataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New datalogerBeta1.dbBiogasDataSetTableAdapters.usuariosTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txtReact2, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.txtReact3, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtRect1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbPersona, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSave, 1, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 10
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(543, 271)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtReact2
        '
        Me.txtReact2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtReact2.Location = New System.Drawing.Point(63, 109)
        Me.txtReact2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReact2.Name = "txtReact2"
        Me.txtReact2.Size = New System.Drawing.Size(245, 22)
        Me.txtReact2.TabIndex = 2
        Me.txtReact2.Text = "0"
        Me.txtReact2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReact3
        '
        Me.txtReact3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtReact3.Location = New System.Drawing.Point(61, 171)
        Me.txtReact3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReact3.Name = "txtReact3"
        Me.txtReact3.Size = New System.Drawing.Size(248, 22)
        Me.txtReact3.TabIndex = 3
        Me.txtReact3.Text = "0"
        Me.txtReact3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lectura Actual Reactor1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Lectura Actual Reactor 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 136)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lectura Actual Reactor 3"
        '
        'txtRect1
        '
        Me.txtRect1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.txtRect1.Location = New System.Drawing.Point(61, 47)
        Me.txtRect1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRect1.Name = "txtRect1"
        Me.txtRect1.Size = New System.Drawing.Size(249, 22)
        Me.txtRect1.TabIndex = 1
        Me.txtRect1.Text = "0"
        Me.txtRect1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 198)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Persona Responsable"
        '
        'cmbPersona
        '
        Me.cmbPersona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.cmbPersona.DataSource = Me.UsuariosBindingSource
        Me.cmbPersona.DisplayMember = "nombre"
        Me.cmbPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPersona.FormattingEnabled = True
        Me.cmbPersona.Location = New System.Drawing.Point(59, 233)
        Me.cmbPersona.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPersona.Name = "cmbPersona"
        Me.cmbPersona.Size = New System.Drawing.Size(253, 24)
        Me.cmbPersona.TabIndex = 6
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.DbBiogasDataSet
        '
        'DbBiogasDataSet
        '
        Me.DbBiogasDataSet.DataSetName = "dbBiogasDataSet"
        Me.DbBiogasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoEllipsis = True
        Me.btnSave.Location = New System.Drawing.Point(375, 109)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.TableLayoutPanel1.SetRowSpan(Me.btnSave, 2)
        Me.btnSave.Size = New System.Drawing.Size(164, 54)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Continuar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frmLecturaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 271)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLecturaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lectura Inicial de los Caudalimetros"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRect1 As System.Windows.Forms.TextBox
    Friend WithEvents txtReact2 As System.Windows.Forms.TextBox
    Friend WithEvents txtReact3 As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPersona As System.Windows.Forms.ComboBox
    Friend WithEvents DbBiogasDataSet As datalogerBeta1.dbBiogasDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As datalogerBeta1.dbBiogasDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
