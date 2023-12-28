Partial Class TAKEOFFDataSetProjectName
    Partial Public Class PROJECTDataTable
        Private Sub PROJECTDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PROJECT_NAMEColumn.ColumnName) Then
                'Ajoutez le code utilisateur ici
            End If

        End Sub

    End Class
End Class
