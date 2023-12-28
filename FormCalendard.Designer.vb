<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCalendard
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
        Me.TakeoffDataSet51 = New PrevisionFlex.TAKEOFFDataSet5()
        Me.PROJECTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECTTableAdapter = New PrevisionFlex.TAKEOFFDataSet5TableAdapters.PROJECTTableAdapter()
        CType(Me.TakeoffDataSet51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout
        '
        'TakeoffDataSet51
        '
        Me.TakeoffDataSet51.DataSetName = "TAKEOFFDataSet5"
        Me.TakeoffDataSet51.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PROJECTBindingSource
        '
        Me.PROJECTBindingSource.DataMember = "PROJECT"
        Me.PROJECTBindingSource.DataSource = Me.TakeoffDataSet51
        '
        'PROJECTTableAdapter
        '
        Me.PROJECTTableAdapter.ClearBeforeFill = True
        '
        'FormCalendard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 643)
        Me.Name = "FormCalendard"
        Me.Text = "FormCalendard"
        CType(Me.TakeoffDataSet51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TakeoffDataSet51 As TAKEOFFDataSet5
    Friend WithEvents PROJECTBindingSource As BindingSource
    Friend WithEvents PROJECTTableAdapter As TAKEOFFDataSet5TableAdapters.PROJECTTableAdapter
End Class
