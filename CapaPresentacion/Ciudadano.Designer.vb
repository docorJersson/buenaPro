<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ciudadano
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumDoc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApePaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApeMaterno = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Documento:"
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {"DNI", "RUC"})
        Me.cboTipoDoc.Location = New System.Drawing.Point(149, 34)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoDoc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "N° Documento:"
        '
        'txtNumDoc
        '
        Me.txtNumDoc.Location = New System.Drawing.Point(149, 68)
        Me.txtNumDoc.Name = "txtNumDoc"
        Me.txtNumDoc.Size = New System.Drawing.Size(121, 20)
        Me.txtNumDoc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido Paterno:"
        '
        'txtApePaterno
        '
        Me.txtApePaterno.Location = New System.Drawing.Point(149, 105)
        Me.txtApePaterno.Name = "txtApePaterno"
        Me.txtApePaterno.Size = New System.Drawing.Size(121, 20)
        Me.txtApePaterno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Apellido Materno:"
        '
        'txtApeMaterno
        '
        Me.txtApeMaterno.Location = New System.Drawing.Point(149, 136)
        Me.txtApeMaterno.Name = "txtApeMaterno"
        Me.txtApeMaterno.Size = New System.Drawing.Size(121, 20)
        Me.txtApeMaterno.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombres:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(149, 178)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(188, 20)
        Me.txtNombre.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sexo:"
        '
        'cboSexo
        '
        Me.cboSexo.FormattingEnabled = True
        Me.cboSexo.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.cboSexo.Location = New System.Drawing.Point(149, 218)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(121, 21)
        Me.cboSexo.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(60, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(149, 254)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(188, 20)
        Me.txtEmail.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(149, 299)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(105, 20)
        Me.txtTelefono.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(60, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Teléfono:"
        '
        'Ciudadano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 422)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboSexo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApeMaterno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtApePaterno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumDoc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTipoDoc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ciudadano"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cboTipoDoc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumDoc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApePaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtApeMaterno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboSexo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label8 As Label
End Class
