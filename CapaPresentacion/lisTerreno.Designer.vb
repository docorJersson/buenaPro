<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lisTerreno
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
        Me.dtTerreno = New System.Windows.Forms.DataGridView()
        CType(Me.dtTerreno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtTerreno
        '
        Me.dtTerreno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtTerreno.Location = New System.Drawing.Point(12, 49)
        Me.dtTerreno.Name = "dtTerreno"
        Me.dtTerreno.Size = New System.Drawing.Size(694, 384)
        Me.dtTerreno.TabIndex = 0
        '
        'lisTerreno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 445)
        Me.Controls.Add(Me.dtTerreno)
        Me.Name = "lisTerreno"
        Me.Text = "lisTerreno"
        CType(Me.dtTerreno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtTerreno As DataGridView
End Class
