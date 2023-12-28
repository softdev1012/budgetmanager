Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports Devart.Data
Imports System.ComponentModel
Public Class FormItemsDataEntry
    Private Sub FormItemsDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSetProject.PROJECT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.PROJECTTableAdapter.Fill(Me.TAKEOFFDataSetProject.PROJECT)
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSet3.ITEMS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.ITEMSTableAdapter.Fill(Me.TAKEOFFDataSet3.ITEMS)
        '
        FindProjectListe()
        CenterForm(Me)
        'AddHandler RadGridViewProjectName.CellClick, AddressOf RadGridViewProjectNameClick
    End Sub
    Private Sub ButtonGridviewDelete_Click(sender As Object, e As EventArgs) Handles ButtonGridviewDeleteProjectMainForm.Click
        Dim iindex As Integer = -1
        UpdateGridInfoProject(Me.RadGridViewProjectName.CurrentRow, iindex)

        Try
            Me.PROJECTTableAdapter.DeleteQuery(iindex)
            Me.RadGridViewProjectName.CurrentRow.Delete()
            'UpdateGridInfo(Me.RadGridViewItems.CurrentRow, irow)
        Catch ex As Exception
        End Try
    End Sub




    Private Sub ButtonGridviewNew_Click(sender As Object, e As EventArgs) Handles ButtonGridviewNewProjectMainForm.Click
        Dim iindex As Integer = 0
        RadGridViewProjectName.Rows.AddNew()
        RadDateTimePickerDateModify.Value = Today.ToShortDateString
        RadDateTimePickerDateCreat.Value = Today.ToShortDateString
        RadDateTimePickerDateCreat.Value = Today.ToShortDateString
        RadTextBoxProjectMainFormStatus.Text = "IN PROGRESS"
        RadTextBoxProjectMainFormPathName.Text = "C:\TAKEOFF\DATA"
        'RadTextBoxItemsCode.Text = "Code Name" 'ArrayCurrentItems(const_Category)
        'RadTextBoxParent_Items.Text = ArrayCurrentItems(const_Category)
        'RadSpinEditorVATPorucent.Value = ArrayCurrentItems(const_VAT_Porucent)
        iindex = FindLastProjectCount() + 1
        RadSpinEditorProjectIndex.Value = iindex
    End Sub

    Private Function FindLastProjectCount()

        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "PROJECT"
        Dim resultat As String = ""
        Dim iindex As Integer
        Dim ds As New DataSet
        Dim sql_tout_afficher As String
        sql_tout_afficher = "SELECT * FROM " + local_tableName + " ORDER BY PROJECT_INDEX "
        Dim con As New OleDb.OleDbConnection
        Dim nombre As Long
        con.ConnectionString = GlobalProvider
        Dim cmd As OleDb.OleDbCommand
        cmd = New OleDb.OleDbCommand(sql_tout_afficher, con)
        cmd.Connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter With {
            .SelectCommand = cmd
        }
        da.Fill(ds, local_tableName)
        nombre = ds.Tables(local_tableName).Rows.Count - 1
        If nombre > 0 Then
            iindex = ds.Tables(local_tableName).Rows(nombre).Item("PROJECT_INDEX")
        End If
        'nombre = ds.Tables(local_tableName).Rows.Count
        Return iindex
    End Function

    Private Sub UpdateGridInfoProject(ByVal currentRow As GridViewRowInfo, ByRef iindex As Integer)

        If currentRow Is Nothing Then
            Return
        End If
        'currentRow.Index
        If IsDBNull(currentRow.Cells(1).Value) Then
            iindex = FindLastProjectCount() + 1
            currentRow.Cells(1).Value = iindex
        Else
            iindex = currentRow.Cells(1).Value
        End If
        Me.RadGridViewProjectName.CloseEditor()
        currentRow.Cells(1).Value = RadSpinEditorProjectIndex.Value

        RadLabelElementMessage.Text = ""
        Dim newRowInfo As GridViewNewRowInfo = TryCast(currentRow, GridViewNewRowInfo)
        If newRowInfo IsNot Nothing Then
            currentRow.InvalidateRow()
        Else
            CType(Me.RadGridViewProjectName.CurrentRow.DataBoundItem, IEditableObject).EndEdit()
        End If
    End Sub

    Private Sub ButtonGridviewUpdate_Click(sender As Object, e As EventArgs) Handles ButtonGridviewUpdateProjectMainForm.Click
        Dim irow As Integer = -1
        UpdateGridInfoProject(Me.RadGridViewProjectName.CurrentRow, irow)

        Try
            Me.PROJECTTableAdapter.Update(Me.TAKEOFFDataSetProject)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadGridViewProjectName_Click(sender As Object, e As EventArgs) Handles RadGridViewProjectName.Click
        'RadGridViewProjectName.GroupDescriptors.Expression = "PROJECT_CODE"
        'groupe
    End Sub


    Private Function FindProjectListe() As Integer
        Dim mysql As String
        Dim cpt As Integer
        Dim basename As String = "project"
        mysql = "SELECT *  FROM " + basename + " order by project_INDEX desc"
        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            Me.RadGridViewProjectName.DataSource = reader
            cpt = RadGridViewProjectName.Rows.Count
            connection.Close()
        End If
        Return cpt
    End Function

    Private Sub FormItemsDataEntry_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.Show()
    End Sub
End Class