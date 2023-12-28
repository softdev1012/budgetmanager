<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormListView
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
		Me.components = New System.ComponentModel.Container()
		Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Dim GridViewDecimalColumn4 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn5 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewDecimalColumn6 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Dim GridViewDecimalColumn7 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn8 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
		Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
		Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewDecimalColumn9 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn10 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn11 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
		Dim GridViewDecimalColumn12 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn13 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim GridViewDecimalColumn14 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
		Dim TableViewDefinition3 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormListView))
		Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
		Me.RadLabelStatusMessage = New Telerik.WinControls.UI.RadLabelElement()
		Me.RadPanelHaut = New Telerik.WinControls.UI.RadPanel()
		Me.RadDateTimePickerDateEnd = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadDateTimePickerDayStard = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadLabelDayEnd = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelDaySart = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelGlobalCathegory = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelProjectNameGlobal = New Telerik.WinControls.UI.RadLabel()
		Me.RadLabelCentreNameGlobal = New Telerik.WinControls.UI.RadLabel()
		Me.FILESPATHBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TAKEOFFDataSet2 = New PrevisionFlex.TAKEOFFDataSet2()
		Me.TAKEOFFDataSet = New PrevisionFlex.TAKEOFFDataSet()
		Me.ITEMSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TAKEOFFDataSet1 = New PrevisionFlex.TAKEOFFDataSet1()
		Me.ITEMSTableAdapter = New PrevisionFlex.TAKEOFFDataSet1TableAdapters.ITEMSTableAdapter()
		Me.FILES_PATHTableAdapter = New PrevisionFlex.TAKEOFFDataSet2TableAdapters.FILES_PATHTableAdapter()
		Me.RadCollapsiblePanelDocPathName = New Telerik.WinControls.UI.RadCollapsiblePanel()
		Me.RadGridViewItems = New Telerik.WinControls.UI.RadGridView()
		Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.RadButtonPathNameListView = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonPathNameDetails = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonParthnameIcon = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonPathNameClear = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonPathNameSave = New Telerik.WinControls.UI.RadButton()
		Me.RadListViewDocuments = New Telerik.WinControls.UI.RadListView()
		Me.RadCollapsiblePanelInvoice = New Telerik.WinControls.UI.RadCollapsiblePanel()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.RadDataLayout1 = New Telerik.WinControls.UI.RadDataLayout()
		Me.INVOICEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.TAKEOFFDataSet41 = New PrevisionFlex.TAKEOFFDataSet4()
		Me.RadSpinEditor3 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorInvoiceIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadDateTimePickerInvoiceCreatDate = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadDateTimePickerModifyDate = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadTextBoxInvoiceNumber = New Telerik.WinControls.UI.RadTextBox()
		Me.RadSpinEditorType = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorInvoiceProjectIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorInvoiceItemIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBoxInvoiceSupplier = New Telerik.WinControls.UI.RadTextBox()
		Me.RadSpinEditorInvoiceAmount = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorInvoiceVATPourcent = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorInvoiceVATAmount = New Telerik.WinControls.UI.RadSpinEditor()
		Me.DataLayoutControlItem13 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem14 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem15 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem16 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem17 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem18 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem19 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem20 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem21 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem22 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem23 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem24 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.RadButtonProjectManager = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonInvoiceNEW = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonSupplierInvoiceDelete = New Telerik.WinControls.UI.RadButton()
		Me.RadButtonInvoiceUpdate = New Telerik.WinControls.UI.RadButton()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.RadGridViewInvoice = New Telerik.WinControls.UI.RadGridView()
		Me.RadSpinEditor1 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditor2 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadDateTimePicker1 = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadDateTimePicker2 = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadTextBox1 = New Telerik.WinControls.UI.RadTextBox()
		Me.RadSpinEditorInvoiceType = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorProjectIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditor5 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBox2 = New Telerik.WinControls.UI.RadTextBox()
		Me.RadSpinEditor6 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorVATPourcent = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditor8 = New Telerik.WinControls.UI.RadSpinEditor()
		Me.DataLayoutControlItem1 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem2 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem3 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem4 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem5 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem6 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem7 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem8 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem9 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem10 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem11 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem12 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.TAKEOFFDataSetInvoice = New PrevisionFlex.TAKEOFFDataSetInvoice()
		Me.INVOICETableAdapter = New PrevisionFlex.TAKEOFFDataSet4TableAdapters.INVOICETableAdapter()
		Me.TAKEOFFDataSet42 = New PrevisionFlex.TAKEOFFDataSet4()
		Me.INVOICEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.DataLayoutControlItem25 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.RadBindingNavigator1 = New Telerik.WinControls.UI.RadBindingNavigator()
		Me.CommandBarRowElement1 = New Telerik.WinControls.UI.CommandBarRowElement()
		Me.CommandBarStripElement1 = New Telerik.WinControls.UI.CommandBarStripElement()
		Me.CommandBarButton1 = New Telerik.WinControls.UI.CommandBarButton()
		Me.CommandBarSeparator1 = New Telerik.WinControls.UI.CommandBarSeparator()
		Me.CommandBarButton2 = New Telerik.WinControls.UI.CommandBarButton()
		Me.CommandBarSeparator2 = New Telerik.WinControls.UI.CommandBarSeparator()
		Me.CommandBarTextBox1 = New Telerik.WinControls.UI.CommandBarTextBox()
		Me.CommandBarLabel1 = New Telerik.WinControls.UI.CommandBarLabel()
		Me.CommandBarSeparator3 = New Telerik.WinControls.UI.CommandBarSeparator()
		Me.CommandBarButton3 = New Telerik.WinControls.UI.CommandBarButton()
		Me.CommandBarSeparator4 = New Telerik.WinControls.UI.CommandBarSeparator()
		Me.CommandBarButton4 = New Telerik.WinControls.UI.CommandBarButton()
		Me.CommandBarStripElement2 = New Telerik.WinControls.UI.CommandBarStripElement()
		Me.CommandBarButton5 = New Telerik.WinControls.UI.CommandBarButton()
		Me.CommandBarSeparator5 = New Telerik.WinControls.UI.CommandBarSeparator()
		Me.CommandBarButton6 = New Telerik.WinControls.UI.CommandBarButton()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.RadTextBoxNumEtiquette = New Telerik.WinControls.UI.RadTextBox()
		CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadPanelHaut, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadPanelHaut.SuspendLayout()
		CType(Me.RadDateTimePickerDateEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerDayStard, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelDayEnd, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelDaySart, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelGlobalCathegory, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelProjectNameGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadLabelCentreNameGlobal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.FILESPATHBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TAKEOFFDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TAKEOFFDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.ITEMSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TAKEOFFDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadCollapsiblePanelDocPathName, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadCollapsiblePanelDocPathName.PanelContainer.SuspendLayout()
		Me.RadCollapsiblePanelDocPathName.SuspendLayout()
		CType(Me.RadGridViewItems, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewItems.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.RadButtonPathNameListView, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonPathNameDetails, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonParthnameIcon, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonPathNameClear, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonPathNameSave, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadListViewDocuments, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadCollapsiblePanelInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadCollapsiblePanelInvoice.PanelContainer.SuspendLayout()
		Me.RadCollapsiblePanelInvoice.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		CType(Me.RadDataLayout1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDataLayout1.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadDataLayout1.LayoutControl.SuspendLayout()
		Me.RadDataLayout1.SuspendLayout()
		CType(Me.INVOICEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TAKEOFFDataSet41, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerInvoiceCreatDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerModifyDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxInvoiceNumber, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorType, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceProjectIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceItemIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxInvoiceSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceAmount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceVATPourcent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceVATAmount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonProjectManager, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonInvoiceNEW, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonSupplierInvoiceDelete, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadButtonInvoiceUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewInvoice.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorInvoiceType, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorVATPourcent, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditor8, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TAKEOFFDataSetInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TAKEOFFDataSet42, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.INVOICEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxNumEtiquette, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RadStatusStrip1
		'
		Me.RadStatusStrip1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelStatusMessage})
		Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 857)
		Me.RadStatusStrip1.Name = "RadStatusStrip1"
		Me.RadStatusStrip1.Size = New System.Drawing.Size(1684, 24)
		Me.RadStatusStrip1.TabIndex = 3
		'
		'RadLabelStatusMessage
		'
		Me.RadLabelStatusMessage.Name = "RadLabelStatusMessage"
		Me.RadStatusStrip1.SetSpring(Me.RadLabelStatusMessage, False)
		Me.RadLabelStatusMessage.Text = "RadLabelElement1"
		Me.RadLabelStatusMessage.TextWrap = True
		'
		'RadPanelHaut
		'
		Me.RadPanelHaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(200, Byte), Integer))
		Me.RadPanelHaut.Controls.Add(Me.RadDateTimePickerDateEnd)
		Me.RadPanelHaut.Controls.Add(Me.RadDateTimePickerDayStard)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelDayEnd)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelDaySart)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelGlobalCathegory)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelProjectNameGlobal)
		Me.RadPanelHaut.Controls.Add(Me.RadLabelCentreNameGlobal)
		Me.RadPanelHaut.Location = New System.Drawing.Point(0, 2)
		Me.RadPanelHaut.Name = "RadPanelHaut"
		Me.RadPanelHaut.Size = New System.Drawing.Size(1920, 35)
		Me.RadPanelHaut.TabIndex = 45
		'
		'RadDateTimePickerDateEnd
		'
		Me.RadDateTimePickerDateEnd.BackColor = System.Drawing.Color.Transparent
		Me.RadDateTimePickerDateEnd.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerDateEnd.Location = New System.Drawing.Point(827, 6)
		Me.RadDateTimePickerDateEnd.Name = "RadDateTimePickerDateEnd"
		Me.RadDateTimePickerDateEnd.Size = New System.Drawing.Size(152, 24)
		Me.RadDateTimePickerDateEnd.TabIndex = 49
		Me.RadDateTimePickerDateEnd.TabStop = False
		Me.RadDateTimePickerDateEnd.Text = "Sunday, April 14, 2019"
		Me.RadDateTimePickerDateEnd.Value = New Date(2019, 4, 14, 10, 25, 51, 620)
		'
		'RadDateTimePickerDayStard
		'
		Me.RadDateTimePickerDayStard.BackColor = System.Drawing.Color.Transparent
		Me.RadDateTimePickerDayStard.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerDayStard.Location = New System.Drawing.Point(966, 7)
		Me.RadDateTimePickerDayStard.Name = "RadDateTimePickerDayStard"
		Me.RadDateTimePickerDayStard.Size = New System.Drawing.Size(152, 24)
		Me.RadDateTimePickerDayStard.TabIndex = 48
		Me.RadDateTimePickerDayStard.TabStop = False
		Me.RadDateTimePickerDayStard.Text = "Sunday, April 14, 2019"
		Me.RadDateTimePickerDayStard.Value = New Date(2019, 4, 14, 10, 25, 51, 620)
		'
		'RadLabelDayEnd
		'
		Me.RadLabelDayEnd.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelDayEnd.ForeColor = System.Drawing.Color.White
		Me.RadLabelDayEnd.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelDayEnd.Location = New System.Drawing.Point(1350, 6)
		Me.RadLabelDayEnd.Name = "RadLabelDayEnd"
		Me.RadLabelDayEnd.Size = New System.Drawing.Size(64, 18)
		Me.RadLabelDayEnd.TabIndex = 47
		Me.RadLabelDayEnd.Text = "RadLabel35"
		Me.RadLabelDayEnd.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabelDaySart
		'
		Me.RadLabelDaySart.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelDaySart.ForeColor = System.Drawing.Color.White
		Me.RadLabelDaySart.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelDaySart.Location = New System.Drawing.Point(1212, 6)
		Me.RadLabelDaySart.Name = "RadLabelDaySart"
		Me.RadLabelDaySart.Size = New System.Drawing.Size(64, 18)
		Me.RadLabelDaySart.TabIndex = 46
		Me.RadLabelDaySart.Text = "RadLabel35"
		Me.RadLabelDaySart.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabelGlobalCathegory
		'
		Me.RadLabelGlobalCathegory.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelGlobalCathegory.ForeColor = System.Drawing.Color.White
		Me.RadLabelGlobalCathegory.ImageAlignment = System.Drawing.ContentAlignment.TopLeft
		Me.RadLabelGlobalCathegory.Location = New System.Drawing.Point(633, 6)
		Me.RadLabelGlobalCathegory.Name = "RadLabelGlobalCathegory"
		Me.RadLabelGlobalCathegory.Size = New System.Drawing.Size(136, 18)
		Me.RadLabelGlobalCathegory.TabIndex = 45
		Me.RadLabelGlobalCathegory.Text = "RadLabelGlobalCathegory"
		Me.RadLabelGlobalCathegory.TextAlignment = System.Drawing.ContentAlignment.TopLeft
		'
		'RadLabelProjectNameGlobal
		'
		Me.RadLabelProjectNameGlobal.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelProjectNameGlobal.ForeColor = System.Drawing.Color.White
		Me.RadLabelProjectNameGlobal.Location = New System.Drawing.Point(300, 5)
		Me.RadLabelProjectNameGlobal.Name = "RadLabelProjectNameGlobal"
		Me.RadLabelProjectNameGlobal.Size = New System.Drawing.Size(144, 18)
		Me.RadLabelProjectNameGlobal.TabIndex = 44
		Me.RadLabelProjectNameGlobal.Text = "RadLabelAudioNameGlobal"
		'
		'RadLabelCentreNameGlobal
		'
		Me.RadLabelCentreNameGlobal.BackColor = System.Drawing.Color.Transparent
		Me.RadLabelCentreNameGlobal.ForeColor = System.Drawing.Color.White
		Me.RadLabelCentreNameGlobal.Location = New System.Drawing.Point(3, 5)
		Me.RadLabelCentreNameGlobal.Name = "RadLabelCentreNameGlobal"
		Me.RadLabelCentreNameGlobal.Size = New System.Drawing.Size(124, 18)
		Me.RadLabelCentreNameGlobal.TabIndex = 43
		Me.RadLabelCentreNameGlobal.Text = "RadLabelNomDuCentre"
		'
		'FILESPATHBindingSource
		'
		Me.FILESPATHBindingSource.DataMember = "FILES_PATH"
		Me.FILESPATHBindingSource.DataSource = Me.TAKEOFFDataSet2
		'
		'TAKEOFFDataSet2
		'
		Me.TAKEOFFDataSet2.DataSetName = "TAKEOFFDataSet2"
		Me.TAKEOFFDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'TAKEOFFDataSet
		'
		Me.TAKEOFFDataSet.DataSetName = "TAKEOFFDataSet"
		Me.TAKEOFFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ITEMSBindingSource
		'
		Me.ITEMSBindingSource.DataMember = "ITEMS"
		Me.ITEMSBindingSource.DataSource = Me.TAKEOFFDataSet1
		'
		'TAKEOFFDataSet1
		'
		Me.TAKEOFFDataSet1.DataSetName = "TAKEOFFDataSet1"
		Me.TAKEOFFDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ITEMSTableAdapter
		'
		Me.ITEMSTableAdapter.ClearBeforeFill = True
		'
		'FILES_PATHTableAdapter
		'
		Me.FILES_PATHTableAdapter.ClearBeforeFill = True
		'
		'RadCollapsiblePanelDocPathName
		'
		Me.RadCollapsiblePanelDocPathName.HeaderText = "Gestion des pièces jointes"
		Me.RadCollapsiblePanelDocPathName.IsExpanded = False
		Me.RadCollapsiblePanelDocPathName.Location = New System.Drawing.Point(13, 56)
		Me.RadCollapsiblePanelDocPathName.Name = "RadCollapsiblePanelDocPathName"
		Me.RadCollapsiblePanelDocPathName.OwnerBoundsCache = New System.Drawing.Rectangle(13, 56, 1458, 613)
		'
		'RadCollapsiblePanelDocPathName.PanelContainer
		'
		Me.RadCollapsiblePanelDocPathName.PanelContainer.Controls.Add(Me.RadGridViewItems)
		Me.RadCollapsiblePanelDocPathName.PanelContainer.Controls.Add(Me.RadGridView1)
		Me.RadCollapsiblePanelDocPathName.PanelContainer.Controls.Add(Me.GroupBox1)
		Me.RadCollapsiblePanelDocPathName.PanelContainer.Size = New System.Drawing.Size(0, 0)
		Me.RadCollapsiblePanelDocPathName.Size = New System.Drawing.Size(1458, 21)
		Me.RadCollapsiblePanelDocPathName.TabIndex = 54
		'
		'RadGridViewItems
		'
		Me.RadGridViewItems.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.RadGridViewItems.Location = New System.Drawing.Point(13, 10)
		'
		'
		'
		Me.RadGridViewItems.MasterTemplate.AllowSearchRow = True
		Me.RadGridViewItems.MasterTemplate.AutoExpandGroups = True
		GridViewDecimalColumn1.DataType = GetType(Integer)
		GridViewDecimalColumn1.FieldName = "INDEX"
		GridViewDecimalColumn1.HeaderText = "INDEX"
		GridViewDecimalColumn1.IsAutoGenerated = True
		GridViewDecimalColumn1.Name = "INDEX"
		GridViewDecimalColumn2.DataType = GetType(Integer)
		GridViewDecimalColumn2.FieldName = "ITEMS_INDEX"
		GridViewDecimalColumn2.HeaderText = "INDEX"
		GridViewDecimalColumn2.IsAutoGenerated = True
		GridViewDecimalColumn2.Name = "ITEMS_INDEX"
		GridViewDecimalColumn3.DataType = GetType(Integer)
		GridViewDecimalColumn3.FieldName = "ITEMS_PROJECT_INDEX"
		GridViewDecimalColumn3.HeaderText = "PROJECT INDEX"
		GridViewDecimalColumn3.IsAutoGenerated = True
		GridViewDecimalColumn3.Name = "ITEMS_PROJECT_INDEX"
		GridViewTextBoxColumn1.FieldName = "ITEMS_CODE"
		GridViewTextBoxColumn1.HeaderText = "ITEMS CODE"
		GridViewTextBoxColumn1.IsAutoGenerated = True
		GridViewTextBoxColumn1.Name = "ITEMS_CODE"
		GridViewTextBoxColumn1.Width = 110
		GridViewTextBoxColumn2.FieldName = "ITEMS_NAME"
		GridViewTextBoxColumn2.HeaderText = "ITEMS NAME"
		GridViewTextBoxColumn2.IsAutoGenerated = True
		GridViewTextBoxColumn2.Name = "ITEMS_NAME"
		GridViewTextBoxColumn2.Width = 200
		GridViewTextBoxColumn3.FieldName = "ITEMS_PARENT"
		GridViewTextBoxColumn3.HeaderText = "ITEMS PARENT"
		GridViewTextBoxColumn3.IsAutoGenerated = True
		GridViewTextBoxColumn3.Name = "ITEMS_PARENT"
		GridViewTextBoxColumn3.Width = 150
		Me.RadGridViewItems.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
		Me.RadGridViewItems.MasterTemplate.DataSource = Me.ITEMSBindingSource
		Me.RadGridViewItems.MasterTemplate.EnableAlternatingRowColor = True
		Me.RadGridViewItems.MasterTemplate.ViewDefinition = TableViewDefinition1
		Me.RadGridViewItems.Name = "RadGridViewItems"
		'
		'
		'
		Me.RadGridViewItems.RootElement.ControlBounds = New System.Drawing.Rectangle(13, 10, 240, 150)
		Me.RadGridViewItems.Size = New System.Drawing.Size(662, 339)
		Me.RadGridViewItems.TabIndex = 55
		'
		'RadGridView1
		'
		Me.RadGridView1.Location = New System.Drawing.Point(681, 10)
		'
		'
		'
		GridViewDecimalColumn4.DataType = GetType(Integer)
		GridViewDecimalColumn4.FieldName = "INDEX"
		GridViewDecimalColumn4.HeaderText = "INDEX"
		GridViewDecimalColumn4.IsAutoGenerated = True
		GridViewDecimalColumn4.Name = "INDEX"
		GridViewDecimalColumn5.DataType = GetType(Integer)
		GridViewDecimalColumn5.FieldName = "FILES_PATH_INDEX"
		GridViewDecimalColumn5.HeaderText = "FILES_PATH_INDEX"
		GridViewDecimalColumn5.IsAutoGenerated = True
		GridViewDecimalColumn5.Name = "FILES_PATH_INDEX"
		GridViewTextBoxColumn4.FieldName = "FILES_PATH_NAME"
		GridViewTextBoxColumn4.HeaderText = "FILES_PATH_NAME"
		GridViewTextBoxColumn4.IsAutoGenerated = True
		GridViewTextBoxColumn4.Name = "FILES_PATH_NAME"
		GridViewTextBoxColumn4.Width = 100
		GridViewTextBoxColumn5.FieldName = "FILES_PATH_FILE_NAME"
		GridViewTextBoxColumn5.HeaderText = "FILES_PATH_FILE_NAME"
		GridViewTextBoxColumn5.IsAutoGenerated = True
		GridViewTextBoxColumn5.Name = "FILES_PATH_FILE_NAME"
		GridViewTextBoxColumn5.Width = 150
		GridViewTextBoxColumn6.FieldName = "FILES_PATH_ITEMS_CATEGORY"
		GridViewTextBoxColumn6.HeaderText = "FILES_PATH_ITEMS_CATEGORY"
		GridViewTextBoxColumn6.IsAutoGenerated = True
		GridViewTextBoxColumn6.Name = "FILES_PATH_ITEMS_CATEGORY"
		GridViewTextBoxColumn6.Width = 150
		GridViewDecimalColumn6.DataType = GetType(Integer)
		GridViewDecimalColumn6.FieldName = "FILES_PATH_PROJECT_INDEX"
		GridViewDecimalColumn6.HeaderText = "FILES_PATH_PROJECT_INDEX"
		GridViewDecimalColumn6.IsAutoGenerated = True
		GridViewDecimalColumn6.Name = "FILES_PATH_PROJECT_INDEX"
		GridViewDecimalColumn6.Width = 150
		Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn4, GridViewDecimalColumn5, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewDecimalColumn6})
		Me.RadGridView1.MasterTemplate.DataSource = Me.FILESPATHBindingSource
		Me.RadGridView1.MasterTemplate.EnableAlternatingRowColor = True
		Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition2
		Me.RadGridView1.Name = "RadGridView1"
		Me.RadGridView1.Size = New System.Drawing.Size(717, 339)
		Me.RadGridView1.TabIndex = 54
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.RadButtonPathNameListView)
		Me.GroupBox1.Controls.Add(Me.RadButtonPathNameDetails)
		Me.GroupBox1.Controls.Add(Me.RadButtonParthnameIcon)
		Me.GroupBox1.Controls.Add(Me.RadButtonPathNameClear)
		Me.GroupBox1.Controls.Add(Me.RadButtonPathNameSave)
		Me.GroupBox1.Controls.Add(Me.RadListViewDocuments)
		Me.GroupBox1.Location = New System.Drawing.Point(13, 363)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1385, 210)
		Me.GroupBox1.TabIndex = 53
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "GroupBox1"
		'
		'RadButtonPathNameListView
		'
		Me.RadButtonPathNameListView.Location = New System.Drawing.Point(1320, 148)
		Me.RadButtonPathNameListView.Name = "RadButtonPathNameListView"
		Me.RadButtonPathNameListView.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonPathNameListView.TabIndex = 56
		Me.RadButtonPathNameListView.Text = "Liste"
		'
		'RadButtonPathNameDetails
		'
		Me.RadButtonPathNameDetails.Location = New System.Drawing.Point(1320, 116)
		Me.RadButtonPathNameDetails.Name = "RadButtonPathNameDetails"
		Me.RadButtonPathNameDetails.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonPathNameDetails.TabIndex = 55
		Me.RadButtonPathNameDetails.Text = "Details"
		'
		'RadButtonParthnameIcon
		'
		Me.RadButtonParthnameIcon.Location = New System.Drawing.Point(1320, 84)
		Me.RadButtonParthnameIcon.Name = "RadButtonParthnameIcon"
		Me.RadButtonParthnameIcon.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonParthnameIcon.TabIndex = 54
		Me.RadButtonParthnameIcon.Text = "Icon"
		'
		'RadButtonPathNameClear
		'
		Me.RadButtonPathNameClear.Location = New System.Drawing.Point(1320, 20)
		Me.RadButtonPathNameClear.Name = "RadButtonPathNameClear"
		Me.RadButtonPathNameClear.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonPathNameClear.TabIndex = 54
		Me.RadButtonPathNameClear.Text = "Clear"
		'
		'RadButtonPathNameSave
		'
		Me.RadButtonPathNameSave.Location = New System.Drawing.Point(1320, 52)
		Me.RadButtonPathNameSave.Name = "RadButtonPathNameSave"
		Me.RadButtonPathNameSave.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonPathNameSave.TabIndex = 53
		Me.RadButtonPathNameSave.Text = "Save"
		'
		'RadListViewDocuments
		'
		Me.RadListViewDocuments.AutoScroll = True
		Me.RadListViewDocuments.GroupItemSize = New System.Drawing.Size(200, 28)
		Me.RadListViewDocuments.ItemSize = New System.Drawing.Size(200, 28)
		Me.RadListViewDocuments.Location = New System.Drawing.Point(5, 20)
		Me.RadListViewDocuments.Name = "RadListViewDocuments"
		Me.RadListViewDocuments.Size = New System.Drawing.Size(1309, 173)
		Me.RadListViewDocuments.TabIndex = 46
		'
		'RadCollapsiblePanelInvoice
		'
		Me.RadCollapsiblePanelInvoice.HeaderText = "Invoices of Cost for Porject"
		Me.RadCollapsiblePanelInvoice.Location = New System.Drawing.Point(12, 83)
		Me.RadCollapsiblePanelInvoice.Name = "RadCollapsiblePanelInvoice"
		Me.RadCollapsiblePanelInvoice.OwnerBoundsCache = New System.Drawing.Rectangle(12, 83, 1459, 432)
		'
		'RadCollapsiblePanelInvoice.PanelContainer
		'
		Me.RadCollapsiblePanelInvoice.PanelContainer.Controls.Add(Me.GroupBox2)
		Me.RadCollapsiblePanelInvoice.PanelContainer.Size = New System.Drawing.Size(1108, 428)
		Me.RadCollapsiblePanelInvoice.Size = New System.Drawing.Size(1127, 470)
		Me.RadCollapsiblePanelInvoice.TabIndex = 55
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.RadDataLayout1)
		Me.GroupBox2.Controls.Add(Me.RadButtonProjectManager)
		Me.GroupBox2.Controls.Add(Me.RadButtonInvoiceNEW)
		Me.GroupBox2.Controls.Add(Me.RadButtonSupplierInvoiceDelete)
		Me.GroupBox2.Controls.Add(Me.RadButtonInvoiceUpdate)
		Me.GroupBox2.Controls.Add(Me.PictureBox1)
		Me.GroupBox2.Controls.Add(Me.RadGridViewInvoice)
		Me.GroupBox2.Location = New System.Drawing.Point(9, 5)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(2018, 444)
		Me.GroupBox2.TabIndex = 54
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "GroupBox2"
		'
		'RadDataLayout1
		'
		Me.RadDataLayout1.DataSource = Me.INVOICEBindingSource
		'
		'RadDataLayout1.LayoutControl
		'
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditor3)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorInvoiceIndex)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadDateTimePickerInvoiceCreatDate)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadDateTimePickerModifyDate)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadTextBoxInvoiceNumber)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorType)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorInvoiceProjectIndex)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorInvoiceItemIndex)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadTextBoxInvoiceSupplier)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorInvoiceAmount)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorInvoiceVATPourcent)
		Me.RadDataLayout1.LayoutControl.Controls.Add(Me.RadSpinEditorInvoiceVATAmount)
		Me.RadDataLayout1.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RadDataLayout1.LayoutControl.DrawBorder = False
		Me.RadDataLayout1.LayoutControl.Items.AddRange(New Telerik.WinControls.RadItem() {Me.DataLayoutControlItem13, Me.DataLayoutControlItem14, Me.DataLayoutControlItem15, Me.DataLayoutControlItem16, Me.DataLayoutControlItem17, Me.DataLayoutControlItem18, Me.DataLayoutControlItem19, Me.DataLayoutControlItem20, Me.DataLayoutControlItem21, Me.DataLayoutControlItem22, Me.DataLayoutControlItem23, Me.DataLayoutControlItem24})
		Me.RadDataLayout1.LayoutControl.Location = New System.Drawing.Point(0, 0)
		Me.RadDataLayout1.LayoutControl.Name = "LayoutControl"
		Me.RadDataLayout1.LayoutControl.Size = New System.Drawing.Size(319, 333)
		Me.RadDataLayout1.LayoutControl.TabIndex = 0
		Me.RadDataLayout1.Location = New System.Drawing.Point(738, 21)
		Me.RadDataLayout1.Name = "RadDataLayout1"
		Me.RadDataLayout1.Size = New System.Drawing.Size(319, 333)
		Me.RadDataLayout1.TabIndex = 54
		'
		'INVOICEBindingSource
		'
		Me.INVOICEBindingSource.DataMember = "INVOICE"
		Me.INVOICEBindingSource.DataSource = Me.TAKEOFFDataSet41
		'
		'TAKEOFFDataSet41
		'
		Me.TAKEOFFDataSet41.DataSetName = "TAKEOFFDataSet4"
		Me.TAKEOFFDataSet41.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'RadSpinEditor3
		'
		Me.RadSpinEditor3.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditor3.Location = New System.Drawing.Point(144, 2)
		Me.RadSpinEditor3.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor3.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor3.Name = "RadSpinEditor3"
		Me.RadSpinEditor3.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditor3.TabIndex = 55
		Me.RadSpinEditor3.TabStop = False
		'
		'RadSpinEditorInvoiceIndex
		'
		Me.RadSpinEditorInvoiceIndex.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceIndex.Location = New System.Drawing.Point(144, 28)
		Me.RadSpinEditorInvoiceIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceIndex.Name = "RadSpinEditorInvoiceIndex"
		Me.RadSpinEditorInvoiceIndex.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorInvoiceIndex.TabIndex = 56
		Me.RadSpinEditorInvoiceIndex.TabStop = False
		'
		'RadDateTimePickerInvoiceCreatDate
		'
		Me.RadDateTimePickerInvoiceCreatDate.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerInvoiceCreatDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_DATECREAT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadDateTimePickerInvoiceCreatDate.Location = New System.Drawing.Point(144, 54)
		Me.RadDateTimePickerInvoiceCreatDate.Name = "RadDateTimePickerInvoiceCreatDate"
		Me.RadDateTimePickerInvoiceCreatDate.Size = New System.Drawing.Size(171, 24)
		Me.RadDateTimePickerInvoiceCreatDate.TabIndex = 57
		Me.RadDateTimePickerInvoiceCreatDate.TabStop = False
		Me.RadDateTimePickerInvoiceCreatDate.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePickerInvoiceCreatDate.Value = New Date(2019, 6, 13, 21, 34, 17, 418)
		'
		'RadDateTimePickerModifyDate
		'
		Me.RadDateTimePickerModifyDate.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerModifyDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_DATEMODIFY", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadDateTimePickerModifyDate.Location = New System.Drawing.Point(144, 80)
		Me.RadDateTimePickerModifyDate.Name = "RadDateTimePickerModifyDate"
		Me.RadDateTimePickerModifyDate.Size = New System.Drawing.Size(171, 24)
		Me.RadDateTimePickerModifyDate.TabIndex = 58
		Me.RadDateTimePickerModifyDate.TabStop = False
		Me.RadDateTimePickerModifyDate.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePickerModifyDate.Value = New Date(2019, 6, 13, 21, 34, 17, 418)
		'
		'RadTextBoxInvoiceNumber
		'
		Me.RadTextBoxInvoiceNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVOICEBindingSource, "INVOICE_NUMBER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadTextBoxInvoiceNumber.Location = New System.Drawing.Point(144, 106)
		Me.RadTextBoxInvoiceNumber.Name = "RadTextBoxInvoiceNumber"
		Me.RadTextBoxInvoiceNumber.Size = New System.Drawing.Size(171, 24)
		Me.RadTextBoxInvoiceNumber.TabIndex = 59
		'
		'RadSpinEditorType
		'
		Me.RadSpinEditorType.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_TYPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorType.Location = New System.Drawing.Point(144, 132)
		Me.RadSpinEditorType.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorType.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorType.Name = "RadSpinEditorType"
		Me.RadSpinEditorType.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorType.TabIndex = 60
		Me.RadSpinEditorType.TabStop = False
		'
		'RadSpinEditorInvoiceProjectIndex
		'
		Me.RadSpinEditorInvoiceProjectIndex.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_PROJECT_INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceProjectIndex.Location = New System.Drawing.Point(144, 158)
		Me.RadSpinEditorInvoiceProjectIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceProjectIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceProjectIndex.Name = "RadSpinEditorInvoiceProjectIndex"
		Me.RadSpinEditorInvoiceProjectIndex.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorInvoiceProjectIndex.TabIndex = 61
		Me.RadSpinEditorInvoiceProjectIndex.TabStop = False
		'
		'RadSpinEditorInvoiceItemIndex
		'
		Me.RadSpinEditorInvoiceItemIndex.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_ITEMS_INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceItemIndex.Location = New System.Drawing.Point(144, 184)
		Me.RadSpinEditorInvoiceItemIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceItemIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceItemIndex.Name = "RadSpinEditorInvoiceItemIndex"
		Me.RadSpinEditorInvoiceItemIndex.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorInvoiceItemIndex.TabIndex = 62
		Me.RadSpinEditorInvoiceItemIndex.TabStop = False
		'
		'RadTextBoxInvoiceSupplier
		'
		Me.RadTextBoxInvoiceSupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVOICEBindingSource, "INVOICE_SUPPLIER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadTextBoxInvoiceSupplier.Location = New System.Drawing.Point(144, 210)
		Me.RadTextBoxInvoiceSupplier.Name = "RadTextBoxInvoiceSupplier"
		Me.RadTextBoxInvoiceSupplier.Size = New System.Drawing.Size(171, 24)
		Me.RadTextBoxInvoiceSupplier.TabIndex = 63
		'
		'RadSpinEditorInvoiceAmount
		'
		Me.RadSpinEditorInvoiceAmount.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_AMOUNT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceAmount.DecimalPlaces = 2
		Me.RadSpinEditorInvoiceAmount.Location = New System.Drawing.Point(144, 236)
		Me.RadSpinEditorInvoiceAmount.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceAmount.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceAmount.Name = "RadSpinEditorInvoiceAmount"
		Me.RadSpinEditorInvoiceAmount.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorInvoiceAmount.TabIndex = 64
		Me.RadSpinEditorInvoiceAmount.TabStop = False
		'
		'RadSpinEditorInvoiceVATPourcent
		'
		Me.RadSpinEditorInvoiceVATPourcent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_VATPOURCENT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceVATPourcent.DecimalPlaces = 2
		Me.RadSpinEditorInvoiceVATPourcent.Location = New System.Drawing.Point(144, 262)
		Me.RadSpinEditorInvoiceVATPourcent.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceVATPourcent.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceVATPourcent.Name = "RadSpinEditorInvoiceVATPourcent"
		Me.RadSpinEditorInvoiceVATPourcent.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorInvoiceVATPourcent.TabIndex = 65
		Me.RadSpinEditorInvoiceVATPourcent.TabStop = False
		'
		'RadSpinEditorInvoiceVATAmount
		'
		Me.RadSpinEditorInvoiceVATAmount.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_VATAMOUNT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceVATAmount.DecimalPlaces = 2
		Me.RadSpinEditorInvoiceVATAmount.Location = New System.Drawing.Point(144, 297)
		Me.RadSpinEditorInvoiceVATAmount.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceVATAmount.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceVATAmount.Name = "RadSpinEditorInvoiceVATAmount"
		Me.RadSpinEditorInvoiceVATAmount.Size = New System.Drawing.Size(171, 24)
		Me.RadSpinEditorInvoiceVATAmount.TabIndex = 66
		Me.RadSpinEditorInvoiceVATAmount.TabStop = False
		'
		'DataLayoutControlItem13
		'
		Me.DataLayoutControlItem13.AssociatedControl = Me.RadSpinEditor3
		Me.DataLayoutControlItem13.Bounds = New System.Drawing.Rectangle(0, 0, 317, 26)
		Me.DataLayoutControlItem13.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem13.Name = "DataLayoutControlItem13"
		Me.DataLayoutControlItem13.Text = "INDEX"
		Me.DataLayoutControlItem13.TextFixedSize = 140
		Me.DataLayoutControlItem13.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem13.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem14
		'
		Me.DataLayoutControlItem14.AssociatedControl = Me.RadSpinEditorInvoiceIndex
		Me.DataLayoutControlItem14.Bounds = New System.Drawing.Rectangle(0, 26, 317, 26)
		Me.DataLayoutControlItem14.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem14.Name = "DataLayoutControlItem14"
		Me.DataLayoutControlItem14.Text = "INVOICE_INDEX"
		Me.DataLayoutControlItem14.TextFixedSize = 140
		Me.DataLayoutControlItem14.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem14.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem15
		'
		Me.DataLayoutControlItem15.AssociatedControl = Me.RadDateTimePickerInvoiceCreatDate
		Me.DataLayoutControlItem15.Bounds = New System.Drawing.Rectangle(0, 52, 317, 26)
		Me.DataLayoutControlItem15.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem15.Name = "DataLayoutControlItem15"
		Me.DataLayoutControlItem15.Text = "INVOICE_DATECREAT"
		Me.DataLayoutControlItem15.TextFixedSize = 140
		Me.DataLayoutControlItem15.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem15.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem16
		'
		Me.DataLayoutControlItem16.AssociatedControl = Me.RadDateTimePickerModifyDate
		Me.DataLayoutControlItem16.Bounds = New System.Drawing.Rectangle(0, 78, 317, 26)
		Me.DataLayoutControlItem16.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem16.Name = "DataLayoutControlItem16"
		Me.DataLayoutControlItem16.Text = "INVOICE_DATEMODIFY"
		Me.DataLayoutControlItem16.TextFixedSize = 140
		Me.DataLayoutControlItem16.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem16.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem17
		'
		Me.DataLayoutControlItem17.AssociatedControl = Me.RadTextBoxInvoiceNumber
		Me.DataLayoutControlItem17.Bounds = New System.Drawing.Rectangle(0, 104, 317, 26)
		Me.DataLayoutControlItem17.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem17.Name = "DataLayoutControlItem17"
		Me.DataLayoutControlItem17.Text = "INVOICE_NUMBER"
		Me.DataLayoutControlItem17.TextFixedSize = 140
		Me.DataLayoutControlItem17.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem17.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem18
		'
		Me.DataLayoutControlItem18.AssociatedControl = Me.RadSpinEditorType
		Me.DataLayoutControlItem18.Bounds = New System.Drawing.Rectangle(0, 130, 317, 26)
		Me.DataLayoutControlItem18.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem18.Name = "DataLayoutControlItem18"
		Me.DataLayoutControlItem18.Text = "INVOICE_TYPE"
		Me.DataLayoutControlItem18.TextFixedSize = 140
		Me.DataLayoutControlItem18.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem18.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem19
		'
		Me.DataLayoutControlItem19.AssociatedControl = Me.RadSpinEditorInvoiceProjectIndex
		Me.DataLayoutControlItem19.Bounds = New System.Drawing.Rectangle(0, 156, 317, 26)
		Me.DataLayoutControlItem19.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem19.Name = "DataLayoutControlItem19"
		Me.DataLayoutControlItem19.Text = "INVOICE_PROJECT_INDEX"
		Me.DataLayoutControlItem19.TextFixedSize = 140
		Me.DataLayoutControlItem19.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem19.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem20
		'
		Me.DataLayoutControlItem20.AssociatedControl = Me.RadSpinEditorInvoiceItemIndex
		Me.DataLayoutControlItem20.Bounds = New System.Drawing.Rectangle(0, 182, 317, 26)
		Me.DataLayoutControlItem20.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem20.Name = "DataLayoutControlItem20"
		Me.DataLayoutControlItem20.Text = "INVOICE_ITEMS_INDEX"
		Me.DataLayoutControlItem20.TextFixedSize = 140
		Me.DataLayoutControlItem20.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem20.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem21
		'
		Me.DataLayoutControlItem21.AssociatedControl = Me.RadTextBoxInvoiceSupplier
		Me.DataLayoutControlItem21.Bounds = New System.Drawing.Rectangle(0, 208, 317, 26)
		Me.DataLayoutControlItem21.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem21.Name = "DataLayoutControlItem21"
		Me.DataLayoutControlItem21.Text = "INVOICE_SUPPLIER"
		Me.DataLayoutControlItem21.TextFixedSize = 140
		Me.DataLayoutControlItem21.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem21.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem22
		'
		Me.DataLayoutControlItem22.AssociatedControl = Me.RadSpinEditorInvoiceAmount
		Me.DataLayoutControlItem22.Bounds = New System.Drawing.Rectangle(0, 234, 317, 26)
		Me.DataLayoutControlItem22.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem22.Name = "DataLayoutControlItem22"
		Me.DataLayoutControlItem22.Text = "INVOICE_AMOUNT"
		Me.DataLayoutControlItem22.TextFixedSize = 140
		Me.DataLayoutControlItem22.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem22.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem23
		'
		Me.DataLayoutControlItem23.AssociatedControl = Me.RadSpinEditorInvoiceVATPourcent
		Me.DataLayoutControlItem23.Bounds = New System.Drawing.Rectangle(0, 260, 317, 26)
		Me.DataLayoutControlItem23.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem23.Name = "DataLayoutControlItem23"
		Me.DataLayoutControlItem23.Text = "INVOICE_VATPOURCENT"
		Me.DataLayoutControlItem23.TextFixedSize = 140
		Me.DataLayoutControlItem23.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem23.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem24
		'
		Me.DataLayoutControlItem24.AssociatedControl = Me.RadSpinEditorInvoiceVATAmount
		Me.DataLayoutControlItem24.Bounds = New System.Drawing.Rectangle(0, 286, 317, 45)
		Me.DataLayoutControlItem24.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem24.Name = "DataLayoutControlItem24"
		Me.DataLayoutControlItem24.Text = "INVOICE_VATAMOUNT"
		Me.DataLayoutControlItem24.TextFixedSize = 140
		Me.DataLayoutControlItem24.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem24.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'RadButtonProjectManager
		'
		Me.RadButtonProjectManager.Location = New System.Drawing.Point(8, 361)
		Me.RadButtonProjectManager.Name = "RadButtonProjectManager"
		Me.RadButtonProjectManager.Size = New System.Drawing.Size(217, 26)
		Me.RadButtonProjectManager.TabIndex = 58
		Me.RadButtonProjectManager.Text = "Add new Project"
		'
		'RadButtonInvoiceNEW
		'
		Me.RadButtonInvoiceNEW.Location = New System.Drawing.Point(868, 360)
		Me.RadButtonInvoiceNEW.Name = "RadButtonInvoiceNEW"
		Me.RadButtonInvoiceNEW.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonInvoiceNEW.TabIndex = 59
		Me.RadButtonInvoiceNEW.Text = "New"
		'
		'RadButtonSupplierInvoiceDelete
		'
		Me.RadButtonSupplierInvoiceDelete.Location = New System.Drawing.Point(803, 360)
		Me.RadButtonSupplierInvoiceDelete.Name = "RadButtonSupplierInvoiceDelete"
		Me.RadButtonSupplierInvoiceDelete.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonSupplierInvoiceDelete.TabIndex = 58
		Me.RadButtonSupplierInvoiceDelete.Text = "Delete"
		'
		'RadButtonInvoiceUpdate
		'
		Me.RadButtonInvoiceUpdate.Location = New System.Drawing.Point(738, 360)
		Me.RadButtonInvoiceUpdate.Name = "RadButtonInvoiceUpdate"
		Me.RadButtonInvoiceUpdate.Size = New System.Drawing.Size(59, 26)
		Me.RadButtonInvoiceUpdate.TabIndex = 57
		Me.RadButtonInvoiceUpdate.Text = "Update"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.PrevisionFlex.My.Resources.Resources.reflech_25x25
		Me.PictureBox1.Location = New System.Drawing.Point(933, 361)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
		Me.PictureBox1.TabIndex = 55
		Me.PictureBox1.TabStop = False
		'
		'RadGridViewInvoice
		'
		Me.RadGridViewInvoice.Location = New System.Drawing.Point(8, 24)
		'
		'
		'
		GridViewDecimalColumn7.DataType = GetType(Integer)
		GridViewDecimalColumn7.FieldName = "INDEX"
		GridViewDecimalColumn7.HeaderText = "INDEX"
		GridViewDecimalColumn7.IsAutoGenerated = True
		GridViewDecimalColumn7.Name = "INDEX"
		GridViewDecimalColumn8.DataType = GetType(Integer)
		GridViewDecimalColumn8.FieldName = "INVOICE_INDEX"
		GridViewDecimalColumn8.HeaderText = "INVOICE INDEX"
		GridViewDecimalColumn8.IsAutoGenerated = True
		GridViewDecimalColumn8.Name = "INVOICE_INDEX"
		GridViewDateTimeColumn1.FieldName = "INVOICE_DATECREAT"
		GridViewDateTimeColumn1.HeaderText = "DATE CREAT"
		GridViewDateTimeColumn1.IsAutoGenerated = True
		GridViewDateTimeColumn1.Name = "INVOICE_DATECREAT"
		GridViewDateTimeColumn1.Width = 90
		GridViewDateTimeColumn2.FieldName = "INVOICE_DATEMODIFY"
		GridViewDateTimeColumn2.HeaderText = "DATE MODIFY"
		GridViewDateTimeColumn2.IsAutoGenerated = True
		GridViewDateTimeColumn2.Name = "INVOICE_DATEMODIFY"
		GridViewDateTimeColumn2.Width = 90
		GridViewTextBoxColumn7.FieldName = "INVOICE_NUMBER"
		GridViewTextBoxColumn7.HeaderText = "NUMBER"
		GridViewTextBoxColumn7.IsAutoGenerated = True
		GridViewTextBoxColumn7.Name = "INVOICE_NUMBER"
		GridViewTextBoxColumn7.Width = 90
		GridViewDecimalColumn9.DataType = GetType(Integer)
		GridViewDecimalColumn9.FieldName = "INVOICE_TYPE"
		GridViewDecimalColumn9.HeaderText = "TYPE"
		GridViewDecimalColumn9.IsAutoGenerated = True
		GridViewDecimalColumn9.Name = "INVOICE_TYPE"
		GridViewDecimalColumn9.Width = 60
		GridViewDecimalColumn10.DataType = GetType(Integer)
		GridViewDecimalColumn10.FieldName = "INVOICE_PROJECT_INDEX"
		GridViewDecimalColumn10.HeaderText = "PROJECT INDEX"
		GridViewDecimalColumn10.IsAutoGenerated = True
		GridViewDecimalColumn10.Name = "INVOICE_PROJECT_INDEX"
		GridViewDecimalColumn10.Width = 60
		GridViewDecimalColumn11.DataType = GetType(Integer)
		GridViewDecimalColumn11.FieldName = "INVOICE_ITEMS_INDEX"
		GridViewDecimalColumn11.HeaderText = "ITEMS INDEX"
		GridViewDecimalColumn11.IsAutoGenerated = True
		GridViewDecimalColumn11.Name = "INVOICE_ITEMS_INDEX"
		GridViewDecimalColumn11.Width = 60
		GridViewTextBoxColumn8.FieldName = "INVOICE_SUPPLIER"
		GridViewTextBoxColumn8.HeaderText = "SUPPLIER"
		GridViewTextBoxColumn8.IsAutoGenerated = True
		GridViewTextBoxColumn8.Name = "INVOICE_SUPPLIER"
		GridViewTextBoxColumn8.Width = 120
		GridViewDecimalColumn12.DataType = GetType(Single)
		GridViewDecimalColumn12.FieldName = "INVOICE_AMOUNT"
		GridViewDecimalColumn12.HeaderText = "INVOICE TOTAL"
		GridViewDecimalColumn12.IsAutoGenerated = True
		GridViewDecimalColumn12.Name = "INVOICE_AMOUNT"
		GridViewDecimalColumn12.Width = 90
		GridViewDecimalColumn13.DataType = GetType(Single)
		GridViewDecimalColumn13.FieldName = "INVOICE_VATPOURCENT"
		GridViewDecimalColumn13.HeaderText = "VAT %"
		GridViewDecimalColumn13.IsAutoGenerated = True
		GridViewDecimalColumn13.Name = "INVOICE_VATPOURCENT"
		GridViewDecimalColumn13.Width = 60
		GridViewDecimalColumn14.DataType = GetType(Single)
		GridViewDecimalColumn14.FieldName = "INVOICE_VATAMOUNT"
		GridViewDecimalColumn14.HeaderText = "VAT TOTAL"
		GridViewDecimalColumn14.IsAutoGenerated = True
		GridViewDecimalColumn14.Name = "INVOICE_VATAMOUNT"
		GridViewDecimalColumn14.Width = 80
		Me.RadGridViewInvoice.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn7, GridViewDecimalColumn8, GridViewDateTimeColumn1, GridViewDateTimeColumn2, GridViewTextBoxColumn7, GridViewDecimalColumn9, GridViewDecimalColumn10, GridViewDecimalColumn11, GridViewTextBoxColumn8, GridViewDecimalColumn12, GridViewDecimalColumn13, GridViewDecimalColumn14})
		Me.RadGridViewInvoice.MasterTemplate.DataSource = Me.INVOICEBindingSource
		Me.RadGridViewInvoice.MasterTemplate.ViewDefinition = TableViewDefinition3
		Me.RadGridViewInvoice.Name = "RadGridViewInvoice"
		Me.RadGridViewInvoice.Size = New System.Drawing.Size(719, 330)
		Me.RadGridViewInvoice.TabIndex = 1
		'
		'RadSpinEditor1
		'
		Me.RadSpinEditor1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditor1.Location = New System.Drawing.Point(89, 3)
		Me.RadSpinEditor1.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor1.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor1.Name = "RadSpinEditor1"
		Me.RadSpinEditor1.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditor1.TabIndex = 55
		Me.RadSpinEditor1.TabStop = False
		'
		'RadSpinEditor2
		'
		Me.RadSpinEditor2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditor2.Location = New System.Drawing.Point(89, 9)
		Me.RadSpinEditor2.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor2.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor2.Name = "RadSpinEditor2"
		Me.RadSpinEditor2.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditor2.TabIndex = 56
		Me.RadSpinEditor2.TabStop = False
		'
		'RadDateTimePicker1
		'
		Me.RadDateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_DATECREAT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadDateTimePicker1.Location = New System.Drawing.Point(89, 29)
		Me.RadDateTimePicker1.Name = "RadDateTimePicker1"
		Me.RadDateTimePicker1.Size = New System.Drawing.Size(259, 20)
		Me.RadDateTimePicker1.TabIndex = 57
		Me.RadDateTimePicker1.TabStop = False
		Me.RadDateTimePicker1.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePicker1.Value = New Date(2019, 6, 13, 18, 0, 56, 793)
		'
		'RadDateTimePicker2
		'
		Me.RadDateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_DATEMODIFY", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadDateTimePicker2.Location = New System.Drawing.Point(89, 16)
		Me.RadDateTimePicker2.Name = "RadDateTimePicker2"
		Me.RadDateTimePicker2.Size = New System.Drawing.Size(259, 20)
		Me.RadDateTimePicker2.TabIndex = 58
		Me.RadDateTimePicker2.TabStop = False
		Me.RadDateTimePicker2.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePicker2.Value = New Date(2019, 6, 13, 18, 0, 56, 838)
		'
		'RadTextBox1
		'
		Me.RadTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVOICEBindingSource, "INVOICE_NUMBER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadTextBox1.Location = New System.Drawing.Point(89, 29)
		Me.RadTextBox1.Name = "RadTextBox1"
		Me.RadTextBox1.Size = New System.Drawing.Size(259, 20)
		Me.RadTextBox1.TabIndex = 59
		'
		'RadSpinEditorInvoiceType
		'
		Me.RadSpinEditorInvoiceType.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_TYPE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorInvoiceType.Location = New System.Drawing.Point(89, 68)
		Me.RadSpinEditorInvoiceType.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorInvoiceType.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorInvoiceType.Name = "RadSpinEditorInvoiceType"
		Me.RadSpinEditorInvoiceType.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.RadSpinEditorInvoiceType.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditorInvoiceType.TabIndex = 60
		Me.RadSpinEditorInvoiceType.TabStop = False
		Me.RadSpinEditorInvoiceType.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'RadSpinEditorProjectIndex
		'
		Me.RadSpinEditorProjectIndex.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_PROJECT_INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorProjectIndex.Location = New System.Drawing.Point(89, 15)
		Me.RadSpinEditorProjectIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorProjectIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorProjectIndex.Name = "RadSpinEditorProjectIndex"
		Me.RadSpinEditorProjectIndex.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.RadSpinEditorProjectIndex.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditorProjectIndex.TabIndex = 61
		Me.RadSpinEditorProjectIndex.TabStop = False
		Me.RadSpinEditorProjectIndex.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'RadSpinEditor5
		'
		Me.RadSpinEditor5.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_ITEMS_INDEX", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditor5.Location = New System.Drawing.Point(89, 28)
		Me.RadSpinEditor5.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor5.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor5.Name = "RadSpinEditor5"
		Me.RadSpinEditor5.NullableValue = New Decimal(New Integer() {1, 0, 0, 0})
		Me.RadSpinEditor5.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditor5.TabIndex = 62
		Me.RadSpinEditor5.TabStop = False
		Me.RadSpinEditor5.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'RadTextBox2
		'
		Me.RadTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.INVOICEBindingSource, "INVOICE_SUPPLIER", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadTextBox2.Location = New System.Drawing.Point(89, 66)
		Me.RadTextBox2.Name = "RadTextBox2"
		Me.RadTextBox2.Size = New System.Drawing.Size(259, 20)
		Me.RadTextBox2.TabIndex = 63
		'
		'RadSpinEditor6
		'
		Me.RadSpinEditor6.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_AMOUNT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditor6.Location = New System.Drawing.Point(89, 39)
		Me.RadSpinEditor6.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor6.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor6.Name = "RadSpinEditor6"
		Me.RadSpinEditor6.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditor6.TabIndex = 64
		Me.RadSpinEditor6.TabStop = False
		'
		'RadSpinEditorVATPourcent
		'
		Me.RadSpinEditorVATPourcent.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_VATPOURCENT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditorVATPourcent.Location = New System.Drawing.Point(89, 62)
		Me.RadSpinEditorVATPourcent.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorVATPourcent.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorVATPourcent.Name = "RadSpinEditorVATPourcent"
		Me.RadSpinEditorVATPourcent.NullableValue = New Decimal(New Integer() {20, 0, 0, 0})
		Me.RadSpinEditorVATPourcent.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditorVATPourcent.TabIndex = 65
		Me.RadSpinEditorVATPourcent.TabStop = False
		Me.RadSpinEditorVATPourcent.Value = New Decimal(New Integer() {20, 0, 0, 0})
		'
		'RadSpinEditor8
		'
		Me.RadSpinEditor8.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.INVOICEBindingSource, "INVOICE_VATAMOUNT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
		Me.RadSpinEditor8.Location = New System.Drawing.Point(89, 147)
		Me.RadSpinEditor8.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditor8.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditor8.Name = "RadSpinEditor8"
		Me.RadSpinEditor8.Size = New System.Drawing.Size(259, 20)
		Me.RadSpinEditor8.TabIndex = 66
		Me.RadSpinEditor8.TabStop = False
		'
		'DataLayoutControlItem1
		'
		Me.DataLayoutControlItem1.AssociatedControl = Me.RadSpinEditor1
		Me.DataLayoutControlItem1.Bounds = New System.Drawing.Rectangle(0, 0, 352, 26)
		Me.DataLayoutControlItem1.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem1.Name = "DataLayoutControlItem1"
		Me.DataLayoutControlItem1.Text = "INDEX"
		Me.DataLayoutControlItem1.TextFixedSize = 140
		Me.DataLayoutControlItem1.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem1.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem2
		'
		Me.DataLayoutControlItem2.AssociatedControl = Me.RadSpinEditor2
		Me.DataLayoutControlItem2.Bounds = New System.Drawing.Rectangle(0, 0, 352, 39)
		Me.DataLayoutControlItem2.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem2.Name = "DataLayoutControlItem2"
		Me.DataLayoutControlItem2.Text = "INVOICE_INDEX"
		Me.DataLayoutControlItem2.TextFixedSize = 140
		Me.DataLayoutControlItem2.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem2.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem3
		'
		Me.DataLayoutControlItem3.AssociatedControl = Me.RadDateTimePicker1
		Me.DataLayoutControlItem3.Bounds = New System.Drawing.Rectangle(0, 0, 352, 78)
		Me.DataLayoutControlItem3.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem3.Name = "DataLayoutControlItem3"
		Me.DataLayoutControlItem3.Text = "INVOICE_DATECREAT"
		Me.DataLayoutControlItem3.TextFixedSize = 140
		Me.DataLayoutControlItem3.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem3.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem4
		'
		Me.DataLayoutControlItem4.AssociatedControl = Me.RadDateTimePicker2
		Me.DataLayoutControlItem4.Bounds = New System.Drawing.Rectangle(0, 0, 352, 52)
		Me.DataLayoutControlItem4.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem4.Name = "DataLayoutControlItem4"
		Me.DataLayoutControlItem4.Text = "INVOICE_DATEMODIFY"
		Me.DataLayoutControlItem4.TextFixedSize = 140
		Me.DataLayoutControlItem4.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem4.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem5
		'
		Me.DataLayoutControlItem5.AssociatedControl = Me.RadTextBox1
		Me.DataLayoutControlItem5.Bounds = New System.Drawing.Rectangle(0, 0, 352, 78)
		Me.DataLayoutControlItem5.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem5.Name = "DataLayoutControlItem5"
		Me.DataLayoutControlItem5.Text = "INVOICE_NUMBER"
		Me.DataLayoutControlItem5.TextFixedSize = 140
		Me.DataLayoutControlItem5.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem5.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem6
		'
		Me.DataLayoutControlItem6.AssociatedControl = Me.RadSpinEditorInvoiceType
		Me.DataLayoutControlItem6.Bounds = New System.Drawing.Rectangle(0, 0, 352, 156)
		Me.DataLayoutControlItem6.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem6.Name = "DataLayoutControlItem6"
		Me.DataLayoutControlItem6.Text = "INVOICE_TYPE"
		Me.DataLayoutControlItem6.TextFixedSize = 140
		Me.DataLayoutControlItem6.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem6.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem7
		'
		Me.DataLayoutControlItem7.AssociatedControl = Me.RadSpinEditorProjectIndex
		Me.DataLayoutControlItem7.Bounds = New System.Drawing.Rectangle(0, 0, 352, 51)
		Me.DataLayoutControlItem7.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem7.Name = "DataLayoutControlItem7"
		Me.DataLayoutControlItem7.Text = "INVOICE_PROJECT_INDEX"
		Me.DataLayoutControlItem7.TextFixedSize = 140
		Me.DataLayoutControlItem7.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem7.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem8
		'
		Me.DataLayoutControlItem8.AssociatedControl = Me.RadSpinEditor5
		Me.DataLayoutControlItem8.Bounds = New System.Drawing.Rectangle(0, 0, 352, 76)
		Me.DataLayoutControlItem8.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem8.Name = "DataLayoutControlItem8"
		Me.DataLayoutControlItem8.Text = "INVOICE_ITEMS_INDEX"
		Me.DataLayoutControlItem8.TextFixedSize = 140
		Me.DataLayoutControlItem8.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem8.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem9
		'
		Me.DataLayoutControlItem9.AssociatedControl = Me.RadTextBox2
		Me.DataLayoutControlItem9.Bounds = New System.Drawing.Rectangle(0, 0, 352, 153)
		Me.DataLayoutControlItem9.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem9.Name = "DataLayoutControlItem9"
		Me.DataLayoutControlItem9.Text = "INVOICE_SUPPLIER"
		Me.DataLayoutControlItem9.TextFixedSize = 140
		Me.DataLayoutControlItem9.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem9.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem10
		'
		Me.DataLayoutControlItem10.AssociatedControl = Me.RadSpinEditor6
		Me.DataLayoutControlItem10.Bounds = New System.Drawing.Rectangle(0, 0, 352, 99)
		Me.DataLayoutControlItem10.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem10.Name = "DataLayoutControlItem10"
		Me.DataLayoutControlItem10.Text = "INVOICE_AMOUNT"
		Me.DataLayoutControlItem10.TextFixedSize = 140
		Me.DataLayoutControlItem10.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem10.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem11
		'
		Me.DataLayoutControlItem11.AssociatedControl = Me.RadSpinEditorVATPourcent
		Me.DataLayoutControlItem11.Bounds = New System.Drawing.Rectangle(0, 0, 352, 144)
		Me.DataLayoutControlItem11.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem11.Name = "DataLayoutControlItem11"
		Me.DataLayoutControlItem11.Text = "INVOICE_VATPOURCENT"
		Me.DataLayoutControlItem11.TextFixedSize = 140
		Me.DataLayoutControlItem11.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem11.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem12
		'
		Me.DataLayoutControlItem12.AssociatedControl = Me.RadSpinEditor8
		Me.DataLayoutControlItem12.Bounds = New System.Drawing.Rectangle(0, 0, 352, 315)
		Me.DataLayoutControlItem12.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem12.Name = "DataLayoutControlItem12"
		Me.DataLayoutControlItem12.Text = "INVOICE_VATAMOUNT"
		Me.DataLayoutControlItem12.TextFixedSize = 140
		Me.DataLayoutControlItem12.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem12.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'TAKEOFFDataSetInvoice
		'
		Me.TAKEOFFDataSetInvoice.DataSetName = "TAKEOFFDataSetInvoice"
		Me.TAKEOFFDataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'INVOICETableAdapter
		'
		Me.INVOICETableAdapter.ClearBeforeFill = True
		'
		'TAKEOFFDataSet42
		'
		Me.TAKEOFFDataSet42.DataSetName = "TAKEOFFDataSet4"
		Me.TAKEOFFDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'INVOICEBindingSource1
		'
		Me.INVOICEBindingSource1.DataMember = "INVOICE"
		Me.INVOICEBindingSource1.DataSource = Me.TAKEOFFDataSet42
		'
		'DataLayoutControlItem25
		'
		Me.DataLayoutControlItem25.AssociatedControl = Me.RadSpinEditor3
		Me.DataLayoutControlItem25.Bounds = New System.Drawing.Rectangle(0, 0, 317, 26)
		Me.DataLayoutControlItem25.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem25.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
		Me.DataLayoutControlItem25.Name = "DataLayoutControlItem25"
		Me.DataLayoutControlItem25.Text = "INDEX"
		Me.DataLayoutControlItem25.TextFixedSize = 140
		Me.DataLayoutControlItem25.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem25.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
		Me.DataLayoutControlItem25.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		Me.DataLayoutControlItem25.UseCompatibleTextRendering = False
		'
		'RadBindingNavigator1
		'
		Me.RadBindingNavigator1.Dock = System.Windows.Forms.DockStyle.Top
		Me.RadBindingNavigator1.Location = New System.Drawing.Point(0, 0)
		Me.RadBindingNavigator1.Name = "RadBindingNavigator1"
		Me.RadBindingNavigator1.Rows.AddRange(New Telerik.WinControls.UI.CommandBarRowElement() {Me.CommandBarRowElement1})
		Me.RadBindingNavigator1.Size = New System.Drawing.Size(1684, 30)
		Me.RadBindingNavigator1.TabIndex = 56
		'
		'CommandBarRowElement1
		'
		Me.CommandBarRowElement1.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.RowElement
		Me.CommandBarRowElement1.MinSize = New System.Drawing.Size(25, 25)
		Me.CommandBarRowElement1.Name = "CommandBarRowElement1"
		Me.CommandBarRowElement1.Strips.AddRange(New Telerik.WinControls.UI.CommandBarStripElement() {Me.CommandBarStripElement1, Me.CommandBarStripElement2})
		'
		'CommandBarStripElement1
		'
		Me.CommandBarStripElement1.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.FirstStrip
		Me.CommandBarStripElement1.DisplayName = "CommandBarStripElement1"
		Me.CommandBarStripElement1.EnableDragging = False
		'
		'
		'
		Me.CommandBarStripElement1.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		Me.CommandBarStripElement1.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarButton1, Me.CommandBarSeparator1, Me.CommandBarButton2, Me.CommandBarSeparator2, Me.CommandBarTextBox1, Me.CommandBarLabel1, Me.CommandBarSeparator3, Me.CommandBarButton3, Me.CommandBarSeparator4, Me.CommandBarButton4})
		Me.CommandBarStripElement1.MinSize = New System.Drawing.Size(0, 0)
		'
		'
		'
		Me.CommandBarStripElement1.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		CType(Me.CommandBarStripElement1.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		CType(Me.CommandBarStripElement1.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		'
		'CommandBarButton1
		'
		Me.CommandBarButton1.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.FirstItem
		Me.CommandBarButton1.Image = CType(resources.GetObject("CommandBarButton1.Image"), System.Drawing.Image)
		Me.CommandBarButton1.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CommandBarButton1.Name = "CommandBarButton1"
		Me.CommandBarButton1.SvgImageXml = resources.GetString("CommandBarButton1.SvgImageXml")
		'
		'CommandBarSeparator1
		'
		Me.CommandBarSeparator1.Name = "CommandBarSeparator1"
		Me.CommandBarSeparator1.VisibleInOverflowMenu = False
		'
		'CommandBarButton2
		'
		Me.CommandBarButton2.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.PreviousItem
		Me.CommandBarButton2.Image = CType(resources.GetObject("CommandBarButton2.Image"), System.Drawing.Image)
		Me.CommandBarButton2.Name = "CommandBarButton2"
		Me.CommandBarButton2.SvgImageXml = resources.GetString("CommandBarButton2.SvgImageXml")
		'
		'CommandBarSeparator2
		'
		Me.CommandBarSeparator2.Name = "CommandBarSeparator2"
		Me.CommandBarSeparator2.VisibleInOverflowMenu = False
		'
		'CommandBarTextBox1
		'
		Me.CommandBarTextBox1.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.PositionItem
		Me.CommandBarTextBox1.Name = "CommandBarTextBox1"
		'
		'CommandBarLabel1
		'
		Me.CommandBarLabel1.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.CountItem
		Me.CommandBarLabel1.Name = "CommandBarLabel1"
		Me.CommandBarLabel1.Text = "of {0}"
		'
		'CommandBarSeparator3
		'
		Me.CommandBarSeparator3.Name = "CommandBarSeparator3"
		Me.CommandBarSeparator3.VisibleInOverflowMenu = False
		'
		'CommandBarButton3
		'
		Me.CommandBarButton3.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.NextItem
		Me.CommandBarButton3.Image = CType(resources.GetObject("CommandBarButton3.Image"), System.Drawing.Image)
		Me.CommandBarButton3.Name = "CommandBarButton3"
		Me.CommandBarButton3.SvgImageXml = resources.GetString("CommandBarButton3.SvgImageXml")
		'
		'CommandBarSeparator4
		'
		Me.CommandBarSeparator4.Name = "CommandBarSeparator4"
		Me.CommandBarSeparator4.VisibleInOverflowMenu = False
		'
		'CommandBarButton4
		'
		Me.CommandBarButton4.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.LastItem
		Me.CommandBarButton4.Image = CType(resources.GetObject("CommandBarButton4.Image"), System.Drawing.Image)
		Me.CommandBarButton4.Name = "CommandBarButton4"
		Me.CommandBarButton4.SvgImageXml = resources.GetString("CommandBarButton4.SvgImageXml")
		'
		'CommandBarStripElement2
		'
		Me.CommandBarStripElement2.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.SecondStrip
		Me.CommandBarStripElement2.DisplayName = "CommandBarStripElement2"
		Me.CommandBarStripElement2.EnableDragging = False
		'
		'
		'
		Me.CommandBarStripElement2.Grip.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		Me.CommandBarStripElement2.Items.AddRange(New Telerik.WinControls.UI.RadCommandBarBaseItem() {Me.CommandBarButton5, Me.CommandBarSeparator5, Me.CommandBarButton6})
		Me.CommandBarStripElement2.MinSize = New System.Drawing.Size(0, 0)
		'
		'
		'
		Me.CommandBarStripElement2.OverflowButton.Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		CType(Me.CommandBarStripElement2.GetChildAt(0), Telerik.WinControls.UI.RadCommandBarGrip).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		CType(Me.CommandBarStripElement2.GetChildAt(2), Telerik.WinControls.UI.RadCommandBarOverflowButton).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
		'
		'CommandBarButton5
		'
		Me.CommandBarButton5.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.NewItem
		Me.CommandBarButton5.Image = CType(resources.GetObject("CommandBarButton5.Image"), System.Drawing.Image)
		Me.CommandBarButton5.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
		Me.CommandBarButton5.Name = "CommandBarButton5"
		Me.CommandBarButton5.SvgImageXml = resources.GetString("CommandBarButton5.SvgImageXml")
		'
		'CommandBarSeparator5
		'
		Me.CommandBarSeparator5.Name = "CommandBarSeparator5"
		Me.CommandBarSeparator5.VisibleInOverflowMenu = False
		'
		'CommandBarButton6
		'
		Me.CommandBarButton6.CommandRole = Telerik.WinControls.UI.RadCommandBarRole.DeleteItem
		Me.CommandBarButton6.Image = CType(resources.GetObject("CommandBarButton6.Image"), System.Drawing.Image)
		Me.CommandBarButton6.Name = "CommandBarButton6"
		Me.CommandBarButton6.SvgImageXml = resources.GetString("CommandBarButton6.SvgImageXml")
		'
		'RadTextBoxNumEtiquette
		'
		Me.RadTextBoxNumEtiquette.Location = New System.Drawing.Point(1200, 154)
		Me.RadTextBoxNumEtiquette.Name = "RadTextBoxNumEtiquette"
		Me.RadTextBoxNumEtiquette.Size = New System.Drawing.Size(516, 24)
		Me.RadTextBoxNumEtiquette.TabIndex = 57
		'
		'FormListView
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1684, 881)
		Me.Controls.Add(Me.RadTextBoxNumEtiquette)
		Me.Controls.Add(Me.RadBindingNavigator1)
		Me.Controls.Add(Me.RadCollapsiblePanelInvoice)
		Me.Controls.Add(Me.RadCollapsiblePanelDocPathName)
		Me.Controls.Add(Me.RadPanelHaut)
		Me.Controls.Add(Me.RadStatusStrip1)
		Me.Name = "FormListView"
		Me.Text = "FormListView"
		CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadPanelHaut, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadPanelHaut.ResumeLayout(False)
		Me.RadPanelHaut.PerformLayout()
		CType(Me.RadDateTimePickerDateEnd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerDayStard, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelDayEnd, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelDaySart, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelGlobalCathegory, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelProjectNameGlobal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadLabelCentreNameGlobal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.FILESPATHBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TAKEOFFDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TAKEOFFDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.ITEMSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TAKEOFFDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadCollapsiblePanelDocPathName.PanelContainer.ResumeLayout(False)
		CType(Me.RadCollapsiblePanelDocPathName, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadCollapsiblePanelDocPathName.ResumeLayout(False)
		CType(Me.RadGridViewItems.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewItems, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		CType(Me.RadButtonPathNameListView, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonPathNameDetails, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonParthnameIcon, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonPathNameClear, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonPathNameSave, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadListViewDocuments, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadCollapsiblePanelInvoice.PanelContainer.ResumeLayout(False)
		CType(Me.RadCollapsiblePanelInvoice, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadCollapsiblePanelInvoice.ResumeLayout(False)
		Me.GroupBox2.ResumeLayout(False)
		CType(Me.RadDataLayout1.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadDataLayout1.LayoutControl.ResumeLayout(False)
		Me.RadDataLayout1.LayoutControl.PerformLayout()
		CType(Me.RadDataLayout1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadDataLayout1.ResumeLayout(False)
		CType(Me.INVOICEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TAKEOFFDataSet41, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerInvoiceCreatDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerModifyDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxInvoiceNumber, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceProjectIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceItemIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxInvoiceSupplier, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceAmount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceVATPourcent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceVATAmount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonProjectManager, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonInvoiceNEW, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonSupplierInvoiceDelete, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadButtonInvoiceUpdate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewInvoice.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewInvoice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePicker1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePicker2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorInvoiceType, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorVATPourcent, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditor8, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TAKEOFFDataSetInvoice, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TAKEOFFDataSet42, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.INVOICEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxNumEtiquette, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents RadStatusStrip1 As RadStatusStrip
    Friend WithEvents RadLabelStatusMessage As RadLabelElement
    Friend WithEvents RadPanelHaut As RadPanel
    Friend WithEvents RadDateTimePickerDateEnd As RadDateTimePicker
    Friend WithEvents RadDateTimePickerDayStard As RadDateTimePicker
    Friend WithEvents RadLabelDayEnd As RadLabel
    Friend WithEvents RadLabelDaySart As RadLabel
    Friend WithEvents RadLabelGlobalCathegory As RadLabel
    Friend WithEvents RadLabelProjectNameGlobal As RadLabel
    Friend WithEvents RadLabelCentreNameGlobal As RadLabel
    Friend WithEvents TAKEOFFDataSet As TAKEOFFDataSet
    Friend WithEvents TAKEOFFDataSet1 As TAKEOFFDataSet1
    Friend WithEvents ITEMSBindingSource As BindingSource
    Friend WithEvents ITEMSTableAdapter As TAKEOFFDataSet1TableAdapters.ITEMSTableAdapter
    Friend WithEvents TAKEOFFDataSet2 As TAKEOFFDataSet2
    Friend WithEvents FILESPATHBindingSource As BindingSource
    Friend WithEvents FILES_PATHTableAdapter As TAKEOFFDataSet2TableAdapters.FILES_PATHTableAdapter
    Friend WithEvents TAKEOFFDataSet4 As TAKEOFFDataSet4
    Friend WithEvents RadCollapsiblePanelDocPathName As RadCollapsiblePanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadListViewDocuments As RadListView
    Friend WithEvents RadCollapsiblePanelInvoice As RadCollapsiblePanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadGridViewInvoice As RadGridView
    Friend WithEvents RadDataLayout1 As RadDataLayout
    Friend WithEvents TAKEOFFDataSetInvoice As TAKEOFFDataSetInvoice
    Friend WithEvents TAKEOFFDataSet41 As TAKEOFFDataSet4
    Friend WithEvents INVOICEBindingSource As BindingSource
    Friend WithEvents INVOICETableAdapter As TAKEOFFDataSet4TableAdapters.INVOICETableAdapter
    Friend WithEvents RadSpinEditor1 As RadSpinEditor
    Friend WithEvents RadSpinEditor2 As RadSpinEditor
    Friend WithEvents RadDateTimePicker1 As RadDateTimePicker
    Friend WithEvents RadDateTimePicker2 As RadDateTimePicker
    Friend WithEvents RadTextBox1 As RadTextBox
    Friend WithEvents RadSpinEditorInvoiceType As RadSpinEditor
    Friend WithEvents RadSpinEditorProjectIndex As RadSpinEditor
    Friend WithEvents RadSpinEditor5 As RadSpinEditor
    Friend WithEvents RadTextBox2 As RadTextBox
    Friend WithEvents RadSpinEditor6 As RadSpinEditor
    Friend WithEvents RadSpinEditorVATPourcent As RadSpinEditor
    Friend WithEvents RadSpinEditor8 As RadSpinEditor
    Friend WithEvents DataLayoutControlItem1 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem2 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem3 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem4 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem5 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem6 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem7 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem8 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem9 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem10 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem11 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem12 As DataLayoutControlItem
    Friend WithEvents TAKEOFFDataSet42 As TAKEOFFDataSet4
    Friend WithEvents INVOICEBindingSource1 As BindingSource
    Friend WithEvents RadSpinEditor3 As RadSpinEditor
    Friend WithEvents RadSpinEditorInvoiceIndex As RadSpinEditor
    Friend WithEvents RadDateTimePickerInvoiceCreatDate As RadDateTimePicker
    Friend WithEvents RadDateTimePickerModifyDate As RadDateTimePicker
    Friend WithEvents RadTextBoxInvoiceNumber As RadTextBox
    Friend WithEvents RadSpinEditorType As RadSpinEditor
    Friend WithEvents RadSpinEditorInvoiceProjectIndex As RadSpinEditor
    Friend WithEvents RadSpinEditorInvoiceItemIndex As RadSpinEditor
    Friend WithEvents RadTextBoxInvoiceSupplier As RadTextBox
    Friend WithEvents RadSpinEditorInvoiceAmount As RadSpinEditor
    Friend WithEvents RadSpinEditorInvoiceVATPourcent As RadSpinEditor
    Friend WithEvents RadSpinEditorInvoiceVATAmount As RadSpinEditor
    Friend WithEvents DataLayoutControlItem13 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem14 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem15 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem16 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem17 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem18 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem19 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem20 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem21 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem22 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem23 As DataLayoutControlItem
    Friend WithEvents DataLayoutControlItem24 As DataLayoutControlItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadGridViewItems As RadGridView
    Friend WithEvents RadGridView1 As RadGridView
    Friend WithEvents RadButtonInvoiceUpdate As RadButton
    Friend WithEvents RadButtonSupplierInvoiceDelete As RadButton
    Friend WithEvents RadButtonInvoiceNEW As RadButton
    Friend WithEvents RadButtonPathNameSave As RadButton
    Friend WithEvents RadButtonPathNameClear As RadButton
    Friend WithEvents RadButtonParthnameIcon As RadButton
    Friend WithEvents RadButtonPathNameDetails As RadButton
    Friend WithEvents RadButtonPathNameListView As RadButton
    Friend WithEvents RadButtonProjectManager As RadButton
    Friend WithEvents DataLayoutControlItem25 As DataLayoutControlItem
    Friend WithEvents RadBindingNavigator1 As RadBindingNavigator
    Friend WithEvents CommandBarRowElement1 As CommandBarRowElement
    Friend WithEvents CommandBarStripElement1 As CommandBarStripElement
    Friend WithEvents CommandBarButton1 As CommandBarButton
    Friend WithEvents CommandBarSeparator1 As CommandBarSeparator
    Friend WithEvents CommandBarButton2 As CommandBarButton
    Friend WithEvents CommandBarSeparator2 As CommandBarSeparator
    Friend WithEvents CommandBarTextBox1 As CommandBarTextBox
    Friend WithEvents CommandBarLabel1 As CommandBarLabel
    Friend WithEvents CommandBarSeparator3 As CommandBarSeparator
    Friend WithEvents CommandBarButton3 As CommandBarButton
    Friend WithEvents CommandBarSeparator4 As CommandBarSeparator
    Friend WithEvents CommandBarButton4 As CommandBarButton
    Friend WithEvents CommandBarStripElement2 As CommandBarStripElement
    Friend WithEvents CommandBarButton5 As CommandBarButton
    Friend WithEvents CommandBarSeparator5 As CommandBarSeparator
    Friend WithEvents CommandBarButton6 As CommandBarButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents RadTextBoxNumEtiquette As RadTextBox
End Class
