<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsulta
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
        Dim NroensayoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.DbBiogasDataSet = New datalogerBeta1.dbBiogasDataSet
        Me.EnsayosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EnsayosTableAdapter = New datalogerBeta1.dbBiogasDataSetTableAdapters.ensayosTableAdapter
        Me.TableAdapterManager = New datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager
        Me.NroensayoComboBox = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtResponsable = New System.Windows.Forms.TextBox
        Me.txtReactor1 = New System.Windows.Forms.TextBox
        Me.txtReactor2 = New System.Windows.Forms.TextBox
        Me.txtReactor3 = New System.Windows.Forms.TextBox
        Me.EnsayosdataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTableAdapter = New datalogerBeta1.dbBiogasDataSetTableAdapters.dataTableAdapter
        Me.EnsayosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        NroensayoLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnsayosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnsayosdataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnsayosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NroensayoLabel
        '
        NroensayoLabel.AutoSize = True
        NroensayoLabel.Location = New System.Drawing.Point(28, 30)
        NroensayoLabel.Name = "NroensayoLabel"
        NroensayoLabel.Size = New System.Drawing.Size(109, 13)
        NroensayoLabel.TabIndex = 1
        NroensayoLabel.Text = "Seleccione el Ensayo"
        '
        'DbBiogasDataSet
        '
        Me.DbBiogasDataSet.DataSetName = "dbBiogasDataSet"
        Me.DbBiogasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EnsayosBindingSource
        '
        Me.EnsayosBindingSource.DataMember = "ensayos"
        Me.EnsayosBindingSource.DataSource = Me.DbBiogasDataSet
        '
        'EnsayosTableAdapter
        '
        Me.EnsayosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.dataTableAdapter = Me.DataTableAdapter
        Me.TableAdapterManager.datosanaliticosTableAdapter = Nothing
        Me.TableAdapterManager.ensayosTableAdapter = Me.EnsayosTableAdapter
        Me.TableAdapterManager.resultadosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'NroensayoComboBox
        '
        Me.NroensayoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EnsayosBindingSource, "nroensayo", True))
        Me.NroensayoComboBox.DataSource = Me.EnsayosBindingSource1
        Me.NroensayoComboBox.DisplayMember = "nroensayo"
        Me.NroensayoComboBox.FormattingEnabled = True
        Me.NroensayoComboBox.Location = New System.Drawing.Point(31, 56)
        Me.NroensayoComboBox.Name = "NroensayoComboBox"
        Me.NroensayoComboBox.Size = New System.Drawing.Size(283, 21)
        Me.NroensayoComboBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResponsable
        '
        Me.txtResponsable.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable.Location = New System.Drawing.Point(31, 99)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(283, 20)
        Me.txtResponsable.TabIndex = 4
        '
        'txtReactor1
        '
        Me.txtReactor1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReactor1.Location = New System.Drawing.Point(31, 141)
        Me.txtReactor1.Name = "txtReactor1"
        Me.txtReactor1.Size = New System.Drawing.Size(283, 20)
        Me.txtReactor1.TabIndex = 5
        '
        'txtReactor2
        '
        Me.txtReactor2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReactor2.Location = New System.Drawing.Point(31, 185)
        Me.txtReactor2.Name = "txtReactor2"
        Me.txtReactor2.Size = New System.Drawing.Size(283, 20)
        Me.txtReactor2.TabIndex = 6
        '
        'txtReactor3
        '
        Me.txtReactor3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtReactor3.Location = New System.Drawing.Point(31, 226)
        Me.txtReactor3.Name = "txtReactor3"
        Me.txtReactor3.Size = New System.Drawing.Size(283, 20)
        Me.txtReactor3.TabIndex = 7
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(28, 83)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(69, 13)
        Label1.TabIndex = 8
        Label1.Text = "Responsable"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(28, 125)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(96, 13)
        Label2.TabIndex = 9
        Label2.Text = "Sustrato Reactor 1"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(28, 169)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(96, 13)
        Label3.TabIndex = 10
        Label3.Text = "Sustrato Reactor 2"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(28, 210)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(96, 13)
        Label4.TabIndex = 11
        Label4.Text = "Sustrato Reactor 3"
        '
        'EnsayosdataBindingSource
        '
        Me.EnsayosdataBindingSource.DataMember = "ensayosdata"
        Me.EnsayosdataBindingSource.DataSource = Me.EnsayosBindingSource
        '
        'DataTableAdapter
        '
        Me.DataTableAdapter.ClearBeforeFill = True
        '
        'EnsayosBindingSource1
        '
        Me.EnsayosBindingSource1.DataMember = "ensayos"
        Me.EnsayosBindingSource1.DataSource = Me.DbBiogasDataSet
        '
        'frmConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 301)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtReactor3)
        Me.Controls.Add(Me.txtReactor2)
        Me.Controls.Add(Me.txtReactor1)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(NroensayoLabel)
        Me.Controls.Add(Me.NroensayoComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Ensayos"
        CType(Me.DbBiogasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnsayosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnsayosdataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnsayosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbBiogasDataSet As datalogerBeta1.dbBiogasDataSet
    Friend WithEvents EnsayosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnsayosTableAdapter As datalogerBeta1.dbBiogasDataSetTableAdapters.ensayosTableAdapter
    Friend WithEvents TableAdapterManager As datalogerBeta1.dbBiogasDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NroensayoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtReactor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtReactor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtReactor3 As System.Windows.Forms.TextBox
    Friend WithEvents DataTableAdapter As datalogerBeta1.dbBiogasDataSetTableAdapters.dataTableAdapter
    Friend WithEvents EnsayosdataBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EnsayosBindingSource1 As System.Windows.Forms.BindingSource
End Class
