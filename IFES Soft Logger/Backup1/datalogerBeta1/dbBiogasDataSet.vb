Partial Class dbBiogasDataSet
    Partial Class cons1DataTable

        Private Sub cons1DataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.caudalActColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
