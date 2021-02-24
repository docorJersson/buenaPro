<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listFinancierta_Entidad
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtLisFinanEnti = New System.Windows.Forms.DataGridView()
        CType(Me.dtLisFinanEnti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtLisFinanEnti
        '
        Me.dtLisFinanEnti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtLisFinanEnti.Location = New System.Drawing.Point(12, 71)
        Me.dtLisFinanEnti.Name = "dtLisFinanEnti"
        Me.dtLisFinanEnti.Size = New System.Drawing.Size(592, 385)
        Me.dtLisFinanEnti.TabIndex = 0
        '
        'listFinancierta_Entidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 468)
        Me.Controls.Add(Me.dtLisFinanEnti)
        Me.Name = "listFinancierta_Entidad"
        Me.Text = "listFinancierta_Entidad"
        CType(Me.dtLisFinanEnti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtLisFinanEnti As DataGridView
End Class
