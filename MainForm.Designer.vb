<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form remplace la méthode Dispose pour nettoyer la liste des composants.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Requise par le Concepteur Windows Form
	Private components As System.ComponentModel.IContainer

	'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
	'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
	'Ne la modifiez pas à l'aide de l'éditeur de code.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim ListViewDetailColumn1 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name")
		Dim ListViewDetailColumn2 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Age")
		Dim ListViewDetailColumn3 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Gender")
		Dim ListViewDetailColumn4 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "EncounterTime")
		Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem14 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem15 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim TableViewDefinition13 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Dim TableViewDefinition14 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
		Dim TableViewDefinition15 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Me.RadPanelTodaysAppointments = New Telerik.WinControls.UI.RadPanel()
		Me.RadLabelMTPaye = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelAllTotalOfItems = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelLastAppointmentToday = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelTotalEstimation = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelCurrentItems = New Telerik.WinControls.UI.RadLabel()
		Me.RadListeiewProjectName = New Telerik.WinControls.UI.RadListView()
		Me.ListBoxItemsParent = New System.Windows.Forms.ListBox()
		Me.RadStatusStrip2 = New Telerik.WinControls.UI.RadStatusStrip()
		Me.RadLabelElementMessage = New Telerik.WinControls.UI.RadLabelElement()
		Me.RadPanelHaut = New Telerik.WinControls.UI.RadPanel()
		Me.RadBtnExportExcel = New Telerik.WinControls.UI.RadButton()
		Me.RadBtnExportPDF = New Telerik.WinControls.UI.RadButton()
		Me.RadcmbTypeCharge = New Telerik.WinControls.UI.RadDropDownList()
		Me.RadDateTimePickerMonth = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadLabelGlobalCathegory = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelProjectNameGlobal = New Telerik.WinControls.UI.RadLabel()
		Me.RadCheckBoxFF = New Telerik.WinControls.UI.RadCheckBox()
		Me.ButtonGridviewUpdate = New System.Windows.Forms.Button()
		Me.ButtonGridviewDelete = New System.Windows.Forms.Button()
		Me.ButtonGridviewNew = New System.Windows.Forms.Button()
		Me.RadGridViewClassItemsListe = New Telerik.WinControls.UI.RadGridView()
		Me.RadButtonItemsLevelOne = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonGroupageRefhesh = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonGroupCancel = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonGroupage = New Telerik.WinControls.UI.RadButton()
		Me.RadGridViewItems = New Telerik.WinControls.UI.RadGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RadDateTimePickerITEMS_DatePaiement = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadSpinEditor_ITEMS_INDEX = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditor_INDEX = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorITEMS_TAXE_VALUE = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditor_MTTVA = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorITEMS_TAXE = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorITEMS_UNIT = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorITEMS_QUANTITY = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorITEMS_MT_PAIEMENT = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadDropDownITEMS_PayeQui = New Telerik.WinControls.UI.RadDropDownList()
		Me.RadDropDownITEMS_CURRENCY = New Telerik.WinControls.UI.RadDropDownList()
		Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
		Me.RadTextBoxITEMS_PAYE_QUI = New Telerik.WinControls.UI.RadTextBox()
		Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelPayeOuPas = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelDatePaiement = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
		Me.RadTextBoxITEMS_PARENT = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_NAME = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_CODE = New Telerik.WinControls.UI.RadTextBox()
		Me.GroupBoxMenuVertical = New System.Windows.Forms.Panel()
		Me.paneMain = New System.Windows.Forms.Panel()
		Me.paneSettings = New System.Windows.Forms.Panel()
		Me.ButtonNewProject = New System.Windows.Forms.Button()
		Me.ButtonDeleteProject = New System.Windows.Forms.Button()
		Me.ButtonUpdateProject = New System.Windows.Forms.Button()
		Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
		Me.RadLabel27 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel26 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel25 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel24 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel23 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel22 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel21 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
		Me.RadSpinEditorIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorProjectIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBoxProjectCode = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxProjectName = New Telerik.WinControls.UI.RadTextBox()
		Me.RadDateTimePickerCreateDate = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadDateTimePickerModifyDate = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadTextBoxProjectStatus = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxProjectDataPath = New Telerik.WinControls.UI.RadTextBox()
		Me.RadGridViewProjectName = New Telerik.WinControls.UI.RadGridView()
		Me.RadProgressBarExport = New Telerik.WinControls.UI.RadProgressBar()
		Me.Office2019GrayTheme1 = New Telerik.WinControls.Themes.Office2019GrayTheme()
		CType(Me.RadPanelTodaysAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadPanelTodaysAppointments.SuspendLayout()
		CType(Me.RadLabelMTPaye, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelAllTotalOfItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelLastAppointmentToday, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelTotalEstimation, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelCurrentItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadListeiewProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadPanelHaut, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadPanelHaut.SuspendLayout()
		CType(Me.RadBtnExportExcel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadBtnExportPDF, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadcmbTypeCharge, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerMonth, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelGlobalCathegory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelProjectNameGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadCheckBoxFF, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewClassItemsListe, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewClassItemsListe.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonItemsLevelOne, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonGroupageRefhesh, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonGroupCancel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonGroupage, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.RadDateTimePickerITEMS_DatePaiement, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerITEMS_LAST_EDIT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor_ITEMS_INDEX, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor_INDEX, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorITEMS_TAXE_VALUE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor_MTTVA, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorITEMS_TAXE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorITEMS_UNIT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorITEMS_QUANTITY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorITEMS_MT_PAIEMENT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDropDownITEMS_PayeQui, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDropDownITEMS_CURRENCY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_PAYE_QUI, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelPayeOuPas, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelDatePaiement, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_PARENT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_CODE, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.paneMain.SuspendLayout()
		Me.paneSettings.SuspendLayout()
		CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadGroupBox1.SuspendLayout()
		CType(Me.RadLabel27, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerCreateDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerModifyDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectStatus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectDataPath, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewProjectName.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadProgressBarExport, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RadPanelTodaysAppointments
		'
		Me.RadPanelTodaysAppointments.BackColor = System.Drawing.Color.Gainsboro
		Me.RadPanelTodaysAppointments.Controls.Add(Me.RadLabelMTPaye)
		Me.RadPanelTodaysAppointments.Controls.Add(Me.RadLabelAllTotalOfItems)
		Me.RadPanelTodaysAppointments.Controls.Add(Me.RadLabelLastAppointmentToday)
		Me.RadPanelTodaysAppointments.Controls.Add(Me.RadLabelTotalEstimation)
		Me.RadPanelTodaysAppointments.Controls.Add(Me.RadLabelCurrentItems)
		Me.RadPanelTodaysAppointments.Location = New System.Drawing.Point(266, 570)
		Me.RadPanelTodaysAppointments.Name = "RadPanelTodaysAppointments"
		'
		'
		'
		Me.RadPanelTodaysAppointments.RootElement.ControlBounds = New System.Drawing.Rectangle(266, 570, 200, 100)
		Me.RadPanelTodaysAppointments.Size = New System.Drawing.Size(300, 276)
		Me.RadPanelTodaysAppointments.TabIndex = 9
		Me.RadPanelTodaysAppointments.ThemeName = "MedicalAppTheme"
		'
		'RadLabelMTPaye
		'
		Me.RadLabelMTPaye.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelMTPaye.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabelMTPaye.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.RadLabelMTPaye.Location = New System.Drawing.Point(17, 152)
		Me.RadLabelMTPaye.Name = "RadLabelMTPaye"
		'
		'
		'
		Me.RadLabelMTPaye.RootElement.ControlBounds = New System.Drawing.Rectangle(17, 152, 100, 18)
		Me.RadLabelMTPaye.Size = New System.Drawing.Size(35, 38)
		Me.RadLabelMTPaye.TabIndex = 2
		Me.RadLabelMTPaye.Text = "0"
		Me.RadLabelMTPaye.UseCompatibleTextRendering = False
		'
		'RadLabelAllTotalOfItems
		'
		Me.RadLabelAllTotalOfItems.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelAllTotalOfItems.Font = New System.Drawing.Font("Segoe UI Light", 15.0!)
		Me.RadLabelAllTotalOfItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.RadLabelAllTotalOfItems.Location = New System.Drawing.Point(14, 203)
		Me.RadLabelAllTotalOfItems.Name = "RadLabelAllTotalOfItems"
		'
		'
		'
		Me.RadLabelAllTotalOfItems.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 203, 100, 18)
		Me.RadLabelAllTotalOfItems.Size = New System.Drawing.Size(56, 31)
		Me.RadLabelAllTotalOfItems.TabIndex = 1
		Me.RadLabelAllTotalOfItems.Text = "0.00€"
		'
		'RadLabelLastAppointmentToday
		'
		Me.RadLabelLastAppointmentToday.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelLastAppointmentToday.Font = New System.Drawing.Font("Segoe UI", 12.25!)
		Me.RadLabelLastAppointmentToday.Location = New System.Drawing.Point(14, 242)
		Me.RadLabelLastAppointmentToday.Name = "RadLabelLastAppointmentToday"
		'
		'
		'
		Me.RadLabelLastAppointmentToday.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 242, 100, 18)
		Me.RadLabelLastAppointmentToday.Size = New System.Drawing.Size(150, 26)
		Me.RadLabelLastAppointmentToday.TabIndex = 1
		Me.RadLabelLastAppointmentToday.Text = "last one at 5:00 PM"
		'
		'RadLabelTotalEstimation
		'
		Me.RadLabelTotalEstimation.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelTotalEstimation.Font = New System.Drawing.Font("Segoe UI Light", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabelTotalEstimation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.RadLabelTotalEstimation.Location = New System.Drawing.Point(14, 68)
		Me.RadLabelTotalEstimation.Name = "RadLabelTotalEstimation"
		'
		'
		'
		Me.RadLabelTotalEstimation.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 68, 100, 18)
		Me.RadLabelTotalEstimation.Size = New System.Drawing.Size(55, 67)
		Me.RadLabelTotalEstimation.TabIndex = 1
		Me.RadLabelTotalEstimation.Text = "0"
		Me.RadLabelTotalEstimation.UseCompatibleTextRendering = False
		'
		'RadLabelCurrentItems
		'
		Me.RadLabelCurrentItems.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelCurrentItems.Font = New System.Drawing.Font("Segoe UI Light", 14.5!)
		Me.RadLabelCurrentItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(79, Byte), Integer))
		Me.RadLabelCurrentItems.Location = New System.Drawing.Point(14, 12)
		Me.RadLabelCurrentItems.Name = "RadLabelCurrentItems"
		'
		'
		'
		Me.RadLabelCurrentItems.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 12, 100, 18)
		Me.RadLabelCurrentItems.Size = New System.Drawing.Size(71, 30)
		Me.RadLabelCurrentItems.TabIndex = 0
		Me.RadLabelCurrentItems.Text = "TODAY"
		'
		'RadListeiewProjectName
		'
		Me.RadListeiewProjectName.AllowArbitraryItemHeight = True
		Me.RadListeiewProjectName.AllowEdit = False
		Me.RadListeiewProjectName.AllowRemove = False
		Me.RadListeiewProjectName.AutoScroll = True
		Me.RadListeiewProjectName.BackColor = System.Drawing.SystemColors.ControlLightLight
		ListViewDetailColumn1.HeaderText = "Name"
		ListViewDetailColumn2.HeaderText = "Age"
		ListViewDetailColumn3.HeaderText = "Gender"
		ListViewDetailColumn4.HeaderText = "EncounterTime"
		Me.RadListeiewProjectName.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn1, ListViewDetailColumn2, ListViewDetailColumn3, ListViewDetailColumn4})
		Me.RadListeiewProjectName.ItemSize = New System.Drawing.Size(200, 95)
		Me.RadListeiewProjectName.Location = New System.Drawing.Point(5, 570)
		Me.RadListeiewProjectName.Name = "RadListeiewProjectName"
		'
		'
		'
		Me.RadListeiewProjectName.RootElement.ControlBounds = New System.Drawing.Rectangle(5, 570, 120, 95)
		Me.RadListeiewProjectName.SelectLastAddedItem = False
		Me.RadListeiewProjectName.Size = New System.Drawing.Size(250, 276)
		Me.RadListeiewProjectName.TabIndex = 10
		Me.RadListeiewProjectName.ThemeName = "MedicalAppTheme"
		Me.RadListeiewProjectName.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
		'
		'ListBoxItemsParent
		'
		Me.ListBoxItemsParent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ListBoxItemsParent.BackColor = System.Drawing.Color.Gainsboro
		Me.ListBoxItemsParent.FormattingEnabled = True
		Me.ListBoxItemsParent.Location = New System.Drawing.Point(1268, 605)
		Me.ListBoxItemsParent.Name = "ListBoxItemsParent"
		Me.ListBoxItemsParent.Size = New System.Drawing.Size(277, 238)
		Me.ListBoxItemsParent.TabIndex = 12
		'
		'RadStatusStrip2
		'
		Me.RadStatusStrip2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadStatusStrip2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElementMessage})
		Me.RadStatusStrip2.Location = New System.Drawing.Point(0, 851)
		Me.RadStatusStrip2.Name = "RadStatusStrip2"
		'
		'
		'
		Me.RadStatusStrip2.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 851, 300, 24)
		Me.RadStatusStrip2.RootElement.StretchVertically = True
		Me.RadStatusStrip2.Size = New System.Drawing.Size(1614, 30)
		Me.RadStatusStrip2.TabIndex = 14
		'
		'RadLabelElementMessage
		'
		Me.RadLabelElementMessage.Name = "RadLabelElementMessage"
		Me.RadStatusStrip2.SetSpring(Me.RadLabelElementMessage, False)
		Me.RadLabelElementMessage.Text = "RadLabelElementMessage"
		Me.RadLabelElementMessage.TextWrap = True
		Me.RadLabelElementMessage.UseCompatibleTextRendering = False
		'
		'RadPanelHaut
		'
		Me.RadPanelHaut.BackColor = System.Drawing.Color.Gray
		Me.RadPanelHaut.Controls.Add(Me.RadBtnExportExcel)
		Me.RadPanelHaut.Controls.Add(Me.RadBtnExportPDF)
		Me.RadPanelHaut.Controls.Add(Me.RadcmbTypeCharge)
		Me.RadPanelHaut.Controls.Add(Me.RadDateTimePickerMonth)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelGlobalCathegory)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelProjectNameGlobal)
		Me.RadPanelHaut.Controls.Add(Me.RadCheckBoxFF)
		Me.RadPanelHaut.Location = New System.Drawing.Point(0, 0)
		Me.RadPanelHaut.Name = "RadPanelHaut"
		'
		'
		'
		Me.RadPanelHaut.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 100)
		Me.RadPanelHaut.Size = New System.Drawing.Size(1554, 35)
		Me.RadPanelHaut.TabIndex = 46
		'
		'RadBtnExportExcel
		'
		Me.RadBtnExportExcel.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadBtnExportExcel.Location = New System.Drawing.Point(1406, 5)
		Me.RadBtnExportExcel.Name = "RadBtnExportExcel"
		Me.RadBtnExportExcel.Size = New System.Drawing.Size(110, 24)
		Me.RadBtnExportExcel.TabIndex = 67
		Me.RadBtnExportExcel.Text = "Export to Excel"
		Me.RadBtnExportExcel.ThemeName = "Office2019Gray"
		'
		'RadBtnExportPDF
		'
		Me.RadBtnExportPDF.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadBtnExportPDF.Location = New System.Drawing.Point(1269, 5)
		Me.RadBtnExportPDF.Name = "RadBtnExportPDF"
		Me.RadBtnExportPDF.Size = New System.Drawing.Size(110, 24)
		Me.RadBtnExportPDF.TabIndex = 66
		Me.RadBtnExportPDF.Text = "Export to PDF"
		Me.RadBtnExportPDF.ThemeName = "Office2019Gray"
		'
		'RadcmbTypeCharge
		'
		Me.RadcmbTypeCharge.DropDownAnimationEnabled = True
		Me.RadcmbTypeCharge.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		RadListDataItem1.Text = "Tous"
		RadListDataItem2.Text = "Hors achats"
		RadListDataItem9.Text = "Hors salaires"
		RadListDataItem10.Text = "Achats"
		RadListDataItem11.Text = "Salaires"
		RadListDataItem12.Text = "Petites charges"
		RadListDataItem13.Text = "Loyer et autres"
		RadListDataItem14.Text = "Taxes et impots"
		RadListDataItem15.Text = "Frais bancaires"
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem1)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem2)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem9)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem10)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem11)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem12)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem13)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem14)
		Me.RadcmbTypeCharge.Items.Add(RadListDataItem15)
		Me.RadcmbTypeCharge.Location = New System.Drawing.Point(856, 5)
		Me.RadcmbTypeCharge.Name = "RadcmbTypeCharge"
		Me.RadcmbTypeCharge.Size = New System.Drawing.Size(136, 24)
		Me.RadcmbTypeCharge.TabIndex = 65
		Me.RadcmbTypeCharge.ThemeName = "Office2019Gray"
		'
		'RadDateTimePickerMonth
		'
		Me.RadDateTimePickerMonth.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerMonth.CustomFormat = "yyyy-MM"
		Me.RadDateTimePickerMonth.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadDateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.RadDateTimePickerMonth.Location = New System.Drawing.Point(534, 5)
		Me.RadDateTimePickerMonth.Name = "RadDateTimePickerMonth"
		Me.RadDateTimePickerMonth.NullDate = New Date(2024, 1, 18, 0, 0, 0, 0)
		Me.RadDateTimePickerMonth.Size = New System.Drawing.Size(117, 24)
		Me.RadDateTimePickerMonth.TabIndex = 46
		Me.RadDateTimePickerMonth.TabStop = False
		Me.RadDateTimePickerMonth.Text = "2024-01"
		Me.RadDateTimePickerMonth.ThemeName = "Office2019Gray"
		Me.RadDateTimePickerMonth.Value = New Date(2024, 1, 10, 11, 13, 48, 329)
		'
		'RadLabelGlobalCathegory
		'
		Me.RadLabelGlobalCathegory.AutoSize = False
		Me.RadLabelGlobalCathegory.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelGlobalCathegory.ForeColor = System.Drawing.Color.White
		Me.RadLabelGlobalCathegory.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelGlobalCathegory.Location = New System.Drawing.Point(270, 5)
		Me.RadLabelGlobalCathegory.Name = "RadLabelGlobalCathegory"
		'
		'
		'
		Me.RadLabelGlobalCathegory.RootElement.ControlBounds = New System.Drawing.Rectangle(270, 5, 100, 18)
		Me.RadLabelGlobalCathegory.Size = New System.Drawing.Size(240, 25)
		Me.RadLabelGlobalCathegory.TabIndex = 45
		Me.RadLabelGlobalCathegory.Text = "RadLabelGlobalCathegory"
		'
		'RadLabelProjectNameGlobal
		'
		Me.RadLabelProjectNameGlobal.AutoSize = False
		Me.RadLabelProjectNameGlobal.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelProjectNameGlobal.ForeColor = System.Drawing.Color.White
		Me.RadLabelProjectNameGlobal.Location = New System.Drawing.Point(20, 5)
		Me.RadLabelProjectNameGlobal.Name = "RadLabelProjectNameGlobal"
		'
		'
		'
		Me.RadLabelProjectNameGlobal.RootElement.ControlBounds = New System.Drawing.Rectangle(20, 5, 100, 18)
		Me.RadLabelProjectNameGlobal.Size = New System.Drawing.Size(240, 25)
		Me.RadLabelProjectNameGlobal.TabIndex = 44
		Me.RadLabelProjectNameGlobal.Text = "RadLabelAudioNameGlobal"
		'
		'RadCheckBoxFF
		'
		Me.RadCheckBoxFF.CheckState = System.Windows.Forms.CheckState.Checked
		Me.RadCheckBoxFF.ForeColor = System.Drawing.Color.White
		Me.RadCheckBoxFF.Location = New System.Drawing.Point(722, 8)
		Me.RadCheckBoxFF.Name = "RadCheckBoxFF"
		Me.RadCheckBoxFF.Size = New System.Drawing.Size(63, 17)
		Me.RadCheckBoxFF.TabIndex = 64
		Me.RadCheckBoxFF.Text = "inclu FF"
		Me.RadCheckBoxFF.ThemeName = "Office2019Gray"
		Me.RadCheckBoxFF.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
		'
		'ButtonGridviewUpdate
		'
		Me.ButtonGridviewUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ButtonGridviewUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ButtonGridviewUpdate.Location = New System.Drawing.Point(112, 501)
		Me.ButtonGridviewUpdate.Name = "ButtonGridviewUpdate"
		Me.ButtonGridviewUpdate.Size = New System.Drawing.Size(60, 29)
		Me.ButtonGridviewUpdate.TabIndex = 48
		Me.ButtonGridviewUpdate.Text = "Update"
		Me.ButtonGridviewUpdate.UseVisualStyleBackColor = True
		'
		'ButtonGridviewDelete
		'
		Me.ButtonGridviewDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ButtonGridviewDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ButtonGridviewDelete.Location = New System.Drawing.Point(190, 501)
		Me.ButtonGridviewDelete.Name = "ButtonGridviewDelete"
		Me.ButtonGridviewDelete.Size = New System.Drawing.Size(60, 29)
		Me.ButtonGridviewDelete.TabIndex = 49
		Me.ButtonGridviewDelete.Text = "Delete"
		Me.ButtonGridviewDelete.UseVisualStyleBackColor = True
		'
		'ButtonGridviewNew
		'
		Me.ButtonGridviewNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.ButtonGridviewNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ButtonGridviewNew.Location = New System.Drawing.Point(35, 501)
		Me.ButtonGridviewNew.Name = "ButtonGridviewNew"
		Me.ButtonGridviewNew.Size = New System.Drawing.Size(60, 29)
		Me.ButtonGridviewNew.TabIndex = 50
		Me.ButtonGridviewNew.Text = "Add"
		Me.ButtonGridviewNew.UseVisualStyleBackColor = True
		'
		'RadGridViewClassItemsListe
		'
		Me.RadGridViewClassItemsListe.Location = New System.Drawing.Point(579, 611)
		'
		'
		'
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowAddNewRow = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowCellContextMenu = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowColumnChooser = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowColumnHeaderContextMenu = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowColumnReorder = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowColumnResize = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowDeleteRow = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowDragToGroup = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowEditRow = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowRowHeaderContextMenu = False
		Me.RadGridViewClassItemsListe.MasterTemplate.AllowRowResize = False
		Me.RadGridViewClassItemsListe.MasterTemplate.EnableAlternatingRowColor = True
		Me.RadGridViewClassItemsListe.MasterTemplate.EnableGrouping = False
		Me.RadGridViewClassItemsListe.MasterTemplate.ShowRowHeaderColumn = False
		Me.RadGridViewClassItemsListe.MasterTemplate.ViewDefinition = TableViewDefinition13
		Me.RadGridViewClassItemsListe.Name = "RadGridViewClassItemsListe"
		Me.RadGridViewClassItemsListe.ShowItemToolTips = False
		Me.RadGridViewClassItemsListe.ShowNoDataText = False
		Me.RadGridViewClassItemsListe.Size = New System.Drawing.Size(680, 232)
		Me.RadGridViewClassItemsListe.TabIndex = 63
		Me.RadGridViewClassItemsListe.ThemeName = "Office2019Gray"
		'
		'RadButtonItemsLevelOne
		'
		Me.RadButtonItemsLevelOne.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonItemsLevelOne.Image = Global.PrevisionFlex.My.Resources.Resources.update_ronde_gray_30x302
		Me.RadButtonItemsLevelOne.Location = New System.Drawing.Point(584, 567)
		Me.RadButtonItemsLevelOne.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonItemsLevelOne.Name = "RadButtonItemsLevelOne"
		'
		'
		'
		Me.RadButtonItemsLevelOne.RootElement.ControlBounds = New System.Drawing.Rectangle(584, 567, 110, 24)
		Me.RadButtonItemsLevelOne.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonItemsLevelOne.TabIndex = 61
		Me.RadButtonItemsLevelOne.Text = "1 Level  "
		Me.RadButtonItemsLevelOne.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadButtonGroupageRefhesh
		'
		Me.RadButtonGroupageRefhesh.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonGroupageRefhesh.Image = Global.PrevisionFlex.My.Resources.Resources.update_ronde_gray_30x302
		Me.RadButtonGroupageRefhesh.Location = New System.Drawing.Point(686, 567)
		Me.RadButtonGroupageRefhesh.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonGroupageRefhesh.Name = "RadButtonGroupageRefhesh"
		'
		'
		'
		Me.RadButtonGroupageRefhesh.RootElement.ControlBounds = New System.Drawing.Rectangle(686, 567, 110, 24)
		Me.RadButtonGroupageRefhesh.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonGroupageRefhesh.TabIndex = 60
		Me.RadButtonGroupageRefhesh.Text = "2 Level   "
		Me.RadButtonGroupageRefhesh.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadButtonGroupCancel
		'
		Me.RadButtonGroupCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonGroupCancel.Image = Global.PrevisionFlex.My.Resources.Resources.treeview_detail_25
		Me.RadButtonGroupCancel.Location = New System.Drawing.Point(890, 567)
		Me.RadButtonGroupCancel.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonGroupCancel.Name = "RadButtonGroupCancel"
		'
		'
		'
		Me.RadButtonGroupCancel.RootElement.ControlBounds = New System.Drawing.Rectangle(890, 567, 110, 24)
		Me.RadButtonGroupCancel.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonGroupCancel.TabIndex = 60
		Me.RadButtonGroupCancel.Text = "Détail  "
		Me.RadButtonGroupCancel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadButtonGroupage
		'
		Me.RadButtonGroupage.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonGroupage.Image = Global.PrevisionFlex.My.Resources.Resources.treeview_sans_detail_25
		Me.RadButtonGroupage.Location = New System.Drawing.Point(788, 567)
		Me.RadButtonGroupage.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonGroupage.Name = "RadButtonGroupage"
		'
		'
		'
		Me.RadButtonGroupage.RootElement.ControlBounds = New System.Drawing.Rectangle(788, 567, 110, 24)
		Me.RadButtonGroupage.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonGroupage.TabIndex = 59
		Me.RadButtonGroupage.Text = "Groupage "
		Me.RadButtonGroupage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadGridViewItems
		'
		Me.RadGridViewItems.AutoScroll = True
		Me.RadGridViewItems.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadGridViewItems.Location = New System.Drawing.Point(5, 40)
		'
		'
		'
		Me.RadGridViewItems.MasterTemplate.AllowAddNewRow = False
		Me.RadGridViewItems.MasterTemplate.AllowDeleteRow = False
		Me.RadGridViewItems.MasterTemplate.AllowEditRow = False
		Me.RadGridViewItems.MasterTemplate.AllowSearchRow = True
		Me.RadGridViewItems.MasterTemplate.AutoExpandGroups = True
		Me.RadGridViewItems.MasterTemplate.EnableAlternatingRowColor = True
		Me.RadGridViewItems.MasterTemplate.ViewDefinition = TableViewDefinition14
		Me.RadGridViewItems.Name = "RadGridViewItems"
		'
		'
		'
		Me.RadGridViewItems.RootElement.ControlBounds = New System.Drawing.Rectangle(5, 40, 240, 150)
		Me.RadGridViewItems.Size = New System.Drawing.Size(1256, 520)
		Me.RadGridViewItems.TabIndex = 6
		Me.RadGridViewItems.ThemeName = "Office2019Gray"
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.RadDateTimePickerITEMS_DatePaiement)
		Me.GroupBox1.Controls.Add(Me.RadDateTimePickerITEMS_LAST_EDIT_DATE)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditor_ITEMS_INDEX)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditor_INDEX)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditorITEMS_TAXE_VALUE)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditor_MTTVA)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditorITEMS_TAXE)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditorITEMS_UNIT)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditorITEMS_QUANTITY)
		Me.GroupBox1.Controls.Add(Me.RadSpinEditorITEMS_MT_PAIEMENT)
		Me.GroupBox1.Controls.Add(Me.RadDropDownITEMS_PayeQui)
		Me.GroupBox1.Controls.Add(Me.RadDropDownITEMS_CURRENCY)
		Me.GroupBox1.Controls.Add(Me.RadLabel13)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_PAYE_QUI)
		Me.GroupBox1.Controls.Add(Me.RadLabel14)
		Me.GroupBox1.Controls.Add(Me.RadLabelPayeOuPas)
		Me.GroupBox1.Controls.Add(Me.RadLabelDatePaiement)
		Me.GroupBox1.Controls.Add(Me.RadLabel12)
		Me.GroupBox1.Controls.Add(Me.RadLabel11)
		Me.GroupBox1.Controls.Add(Me.RadLabel10)
		Me.GroupBox1.Controls.Add(Me.RadLabel9)
		Me.GroupBox1.Controls.Add(Me.RadLabel8)
		Me.GroupBox1.Controls.Add(Me.RadLabel7)
		Me.GroupBox1.Controls.Add(Me.RadLabel6)
		Me.GroupBox1.Controls.Add(Me.RadLabel5)
		Me.GroupBox1.Controls.Add(Me.RadLabel4)
		Me.GroupBox1.Controls.Add(Me.ButtonGridviewDelete)
		Me.GroupBox1.Controls.Add(Me.RadLabel3)
		Me.GroupBox1.Controls.Add(Me.ButtonGridviewNew)
		Me.GroupBox1.Controls.Add(Me.ButtonGridviewUpdate)
		Me.GroupBox1.Controls.Add(Me.RadLabel2)
		Me.GroupBox1.Controls.Add(Me.RadLabel1)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_PARENT)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_NAME)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_CODE)
		Me.GroupBox1.Location = New System.Drawing.Point(1268, 36)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(277, 540)
		Me.GroupBox1.TabIndex = 62
		Me.GroupBox1.TabStop = False
		'
		'RadDateTimePickerITEMS_DatePaiement
		'
		Me.RadDateTimePickerITEMS_DatePaiement.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadDateTimePickerITEMS_DatePaiement.AutoSize = False
		Me.RadDateTimePickerITEMS_DatePaiement.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerITEMS_DatePaiement.CustomFormat = "yyyy-MM-dd"
		Me.RadDateTimePickerITEMS_DatePaiement.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadDateTimePickerITEMS_DatePaiement.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.RadDateTimePickerITEMS_DatePaiement.Location = New System.Drawing.Point(119, 346)
		Me.RadDateTimePickerITEMS_DatePaiement.Name = "RadDateTimePickerITEMS_DatePaiement"
		Me.RadDateTimePickerITEMS_DatePaiement.Size = New System.Drawing.Size(150, 27)
		Me.RadDateTimePickerITEMS_DatePaiement.TabIndex = 70
		Me.RadDateTimePickerITEMS_DatePaiement.TabStop = False
		Me.RadDateTimePickerITEMS_DatePaiement.Text = "2024-01-11"
		Me.RadDateTimePickerITEMS_DatePaiement.ThemeName = "Office2019Gray"
		Me.RadDateTimePickerITEMS_DatePaiement.Value = New Date(2024, 1, 11, 0, 0, 0, 0)
		'
		'RadDateTimePickerITEMS_LAST_EDIT_DATE
		'
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.AutoSize = False
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.CustomFormat = "yyyy-MM-dd"
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Location = New System.Drawing.Point(119, 318)
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Name = "RadDateTimePickerITEMS_LAST_EDIT_DATE"
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Size = New System.Drawing.Size(150, 27)
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.TabIndex = 70
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.TabStop = False
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Text = "2024-01-11"
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.ThemeName = "Office2019Gray"
		Me.RadDateTimePickerITEMS_LAST_EDIT_DATE.Value = New Date(2024, 1, 11, 0, 0, 0, 0)
		'
		'RadSpinEditor_ITEMS_INDEX
		'
		Me.RadSpinEditor_ITEMS_INDEX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditor_ITEMS_INDEX.AutoSize = False
		Me.RadSpinEditor_ITEMS_INDEX.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditor_ITEMS_INDEX.Location = New System.Drawing.Point(119, 38)
		Me.RadSpinEditor_ITEMS_INDEX.Name = "RadSpinEditor_ITEMS_INDEX"
		Me.RadSpinEditor_ITEMS_INDEX.ReadOnly = True
		Me.RadSpinEditor_ITEMS_INDEX.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditor_ITEMS_INDEX.TabIndex = 69
		Me.RadSpinEditor_ITEMS_INDEX.ThemeName = "Office2019Gray"
		'
		'RadSpinEditor_INDEX
		'
		Me.RadSpinEditor_INDEX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditor_INDEX.AutoSize = False
		Me.RadSpinEditor_INDEX.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditor_INDEX.Location = New System.Drawing.Point(119, 10)
		Me.RadSpinEditor_INDEX.Name = "RadSpinEditor_INDEX"
		Me.RadSpinEditor_INDEX.ReadOnly = True
		Me.RadSpinEditor_INDEX.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditor_INDEX.TabIndex = 68
		Me.RadSpinEditor_INDEX.ThemeName = "Office2019Gray"
		'
		'RadSpinEditorITEMS_TAXE_VALUE
		'
		Me.RadSpinEditorITEMS_TAXE_VALUE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditorITEMS_TAXE_VALUE.AutoSize = False
		Me.RadSpinEditorITEMS_TAXE_VALUE.DecimalPlaces = 2
		Me.RadSpinEditorITEMS_TAXE_VALUE.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditorITEMS_TAXE_VALUE.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.RadSpinEditorITEMS_TAXE_VALUE.Location = New System.Drawing.Point(119, 262)
		Me.RadSpinEditorITEMS_TAXE_VALUE.Name = "RadSpinEditorITEMS_TAXE_VALUE"
		Me.RadSpinEditorITEMS_TAXE_VALUE.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditorITEMS_TAXE_VALUE.TabIndex = 67
		Me.RadSpinEditorITEMS_TAXE_VALUE.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.RadSpinEditorITEMS_TAXE_VALUE.ThemeName = "Office2019Gray"
		'
		'RadSpinEditor_MTTVA
		'
		Me.RadSpinEditor_MTTVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditor_MTTVA.AutoSize = False
		Me.RadSpinEditor_MTTVA.DecimalPlaces = 2
		Me.RadSpinEditor_MTTVA.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditor_MTTVA.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.RadSpinEditor_MTTVA.Location = New System.Drawing.Point(119, 234)
		Me.RadSpinEditor_MTTVA.Name = "RadSpinEditor_MTTVA"
		Me.RadSpinEditor_MTTVA.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditor_MTTVA.TabIndex = 67
		Me.RadSpinEditor_MTTVA.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.RadSpinEditor_MTTVA.ThemeName = "Office2019Gray"
		'
		'RadSpinEditorITEMS_TAXE
		'
		Me.RadSpinEditorITEMS_TAXE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditorITEMS_TAXE.AutoSize = False
		Me.RadSpinEditorITEMS_TAXE.DecimalPlaces = 2
		Me.RadSpinEditorITEMS_TAXE.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditorITEMS_TAXE.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.RadSpinEditorITEMS_TAXE.Location = New System.Drawing.Point(119, 206)
		Me.RadSpinEditorITEMS_TAXE.Name = "RadSpinEditorITEMS_TAXE"
		Me.RadSpinEditorITEMS_TAXE.NullableValue = New Decimal(New Integer() {2000, 0, 0, 131072})
		Me.RadSpinEditorITEMS_TAXE.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditorITEMS_TAXE.TabIndex = 66
		Me.RadSpinEditorITEMS_TAXE.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.RadSpinEditorITEMS_TAXE.ThemeName = "Office2019Gray"
		Me.RadSpinEditorITEMS_TAXE.Value = New Decimal(New Integer() {2000, 0, 0, 131072})
		'
		'RadSpinEditorITEMS_UNIT
		'
		Me.RadSpinEditorITEMS_UNIT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditorITEMS_UNIT.AutoSize = False
		Me.RadSpinEditorITEMS_UNIT.DecimalPlaces = 2
		Me.RadSpinEditorITEMS_UNIT.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditorITEMS_UNIT.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.RadSpinEditorITEMS_UNIT.Location = New System.Drawing.Point(119, 178)
		Me.RadSpinEditorITEMS_UNIT.Name = "RadSpinEditorITEMS_UNIT"
		Me.RadSpinEditorITEMS_UNIT.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditorITEMS_UNIT.TabIndex = 65
		Me.RadSpinEditorITEMS_UNIT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.RadSpinEditorITEMS_UNIT.ThemeName = "Office2019Gray"
		'
		'RadSpinEditorITEMS_QUANTITY
		'
		Me.RadSpinEditorITEMS_QUANTITY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditorITEMS_QUANTITY.AutoSize = False
		Me.RadSpinEditorITEMS_QUANTITY.DecimalPlaces = 2
		Me.RadSpinEditorITEMS_QUANTITY.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditorITEMS_QUANTITY.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.RadSpinEditorITEMS_QUANTITY.Location = New System.Drawing.Point(119, 150)
		Me.RadSpinEditorITEMS_QUANTITY.Name = "RadSpinEditorITEMS_QUANTITY"
		Me.RadSpinEditorITEMS_QUANTITY.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditorITEMS_QUANTITY.TabIndex = 64
		Me.RadSpinEditorITEMS_QUANTITY.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.RadSpinEditorITEMS_QUANTITY.ThemeName = "Office2019Gray"
		'
		'RadSpinEditorITEMS_MT_PAIEMENT
		'
		Me.RadSpinEditorITEMS_MT_PAIEMENT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadSpinEditorITEMS_MT_PAIEMENT.AutoSize = False
		Me.RadSpinEditorITEMS_MT_PAIEMENT.DecimalPlaces = 2
		Me.RadSpinEditorITEMS_MT_PAIEMENT.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		Me.RadSpinEditorITEMS_MT_PAIEMENT.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
		Me.RadSpinEditorITEMS_MT_PAIEMENT.Location = New System.Drawing.Point(119, 402)
		Me.RadSpinEditorITEMS_MT_PAIEMENT.Name = "RadSpinEditorITEMS_MT_PAIEMENT"
		Me.RadSpinEditorITEMS_MT_PAIEMENT.Size = New System.Drawing.Size(150, 27)
		Me.RadSpinEditorITEMS_MT_PAIEMENT.TabIndex = 63
		Me.RadSpinEditorITEMS_MT_PAIEMENT.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.RadSpinEditorITEMS_MT_PAIEMENT.ThemeName = "Office2019Gray"
		'
		'RadDropDownITEMS_PayeQui
		'
		Me.RadDropDownITEMS_PayeQui.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadDropDownITEMS_PayeQui.AutoSize = False
		Me.RadDropDownITEMS_PayeQui.DropDownAnimationEnabled = True
		Me.RadDropDownITEMS_PayeQui.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		RadListDataItem3.Text = "O"
		RadListDataItem3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		RadListDataItem4.Text = "N"
		RadListDataItem4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadDropDownITEMS_PayeQui.Items.Add(RadListDataItem3)
		Me.RadDropDownITEMS_PayeQui.Items.Add(RadListDataItem4)
		Me.RadDropDownITEMS_PayeQui.Location = New System.Drawing.Point(119, 374)
		Me.RadDropDownITEMS_PayeQui.Name = "RadDropDownITEMS_PayeQui"
		Me.RadDropDownITEMS_PayeQui.Size = New System.Drawing.Size(150, 27)
		Me.RadDropDownITEMS_PayeQui.TabIndex = 62
		Me.RadDropDownITEMS_PayeQui.ThemeName = "Office2019Gray"
		'
		'RadDropDownITEMS_CURRENCY
		'
		Me.RadDropDownITEMS_CURRENCY.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadDropDownITEMS_CURRENCY.AutoSize = False
		Me.RadDropDownITEMS_CURRENCY.DropDownAnimationEnabled = True
		Me.RadDropDownITEMS_CURRENCY.Font = New System.Drawing.Font("Segoe UI", 9.75!)
		RadListDataItem5.Text = "EURO"
		RadListDataItem5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		RadListDataItem6.Text = "$"
		RadListDataItem6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadDropDownITEMS_CURRENCY.Items.Add(RadListDataItem5)
		Me.RadDropDownITEMS_CURRENCY.Items.Add(RadListDataItem6)
		Me.RadDropDownITEMS_CURRENCY.Location = New System.Drawing.Point(119, 290)
		Me.RadDropDownITEMS_CURRENCY.Name = "RadDropDownITEMS_CURRENCY"
		Me.RadDropDownITEMS_CURRENCY.Size = New System.Drawing.Size(150, 27)
		Me.RadDropDownITEMS_CURRENCY.TabIndex = 62
		Me.RadDropDownITEMS_CURRENCY.ThemeName = "Office2019Gray"
		'
		'RadLabel13
		'
		Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel13.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel13.Location = New System.Drawing.Point(50, 433)
		Me.RadLabel13.Name = "RadLabel13"
		Me.RadLabel13.Size = New System.Drawing.Size(63, 21)
		Me.RadLabel13.TabIndex = 61
		Me.RadLabel13.Text = "Paie Qui :"
		Me.RadLabel13.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadTextBoxITEMS_PAYE_QUI
		'
		Me.RadTextBoxITEMS_PAYE_QUI.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadTextBoxITEMS_PAYE_QUI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_PAYE_QUI.Location = New System.Drawing.Point(119, 430)
		Me.RadTextBoxITEMS_PAYE_QUI.Name = "RadTextBoxITEMS_PAYE_QUI"
		Me.RadTextBoxITEMS_PAYE_QUI.ShowClearButton = True
		Me.RadTextBoxITEMS_PAYE_QUI.Size = New System.Drawing.Size(150, 24)
		Me.RadTextBoxITEMS_PAYE_QUI.TabIndex = 60
		Me.RadTextBoxITEMS_PAYE_QUI.Text = "FRENCH RERO"
		Me.RadTextBoxITEMS_PAYE_QUI.ThemeName = "Office2019Gray"
		'
		'RadLabel14
		'
		Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel14.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel14.Location = New System.Drawing.Point(51, 404)
		Me.RadLabel14.Name = "RadLabel14"
		Me.RadLabel14.Size = New System.Drawing.Size(64, 21)
		Me.RadLabel14.TabIndex = 59
		Me.RadLabel14.Text = "Mt. Payé :"
		Me.RadLabel14.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabelPayeOuPas
		'
		Me.RadLabelPayeOuPas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabelPayeOuPas.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabelPayeOuPas.Location = New System.Drawing.Point(47, 378)
		Me.RadLabelPayeOuPas.Name = "RadLabelPayeOuPas"
		Me.RadLabelPayeOuPas.Size = New System.Drawing.Size(70, 21)
		Me.RadLabelPayeOuPas.TabIndex = 57
		Me.RadLabelPayeOuPas.Text = "Payé O/N :"
		Me.RadLabelPayeOuPas.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabelDatePaiement
		'
		Me.RadLabelDatePaiement.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabelDatePaiement.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabelDatePaiement.Location = New System.Drawing.Point(11, 350)
		Me.RadLabelDatePaiement.Name = "RadLabelDatePaiement"
		Me.RadLabelDatePaiement.Size = New System.Drawing.Size(104, 21)
		Me.RadLabelDatePaiement.TabIndex = 55
		Me.RadLabelDatePaiement.Text = "Date  paiement :"
		Me.RadLabelDatePaiement.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel12
		'
		Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel12.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel12.Location = New System.Drawing.Point(23, 321)
		Me.RadLabel12.Name = "RadLabel12"
		Me.RadLabel12.Size = New System.Drawing.Size(92, 21)
		Me.RadLabel12.TabIndex = 53
		Me.RadLabel12.Text = "Date  Facture :"
		Me.RadLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel11
		'
		Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel11.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel11.Location = New System.Drawing.Point(46, 294)
		Me.RadLabel11.Name = "RadLabel11"
		Me.RadLabel11.Size = New System.Drawing.Size(67, 21)
		Me.RadLabel11.TabIndex = 53
		Me.RadLabel11.Text = "EURO / $ :"
		Me.RadLabel11.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel10
		'
		Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel10.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel10.Location = New System.Drawing.Point(57, 266)
		Me.RadLabel10.Name = "RadLabel10"
		Me.RadLabel10.Size = New System.Drawing.Size(58, 21)
		Me.RadLabel10.TabIndex = 53
		Me.RadLabel10.Text = "Mt TVA :"
		Me.RadLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel9
		'
		Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel9.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel9.Location = New System.Drawing.Point(35, 237)
		Me.RadLabel9.Name = "RadLabel9"
		Me.RadLabel9.Size = New System.Drawing.Size(79, 21)
		Me.RadLabel9.TabIndex = 53
		Me.RadLabel9.Text = "Total Items :"
		Me.RadLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel8
		'
		Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel8.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel8.Location = New System.Drawing.Point(46, 210)
		Me.RadLabel8.Name = "RadLabel8"
		Me.RadLabel8.Size = New System.Drawing.Size(69, 21)
		Me.RadLabel8.TabIndex = 53
		Me.RadLabel8.Text = "Taux TVA :"
		Me.RadLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel7
		'
		Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel7.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel7.Location = New System.Drawing.Point(69, 182)
		Me.RadLabel7.Name = "RadLabel7"
		Me.RadLabel7.Size = New System.Drawing.Size(43, 21)
		Me.RadLabel7.TabIndex = 53
		Me.RadLabel7.Text = "Px U. :"
		Me.RadLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel6
		'
		Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel6.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel6.Location = New System.Drawing.Point(50, 154)
		Me.RadLabel6.Name = "RadLabel6"
		Me.RadLabel6.Size = New System.Drawing.Size(65, 21)
		Me.RadLabel6.TabIndex = 53
		Me.RadLabel6.Text = "Quantité :"
		Me.RadLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel5
		'
		Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel5.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel5.Location = New System.Drawing.Point(62, 126)
		Me.RadLabel5.Name = "RadLabel5"
		Me.RadLabel5.Size = New System.Drawing.Size(51, 21)
		Me.RadLabel5.TabIndex = 53
		Me.RadLabel5.Text = "Parent :"
		Me.RadLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel4
		'
		Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel4.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel4.Location = New System.Drawing.Point(70, 98)
		Me.RadLabel4.Name = "RadLabel4"
		Me.RadLabel4.Size = New System.Drawing.Size(43, 21)
		Me.RadLabel4.TabIndex = 53
		Me.RadLabel4.Text = "Nom :"
		Me.RadLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel3
		'
		Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel3.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel3.Location = New System.Drawing.Point(61, 69)
		Me.RadLabel3.Name = "RadLabel3"
		Me.RadLabel3.Size = New System.Drawing.Size(55, 21)
		Me.RadLabel3.TabIndex = 53
		Me.RadLabel3.Text = "Famille :"
		Me.RadLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel2
		'
		Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel2.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel2.Location = New System.Drawing.Point(89, 41)
		Me.RadLabel2.Name = "RadLabel2"
		Me.RadLabel2.Size = New System.Drawing.Size(26, 21)
		Me.RadLabel2.TabIndex = 52
		Me.RadLabel2.Text = "ID :"
		Me.RadLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabel1
		'
		Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadLabel1.ImageAlignment = System.Drawing.ContentAlignment.MiddleRight
		Me.RadLabel1.Location = New System.Drawing.Point(71, 14)
		Me.RadLabel1.Name = "RadLabel1"
		Me.RadLabel1.Size = New System.Drawing.Size(46, 21)
		Me.RadLabel1.TabIndex = 51
		Me.RadLabel1.Text = "Index :"
		Me.RadLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadTextBoxITEMS_PARENT
		'
		Me.RadTextBoxITEMS_PARENT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadTextBoxITEMS_PARENT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_PARENT.Location = New System.Drawing.Point(119, 123)
		Me.RadTextBoxITEMS_PARENT.Name = "RadTextBoxITEMS_PARENT"
		Me.RadTextBoxITEMS_PARENT.ShowClearButton = True
		Me.RadTextBoxITEMS_PARENT.Size = New System.Drawing.Size(150, 24)
		Me.RadTextBoxITEMS_PARENT.TabIndex = 4
		Me.RadTextBoxITEMS_PARENT.Text = "_ROOT"
		Me.RadTextBoxITEMS_PARENT.ThemeName = "Office2019Gray"
		'
		'RadTextBoxITEMS_NAME
		'
		Me.RadTextBoxITEMS_NAME.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadTextBoxITEMS_NAME.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_NAME.Location = New System.Drawing.Point(119, 95)
		Me.RadTextBoxITEMS_NAME.Name = "RadTextBoxITEMS_NAME"
		Me.RadTextBoxITEMS_NAME.ShowClearButton = True
		Me.RadTextBoxITEMS_NAME.Size = New System.Drawing.Size(150, 24)
		Me.RadTextBoxITEMS_NAME.TabIndex = 3
		Me.RadTextBoxITEMS_NAME.Text = "ARROSAGE"
		Me.RadTextBoxITEMS_NAME.ThemeName = "Office2019Gray"
		'
		'RadTextBoxITEMS_CODE
		'
		Me.RadTextBoxITEMS_CODE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RadTextBoxITEMS_CODE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_CODE.Location = New System.Drawing.Point(119, 67)
		Me.RadTextBoxITEMS_CODE.Name = "RadTextBoxITEMS_CODE"
		Me.RadTextBoxITEMS_CODE.ShowClearButton = True
		Me.RadTextBoxITEMS_CODE.Size = New System.Drawing.Size(150, 24)
		Me.RadTextBoxITEMS_CODE.TabIndex = 2
		Me.RadTextBoxITEMS_CODE.Text = "LOYERS"
		Me.RadTextBoxITEMS_CODE.ThemeName = "Office2019Gray"
		'
		'GroupBoxMenuVertical
		'
		Me.GroupBoxMenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer))
		Me.GroupBoxMenuVertical.Location = New System.Drawing.Point(0, 0)
		Me.GroupBoxMenuVertical.Name = "GroupBoxMenuVertical"
		Me.GroupBoxMenuVertical.Size = New System.Drawing.Size(60, 852)
		Me.GroupBoxMenuVertical.TabIndex = 65
		'
		'paneMain
		'
		Me.paneMain.Controls.Add(Me.RadProgressBarExport)
		Me.paneMain.Controls.Add(Me.GroupBox1)
		Me.paneMain.Controls.Add(Me.ListBoxItemsParent)
		Me.paneMain.Controls.Add(Me.RadGridViewClassItemsListe)
		Me.paneMain.Controls.Add(Me.RadButtonItemsLevelOne)
		Me.paneMain.Controls.Add(Me.RadButtonGroupageRefhesh)
		Me.paneMain.Controls.Add(Me.RadPanelHaut)
		Me.paneMain.Controls.Add(Me.RadButtonGroupCancel)
		Me.paneMain.Controls.Add(Me.RadButtonGroupage)
		Me.paneMain.Controls.Add(Me.RadGridViewItems)
		Me.paneMain.Controls.Add(Me.RadListeiewProjectName)
		Me.paneMain.Controls.Add(Me.RadPanelTodaysAppointments)
		Me.paneMain.Location = New System.Drawing.Point(60, 0)
		Me.paneMain.Name = "paneMain"
		Me.paneMain.Size = New System.Drawing.Size(1554, 852)
		Me.paneMain.TabIndex = 66
		'
		'paneSettings
		'
		Me.paneSettings.Controls.Add(Me.ButtonNewProject)
		Me.paneSettings.Controls.Add(Me.ButtonDeleteProject)
		Me.paneSettings.Controls.Add(Me.ButtonUpdateProject)
		Me.paneSettings.Controls.Add(Me.RadGroupBox1)
		Me.paneSettings.Controls.Add(Me.RadGridViewProjectName)
		Me.paneSettings.Location = New System.Drawing.Point(1700, 0)
		Me.paneSettings.Name = "paneSettings"
		Me.paneSettings.Size = New System.Drawing.Size(1545, 845)
		Me.paneSettings.TabIndex = 67
		'
		'ButtonNewProject
		'
		Me.ButtonNewProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonNewProject.Location = New System.Drawing.Point(1102, 571)
		Me.ButtonNewProject.Name = "ButtonNewProject"
		Me.ButtonNewProject.Size = New System.Drawing.Size(60, 29)
		Me.ButtonNewProject.TabIndex = 62
		Me.ButtonNewProject.Text = "Add"
		Me.ButtonNewProject.UseVisualStyleBackColor = True
		'
		'ButtonDeleteProject
		'
		Me.ButtonDeleteProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonDeleteProject.Location = New System.Drawing.Point(1302, 571)
		Me.ButtonDeleteProject.Name = "ButtonDeleteProject"
		Me.ButtonDeleteProject.Size = New System.Drawing.Size(60, 29)
		Me.ButtonDeleteProject.TabIndex = 61
		Me.ButtonDeleteProject.Text = "Delete"
		Me.ButtonDeleteProject.UseVisualStyleBackColor = True
		'
		'ButtonUpdateProject
		'
		Me.ButtonUpdateProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonUpdateProject.Location = New System.Drawing.Point(1202, 571)
		Me.ButtonUpdateProject.Name = "ButtonUpdateProject"
		Me.ButtonUpdateProject.Size = New System.Drawing.Size(60, 29)
		Me.ButtonUpdateProject.TabIndex = 60
		Me.ButtonUpdateProject.Text = "Update"
		Me.ButtonUpdateProject.UseVisualStyleBackColor = True
		'
		'RadGroupBox1
		'
		Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
		Me.RadGroupBox1.Controls.Add(Me.RadLabel27)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel26)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel25)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel24)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel23)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel22)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel21)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel20)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel19)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel18)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel17)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel16)
		Me.RadGroupBox1.Controls.Add(Me.RadLabel15)
		Me.RadGroupBox1.Controls.Add(Me.RadSpinEditorIndex)
		Me.RadGroupBox1.Controls.Add(Me.RadSpinEditorProjectIndex)
		Me.RadGroupBox1.Controls.Add(Me.RadTextBoxProjectCode)
		Me.RadGroupBox1.Controls.Add(Me.RadTextBoxProjectName)
		Me.RadGroupBox1.Controls.Add(Me.RadDateTimePickerCreateDate)
		Me.RadGroupBox1.Controls.Add(Me.RadDateTimePickerModifyDate)
		Me.RadGroupBox1.Controls.Add(Me.RadTextBoxProjectStatus)
		Me.RadGroupBox1.Controls.Add(Me.RadTextBoxProjectDataPath)
		Me.RadGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(1)
		Me.RadGroupBox1.HeaderText = ""
		Me.RadGroupBox1.Location = New System.Drawing.Point(1042, 142)
		Me.RadGroupBox1.Name = "RadGroupBox1"
		Me.RadGroupBox1.Size = New System.Drawing.Size(375, 390)
		Me.RadGroupBox1.TabIndex = 59
		'
		'RadLabel27
		'
		Me.RadLabel27.Location = New System.Drawing.Point(17, 336)
		Me.RadLabel27.Name = "RadLabel27"
		Me.RadLabel27.Size = New System.Drawing.Size(148, 18)
		Me.RadLabel27.TabIndex = 20
		Me.RadLabel27.Text = "PROJECT_DATA_PATHNAME"
		'
		'RadLabel26
		'
		Me.RadLabel26.Location = New System.Drawing.Point(17, 336)
		Me.RadLabel26.Name = "RadLabel26"
		Me.RadLabel26.Size = New System.Drawing.Size(38, 18)
		Me.RadLabel26.TabIndex = 20
		Me.RadLabel26.Text = "INDEX"
		'
		'RadLabel25
		'
		Me.RadLabel25.Location = New System.Drawing.Point(17, 291)
		Me.RadLabel25.Name = "RadLabel25"
		Me.RadLabel25.Size = New System.Drawing.Size(94, 18)
		Me.RadLabel25.TabIndex = 20
		Me.RadLabel25.Text = "PROJECT_STATUS"
		'
		'RadLabel24
		'
		Me.RadLabel24.Location = New System.Drawing.Point(17, 291)
		Me.RadLabel24.Name = "RadLabel24"
		Me.RadLabel24.Size = New System.Drawing.Size(38, 18)
		Me.RadLabel24.TabIndex = 20
		Me.RadLabel24.Text = "INDEX"
		'
		'RadLabel23
		'
		Me.RadLabel23.Location = New System.Drawing.Point(17, 248)
		Me.RadLabel23.Name = "RadLabel23"
		Me.RadLabel23.Size = New System.Drawing.Size(128, 18)
		Me.RadLabel23.TabIndex = 20
		Me.RadLabel23.Text = "PROJECT_MODIFY_DATE"
		'
		'RadLabel22
		'
		Me.RadLabel22.Location = New System.Drawing.Point(17, 248)
		Me.RadLabel22.Name = "RadLabel22"
		Me.RadLabel22.Size = New System.Drawing.Size(38, 18)
		Me.RadLabel22.TabIndex = 20
		Me.RadLabel22.Text = "INDEX"
		'
		'RadLabel21
		'
		Me.RadLabel21.Location = New System.Drawing.Point(17, 205)
		Me.RadLabel21.Name = "RadLabel21"
		Me.RadLabel21.Size = New System.Drawing.Size(120, 18)
		Me.RadLabel21.TabIndex = 20
		Me.RadLabel21.Text = "PROJECT_CREAT_DATE"
		'
		'RadLabel20
		'
		Me.RadLabel20.Location = New System.Drawing.Point(17, 205)
		Me.RadLabel20.Name = "RadLabel20"
		Me.RadLabel20.Size = New System.Drawing.Size(38, 18)
		Me.RadLabel20.TabIndex = 20
		Me.RadLabel20.Text = "INDEX"
		'
		'RadLabel19
		'
		Me.RadLabel19.Location = New System.Drawing.Point(17, 162)
		Me.RadLabel19.Name = "RadLabel19"
		Me.RadLabel19.Size = New System.Drawing.Size(87, 18)
		Me.RadLabel19.TabIndex = 20
		Me.RadLabel19.Text = "PROJECT_NAME"
		'
		'RadLabel18
		'
		Me.RadLabel18.Location = New System.Drawing.Point(17, 119)
		Me.RadLabel18.Name = "RadLabel18"
		Me.RadLabel18.Size = New System.Drawing.Size(84, 18)
		Me.RadLabel18.TabIndex = 20
		Me.RadLabel18.Text = "PROJECT_CODE"
		'
		'RadLabel17
		'
		Me.RadLabel17.Location = New System.Drawing.Point(17, 119)
		Me.RadLabel17.Name = "RadLabel17"
		Me.RadLabel17.Size = New System.Drawing.Size(38, 18)
		Me.RadLabel17.TabIndex = 20
		Me.RadLabel17.Text = "INDEX"
		'
		'RadLabel16
		'
		Me.RadLabel16.Location = New System.Drawing.Point(17, 77)
		Me.RadLabel16.Name = "RadLabel16"
		Me.RadLabel16.Size = New System.Drawing.Size(87, 18)
		Me.RadLabel16.TabIndex = 19
		Me.RadLabel16.Text = "PROJECT_INDEX"
		'
		'RadLabel15
		'
		Me.RadLabel15.Location = New System.Drawing.Point(17, 35)
		Me.RadLabel15.Name = "RadLabel15"
		Me.RadLabel15.Size = New System.Drawing.Size(38, 18)
		Me.RadLabel15.TabIndex = 18
		Me.RadLabel15.Text = "INDEX"
		'
		'RadSpinEditorIndex
		'
		Me.RadSpinEditorIndex.Location = New System.Drawing.Point(170, 33)
		Me.RadSpinEditorIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorIndex.Name = "RadSpinEditorIndex"
		Me.RadSpinEditorIndex.ReadOnly = True
		Me.RadSpinEditorIndex.Size = New System.Drawing.Size(189, 24)
		Me.RadSpinEditorIndex.TabIndex = 10
		Me.RadSpinEditorIndex.TabStop = False
		'
		'RadSpinEditorProjectIndex
		'
		Me.RadSpinEditorProjectIndex.Location = New System.Drawing.Point(170, 76)
		Me.RadSpinEditorProjectIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorProjectIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorProjectIndex.Name = "RadSpinEditorProjectIndex"
		Me.RadSpinEditorProjectIndex.ReadOnly = True
		Me.RadSpinEditorProjectIndex.Size = New System.Drawing.Size(189, 24)
		Me.RadSpinEditorProjectIndex.TabIndex = 11
		Me.RadSpinEditorProjectIndex.TabStop = False
		'
		'RadTextBoxProjectCode
		'
		Me.RadTextBoxProjectCode.Location = New System.Drawing.Point(170, 119)
		Me.RadTextBoxProjectCode.Name = "RadTextBoxProjectCode"
		Me.RadTextBoxProjectCode.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectCode.TabIndex = 12
		'
		'RadTextBoxProjectName
		'
		Me.RadTextBoxProjectName.Location = New System.Drawing.Point(170, 162)
		Me.RadTextBoxProjectName.Name = "RadTextBoxProjectName"
		Me.RadTextBoxProjectName.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectName.TabIndex = 13
		'
		'RadDateTimePickerCreateDate
		'
		Me.RadDateTimePickerCreateDate.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerCreateDate.Location = New System.Drawing.Point(170, 205)
		Me.RadDateTimePickerCreateDate.Name = "RadDateTimePickerCreateDate"
		Me.RadDateTimePickerCreateDate.ReadOnly = True
		Me.RadDateTimePickerCreateDate.Size = New System.Drawing.Size(189, 24)
		Me.RadDateTimePickerCreateDate.TabIndex = 14
		Me.RadDateTimePickerCreateDate.TabStop = False
		Me.RadDateTimePickerCreateDate.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePickerCreateDate.Value = New Date(2019, 6, 13, 10, 21, 40, 502)
		'
		'RadDateTimePickerModifyDate
		'
		Me.RadDateTimePickerModifyDate.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerModifyDate.Location = New System.Drawing.Point(170, 248)
		Me.RadDateTimePickerModifyDate.Name = "RadDateTimePickerModifyDate"
		Me.RadDateTimePickerModifyDate.ReadOnly = True
		Me.RadDateTimePickerModifyDate.Size = New System.Drawing.Size(189, 24)
		Me.RadDateTimePickerModifyDate.TabIndex = 15
		Me.RadDateTimePickerModifyDate.TabStop = False
		Me.RadDateTimePickerModifyDate.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePickerModifyDate.Value = New Date(2019, 6, 13, 10, 21, 40, 550)
		'
		'RadTextBoxProjectStatus
		'
		Me.RadTextBoxProjectStatus.Location = New System.Drawing.Point(170, 291)
		Me.RadTextBoxProjectStatus.Name = "RadTextBoxProjectStatus"
		Me.RadTextBoxProjectStatus.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectStatus.TabIndex = 16
		'
		'RadTextBoxProjectDataPath
		'
		Me.RadTextBoxProjectDataPath.Location = New System.Drawing.Point(170, 336)
		Me.RadTextBoxProjectDataPath.Name = "RadTextBoxProjectDataPath"
		Me.RadTextBoxProjectDataPath.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectDataPath.TabIndex = 17
		'
		'RadGridViewProjectName
		'
		Me.RadGridViewProjectName.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically
		Me.RadGridViewProjectName.Location = New System.Drawing.Point(105, 102)
		'
		'
		'
		Me.RadGridViewProjectName.MasterTemplate.AllowAddNewRow = False
		Me.RadGridViewProjectName.MasterTemplate.AllowSearchRow = True
		Me.RadGridViewProjectName.MasterTemplate.EnableAlternatingRowColor = True
		Me.RadGridViewProjectName.MasterTemplate.ShowRowHeaderColumn = False
		Me.RadGridViewProjectName.MasterTemplate.ViewDefinition = TableViewDefinition15
		Me.RadGridViewProjectName.Name = "RadGridViewProjectName"
		Me.RadGridViewProjectName.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.None
		Me.RadGridViewProjectName.Size = New System.Drawing.Size(879, 556)
		Me.RadGridViewProjectName.TabIndex = 1
		Me.RadGridViewProjectName.ThemeName = "Office2019Gray"
		'
		'RadProgressBarExport
		'
		Me.RadProgressBarExport.Location = New System.Drawing.Point(1087, 571)
		Me.RadProgressBarExport.Name = "RadProgressBarExport"
		Me.RadProgressBarExport.ShowProgressIndicators = True
		Me.RadProgressBarExport.Size = New System.Drawing.Size(130, 24)
		Me.RadProgressBarExport.TabIndex = 64
		Me.RadProgressBarExport.Text = "0 %"
		Me.RadProgressBarExport.ThemeName = "Office2019Gray"
		Me.RadProgressBarExport.Visible = False
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1614, 881)
		Me.Controls.Add(Me.paneSettings)
		Me.Controls.Add(Me.paneMain)
		Me.Controls.Add(Me.GroupBoxMenuVertical)
		Me.Controls.Add(Me.RadStatusStrip2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "MainForm"
		Me.Text = "PrevisionFlex software 1.0"
		CType(Me.RadPanelTodaysAppointments, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadPanelTodaysAppointments.ResumeLayout(False)
		Me.RadPanelTodaysAppointments.PerformLayout()
		CType(Me.RadLabelMTPaye, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelAllTotalOfItems, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelLastAppointmentToday, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelTotalEstimation, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelCurrentItems, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadListeiewProjectName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadPanelHaut, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadPanelHaut.ResumeLayout(False)
		Me.RadPanelHaut.PerformLayout()
		CType(Me.RadBtnExportExcel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadBtnExportPDF, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadcmbTypeCharge, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerMonth, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelGlobalCathegory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelProjectNameGlobal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadCheckBoxFF, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewClassItemsListe.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewClassItemsListe, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonItemsLevelOne, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonGroupageRefhesh, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonGroupCancel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonGroupage, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.RadDateTimePickerITEMS_DatePaiement, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerITEMS_LAST_EDIT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor_ITEMS_INDEX, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor_INDEX, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorITEMS_TAXE_VALUE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor_MTTVA, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorITEMS_TAXE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorITEMS_UNIT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorITEMS_QUANTITY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorITEMS_MT_PAIEMENT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDropDownITEMS_PayeQui, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDropDownITEMS_CURRENCY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_PAYE_QUI, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelPayeOuPas, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelDatePaiement, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_PARENT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_NAME, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_CODE, System.ComponentModel.ISupportInitialize).EndInit()
		Me.paneMain.ResumeLayout(False)
		Me.paneSettings.ResumeLayout(False)
		CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadGroupBox1.ResumeLayout(False)
		Me.RadGroupBox1.PerformLayout()
		CType(Me.RadLabel27, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel26, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel25, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel23, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel21, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerCreateDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerModifyDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectStatus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectDataPath, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewProjectName.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewProjectName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadProgressBarExport, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Private WithEvents RadPanelTodaysAppointments As Telerik.WinControls.UI.RadPanel
	Private WithEvents RadLabelAllTotalOfItems As Telerik.WinControls.UI.RadLabel
	Private WithEvents RadLabelLastAppointmentToday As Telerik.WinControls.UI.RadLabel
	Private WithEvents RadLabelTotalEstimation As Telerik.WinControls.UI.RadLabel
	Private WithEvents RadLabelCurrentItems As Telerik.WinControls.UI.RadLabel
	Private WithEvents RadListeiewProjectName As Telerik.WinControls.UI.RadListView
	Friend WithEvents ListBoxItemsParent As ListBox
	Friend WithEvents RadStatusStrip2 As RadStatusStrip
	Friend WithEvents RadLabelElementMessage As RadLabelElement
	Friend WithEvents RadPanelHaut As RadPanel
	Friend WithEvents RadLabelGlobalCathegory As RadLabel
	Friend WithEvents RadLabelProjectNameGlobal As RadLabel
	Friend WithEvents ButtonGridviewUpdate As Button
	Friend WithEvents ButtonGridviewDelete As Button
	Friend WithEvents ButtonGridviewNew As Button
	Friend WithEvents RadGridViewItems As RadGridView
	Friend WithEvents RadButtonGroupCancel As RadButton
	Friend WithEvents RadButtonGroupage As RadButton
	Friend WithEvents RadButtonGroupageRefhesh As RadButton
	Friend WithEvents RadButtonItemsLevelOne As RadButton
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents RadTextBoxITEMS_PARENT As RadTextBox
	Friend WithEvents RadTextBoxITEMS_NAME As RadTextBox
	Friend WithEvents RadTextBoxITEMS_CODE As RadTextBox
	Private WithEvents RadLabelMTPaye As RadLabel
	Friend WithEvents RadLabel1 As RadLabel
	Friend WithEvents RadLabel2 As RadLabel
	Friend WithEvents RadLabel12 As RadLabel
	Friend WithEvents RadLabel11 As RadLabel
	Friend WithEvents RadLabel10 As RadLabel
	Friend WithEvents RadLabel9 As RadLabel
	Friend WithEvents RadLabel8 As RadLabel
	Friend WithEvents RadLabel7 As RadLabel
	Friend WithEvents RadLabel6 As RadLabel
	Friend WithEvents RadLabel5 As RadLabel
	Friend WithEvents RadLabel4 As RadLabel
	Friend WithEvents RadLabel3 As RadLabel
	Friend WithEvents RadLabel13 As RadLabel
	Friend WithEvents RadTextBoxITEMS_PAYE_QUI As RadTextBox
	Friend WithEvents RadLabel14 As RadLabel
	Friend WithEvents RadLabelPayeOuPas As RadLabel
	Friend WithEvents RadLabelDatePaiement As RadLabel
	Friend WithEvents RadGridViewClassItemsListe As RadGridView
	Friend WithEvents RadCheckBoxFF As RadCheckBox
	Friend WithEvents GroupBoxMenuVertical As Panel
	Friend WithEvents paneMain As Panel
	Friend WithEvents RadDateTimePickerMonth As RadDateTimePicker
	Friend WithEvents RadcmbTypeCharge As RadDropDownList
	Friend WithEvents RadBtnExportExcel As RadButton
	Friend WithEvents RadBtnExportPDF As RadButton
	Friend WithEvents paneSettings As Panel
	Friend WithEvents RadGridViewProjectName As RadGridView
	Friend WithEvents RadGroupBox1 As RadGroupBox
	Friend WithEvents RadSpinEditorIndex As RadSpinEditor
	Friend WithEvents RadSpinEditorProjectIndex As RadSpinEditor
	Friend WithEvents RadTextBoxProjectCode As RadTextBox
	Friend WithEvents RadTextBoxProjectName As RadTextBox
	Friend WithEvents RadDateTimePickerCreateDate As RadDateTimePicker
	Friend WithEvents RadDateTimePickerModifyDate As RadDateTimePicker
	Friend WithEvents RadTextBoxProjectStatus As RadTextBox
	Friend WithEvents RadTextBoxProjectDataPath As RadTextBox
	Friend WithEvents ButtonNewProject As Button
	Friend WithEvents ButtonDeleteProject As Button
	Friend WithEvents ButtonUpdateProject As Button
	Friend WithEvents RadLabel27 As RadLabel
	Friend WithEvents RadLabel26 As RadLabel
	Friend WithEvents RadLabel25 As RadLabel
	Friend WithEvents RadLabel24 As RadLabel
	Friend WithEvents RadLabel23 As RadLabel
	Friend WithEvents RadLabel22 As RadLabel
	Friend WithEvents RadLabel21 As RadLabel
	Friend WithEvents RadLabel20 As RadLabel
	Friend WithEvents RadLabel19 As RadLabel
	Friend WithEvents RadLabel18 As RadLabel
	Friend WithEvents RadLabel17 As RadLabel
	Friend WithEvents RadLabel16 As RadLabel
	Friend WithEvents RadLabel15 As RadLabel
	Friend WithEvents RadDropDownITEMS_CURRENCY As RadDropDownList
	Friend WithEvents RadDropDownITEMS_PayeQui As RadDropDownList
	Friend WithEvents RadSpinEditorITEMS_MT_PAIEMENT As RadSpinEditor
	Friend WithEvents RadSpinEditorITEMS_QUANTITY As RadSpinEditor
	Friend WithEvents RadSpinEditorITEMS_UNIT As RadSpinEditor
	Friend WithEvents RadSpinEditorITEMS_TAXE As RadSpinEditor
	Friend WithEvents RadSpinEditor_MTTVA As RadSpinEditor
	Friend WithEvents RadSpinEditorITEMS_TAXE_VALUE As RadSpinEditor
	Friend WithEvents RadSpinEditor_INDEX As RadSpinEditor
	Friend WithEvents RadSpinEditor_ITEMS_INDEX As RadSpinEditor
	Friend WithEvents RadDateTimePickerITEMS_LAST_EDIT_DATE As RadDateTimePicker
	Friend WithEvents RadDateTimePickerITEMS_DatePaiement As RadDateTimePicker
	Friend WithEvents RadProgressBarExport As RadProgressBar
	Friend WithEvents Office2019GrayTheme1 As Themes.Office2019GrayTheme
End Class
