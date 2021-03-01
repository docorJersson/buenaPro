<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listFuncionariOSCE
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
        Me.dtFuncOsce = New System.Windows.Forms.DataGridView()
        CType(Me.dtFuncOsce, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtFuncOsce
        '
        Me.dtFuncOsce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtFuncOsce.Location = New System.Drawing.Point(12, 79)
        Me.dtFuncOsce.Name = "dtFuncOsce"
        Me.dtFuncOsce.Size = New System.Drawing.Size(738, 395)
        Me.dtFuncOsce.TabIndex = 0
        '
        'listFuncionariOSCE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 486)
        Me.Controls.Add(Me.dtFuncOsce)
        Me.Name = "listFuncionariOSCE"
        Me.Text = "listFuncionariOSCE"
        CType(Me.dtFuncOsce, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtFuncOsce As DataGridView
End Class
