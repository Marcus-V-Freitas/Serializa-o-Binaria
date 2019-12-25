<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSerializar = New System.Windows.Forms.Button()
        Me.btnDeserializar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(169, 68)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(100, 20)
        Me.txtPreco.TabIndex = 0
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(169, 140)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 1
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(169, 228)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(100, 20)
        Me.txtMarca.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Preço:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Modelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Marca:"
        '
        'btnSerializar
        '
        Me.btnSerializar.Location = New System.Drawing.Point(122, 344)
        Me.btnSerializar.Name = "btnSerializar"
        Me.btnSerializar.Size = New System.Drawing.Size(75, 23)
        Me.btnSerializar.TabIndex = 6
        Me.btnSerializar.Text = "Serializar"
        Me.btnSerializar.UseVisualStyleBackColor = True
        '
        'btnDeserializar
        '
        Me.btnDeserializar.Location = New System.Drawing.Point(386, 344)
        Me.btnDeserializar.Name = "btnDeserializar"
        Me.btnDeserializar.Size = New System.Drawing.Size(75, 23)
        Me.btnDeserializar.TabIndex = 7
        Me.btnDeserializar.Text = "Deserializar"
        Me.btnDeserializar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDeserializar)
        Me.Controls.Add(Me.btnSerializar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtPreco)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPreco As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSerializar As Button
    Friend WithEvents btnDeserializar As Button
End Class
