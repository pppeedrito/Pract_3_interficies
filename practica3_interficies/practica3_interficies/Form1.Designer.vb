<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.TxtUsuari = New System.Windows.Forms.TextBox()
        Me.BtnAgr = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboObligatorio = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(398, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Preguntar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.ItemHeight = 16
        Me.Lista.Location = New System.Drawing.Point(29, 64)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(289, 228)
        Me.Lista.TabIndex = 1
        '
        'TxtUsuari
        '
        Me.TxtUsuari.Location = New System.Drawing.Point(352, 50)
        Me.TxtUsuari.Name = "TxtUsuari"
        Me.TxtUsuari.Size = New System.Drawing.Size(213, 22)
        Me.TxtUsuari.TabIndex = 2
        '
        'BtnAgr
        '
        Me.BtnAgr.Location = New System.Drawing.Point(398, 132)
        Me.BtnAgr.Name = "BtnAgr"
        Me.BtnAgr.Size = New System.Drawing.Size(121, 38)
        Me.BtnAgr.TabIndex = 3
        Me.BtnAgr.Text = "Añadir"
        Me.BtnAgr.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(29, 355)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 60)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Ordenación numérica"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(144, 355)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 60)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Ordenación ASCI"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(398, 394)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(105, 21)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Descendent"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tipus de ordenació"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Introduce las "
        '
        'ComboObligatorio
        '
        Me.ComboObligatorio.FormattingEnabled = True
        Me.ComboObligatorio.Items.AddRange(New Object() {"Principio List Box", "Ordenación Numerica", "Final List BoX"})
        Me.ComboObligatorio.Location = New System.Drawing.Point(352, 92)
        Me.ComboObligatorio.Name = "ComboObligatorio"
        Me.ComboObligatorio.Size = New System.Drawing.Size(213, 24)
        Me.ComboObligatorio.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(398, 246)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(121, 37)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Eliminar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(398, 299)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(121, 43)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Informacion"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 575)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ComboObligatorio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnAgr)
        Me.Controls.Add(Me.TxtUsuari)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Lista As ListBox
    Friend WithEvents TxtUsuari As TextBox
    Friend WithEvents BtnAgr As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboObligatorio As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
