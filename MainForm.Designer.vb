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
		Dim ListViewDetailColumn5 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "Name")
		Dim ListViewDetailColumn6 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Age")
		Dim ListViewDetailColumn7 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Gender")
		Dim ListViewDetailColumn8 As Telerik.WinControls.UI.ListViewDetailColumn = New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "EncounterTime")
		Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Dim TableViewDefinition4 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Me.radPanelTodaysAppointments = New Telerik.WinControls.UI.RadPanel()
		Me.RadLabelMTPaye = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelAllTotalOfItems = New Telerik.WinControls.UI.RadLabel()
		Me.radLabelLastAppointmentToday = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelTotalEstimation = New Telerik.WinControls.UI.RadLabel()
		Me.radLabelCurrentItems = New Telerik.WinControls.UI.RadLabel()
		Me.RadListeiewProjectName = New Telerik.WinControls.UI.RadListView()
		Me.ListBoxItemsParent = New System.Windows.Forms.ListBox()
		Me.RadStatusStrip2 = New Telerik.WinControls.UI.RadStatusStrip()
		Me.RadLabelElementMessage = New Telerik.WinControls.UI.RadLabelElement()
		Me.RadPanelHaut = New Telerik.WinControls.UI.RadPanel()
		Me.RadLabelDayEnd = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelDaySart = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelGlobalCathegory = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelProjectNameGlobal = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelCentreNameGlobal = New Telerik.WinControls.UI.RadLabel()
		Me.RadSpinEditorIndexKey = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorItemIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorProjectIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBoxItemsCode = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxItemName = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxParent_Items = New Telerik.WinControls.UI.RadTextBox()
		Me.RadSpinEditorQuantity = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorUnitQuantity = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorUnitPrice = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorTotalPrice = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorVATPorucent = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorVATValue = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBoxCurrency = New Telerik.WinControls.UI.RadTextBox()
		Me.ButtonGridviewUpdate = New System.Windows.Forms.Button()
		Me.ButtonGridviewDelete = New System.Windows.Forms.Button()
		Me.ButtonGridviewNew = New System.Windows.Forms.Button()
		Me.GroupBoxItemMainForm = New System.Windows.Forms.GroupBox()
		Me.CheckedListBoxTypeCharge = New System.Windows.Forms.CheckedListBox()
		Me.RadCheckBoxFF = New Telerik.WinControls.UI.RadCheckBox()
		Me.RadGridViewClassItemsListe = New Telerik.WinControls.UI.RadGridView()
		Me.RadButtonItemsLevelOne = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonGroupageRefhesh = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonGroupCancel = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonGroupage = New Telerik.WinControls.UI.RadButton()
		Me.RadGridViewItems = New Telerik.WinControls.UI.RadGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
		Me.RadTextBoxITEMS_PAYE_QUI = New Telerik.WinControls.UI.RadTextBox()
		Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
		Me.RadTextBoxITEMS_MT_PAIEMENT = New Telerik.WinControls.UI.RadTextBox()
		Me.RadLabelPayeOuPas = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelDatePaiement = New Telerik.WinControls.UI.RadLabel()
		Me.RadTextBoxITEMS_PayeQui = New Telerik.WinControls.UI.RadTextBox()
		Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
		Me.RadTextBoxITEMS_DatePaiement = New Telerik.WinControls.UI.RadTextBox()
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
		Me.RadTextBoxITEMS_LAST_EDIT_DATE = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_CURRENCY = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBox_MTTVA = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_TAXE_VALUE = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_TAXE = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_UNIT = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_QUANTITY = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_PARENT = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_NAME = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxITEMS_CODE = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBox_ITEMS_INDEX = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBox_INDEX = New Telerik.WinControls.UI.RadTextBox()
		Me.RadSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorProjectIndex2 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxProjectMainFormStatus = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxProjectMainFormPathName = New Telerik.WinControls.UI.RadTextBox()
		Me.GroupBoxMenuVertical = New System.Windows.Forms.Panel()
		CType(Me.radPanelTodaysAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.radPanelTodaysAppointments.SuspendLayout()
		CType(Me.RadLabelMTPaye, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelAllTotalOfItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.radLabelLastAppointmentToday, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelTotalEstimation, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.radLabelCurrentItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadListeiewProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadPanelHaut, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadPanelHaut.SuspendLayout()
		CType(Me.RadLabelDayEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelDaySart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelGlobalCathegory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelProjectNameGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelCentreNameGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorIndexKey, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorItemIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxItemsCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxItemName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxParent_Items, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorUnitQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorUnitPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorTotalPrice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorVATPorucent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorVATValue, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxCurrency, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBoxItemMainForm.SuspendLayout()
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
		CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_PAYE_QUI, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_MT_PAIEMENT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelPayeOuPas, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelDatePaiement, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_PayeQui, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_DatePaiement, System.ComponentModel.ISupportInitialize).BeginInit()
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
		CType(Me.RadTextBoxITEMS_LAST_EDIT_DATE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_CURRENCY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox_MTTVA, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_TAXE_VALUE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_TAXE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_UNIT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_QUANTITY, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_PARENT, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_NAME, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxITEMS_CODE, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox_ITEMS_INDEX, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox_INDEX, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorProjectIndex2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectMainFormStatus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectMainFormPathName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'radPanelTodaysAppointments
		'
		Me.radPanelTodaysAppointments.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.radPanelTodaysAppointments.Controls.Add(Me.RadLabelMTPaye)
		Me.radPanelTodaysAppointments.Controls.Add(Me.RadLabelAllTotalOfItems)
		Me.radPanelTodaysAppointments.Controls.Add(Me.radLabelLastAppointmentToday)
		Me.radPanelTodaysAppointments.Controls.Add(Me.RadLabelTotalEstimation)
		Me.radPanelTodaysAppointments.Controls.Add(Me.radLabelCurrentItems)
		Me.radPanelTodaysAppointments.Location = New System.Drawing.Point(260, 530)
		Me.radPanelTodaysAppointments.Name = "radPanelTodaysAppointments"
		'
		'
		'
		Me.radPanelTodaysAppointments.RootElement.ControlBounds = New System.Drawing.Rectangle(260, 530, 200, 100)
		Me.radPanelTodaysAppointments.Size = New System.Drawing.Size(300, 276)
		Me.radPanelTodaysAppointments.TabIndex = 9
		Me.radPanelTodaysAppointments.ThemeName = "MedicalAppTheme"
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
		Me.RadLabelMTPaye.Size = New System.Drawing.Size(53, 38)
		Me.RadLabelMTPaye.TabIndex = 2
		Me.RadLabelMTPaye.Text = "25"
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
		'radLabelLastAppointmentToday
		'
		Me.radLabelLastAppointmentToday.BackColor = System.Drawing.Color.Transparent
		Me.radLabelLastAppointmentToday.Font = New System.Drawing.Font("Segoe UI", 12.25!)
		Me.radLabelLastAppointmentToday.Location = New System.Drawing.Point(14, 242)
		Me.radLabelLastAppointmentToday.Name = "radLabelLastAppointmentToday"
		'
		'
		'
		Me.radLabelLastAppointmentToday.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 242, 100, 18)
		Me.radLabelLastAppointmentToday.Size = New System.Drawing.Size(150, 26)
		Me.radLabelLastAppointmentToday.TabIndex = 1
		Me.radLabelLastAppointmentToday.Text = "last one at 5:00 PM"
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
		Me.RadLabelTotalEstimation.Size = New System.Drawing.Size(80, 67)
		Me.RadLabelTotalEstimation.TabIndex = 1
		Me.RadLabelTotalEstimation.Text = "25"
		Me.RadLabelTotalEstimation.UseCompatibleTextRendering = False
		'
		'radLabelCurrentItems
		'
		Me.radLabelCurrentItems.BackColor = System.Drawing.Color.Transparent
		Me.radLabelCurrentItems.Font = New System.Drawing.Font("Segoe UI Light", 14.5!)
		Me.radLabelCurrentItems.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(79, Byte), Integer))
		Me.radLabelCurrentItems.Location = New System.Drawing.Point(14, 12)
		Me.radLabelCurrentItems.Name = "radLabelCurrentItems"
		'
		'
		'
		Me.radLabelCurrentItems.RootElement.ControlBounds = New System.Drawing.Rectangle(14, 12, 100, 18)
		Me.radLabelCurrentItems.Size = New System.Drawing.Size(71, 30)
		Me.radLabelCurrentItems.TabIndex = 0
		Me.radLabelCurrentItems.Text = "TODAY"
		'
		'RadListeiewProjectName
		'
		Me.RadListeiewProjectName.AllowArbitraryItemHeight = True
		Me.RadListeiewProjectName.AllowEdit = False
		Me.RadListeiewProjectName.AllowRemove = False
		Me.RadListeiewProjectName.AutoScroll = True
		Me.RadListeiewProjectName.BackColor = System.Drawing.SystemColors.ControlLightLight
		ListViewDetailColumn5.HeaderText = "Name"
		ListViewDetailColumn6.HeaderText = "Age"
		ListViewDetailColumn7.HeaderText = "Gender"
		ListViewDetailColumn8.HeaderText = "EncounterTime"
		Me.RadListeiewProjectName.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {ListViewDetailColumn5, ListViewDetailColumn6, ListViewDetailColumn7, ListViewDetailColumn8})
		Me.RadListeiewProjectName.ItemSize = New System.Drawing.Size(200, 95)
		Me.RadListeiewProjectName.Location = New System.Drawing.Point(5, 530)
		Me.RadListeiewProjectName.Name = "RadListeiewProjectName"
		'
		'
		'
		Me.RadListeiewProjectName.RootElement.ControlBounds = New System.Drawing.Rectangle(5, 530, 120, 95)
		Me.RadListeiewProjectName.SelectLastAddedItem = False
		Me.RadListeiewProjectName.Size = New System.Drawing.Size(250, 276)
		Me.RadListeiewProjectName.TabIndex = 10
		Me.RadListeiewProjectName.ThemeName = "MedicalAppTheme"
		Me.RadListeiewProjectName.VerticalScrollState = Telerik.WinControls.UI.ScrollState.AlwaysHide
		'
		'ListBoxItemsParent
		'
		Me.ListBoxItemsParent.FormattingEnabled = True
		Me.ListBoxItemsParent.Location = New System.Drawing.Point(1265, 567)
		Me.ListBoxItemsParent.Name = "ListBoxItemsParent"
		Me.ListBoxItemsParent.Size = New System.Drawing.Size(270, 238)
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
		Me.RadPanelHaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(200, Byte), Integer))
		Me.RadPanelHaut.Controls.Add(Me.RadLabelDayEnd)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelDaySart)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelGlobalCathegory)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelProjectNameGlobal)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelCentreNameGlobal)
		Me.RadPanelHaut.Location = New System.Drawing.Point(0, 0)
		Me.RadPanelHaut.Name = "RadPanelHaut"
		'
		'
		'
		Me.RadPanelHaut.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 200, 100)
		Me.RadPanelHaut.Size = New System.Drawing.Size(1620, 35)
		Me.RadPanelHaut.TabIndex = 46
		'
		'RadLabelDayEnd
		'
		Me.RadLabelDayEnd.AutoSize = False
		Me.RadLabelDayEnd.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelDayEnd.ForeColor = System.Drawing.Color.White
		Me.RadLabelDayEnd.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelDayEnd.Location = New System.Drawing.Point(1320, 5)
		Me.RadLabelDayEnd.Name = "RadLabelDayEnd"
		'
		'
		'
		Me.RadLabelDayEnd.RootElement.ControlBounds = New System.Drawing.Rectangle(1320, 5, 100, 18)
		Me.RadLabelDayEnd.Size = New System.Drawing.Size(200, 25)
		Me.RadLabelDayEnd.TabIndex = 47
		Me.RadLabelDayEnd.Text = "RadLabel35"
		'
		'RadLabelDaySart
		'
		Me.RadLabelDaySart.AutoSize = False
		Me.RadLabelDaySart.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelDaySart.ForeColor = System.Drawing.Color.White
		Me.RadLabelDaySart.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelDaySart.Location = New System.Drawing.Point(1100, 5)
		Me.RadLabelDaySart.Name = "RadLabelDaySart"
		'
		'
		'
		Me.RadLabelDaySart.RootElement.ControlBounds = New System.Drawing.Rectangle(1100, 5, 100, 18)
		Me.RadLabelDaySart.Size = New System.Drawing.Size(200, 25)
		Me.RadLabelDaySart.TabIndex = 46
		Me.RadLabelDaySart.Text = "RadLabel35"
		'
		'RadLabelGlobalCathegory
		'
		Me.RadLabelGlobalCathegory.AutoSize = False
		Me.RadLabelGlobalCathegory.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelGlobalCathegory.ForeColor = System.Drawing.Color.White
		Me.RadLabelGlobalCathegory.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelGlobalCathegory.Location = New System.Drawing.Point(520, 5)
		Me.RadLabelGlobalCathegory.Name = "RadLabelGlobalCathegory"
		'
		'
		'
		Me.RadLabelGlobalCathegory.RootElement.ControlBounds = New System.Drawing.Rectangle(520, 5, 100, 18)
		Me.RadLabelGlobalCathegory.Size = New System.Drawing.Size(240, 25)
		Me.RadLabelGlobalCathegory.TabIndex = 45
		Me.RadLabelGlobalCathegory.Text = "RadLabelGlobalCathegory"
		'
		'RadLabelProjectNameGlobal
		'
		Me.RadLabelProjectNameGlobal.AutoSize = False
		Me.RadLabelProjectNameGlobal.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelProjectNameGlobal.ForeColor = System.Drawing.Color.White
		Me.RadLabelProjectNameGlobal.Location = New System.Drawing.Point(270, 5)
		Me.RadLabelProjectNameGlobal.Name = "RadLabelProjectNameGlobal"
		'
		'
		'
		Me.RadLabelProjectNameGlobal.RootElement.ControlBounds = New System.Drawing.Rectangle(270, 5, 100, 18)
		Me.RadLabelProjectNameGlobal.Size = New System.Drawing.Size(240, 25)
		Me.RadLabelProjectNameGlobal.TabIndex = 44
		Me.RadLabelProjectNameGlobal.Text = "RadLabelAudioNameGlobal"
		'
		'RadLabelCentreNameGlobal
		'
		Me.RadLabelCentreNameGlobal.AutoSize = False
		Me.RadLabelCentreNameGlobal.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelCentreNameGlobal.ForeColor = System.Drawing.Color.White
		Me.RadLabelCentreNameGlobal.Location = New System.Drawing.Point(20, 5)
		Me.RadLabelCentreNameGlobal.Name = "RadLabelCentreNameGlobal"
		'
		'
		'
		Me.RadLabelCentreNameGlobal.RootElement.ControlBounds = New System.Drawing.Rectangle(20, 5, 100, 18)
		Me.RadLabelCentreNameGlobal.Size = New System.Drawing.Size(240, 25)
		Me.RadLabelCentreNameGlobal.TabIndex = 43
		Me.RadLabelCentreNameGlobal.Text = "RadLabelNomDuCentre"
		'
		'RadSpinEditorIndexKey
		'
		Me.RadSpinEditorIndexKey.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorIndexKey.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorIndexKey.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorIndexKey.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorIndexKey.Name = "RadSpinEditorIndexKey"
		Me.RadSpinEditorIndexKey.ReadOnly = True
		'
		'
		'
		Me.RadSpinEditorIndexKey.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorIndexKey.RootElement.StretchVertically = True
		Me.RadSpinEditorIndexKey.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorIndexKey.TabIndex = 48
		Me.RadSpinEditorIndexKey.TabStop = False
		'
		'RadSpinEditorItemIndex
		'
		Me.RadSpinEditorItemIndex.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorItemIndex.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorItemIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorItemIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorItemIndex.Name = "RadSpinEditorItemIndex"
		Me.RadSpinEditorItemIndex.ReadOnly = True
		'
		'
		'
		Me.RadSpinEditorItemIndex.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorItemIndex.RootElement.StretchVertically = True
		Me.RadSpinEditorItemIndex.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorItemIndex.TabIndex = 49
		Me.RadSpinEditorItemIndex.TabStop = False
		'
		'RadSpinEditorProjectIndex
		'
		Me.RadSpinEditorProjectIndex.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorProjectIndex.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorProjectIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorProjectIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorProjectIndex.Name = "RadSpinEditorProjectIndex"
		'
		'
		'
		Me.RadSpinEditorProjectIndex.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorProjectIndex.RootElement.StretchVertically = True
		Me.RadSpinEditorProjectIndex.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorProjectIndex.TabIndex = 50
		Me.RadSpinEditorProjectIndex.TabStop = False
		'
		'RadTextBoxItemsCode
		'
		Me.RadTextBoxItemsCode.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBoxItemsCode.Location = New System.Drawing.Point(64, 3)
		Me.RadTextBoxItemsCode.Name = "RadTextBoxItemsCode"
		'
		'
		'
		Me.RadTextBoxItemsCode.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadTextBoxItemsCode.RootElement.StretchVertically = True
		Me.RadTextBoxItemsCode.Size = New System.Drawing.Size(184, 20)
		Me.RadTextBoxItemsCode.TabIndex = 51
		'
		'RadTextBoxItemName
		'
		Me.RadTextBoxItemName.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBoxItemName.Location = New System.Drawing.Point(64, 3)
		Me.RadTextBoxItemName.Name = "RadTextBoxItemName"
		'
		'
		'
		Me.RadTextBoxItemName.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadTextBoxItemName.RootElement.StretchVertically = True
		Me.RadTextBoxItemName.Size = New System.Drawing.Size(184, 20)
		Me.RadTextBoxItemName.TabIndex = 52
		'
		'RadTextBoxParent_Items
		'
		Me.RadTextBoxParent_Items.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBoxParent_Items.Location = New System.Drawing.Point(64, 3)
		Me.RadTextBoxParent_Items.Name = "RadTextBoxParent_Items"
		'
		'
		'
		Me.RadTextBoxParent_Items.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadTextBoxParent_Items.RootElement.StretchVertically = True
		Me.RadTextBoxParent_Items.Size = New System.Drawing.Size(184, 20)
		Me.RadTextBoxParent_Items.TabIndex = 53
		'
		'RadSpinEditorQuantity
		'
		Me.RadSpinEditorQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorQuantity.DecimalPlaces = 2
		Me.RadSpinEditorQuantity.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorQuantity.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorQuantity.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorQuantity.Name = "RadSpinEditorQuantity"
		'
		'
		'
		Me.RadSpinEditorQuantity.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorQuantity.RootElement.StretchVertically = True
		Me.RadSpinEditorQuantity.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorQuantity.TabIndex = 54
		Me.RadSpinEditorQuantity.TabStop = False
		'
		'RadSpinEditorUnitQuantity
		'
		Me.RadSpinEditorUnitQuantity.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorUnitQuantity.DecimalPlaces = 2
		Me.RadSpinEditorUnitQuantity.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorUnitQuantity.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorUnitQuantity.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorUnitQuantity.Name = "RadSpinEditorUnitQuantity"
		'
		'
		'
		Me.RadSpinEditorUnitQuantity.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorUnitQuantity.RootElement.StretchVertically = True
		Me.RadSpinEditorUnitQuantity.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorUnitQuantity.TabIndex = 55
		Me.RadSpinEditorUnitQuantity.TabStop = False
		'
		'RadSpinEditorUnitPrice
		'
		Me.RadSpinEditorUnitPrice.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorUnitPrice.DecimalPlaces = 2
		Me.RadSpinEditorUnitPrice.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorUnitPrice.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorUnitPrice.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorUnitPrice.Name = "RadSpinEditorUnitPrice"
		'
		'
		'
		Me.RadSpinEditorUnitPrice.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorUnitPrice.RootElement.StretchVertically = True
		Me.RadSpinEditorUnitPrice.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorUnitPrice.TabIndex = 56
		Me.RadSpinEditorUnitPrice.TabStop = False
		'
		'RadSpinEditorTotalPrice
		'
		Me.RadSpinEditorTotalPrice.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorTotalPrice.DecimalPlaces = 2
		Me.RadSpinEditorTotalPrice.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorTotalPrice.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorTotalPrice.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorTotalPrice.Name = "RadSpinEditorTotalPrice"
		Me.RadSpinEditorTotalPrice.ReadOnly = True
		'
		'
		'
		Me.RadSpinEditorTotalPrice.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorTotalPrice.RootElement.StretchVertically = True
		Me.RadSpinEditorTotalPrice.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorTotalPrice.TabIndex = 57
		Me.RadSpinEditorTotalPrice.TabStop = False
		'
		'RadSpinEditorVATPorucent
		'
		Me.RadSpinEditorVATPorucent.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorVATPorucent.DecimalPlaces = 2
		Me.RadSpinEditorVATPorucent.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorVATPorucent.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorVATPorucent.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorVATPorucent.Name = "RadSpinEditorVATPorucent"
		'
		'
		'
		Me.RadSpinEditorVATPorucent.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorVATPorucent.RootElement.StretchVertically = True
		Me.RadSpinEditorVATPorucent.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorVATPorucent.TabIndex = 58
		Me.RadSpinEditorVATPorucent.TabStop = False
		'
		'RadSpinEditorVATValue
		'
		Me.RadSpinEditorVATValue.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorVATValue.DecimalPlaces = 2
		Me.RadSpinEditorVATValue.Location = New System.Drawing.Point(64, 3)
		Me.RadSpinEditorVATValue.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorVATValue.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorVATValue.Name = "RadSpinEditorVATValue"
		Me.RadSpinEditorVATValue.ReadOnly = True
		'
		'
		'
		Me.RadSpinEditorVATValue.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadSpinEditorVATValue.RootElement.StretchVertically = True
		Me.RadSpinEditorVATValue.Size = New System.Drawing.Size(184, 20)
		Me.RadSpinEditorVATValue.TabIndex = 59
		Me.RadSpinEditorVATValue.TabStop = False
		'
		'RadTextBoxCurrency
		'
		Me.RadTextBoxCurrency.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBoxCurrency.Location = New System.Drawing.Point(64, 3)
		Me.RadTextBoxCurrency.Name = "RadTextBoxCurrency"
		'
		'
		'
		Me.RadTextBoxCurrency.RootElement.ControlBounds = New System.Drawing.Rectangle(64, 3, 100, 20)
		Me.RadTextBoxCurrency.RootElement.StretchVertically = True
		Me.RadTextBoxCurrency.Size = New System.Drawing.Size(184, 20)
		Me.RadTextBoxCurrency.TabIndex = 60
		'
		'ButtonGridviewUpdate
		'
		Me.ButtonGridviewUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ButtonGridviewUpdate.Location = New System.Drawing.Point(112, 465)
		Me.ButtonGridviewUpdate.Name = "ButtonGridviewUpdate"
		Me.ButtonGridviewUpdate.Size = New System.Drawing.Size(60, 29)
		Me.ButtonGridviewUpdate.TabIndex = 48
		Me.ButtonGridviewUpdate.Text = "Update"
		Me.ButtonGridviewUpdate.UseVisualStyleBackColor = True
		'
		'ButtonGridviewDelete
		'
		Me.ButtonGridviewDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ButtonGridviewDelete.Location = New System.Drawing.Point(190, 465)
		Me.ButtonGridviewDelete.Name = "ButtonGridviewDelete"
		Me.ButtonGridviewDelete.Size = New System.Drawing.Size(60, 29)
		Me.ButtonGridviewDelete.TabIndex = 49
		Me.ButtonGridviewDelete.Text = "Delete"
		Me.ButtonGridviewDelete.UseVisualStyleBackColor = True
		'
		'ButtonGridviewNew
		'
		Me.ButtonGridviewNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.ButtonGridviewNew.Location = New System.Drawing.Point(35, 465)
		Me.ButtonGridviewNew.Name = "ButtonGridviewNew"
		Me.ButtonGridviewNew.Size = New System.Drawing.Size(60, 29)
		Me.ButtonGridviewNew.TabIndex = 50
		Me.ButtonGridviewNew.Text = "Add"
		Me.ButtonGridviewNew.UseVisualStyleBackColor = True
		'
		'GroupBoxItemMainForm
		'
		Me.GroupBoxItemMainForm.Controls.Add(Me.CheckedListBoxTypeCharge)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadCheckBoxFF)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadGridViewClassItemsListe)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadButtonItemsLevelOne)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadButtonGroupageRefhesh)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadButtonGroupCancel)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadButtonGroupage)
		Me.GroupBoxItemMainForm.Controls.Add(Me.ListBoxItemsParent)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadListeiewProjectName)
		Me.GroupBoxItemMainForm.Controls.Add(Me.radPanelTodaysAppointments)
		Me.GroupBoxItemMainForm.Controls.Add(Me.RadGridViewItems)
		Me.GroupBoxItemMainForm.Controls.Add(Me.GroupBox1)
		Me.GroupBoxItemMainForm.ForeColor = System.Drawing.SystemColors.ButtonShadow
		Me.GroupBoxItemMainForm.Location = New System.Drawing.Point(65, 35)
		Me.GroupBoxItemMainForm.Name = "GroupBoxItemMainForm"
		Me.GroupBoxItemMainForm.Size = New System.Drawing.Size(1560, 820)
		Me.GroupBoxItemMainForm.TabIndex = 53
		Me.GroupBoxItemMainForm.TabStop = False
		'
		'CheckedListBoxTypeCharge
		'
		Me.CheckedListBoxTypeCharge.CheckOnClick = True
		Me.CheckedListBoxTypeCharge.FormattingEnabled = True
		Me.CheckedListBoxTypeCharge.Items.AddRange(New Object() {"Tous", "Hors achats", "Hors salaires", "Achats", "Salaires", "Petites charges", "Loyer et autres", "Taxes et impots", "Frais bancaires"})
		Me.CheckedListBoxTypeCharge.Location = New System.Drawing.Point(566, 574)
		Me.CheckedListBoxTypeCharge.Name = "CheckedListBoxTypeCharge"
		Me.CheckedListBoxTypeCharge.Size = New System.Drawing.Size(130, 139)
		Me.CheckedListBoxTypeCharge.TabIndex = 65
		'
		'RadCheckBoxFF
		'
		Me.RadCheckBoxFF.CheckState = System.Windows.Forms.CheckState.Checked
		Me.RadCheckBoxFF.Location = New System.Drawing.Point(598, 550)
		Me.RadCheckBoxFF.Name = "RadCheckBoxFF"
		Me.RadCheckBoxFF.Size = New System.Drawing.Size(61, 18)
		Me.RadCheckBoxFF.TabIndex = 64
		Me.RadCheckBoxFF.Text = "inclu FF"
		Me.RadCheckBoxFF.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
		'
		'RadGridViewClassItemsListe
		'
		Me.RadGridViewClassItemsListe.Location = New System.Drawing.Point(700, 574)
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
		Me.RadGridViewClassItemsListe.MasterTemplate.EnableGrouping = False
		Me.RadGridViewClassItemsListe.MasterTemplate.ShowRowHeaderColumn = False
		Me.RadGridViewClassItemsListe.MasterTemplate.ViewDefinition = TableViewDefinition3
		Me.RadGridViewClassItemsListe.Name = "RadGridViewClassItemsListe"
		Me.RadGridViewClassItemsListe.ShowItemToolTips = False
		Me.RadGridViewClassItemsListe.ShowNoDataText = False
		Me.RadGridViewClassItemsListe.Size = New System.Drawing.Size(555, 232)
		Me.RadGridViewClassItemsListe.TabIndex = 63
		'
		'RadButtonItemsLevelOne
		'
		Me.RadButtonItemsLevelOne.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonItemsLevelOne.Image = Global.PrevisionFlex.My.Resources.Resources.update_ronde_gray_30x302
		Me.RadButtonItemsLevelOne.Location = New System.Drawing.Point(705, 530)
		Me.RadButtonItemsLevelOne.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonItemsLevelOne.Name = "RadButtonItemsLevelOne"
		'
		'
		'
		Me.RadButtonItemsLevelOne.RootElement.ControlBounds = New System.Drawing.Rectangle(705, 530, 110, 24)
		Me.RadButtonItemsLevelOne.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonItemsLevelOne.TabIndex = 61
		Me.RadButtonItemsLevelOne.Text = "1 Level  "
		Me.RadButtonItemsLevelOne.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadButtonGroupageRefhesh
		'
		Me.RadButtonGroupageRefhesh.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonGroupageRefhesh.Image = Global.PrevisionFlex.My.Resources.Resources.update_ronde_gray_30x302
		Me.RadButtonGroupageRefhesh.Location = New System.Drawing.Point(807, 530)
		Me.RadButtonGroupageRefhesh.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonGroupageRefhesh.Name = "RadButtonGroupageRefhesh"
		'
		'
		'
		Me.RadButtonGroupageRefhesh.RootElement.ControlBounds = New System.Drawing.Rectangle(807, 530, 110, 24)
		Me.RadButtonGroupageRefhesh.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonGroupageRefhesh.TabIndex = 60
		Me.RadButtonGroupageRefhesh.Text = "2 Level   "
		Me.RadButtonGroupageRefhesh.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadButtonGroupCancel
		'
		Me.RadButtonGroupCancel.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonGroupCancel.Image = Global.PrevisionFlex.My.Resources.Resources.treeview_detail_25
		Me.RadButtonGroupCancel.Location = New System.Drawing.Point(1011, 530)
		Me.RadButtonGroupCancel.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonGroupCancel.Name = "RadButtonGroupCancel"
		'
		'
		'
		Me.RadButtonGroupCancel.RootElement.ControlBounds = New System.Drawing.Rectangle(1011, 530, 110, 24)
		Me.RadButtonGroupCancel.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonGroupCancel.TabIndex = 60
		Me.RadButtonGroupCancel.Text = "Détail  "
		Me.RadButtonGroupCancel.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadButtonGroupage
		'
		Me.RadButtonGroupage.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadButtonGroupage.Image = Global.PrevisionFlex.My.Resources.Resources.treeview_sans_detail_25
		Me.RadButtonGroupage.Location = New System.Drawing.Point(909, 530)
		Me.RadButtonGroupage.Margin = New System.Windows.Forms.Padding(6)
		Me.RadButtonGroupage.Name = "RadButtonGroupage"
		'
		'
		'
		Me.RadButtonGroupage.RootElement.ControlBounds = New System.Drawing.Rectangle(909, 530, 110, 24)
		Me.RadButtonGroupage.Size = New System.Drawing.Size(90, 38)
		Me.RadButtonGroupage.TabIndex = 59
		Me.RadButtonGroupage.Text = "Groupage "
		Me.RadButtonGroupage.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
		'
		'RadGridViewItems
		'
		Me.RadGridViewItems.AutoScroll = True
		Me.RadGridViewItems.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadGridViewItems.Location = New System.Drawing.Point(5, 5)
		'
		'
		'
		Me.RadGridViewItems.MasterTemplate.AllowAddNewRow = False
		Me.RadGridViewItems.MasterTemplate.AllowDeleteRow = False
		Me.RadGridViewItems.MasterTemplate.AllowEditRow = False
		Me.RadGridViewItems.MasterTemplate.AllowSearchRow = True
		Me.RadGridViewItems.MasterTemplate.AutoExpandGroups = True
		Me.RadGridViewItems.MasterTemplate.EnableAlternatingRowColor = True
		Me.RadGridViewItems.MasterTemplate.ViewDefinition = TableViewDefinition4
		Me.RadGridViewItems.Name = "RadGridViewItems"
		'
		'
		'
		Me.RadGridViewItems.RootElement.ControlBounds = New System.Drawing.Rectangle(5, 5, 240, 150)
		Me.RadGridViewItems.Size = New System.Drawing.Size(1250, 510)
		Me.RadGridViewItems.TabIndex = 6
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.RadLabel13)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_PAYE_QUI)
		Me.GroupBox1.Controls.Add(Me.RadLabel14)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_MT_PAIEMENT)
		Me.GroupBox1.Controls.Add(Me.RadLabelPayeOuPas)
		Me.GroupBox1.Controls.Add(Me.RadLabelDatePaiement)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_PayeQui)
		Me.GroupBox1.Controls.Add(Me.RadLabel12)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_DatePaiement)
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
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_LAST_EDIT_DATE)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_CURRENCY)
		Me.GroupBox1.Controls.Add(Me.RadTextBox_MTTVA)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_TAXE_VALUE)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_TAXE)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_UNIT)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_QUANTITY)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_PARENT)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_NAME)
		Me.GroupBox1.Controls.Add(Me.RadTextBoxITEMS_CODE)
		Me.GroupBox1.Controls.Add(Me.RadTextBox_ITEMS_INDEX)
		Me.GroupBox1.Controls.Add(Me.RadTextBox_INDEX)
		Me.GroupBox1.Location = New System.Drawing.Point(1262, 5)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(277, 506)
		Me.GroupBox1.TabIndex = 62
		Me.GroupBox1.TabStop = False
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
		Me.RadTextBoxITEMS_PAYE_QUI.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_PAYE_QUI.Location = New System.Drawing.Point(120, 430)
		Me.RadTextBoxITEMS_PAYE_QUI.Name = "RadTextBoxITEMS_PAYE_QUI"
		Me.RadTextBoxITEMS_PAYE_QUI.ShowClearButton = True
		Me.RadTextBoxITEMS_PAYE_QUI.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_PAYE_QUI.TabIndex = 60
		Me.RadTextBoxITEMS_PAYE_QUI.Text = "FRENCH RERO"
		Me.RadTextBoxITEMS_PAYE_QUI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
		'RadTextBoxITEMS_MT_PAIEMENT
		'
		Me.RadTextBoxITEMS_MT_PAIEMENT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_MT_PAIEMENT.Location = New System.Drawing.Point(119, 402)
		Me.RadTextBoxITEMS_MT_PAIEMENT.Name = "RadTextBoxITEMS_MT_PAIEMENT"
		Me.RadTextBoxITEMS_MT_PAIEMENT.ShowClearButton = True
		Me.RadTextBoxITEMS_MT_PAIEMENT.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_MT_PAIEMENT.TabIndex = 58
		Me.RadTextBoxITEMS_MT_PAIEMENT.Text = "0.00"
		Me.RadTextBoxITEMS_MT_PAIEMENT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
		'RadTextBoxITEMS_PayeQui
		'
		Me.RadTextBoxITEMS_PayeQui.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_PayeQui.Location = New System.Drawing.Point(119, 374)
		Me.RadTextBoxITEMS_PayeQui.Name = "RadTextBoxITEMS_PayeQui"
		Me.RadTextBoxITEMS_PayeQui.ShowClearButton = True
		Me.RadTextBoxITEMS_PayeQui.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_PayeQui.TabIndex = 56
		Me.RadTextBoxITEMS_PayeQui.Text = "N"
		Me.RadTextBoxITEMS_PayeQui.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
		'RadTextBoxITEMS_DatePaiement
		'
		Me.RadTextBoxITEMS_DatePaiement.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_DatePaiement.Location = New System.Drawing.Point(119, 346)
		Me.RadTextBoxITEMS_DatePaiement.Name = "RadTextBoxITEMS_DatePaiement"
		Me.RadTextBoxITEMS_DatePaiement.ShowClearButton = True
		Me.RadTextBoxITEMS_DatePaiement.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_DatePaiement.TabIndex = 54
		Me.RadTextBoxITEMS_DatePaiement.Text = "01-01-2023"
		Me.RadTextBoxITEMS_DatePaiement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
		'RadTextBoxITEMS_LAST_EDIT_DATE
		'
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.Location = New System.Drawing.Point(119, 318)
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.Name = "RadTextBoxITEMS_LAST_EDIT_DATE"
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.ShowClearButton = True
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.TabIndex = 11
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.Text = "01-01-2023"
		Me.RadTextBoxITEMS_LAST_EDIT_DATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBoxITEMS_CURRENCY
		'
		Me.RadTextBoxITEMS_CURRENCY.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_CURRENCY.Location = New System.Drawing.Point(119, 290)
		Me.RadTextBoxITEMS_CURRENCY.Name = "RadTextBoxITEMS_CURRENCY"
		Me.RadTextBoxITEMS_CURRENCY.ShowClearButton = True
		Me.RadTextBoxITEMS_CURRENCY.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_CURRENCY.TabIndex = 10
		Me.RadTextBoxITEMS_CURRENCY.Text = "EURO"
		Me.RadTextBoxITEMS_CURRENCY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBox_MTTVA
		'
		Me.RadTextBox_MTTVA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBox_MTTVA.Location = New System.Drawing.Point(119, 234)
		Me.RadTextBox_MTTVA.Name = "RadTextBox_MTTVA"
		Me.RadTextBox_MTTVA.ShowClearButton = True
		Me.RadTextBox_MTTVA.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBox_MTTVA.TabIndex = 9
		Me.RadTextBox_MTTVA.Text = "0.00"
		Me.RadTextBox_MTTVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBoxITEMS_TAXE_VALUE
		'
		Me.RadTextBoxITEMS_TAXE_VALUE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_TAXE_VALUE.Location = New System.Drawing.Point(119, 262)
		Me.RadTextBoxITEMS_TAXE_VALUE.Name = "RadTextBoxITEMS_TAXE_VALUE"
		Me.RadTextBoxITEMS_TAXE_VALUE.ShowClearButton = True
		Me.RadTextBoxITEMS_TAXE_VALUE.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_TAXE_VALUE.TabIndex = 8
		Me.RadTextBoxITEMS_TAXE_VALUE.Text = "0.00"
		Me.RadTextBoxITEMS_TAXE_VALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBoxITEMS_TAXE
		'
		Me.RadTextBoxITEMS_TAXE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_TAXE.Location = New System.Drawing.Point(119, 206)
		Me.RadTextBoxITEMS_TAXE.Name = "RadTextBoxITEMS_TAXE"
		Me.RadTextBoxITEMS_TAXE.ShowClearButton = True
		Me.RadTextBoxITEMS_TAXE.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_TAXE.TabIndex = 7
		Me.RadTextBoxITEMS_TAXE.Text = "20.00"
		Me.RadTextBoxITEMS_TAXE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBoxITEMS_UNIT
		'
		Me.RadTextBoxITEMS_UNIT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_UNIT.Location = New System.Drawing.Point(119, 179)
		Me.RadTextBoxITEMS_UNIT.Name = "RadTextBoxITEMS_UNIT"
		Me.RadTextBoxITEMS_UNIT.ShowClearButton = True
		Me.RadTextBoxITEMS_UNIT.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_UNIT.TabIndex = 6
		Me.RadTextBoxITEMS_UNIT.Text = " 0.00"
		Me.RadTextBoxITEMS_UNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBoxITEMS_QUANTITY
		'
		Me.RadTextBoxITEMS_QUANTITY.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_QUANTITY.Location = New System.Drawing.Point(119, 151)
		Me.RadTextBoxITEMS_QUANTITY.Name = "RadTextBoxITEMS_QUANTITY"
		Me.RadTextBoxITEMS_QUANTITY.ShowClearButton = True
		Me.RadTextBoxITEMS_QUANTITY.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_QUANTITY.TabIndex = 5
		Me.RadTextBoxITEMS_QUANTITY.Text = "0.00"
		Me.RadTextBoxITEMS_QUANTITY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'RadTextBoxITEMS_PARENT
		'
		Me.RadTextBoxITEMS_PARENT.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_PARENT.Location = New System.Drawing.Point(119, 123)
		Me.RadTextBoxITEMS_PARENT.Name = "RadTextBoxITEMS_PARENT"
		Me.RadTextBoxITEMS_PARENT.ShowClearButton = True
		Me.RadTextBoxITEMS_PARENT.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_PARENT.TabIndex = 4
		Me.RadTextBoxITEMS_PARENT.Text = "_ROOT"
		'
		'RadTextBoxITEMS_NAME
		'
		Me.RadTextBoxITEMS_NAME.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_NAME.Location = New System.Drawing.Point(119, 95)
		Me.RadTextBoxITEMS_NAME.Name = "RadTextBoxITEMS_NAME"
		Me.RadTextBoxITEMS_NAME.ShowClearButton = True
		Me.RadTextBoxITEMS_NAME.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_NAME.TabIndex = 3
		Me.RadTextBoxITEMS_NAME.Text = "ARROSAGE"
		'
		'RadTextBoxITEMS_CODE
		'
		Me.RadTextBoxITEMS_CODE.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBoxITEMS_CODE.Location = New System.Drawing.Point(119, 67)
		Me.RadTextBoxITEMS_CODE.Name = "RadTextBoxITEMS_CODE"
		Me.RadTextBoxITEMS_CODE.ShowClearButton = True
		Me.RadTextBoxITEMS_CODE.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBoxITEMS_CODE.TabIndex = 2
		Me.RadTextBoxITEMS_CODE.Text = "LOYERS"
		'
		'RadTextBox_ITEMS_INDEX
		'
		Me.RadTextBox_ITEMS_INDEX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBox_ITEMS_INDEX.Location = New System.Drawing.Point(119, 38)
		Me.RadTextBox_ITEMS_INDEX.Name = "RadTextBox_ITEMS_INDEX"
		Me.RadTextBox_ITEMS_INDEX.ShowClearButton = True
		Me.RadTextBox_ITEMS_INDEX.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBox_ITEMS_INDEX.TabIndex = 1
		Me.RadTextBox_ITEMS_INDEX.Text = "0"
		'
		'RadTextBox_INDEX
		'
		Me.RadTextBox_INDEX.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadTextBox_INDEX.Location = New System.Drawing.Point(119, 10)
		Me.RadTextBox_INDEX.Name = "RadTextBox_INDEX"
		Me.RadTextBox_INDEX.ShowClearButton = True
		Me.RadTextBox_INDEX.Size = New System.Drawing.Size(150, 27)
		Me.RadTextBox_INDEX.TabIndex = 0
		Me.RadTextBox_INDEX.Text = "0"
		'
		'RadSpinEditor1
		'
		Me.RadSpinEditor1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditor1.Location = New System.Drawing.Point(120, 3)
		Me.RadSpinEditor1.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor1.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor1.Name = "RadSpinEditor1"
		'
		'
		'
		Me.RadSpinEditor1.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 3, 100, 20)
		Me.RadSpinEditor1.RootElement.StretchVertically = True
		Me.RadSpinEditor1.Size = New System.Drawing.Size(352, 20)
		Me.RadSpinEditor1.TabIndex = 58
		Me.RadSpinEditor1.TabStop = False
		'
		'RadSpinEditorProjectIndex2
		'
		Me.RadSpinEditorProjectIndex2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadSpinEditorProjectIndex2.Location = New System.Drawing.Point(120, 3)
		Me.RadSpinEditorProjectIndex2.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorProjectIndex2.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorProjectIndex2.Name = "RadSpinEditorProjectIndex2"
		'
		'
		'
		Me.RadSpinEditorProjectIndex2.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 3, 100, 20)
		Me.RadSpinEditorProjectIndex2.RootElement.StretchVertically = True
		Me.RadSpinEditorProjectIndex2.Size = New System.Drawing.Size(352, 20)
		Me.RadSpinEditorProjectIndex2.TabIndex = 59
		Me.RadSpinEditorProjectIndex2.TabStop = False
		'
		'RadTextBox1
		'
		Me.RadTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBox1.Location = New System.Drawing.Point(120, 3)
		Me.RadTextBox1.Name = "RadTextBox1"
		'
		'
		'
		Me.RadTextBox1.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 3, 100, 20)
		Me.RadTextBox1.RootElement.StretchVertically = True
		Me.RadTextBox1.Size = New System.Drawing.Size(352, 20)
		Me.RadTextBox1.TabIndex = 60
		'
		'RadTextBox2
		'
		Me.RadTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBox2.Location = New System.Drawing.Point(120, 3)
		Me.RadTextBox2.Name = "RadTextBox2"
		'
		'
		'
		Me.RadTextBox2.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 3, 100, 20)
		Me.RadTextBox2.RootElement.StretchVertically = True
		Me.RadTextBox2.Size = New System.Drawing.Size(352, 20)
		Me.RadTextBox2.TabIndex = 61
		'
		'RadTextBoxProjectMainFormStatus
		'
		Me.RadTextBoxProjectMainFormStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBoxProjectMainFormStatus.Location = New System.Drawing.Point(120, 3)
		Me.RadTextBoxProjectMainFormStatus.Name = "RadTextBoxProjectMainFormStatus"
		'
		'
		'
		Me.RadTextBoxProjectMainFormStatus.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 3, 100, 20)
		Me.RadTextBoxProjectMainFormStatus.RootElement.StretchVertically = True
		Me.RadTextBoxProjectMainFormStatus.Size = New System.Drawing.Size(352, 20)
		Me.RadTextBoxProjectMainFormStatus.TabIndex = 64
		'
		'RadTextBoxProjectMainFormPathName
		'
		Me.RadTextBoxProjectMainFormPathName.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadTextBoxProjectMainFormPathName.Location = New System.Drawing.Point(120, 7)
		Me.RadTextBoxProjectMainFormPathName.Name = "RadTextBoxProjectMainFormPathName"
		'
		'
		'
		Me.RadTextBoxProjectMainFormPathName.RootElement.ControlBounds = New System.Drawing.Rectangle(120, 7, 100, 20)
		Me.RadTextBoxProjectMainFormPathName.RootElement.StretchVertically = True
		Me.RadTextBoxProjectMainFormPathName.Size = New System.Drawing.Size(352, 20)
		Me.RadTextBoxProjectMainFormPathName.TabIndex = 65
		'
		'GroupBoxMenuVertical
		'
		Me.GroupBoxMenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(62, Byte), Integer))
		Me.GroupBoxMenuVertical.Location = New System.Drawing.Point(0, 35)
		Me.GroupBoxMenuVertical.Name = "GroupBoxMenuVertical"
		Me.GroupBoxMenuVertical.Size = New System.Drawing.Size(60, 817)
		Me.GroupBoxMenuVertical.TabIndex = 65
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1614, 881)
		Me.Controls.Add(Me.GroupBoxMenuVertical)
		Me.Controls.Add(Me.GroupBoxItemMainForm)
		Me.Controls.Add(Me.RadPanelHaut)
		Me.Controls.Add(Me.RadStatusStrip2)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "MainForm"
		Me.Text = "PrevisionFlex software 1.0"
		CType(Me.radPanelTodaysAppointments, System.ComponentModel.ISupportInitialize).EndInit()
		Me.radPanelTodaysAppointments.ResumeLayout(False)
		Me.radPanelTodaysAppointments.PerformLayout()
		CType(Me.RadLabelMTPaye, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelAllTotalOfItems, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.radLabelLastAppointmentToday, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelTotalEstimation, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.radLabelCurrentItems, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadListeiewProjectName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadPanelHaut, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadPanelHaut.ResumeLayout(False)
		CType(Me.RadLabelDayEnd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelDaySart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelGlobalCathegory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelProjectNameGlobal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelCentreNameGlobal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorIndexKey, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorItemIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxItemsCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxItemName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxParent_Items, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorUnitQuantity, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorUnitPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorTotalPrice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorVATPorucent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorVATValue, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxCurrency, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBoxItemMainForm.ResumeLayout(False)
		Me.GroupBoxItemMainForm.PerformLayout()
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
		CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_PAYE_QUI, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_MT_PAIEMENT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelPayeOuPas, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelDatePaiement, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_PayeQui, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_DatePaiement, System.ComponentModel.ISupportInitialize).EndInit()
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
		CType(Me.RadTextBoxITEMS_LAST_EDIT_DATE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_CURRENCY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox_MTTVA, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_TAXE_VALUE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_TAXE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_UNIT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_QUANTITY, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_PARENT, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_NAME, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxITEMS_CODE, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox_ITEMS_INDEX, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox_INDEX, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorProjectIndex2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectMainFormStatus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectMainFormPathName, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Private WithEvents radPanelTodaysAppointments As Telerik.WinControls.UI.RadPanel
	Private WithEvents RadLabelAllTotalOfItems As Telerik.WinControls.UI.RadLabel
	Private WithEvents radLabelLastAppointmentToday As Telerik.WinControls.UI.RadLabel
	Private WithEvents RadLabelTotalEstimation As Telerik.WinControls.UI.RadLabel
	Private WithEvents radLabelCurrentItems As Telerik.WinControls.UI.RadLabel
	Private WithEvents RadListeiewProjectName As Telerik.WinControls.UI.RadListView
	Friend WithEvents ListBoxItemsParent As ListBox
	Friend WithEvents RadStatusStrip2 As RadStatusStrip
	Friend WithEvents RadLabelElementMessage As RadLabelElement
	Friend WithEvents RadPanelHaut As RadPanel
	Friend WithEvents RadLabelDayEnd As RadLabel
	Friend WithEvents RadLabelDaySart As RadLabel
	Friend WithEvents RadLabelGlobalCathegory As RadLabel
	Friend WithEvents RadLabelProjectNameGlobal As RadLabel
	Friend WithEvents RadLabelCentreNameGlobal As RadLabel
	'Friend WithEvents RadDataLayoutItemMainForm As RadDataLayout
	Friend WithEvents RadSpinEditorIndexKey As RadSpinEditor
	Friend WithEvents RadSpinEditorItemIndex As RadSpinEditor
	Friend WithEvents RadSpinEditorProjectIndex As RadSpinEditor
	Friend WithEvents RadTextBoxItemsCode As RadTextBox
	Friend WithEvents RadTextBoxItemName As RadTextBox
	Friend WithEvents RadTextBoxParent_Items As RadTextBox
	Friend WithEvents RadSpinEditorQuantity As RadSpinEditor
	Friend WithEvents RadSpinEditorUnitQuantity As RadSpinEditor
	Friend WithEvents RadSpinEditorUnitPrice As RadSpinEditor
	Friend WithEvents RadSpinEditorTotalPrice As RadSpinEditor
	Friend WithEvents RadSpinEditorVATPorucent As RadSpinEditor
	Friend WithEvents RadSpinEditorVATValue As RadSpinEditor
	Friend WithEvents RadTextBoxCurrency As RadTextBox
	Friend WithEvents ButtonGridviewUpdate As Button
	Friend WithEvents ButtonGridviewDelete As Button
	Friend WithEvents ButtonGridviewNew As Button
	Friend WithEvents GroupBoxItemMainForm As GroupBox
	Friend WithEvents RadGridViewItems As RadGridView
	Friend WithEvents RadSpinEditor1 As RadSpinEditor
	Friend WithEvents RadSpinEditorProjectIndex2 As RadSpinEditor
	Friend WithEvents RadTextBox1 As RadTextBox
	Friend WithEvents RadTextBox2 As RadTextBox
	Friend WithEvents RadTextBoxProjectMainFormStatus As RadTextBox
	Friend WithEvents RadTextBoxProjectMainFormPathName As RadTextBox
	Friend WithEvents RadButtonGroupCancel As RadButton
	Friend WithEvents RadButtonGroupage As RadButton
	Friend WithEvents RadButtonGroupageRefhesh As RadButton
	Friend WithEvents RadButtonItemsLevelOne As RadButton
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents RadTextBox_INDEX As RadTextBox
	Friend WithEvents RadTextBoxITEMS_UNIT As RadTextBox
	Friend WithEvents RadTextBoxITEMS_QUANTITY As RadTextBox
	Friend WithEvents RadTextBoxITEMS_PARENT As RadTextBox
	Friend WithEvents RadTextBoxITEMS_NAME As RadTextBox
	Friend WithEvents RadTextBoxITEMS_CODE As RadTextBox
	Friend WithEvents RadTextBox_ITEMS_INDEX As RadTextBox
	Friend WithEvents RadTextBoxITEMS_TAXE_VALUE As RadTextBox
	Friend WithEvents RadTextBoxITEMS_TAXE As RadTextBox
	Friend WithEvents RadTextBoxITEMS_LAST_EDIT_DATE As RadTextBox
	Friend WithEvents RadTextBoxITEMS_CURRENCY As RadTextBox
	Friend WithEvents RadTextBox_MTTVA As RadTextBox
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
	Friend WithEvents RadTextBoxITEMS_MT_PAIEMENT As RadTextBox
	Friend WithEvents RadLabelPayeOuPas As RadLabel
	Friend WithEvents RadLabelDatePaiement As RadLabel
	Friend WithEvents RadTextBoxITEMS_PayeQui As RadTextBox
	Friend WithEvents RadTextBoxITEMS_DatePaiement As RadTextBox
	Friend WithEvents RadGridViewClassItemsListe As RadGridView
	Friend WithEvents RadCheckBoxFF As RadCheckBox
	Friend WithEvents CheckedListBoxTypeCharge As CheckedListBox
	Friend WithEvents GroupBoxMenuVertical As Panel
End Class
