<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaCiudadano
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
        Me.dtCiudadano = New System.Windows.Forms.DataGridView()
        CType(Me.dtCiudadano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtCiudadano
        '
        Me.dtCiudadano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtCiudadano.Location = New System.Drawing.Point(12, 105)
        Me.dtCiudadano.Name = "dtCiudadano"
        Me.dtCiudadano.Size = New System.Drawing.Size(826, 416)
        Me.dtCiudadano.TabIndex = 0
        '
        'listaCiudadano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 533)
        Me.Controls.Add(Me.dtCiudadano)
        Me.Name = "listaCiudadano"
        Me.Text = "listaCiudadano"
        CType(Me.dtCiudadano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtCiudadano As DataGridView
End Class
