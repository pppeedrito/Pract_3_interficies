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
        Me.Btn_preg = New System.Windows.Forms.Button()
        Me.Lista = New System.Windows.Forms.ListBox()
        Me.TxtUsuari = New System.Windows.Forms.TextBox()
        Me.BtnAgr = New System.Windows.Forms.Button()
        Me.btn_ord_num = New System.Windows.Forms.Button()
        Me.Btn_ord_asci = New System.Windows.Forms.Button()
        Me.Rdbtn_Desc = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboObligatorio = New System.Windows.Forms.ComboBox()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_info = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_preg
        '
        Me.Btn_preg.Location = New System.Drawing.Point(398, 191)
        Me.Btn_preg.Name = "Btn_preg"
        Me.Btn_preg.Size = New System.Drawing.Size(121, 37)
        Me.Btn_preg.TabIndex = 0
        Me.Btn_preg.Text = "Preguntar"
        Me.Btn_preg.UseVisualStyleBackColor = True
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
        'btn_ord_num
        '
        Me.btn_ord_num.Location = New System.Drawing.Point(29, 355)
        Me.btn_ord_num.Name = "btn_ord_num"
        Me.btn_ord_num.Size = New System.Drawing.Size(93, 60)
        Me.btn_ord_num.TabIndex = 4
        Me.btn_ord_num.Text = "Ordenación numérica"
        Me.btn_ord_num.UseVisualStyleBackColor = True
        '
        'Btn_ord_asci
        '
        Me.Btn_ord_asci.Location = New System.Drawing.Point(144, 355)
        Me.Btn_ord_asci.Name = "Btn_ord_asci"
        Me.Btn_ord_asci.Size = New System.Drawing.Size(91, 60)
        Me.Btn_ord_asci.TabIndex = 5
        Me.Btn_ord_asci.Text = "Ordenación ASCI"
        Me.Btn_ord_asci.UseVisualStyleBackColor = True
        '
        'Rdbtn_Desc
        '
        Me.Rdbtn_Desc.AutoSize = True
        Me.Rdbtn_Desc.Location = New System.Drawing.Point(398, 394)
        Me.Rdbtn_Desc.Name = "Rdbtn_Desc"
        Me.Rdbtn_Desc.Size = New System.Drawing.Size(105, 21)
        Me.Rdbtn_Desc.TabIndex = 6
        Me.Rdbtn_Desc.TabStop = True
        Me.Rdbtn_Desc.Text = "Descendent"
        Me.Rdbtn_Desc.UseVisualStyleBackColor = True
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
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.Location = New System.Drawing.Point(398, 246)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(121, 37)
        Me.Btn_Eliminar.TabIndex = 10
        Me.Btn_Eliminar.Text = "Eliminar"
        Me.Btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Btn_info
        '
        Me.Btn_info.Location = New System.Drawing.Point(398, 299)
        Me.Btn_info.Name = "Btn_info"
        Me.Btn_info.Size = New System.Drawing.Size(121, 43)
        Me.Btn_info.TabIndex = 11
        Me.Btn_info.Text = "Informacion"
        Me.Btn_info.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 575)
        Me.Controls.Add(Me.Btn_info)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.ComboObligatorio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Rdbtn_Desc)
        Me.Controls.Add(Me.Btn_ord_asci)
        Me.Controls.Add(Me.btn_ord_num)
        Me.Controls.Add(Me.BtnAgr)
        Me.Controls.Add(Me.TxtUsuari)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.Btn_preg)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_preg As Button
    Friend WithEvents Lista As ListBox
    Friend WithEvents TxtUsuari As TextBox
    Friend WithEvents BtnAgr As Button
    Friend WithEvents btn_ord_num As Button
    Friend WithEvents Btn_ord_asci As Button
    Friend WithEvents Rdbtn_Desc As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboObligatorio As ComboBox
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents Btn_info As Button
End Class
