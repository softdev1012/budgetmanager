<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormItemsDataEntry
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
		Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
		Me.RadGridViewProjectName = New Telerik.WinControls.UI.RadGridView()
		Me.RadDataLayoutProjectNameMAinForm = New Telerik.WinControls.UI.RadDataLayout()
		Me.RadSpinEditorIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadSpinEditorProjectIndex = New Telerik.WinControls.UI.RadSpinEditor()
		Me.RadTextBoxProjectCode = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxProjectName = New Telerik.WinControls.UI.RadTextBox()
		Me.RadDateTimePickerCreateDate = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadDateTimePickerModifyDate = New Telerik.WinControls.UI.RadDateTimePicker()
		Me.RadTextBoxProjectStatus = New Telerik.WinControls.UI.RadTextBox()
		Me.RadTextBoxProjectDataPath = New Telerik.WinControls.UI.RadTextBox()
		Me.DataLayoutControlItem1 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem2 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem3 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem4 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem5 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem6 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem7 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.DataLayoutControlItem8 = New Telerik.WinControls.UI.DataLayoutControlItem()
		Me.ButtonNewProject = New System.Windows.Forms.Button()
		Me.ButtonDeleteProject = New System.Windows.Forms.Button()
		Me.ButtonUpdateProject = New System.Windows.Forms.Button()
		Me.RadStatusStrip2 = New Telerik.WinControls.UI.RadStatusStrip()
		Me.RadLabelElementMessage = New Telerik.WinControls.UI.RadLabelElement()
		CType(Me.RadGridViewProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadGridViewProjectName.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDataLayoutProjectNameMAinForm, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDataLayoutProjectNameMAinForm.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.SuspendLayout()
		Me.RadDataLayoutProjectNameMAinForm.SuspendLayout()
		CType(Me.RadSpinEditorIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectCode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectName, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerCreateDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadDateTimePickerModifyDate, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectStatus, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadTextBoxProjectDataPath, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'RadGridViewProjectName
		'
		Me.RadGridViewProjectName.BeginEditMode = Telerik.WinControls.RadGridViewBeginEditMode.BeginEditProgrammatically
		Me.RadGridViewProjectName.Location = New System.Drawing.Point(10, 10)
		'
		'
		'
		Me.RadGridViewProjectName.MasterTemplate.AllowAddNewRow = False
		Me.RadGridViewProjectName.MasterTemplate.AllowSearchRow = True
		Me.RadGridViewProjectName.MasterTemplate.ShowRowHeaderColumn = False
		Me.RadGridViewProjectName.MasterTemplate.ViewDefinition = TableViewDefinition1
		Me.RadGridViewProjectName.Name = "RadGridViewProjectName"
		Me.RadGridViewProjectName.NewRowEnterKeyMode = Telerik.WinControls.UI.RadGridViewNewRowEnterKeyMode.None
		Me.RadGridViewProjectName.Size = New System.Drawing.Size(700, 520)
		Me.RadGridViewProjectName.TabIndex = 0
		Me.RadGridViewProjectName.ThemeName = "ControlDefault"
		'
		'RadDataLayoutProjectNameMAinForm
		'
		Me.RadDataLayoutProjectNameMAinForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		'
		'RadDataLayoutProjectNameMAinForm.LayoutControl
		'
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadSpinEditorIndex)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadSpinEditorProjectIndex)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadTextBoxProjectCode)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadTextBoxProjectName)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadDateTimePickerCreateDate)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadDateTimePickerModifyDate)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadTextBoxProjectStatus)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Controls.Add(Me.RadTextBoxProjectDataPath)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.DrawBorder = False
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Items.AddRange(New Telerik.WinControls.RadItem() {Me.DataLayoutControlItem1, Me.DataLayoutControlItem2, Me.DataLayoutControlItem3, Me.DataLayoutControlItem4, Me.DataLayoutControlItem5, Me.DataLayoutControlItem6, Me.DataLayoutControlItem7, Me.DataLayoutControlItem8})
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Location = New System.Drawing.Point(0, 0)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Name = "LayoutControl"
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.Size = New System.Drawing.Size(350, 350)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.TabIndex = 0
		Me.RadDataLayoutProjectNameMAinForm.Location = New System.Drawing.Point(742, 60)
		Me.RadDataLayoutProjectNameMAinForm.Name = "RadDataLayoutProjectNameMAinForm"
		Me.RadDataLayoutProjectNameMAinForm.Size = New System.Drawing.Size(350, 350)
		Me.RadDataLayoutProjectNameMAinForm.TabIndex = 1
		'
		'RadSpinEditorIndex
		'
		Me.RadSpinEditorIndex.Location = New System.Drawing.Point(157, 10)
		Me.RadSpinEditorIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorIndex.Name = "RadSpinEditorIndex"
		Me.RadSpinEditorIndex.ReadOnly = True
		Me.RadSpinEditorIndex.Size = New System.Drawing.Size(189, 24)
		Me.RadSpinEditorIndex.TabIndex = 2
		Me.RadSpinEditorIndex.TabStop = False
		'
		'RadSpinEditorProjectIndex
		'
		Me.RadSpinEditorProjectIndex.Location = New System.Drawing.Point(157, 53)
		Me.RadSpinEditorProjectIndex.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
		Me.RadSpinEditorProjectIndex.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
		Me.RadSpinEditorProjectIndex.Name = "RadSpinEditorProjectIndex"
		Me.RadSpinEditorProjectIndex.ReadOnly = True
		Me.RadSpinEditorProjectIndex.Size = New System.Drawing.Size(189, 24)
		Me.RadSpinEditorProjectIndex.TabIndex = 3
		Me.RadSpinEditorProjectIndex.TabStop = False
		'
		'RadTextBoxProjectCode
		'
		Me.RadTextBoxProjectCode.Location = New System.Drawing.Point(157, 96)
		Me.RadTextBoxProjectCode.Name = "RadTextBoxProjectCode"
		Me.RadTextBoxProjectCode.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectCode.TabIndex = 4
		'
		'RadTextBoxProjectName
		'
		Me.RadTextBoxProjectName.Location = New System.Drawing.Point(157, 139)
		Me.RadTextBoxProjectName.Name = "RadTextBoxProjectName"
		Me.RadTextBoxProjectName.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectName.TabIndex = 5
		'
		'RadDateTimePickerCreateDate
		'
		Me.RadDateTimePickerCreateDate.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerCreateDate.Location = New System.Drawing.Point(157, 182)
		Me.RadDateTimePickerCreateDate.Name = "RadDateTimePickerCreateDate"
		Me.RadDateTimePickerCreateDate.ReadOnly = True
		Me.RadDateTimePickerCreateDate.Size = New System.Drawing.Size(189, 24)
		Me.RadDateTimePickerCreateDate.TabIndex = 6
		Me.RadDateTimePickerCreateDate.TabStop = False
		Me.RadDateTimePickerCreateDate.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePickerCreateDate.Value = New Date(2019, 6, 13, 10, 21, 40, 502)
		'
		'RadDateTimePickerModifyDate
		'
		Me.RadDateTimePickerModifyDate.CalendarSize = New System.Drawing.Size(290, 320)
		Me.RadDateTimePickerModifyDate.Location = New System.Drawing.Point(157, 225)
		Me.RadDateTimePickerModifyDate.Name = "RadDateTimePickerModifyDate"
		Me.RadDateTimePickerModifyDate.ReadOnly = True
		Me.RadDateTimePickerModifyDate.Size = New System.Drawing.Size(189, 24)
		Me.RadDateTimePickerModifyDate.TabIndex = 7
		Me.RadDateTimePickerModifyDate.TabStop = False
		Me.RadDateTimePickerModifyDate.Text = "Thursday, June 13, 2019"
		Me.RadDateTimePickerModifyDate.Value = New Date(2019, 6, 13, 10, 21, 40, 550)
		'
		'RadTextBoxProjectStatus
		'
		Me.RadTextBoxProjectStatus.Location = New System.Drawing.Point(157, 268)
		Me.RadTextBoxProjectStatus.Name = "RadTextBoxProjectStatus"
		Me.RadTextBoxProjectStatus.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectStatus.TabIndex = 8
		'
		'RadTextBoxProjectDataPath
		'
		Me.RadTextBoxProjectDataPath.Location = New System.Drawing.Point(157, 313)
		Me.RadTextBoxProjectDataPath.Name = "RadTextBoxProjectDataPath"
		Me.RadTextBoxProjectDataPath.Size = New System.Drawing.Size(189, 24)
		Me.RadTextBoxProjectDataPath.TabIndex = 9
		'
		'DataLayoutControlItem1
		'
		Me.DataLayoutControlItem1.AssociatedControl = Me.RadSpinEditorIndex
		Me.DataLayoutControlItem1.Bounds = New System.Drawing.Rectangle(0, 0, 348, 43)
		Me.DataLayoutControlItem1.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem1.Name = "DataLayoutControlItem1"
		Me.DataLayoutControlItem1.Text = "INDEX"
		Me.DataLayoutControlItem1.TextFixedSize = 153
		Me.DataLayoutControlItem1.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem1.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem2
		'
		Me.DataLayoutControlItem2.AssociatedControl = Me.RadSpinEditorProjectIndex
		Me.DataLayoutControlItem2.Bounds = New System.Drawing.Rectangle(0, 43, 348, 43)
		Me.DataLayoutControlItem2.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem2.Name = "DataLayoutControlItem2"
		Me.DataLayoutControlItem2.Text = "PROJECT_INDEX"
		Me.DataLayoutControlItem2.TextFixedSize = 153
		Me.DataLayoutControlItem2.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem2.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem3
		'
		Me.DataLayoutControlItem3.AssociatedControl = Me.RadTextBoxProjectCode
		Me.DataLayoutControlItem3.Bounds = New System.Drawing.Rectangle(0, 86, 348, 43)
		Me.DataLayoutControlItem3.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem3.Name = "DataLayoutControlItem3"
		Me.DataLayoutControlItem3.Text = "PROJECT_CODE"
		Me.DataLayoutControlItem3.TextFixedSize = 153
		Me.DataLayoutControlItem3.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem3.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem4
		'
		Me.DataLayoutControlItem4.AssociatedControl = Me.RadTextBoxProjectName
		Me.DataLayoutControlItem4.Bounds = New System.Drawing.Rectangle(0, 129, 348, 43)
		Me.DataLayoutControlItem4.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem4.Name = "DataLayoutControlItem4"
		Me.DataLayoutControlItem4.Text = "PROJECT_NAME"
		Me.DataLayoutControlItem4.TextFixedSize = 153
		Me.DataLayoutControlItem4.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem4.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem5
		'
		Me.DataLayoutControlItem5.AssociatedControl = Me.RadDateTimePickerCreateDate
		Me.DataLayoutControlItem5.Bounds = New System.Drawing.Rectangle(0, 172, 348, 43)
		Me.DataLayoutControlItem5.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem5.Name = "DataLayoutControlItem5"
		Me.DataLayoutControlItem5.Text = "PROJECT_CREAT_DATE"
		Me.DataLayoutControlItem5.TextFixedSize = 153
		Me.DataLayoutControlItem5.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem5.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem6
		'
		Me.DataLayoutControlItem6.AssociatedControl = Me.RadDateTimePickerModifyDate
		Me.DataLayoutControlItem6.Bounds = New System.Drawing.Rectangle(0, 215, 348, 43)
		Me.DataLayoutControlItem6.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem6.Name = "DataLayoutControlItem6"
		Me.DataLayoutControlItem6.Text = "PROJECT_MODIFY_DATE"
		Me.DataLayoutControlItem6.TextFixedSize = 153
		Me.DataLayoutControlItem6.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem6.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem7
		'
		Me.DataLayoutControlItem7.AssociatedControl = Me.RadTextBoxProjectStatus
		Me.DataLayoutControlItem7.Bounds = New System.Drawing.Rectangle(0, 258, 348, 43)
		Me.DataLayoutControlItem7.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem7.Name = "DataLayoutControlItem7"
		Me.DataLayoutControlItem7.Text = "PROJECT_STATUS"
		Me.DataLayoutControlItem7.TextFixedSize = 153
		Me.DataLayoutControlItem7.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem7.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'DataLayoutControlItem8
		'
		Me.DataLayoutControlItem8.AssociatedControl = Me.RadTextBoxProjectDataPath
		Me.DataLayoutControlItem8.Bounds = New System.Drawing.Rectangle(0, 301, 348, 47)
		Me.DataLayoutControlItem8.ControlVerticalAlignment = Telerik.WinControls.UI.RadVerticalAlignment.Center
		Me.DataLayoutControlItem8.Name = "DataLayoutControlItem8"
		Me.DataLayoutControlItem8.Text = "PROJECT_DATA_PATHNAME"
		Me.DataLayoutControlItem8.TextFixedSize = 153
		Me.DataLayoutControlItem8.TextProportionalSize = 0.25!
		Me.DataLayoutControlItem8.TextSizeMode = Telerik.WinControls.UI.LayoutItemTextSizeMode.Fixed
		'
		'ButtonNewProject
		'
		Me.ButtonNewProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonNewProject.Location = New System.Drawing.Point(797, 445)
		Me.ButtonNewProject.Name = "ButtonNewProject"
		Me.ButtonNewProject.Size = New System.Drawing.Size(60, 29)
		Me.ButtonNewProject.TabIndex = 53
		Me.ButtonNewProject.Text = "Add"
		Me.ButtonNewProject.UseVisualStyleBackColor = True
		'
		'ButtonDeleteProject
		'
		Me.ButtonDeleteProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonDeleteProject.Location = New System.Drawing.Point(997, 445)
		Me.ButtonDeleteProject.Name = "ButtonDeleteProject"
		Me.ButtonDeleteProject.Size = New System.Drawing.Size(60, 29)
		Me.ButtonDeleteProject.TabIndex = 52
		Me.ButtonDeleteProject.Text = "Delete"
		Me.ButtonDeleteProject.UseVisualStyleBackColor = True
		'
		'ButtonUpdateProject
		'
		Me.ButtonUpdateProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ButtonUpdateProject.Location = New System.Drawing.Point(897, 445)
		Me.ButtonUpdateProject.Name = "ButtonUpdateProject"
		Me.ButtonUpdateProject.Size = New System.Drawing.Size(60, 29)
		Me.ButtonUpdateProject.TabIndex = 51
		Me.ButtonUpdateProject.Text = "Update"
		Me.ButtonUpdateProject.UseVisualStyleBackColor = True
		'
		'RadStatusStrip2
		'
		Me.RadStatusStrip2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadLabelElementMessage})
		Me.RadStatusStrip2.Location = New System.Drawing.Point(0, 537)
		Me.RadStatusStrip2.Name = "RadStatusStrip2"
		Me.RadStatusStrip2.Size = New System.Drawing.Size(1104, 24)
		Me.RadStatusStrip2.TabIndex = 54
		'
		'RadLabelElementMessage
		'
		Me.RadLabelElementMessage.Name = "RadLabelElementMessage"
		Me.RadStatusStrip2.SetSpring(Me.RadLabelElementMessage, False)
		Me.RadLabelElementMessage.Text = "RadLabelElementMessage"
		Me.RadLabelElementMessage.TextWrap = True
		Me.RadLabelElementMessage.UseCompatibleTextRendering = False
		'
		'FormItemsDataEntry
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1104, 561)
		Me.Controls.Add(Me.RadDataLayoutProjectNameMAinForm)
		Me.Controls.Add(Me.RadStatusStrip2)
		Me.Controls.Add(Me.ButtonNewProject)
		Me.Controls.Add(Me.ButtonDeleteProject)
		Me.Controls.Add(Me.ButtonUpdateProject)
		Me.Controls.Add(Me.RadGridViewProjectName)
		Me.Name = "FormItemsDataEntry"
		Me.Text = "PrevisionFlex software 1.0"
		CType(Me.RadGridViewProjectName.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadGridViewProjectName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDataLayoutProjectNameMAinForm.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.ResumeLayout(False)
		Me.RadDataLayoutProjectNameMAinForm.LayoutControl.PerformLayout()
		CType(Me.RadDataLayoutProjectNameMAinForm, System.ComponentModel.ISupportInitialize).EndInit()
		Me.RadDataLayoutProjectNameMAinForm.ResumeLayout(False)
		CType(Me.RadSpinEditorIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadSpinEditorProjectIndex, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectCode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectName, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerCreateDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadDateTimePickerModifyDate, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectStatus, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadTextBoxProjectDataPath, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.RadStatusStrip2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents RadGridViewProjectName As RadGridView
	Friend WithEvents RadDataLayoutProjectNameMAinForm As RadDataLayout
	Friend WithEvents RadSpinEditorIndex As RadSpinEditor
	Friend WithEvents RadSpinEditorProjectIndex As RadSpinEditor
	Friend WithEvents RadTextBoxProjectCode As RadTextBox
	Friend WithEvents RadTextBoxProjectName As RadTextBox
	Friend WithEvents RadDateTimePickerCreateDate As RadDateTimePicker
	Friend WithEvents RadDateTimePickerModifyDate As RadDateTimePicker
	Friend WithEvents RadTextBoxProjectStatus As RadTextBox
	Friend WithEvents RadTextBoxProjectDataPath As RadTextBox
	Friend WithEvents DataLayoutControlItem1 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem2 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem3 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem4 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem5 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem6 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem7 As DataLayoutControlItem
	Friend WithEvents DataLayoutControlItem8 As DataLayoutControlItem
	Friend WithEvents ButtonNewProject As Button
	Friend WithEvents ButtonDeleteProject As Button
	Friend WithEvents ButtonUpdateProject As Button
	Friend WithEvents RadStatusStrip2 As RadStatusStrip
	Friend WithEvents RadLabelElementMessage As RadLabelElement
End Class
