Public Class frmUsuarios

    Private Sub guardar()
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBiogasDataSet)

    End Sub

    Private Sub frmUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbBiogasDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.DbBiogasDataSet.usuarios)

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Dim resp As Integer = MessageBox.Show("¿Desea agregar un nuevo personal?", "Nuevo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = vbYes Then
            UsuariosBindingSource.AddNew()
            NombreTextBox.Enabled = True
            CargoTextBox.Enabled = True
            btnGuardar.Enabled = True
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False

        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        guardar()
        NombreTextBox.Enabled = False
        CargoTextBox.Enabled = False
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim resp As Integer = MessageBox.Show("¿Desea modificar la persona seleccionada?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = vbYes Then
            NombreTextBox.Enabled = True
            CargoTextBox.Enabled = True
            btnGuardar.Enabled = True
            btnNuevo.Enabled = False
            btnModificar.Enabled = False
            btnEliminar.Enabled = False

        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim resp As Integer = MessageBox.Show("¿Desea eliminar a la persona seleccionada?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = vbYes Then
            If UsuariosDataGridView.RowCount > 0 Then
                UsuariosBindingSource.RemoveCurrent()
                guardar()
            End If
        End If
    End Sub
End Class