<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Editor
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
        Me.BarraDeMenus = New System.Windows.Forms.MenuStrip()
        Me.BarraDeHerramientas = New System.Windows.Forms.ToolStrip()
        Me.BarraDeEstado = New System.Windows.Forms.StatusStrip()
        Me.ctEditor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BarraDeMenus
        '
        Me.BarraDeMenus.Location = New System.Drawing.Point(0, 25)
        Me.BarraDeMenus.Name = "BarraDeMenus"
        Me.BarraDeMenus.Size = New System.Drawing.Size(800, 24)
        Me.BarraDeMenus.TabIndex = 0
        '
        'BarraDeHerramientas
        '
        Me.BarraDeHerramientas.Location = New System.Drawing.Point(0, 0)
        Me.BarraDeHerramientas.Name = "BarraDeHerramientas"
        Me.BarraDeHerramientas.Size = New System.Drawing.Size(800, 25)
        Me.BarraDeHerramientas.TabIndex = 1
        '
        'BarraDeEstado
        '
        Me.BarraDeEstado.Location = New System.Drawing.Point(0, 428)
        Me.BarraDeEstado.Name = "BarraDeEstado"
        Me.BarraDeEstado.Size = New System.Drawing.Size(800, 22)
        Me.BarraDeEstado.TabIndex = 2
        '
        'ctEditor
        '
        Me.ctEditor.AcceptsReturn = True
        Me.ctEditor.AcceptsTab = True
        Me.ctEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctEditor.Location = New System.Drawing.Point(0, 49)
        Me.ctEditor.Multiline = True
        Me.ctEditor.Name = "ctEditor"
        Me.ctEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ctEditor.Size = New System.Drawing.Size(800, 379)
        Me.ctEditor.TabIndex = 3
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ctEditor)
        Me.Controls.Add(Me.BarraDeMenus)
        Me.Controls.Add(Me.BarraDeHerramientas)
        Me.Controls.Add(Me.BarraDeEstado)
        Me.Name = "Editor"
        Me.Text = "Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    ' Agrego las barras de menús
    Friend WithEvents BarraDeMenus As MenuStrip
    Friend WithEvents BarraDeHerramientas As ToolStrip
    Friend WithEvents BarraDeEstado As StatusStrip
    Friend WithEvents ctEditor As TextBox

End Class
