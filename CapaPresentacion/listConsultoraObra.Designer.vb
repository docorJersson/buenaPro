<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listConsultoraObra
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
        Me.dtConsultoraObra = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dtConsultoraObra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtConsultoraObra
        '
        Me.dtConsultoraObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtConsultoraObra.Location = New System.Drawing.Point(12, 111)
        Me.dtConsultoraObra.Name = "dtConsultoraObra"
        Me.dtConsultoraObra.Size = New System.Drawing.Size(784, 435)
        Me.dtConsultoraObra.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Consultoras Obras"
        '
        'listConsultoraObra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 558)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtConsultoraObra)
        Me.Name = "listConsultoraObra"
        Me.Text = "listConsultoraObra"
        CType(Me.dtConsultoraObra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtConsultoraObra As DataGridView
    Friend WithEvents Label1 As Label
End Class
