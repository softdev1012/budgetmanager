Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Export
Imports System.Drawing.Printing
Imports System.IO
Public Class MainForm
	Public ProjectIndexGlobal As Integer = 0
	Public Global_Type_Charge As String = "TOUS"
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
	Dim imageArrayMainMenuLocation = {40, 110, 850} 'ecart 45
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
	Private prtDoc As PrintDocument

	Private leftMargin As Integer
	Private rightMargin As Integer
	Private topMargin As Integer
	Private bottomMargin As Integer
	Private invoiceWidth As Integer
	Private invoiceHeight As Integer
	Private CurX As Integer
	Private CurY As Integer
	Private InvFontHeaderNormal As New Font("Segoe UI", 10, FontStyle.Regular)
	Private InvFontHeaderBold As New Font("Segoe UI", 10, FontStyle.Bold)
	Private InvFontTextNormal As New Font("Segoe UI", 8.25, FontStyle.Regular)
	Private InvFontTextBold As New Font("Segoe UI", 8.25, FontStyle.Bold)
	Private InvFontTextItalic As New Font("Segoe UI", 8.25, FontStyle.Italic)


	Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		'DateTimePicker Formatation...
		RadDateTimePickerMonth.DateTimePickerElement.Calendar.HeaderNavigationMode = HeaderNavigationMode.Zoom
		RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Months
		RadDateTimePickerMonth.DateTimePickerElement.TextBoxElement.Enabled = False
		RadDateTimePickerMonth.DateTimePickerElement.TextBoxElement.TextAlign = HorizontalAlignment.Center

		RadDateTimePickerITEMS_DatePaiement.DateTimePickerElement.TextBoxElement.TextAlign = HorizontalAlignment.Right
		RadDateTimePickerITEMS_LAST_EDIT_DATE.DateTimePickerElement.TextBoxElement.TextAlign = HorizontalAlignment.Right

		AddHandler Me.RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomChanging, AddressOf Calendar_ZoomChanging
		'DropDownList Setting
		RadDropDownITEMS_CURRENCY.DropDownListElement.TextBox.TextAlign = HorizontalAlignment.Right
		RadDropDownITEMS_CURRENCY.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
		RadDropDownITEMS_CURRENCY.SelectedIndex = 0

		RadDropDownITEMS_PayeQui.DropDownListElement.TextBox.TextAlign = HorizontalAlignment.Right
		RadDropDownITEMS_PayeQui.DropDownStyle = RadDropDownStyle.DropDownList
		RadDropDownITEMS_PayeQui.SelectedIndex = 1

		RadDropDownITEMS_FF.DropDownListElement.TextBox.TextAlign = HorizontalAlignment.Right
		RadDropDownITEMS_FF.DropDownStyle = RadDropDownStyle.DropDownList
		RadDropDownITEMS_FF.SelectedIndex = 1

		RadcmbTypeCharge.DropDownStyle = RadDropDownStyle.DropDownList


		AddHandler RadGridViewItems.GroupSummaryEvaluate, AddressOf RadGridViewItems_GroupSummaryEvaluate

		prtDoc = New PrintDocument
		AddHandler prtDoc.PrintPage, AddressOf prtDoc_PrintPage

		paneMain.Location = New Point(60, 0)
		paneMain.Visible = True

		paneSettings.Location = New Point(1700, 0)
		paneSettings.Visible = False

		CenterForm(Me)
		init_main_menu()
		GetProjectFromDB()
		InitProjectMenu()
		paneInvoice.Hide()

		If dtProject.Rows.Count > 0 Then
			ProjectIndexGlobal = Val(dtProject.Rows(0).Item("PrOJECT_INDEX"))
			GetItemsFromDB(ProjectIndexGlobal)
			RadSpinEditor_INDEX.Focus()
			display_ProjectName_Flash(FindProjectName(ProjectIndexGlobal), "Project")
		End If
		RadcmbTypeCharge.SelectedIndex = 0
		Global_Type_Charge = UCase(RadcmbTypeCharge.Items(0).Value)
	End Sub
	Private Function checkEarlyMonth()
		Dim mysql As String
		Dim curMonth As String = DateTime.Now.ToString("yyyy-MM")
		mysql = "SELECT COUNT(*) as cnt FROM items WHERE `items_month` = '" & curMonth & "'"
		Try
			Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
			Dim cmd As New MySqlCommand(mysql, connection)
			connection.Open()
			Dim reader As MySqlDataReader
			reader = cmd.ExecuteReader()
			Dim dt As DataTable = New DataTable()
			dt.Load(reader)
			If Val(dt.Rows(0).Item("cnt")) > 0 Then
				Return True
			End If
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
		Return False
	End Function
	Private Sub copyToNextMonth()
		Dim mysql As String
		Dim lastMonth As String = getLastDBMonth()
		Dim curMonth As String = DateTime.Now.ToString("yyyy-MM")
		mysql = "SELECT * FROM items WHERE `items_month` = '" & lastMonth & "'"
		Dim dtable As New DataTable()
		Dim cnt As Integer
		Try
			Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
			Dim cmd As New MySqlCommand(mysql, connection)
			connection.Open()
			Dim reader As MySqlDataReader
			reader = cmd.ExecuteReader()
			dtable.Load(reader)
			cnt = dtable.Rows.Count
			mysql = "INSERT INTO items(items_INDEX, items_projet_INDEX, items_code, items_name, items_parent, items_quantity, items_unit, items_price_total, items_taxe, items_taxe_value, items_currency, items_last_edit_date, Items_date_paiement, items_paiement_ok, `items_mt_payé`, items_paye_qui, items_ff, `items_month`) VALUES "
			For i = 0 To cnt - 1
				If i > 0 Then
					mysql += ","
				End If
				mysql += "('" & dtable.Rows(i).Item("items_INDEX") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_projet_INDEX") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_code") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_name") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_parent") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_quantity") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_unit") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_price_total") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_taxe") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_taxe_value") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_currency") & "',"
				mysql += "'" & ConvertDateMysql4(dtable.Rows(i).Item("items_last_edit_date")) & "',"
				mysql += "'" & ConvertDateMysql4(dtable.Rows(i).Item("Items_date_paiement")) & "',"
				mysql += "'" & dtable.Rows(i).Item("items_paiement_ok") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_mt_payé") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_paye_qui") & "',"
				mysql += "'" & dtable.Rows(i).Item("items_ff") & "',"
				mysql += "'" & curMonth & "')"
			Next
			cmd.CommandText = mysql
			cmd.ExecuteReader()
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
	End Sub

	Private Function getLastDBMonth()
		Dim mysql As String
		Dim rlt As String = "2022-01"
		mysql = "SELECT MAX(`items_month`) AS last_month FROM items"
		Try
			Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
			Dim cmd As New MySqlCommand(mysql, connection)
			connection.Open()
			Dim reader As MySqlDataReader
			reader = cmd.ExecuteReader()
			Dim dt As DataTable = New DataTable()
			dt.Load(reader)
			rlt = dt.Rows(0).Item("last_month")
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
		Return rlt
	End Function
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
				paneMain.Location = New Point(60, 0)
				paneMain.Visible = True

				paneSettings.Location = New Point(2000, 0)
				paneSettings.Visible = False
			Case 1
				paneSettings.Location = New Point(60, 0)
				paneSettings.Visible = True

				paneMain.Location = New Point(2000, 0)
				paneMain.Visible = False
				FindProjectListe()
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
			RadLabelElementMessage.Text = ex.Message
		End Try
	End Sub

	Private Sub RadGridViewItems_SelectionChanged(sender As Object, e As EventArgs) Handles RadGridViewItems.SelectionChanged
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
			RadLabelElementMessage.Text = ex.Message
		End Try
		Category = RadGridViewItems.CurrentRow.Cells(2).Value
		Dim ProjectName As String = ""
		Dim ProjectIDX = Val(RadGridViewItems.CurrentRow.Cells(11).Value)
		ProjectName = FindProjectName(ProjectIDX)
		DisplayProjectDetail()
		display_ProjectCathegory_Flash(Category, "Cathegory")
		display_ProjectName_Flash(ProjectName, "Project")
		calculTotalLine(RadGridViewItems.CurrentRow.Index)
		RadLabelElementMessage.Text = RadGridViewItems.CurrentRow.Cells(2).Value.ToString + " " + Str(RadGridViewItems.CurrentRow.Cells(1).Value)
	End Sub

	Private Sub RadGridViewItems_CommandCellClick(sender As Object, e As GridViewCellEventArgs) Handles RadGridViewItems.CellClick


	End Sub

	Private Sub DisplayProjectDetail()
		Dim col As Integer
		col = RadGridViewItems.Columns.Count
		For i = 0 To col - 1
			ListBoxItemsParent.Items.Add(RadGridViewItems.Columns(i).Name + " " + RadGridViewItems.CurrentRow.Cells(i).Value.ToString)
		Next
		RadSpinEditor_INDEX.Value = RadGridViewItems.CurrentRow.Cells(0).Value
		RadSpinEditor_ITEMS_INDEX.Value = RadGridViewItems.CurrentRow.Cells(1).Value
		RadTextBoxITEMS_CODE.Text = RadGridViewItems.CurrentRow.Cells(2).Value.ToString
		RadTextBoxITEMS_NAME.Text = RadGridViewItems.CurrentRow.Cells(3).Value.ToString
		RadTextBoxITEMS_PARENT.Text = RadGridViewItems.CurrentRow.Cells(4).Value.ToString
		RadSpinEditorITEMS_QUANTITY.Value = RadGridViewItems.CurrentRow.Cells(5).Value
		RadSpinEditorITEMS_UNIT.Value = RadGridViewItems.CurrentRow.Cells(6).Value
		RadSpinEditorITEMS_TAXE.Value = RadGridViewItems.CurrentRow.Cells(7).Value
		RadSpinEditorITEMS_TAXE_VALUE.Value = RadGridViewItems.CurrentRow.Cells(8).Value
		RadDropDownITEMS_CURRENCY.Text = RadGridViewItems.CurrentRow.Cells(9).Value.ToString
		RadDateTimePickerITEMS_LAST_EDIT_DATE.Value = Convert.ToDateTime(RadGridViewItems.CurrentRow.Cells(10).Value.ToString)
		RadSpinEditor_MTTVA.Value = RadGridViewItems.CurrentRow.Cells(12).Value
		RadDateTimePickerITEMS_DatePaiement.Value = Convert.ToDateTime(RadGridViewItems.CurrentRow.Cells(13).Value.ToString)
		RadDropDownITEMS_PayeQui.Text = RadGridViewItems.CurrentRow.Cells(14).Value.ToString
		RadSpinEditorITEMS_MT_PAIEMENT.Value = RadGridViewItems.CurrentRow.Cells(15).Value
		RadTextBoxITEMS_PAYE_QUI.Text = RadGridViewItems.CurrentRow.Cells(16).Value.ToString
		RadDropDownITEMS_FF.Text = RadGridViewItems.CurrentRow.Cells(17).Value.ToString
		RadSpinEditorITEMS_BIG_TOTAL.Value = RadSpinEditorITEMS_TAXE_VALUE.Value + RadSpinEditor_MTTVA.Value
		RadSpinEditor_INDEX.Focus()
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
						  .Index_Date = ConvertDateMysql4(RadDateTimePickerITEMS_LAST_EDIT_DATE.Value),
						  .Montant = RadGridViewItems.Rows(i).Cells(colTotal).Value.ToString,
						  .PayeOuiNon = RadGridViewItems.Rows(i).Cells(colFlagPaye).Value.ToString,
						  .Mt_Paye = MTPaye,
						  .AQui = Trim(RadGridViewItems.Rows(i).Cells(colPayeQui).Value.ToString),
						  .FF = Trim(RadGridViewItems.Rows(i).Cells(ColFF).Value.ToString)
				   })
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

		RadGridViewClassItemsListe.Columns(0).Width = 80
		RadGridViewClassItemsListe.Columns(1).Width = 220
		RadGridViewClassItemsListe.Columns(2).Width = 110
		RadGridViewClassItemsListe.Columns(3).Width = 80
		RadGridViewClassItemsListe.Columns(4).Width = 80
		RadGridViewClassItemsListe.Columns(5).Width = 80
		RadGridViewClassItemsListe.Columns(6).Width = 120
		RadGridViewClassItemsListe.Columns(7).Width = 80
		RadGridViewClassItemsListe.Columns(0).TextAlignment = ContentAlignment.MiddleCenter
		RadGridViewClassItemsListe.Columns(1).TextAlignment = ContentAlignment.MiddleLeft
		RadGridViewClassItemsListe.Columns(2).TextAlignment = ContentAlignment.MiddleCenter
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
			Case "TOUS"
				Critaire = ""
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
				Critaire = " and items_code = 'TAXE-IMPOTS' "
			Case "FRAIS BANCAIRES"
				Critaire = " and items_code = 'BANQUES' "
		End Select
		Dim FF As Boolean
		FF = RadCheckBoxFF.Checked
		Dim curMonth As String = RadDateTimePickerMonth.Text
		If FF Then
			mysql = "SELECT `INDEX`, `items_INDEX`, items_code, items_name, items_parent, items_quantity, items_unit, items_taxe, FORMAT(items_quantity * items_unit * (items_taxe/100.0), 2, 'fr_FR') AS items_mt_tva, items_currency, DATE_FORMAT(items_last_edit_date,'%Y-%m-%d') AS items_last_edit_date, items_projet_INDEX, FORMAT(items_quantity * items_unit * (1.0 + items_taxe/100.0), 2, 'fr_FR') AS items_big_total, DATE_FORMAT(items_date_paiement,'%Y-%m-%d') AS items_date_paiement, items_paiement_ok, items_mt_payé, items_paye_qui, items_ff FROM " + basename + " where items_projet_INDEX = " + Str(idx) + " AND `items_month` = '" + curMonth + "' " + Critaire + " order by items_paiement_ok, items_projet_INDEX desc"
		Else
			mysql = "SELECT `INDEX`, `items_INDEX`, items_code, items_name, items_parent, items_quantity, items_unit, items_taxe, FORMAT(items_quantity * items_unit * (items_taxe/100.0), 2, 'fr_FR') AS items_mt_tva, items_currency, DATE_FORMAT(items_last_edit_date,'%Y-%m-%d') AS items_last_edit_date, items_projet_INDEX, FORMAT(items_quantity * items_unit * (1.0 + items_taxe/100.0), 2, 'fr_FR') AS items_big_total, DATE_FORMAT(items_date_paiement,'%Y-%m-%d') AS items_date_paiement, items_paiement_ok, items_mt_payé, items_paye_qui, items_ff FROM " + basename + " where items_projet_INDEX = " + Str(idx) + " and items_ff = 'N' AND `items_month` = '" + curMonth + "' " + Critaire + " order by items_paiement_ok, items_projet_INDEX desc"
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
					Case 10, 13
						RadGridViewItems.Columns(i).Width = 85
					Case 6, 7, 8, 12, 15
						RadGridViewItems.Columns(i).Width = 80
					Case 2, 16
						RadGridViewItems.Columns(i).Width = 100
					Case 3
						RadGridViewItems.Columns(i).Width = 205
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
			RadGridViewItems.Columns(6).HeaderText = "Unit Price"
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
			RadGridViewItems.Columns(7).TextAlignment = ContentAlignment.MiddleRight
			RadGridViewItems.Columns(8).TextAlignment = ContentAlignment.MiddleRight
			RadGridViewItems.Columns(9).TextAlignment = ContentAlignment.MiddleCenter
			RadGridViewItems.Columns(10).TextAlignment = ContentAlignment.MiddleCenter
			RadGridViewItems.Columns(12).TextAlignment = ContentAlignment.MiddleRight
			RadGridViewItems.Columns(13).TextAlignment = ContentAlignment.MiddleCenter
			RadGridViewItems.Columns(14).TextAlignment = ContentAlignment.MiddleCenter
			RadGridViewItems.Columns(16).TextAlignment = ContentAlignment.MiddleCenter
			RadGridViewItems.Columns(17).TextAlignment = ContentAlignment.MiddleCenter

			display_ProjectCathegory_Flash(RadGridViewItems.Rows(0).Cells(2).Value, "Cathegory")
		Else
			display_ProjectCathegory_Flash("", "Cathegory")
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
			RadLabelElementMessage.Text = ex.Message
		End Try
	End Sub

	Private Sub RadButtonItemUpdate_Click(sender As Object, e As EventArgs) Handles RadButtonItemUpdate.Click
		Dim irow As Integer = -1
		Dim iindex As Integer = RadSpinEditor_INDEX.Value
		If iindex < 1 Then
			RadLabelElementMessage.Text = "Erreur, le code INDEX est erroné"
			Exit Sub
		End If
		Dim result As DialogResult = MessageBox.Show("Are you sure to update item info?", "Update Item", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then
			Exit Sub
		End If

		Dim mysql = "Update items SET ITEMS_INDEX = " + RadSpinEditor_ITEMS_INDEX.Value.ToString
		'      mysql += ", items_projet_INDEX = " + RadTextBox_ITEMS_INDEX.Text
		mysql += ", ITEMS_CODE = '" + RadTextBoxITEMS_CODE.Text + "'"
		mysql += ", ITEMS_NAME = '" + RadTextBoxITEMS_NAME.Text + "'"
		mysql += ", ITEMS_PARENT = '" + RadTextBoxITEMS_PARENT.Text + "'"
		mysql += ", ITEMS_QUANTITY = " + RadSpinEditorITEMS_QUANTITY.Value.ToString
		mysql += ", ITEMS_UNIT = " + RadSpinEditorITEMS_UNIT.Value.ToString
		mysql += ", ITEMS_TAXE = " + RadSpinEditorITEMS_TAXE.Value.ToString
		mysql += ", ITEMS_TAXE_VALUE = " + RadSpinEditorITEMS_TAXE_VALUE.Value.ToString
		mysql += ", ITEMS_CURRENCY = '" + RadDropDownITEMS_CURRENCY.Text + "'"
		mysql += ", ITEMS_LAST_EDIT_DATE = '" + ConvertDateMysql4(RadDateTimePickerITEMS_LAST_EDIT_DATE.Value) + "'"
		mysql += ", items_date_paiement = '" + ConvertDateMysql4(RadDateTimePickerITEMS_DatePaiement.Value) + "'"
		mysql += ", items_paiement_ok = '" + RadDropDownITEMS_PayeQui.Text + "'"
		mysql += ", items_mt_payé = " + RadSpinEditorITEMS_MT_PAIEMENT.Value.ToString
		mysql += ", items_paye_qui = '" + RadTextBoxITEMS_PAYE_QUI.Text + "'"
		mysql += ", items_ff = '" + RadDropDownITEMS_FF.Text + "'"

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
		Dim ConvertedDate = DateOrigine.ToString("yyyy-MM-dd")
		'Dim dyear = DateOrigine.ToString("yyyy")
		'Dim dmonth = DateOrigine.ToString("MM")
		'Dim dday = DateOrigine.ToString("dd")
		'ConvertedDate = dyear + "-" + dmonth + "-" + dday
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
			Dim dt As New DataTable()
			reader = cmd.ExecuteReader()
			dt.Load(reader)
			idx = Val(dt.Rows(0).Item("ITEMS_INDEX"))
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
		Return idx
	End Function

	Private Sub RadButtonItemDelete_Click(sender As Object, e As EventArgs) Handles RadButtonItemDelete.Click
		Dim iindex As Integer = RadSpinEditor_INDEX.Value
		If iindex < 1 Then
			RadLabelElementMessage.Text = "Erreur, le code INDEX est erroné"
			Exit Sub
		End If

		Dim result As DialogResult = MessageBox.Show("Are you sure to delete item?", "Delete Item", MessageBoxButtons.YesNo)
		If result = DialogResult.No Then
			Exit Sub
		End If

		Dim mysql As String
		Dim basename As String = "items"
		mysql = "DELETE FROM " + basename + " where `INDEX` = " + RadSpinEditor_INDEX.Value.ToString
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

	Private Sub RadButtonItemNew_Click(sender As Object, e As EventArgs) Handles RadButtonItemNew.Click
		'        RadDataLayout1 = New RadDataLayout
		Dim result As DialogResult = MessageBox.Show("Are you sure to create new item?", "Create Item", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			InsertItemToDataBase()
			GetItemsFromDB(ProjectIndexGlobal)
		End If
	End Sub

	Private Sub InsertItemToDataBase()

		Dim mysql As String
		RadSpinEditor_ITEMS_INDEX.Value = FindLastItemCount() + 1
		Dim Date1, Date2 As String
		Date1 = ConvertDateMysql4(RadDateTimePickerITEMS_LAST_EDIT_DATE.Value)
		Date2 = ConvertDateMysql4(RadDateTimePickerITEMS_DatePaiement.Value)
		Dim ValueString As String
		ValueString = RadSpinEditor_ITEMS_INDEX.Value.ToString + "," + ProjectIndexGlobal.ToString + ",'"
		ValueString += RadTextBoxITEMS_CODE.Text + "','"
		ValueString += RadTextBoxITEMS_NAME.Text + "','"
		ValueString += RadTextBoxITEMS_PARENT.Text + "',"
		ValueString += RadSpinEditorITEMS_QUANTITY.Value.ToString + ","
		ValueString += RadSpinEditorITEMS_UNIT.Value.ToString + ","
		ValueString += RadSpinEditorITEMS_TAXE.Value.ToString + ","
		ValueString += RadSpinEditorITEMS_TAXE_VALUE.Value.ToString + ",'"
		ValueString += RadDropDownITEMS_CURRENCY.Text + "','"
		ValueString += Date1 + "','" 'RadTextBoxITEMS_LAST_EDIT_DATE.Text + "','"
		ValueString += Date2 + "','" 'RadTextBoxITEMS_DatePaiement.Text + "','"
		ValueString += RadDropDownITEMS_PayeQui.Text + "','"
		ValueString += RadTextBoxITEMS_PAYE_QUI.Text + "',"
		ValueString += RadSpinEditorITEMS_MT_PAIEMENT.Value.ToString + ",'"
		ValueString += RadDropDownITEMS_FF.Text + "','"
		ValueString += DateTime.Now.ToString("yyyy-MM") + "'"

		mysql = "insert into items (items_index,items_projet_INDEX,ITEMS_CODE,ITEMS_NAME,ITEMS_PARENT,ITEMS_QUANTITY,ITEMS_UNIT,ITEMS_TAXE,"
		mysql += "ITEMS_TAXE_VALUE,ITEMS_CURRENCY,ITEMS_LAST_EDIT_DATE,items_date_paiement,items_paiement_ok,items_paye_qui,items_mt_payé,items_ff,`items_month`) "
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
	Private Sub RadGridViewItems_GroupSummaryEvaluate(ByVal sender As Object, ByVal e As GroupSummaryEvaluationEventArgs)


		Dim ItemsCount As Integer = e.Group.ItemCount
		If ItemsCount <= 0 Then
			RadLabelElementMessage.Text = "Groupe vide"
			Exit Sub
		End If
		Dim temp
		Try
			temp = e.Group.Key(0).ToString
			ListBoxItemsParent.Items.Add(temp + Now.ToLongTimeString)
		Catch ex As Exception
			RadLabelElementMessage.Text = "erreur" + ex.Message
			Exit Sub
		End Try

		Dim TotalGroup As Double = 0.0
		For Each row As GridViewRowInfo In e.Group
			TotalGroup += row.Cells("items_price_total").Value
			ListBoxItemsParent.Items.Add([String].Format("{0} a {1} Items, valeur : {2} ", e.Value, ItemsCount, Format(TotalGroup, "0.00€")))
		Next
		e.FormatString = [String].Format("{0} a {1} Items, valeur : {2} ", e.Value, ItemsCount, Format(TotalGroup, "0.00€"))
		RadLabelElementMessage.Text = e.FormatString + Str(ItemsCount) + "Summ : " + e.SummaryItem.Name
		'https://docs.telerik.com/devtools/winforms/controls/gridview/grouping/custom-grouping
	End Sub
	Private Sub RadButtonItemsLevelOne_Click(sender As Object, e As EventArgs) Handles RadButtonItemsLevelOne.Click
		RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT"
		RadGridViewItems.MasterTemplate.ExpandAll()
	End Sub
	Private Sub RadButtonGroupageRefhesh_Click(sender As Object, e As EventArgs) Handles RadButtonGroupageRefhesh.Click
		RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT;ITEMS_CODE"
		RadGridViewItems.MasterTemplate.ExpandAll()
	End Sub
	Private Sub RadButtonGroupage_Click(sender As Object, e As EventArgs) Handles RadButtonGroupage.Click
		RadGridViewItems.GroupDescriptors.Expression = "ITEMS_PARENT;ITEMS_CODE"
		RadGridViewItems.MasterTemplate.CollapseAllGroups()
	End Sub
	Private Sub RadButtonGroupCancel_Click(sender As Object, e As EventArgs) Handles RadButtonGroupCancel.Click
		RadGridViewItems.GroupDescriptors.Expression = ""
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

	Private Sub Calendar_ZoomChanging(sender As Object, e As CalendarZoomChangingEventArgs)
		If Me.RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Years AndAlso e.Direction = DrillDirection.Up Then
			e.Cancel = True
		End If
		If Me.RadDateTimePickerMonth.DateTimePickerElement.Calendar.ZoomLevel = ZoomLevel.Months AndAlso e.Direction = DrillDirection.Down Then
			e.Cancel = True
		End If
	End Sub

	Private Sub RadcmbTypeCharge_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles RadcmbTypeCharge.SelectedIndexChanged
		Global_Type_Charge = UCase(RadcmbTypeCharge.SelectedItem.Text)
		GetItemsFromDB(ProjectIndexGlobal)
	End Sub

	Private Sub RadDateTimePickerMonth_ValueChanged(sender As Object, e As EventArgs) Handles RadDateTimePickerMonth.ValueChanged
		If ProjectIndexGlobal > 0 Then
			GetItemsFromDB(ProjectIndexGlobal)
		End If
	End Sub

	Private Sub RadCheckBoxFF_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles RadCheckBoxFF.ToggleStateChanged
		If ProjectIndexGlobal > 0 Then
			GetItemsFromDB(ProjectIndexGlobal)
		End If
	End Sub
	Private Sub RadBtnExportExcel_Click(sender As Object, e As EventArgs) Handles RadBtnExportExcel.Click
		Dim spreadExporter As GridViewSpreadExport = New GridViewSpreadExport(RadGridViewItems)
		spreadExporter.ExportChildRowsGrouped = True
		AddHandler spreadExporter.AsyncExportProgressChanged, AddressOf exporter_AsyncExportProgressChanged
		AddHandler spreadExporter.AsyncExportCompleted, AddressOf exporter_AsyncExportCompleted
		Dim exportRenderer As New SpreadExportRenderer()
		RadProgressBarExport.Size = New Size(500, 30)
		RadProgressBarExport.Location = New Point(paneMain.Width / 2 - 250, paneMain.Height / 2 - 15)
		RadProgressBarExport.Visible = True
		Dim filename As String = DateTime.Now.ToString("yyyyMMddhhmmss")
		spreadExporter.RunExportAsync("save\items" & filename & ".xlsx", exportRenderer)
	End Sub
	Private Sub RadBtnExportPDF_Click(sender As Object, e As EventArgs) Handles RadBtnExportPDF.Click
		Dim pdfExporter As GridViewPdfExport = New GridViewPdfExport(RadGridViewItems)
		pdfExporter.ExportGroupedColumns = True
		pdfExporter.FileExtension = "pdf"
		pdfExporter.HiddenColumnOption = Export.HiddenOption.DoNotExport
		pdfExporter.ShowHeaderAndFooter = False
		pdfExporter.FitToPageWidth = True
		pdfExporter.PageSize = New SizeF(500, 300)


		AddHandler pdfExporter.AsyncExportProgressChanged, AddressOf exporter_AsyncExportProgressChanged
		AddHandler pdfExporter.AsyncExportCompleted, AddressOf exporter_AsyncExportCompleted

		Dim exportRenderer As New PdfExportRenderer()
		RadProgressBarExport.Size = New Size(500, 30)
		RadProgressBarExport.Location = New Point(paneMain.Width / 2 - 250, paneMain.Height / 2 - 15)
		RadProgressBarExport.Visible = True
		Dim filename As String = DateTime.Now.ToString("yyyyMMddhhmmss")
		pdfExporter.RunExportAsync("save\items" & filename, exportRenderer)

	End Sub
	Private Sub exporter_AsyncExportProgressChanged(sender As Object, e As ProgressChangedEventArgs)
		RadProgressBarExport.Value1 = e.ProgressPercentage
	End Sub
	Private Sub exporter_AsyncExportCompleted(sender As Object, e As AsyncCompletedEventArgs)
		RadProgressBarExport.Value1 = 0
		RadProgressBarExport.Visible = False
		RadMessageBox.Show("Data Exported Successfully!")
	End Sub
	Private Sub RadButtonItemUploadInvoice_Click(sender As Object, e As EventArgs) Handles RadButtonItemUploadInvoice.Click
		Dim irow As Integer = -1
		Dim iindex As Integer = RadGridViewItems.CurrentRow.Cells(0).Value
		If iindex < 1 Then
			RadLabelElementMessage.Text = "Erreur, le code INDEX est erroné"
			Exit Sub
		End If
		If RadOpenFileDialog1.ShowDialog() = DialogResult.OK Then
			Dim filepath As String = "C:\\MyDrive\001\Invoices\"
			If Not Directory.Exists(filepath) Then
				Directory.CreateDirectory(filepath)
			End If
			Dim filename As String = DateTime.Now.ToString("yyyyMMddhhmmss") + ".pdf"
			My.Computer.FileSystem.CopyFile(RadOpenFileDialog1.FileName, filepath + filename, FileIO.UIOption.OnlyErrorDialogs, FileIO.UICancelOption.DoNothing)

			Dim mysql = "Update items SET items_invoice = '" + filename + "' Where `INDEX` = " + iindex.ToString

			RadLabelElementMessage.Text = mysql

			Try
				Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
				Dim cmd As New MySqlCommand(mysql, connection)
				connection.Open()
				Dim reader As MySqlDataReader
				reader = cmd.ExecuteReader()
				connection.Close()
				MessageBox.Show("Invoice pdf is stored successfully", "Store Invoice", MessageBoxButtons.OK)
			Catch ex As Exception
				RadLabelElementMessage.Text = ex.Message
			End Try

		End If
	End Sub

	Private Sub RadButtonInvoiceClose_Click(sender As Object, e As EventArgs) Handles RadButtonInvoiceClose.Click
		paneInvoice.Hide()
	End Sub

	Private Sub RadButtonItemViewInvoice_Click(sender As Object, e As EventArgs) Handles RadButtonItemViewInvoice.Click
		Dim irow As Integer = -1
		Dim iindex As Integer = RadGridViewItems.CurrentRow.Cells(0).Value
		If iindex < 1 Then
			RadLabelElementMessage.Text = "Erreur, le code INDEX est erroné"
			Exit Sub
		End If
		Dim mysql As String
		mysql = "SELECT items_invoice FROM `items` WHERE items.`INDEX` = " + iindex.ToString
		Dim filename As String = ""
		Try
			Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
			Dim cmd As New MySqlCommand(mysql, connection)
			connection.Open()
			Dim reader As MySqlDataReader
			reader = cmd.ExecuteReader()
			Dim dt As DataTable = New DataTable()
			dt.Load(reader)
			filename = dt.Rows(0).Item("items_invoice")
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
		If filename = "" Then
			MessageBox.Show("Invoice pdf is not stored yet.", "View Invoice", MessageBoxButtons.OK)
			Exit Sub
		End If
		Dim filepath As String = "C:\\MyDrive\001\Invoices\"
		If Not File.Exists(filepath + filename) Then
			MessageBox.Show("File not exist.", "View Invoice", MessageBoxButtons.OK)
		End If
		WebBrowserInvoice.Navigate(New Uri(filepath + filename))
		paneInvoice.Show()
	End Sub

	Private Sub prtDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
		leftMargin = 50
		rightMargin = Convert.ToInt32(e.MarginBounds.Right) + 50
		topMargin = Convert.ToInt32(e.MarginBounds.Top)
		bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
		invoiceWidth = Convert.ToInt32(e.MarginBounds.Width) + 100
		invoiceHeight = Convert.ToInt32(e.MarginBounds.Height)
		SetInvoiceHead(e.Graphics)
		SetOrderData(e.Graphics)
	End Sub

	Private Sub SetInvoiceHead(ByVal g As Graphics)
		CurX = leftMargin
		CurY = topMargin
		' Draw Invoice image:
		Dim xImage As Integer = CurX + (invoiceWidth - My.Resources.Invoice_Header.Width) / 2
		g.DrawImage(My.Resources.Invoice_Header, xImage, CurY)
		CurY += My.Resources.Invoice_Header.Height + 40
	End Sub

	Private Sub SetOrderData(ByVal g As Graphics)

		Dim payDate = RadDateTimePickerITEMS_DatePaiement.Text
		Dim itemID = RadSpinEditor_ITEMS_INDEX.Value
		Dim num = RadSpinEditorITEMS_QUANTITY.Value
		Dim unit = RadSpinEditorITEMS_UNIT.Value
		Dim tax = RadSpinEditorITEMS_TAXE.Value
		Dim total = RadSpinEditor_MTTVA.Value
		Dim mttotal = RadSpinEditorITEMS_TAXE_VALUE.Value



		g.FillRectangle(Brushes.LightGray, New Rectangle(New Point(CurX, CurY), New Size(400, 30)))
		g.DrawRectangle(New Pen(Brushes.Black, 1), New Rectangle(New Point(CurX, CurY), New Size(400, 150)))
		g.DrawLine(New Pen(Brushes.Black, 1), CurX, CurY + 30, CurX + 400, CurY + 30)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 230, CurY, CurX + 230, CurY + 30)

		CurX += 10
		CurY += 6

		g.DrawString("FACTURE N°", InvFontHeaderNormal, Brushes.Black, CurX, CurY)
		g.DrawString("FA23-4631", InvFontHeaderBold, Brushes.Black, CurX + 100, CurY)
		g.DrawString("Date :", InvFontHeaderNormal, Brushes.Black, CurX + 240, CurY)
		g.DrawString(payDate, InvFontHeaderBold, Brushes.Black, CurX + 285, CurY)

		CurY += 30
		g.DrawString("Kapeco Oise", InvFontTextBold, Brushes.Black, CurX, CurY)
		CurY += 14
		g.DrawString("16 allée des cottages, 60500 chantilly", InvFontTextBold, Brushes.Black, CurX, CurY)
		CurY += 14
		g.DrawString("Tél. : +33 (0)6 60 44 65 95 / E-mail : franck@kapeco.com", InvFontTextBold, Brushes.Black, CurX, CurY)
		CurY += 20
		g.DrawString("SIRET : ....................804 991 180 00014", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 14
		g.DrawString("Police d’assurance : ...GAN Assurance IARD A16954 141.614.933", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 14
		g.DrawString("Code APE :................7120B", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 14
		g.DrawString("Capital social : 1000 euros - N°TVA : FR 54 804991180", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 30
		g.DrawString("Facture correspondant au dossier :", InvFontTextItalic, Brushes.Black, CurX + 20, CurY)
		CurX -= 10
		CurY += 25
		g.FillRectangle(Brushes.LightGray, New Rectangle(New Point(CurX, CurY), New Size(rightMargin - CurX, 30)))
		g.DrawRectangle(New Pen(Brushes.Black, 1), New Rectangle(New Point(CurX, CurY), New Size(rightMargin - CurX, 70)))
		g.DrawLine(New Pen(Brushes.Black, 1), CurX, CurY + 30, rightMargin, CurY + 30)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 200, CurY, CurX + 200, CurY + 70)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 350, CurY, CurX + 350, CurY + 70)

		CurX += 10
		CurY += 6
		g.DrawString("Référence", InvFontHeaderBold, Brushes.Black, CurX, CurY)
		g.DrawString("Effectuée le", InvFontHeaderBold, Brushes.Black, CurX + 200, CurY)
		g.DrawString("Immeuble bâti visité", InvFontHeaderBold, Brushes.Black, CurX + 350, CurY)

		CurY += 35

		g.DrawString("23/IMO/54544", InvFontTextItalic, Brushes.Black, CurX, CurY)
		g.DrawString(payDate, InvFontTextItalic, Brushes.Black, CurX + 200, CurY)

		CurY -= 8
		g.DrawString("Panda Optic", InvFontTextItalic, Brushes.Black, CurX + 350, CurY)
		CurY += 14
		g.DrawString("2 route de Paris 77340 PONTAULT-COMBAULT", InvFontTextItalic, Brushes.Black, CurX + 350, CurY)

		CurY += 30
		g.DrawString("Prestations réalisées : Métrage (Loi Carrez), Diag. Handicapé", InvFontTextItalic, Brushes.Black, CurX + 20, CurY)

		CurX -= 10
		CurY += 25
		g.FillRectangle(Brushes.LightGray, New Rectangle(New Point(CurX, CurY), New Size(rightMargin - CurX, 30)))
		g.DrawRectangle(New Pen(Brushes.Black, 1), New Rectangle(New Point(CurX, CurY), New Size(rightMargin - CurX, 60)))
		g.DrawLine(New Pen(Brushes.Black, 1), CurX, CurY + 30, rightMargin, CurY + 30)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 90, CurY, CurX + 90, CurY + 60)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 400, CurY, CurX + 400, CurY + 60)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 470, CurY, CurX + 470, CurY + 60)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 530, CurY, CurX + 530, CurY + 60)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 590, CurY, CurX + 590, CurY + 60)
		g.DrawLine(New Pen(Brushes.Black, 1), CurX + 670, CurY, CurX + 670, CurY + 60)

		CurX += 10
		CurY += 6
		g.DrawString("Référence", InvFontHeaderBold, Brushes.Black, CurX, CurY)
		g.DrawString("Désignation", InvFontHeaderBold, Brushes.Black, CurX + 90, CurY)
		g.DrawString("PU € HT", InvFontHeaderBold, Brushes.Black, CurX + 398, CurY)
		g.DrawString("Quant.", InvFontHeaderBold, Brushes.Black, CurX + 528, CurY)
		CurY -= 8
		g.DrawString("Taux", InvFontHeaderBold, Brushes.Black, CurX + 473, CurY)
		g.DrawString("Montant", InvFontHeaderBold, Brushes.Black, CurX + 590, CurY)
		g.DrawString("Montant", InvFontHeaderBold, Brushes.Black, CurX + 670, CurY)
		CurY += 14
		g.DrawString("TVA", InvFontHeaderBold, Brushes.Black, CurX + 476, CurY)
		g.DrawString("€ HT", InvFontHeaderBold, Brushes.Black, CurX + 598, CurY)
		g.DrawString("€ TTC", InvFontHeaderBold, Brushes.Black, CurX + 678, CurY)

		CurY += 24
		g.DrawString(itemID.ToString, InvFontTextNormal, Brushes.Black, CurX, CurY)
		g.DrawString("Pack Diagnostic d'accessibilité handicapés + Ad'ap", InvFontTextNormal, Brushes.Black, CurX + 90, CurY)
		g.DrawString(unit.ToString, InvFontTextNormal, Brushes.Black, CurX + 400, CurY)
		g.DrawString(tax.ToString, InvFontTextNormal, Brushes.Black, CurX + 470, CurY)
		g.DrawString(num.ToString, InvFontTextNormal, Brushes.Black, CurX + 530, CurY)
		g.DrawString(total.ToString, InvFontTextNormal, Brushes.Black, CurX + 590, CurY)
		g.DrawString(mttotal.ToString, InvFontTextNormal, Brushes.Black, CurX + 670, CurY)

		CurY += 50
		CurX += 20
		g.DrawString("Pour les professionnels : Pénalités de retard (taux annuel) : 9.00% - Une indemnité forfaitaire de 40€ pour frais de", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 16
		g.DrawString("recouvrement sera appliquée en cas de retard de paiement conformément aux articles L441-3 et L441-6 du code de", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 16
		g.DrawString("commerce - Pas d'escompte pour paiement anticipé – Date d’échéance : 13/12/2023", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 16
		g.DrawString("Pour les consommateurs : Vous avez la possibilité de recourir à un médiateur de la consommation dans les conditions", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 16
		g.DrawString("prévues au titre 1er du livre VI du Code de la consommation et dont les coordonnées sont disponibles dans nos conditions", InvFontTextNormal, Brushes.Black, CurX, CurY)
		CurY += 16
		g.DrawString("générales de vente jointes avec cette facture.", InvFontTextNormal, Brushes.Black, CurX, CurY)
	End Sub
	Private Sub RadButtonCloneData_Click(sender As Object, e As EventArgs) Handles RadButtonCloneData.Click
		If checkEarlyMonth() = True Then
			MessageBox.Show("Data is already cloned.", "Clone Data", MessageBoxButtons.OK)
			Exit Sub
		End If
		Dim result As DialogResult = MessageBox.Show("Are you sure to clone data?", "Clone Data", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			copyToNextMonth()
		End If
	End Sub

	Private Function GetPrevMonth(ByVal cur As Date)
		Dim mon As Integer = cur.Month
		Dim year As Integer = cur.Year
		mon = mon - 1
		If mon < 1 Then
			year = year - 1
			mon = mon + 12
		End If
		Dim result As String
		result = year.ToString("0000") & "-" & mon.ToString("00")
		Return result
	End Function
	Private Function GetNextMonth(ByVal cur As Date)
		Dim mon As Integer = cur.Month
		Dim year As Integer = cur.Year
		mon = mon + 1
		If mon > 12 Then
			year = year + 1
			mon = mon - 12
		End If
		Dim result As String
		result = year.ToString("0000") & "-" & mon.ToString("00")
		Return result
	End Function
	Private Sub RadButtonPrevMonth_Click(sender As Object, e As EventArgs) Handles RadButtonPrevMonth.Click
		Dim month As String = GetPrevMonth(RadDateTimePickerMonth.Value)
		RadDateTimePickerMonth.Text = month

	End Sub

	Private Sub RadButtonNextMonth_Click(sender As Object, e As EventArgs) Handles RadButtonNextMonth.Click
		Dim month As String = GetNextMonth(RadDateTimePickerMonth.Value)
		RadDateTimePickerMonth.Text = month
	End Sub

	Private Sub RadSpinEditorITEMS_QUANTITY_ValueChanged(sender As Object, e As EventArgs) Handles RadSpinEditorITEMS_QUANTITY.ValueChanged
		RadSpinEditor_MTTVA.Value = RadSpinEditorITEMS_QUANTITY.Value * RadSpinEditorITEMS_UNIT.Value
		RadSpinEditorITEMS_TAXE_VALUE.Value = RadSpinEditor_MTTVA.Value * RadSpinEditorITEMS_TAXE.Value / 100.0
		RadSpinEditorITEMS_BIG_TOTAL.Value = RadSpinEditorITEMS_TAXE_VALUE.Value + RadSpinEditor_MTTVA.Value
	End Sub

	Private Sub RadSpinEditorITEMS_UNIT_ValueChanged(sender As Object, e As EventArgs) Handles RadSpinEditorITEMS_UNIT.ValueChanged
		RadSpinEditor_MTTVA.Value = RadSpinEditorITEMS_QUANTITY.Value * RadSpinEditorITEMS_UNIT.Value
		RadSpinEditorITEMS_TAXE_VALUE.Value = RadSpinEditor_MTTVA.Value * RadSpinEditorITEMS_TAXE.Value / 100.0
		RadSpinEditorITEMS_BIG_TOTAL.Value = RadSpinEditorITEMS_TAXE_VALUE.Value + RadSpinEditor_MTTVA.Value
	End Sub

	Private Sub RadSpinEditorITEMS_TAXE_ValueChanged(sender As Object, e As EventArgs) Handles RadSpinEditorITEMS_TAXE.ValueChanged
		RadSpinEditor_MTTVA.Value = RadSpinEditorITEMS_QUANTITY.Value * RadSpinEditorITEMS_UNIT.Value
		RadSpinEditorITEMS_TAXE_VALUE.Value = RadSpinEditor_MTTVA.Value * RadSpinEditorITEMS_TAXE.Value / 100.0
		RadSpinEditorITEMS_BIG_TOTAL.Value = RadSpinEditorITEMS_TAXE_VALUE.Value + RadSpinEditor_MTTVA.Value
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
		RadGridViewProjectName.Columns(2).Width = 200
		RadGridViewProjectName.Columns(3).Width = 200
		RadGridViewProjectName.Columns(4).Width = 180
		RadGridViewProjectName.Columns(5).Width = 160

		RadGridViewProjectName.Columns(0).TextAlignment = ContentAlignment.MiddleCenter
		RadGridViewProjectName.Columns(1).TextAlignment = ContentAlignment.MiddleCenter
		RadGridViewProjectName.Columns(2).TextAlignment = ContentAlignment.MiddleLeft
		RadGridViewProjectName.Columns(3).TextAlignment = ContentAlignment.MiddleLeft
		RadGridViewProjectName.Columns(4).TextAlignment = ContentAlignment.MiddleRight
		RadGridViewProjectName.Columns(5).TextAlignment = ContentAlignment.MiddleCenter
	End Sub

	Private Function FindLastProjectCount()

		Dim mysql As String
		mysql = "select MAX(PrOJECT_INDEX) AS PrOJECT_INDEX FROM project"
		Dim idx As Integer = 0
		Try
			Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
			Dim cmd As New MySqlCommand(mysql, connection)
			connection.Open()
			Dim reader As MySqlDataReader
			reader = cmd.ExecuteReader()
			idx = Val(reader("PrOJECT_INDEX"))
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
		Return idx
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
	Private Function FindProjectListe() As Integer
		Dim mysql As String
		Dim cpt As Integer
		Dim basename As String = "project"
		mysql = "SELECT *  FROM " + basename + " order by project_INDEX desc"
		Try
			Dim connection As New MySqlConnection(GlobalProviderForLocalHost)
			Dim cmd As New MySqlCommand(mysql, connection)
			connection.Open()
			Dim reader As MySqlDataReader
			reader = cmd.ExecuteReader()
			Me.RadGridViewProjectName.DataSource = reader
			cpt = RadGridViewProjectName.Rows.Count
			SetColumnHeader()
			connection.Close()
		Catch ex As Exception
			RadLabelElementMessage.Text = ex.Message
		End Try
		Return cpt
	End Function

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

	Private Sub UpdateProjectDB(ByVal idx As Integer, ByVal pCode As String, ByVal pName As String, ByVal pStatus As String)
		Dim mysql As String
		mysql = "UPDATE project SET `PrOJECT_CODE` = '" + pCode + "', `PrOJECT_NAME` = '" + pName + "', `PrOJECT_STATUS` = '" + pStatus + "' WHERE `INDEX` = " + idx.ToString
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

	Private Sub DeleteProjectDB(ByVal idx As Integer)
		Dim mysql As String
		mysql = "DELETE FROM project WHERE `INDEX` = " + idx.ToString
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

	Private Sub ButtonNewProject_Click(sender As Object, e As EventArgs) Handles ButtonNewProject.Click
		Dim iindex As Integer = FindLastProjectCount() + 1

		Dim result As DialogResult = MessageBox.Show("Are you sure to add new project infomation?", "Add New Project", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			AddProjectDB(iindex, RadTextBoxProjectCode.Text, RadTextBoxProjectName.Text, RadTextBoxProjectStatus.Text)
			FindProjectListe()
		End If
	End Sub

	Private Sub ButtonUpdateProject_Click(sender As Object, e As EventArgs) Handles ButtonUpdateProject.Click
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

		Dim result As DialogResult = MessageBox.Show("Are you sure to update project infomation?", "Update Project", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			UpdateProjectDB(idx, RadTextBoxProjectCode.Text, RadTextBoxProjectName.Text, RadTextBoxProjectStatus.Text)
			FindProjectListe()
		End If
	End Sub

	Private Sub ButtonDeleteProject_Click(sender As Object, e As EventArgs) Handles ButtonDeleteProject.Click
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
		Dim result As DialogResult = MessageBox.Show("Are you sure to delete project?", "Delete Project", MessageBoxButtons.YesNo)
		If result = DialogResult.Yes Then
			DeleteProjectDB(idx)
			FindProjectListe()
		End If
	End Sub
End Class