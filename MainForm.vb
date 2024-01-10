Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class MainForm
    Public ProjectIndexGlobal As Integer = 0
    Public Global_Type_Charge As String = "ALL"
    Public next_index As Integer = 9999999
    Public Items_root As ArrayList
    Public Items_root_value As ArrayList
    Public Items_root_index As ArrayList
    Public project_name As ArrayList
    Public Const const_Project_index = 0
    Public Const const_Main_Root = 1
    Public Const const_Category = 2
    Public Const const_Main_Root_total_Cost = 3
    Public Const const_Main_Root_total_VAT_Cost = 4
    Public Const const_Category_total_VAT_Cost = 5
    Public Const const_VAT_Porucent = 6
    Public ClassItemsListe As ClassItemsListe

    Dim ArrayGroupe As ArrayList
    Dim ArrayCurrentItems As ArrayList
    Dim ArrayPictureLogo(10) As PictureBox
    Dim ArrayItemsCODE(10) As Label
    Dim ArrayItemsName(10) As Label
    Dim imageArrayLocation = {5, 77, 139, 175, 220, 265, 310, 355, 400, 445, 510, 700}
    Dim imageArrayMainMenuLocation = {40, 90, 140, 190, 240, 290, 340, 390, 440, 740} 'ecart 45
    Dim ImgLogoItems = New Image() {
                        My.Resources.bussy_100,
                        My.Resources.Construction_100,
                        My.Resources.veranda_100,
                        My.Resources.ESTIMATOR_100,
                        My.Resources.ESTIMATOR_100,
                        My.Resources.ESTIMATOR_100,
                        My.Resources.ESTIMATOR_100,
                        My.Resources.ESTIMATOR_100,
                        My.Resources.ESTIMATOR_100,
                                           My.Resources.ESTIMATOR_100
                        }

    Private NRow As Integer = 9
    Dim PictureBoxArray(NRow) As PictureBox
    Dim ImgPoubelleEnter = New Image() {
                        My.Resources.home_White_100x100,
                        My.Resources.architech_white_100x100,
                        My.Resources.calendrier_White_100x100,
                        My.Resources.User_White_100x100_inverse,
                        My.Resources.invoice_white_100x100,
                        My.Resources.Event_White_100x100,
                        My.Resources.settings_icon_128_white,
                        My.Resources.Bell_White_100x100,
                        My.Resources.Help_Center_White_100x100,
                        My.Resources.close_White_100x100
                        }
    Dim ImgPoubelleLeave = New Image() {
                        My.Resources.home_Gray_Clair_100x100,
                        My.Resources.architech_gray_100x100,
                        My.Resources.calendrier_Gray_clair_100x100,
                        My.Resources.User_Gray_Claire_100x100_inverse,
                        My.Resources.invoice_gray_clair_100x100,
                        My.Resources.Event_Gray_Claire_100x100,
                        My.Resources.settings_icon_128_Gray_Clair,
                        My.Resources.Bell_Gray_Claire_100x100,
                        My.Resources.Help_Center_Gray_Clair_100x100,
                        My.Resources.close_Gray_Clair_100x100
                        }
    Private BackColorGray = Color.FromArgb(46, 64, 62)
    Dim MenuLevel As Single  'quel menu active ?
    Dim IndexClicked As Integer = 0

    Dim dtProject As DataTable
    Private Sub fill_Project_Array()
        GlobalProviderForIDM = GlobalProviderForLocalHost
        FindProjectListe()
        Dim i As Integer = dtProject.Rows.Count
        If i > 0 Then
            project_name = New ArrayList
        Else
        End If
        Dim nombre As Integer = dtProject.Rows.Count - 1
        If nombre > 0 Then
            For i = 0 To nombre
                project_name.Add(dtProject.Rows(i).Item(2).ToString)
            Next
        Else

        End If
    End Sub

    Private Sub MainForm_closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        '9999 Dim i As Integer = Items_root.Count
        calcul_Datagridview_Items()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSet3.ITEMS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.ITEMSTableAdapter1.Fill(Me.TAKEOFFDataSet3.ITEMS)
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSet5.PROJECT'. Vous pouvez la déplacer ou la supprimer selon les besoins.

        'TODO: cette ligne de code charge les données dans la table 'TAKEOFFDataSetProjectName.PROJECT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.PROJECTTableAdapter.Fill(Me.TAKEOFFDataSetProjectName.PROJECT)
        'TODO: cette ligne de code charge les données dans la table 'TAKEOFDataSet.ITEMS'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        '@@@@@TOTOTO  Me.ITEMSTableAdapter.Fill(Me.TAKEOFDataSet.ITEMS)
        'AddHandler RadGridViewItems.CellClick, AddressOf RadGridViewItems_CommandCellClick
        AddHandler RadGridViewItems.GroupSummaryEvaluate, AddressOf RadGridViewItems_GroupSummaryEvaluate
        'AddHandler RadGridViewItems.GroupSummaryEvaluate, AddressOf radGridView1_GroupSummaryEvaluate

        CenterForm(Me)
        'FillProjectList_to_listview_old()
        init_main_menu()
        fill_Project_Array()
        init_Groupe()
        FillItems_root()

        'calcul_Datagridview_Items()
        ArrayCurrentItems = New ArrayList
        ArrayCurrentItems.Add(0)  'const_Project_index
        ArrayCurrentItems.Add("__ROOT")
        ArrayCurrentItems.Add("DEFAUT ITEMS")
        ArrayCurrentItems.Add(0)
        ArrayCurrentItems.Add(0)
        ArrayCurrentItems.Add(0)
        ArrayCurrentItems.Add(20) 'vat
        ArrayCurrentItems.Add(0)
        'ALL par défaut
        CheckedListBoxTypeCharge.SetItemChecked(0, True)
        Global_Type_Charge = CheckedListBoxTypeCharge.Items(0)
    End Sub

    Private Sub init_main_menu()

        For i = 0 To NRow

            PictureBoxArray(i) = New PictureBox
            PictureBoxArray(i).Name = Str(i)  'numero pour identifié le picturebox
            PictureBoxArray(i).BackColor = BackColorGray
            PictureBoxArray(i).Image = ImgPoubelleLeave(i)
            PictureBoxArray(i).SizeMode = PictureBoxSizeMode.StretchImage
            PictureBoxArray(i).Location = New Point(9, imageArrayMainMenuLocation(i))
            PictureBoxArray(i).Size = New Size(40, 40) '40,40
            PictureBoxArray(i).Visible = True
            PictureBoxArray(i).ContextMenuStrip = ContextMenuStrip
            'PictureBoxArray(i).Controls.Add(GroupBox1)
            'Me.Controls.Add(PictureBoxArray(i))
            GroupBoxMenuVertical.Controls.Add(PictureBoxArray(i))

            AddHandler PictureBoxArray(i).Click, AddressOf PictureBoxClickHandler
            AddHandler PictureBoxArray(i).MouseHover, AddressOf PictureBoxMouseHoverHandler
            AddHandler PictureBoxArray(i).MouseLeave, AddressOf PictureBoxMouseLeaveHandler
        Next
    End Sub
    Public Sub PictureBoxClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        'MsgBox("I am Picture #" & CType(sender, Button).Text)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)
        sender.image = ImgPoubelleEnter(indexPictureBox)
        IndexClicked = indexPictureBox
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(IndexClicked)
        MenuClick(IndexClicked)

    End Sub

    Private Sub MenuClick(ByVal PictureBoxClicked As Integer)

        Me.Controls.Remove(ListBoxItemsParent)
        'ListBox1.Visible = False
        Try
            '//// GroupBox2.Controls.Remove(ListBox1)
        Catch ex As Exception
        End Try
        MenuLevel = PictureBoxClicked
        Select Case PictureBoxClicked
            Case 0
                paneMain.Visible = True
            Case 1
                paneMain.Visible = False
            Case 2
                FormItemsDataEntry.Show()
                Me.Hide()
            'Case 4
            '    FormListView.Show()
            '    Me.Hide()
            Case 9
                c_fini()
        End Select

    End Sub

    Private Sub c_fini()
        Me.Close()
    End Sub
    Private Sub FillItems_root()

        Dim Items_Root_Name As String = ""
        Dim iindex As Integer = 0
        Dim i As Integer
        iindex = RadGridViewItems.Rows.Count
        If iindex > 0 Then
            'ListBoxItemsParent.Items.Clear()
            Items_root = New ArrayList
            Items_root_value = New ArrayList
            Items_root_index = New ArrayList
            For i = 0 To iindex - 1
                Items_Root_Name = RadGridViewItems.Rows(i).Cells(1).Value
                If Items_Root_Name = "__ROOT" Then
                    Items_root.Add(RadGridViewItems.Rows(i).Cells(4).Value)
                    ListBoxItemsParent.Items.Add(Items_Root_Name + " " + RadGridViewItems.Rows(i).Cells(4).Value + Str(i))
                    Items_root_index.Add(i) ' ligne dans datagrid
                End If

            Next
        Else
            Items_root = New ArrayList
            Items_root.Add("")
        End If

    End Sub
    Private Sub calcul_Datagridview_Items()
        Dim Items_Root_Name As String = ""
        Dim iindex As Integer = 0
        Dim Total_ligne As Double = 0
        Dim total_projet As Double = 0
        Dim montant_tva As Double
        Dim total_tva As Double = 0
        iindex = RadGridViewItems.Rows.Count
        Dim taux_tva As Double
        Dim jj, kk, i As Integer


        kk = 0
        Items_root_value = New ArrayList
        If iindex > 0 Then
            Total_ligne = 0
            ListBoxItemsParent.Items.Clear()
            ' liste des _ROOT
            For Each Items_Element In Items_root
                ListBoxItemsParent.Items.Add(Items_Element)

                For i = 0 To iindex - 1
                    Items_Root_Name = RadGridViewItems.Rows(i).Cells(5).Value
                    If Items_Root_Name <> "__ROOT" Then
                        If Items_Element = Items_Root_Name Then
                            Try
                                Total_ligne = RadGridViewItems.Rows(i).Cells(6).Value * RadGridViewItems.Rows(i).Cells(7).Value * RadGridViewItems.Rows(i).Cells(8).Value
                                RadGridViewItems.Rows(i).Cells(9).Value = Total_ligne
                                total_projet += Total_ligne
                                taux_tva = Format(RadGridViewItems.Rows(i).Cells(10).Value / 100, "0.00")
                                montant_tva = Total_ligne * taux_tva
                                RadGridViewItems.Rows(i).Cells(11).Value = montant_tva
                                total_tva += montant_tva
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                Next

                jj = Items_root_index(kk)
                If jj < iindex And jj >= 0 Then
                    RadGridViewItems.Rows(jj).Cells(9).Value = total_projet
                    RadGridViewItems.Rows(jj).Cells(11).Value = total_tva
                    Try
                        '@@@@@TOTOTO  Me.ITEMSTableAdapter.Update(Me.TAKEOFDataSet.ITEMS)
                    Catch ex As Exception
                        RadLabelElementMessage.Text = ex.Message
                    End Try
                    total_projet = 0
                    total_tva = 0
                End If
                kk += 1
            Next

        End If
    End Sub
    Private Sub display_ProjectCathegory_Flash(Name As String, titre As String)
        Try
            RadLabelGlobalCathegory.Text = "<html><p>" + titre + " : <b><span style=""font-size: medium"">" + Name + "</b><html>"
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            RadLabelGlobalCathegory.ForeColor = Color.Gray
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
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

    Private Sub RadGridViewItems_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridViewItems.CellClick
        ListBoxItemsParent.Items.Clear()
        ListBoxItemsParent.Items.Add("Click")
        Dim iindex As Integer = 0
        Dim Category As String = ""
        Dim lastRow As GridViewRowInfo = RadGridViewItems.Rows(RadGridViewItems.Rows.Count - 1)
        Try
            If IsDBNull(RadGridViewItems.CurrentRow.Cells(2).Value) Or IsNothing(RadGridViewItems.CurrentRow.Cells(2).Value) Then
                iindex = -1
                Category = ""

                Exit Sub
            Else
                Category = RadGridViewItems.CurrentRow.Cells(0).Value
                If IsDBNull(RadGridViewItems.CurrentRow.Cells(3).Value) Then
                    RadGridViewItems.CurrentRow.Cells(3).Value = 0
                End If
                iindex = RadGridViewItems.CurrentRow.Cells(1).Value
            End If

            'display_DataEntry_Centre_from_arrayValue()
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Category = RadGridViewItems.CurrentRow.Cells(2).Value
        Dim ProjectName As String = ""
        ProjectName = FindProjectName(iindex)
        DisplayProjectDetail()
        display_ProjectCathegory_Flash(Category, "Cathegory")
        display_ProjectName_Flash(ProjectName, "Project")
        ArrayCurrentItems(const_Category) = Category
        calculTotalLine(RadGridViewItems.CurrentRow.Index)
        Me.Text = RadGridViewItems.CurrentRow.Cells(2).Value.ToString + " " + Str(RadGridViewItems.CurrentRow.Cells(1).Value)

    End Sub

    Private Sub DisplayProjectDetail()
        Dim col As Integer
        col = RadGridViewItems.Columns.Count
        For i = 0 To col - 1
            ListBoxItemsParent.Items.Add(RadGridViewItems.Columns(i).Name + " " + RadGridViewItems.CurrentRow.Cells(i).Value.ToString)
        Next
        RadTextBox_INDEX.Text = RadGridViewItems.CurrentRow.Cells(0).Value.ToString
        RadTextBox_ITEMS_INDEX.Text = RadGridViewItems.CurrentRow.Cells(1).Value.ToString
        RadTextBoxITEMS_CODE.Text = RadGridViewItems.CurrentRow.Cells(2).Value.ToString
        RadTextBoxITEMS_NAME.Text = RadGridViewItems.CurrentRow.Cells(3).Value.ToString
        RadTextBoxITEMS_PARENT.Text = RadGridViewItems.CurrentRow.Cells(4).Value.ToString
        RadTextBoxITEMS_QUANTITY.Text = RadGridViewItems.CurrentRow.Cells(5).Value.ToString
        RadTextBoxITEMS_UNIT.Text = RadGridViewItems.CurrentRow.Cells(6).Value.ToString
        RadTextBoxITEMS_TAXE.Text = RadGridViewItems.CurrentRow.Cells(7).Value.ToString
        RadTextBoxITEMS_TAXE_VALUE.Text = RadGridViewItems.CurrentRow.Cells(8).Value.ToString
        RadTextBoxITEMS_CURRENCY.Text = RadGridViewItems.CurrentRow.Cells(9).Value.ToString
        Dim tempDate As DateTime = Convert.ToDateTime(RadGridViewItems.CurrentRow.Cells(10).Value.ToString)
        RadTextBoxITEMS_LAST_EDIT_DATE.Text = tempDate.ToString("MM/dd/yyyy")
        RadTextBox_MTTVA.Text = RadGridViewItems.CurrentRow.Cells(12).Value.ToString
        tempDate = Convert.ToDateTime(RadGridViewItems.CurrentRow.Cells(13).Value.ToString)
        RadTextBoxITEMS_DatePaiement.Text = tempDate.ToString("MM/dd/yyyy")
        RadTextBoxITEMS_PayeQui.Text = RadGridViewItems.CurrentRow.Cells(14).Value.ToString
        RadTextBoxITEMS_MT_PAIEMENT.Text = RadGridViewItems.CurrentRow.Cells(15).Value.ToString
        RadTextBoxITEMS_PAYE_QUI.Text = RadGridViewItems.CurrentRow.Cells(16).Value.ToString



    End Sub
    Private Sub calculTotalLine(ByVal iindex As Integer)

        Dim ClassItemsListe = New List(Of ClassItemsListe)
        Dim RowsCount As Integer = 0
        Dim lastRow As GridViewRowInfo = RadGridViewItems.Rows(RadGridViewItems.Rows.Count - 1)
        Dim CurrentCategory As String = ""
        Dim tofindCategory = RadGridViewItems.Rows(iindex).Cells(2).Value
        Dim totalline As Double = 0
        Dim totalPaye As Double = 0
        Dim Alltotal As Double = 0
        Dim AlltotalItems As Double = 0
        Dim colTotal As Integer = 12
        Dim FlagPaye As String = "N"
        Dim colTotalPaye As Integer = 15
        Dim colPayeQui As Integer = 16
        Dim ColFF As Integer = 17
        Dim colFlagPaye As Integer = 14
        RowsCount = RadGridViewItems.Rows.Count - 1
        ListBoxItemsParent.Items.Clear()

        For i = 0 To RowsCount
            Dim MTPaye As String = ""
            'If i <> iindex Then
            If IsDBNull(RadGridViewItems.Rows(i).Cells(2).Value) Then
            Else
                CurrentCategory = RadGridViewItems.Rows(i).Cells(2).Value
                If IsDBNull(RadGridViewItems.Rows(i).Cells(colTotal).Value) Then
                    RadGridViewItems.Rows(i).Cells(colTotal).Value = 0
                End If
                If tofindCategory = CurrentCategory Or iindex = 0 Then
                    totalline += Val(RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString)
                    FlagPaye = RadGridViewItems.Rows(i).Cells(colFlagPaye).Value.ToString
                    If FlagPaye = "O" Then
                        totalPaye += Val(RadGridViewItems.Rows(i).Cells(colTotalPaye).Value.ToString)
                        MTPaye = RadGridViewItems.Rows(i).Cells(colTotalPaye).Value.ToString
                    End If
                    Dim temp
                    temp = CurrentCategory + " " + RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString + RadGridViewItems.Rows(i).Cells(colTotalPaye).Value.ToString
                    ListBoxItemsParent.Items.Insert(0, temp)


                    '//// If RadGridViewItems.Rows(i).Cells(colFlagPaye).Value.ToString Then
                    ClassItemsListe.Add(New ClassItemsListe() With {
                          .Numlig = i + 1,
                          .Index_Items = RadGridViewItems.Rows(i).Cells(3).Value.ToString,
                          .Index_Date = ConvertDateMysql4(RadTextBoxITEMS_LAST_EDIT_DATE.Text),
                          .Montant = RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString,
                          .PayeOuiNon = RadGridViewItems.Rows(i).Cells(colFlagPaye).Value.ToString,
                          .Mt_Paye = MTPaye,
                          .AQui = Trim(RadGridViewItems.Rows(i).Cells(colPayeQui).Value.ToString),
                          .FF = Trim(RadGridViewItems.Rows(i).Cells(ColFF).Value.ToString)
                   })

                    'RadTextBox_INDEX.Text = RadGridViewItems.CurrentRow.Cells(0).Value.ToString
                    'RadTextBox_ITEMS_INDEX.Text = RadGridViewItems.CurrentRow.Cells(1).Value.ToString
                    'RadTextBoxITEMS_CODE.Text = RadGridViewItems.CurrentRow.Cells(2).Value.ToString
                    'RadTextBoxITEMS_NAME.Text = RadGridViewItems.CurrentRow.Cells(3).Value.ToString
                    'RadTextBoxITEMS_PARENT.Text = RadGridViewItems.CurrentRow.Cells(4).Value.ToString
                    'RadTextBoxITEMS_QUANTITY.Text = RadGridViewItems.CurrentRow.Cells(5).Value.ToString
                    'RadTextBoxITEMS_UNIT.Text = RadGridViewItems.CurrentRow.Cells(6).Value.ToString
                    'RadTextBoxITEMS_TAXE.Text = RadGridViewItems.CurrentRow.Cells(7).Value.ToString
                    'RadTextBoxITEMS_TAXE_VALUE.Text = RadGridViewItems.CurrentRow.Cells(8).Value.ToString
                    'RadTextBoxITEMS_CURRENCY.Text = RadGridViewItems.CurrentRow.Cells(9).Value.ToString
                    'RadTextBoxITEMS_LAST_EDIT_DATE.Text = Microsoft.VisualBasic.Left(RadGridViewItems.CurrentRow.Cells(10).Value.ToString, 10)
                    'RadTextBox_MTTVA.Text = RadGridViewItems.CurrentRow.Cells(12).Value.ToString
                    'RadTextBoxITEMS_DatePaiement.Text = RadGridViewItems.CurrentRow.Cells(13).Value.ToString
                    'RadTextBoxITEMS_PayeQui.Text = RadGridViewItems.CurrentRow.Cells(14).Value.ToString
                    'RadTextBoxITEMS_MT_PAIEMENT.Text = RadGridViewItems.CurrentRow.Cells(15).Value.ToString
                    'RadTextBoxITEMS_PAYE_QUI.Text = RadGridViewItems.CurrentRow.Cells(16).Value.ToString



                    '//// End If

                    AlltotalItems += Val(RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString)
                    Alltotal += Val(RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString)
                Else
                    Alltotal += Val(RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString)
                End If
            End If
        Next
        If ClassItemsListe.Count > 0 Then
            RadGridViewClassItemsListe.DataSource = ClassItemsListe
        End If
        RadLabelTotalEstimation.Text = Format(AlltotalItems, "0.00 €")
        RadLabelMTPaye.Text = Format(totalPaye, "0.00 €") + " payé."
        If iindex = 0 Then
            RadLabelCurrentItems.Text = "Toutes charges"
        Else
            RadLabelCurrentItems.Text = tofindCategory
        End If
        RadLabelAllTotalOfItems.Text = Format(Alltotal, "All total : 0.00 €")

        RadGridViewClassItemsListe.Columns(0).Width = 75
        RadGridViewClassItemsListe.Columns(1).Width = 130
        RadGridViewClassItemsListe.Columns(2).Width = 75
        RadGridViewClassItemsListe.Columns(3).Width = 75
        RadGridViewClassItemsListe.Columns(4).Width = 75
        RadGridViewClassItemsListe.Columns(5).Width = 75
        RadGridViewClassItemsListe.Columns(6).Width = 120
        RadGridViewClassItemsListe.Columns(7).Width = 75
        RadGridViewClassItemsListe.Columns(0).TextAlignment = ContentAlignment.MiddleCenter
        'RadGridViewClassItemsListe.Columns(1).TextAlignment = ContentAlignment.MiddleCenter
        'RadGridViewClassItemsListe.Columns(4).TextAlignment = ContentAlignment.MiddleCenter
        'RadGridViewClassItemsListe.Columns(5).TextAlignment = ContentAlignment.MiddleCenter
        RadGridViewClassItemsListe.Columns(2).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(3).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(4).TextAlignment = ContentAlignment.MiddleCenter
        RadGridViewClassItemsListe.Columns(5).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(6).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(7).TextAlignment = ContentAlignment.MiddleCenter


    End Sub
    Private Function FindProjectName(ByVal project_index As Integer)
        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "PROJECT"
        Dim resultat As String = ""
        Dim ds As New DataSet
        Dim sql_tout_afficher As String
        sql_tout_afficher = "SELECT * FROM " + local_tableName + " WHERE  PROJECT_INDEX=" + Str(project_index)
        Dim con As New OleDb.OleDbConnection
        con.ConnectionString = GlobalProvider

        Dim mysql As String
        Dim cpt As Integer
        Dim basename As String = "project"
        mysql = "SELECT *  FROM " + basename + " WHERE  PROJECT_INDEX=" + Str(project_index) + " order by project_INDEX desc"
        dtProject = New DataTable()
        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            dtProject.Load(reader)
            cpt = dtProject.Rows.Count
            If cpt > 0 Then
                resultat = dtProject.Rows(0).Item("PROJECT_CODE").ToString
            End If
            connection.Close()
        End If
        Return cpt
    End Function


    Private Sub RadListeiewProjectNameClick(sender As Object, e As EventArgs) Handles RadListeiewProjectName.SelectedIndexChanged
        'ItemMouseClick 
        Dim iindex As Integer
        iindex = RadListeiewProjectName.SelectedIndex
        Dim temp
        temp = RadListeiewProjectName.Items(0).Value
        '@@@@@TOTOTO  Me.ITEMSTableAdapter.PorjectOne(Me.TAKEOFDataSet.ITEMS, iindex)

        'calcul_Datagridview_Items()
    End Sub
    Private Sub radListViewNextPatients_ItemMouseClick(sender As Object, e As EventArgs) Handles RadListeiewProjectName.ItemMouseClick
        'ItemMouseClick 
        Dim iindex As Integer
        iindex = RadListeiewProjectName.SelectedIndex
        Dim temp
        temp = RadListeiewProjectName.Items(0).Value
        '@@@@@TOTOTO  Me.ITEMSTableAdapter.PorjectOne(Me.TAKEOFDataSet.ITEMS, iindex)

        'calcul_Datagridview_Items()
    End Sub

    Private Sub RadListView2_SelectedItemChanged(sender As Object, e As EventArgs)
        'Me.ITEMSTableAdapter.PorjectOne(Me.TAKEOFDataSet.ITEMS, 1)
    End Sub
    Private Sub radListViewNextPatients_VisualItemCreating(ByVal sender As Object, ByVal e As ListViewVisualItemCreatingEventArgs) Handles RadListeiewProjectName.VisualItemCreating
        e.VisualItem = New PatientsListViewVisualItem()
    End Sub
    Private Sub radListViewNextPatients_VisualItemFormatting(ByVal sender As Object, ByVal e As ListViewVisualItemEventArgs) Handles RadListeiewProjectName.VisualItemFormatting
        Exit Sub   '///////////////
        'TryCast(e.VisualItem, PatientsListViewVisualItem).TopRightElement.Text = (CDate(e.VisualItem.Data("Time"))).ToString("HH:mm")
        Dim itemIndex As Integer = Me.RadListeiewProjectName.Items.IndexOf(e.VisualItem.Data)
        Dim padding As Padding
        If itemIndex = 0 Then
            Dim fullName As String = e.VisualItem.Data("Name").ToString()
            If fullName.Length > 25 Then
                Dim names As String() = fullName.Split(New Char() {" "c})
                fullName = names(0) & "<br>  " & names(1)
            End If
            e.VisualItem.Text = "<html>" & "<span style=""color:#006DC0;font-size:24pt;font-family:Segoe UI Light;"">  " & fullName & "</span>" & "<br>" & "<span style=""color:#4F4C4C;font-size:13pt;font-family:Segoe UI;"">    " & e.VisualItem.Data("Age") & " yo | " & e.VisualItem.Data("Gender") & "</span>" & "</html>"

            e.VisualItem.BorderTopColor = Color.Transparent
            padding = New Padding(2, 1, 2, 9)
        Else
            If itemIndex = 1 Then
                padding = New Padding(2, 10, 2, 10)
            Else
                padding = New Padding(2, 10, 2, 1)
                e.VisualItem.BorderBottomColor = Color.Transparent
            End If

            e.VisualItem.Font = New Font("Segoe UI Light", 16.0F)
            e.VisualItem.ForeColor = Color.FromArgb(0, 109, 192)
            e.VisualItem.Text = "   " & e.VisualItem.Data("Name").ToString()
        End If

        e.VisualItem.Padding = padding
        e.VisualItem.TextAlignment = ContentAlignment.TopLeft
    End Sub

    Public Class PatientsListViewVisualItem
        Inherits SimpleListViewVisualItem
        Private topRightElement_Renamed As LightVisualElement

        Public ReadOnly Property TopRightElement() As LightVisualElement
            Get
                Return Me.topRightElement_Renamed
            End Get
        End Property

        Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
            Get
                Return GetType(SimpleListViewVisualItem)
            End Get
        End Property

        Protected Overrides Sub CreateChildElements()
            MyBase.CreateChildElements()

            Me.topRightElement_Renamed = New LightVisualElement()
            Me.topRightElement_Renamed.StretchHorizontally = False
            Me.topRightElement_Renamed.StretchVertically = False
            Me.topRightElement_Renamed.DrawFill = True
            Me.topRightElement_Renamed.NumberOfColors = 1
            Me.topRightElement_Renamed.BackColor = Color.FromArgb(27, 4, 69)
            Me.topRightElement_Renamed.ForeColor = Color.White
            Me.topRightElement_Renamed.Font = New Font("Segoe UI Semibold", 11.0F)
            Me.topRightElement_Renamed.Alignment = ContentAlignment.TopRight
            Me.topRightElement_Renamed.Padding = New Padding(2)

            Me.Children.Add(Me.topRightElement_Renamed)
        End Sub
    End Class
    Private Sub init_Groupe()
        Dim i As Integer = 0
        ArrayGroupe = New ArrayList
        Dim nombre_project As Integer = dtProject.Rows.Count - 1
        For i = 0 To nombre_project
            imageArrayLocation(i) = 5 + i * 67
            ArrayPictureLogo(i) = New PictureBox
            ArrayPictureLogo(i).Image = ImgLogoItems(i)
            ArrayPictureLogo(i).Name = Str(i)  'numero pour identifié le picturebox
            ArrayPictureLogo(i).SizeMode = PictureBoxSizeMode.StretchImage
            ArrayPictureLogo(i).Location = New Point(5, imageArrayLocation(i))
            ArrayPictureLogo(i).Size = New Size(65, 65)

            Me.RadListeiewProjectName.Controls.Add(ArrayPictureLogo(i)) 'RadPanelMenuItems
            AddHandler ArrayPictureLogo(i).Click, AddressOf MenuPrincipalClickHandler_picture
            'AddHandler ArrayPictureLogo(i).MouseHover, AddressOf PictureBoxMouseHoverHandler
            'AddHandler ArrayPictureLogo(i).MouseLeave, AddressOf PictureBoxMouseLeaveHandler
            '---------------------------------------
            ArrayItemsCODE(i) = New Label
            Me.ArrayItemsCODE(i).AutoSize = True
            Me.ArrayItemsCODE(i).Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ArrayItemsCODE(i).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ArrayItemsCODE(i).Location = New System.Drawing.Point(70, imageArrayLocation(i) + 5)
            Me.ArrayItemsCODE(i).Name = Str(i)
            Me.ArrayItemsCODE(i).Size = New System.Drawing.Size(84, 30)
            Me.ArrayItemsCODE(i).TabIndex = 2
            Me.ArrayItemsCODE(i).Text = "VERANDA"
            Me.RadListeiewProjectName.Controls.Add(ArrayItemsCODE(i)) 'RadPanelMenuItems
            AddHandler ArrayItemsCODE(i).Click, AddressOf MenuPrincipalClickHandler_code
            '---------------------------------------
            ArrayItemsName(i) = New Label
            Me.ArrayItemsName(i).AutoSize = True
            Me.ArrayItemsName(i).Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ArrayItemsName(i).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ArrayItemsName(i).Location = New System.Drawing.Point(72, imageArrayLocation(i) + 38)
            Me.ArrayItemsName(i).Name = Str(i)
            Me.ArrayItemsName(i).Size = New System.Drawing.Size(60, 25)
            Me.ArrayItemsName(i).TabIndex = 1
            Me.ArrayItemsName(i).Text = "VERANDA OF MR. FEDERIC HOLLAND"
            Me.RadListeiewProjectName.Controls.Add(ArrayItemsName(i)) 'RadPanelMenuItems
            AddHandler ArrayItemsName(i).Click, AddressOf MenuPrincipalClickHandler_name
        Next i
        If 1 = 2 Then
            Me.ArrayItemsCODE(0).Text = "TENNIS COURT"
            Me.ArrayItemsName(0).Text = "TENNIS COURT OF MANATHAN"
            Me.ArrayItemsCODE(1).Text = "VERANDA"
            Me.ArrayItemsName(1).Text = "VERANDA OF MR. FEDERIC HOLLAND"
            Me.ArrayItemsCODE(2).Text = "ESTIMATOR"
            Me.ArrayItemsName(2).Text = "Estimator Construction Software for Takeoff"
        End If
        '
        FillProjectList_to_groupBox()
    End Sub
    Private Sub FindItemsSql(ByVal idx As Integer)
        Dim mysql As String
        Dim cpt As Integer
        Dim basename As String = "ITEMS"
        Dim Critaire As String = ""
        Select Case Global_Type_Charge
            Case "ALL"
            Case "HORS ACHATS"
                Critaire = " and items_code != 'ACHATS' "
            Case "HORS SALAIRES"
                Critaire = " and items_code != 'SALAIRES' "
            Case "ACHATS"
                Critaire = " and items_code = 'ACHATS' "
            Case "SALAIRES"
                Critaire = " and items_code = 'SALAIRES' "
            Case "PETITES CHARGES"
                Critaire = " and items_code = 'PTITES CHARGES' "
            Case "LOYER ET AUTRES"
                Critaire = " and items_code = 'LOYERS' "
            Case "TAXES ET IMPOTS"
            Case "FRAIS BANCAIRES"

        End Select
        Dim FF As Boolean
        FF = RadCheckBoxFF.Checked
        If FF Then
            mysql = "SELECT `INDEX`, `items_INDEX`, items_code, items_name, items_parent, items_quantity, items_unit, items_taxe, items_taxe_value, items_currency, items_last_edit_date, items_projet_INDEX, items_price_total, items_date_paiement, items_paiement_ok, items_mt_payé, items_paye_qui, items_ff FROM " + basename + " where items_projet_INDEX = " + Str(idx) + Critaire + " order by items_paiement_ok, items_projet_INDEX desc"
        Else
            mysql = "SELECT `INDEX`, `items_INDEX`, items_code, items_name, items_parent, items_quantity, items_unit, items_taxe, items_taxe_value, items_currency, items_last_edit_date, items_projet_INDEX, items_price_total, items_date_paiement, items_paiement_ok, items_mt_payé, items_paye_qui, items_ff FROM " + basename + " where items_projet_INDEX = " + Str(idx) + " and items_ff = 'N' " + Critaire + " order by items_paiement_ok, items_projet_INDEX desc"
        End If
        'mysql = "SELECT items_INDEX,items_projet_INDEX,items_code,items_Name,items_Parent,items_projet_quantity,items_projet_unit,items_projet_price_total,items_projet_taxe,items_projet_taxe_valu,items_currency,items_last_edit_date  FROM " + basename + " where items_projet_INDEX = " + Str(idx) + " order by items_projet_INDEX desc"
        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            Me.RadGridViewItems.DataSource = reader
            cpt = RadGridViewItems.Rows.Count
            connection.Close()
        End If
        If cpt > 0 Then
            Dim col As Integer = RadGridViewItems.Columns.Count - 1
            For i = 0 To col 'nombre collones
                Select Case i
                    Case 13
                        RadGridViewItems.Columns(i).Width = 75
                    Case 6, 7, 8, 10, 12, 15
                        RadGridViewItems.Columns(i).Width = 70
                    Case 2, 16
                        RadGridViewItems.Columns(i).Width = 100
                    Case 3
                        RadGridViewItems.Columns(i).Width = 160
                    Case 0, 1, 4, 5, 9, 11, 14, 16, 17
                        RadGridViewItems.Columns(i).Width = 65
                End Select
                ListBoxItemsParent.Items.Add(Str(i) + " " + RadGridViewItems.Columns(i).Name)
            Next i
            RadGridViewItems.Columns(0).HeaderText = "IDX"
            RadGridViewItems.Columns(0).HeaderText = "Num"
            RadGridViewItems.Columns(1).HeaderText = "Parent ID"
            RadGridViewItems.Columns(2).HeaderText = "Famille"
            RadGridViewItems.Columns(3).HeaderText = "Nom"
            RadGridViewItems.Columns(4).HeaderText = "Parent"
            RadGridViewItems.Columns(5).HeaderText = "Qté"
            RadGridViewItems.Columns(6).HeaderText = "Quantité"
            RadGridViewItems.Columns(7).HeaderText = "Taux TVA"
            RadGridViewItems.Columns(8).HeaderText = "Mt Total"
            RadGridViewItems.Columns(9).HeaderText = "EURO/$"
            RadGridViewItems.Columns(10).HeaderText = "Date"
            RadGridViewItems.Columns(11).HeaderText = "Projet"
            RadGridViewItems.Columns(12).HeaderText = "Grand TOTAL"
            RadGridViewItems.Columns(13).HeaderText = "PAIEMENT"
            RadGridViewItems.Columns(14).HeaderText = "O/N"
            RadGridViewItems.Columns(15).HeaderText = "Mt. Payé"
            RadGridViewItems.Columns(16).HeaderText = "Payer à"
            RadGridViewItems.Columns(17).HeaderText = "FF"

            RadGridViewItems.Columns(0).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(1).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(4).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(5).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(7).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(9).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(13).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(14).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(16).TextAlignment = ContentAlignment.MiddleCenter
            RadGridViewItems.Columns(17).TextAlignment = ContentAlignment.MiddleCenter

            FillItems_root()
            calculTotalLine(0) 'affiche le total
            'calcul_Datagridview_Items()
        End If
    End Sub
    Private Sub MenuPrincipalClickHandler_name(ByVal sender As Object, ByVal e As System.EventArgs)
        Exit Sub
        Dim CodeName As Label = CType(sender, Label)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)
        IndexMenuPrincipalClicked = Val(CodeName.Name)
        ProjectIndexGlobal = Val(ArrayItemsCODE(indexPictureBox).Text)
        RadLabelElementMessage.Text = "Label " + ArrayItemsCODE(IndexMenuPrincipalClicked).Text + " " + Str(IndexMenuPrincipalClicked)
        display_ProjectName_Flash(ArrayItemsCODE(IndexMenuPrincipalClicked).Text, "Project")
        'FindItemsSql(IndexMenuPrincipalClicked)
        FindItemsSql(ProjectIndexGlobal)
    End Sub
    Private Sub MenuPrincipalClickHandler_code(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim CodeName As Label = CType(sender, Label)
        'Dim picb As PictureBox = CType(sender, PictureBox)
        'Dim indexPictureBox = Val(picb.Name)
        IndexMenuPrincipalClicked = Val(CodeName.Name)
        ProjectIndexGlobal = Val(CodeName.Name)
        RadLabelElementMessage.Text = "Label " + CType(sender, Label).Text + " " + Str(IndexMenuPrincipalClicked)
        display_ProjectName_Flash(CodeName.Text, "Project")
        'FindItemsSql(IndexMenuPrincipalClicked)
        FindItemsSql(ProjectIndexGlobal)
    End Sub
    Private Sub MenuPrincipalClickHandler_picture(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)
        'sender.image = ImgPoubelleEnter(indexPictureBox)
        IndexMenuPrincipalClicked = indexPictureBox + 1
        ProjectIndexGlobal = Val(ArrayItemsCODE(indexPictureBox).Text)
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(IndexMenuPrincipalClicked) + ArrayItemsCODE(indexPictureBox).Text
        display_ProjectName_Flash(ArrayItemsCODE(indexPictureBox).Text, "Project")
        'FindItemsSql(IndexMenuPrincipalClicked)
        FindItemsSql(ProjectIndexGlobal)
    End Sub
    Private Sub PictureBoxMouseHoverHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)

        sender.image = ImgPoubelleEnter(indexPictureBox)
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(IndexMenuPrincipalClicked)
    End Sub
    Private Sub PictureBoxMouseLeaveHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)

        sender.image = ImgPoubelleLeave(indexPictureBox)
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(IndexClicked)
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



    Private Sub FillProjectList_to_groupBox()
        Dim cpt As Integer = 0
        Dim local_tableName As String
        local_tableName = "PROJECT"
        Dim ds As New DataSet
        Dim mysql As String
        mysql = "SELECT * FROM " + local_tableName + " ORDER BY PROJECT_CODE"
        Dim con As New OleDb.OleDbConnection
        Dim nombre As Long
        Dim connection As New MySqlConnection(GlobalProviderForIDM)
        Dim cmd As New MySqlCommand(mysql, connection)
        Dim iindex As Integer
        con.ConnectionString = GlobalProvider
        If IDMorAccess = "IDM" Then

            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            dtProject.Load(reader)
            cpt = dtProject.Rows.Count
            connection.Close()
        End If
        'cmd = New OleDb.OleDbCommand(mysql, con)
        cmd.Connection.Open()
        nombre = dtProject.Rows.Count
        Dim ProjectName As String
        If nombre > 0 Then
            For i = 0 To nombre - 1
                'iindex = ds.Tables(local_tableName).Rows(i).Item("PROJECT_INDEX")
                iindex = dtProject.Rows(i).Item("PROJECT_INDEX")
                ProjectName = dtProject.Rows(i).Item("PROJECT_NAME").ToString
                'resultat = ds.Tables(local_tableName).Rows(i).Item("PROJECT_CODE")
                ArrayItemsCODE(i).Text = Str(iindex)
                ArrayItemsName(i).Text = ProjectName
                If 1 = 2 Then
                    Select Case i
                        Case 0
                            ArrayItemsCODE(i).Text = "1"
                            ArrayItemsName(i).Text = "PANDA1"
                        Case 1
                            ArrayItemsCODE(i).Text = "2"
                            ArrayItemsName(i).Text = "PANDA2"
                        Case 2
                            ArrayItemsCODE(i).Text = "3"
                            ArrayItemsName(i).Text = "PANDA3"
                        Case 3
                            ArrayItemsCODE(i).Text = "4"
                            ArrayItemsName(i).Text = "PANDA4"
                        Case 4
                            ArrayItemsCODE(i).Text = "5"
                            ArrayItemsName(i).Text = "PANDA5"
                    End Select
                End If
                'ArrayItemsCODE(i).Text = resultat
                'ArrayItemsName(i).Text = ds.Tables(local_tableName).Rows(i).Item("PROJECT_NAME")
            Next i
        End If
    End Sub

    Private Sub ButtonGridviewUpdate_Click(sender As Object, e As EventArgs) Handles ButtonGridviewUpdate.Click
        Dim irow As Integer = -1

        'RadTextBox_INDEX.Text = ""
        'RadTextBox_ITEMS_INDEX.Text = ""
        'RadTextBoxITEMS_CODE.Text = ""
        'RadTextBoxITEMS_NAME.Text = ""
        'RadTextBoxITEMS_PARENT.Text = ""
        'RadTextBoxITEMS_QUANTITY.Text = ""
        'RadTextBoxITEMS_UNIT.Text = ""
        'RadTextBoxITEMS_TAXT.Text = ""
        'RadTextBoxITEMS_TAXE_VALUE.Text = ""
        'RadTextBoxITEMS_CURRENCY.Text = ""
        'RadTextBoxITEMS_LAST_EDIT_DATE.Text = ""
        'RadTextBox_MTTVA.Text = ""
        Dim iindex As Integer = Val(RadTextBox_INDEX.Text)
        If iindex < 1 Then
            RadLabelElementMessage.Text = "Erreur, le code INDEX est erroné"
            Exit Sub
        End If

        Dim DateFacture As String

        Dim dyear = Mid(RadTextBoxITEMS_LAST_EDIT_DATE.Text, 7, 4)
        Dim dmonth = Mid(RadTextBoxITEMS_LAST_EDIT_DATE.Text, 4, 2)
        Dim dday = Mid(RadTextBoxITEMS_LAST_EDIT_DATE.Text, 1, 2)
        DateFacture = "'" + dyear + "/" + dmonth + "/" + dday + "'"
        Dim mot As String() = RadTextBoxITEMS_TAXE.Text.Split(New Char() {"%"c})
        Dim TauxTVA = "0"
        If mot.Count > 0 Then
            TauxTVA = mot(0).ToString
        End If

        Dim mysql = "Update items SET ITEMS_INDEX = " + RadTextBox_ITEMS_INDEX.Text
        '      mysql += ", items_projet_INDEX = " + RadTextBox_ITEMS_INDEX.Text
        mysql += ", ITEMS_CODE = '" + RadTextBoxITEMS_CODE.Text + "'"
        mysql += ", ITEMS_NAME = '" + RadTextBoxITEMS_NAME.Text + "'"
        mysql += ", ITEMS_PARENT = '" + RadTextBoxITEMS_PARENT.Text + "'"
        mysql += ", ITEMS_QUANTITY = " + RadTextBoxITEMS_QUANTITY.Text
        mysql += ", ITEMS_UNIT = " + RadTextBoxITEMS_UNIT.Text
        mysql += ", ITEMS_TAXE = " + mot(0).ToString
        mysql += ", ITEMS_TAXE_VALUE = " + RadTextBoxITEMS_TAXE_VALUE.Text
        mysql += ", ITEMS_CURRENCY = '" + RadTextBoxITEMS_CURRENCY.Text + "'"
        mysql += ", ITEMS_LAST_EDIT_DATE = " + DateFacture
        mysql += " Where `INDEX` = " + iindex.ToString

        RadLabelElementMessage.Text = mysql
        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            'Me.RadGridViewProjectName.DataSource = reader
            'cpt = RadGridViewProjectName.Rows.Count
            connection.Close()
            FindItemsSql(ProjectIndexGlobal)
        End If
        Exit Sub
        UpdateGridInfo(Me.RadGridViewItems.CurrentRow, irow)

        Try
            '@@@@@TOTOTO  Me.ITEMSTableAdapter.Update(Me.TAKEOFDataSet.ITEMS)

        Catch ex As Exception
        End Try
    End Sub
    Private Function ConvertDateMysql(ByVal DateOrigine As Date) As String
        Dim ConvertedDate As String '= "#10/15/2022#"
        Dim dyear = DateOrigine.ToString("yyyy")
        Dim dmonth = DateOrigine.ToString("MM")
        Dim dday = DateOrigine.ToString("dd")
        ConvertedDate = "#" + dmonth + "/" + dday + "/" + dyear + "#"
        Return ConvertedDate
    End Function

    Private Function ConvertDateMysql4(ByVal DateOrigine As Date) As String
        Dim ConvertedDate As String '= '2022/11/30'
        Dim dyear = DateOrigine.ToString("yyyy")
        Dim dmonth = DateOrigine.ToString("MM")
        Dim dday = DateOrigine.ToString("dd")
        ConvertedDate = dyear + "-" + dmonth + "-" + dday
        Return ConvertedDate
    End Function
    Private Sub UpdateGridInfo(ByVal currentRow As GridViewRowInfo, ByRef iindex As Integer)
        Dim mysql As String
        Dim basename As String = "ITEMS"
        mysql = "Update ITEMS SET items_INDEX=" + RadTextBox_ITEMS_INDEX.Text
        mysql += ", items_code= '" + RadTextBoxITEMS_CODE.Text
        mysql += "', items_parent ='" + RadTextBoxITEMS_PARENT.Text
        mysql += "', items_quantity= " + RadTextBoxITEMS_QUANTITY.Text
        mysql += ", items_unit= " + RadTextBoxITEMS_UNIT.Text
        mysql += ", items_price_total =" + RadTextBoxITEMS_TAXE_VALUE.Text
        mysql += ", items_parent ='" + RadTextBoxITEMS_NAME.Text
        mysql += "', items_taxe_value= " + RadTextBoxITEMS_TAXE_VALUE.Text
        mysql += ", items_taxe= =" + RadTextBoxITEMS_TAXE_VALUE.Text
        mysql += ", items_name= '" + RadTextBoxITEMS_NAME.Text + "' where items_INDEX = " + RadTextBox_ITEMS_INDEX.Text
        RadLabelElementMessage.Text = mysql
    End Sub
    Private Sub Items_Creat_Root(ByVal currentRow As GridViewRowInfo, ByVal irow As Integer)
        Exit Sub
        Dim i As Integer = 0
        Dim ArrayList As ArrayList
        ArrayList = New ArrayList
        Dim numcolumn As Integer = RadGridViewItems.Columns.Count

        For i = 0 To numcolumn - 1
            ArrayList.Add(currentRow.Cells(i).Value)
        Next
        next_index += 1
        ArrayList(0) = next_index
        ArrayList(1) = FindLastItemCount() + 2
        'ArrayList(4) = ArrayList(5)
        'ArrayList(3) = ArrayList(5)
        ArrayList(2) = "__ROOT"
        ArrayCurrentItems.Add(ArrayList(1))
        RadGridViewItems.Rows.Add(ArrayList.ToArray)
    End Sub
    Private Function FindLastItemCount()

        Dim i As Integer = 0
        Dim local_tableName As String
        local_tableName = "ITEMS"
        Dim resultat As String = ""
        Dim iindex As Integer
        Dim ds As New DataSet
        Dim mysql As String
        Dim FF As Boolean
        FF = RadCheckBoxFF.Checked
        If FF Then
            mysql = "SELECT * FROM " + local_tableName + " ORDER BY ITEMS_INDEX "
        Else
            mysql = "SELECT * FROM " + local_tableName + " where items_ff = 'N' ORDER BY ITEMS_INDEX "
        End If
        Dim con As New OleDb.OleDbConnection
        Dim nombre As Long
        con.ConnectionString = GlobalProvider
        Dim cmd As OleDb.OleDbCommand
        cmd = New OleDb.OleDbCommand(mysql, con)
        cmd.Connection.Open()
        Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter With {
            .SelectCommand = cmd
        }
        da.Fill(ds, local_tableName)
        nombre = ds.Tables(local_tableName).Rows.Count - 1
        If nombre > 0 Then
            iindex = ds.Tables(local_tableName).Rows(nombre).Item("ITEMS_INDEX")
        End If
        'nombre = ds.Tables(local_tableName).Rows.Count
        Return iindex
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
    Private Sub ButtonGridviewDelete_Click(sender As Object, e As EventArgs) Handles ButtonGridviewDelete.Click
        Dim iindex As Integer = Val(RadTextBox_INDEX.Text)
        If iindex < 1 Then
            RadLabelElementMessage.Text = "Erreur, le code INDEX est erroné"
            Exit Sub
        End If
        Dim mysql As String
        Dim basename As String = "items"
        mysql = "DELETE FROM " + basename + " where `INDEX` = " + RadTextBox_INDEX.Text
        RadLabelElementMessage.Text = mysql
        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            'Me.RadGridViewProjectName.DataSource = reader
            'cpt = RadGridViewProjectName.Rows.Count
            connection.Close()
            FindItemsSql(ProjectIndexGlobal)
        End If
        Exit Sub

        UpdateGridInfo(Me.RadGridViewItems.CurrentRow, iindex)

        Try
            '@@@@@TOTOTO  Me.ITEMSTableAdapter.DeleteQuery(iindex)
            Me.RadGridViewItems.CurrentRow.Delete()
            'UpdateGridInfo(Me.RadGridViewItems.CurrentRow, irow)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub insert_Items()
        Dim i = 0
        i = i
        'RadTextBox_INDEX.Text = ""
        RadTextBox_ITEMS_INDEX.Text = Str(FindLastItemCount())
        RadTextBoxITEMS_CODE.Text = "" 'Str(FindLastItemCount())
        RadTextBoxITEMS_NAME.Text = ""
        RadTextBoxITEMS_PARENT.Text = "_ROOT"
        RadTextBoxITEMS_QUANTITY.Text = "1"
        RadTextBoxITEMS_UNIT.Text = "0"
        RadTextBoxITEMS_TAXE.Text = "20%"
        RadTextBoxITEMS_TAXE_VALUE.Text = "0"
        RadTextBoxITEMS_CURRENCY.Text = "EURO"
        RadTextBoxITEMS_LAST_EDIT_DATE.Text = Today.ToString
        RadTextBox_MTTVA.Text = ""
        RadTextBoxITEMS_DatePaiement.Text = Today.ToString
        RadTextBoxITEMS_PayeQui.Text = "N"
        RadTextBoxITEMS_MT_PAIEMENT.Text = ""
        RadTextBoxITEMS_PAYE_QUI.Text = "CIC"
    End Sub
    Private Sub ButtonGridviewNew_Click(sender As Object, e As EventArgs) Handles ButtonGridviewNew.Click
        '        RadDataLayout1 = New RadDataLayout
        'insert_Items()
        InsertItemToDataBase(0)
        FindItemsSql(ProjectIndexGlobal)
        Exit Sub
        Dim iindex As Integer = 0
        RadGridViewItems.Rows.AddNew()
        iindex = FindLastItemCount() + 1
        next_index += next_index
    End Sub

    Private Sub InsertItemToDataBase(ByVal Items_Index As Integer)

        Dim mysql As String
        Dim basename As String = "cic"
        'Dim ddate As String = OOClassBanque.Banque_Date.ToString("yyyy/MM/dd")
        RadTextBox_ITEMS_INDEX.Text = Str(FindLastItemCount())
        'RadTextBoxITEMS_CODE.Text = "" 'Str(FindLastItemCount())
        'RadTextBoxITEMS_NAME.Text = ""


        'RadTextBox_ITEMS_INDEX.Text = Str(FindLastItemCount())
        'RadTextBoxITEMS_CODE.Text = "" 'Str(FindLastItemCount())
        'RadTextBoxITEMS_NAME.Text = ""
        'RadTextBoxITEMS_PARENT.Text = "_ROOT"
        'RadTextBoxITEMS_QUANTITY.Text = "1"
        'RadTextBoxITEMS_UNIT.Text = "0"
        'RadTextBoxITEMS_TAXE.Text = "20%"
        'RadTextBoxITEMS_TAXE_VALUE.Text = "0"
        'RadTextBoxITEMS_CURRENCY.Text = "EURO"
        'RadTextBoxITEMS_LAST_EDIT_DATE.Text = Today.ToString
        'RadTextBox_MTTVA.Text = ""
        'RadTextBoxITEMS_DatePaiement.Text = Today.ToString
        'RadTextBoxITEMS_PayeQui.Text = "N"
        'RadTextBoxITEMS_MT_PAIEMENT.Text = ""
        'RadTextBoxITEMS_PAYE_QUI.Text = "CIC"
        Dim Date1, Date2 As String
        Date1 = ConvertDateMysql4(RadTextBoxITEMS_LAST_EDIT_DATE.Text)
        Date2 = ConvertDateMysql4(RadTextBoxITEMS_DatePaiement.Text)
        Dim ValueString As String
        ValueString = RadTextBox_ITEMS_INDEX.Text + "," + ProjectIndexGlobal.ToString + ",'"
        ValueString += RadTextBoxITEMS_CODE.Text + "','"
        ValueString += RadTextBoxITEMS_NAME.Text + "','"
        ValueString += RadTextBoxITEMS_PARENT.Text + "',"
        ValueString += RadTextBoxITEMS_QUANTITY.Text + ","
        ValueString += RadTextBoxITEMS_UNIT.Text + ","
        ValueString += RadTextBoxITEMS_TAXE.Text + ","
        ValueString += RadTextBoxITEMS_TAXE_VALUE.Text + ",'"
        ValueString += RadTextBoxITEMS_CURRENCY.Text + "','"
        ValueString += Date1 + "','" 'RadTextBoxITEMS_LAST_EDIT_DATE.Text + "','"
        ValueString += Date2 + "','" 'RadTextBoxITEMS_DatePaiement.Text + "','"
        ValueString += RadTextBoxITEMS_PayeQui.Text + "','"
        ValueString += RadTextBoxITEMS_PAYE_QUI.Text + "',"
        ValueString += RadTextBoxITEMS_MT_PAIEMENT.Text

        mysql = "insert into items (items_index,items_projet_INDEX,ITEMS_CODE,ITEMS_NAME,ITEMS_PARENT,ITEMS_QUANTITY,ITEMS_UNIT,ITEMS_TAXE,"
        mysql += "ITEMS_TAXE_VALUE,ITEMS_CURRENCY,ITEMS_LAST_EDIT_DATE,items_date_paiement,items_paiement_ok,items_paye_qui,items_mt_payé) "
        mysql += "values( " + ValueString + ")"
        'mysql += "values( 28,1,'VELO','VELOELECT','_ROOT',90,91,92,93,'EURO','1900-01-01','1900-02-02','N','JP',95)"

        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)

            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            connection.Close()
        End If

    End Sub


    Private Sub ButtonGridviewNewProjectMainForm_Click(sender As Object, e As EventArgs)
        Dim iindex As Integer = 0
        '@@@@@TOTO RadDateTimePickerDateCreat.Value = Today.ToShortDateString
        '@@@@@TOTO RadDateTimePickerDateCreat.Value = Today.ToShortDateString
        '@@@@@TOTO RadDateTimePickerDateCreat.Value = Today.ToShortDateString
        'RadTextBoxItemsCode.Text = "Code Name" 'ArrayCurrentItems(const_Category)
        'RadTextBoxParent_Items.Text = ArrayCurrentItems(const_Category)
        'RadSpinEditorVATPorucent.Value = ArrayCurrentItems(const_VAT_Porucent)
        iindex = FindLastProjectCount() + 1
    End Sub

    Private Sub RadTextBox2999_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonGridviewDeleteProjectMainForm_Click(sender As Object, e As EventArgs)
        Dim iindex As Integer = -1

        Try
            '@@@@@TOTOTO  Me.PROJECTTableAdapter.DeleteQuery(iindex)
            'UpdateGridInfo(Me.RadGridViewItems.CurrentRow, irow)
        Catch ex As Exception
        End Try
    End Sub
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

        RadLabelElementMessage.Text = ""
        Dim newRowInfo As GridViewNewRowInfo = TryCast(currentRow, GridViewNewRowInfo)
        If newRowInfo IsNot Nothing Then
            currentRow.InvalidateRow()
        Else
        End If
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

    Private Sub RadButtonGroupage_Click(sender As Object, e As EventArgs) Handles RadButtonGroupage.Click
        RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT;ITEMS_CODE"
        RadGridViewItems.MasterTemplate.CollapseAllGroups()
    End Sub

    Private Function GetQuarter([date] As DateTime) As String
        If [date].Month >= 0 AndAlso [date].Month <= 3 Then
            Return "Q1"
        ElseIf [date].Month >= 4 AndAlso [date].Month <= 6 Then
            Return "Q2"
        ElseIf [date].Month >= 7 AndAlso [date].Month <= 9 Then
            Return "Q3"
        Else
            Return "Q4"
        End If
    End Function
    Private Sub radGridView1_GroupSummaryEvaluate(sender As Object, e As GroupSummaryEvaluationEventArgs)
        If e.Value Is Nothing Then
            e.FormatString = e.Group.Key.ToString()
            RadLabelElementMessage.Text = e.FormatString + " " + Now.ToLongTimeString
        End If
        RadLabelElementMessage.Text = RadLabelElementMessage.Text + "/" + e.Value
    End Sub
    Private Sub RadGridViewItems_GroupSummaryEvaluate(ByVal sender As Object, ByVal e As GroupSummaryEvaluationEventArgs)


        Dim ItemsCount As Integer = e.Group.ItemCount
        If ItemsCount <= 0 Then
            RadLabelElementMessage.Text = "Groupe vide"
            Exit Sub
        End If
        'ListBox1.Items.Clear()

        Dim temp

        'temp = e.Group.GroupRow.Index
        Try
            temp = e.Group.Key(0).ToString
            'temp = e.Group.Item(e.Group.GroupRow.Index).ToString
            ListBoxItemsParent.Items.Add(temp + Now.ToLongTimeString)
        Catch ex As Exception
            RadLabelElementMessage.Text = "erreur" + ex.Message
            Exit Sub
        End Try

        'If e.SummaryItem.Name = "ITEMS_PARENT" Then

        Dim TotalGroup As Integer = 0
        For Each row As GridViewRowInfo In e.Group
            'If row.Cells("ITEMS_PARENT").Value.ToString() = "GARDEN" Then
            'If row.Cells("ITEMS_PARENT").Value.ToString() = "GARDEN" Then 'items_price_total
            TotalGroup += row.Cells("items_price_total").Value
            '                End If
            ListBoxItemsParent.Items.Add([String].Format("{0} a {1} Items, valeur : {2} ", e.Value, ItemsCount, Format(TotalGroup, "0€")))
        Next
        e.FormatString = [String].Format("{0} a {1} Items, valeur : {2} ", e.Value, ItemsCount, Format(TotalGroup, "0€"))
        'e.Group(0).IsExpanded = True
        'Me.RadGridViewItems.Groups(0).Expand()
        'Else
        'RadLabelElementMessage.Text = "No Parent " + e.FormatString + Str(ItemsCount) + "Summ : " + e.SummaryItem.Name
        'End If
        RadLabelElementMessage.Text = e.FormatString + Str(ItemsCount) + "Summ : " + e.SummaryItem.Name
        'https://docs.telerik.com/devtools/winforms/controls/gridview/grouping/custom-grouping
    End Sub


    Private Sub RadButton1_Click_2(sender As Object, e As EventArgs) Handles RadButtonGroupCancel.Click
        RadGridViewItems.GroupDescriptors.Expression = ""
    End Sub
    Private Sub FindItemByCode(ByVal ItemCode As String, ByRef Items_Parent_Aarray As ArrayList)
        Dim ItemCount As Integer = 0
        Dim temp As String
        Dim findit As Boolean = False
        If IsNothing(ItemCode) Then
            Exit Sub

        End If
        ListBoxItemsParent.Items.Clear()

        If ItemCode > "" Then
            Items_Parent_Aarray = New ArrayList
            '@@@@@TOTOTO  Me.ITEMSTableAdapter1.FillByByCode(Me.TAKEOFFDataSet3.ITEMS, "%" + ItemCode + "%")

            'Me.ITEMSTableAdapter.FindItemByCode(Me.TAKEOFDataSet.ITEMS, ItemCode)
            'ItemCount = Me.TAKEOFFDataSet3.ITEMS.Count
            'If ItemCount > 0 Then
            '    For i = 0 To ItemCount - 1
            '        findit = False
            '        temp = Me.TAKEOFFDataSet3.Tables(0).Rows(i).Item("ITEMS_PARENT")
            '        For Each Elements As String In Items_Parent_Aarray
            '            If Elements = temp Then
            '                findit = True
            '                Exit For
            '            End If
            '        Next
            '        If findit = False Then
            '            Items_Parent_Aarray.Add(temp)
            '            ListBoxItemsParent.Items.Add(temp)
            '        End If
            '    Next i
            'End If
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxItemsParent.Click

    End Sub

    Private Sub ListBoxItemsParent_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxItemsParent.Click
        Dim iindex As Integer = 0
        iindex = ListBoxItemsParent.SelectedIndex
        If iindex >= 0 Then
            Dim temp As String = ""
            temp = ListBoxItemsParent.Items(iindex)
        End If
    End Sub

    Private Sub RadListViewNextPatients_SelectedItemChanged(sender As Object, e As EventArgs) Handles RadListeiewProjectName.SelectedItemChanged
        Dim iindex As Integer
        iindex = RadListeiewProjectName.SelectedIndex
        Dim temp
        temp = RadListeiewProjectName.Items(0).Value
        '@@@@@TOTOTO  Me.ITEMSTableAdapter.PorjectOne(Me.TAKEOFDataSet.ITEMS, iindex)
        iindex = iindex
        'calcul_Datagridview_Items()
    End Sub

    Private Sub RadButtonGroupageRefhesh_Click(sender As Object, e As EventArgs) Handles RadButtonGroupageRefhesh.Click
        RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT;ITEMS_CODE"
        RadGridViewItems.MasterTemplate.ExpandAll()
    End Sub

    Private Sub RadButton1_Click_3(sender As Object, e As EventArgs) Handles RadButtonItemsLevelOne.Click
        RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT"
        RadGridViewItems.MasterTemplate.ExpandAll()
    End Sub

    Private Function FindProjectListe() As Integer
        Dim mysql As String
        Dim cpt As Integer
        Dim basename As String = "project"
        mysql = "SELECT *  FROM " + basename + " order by project_INDEX desc"
        dtProject = New DataTable()
        If IDMorAccess = "IDM" Then
            Dim connection As New MySqlConnection(GlobalProviderForIDM)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            dtProject.Load(reader)
            cpt = dtProject.Rows.Count
            connection.Close()
        End If
        RadLabelElementMessage.Text = "Nombre de projets" + Str(cpt)
        Return cpt
    End Function
    Private Sub CheckedListBoxTypeCharge_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxTypeCharge.SelectedIndexChanged
        Dim ok As Integer
        ok = CheckedListBoxTypeCharge.SelectedIndex
        If ok < 0 Then
            ok = 0
        End If
        Global_Type_Charge = UCase(CheckedListBoxTypeCharge.Items(ok))
        Dim Nombre = CheckedListBoxTypeCharge.Items.Count - 1
        For i = 0 To Nombre
            If ok <> i Then
                CheckedListBoxTypeCharge.SetItemChecked(i, False)
            End If
        Next
    End Sub
End Class