<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtproveed = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtproveed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtproveed
        '
        Me.dtproveed.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtproveed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtproveed.GridColor = System.Drawing.SystemColors.ButtonFace
        Me.dtproveed.Location = New System.Drawing.Point(58, 93)
        Me.dtproveed.Name = "dtproveed"
        Me.dtproveed.RowTemplate.Height = 24
        Me.dtproveed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dtproveed.Size = New System.Drawing.Size(1030, 445)
        Me.dtproveed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(155, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LISTA DE PROVEEDORES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(887, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 38)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'listProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 593)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtproveed)
        Me.Name = "listProveedor"
        Me.Text = "PROVEEDORES"
        CType(Me.dtproveed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtproveed As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
