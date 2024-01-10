Imports MySql.Data.MySqlClient
Imports System.ComponentModel
Public Class FormItemsDataEntry
    Private Sub FormItemsDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSetProject.PROJECT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.PROJECTTableAdapter.Fill(Me.TAKEOFFDataSetProject.PROJECT)
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSet3.ITEMS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.ITEMSTableAdapter.Fill(Me.TAKEOFFDataSet3.ITEMS)
        '
        CenterForm(Me)
        FindProjectListe()
        'AddHandler RadGridViewProjectName.CellClick, AddressOf RadGridViewProjectNameClick
    End Sub

    Private Sub SetColumnHeader()
        RadGridViewProjectName.Columns(0).HeaderText = "Index"
        RadGridViewProjectName.Columns(1).HeaderText = "Project Index"
        RadGridViewProjectName.Columns(2).HeaderText = "Project Code"
        RadGridViewProjectName.Columns(3).HeaderText = "Project Name"
        RadGridViewProjectName.Columns(4).HeaderText = "Project Create Date"
        RadGridViewProjectName.Columns(5).HeaderText = "Project Status"

        RadGridViewProjectName.Columns(0).Width = 50
        RadGridViewProjectName.Columns(1).Width = 90
        RadGridViewProjectName.Columns(2).Width = 120
        RadGridViewProjectName.Columns(3).Width = 160
        RadGridViewProjectName.Columns(4).Width = 150
        RadGridViewProjectName.Columns(5).Width = 120

        RadGridViewProjectName.Columns(0).TextAlignment = ContentAlignment.MiddleCenter
        RadGridViewProjectName.Columns(1).TextAlignment = ContentAlignment.MiddleCenter
        RadGridViewProjectName.Columns(2).TextAlignment = ContentAlignment.MiddleLeft
        RadGridViewProjectName.Columns(3).TextAlignment = ContentAlignment.MiddleLeft
        RadGridViewProjectName.Columns(4).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewProjectName.Columns(5).TextAlignment = ContentAlignment.MiddleCenter
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
        RadGridViewProjectName.CloseEditor()
        currentRow.Cells(1).Value = RadSpinEditorProjectIndex.Value
        currentRow.Cells(2).Value = RadTextBoxProjectCode.Text
        currentRow.Cells(3).Value = RadTextBoxProjectName.Text
        currentRow.Cells(4).Value = RadDateTimePickerCreateDate.Text
        currentRow.Cells(5).Value = RadTextBoxProjectStatus.Text
        RadLabelElementMessage.Text = ""
    End Sub

    Private Sub ButtonGridviewUpdate_Click(sender As Object, e As EventArgs) Handles ButtonGridviewUpdateProjectMainForm.Click
        Dim idx As Integer
        'UpdateGridInfoProject(Me.RadGridViewProjectName.CurrentRow, irow)
        If RadGridViewProjectName.CurrentRow Is Nothing Then
            Return
        End If
        'currentRow.Index
        If IsDBNull(RadGridViewProjectName.CurrentRow.Cells(1).Value) Then
            Return
        End If
        idx = RadGridViewProjectName.CurrentRow.Cells(0).Value
        UpdateProjectDB(idx, RadTextBoxProjectCode.Text, RadTextBoxProjectName.Text, RadTextBoxProjectStatus.Text)
        FindProjectListe()
        Try
            '@@@@@TOTOTO  Me.PROJECTTableAdapter.Update(Me.TAKEOFFDataSetProject)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonGridviewDelete_Click(sender As Object, e As EventArgs) Handles ButtonGridviewDeleteProjectMainForm.Click
        Dim idx As Integer
        'UpdateGridInfoProject(Me.RadGridViewProjectName.CurrentRow, irow)
        If RadGridViewProjectName.CurrentRow Is Nothing Then
            Return
        End If
        'currentRow.Index
        If IsDBNull(RadGridViewProjectName.CurrentRow.Cells(1).Value) Then
            Return
        End If
        idx = RadGridViewProjectName.CurrentRow.Cells(0).Value
        DeleteProjectDB(idx)
        FindProjectListe()
        Try
            '@@@@@TOTOTO  Me.PROJECTTableAdapter.DeleteQuery(idx)
            'Me.RadGridViewProjectName.CurrentRow.Delete()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub ButtonGridviewNew_Click(sender As Object, e As EventArgs) Handles ButtonGridviewNewProjectMainForm.Click
        Dim iindex As Integer = FindLastProjectCount() + 1
        AddProjectDB(iindex, RadTextBoxProjectCode.Text, RadTextBoxProjectName.Text, RadTextBoxProjectStatus.Text)
        FindProjectListe()
        Try
            '@@@@@TOTOTO  Me.PROJECTTableAdapter.Insert(iindex, RadTextBoxProjectCode.Text, RadTextBoxProjectName.Text, Date.Now(), Date.Now(), RadTextBoxProjectStatus.Text, "")
            '@@@@@TOTOTO  Me.PROJECTTableAdapter.Update(Me.TAKEOFFDataSetProject)
        Catch ex As Exception
        End Try
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
            SetColumnHeader()
            connection.Close()
        End If
        Return cpt
    End Function

    Private Sub FormItemsDataEntry_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.Show()
    End Sub

    Private Sub RadGridViewProjectName_SelectionChanged(sender As Object, e As EventArgs) Handles RadGridViewProjectName.SelectionChanged
        RadSpinEditorIndex.Value = Val(RadGridViewProjectName.CurrentRow.Cells(0).Value.ToString)
        RadSpinEditorProjectIndex.Value = Val(RadGridViewProjectName.CurrentRow.Cells(1).Value.ToString)
        RadTextBoxProjectCode.Text = RadGridViewProjectName.CurrentRow.Cells(2).Value.ToString
        RadTextBoxProjectName.Text = RadGridViewProjectName.CurrentRow.Cells(3).Value.ToString
        RadDateTimePickerCreateDate.Text = RadGridViewProjectName.CurrentRow.Cells(4).Value.ToString
        RadTextBoxProjectStatus.Text = RadGridViewProjectName.CurrentRow.Cells(5).Value.ToString
        RadDateTimePickerModifyDate.Value = DateTime.Now
    End Sub

    Private Sub AddProjectDB(ByVal pIndex As Integer, ByVal pCode As String, ByVal pName As String, ByVal pStatus As String)
        Dim mysql As String
        mysql = "INSERT INTO project(`PrOJECT_INDEX`, `PrOJECT_CODE`, `PrOJECT_NAME`, `PrOJECT_CREAT_DATE`, `PrOJECT_STATUS`) VALUES (" + pIndex.ToString + ", '" + pCode + "', '" + pName + "', CURDATE(), '" + pStatus + "')"
        Try
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
    End Sub

    Private Sub UpdateProjectDB(ByVal idx As Integer, ByVal pCode As String, ByVal pName As String, ByVal pStatus As String)
        Dim mysql As String
        mysql = "UPDATE project SET `PrOJECT_CODE` = '" + pCode + "', `PrOJECT_NAME` = '" + pName + "', `PrOJECT_STATUS` = '" + pStatus + "' WHERE `INDEX` = " + idx.ToString
        Try
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
    End Sub

    Private Sub DeleteProjectDB(ByVal idx As Integer)
        Dim mysql As String
        mysql = "DELETE FROM project WHERE `INDEX` = " + idx.ToString
        Try
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
    End Sub
End Class
