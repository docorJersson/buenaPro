<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listaFinancieras
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
        Me.daGriFinancieras = New System.Windows.Forms.DataGridView()
        CType(Me.daGriFinancieras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'daGriFinancieras
        '
        Me.daGriFinancieras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.daGriFinancieras.Location = New System.Drawing.Point(12, 47)
        Me.daGriFinancieras.Name = "daGriFinancieras"
        Me.daGriFinancieras.Size = New System.Drawing.Size(730, 314)
        Me.daGriFinancieras.TabIndex = 0
        '
        'listaFinancieras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 373)
        Me.Controls.Add(Me.daGriFinancieras)
        Me.Name = "listaFinancieras"
        Me.Text = "listaFinancieras"
        CType(Me.daGriFinancieras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents daGriFinancieras As DataGridView
End Class
