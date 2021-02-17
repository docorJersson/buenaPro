<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MANTENEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MANTENEDORToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(756, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MANTENEDORToolStripMenuItem
        '
        Me.MANTENEDORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROVEEDORESToolStripMenuItem})
        Me.MANTENEDORToolStripMenuItem.Name = "MANTENEDORToolStripMenuItem"
        Me.MANTENEDORToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.MANTENEDORToolStripMenuItem.Text = "MANTENEDOR"
        '
        'PROVEEDORESToolStripMenuItem
        '
        Me.PROVEEDORESToolStripMenuItem.Name = "PROVEEDORESToolStripMenuItem"
        Me.PROVEEDORESToolStripMenuItem.Size = New System.Drawing.Size(184, 26)
        Me.PROVEEDORESToolStripMenuItem.Text = "PROVEEDORES"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 421)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MANTENEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORESToolStripMenuItem As ToolStripMenuItem
End Class
