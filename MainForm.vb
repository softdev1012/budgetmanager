Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Public Class MainForm
    Public ProjectIndexGlobal As Integer = 0
    Public Global_Type_Charge As String = "ALL"
    'Public IndexMenuPrincipalClicked As Integer = 0
    Dim ArrayPictureLogo(10) As PictureBox
    Dim ArrayItemsCODE(10) As Label
    Dim ArrayItemsName(10) As Label
    Dim ImgLogoItems = New Image() {
                        My.Resources.bussy_100,
                        My.Resources.Construction_100,
                        My.Resources.veranda_100,
                        My.Resources.ESTIMATOR_100
                        }
    Private NRow As Integer = 2
    Dim PictureBoxArray(NRow) As PictureBox
    Dim imageArrayMainMenuLocation = {40, 110, 760} 'ecart 45
    Dim ImgPoubelleEnter = New Image() {
                        My.Resources.home_White_100x100,
                        My.Resources.settings_icon_128_white,
                        My.Resources.close_White_100x100
                        }
    Dim ImgPoubelleLeave = New Image() {
                        My.Resources.home_Gray_Clair_100x100,
                        My.Resources.settings_icon_128_Gray_Clair,
                        My.Resources.close_Gray_Clair_100x100
                        }
    Private BackColorGray = Color.FromArgb(46, 64, 62)
    Dim IndexClicked As Integer = 0

    Private dtProject As DataTable = New DataTable()

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DateTimePicker Formatation...
        RadDateTimePickerMonth.DateTimePickerElement.Calendar.HeaderNavigationMode = HeaderNavigationMode.Zoom
        RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Months
        AddHandler Me.RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomChanging, AddressOf Calendar_ZoomChanging
        '


        AddHandler RadGridViewItems.GroupSummaryEvaluate, AddressOf RadGridViewItems_GroupSummaryEvaluate

        CenterForm(Me)
        init_main_menu()
        GetProjectFromDB()
        InitProjectMenu()

        If dtProject.Rows.Count > 0 Then
            GetItemsFromDB(Val(dtProject.Rows(0).Item("PrOJECT_INDEX")))
        End If
        CheckedListBoxTypeCharge.SetItemChecked(0, True)
        Global_Type_Charge = CheckedListBoxTypeCharge.Items(0)
    End Sub

    Private Sub init_main_menu()
        For i = 0 To NRow
            PictureBoxArray(i) = New PictureBox
            PictureBoxArray(i).Name = Str(i)
            PictureBoxArray(i).BackColor = BackColorGray
            PictureBoxArray(i).Image = ImgPoubelleLeave(i)
            PictureBoxArray(i).SizeMode = PictureBoxSizeMode.StretchImage
            PictureBoxArray(i).Location = New Point(9, imageArrayMainMenuLocation(i))
            PictureBoxArray(i).Size = New Size(40, 40) '40,40
            PictureBoxArray(i).Visible = True
            PictureBoxArray(i).ContextMenuStrip = ContextMenuStrip
            GroupBoxMenuVertical.Controls.Add(PictureBoxArray(i))

            AddHandler PictureBoxArray(i).Click, AddressOf PictureBoxClickHandler
            AddHandler PictureBoxArray(i).MouseHover, AddressOf PictureBoxMouseHoverHandler
            AddHandler PictureBoxArray(i).MouseLeave, AddressOf PictureBoxMouseLeaveHandler
        Next
    End Sub
    Public Sub PictureBoxClickHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)
        sender.image = ImgPoubelleEnter(indexPictureBox)
        IndexClicked = indexPictureBox
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(IndexClicked)
        Select Case IndexClicked
            Case 0
                paneMain.Visible = True
            Case 1
                FormItemsDataEntry.Show()
                Me.Hide()
            Case Else
                c_fini()
        End Select
    End Sub

    Private Sub PictureBoxMouseHoverHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)
        sender.image = ImgPoubelleEnter(indexPictureBox)
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(indexPictureBox)
    End Sub
    Private Sub PictureBoxMouseLeaveHandler(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim indexPictureBox = Val(picb.Name)
        sender.image = ImgPoubelleLeave(indexPictureBox)
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(indexPictureBox)
    End Sub

    Private Sub c_fini()
        Me.Close()
    End Sub
    Private Sub display_ProjectCathegory_Flash(Name As String, titre As String)
        Try
            RadLabelGlobalCathegory.Text = "<html><p>" + titre + " : <b><span style=""font-size: medium"">" + Name + "</b><html>"
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
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
        Category = RadGridViewItems.CurrentRow.Cells(2).Value
        Dim ProjectName As String = ""
        Dim ProjectIDX = Val(RadGridViewItems.CurrentRow.Cells(11).Value)
        ProjectName = FindProjectName(ProjectIDX)
        DisplayProjectDetail()
        display_ProjectCathegory_Flash(Category, "Cathegory")
        display_ProjectName_Flash(ProjectName, "Project")
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
        Dim cnt As Integer = RadGridViewItems.Rows.Count - 1
        Dim CurrentCategory As String
        Dim tofindCategory = ""
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
        ListBoxItemsParent.Items.Clear()
        If RadGridViewItems.Rows.Count > iindex Then
            tofindCategory = RadGridViewItems.Rows(iindex).Cells(2).Value
        End If

        For i = 0 To cnt
            Dim MTPaye As String = ""
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
        RadGridViewClassItemsListe.DataSource = ClassItemsListe
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
        RadGridViewClassItemsListe.Columns(2).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(3).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(4).TextAlignment = ContentAlignment.MiddleCenter
        RadGridViewClassItemsListe.Columns(5).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(6).TextAlignment = ContentAlignment.MiddleRight
        RadGridViewClassItemsListe.Columns(7).TextAlignment = ContentAlignment.MiddleCenter


    End Sub
    Private Function FindProjectName(ByVal project_index As Integer)

        Dim i As Integer
        Dim cnt As Integer = dtProject.Rows.Count

        For i = 0 To cnt - 1
            If Val(dtProject.Rows(i).Item("PrOJECT_INDEX")) = project_index Then
                Return dtProject.Rows(i).Item("PrOJECT_NAME")
            End If
        Next
        Return ""
    End Function
    Private Sub InitProjectMenu()
        Dim i As Integer = 0
        Dim nombre_project As Integer = dtProject.Rows.Count - 1
        For i = 0 To nombre_project
            Dim y As Integer = 5 + i * 67
            Dim imgIdx As Integer = i
            If imgIdx > 3 Then
                imgIdx = 3
            End If
            ArrayPictureLogo(i) = New PictureBox
            ArrayPictureLogo(i).Image = ImgLogoItems(imgIdx)
            ArrayPictureLogo(i).Name = Str(i)  'numero pour identifié le picturebox
            ArrayPictureLogo(i).SizeMode = PictureBoxSizeMode.StretchImage
            ArrayPictureLogo(i).Location = New Point(5, y)
            ArrayPictureLogo(i).Size = New Size(65, 65)

            Me.RadListeiewProjectName.Controls.Add(ArrayPictureLogo(i)) 'RadPanelMenuItems
            AddHandler ArrayPictureLogo(i).Click, AddressOf MenuPrincipalClickHandler_picture

            '---------------------------------------
            ArrayItemsCODE(i) = New Label
            Me.ArrayItemsCODE(i).AutoSize = True
            Me.ArrayItemsCODE(i).Font = New System.Drawing.Font("Segoe UI Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ArrayItemsCODE(i).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ArrayItemsCODE(i).Location = New System.Drawing.Point(70, y + 5)
            Me.ArrayItemsCODE(i).Name = Str(i)
            Me.ArrayItemsCODE(i).Size = New System.Drawing.Size(84, 30)
            Me.ArrayItemsCODE(i).TabIndex = 2
            ArrayItemsCODE(i).Text = dtProject.Rows(i).Item("PROJECT_INDEX").ToString
            Me.RadListeiewProjectName.Controls.Add(ArrayItemsCODE(i)) 'RadPanelMenuItems
            AddHandler ArrayItemsCODE(i).Click, AddressOf MenuPrincipalClickHandler_code
            '---------------------------------------
            ArrayItemsName(i) = New Label
            Me.ArrayItemsName(i).AutoSize = True
            Me.ArrayItemsName(i).Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ArrayItemsName(i).ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.ArrayItemsName(i).Location = New System.Drawing.Point(72, y + 38)
            Me.ArrayItemsName(i).Name = Str(i)
            Me.ArrayItemsName(i).Size = New System.Drawing.Size(60, 25)
            Me.ArrayItemsName(i).TabIndex = 1
            ArrayItemsName(i).Text = dtProject.Rows(i).Item("PROJECT_NAME").ToString
            Me.RadListeiewProjectName.Controls.Add(ArrayItemsName(i)) 'RadPanelMenuItems
            AddHandler ArrayItemsName(i).Click, AddressOf MenuPrincipalClickHandler_name
        Next i
    End Sub
    Private Sub GetItemsFromDB(ByVal idx As Integer)
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
        Try
            Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            Me.RadGridViewItems.DataSource = reader
            cpt = RadGridViewItems.Rows.Count
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
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

        End If
        calculTotalLine(0) 'affiche le total
    End Sub
    Private Sub MenuPrincipalClickHandler_name(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim CodeName As Label = CType(sender, Label)
        Dim idx = Val(CodeName.Name)
        ProjectIndexGlobal = Val(ArrayItemsCODE(idx).Text)
        RadLabelElementMessage.Text = "Label " + ArrayItemsCODE(idx).Text + " " + Str(idx)
        display_ProjectName_Flash(CodeName.Text, "Project")
        GetItemsFromDB(ProjectIndexGlobal)
    End Sub
    Private Sub MenuPrincipalClickHandler_code(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim CodeName As Label = CType(sender, Label)
        Dim idx As Integer = Val(CodeName.Name)
        ProjectIndexGlobal = Val(CodeName.Text)
        RadLabelElementMessage.Text = "Label " + CType(sender, Label).Text + " " + Str(idx)
        display_ProjectName_Flash(ArrayItemsName(idx).Text, "Project")
        GetItemsFromDB(ProjectIndexGlobal)
    End Sub
    Private Sub MenuPrincipalClickHandler_picture(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim picb As PictureBox = CType(sender, PictureBox)
        Dim idx = Val(picb.Name)
        ProjectIndexGlobal = Val(ArrayItemsCODE(idx).Text)
        RadLabelElementMessage.Text = "Picture " + picb.Name + CType(sender, PictureBox).Text + " " + Str(idx + 1) + ArrayItemsCODE(idx).Text
        display_ProjectName_Flash(ArrayItemsName(idx).Text, "Project")
        GetItemsFromDB(ProjectIndexGlobal)
    End Sub

    Private Sub display_ProjectName_Flash(Name As String, titre As String)
        Try
            RadLabelProjectNameGlobal.Text = "<html><p>" + titre + " : <b><span style=""font-size: medium"">" + Name + "</b><html>"
        Catch ex As Exception
            Me.Text = ex.Message
        End Try
    End Sub


    Private Sub ButtonGridviewUpdate_Click(sender As Object, e As EventArgs) Handles ButtonGridviewUpdate.Click
        Dim irow As Integer = -1
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

        Try
            Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            'Me.RadGridViewProjectName.DataSource = reader
            'cpt = RadGridViewProjectName.Rows.Count
            connection.Close()
            GetItemsFromDB(ProjectIndexGlobal)
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
    End Sub

    Private Function ConvertDateMysql4(ByVal DateOrigine As Date) As String
        Dim ConvertedDate As String '= '2022/11/30'
        Dim dyear = DateOrigine.ToString("yyyy")
        Dim dmonth = DateOrigine.ToString("MM")
        Dim dday = DateOrigine.ToString("dd")
        ConvertedDate = dyear + "-" + dmonth + "-" + dday
        Return ConvertedDate
    End Function
    Private Function FindLastItemCount()
        Dim mysql As String
        mysql = "select MAX(ITEMS_INDEX) AS ITEMS_INDEX FROM items"
        Dim idx As Integer = 0
        Try
            Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            idx = Val(reader("ITEMS_INDEX"))
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
        Return idx
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

        Try
            Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            'Me.RadGridViewProjectName.DataSource = reader
            'cpt = RadGridViewProjectName.Rows.Count
            connection.Close()
            GetItemsFromDB(ProjectIndexGlobal)
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
    End Sub
    Private Sub ButtonGridviewNew_Click(sender As Object, e As EventArgs) Handles ButtonGridviewNew.Click
        '        RadDataLayout1 = New RadDataLayout
        InsertItemToDataBase(0)
        GetItemsFromDB(ProjectIndexGlobal)
        Exit Sub
        Dim iindex As Integer = 0
        RadGridViewItems.Rows.AddNew()
        iindex = FindLastItemCount() + 1
    End Sub

    Private Sub InsertItemToDataBase(ByVal Items_Index As Integer)

        Dim mysql As String
        Dim basename As String = "cic"
        RadTextBox_ITEMS_INDEX.Text = Str(FindLastItemCount())
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

        Try
            Dim connection As New MySqlConnection(GlobalProviderForLocalHost)

            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try

    End Sub
    Private Sub RadButtonGroupage_Click(sender As Object, e As EventArgs) Handles RadButtonGroupage.Click
        RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT;ITEMS_CODE"
        RadGridViewItems.MasterTemplate.CollapseAllGroups()
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

    Private Sub RadButtonGroupageRefhesh_Click(sender As Object, e As EventArgs) Handles RadButtonGroupageRefhesh.Click
        RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT;ITEMS_CODE"
        RadGridViewItems.MasterTemplate.ExpandAll()
    End Sub

    Private Function GetProjectFromDB() As Integer
        Dim mysql As String
        Dim cpt As Integer
        mysql = "SELECT *  FROM project Order by project_INDEX desc"
        Try
            Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
            Dim cmd As New MySqlCommand(mysql, connection)
            connection.Open()
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader()
            dtProject.Load(reader)
            cpt = dtProject.Rows.Count
            connection.Close()
        Catch ex As Exception
            RadLabelElementMessage.Text = ex.Message
        End Try
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
    Private Sub Calendar_ZoomChanging(sender As Object, e As CalendarZoomChangingEventArgs)
        If Me.RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Years AndAlso e.Direction = DrillDirection.Up Then
            e.Cancel = True
        End If
        If Me.RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Months AndAlso e.Direction = DrillDirection.Down Then
            e.Cancel = True
        End If
    End Sub
End Class