Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports Devart.Data
Public Class FormListView
    Public Const const_Project_index = 0
    Public Const const_Main_Root = 1
    Public Const const_Category = 2
    Public Const const_Main_Root_total_Cost = 3
    Public Const const_Main_Root_total_VAT_Cost = 4
    Public Const const_Category_total_VAT_Cost = 5
    Public Const const_const_Project_index = 6
    Dim DataGridviewRows As Integer = 0
    Dim ArrayGroupe As ArrayList
    Dim ArrayPictureLogo(10) As PictureBox
    Dim ArrayItemsCODE(10) As Label
    Dim ArrayItemsName(10) As Label
    Dim ArrayCurrentItems As ArrayList
    Dim imageArrayLocation = {5, 77, 139, 175, 220, 265, 310, 355, 400, 445, 510, 700}
    Dim ImgLogoItems = New Image() {
                        My.Resources.tennis_100,
                        My.Resources.veranda_100,
                        My.Resources.ESTIMATOR_100
                        }

    Private Sub DisplayProject()
        Me.RadDataLayout1.ItemDefaultHeight = 26
        Me.RadDataLayout1.ColumnCount = 2
        Me.RadDataLayout1.FlowDirection = FlowDirection.TopDown
        Me.RadDataLayout1.AutoSizeLabels = True
        '
        Me.RadDataLayout1.DataSource = New ClassProjectName() With {
    .FirstName = "Sarah",
    .LastName = "Blake",
    .Occupation = "Supplied Manager",
    .StartingDate = New DateTime(2005, 4, 12),
    .IsMarried = True
}

        Dim employees As New List(Of ClassProjectName)()
        employees.Add(New ClassProjectName() With {
    .FirstName = "Sarah nnnnn",
    .LastName = "Blake nnnnn",
    .Occupation = "Supplied Manager",
    .StartingDate = New DateTime(2005, 4, 12),
    .IsMarried = True
})
        employees.Add(New ClassProjectName() With {
    .FirstName = "Jane",
    .LastName = "Simpson",
    .Occupation = "Security",
    .StartingDate = New DateTime(2008, 12, 3),
    .IsMarried = True
})
        employees.Add(New ClassProjectName() With {
    .FirstName = "John",
    .LastName = "Peterson",
    .Occupation = "Consultant",
    .StartingDate = New DateTime(2005, 4, 12),
    .IsMarried = False
})
        employees.Add(New ClassProjectName() With {
    .FirstName = "Peter",
    .LastName = "Bush",
    .Occupation = "Cashier",
    .StartingDate = New DateTime(2005, 4, 12),
    .IsMarried = True
})

        Me.RadDataLayout1.DataSource = employees
        Me.BindingSource1.DataSource = employees
        Me.RadDataLayout1.DataSource = Me.BindingSource1
        Me.RadBindingNavigator1.BindingSource = Me.BindingSource1
        'Me.RadBindingNavigator1.BindingSource = employees





    End Sub
    Private Sub FormListView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm(Me)
        Dim Category, ProjectName As String
        ProjectName = FindProjectName(0)
        DisplayProject()
        Exit Sub
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSet42.INVOICE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        '        Me.INVOICETableAdapter.Fill(Me.TAKEOFFDataSet42.INVOICE)
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSet41.INVOICE'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.INVOICETableAdapter.Fill(Me.TAKEOFFDataSet41.INVOICE)
        Me.ITEMSTableAdapter.ProjectOne(Me.TAKEOFFDataSet1.ITEMS, 1)
        Me.FILES_PATHTableAdapter.ProjectOne(Me.TAKEOFFDataSet2.FILES_PATH, 1)
        Me.AllowDrop = True
        AddHandler RadGridViewItems.CellClick, AddressOf RadGridViewItems_CommandCellClick
        ArrayCurrentItems = New ArrayList
        ArrayCurrentItems.Add(1)  'const_Project_index
        ArrayCurrentItems.Add("_ROOT")
        ArrayCurrentItems.Add("SECURITY")
        ArrayCurrentItems.Add(0)
        ArrayCurrentItems.Add(0)
        ArrayCurrentItems.Add(0)
        ArrayCurrentItems.Add("Project Name")
        RadTextBox1.Width = 150

        If RadGridViewItems.Rows.Count > 0 Then
            Category = RadGridViewItems.Rows(0).Cells(5).Value
            ProjectName = RadGridViewItems.Rows(0).Cells(3).Value
        Else
            Category = ArrayCurrentItems(const_Category)
            ProjectName = ArrayCurrentItems(const_Project_index)
        End If
        display_ProjectCathegory_Flash(Category, "Cathegory")
        display_ProjectName_Flash(ProjectName, "Project")

    End Sub

    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            RadListViewDocuments.Items.Add(path)
        Next
        display_ButtonSave_Flash("Save", "")
    End Sub

    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub display_ButtonSave_Flash(Name As String, titre As String)
        Try
            RadButtonPathNameSave.Text = "<html><b>" + Name + "</b><html>"
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadButtonPathNameSave.ForeColor = Color.Gray
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadButtonPathNameSave.ForeColor = Color.Black
            'display_flash(Brand_Name)
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Try
            'display_DataEntry_Centre_from_arrayValue()
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            RadLabelStatusMessage.Text = strFileName
        End If
    End Sub

    Private Sub RadGridViewItems_CommandCellClick(sender As Object, e As EventArgs)
        Dim lastRow As GridViewRowInfo = RadGridViewItems.Rows(RadGridViewItems.Rows.Count - 1)
        Dim iindex As Integer = RadGridViewItems.CurrentRow.Cells(2).Value
        Dim ProjectName As String = ""
        ProjectName = FindProjectName(iindex)
        Dim Category As String = RadGridViewItems.CurrentRow.Cells(5).Value

        display_ProjectCathegory_Flash(Category, "Cathegory")
        display_ProjectName_Flash(ProjectName, "Project")
        ArrayCurrentItems(const_Category) = Category
    End Sub
    Private Sub display_ProjectCathegory_Flash(Name As String, titre As String)
        Try
            RadLabelGlobalCathegory.Text = "<html><p>" + titre + " : <b><span style=""font-size: medium"">" + Name + "</b><html>"
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadLabelGlobalCathegory.ForeColor = Color.Gray
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadLabelGlobalCathegory.ForeColor = Color.White
            'display_flash(Brand_Name)
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Try
            'display_DataEntry_Centre_from_arrayValue()
        Catch ex As Exception
            Me.Text = ex.Message
        End Try

    End Sub
    Private Sub display_ProjectName_Flash(Name As String, titre As String)
        Try
            RadLabelProjectNameGlobal.Text = "<html><p>" + titre + " : <b><span style=""font-size: medium"">" + Name + "</b><html>"
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadLabelProjectNameGlobal.ForeColor = Color.Gray
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadLabelProjectNameGlobal.ForeColor = Color.White
            'display_flash(Brand_Name)
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Try
            'display_DataEntry_Centre_from_arrayValue()
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub
    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.FILES_PATHTableAdapter.Fill(Me.TAKEOFFDataSet2.FILES_PATH)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Function FindProjectName(ByVal project_index As Integer)

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
            Me.RadGridViewInvoice.DataSource = reader
            cpt = RadGridViewInvoice.Rows.Count
            connection.Close()
        End If
        Return cpt





        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "PROJECT"
        Dim resultat As String = ""
        Dim iindex As Integer
        Dim ds As New DataSet
        Dim sql_tout_afficher As String
        sql_tout_afficher = "SELECT * FROM " + local_tableName + " WHERE  PROJECT_INDEX=" + Str(project_index)
        Dim con As New OleDb.OleDbConnection
        Dim nombre As Long
        con.ConnectionString = GlobalProvider
        If nombre > 0 Then

            iindex = ds.Tables(local_tableName).Rows(i).Item("PROJECT_INDEX")
            resultat = ds.Tables(local_tableName).Rows(i).Item("PROJECT_CODE")
            Return resultat
        Else
            Return ""
        End If
    End Function
    Private Function FindProjectPathName(ByVal iindex As Integer) As String
        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "PROJECT"
        Dim resultat As String = ""
        Dim DataPathName As String = ""
        Dim ds As New DataSet
        Dim sql_tout_afficher As String
        sql_tout_afficher = "SELECT * FROM " + local_tableName + " WHERE PROJECT_INDEX = " + Str(iindex)
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
            DataPathName = ds.Tables(local_tableName).Rows(nombre).Item("PROJECT_DATA_PATHNAME")
        End If
        'nombre = ds.Tables(local_tableName).Rows.Count
        Return DataPathName
    End Function
    Private Function FindLastpathCount()

        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "FILES_PATH"
        Dim resultat As String = ""
        Dim iindex As Integer
        Dim ds As New DataSet
        Dim sql_tout_afficher As String
        sql_tout_afficher = "SELECT * FROM " + local_tableName + " ORDER BY FILES_PATH_INDEX"
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
            iindex = ds.Tables(local_tableName).Rows(nombre).Item("FILES_PATH_INDEX")
        End If
        'nombre = ds.Tables(local_tableName).Rows.Count
        Return iindex
    End Function



    Private Function ExtractFilename(ByVal StrPath As String, ByRef pathname As String, Optional WithExt As Boolean = False) As String
        Dim strRet As String
        Dim l As Integer
        strRet = Split(StrPath, "\")(UBound(Split(StrPath, "\")))
        l = Len(strRet)
        If l > 0 Then
            pathname = Microsoft.VisualBasic.Left(StrPath, Len(StrPath) - l)
        End If
        If Not WithExt Then
            strRet = Split(strRet, ".")(0)
        End If

        ExtractFilename = strRet
    End Function

    Private Sub RadGridViewItems_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonGridviewDelete_Click(sender As Object, e As EventArgs)
        Dim iindex As Integer = -1
        UpdateInvoiceGridInfo(Me.RadGridViewInvoice.CurrentRow, iindex)
        Try
            Me.INVOICETableAdapter.DeleteQuery(iindex)
            Me.RadGridViewInvoice.CurrentRow.Delete()
            'UpdateGridInfo(Me.RadGridViewItems.CurrentRow, irow)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonGridviewNew_Click(sender As Object, e As EventArgs)
        Dim iindex As Integer = 0
        RadGridViewInvoice.Rows.AddNew()
        RadSpinEditorInvoiceType.Value = 1
        RadSpinEditorProjectIndex.Value = ArrayCurrentItems(const_Project_index)
        RadSpinEditorInvoiceIndex.Value = FindLastInvoiceCount() + 1
        display_UpdateText_Flash("Update", "")
    End Sub
    Private Sub display_UpdateText_Flash(Name As String, titre As String)
        Try
            RadButtonInvoiceUpdate.Text = "<html><b>" + Name + "</b><html>"
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadButtonInvoiceUpdate.ForeColor = Color.Gray
            Application.DoEvents()
            System.Threading.Thread.Sleep(300)
            RadButtonInvoiceUpdate.ForeColor = Color.Black
            'display_flash(Brand_Name)
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Try
            'display_DataEntry_Centre_from_arrayValue()
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub


    Private Function FindLastInvoiceCount()

        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "INVOICE"
        Dim resultat As String = ""
        Dim iindex As Integer
        Dim ds As New DataSet
        Dim sql_tout_afficher As String
        sql_tout_afficher = "SELECT * FROM " + local_tableName + " ORDER BY INVOICE_INDEX "
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
            iindex = ds.Tables(local_tableName).Rows(nombre).Item("INVOICE_INDEX")
        End If
        'nombre = ds.Tables(local_tableName).Rows.Count
        Return iindex
    End Function
    Private Sub UpdateInvoiceGridInfo(ByVal currentRow As GridViewRowInfo, ByRef iindex As Integer)
        Exit Sub
        Dim vatPC As Double
        'currentRow.Index
        If IsDBNull(currentRow.Cells(1).Value) Then
            iindex = FindLastInvoiceCount() + 1
            currentRow.Cells(1).Value = iindex
        Else
            iindex = currentRow.Cells(1).Value
        End If
        Me.RadGridViewInvoice.CloseEditor()
        If IsNothing(RadSpinEditorVATPourcent.Value) Then
            RadSpinEditorVATPourcent.Value = 0
        End If
        currentRow.Cells(2).Value = RadDateTimePickerInvoiceCreatDate.Value.ToShortDateString
        currentRow.Cells(3).Value = RadDateTimePickerModifyDate.Value.ToShortDateString
        currentRow.Cells(4).Value = RadTextBoxInvoiceNumber.Text
        currentRow.Cells(5).Value = RadSpinEditorType.Value
        currentRow.Cells(6).Value = RadSpinEditorInvoiceProjectIndex.Value
        currentRow.Cells(7).Value = RadSpinEditorInvoiceItemIndex.Value
        currentRow.Cells(8).Value = RadTextBoxInvoiceSupplier.Text
        currentRow.Cells(9).Value = RadSpinEditorInvoiceAmount.Value
        currentRow.Cells(10).Value = RadSpinEditorInvoiceVATPourcent.Text
        If vatPC = 0 Then
            vatPC = 20
        End If
        vatPC = currentRow.Cells(10).Value / 100
        currentRow.Cells(11).Value = currentRow.Cells(9).Value * vatPC
        RadSpinEditorInvoiceVATAmount.Text = currentRow.Cells(11).Value.ToString
        RadLabelStatusMessage.Text = ""
        Dim newRowInfo As GridViewNewRowInfo = TryCast(currentRow, GridViewNewRowInfo)
        If newRowInfo IsNot Nothing Then
            currentRow.InvalidateRow()
        Else
            CType(Me.RadGridViewInvoice.CurrentRow.DataBoundItem, IEditableObject).EndEdit()
        End If
    End Sub
    Private Sub RadSpinEditorInvoiceAmount_lastfocus(sender As Object, e As EventArgs) Handles RadSpinEditorInvoiceAmount.LostFocus
        Dim vatpc As Double
        vatpc = Val(RadSpinEditorInvoiceVATPourcent.Text)
        If vatpc = 0 Then
            RadSpinEditorInvoiceVATPourcent.Text = "20.00"
        End If
        vatpc = vatpc / 100
        RadSpinEditorInvoiceVATAmount.Value = RadSpinEditorInvoiceAmount.Value * vatpc
    End Sub
    'SelectedIndexChanged
    Private Sub ButtonGridviewUpdate_CellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridViewInvoice.CellClick
        If (e.RowIndex >= 0) Then
            RadTextBoxNumEtiquette.Text = RadGridViewInvoice.Rows(e.RowIndex).Cells("NumEtiquette").Value.ToString
            'FindNumEtiquette(RadTextBoxNumEtiquette.Text, -1)
        End If
        Exit Sub
        'UpdateInvoiceGridInfo(Me.RadGridViewInvoice.CurrentRow, irow)
        Try
            Me.INVOICETableAdapter.Update(Me.TAKEOFFDataSet41.INVOICE)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.INVOICETableAdapter.Fill(Me.TAKEOFFDataSet41.INVOICE)
        Me.ITEMSTableAdapter.ProjectOne(Me.TAKEOFFDataSet1.ITEMS, 1)
        Me.FILES_PATHTableAdapter.ProjectOne(Me.TAKEOFFDataSet2.FILES_PATH, 1)
    End Sub
    Private Sub RadCollapsiblePanelDocPathName_Collapsed(sender As Object, e As EventArgs) Handles RadCollapsiblePanelDocPathName.Collapsed
        RadCollapsiblePanelInvoice.Top = RadCollapsiblePanelDocPathName.Top + RadCollapsiblePanelDocPathName.Height + 3
    End Sub
    Private Sub RadCollapsiblePanelDocPathName_Expanded(sender As Object, e As EventArgs) Handles RadCollapsiblePanelDocPathName.Expanded
        RadCollapsiblePanelInvoice.Top = RadCollapsiblePanelDocPathName.Top + RadCollapsiblePanelDocPathName.Height + 3
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButtonInvoiceUpdate.Click
        Dim irow As Integer = -1
        UpdateInvoiceGridInfo(Me.RadGridViewInvoice.CurrentRow, irow)
        Try
            Me.INVOICETableAdapter.Update(Me.TAKEOFFDataSet41.INVOICE)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadButtonSupplierInvoiceDelete_Click(sender As Object, e As EventArgs) Handles RadButtonSupplierInvoiceDelete.Click
        Dim irow As Integer = -1
        UpdateInvoiceGridInfo(Me.RadGridViewInvoice.CurrentRow, irow)
        Try
            Me.INVOICETableAdapter.Update(Me.TAKEOFFDataSet41.INVOICE)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub RadButtonInvoiceNEW_Click(sender As Object, e As EventArgs) Handles RadButtonInvoiceNEW.Click
        Exit Sub
        Dim iindex As Integer = 0
        RadGridViewInvoice.Rows.AddNew()
        RadSpinEditorInvoiceType.Value = 1
        RadSpinEditorProjectIndex.Value = ArrayCurrentItems(const_Project_index)
        RadSpinEditorInvoiceIndex.Value = FindLastInvoiceCount() + 1
        display_UpdateText_Flash("Update", "")
    End Sub

    Private Sub RadButtonPathNameClear_Click(sender As Object, e As EventArgs) Handles RadButtonPathNameClear.Click
        RadListViewDocuments.Items.Clear()
    End Sub
    Private Sub RadButtonParthnameIcon_Click(sender As Object, e As EventArgs) Handles RadButtonParthnameIcon.Click
        RadListViewDocuments.ViewType = ListViewType.IconsView
    End Sub
    Private Sub RadButtonPathNameDetails_Click(sender As Object, e As EventArgs) Handles RadButtonPathNameDetails.Click
        RadListViewDocuments.ViewType = ListViewType.DetailsView
    End Sub

    Private Sub RadButtonPathNameSave_Click(sender As Object, e As EventArgs) Handles RadButtonPathNameSave.Click
        Dim docCounter As Integer
        Dim i As Integer = 0
        Dim temp As String
        Dim MyFileName As String
        docCounter = RadListViewDocuments.Items.Count
        If docCounter > 0 Then
            Dim pathcount As Integer = 0
            Dim pathname As String = ""
            pathcount = FindLastpathCount()
            For i = 0 To docCounter - 1
                temp = RadListViewDocuments.Items(i).Value
                MyFileName = ExtractFilename(temp, pathname, True)
                Try
                    Me.FILES_PATHTableAdapter.InsertQuery(pathcount + i + 1, pathname, MyFileName, ArrayCurrentItems(const_Category), 1)
                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)
                End Try
            Next i
            Me.FILES_PATHTableAdapter.ProjectOne(Me.TAKEOFFDataSet2.FILES_PATH, 1)
            RadButtonPathNameSave.Text = "Save"
        End If
    End Sub

    Private Sub RadButtonPathNameListView_Click(sender As Object, e As EventArgs) Handles RadButtonPathNameListView.Click
        RadListViewDocuments.ViewType = ListViewType.ListView
    End Sub

    Private Sub RadButtonProjectManager_Click(sender As Object, e As EventArgs) Handles RadButtonProjectManager.Click
        FormItemsDataEntry.Show()
    End Sub

    Private Sub RadGridViewInvoice_Click(sender As Object, e As GridViewCellEventArgs) Handles RadGridViewInvoice.Click
        If (e.RowIndex >= 0) Then
            RadTextBoxNumEtiquette.Text = RadGridViewInvoice.Rows(e.RowIndex).Cells("NumEtiquette").Value.ToString
            'FindNumEtiquette(RadTextBoxNumEtiquette.Text, -1)
        End If
        Exit Sub
        'UpdateInvoiceGridInfo(Me.RadGridViewInvoice.CurrentRow, irow)
        Try
            Me.INVOICETableAdapter.Update(Me.TAKEOFFDataSet41.INVOICE)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormListView_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainForm.Show()
    End Sub
End Class
