﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Convocatoria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboTiSeleccion = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.txtNomenclatura = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcConvocatoria = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNormativa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnConvocatoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ckGenerar = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lstCronograma = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboProcedimiento = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtFin = New System.Windows.Forms.DateTimePicker()
        Me.pnCronograma = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnCronograma.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboTiSeleccion)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.txtNomenclatura)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtcConvocatoria)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtNormativa)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtnConvocatoria)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 85)
        Me.Panel1.TabIndex = 0
        '
        'cboTiSeleccion
        '
        Me.cboTiSeleccion.FormattingEnabled = True
        Me.cboTiSeleccion.Items.AddRange(New Object() {"POR LA ENTIDAD", "POR LA OSCE", "POR LA CONTRALORÍA", "POR EL CONGRESO", "POR EL GOBIERNO", "POR OTROS MEDIOS"})
        Me.cboTiSeleccion.Location = New System.Drawing.Point(546, 13)
        Me.cboTiSeleccion.Name = "cboTiSeleccion"
        Me.cboTiSeleccion.Size = New System.Drawing.Size(176, 21)
        Me.cboTiSeleccion.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(705, 49)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Generar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'txtNomenclatura
        '
        Me.txtNomenclatura.Location = New System.Drawing.Point(524, 49)
        Me.txtNomenclatura.Name = "txtNomenclatura"
        Me.txtNomenclatura.Size = New System.Drawing.Size(157, 20)
        Me.txtNomenclatura.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(442, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nomenclatura:"
        '
        'txtcConvocatoria
        '
        Me.txtcConvocatoria.Enabled = False
        Me.txtcConvocatoria.Location = New System.Drawing.Point(102, 13)
        Me.txtcConvocatoria.Name = "txtcConvocatoria"
        Me.txtcConvocatoria.Size = New System.Drawing.Size(154, 20)
        Me.txtcConvocatoria.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(271, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "N° Convocatoria:"
        '
        'txtNormativa
        '
        Me.txtNormativa.Location = New System.Drawing.Point(127, 49)
        Me.txtNormativa.Name = "txtNormativa"
        Me.txtNormativa.Size = New System.Drawing.Size(295, 20)
        Me.txtNormativa.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Normativa Aplicable:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(461, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Selección:"
        '
        'txtnConvocatoria
        '
        Me.txtnConvocatoria.Location = New System.Drawing.Point(364, 13)
        Me.txtnConvocatoria.Name = "txtnConvocatoria"
        Me.txtnConvocatoria.Size = New System.Drawing.Size(74, 20)
        Me.txtnConvocatoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "C° Convocatoria:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Cronograma"
        '
        'ckGenerar
        '
        Me.ckGenerar.AutoSize = True
        Me.ckGenerar.Location = New System.Drawing.Point(532, 130)
        Me.ckGenerar.Name = "ckGenerar"
        Me.ckGenerar.Size = New System.Drawing.Size(84, 17)
        Me.ckGenerar.TabIndex = 5
        Me.ckGenerar.Text = "Autogenerar"
        Me.ckGenerar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ckGenerar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Infromación General"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 322)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(187, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Información general del Procedimiento"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TextBox9)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TextBox8)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.TextBox15)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.CheckBox3)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.ComboBox3)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.TextBox16)
        Me.Panel3.Controls.Add(Me.TextBox17)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.TextBox18)
        Me.Panel3.Controls.Add(Me.TextBox19)
        Me.Panel3.Controls.Add(Me.ComboBox4)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.TextBox20)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.TextBox21)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Location = New System.Drawing.Point(9, 337)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(795, 165)
        Me.Panel3.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(289, 130)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 20)
        Me.TextBox1.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nombre:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(588, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = ".."
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(599, 131)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(160, 20)
        Me.TextBox9.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(532, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "N° Cuenta:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Entidad de Pago:"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(106, 130)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(67, 20)
        Me.TextBox8.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(231, 137)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 13)
        Me.Label21.TabIndex = 20
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(617, 92)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(78, 20)
        Me.TextBox15.TabIndex = 19
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(544, 95)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Costo Bases:"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(465, 94)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(63, 17)
        Me.CheckBox3.TabIndex = 17
        Me.CheckBox3.Text = "Gratuito"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(285, 95)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(101, 13)
        Me.Label23.TabIndex = 16
        Me.Label23.Text = "Costo Participación:"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Seleccione", "Soles", "Dolar", "Euro"})
        Me.ComboBox3.Location = New System.Drawing.Point(688, 18)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(93, 21)
        Me.ComboBox3.TabIndex = 15
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(633, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(49, 13)
        Me.Label24.TabIndex = 14
        Me.Label24.Text = "Moneda:"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(388, 92)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(71, 20)
        Me.TextBox16.TabIndex = 13
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(156, 92)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(99, 20)
        Me.TextBox17.TabIndex = 12
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(11, 95)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(139, 13)
        Me.Label25.TabIndex = 11
        Me.Label25.Text = "Valor Estimado/ Referencial"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(329, 56)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(452, 20)
        Me.TextBox18.TabIndex = 10
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(57, 18)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(88, 20)
        Me.TextBox19.TabIndex = 3
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(139, 56)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox4.TabIndex = 9
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(199, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(33, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "RUC:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(257, 59)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(66, 13)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Descripción:"
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(235, 18)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(85, 20)
        Me.TextBox20.TabIndex = 1
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(14, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(119, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Objeto de Contratación:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 21)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(44, 13)
        Me.Label29.TabIndex = 2
        Me.Label29.Text = "Ubigeo:"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(392, 18)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(224, 20)
        Me.TextBox21.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "...."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(339, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(47, 13)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Nombre:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(311, 516)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(84, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Generar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(401, 514)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Cancelar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(482, 514)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 14
        Me.Button5.Text = "Cerrar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lstCronograma
        '
        Me.lstCronograma.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstCronograma.Location = New System.Drawing.Point(12, 135)
        Me.lstCronograma.Name = "lstCronograma"
        Me.lstCronograma.Size = New System.Drawing.Size(495, 181)
        Me.lstCronograma.TabIndex = 15
        Me.lstCronograma.UseCompatibleStateImageBehavior = False
        Me.lstCronograma.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Procedimiento"
        Me.ColumnHeader2.Width = 270
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Fecha Inicio"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha Fin"
        Me.ColumnHeader4.Width = 120
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Procedimiemto"
        '
        'cboProcedimiento
        '
        Me.cboProcedimiento.FormattingEnabled = True
        Me.cboProcedimiento.Location = New System.Drawing.Point(90, 17)
        Me.cboProcedimiento.Name = "cboProcedimiento"
        Me.cboProcedimiento.Size = New System.Drawing.Size(168, 21)
        Me.cboProcedimiento.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Fecha Inicio"
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(90, 61)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(168, 20)
        Me.dtInicio.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 108)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Fecha Fin"
        '
        'dtFin
        '
        Me.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFin.Location = New System.Drawing.Point(90, 102)
        Me.dtFin.Name = "dtFin"
        Me.dtFin.Size = New System.Drawing.Size(168, 20)
        Me.dtFin.TabIndex = 22
        '
        'pnCronograma
        '
        Me.pnCronograma.Controls.Add(Me.Button6)
        Me.pnCronograma.Controls.Add(Me.Label13)
        Me.pnCronograma.Controls.Add(Me.dtFin)
        Me.pnCronograma.Controls.Add(Me.cboProcedimiento)
        Me.pnCronograma.Controls.Add(Me.Label16)
        Me.pnCronograma.Controls.Add(Me.Label14)
        Me.pnCronograma.Controls.Add(Me.dtInicio)
        Me.pnCronograma.Location = New System.Drawing.Point(532, 149)
        Me.pnCronograma.Name = "pnCronograma"
        Me.pnCronograma.Size = New System.Drawing.Size(272, 167)
        Me.pnCronograma.TabIndex = 23
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(183, 128)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Agregar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Convocatoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(819, 548)
        Me.Controls.Add(Me.pnCronograma)
        Me.Controls.Add(Me.lstCronograma)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ckGenerar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Convocatoria"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnCronograma.ResumeLayout(False)
        Me.pnCronograma.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnConvocatoria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomenclatura As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcConvocatoria As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNormativa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ckGenerar As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label30 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents lstCronograma As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label13 As Label
    Friend WithEvents cboProcedimiento As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dtInicio As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents dtFin As DateTimePicker
    Friend WithEvents pnCronograma As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents cboTiSeleccion As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
End Class
