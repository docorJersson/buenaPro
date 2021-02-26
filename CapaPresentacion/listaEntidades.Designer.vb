<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaEntidades
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
        Me.dtgEntidades = New System.Windows.Forms.DataGridView()
        CType(Me.dtgEntidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgEntidades
        '
        Me.dtgEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEntidades.Location = New System.Drawing.Point(12, 105)
        Me.dtgEntidades.Name = "dtgEntidades"
        Me.dtgEntidades.Size = New System.Drawing.Size(864, 444)
        Me.dtgEntidades.TabIndex = 0
        '
        'listaEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 561)
        Me.Controls.Add(Me.dtgEntidades)
        Me.Name = "listaEntidades"
        Me.Text = "listaEntidadesFinanciera"
        CType(Me.dtgEntidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgEntidades As DataGridView
End Class
