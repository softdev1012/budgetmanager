Public Class FormCalendard
    Private Sub FormCalendard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'TakeoffDataSet51.PROJECT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.PROJECTTableAdapter.Fill(Me.TakeoffDataSet51.PROJECT)

    End Sub
End Class