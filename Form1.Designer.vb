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
        Me.BarraDeEstado = New System.Windows.Forms.StatusStrip()
        Me.BarraDeMenu = New System.Windows.Forms.MenuStrip()
        Me.menuArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdicion = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EdicionPegar = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuOpciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesFuente = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpFuCourierNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpFuArial = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpFuPredeterminada = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesTam = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpTam16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpTam24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpTamPredeterminado = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraDeHerramientas = New System.Windows.Forms.ToolStrip()
        Me.btbarCortar = New System.Windows.Forms.ToolStripButton()
        Me.btbarCopiar = New System.Windows.Forms.ToolStripButton()
        Me.btbarPegar = New System.Windows.Forms.ToolStripButton()
        Me.ctEditor = New System.Windows.Forms.TextBox()
        Me.EdicionDeshacer = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraDeMenu.SuspendLayout()
        Me.BarraDeHerramientas.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraDeEstado
        '
        Me.BarraDeEstado.Location = New System.Drawing.Point(0, 428)
        Me.BarraDeEstado.Name = "BarraDeEstado"
        Me.BarraDeEstado.Size = New System.Drawing.Size(800, 22)
        Me.BarraDeEstado.TabIndex = 2
        '
        'BarraDeMenu
        '
        Me.BarraDeMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuArchivo, Me.menuEdicion, Me.menuOpciones})
        Me.BarraDeMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraDeMenu.Name = "BarraDeMenu"
        Me.BarraDeMenu.Size = New System.Drawing.Size(800, 24)
        Me.BarraDeMenu.TabIndex = 4
        Me.BarraDeMenu.Text = "MenuStrip1"
        '
        'menuArchivo
        '
        Me.menuArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoSalir})
        Me.menuArchivo.Name = "menuArchivo"
        Me.menuArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuArchivo.Text = "&Archivo"
        '
        'ArchivoSalir
        '
        Me.ArchivoSalir.Name = "ArchivoSalir"
        Me.ArchivoSalir.Size = New System.Drawing.Size(96, 22)
        Me.ArchivoSalir.Text = "&Salir"
        '
        'menuEdicion
        '
        Me.menuEdicion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EdicionDeshacer, Me.EdicionCortar, Me.EdicionCopiar, Me.EdicionPegar})
        Me.menuEdicion.Name = "menuEdicion"
        Me.menuEdicion.Size = New System.Drawing.Size(58, 20)
        Me.menuEdicion.Text = "&Edición"
        '
        'EdicionCortar
        '
        Me.EdicionCortar.Image = Global.Editor.My.Resources.Resources.imagenEdicionCortar
        Me.EdicionCortar.ImageTransparentColor = System.Drawing.Color.Black
        Me.EdicionCortar.Name = "EdicionCortar"
        Me.EdicionCortar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.EdicionCortar.Size = New System.Drawing.Size(180, 22)
        Me.EdicionCortar.Text = "Cor&tar"
        '
        'EdicionCopiar
        '
        Me.EdicionCopiar.Image = Global.Editor.My.Resources.Resources.imagenEdicionCopiar
        Me.EdicionCopiar.ImageTransparentColor = System.Drawing.Color.Black
        Me.EdicionCopiar.Name = "EdicionCopiar"
        Me.EdicionCopiar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.EdicionCopiar.Size = New System.Drawing.Size(180, 22)
        Me.EdicionCopiar.Text = "&Copiar"
        '
        'EdicionPegar
        '
        Me.EdicionPegar.Image = Global.Editor.My.Resources.Resources.imagenEdicionPegar
        Me.EdicionPegar.ImageTransparentColor = System.Drawing.Color.Black
        Me.EdicionPegar.Name = "EdicionPegar"
        Me.EdicionPegar.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EdicionPegar.Size = New System.Drawing.Size(180, 22)
        Me.EdicionPegar.Text = "&Pegar"
        '
        'menuOpciones
        '
        Me.menuOpciones.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesFuente, Me.OpcionesTam})
        Me.menuOpciones.Name = "menuOpciones"
        Me.menuOpciones.Size = New System.Drawing.Size(69, 20)
        Me.menuOpciones.Text = "&Opciones"
        '
        'OpcionesFuente
        '
        Me.OpcionesFuente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpFuCourierNew, Me.OpFuArial, Me.OpFuPredeterminada})
        Me.OpcionesFuente.Name = "OpcionesFuente"
        Me.OpcionesFuente.Size = New System.Drawing.Size(116, 22)
        Me.OpcionesFuente.Text = "&Fuente"
        '
        'OpFuCourierNew
        '
        Me.OpFuCourierNew.Name = "OpFuCourierNew"
        Me.OpFuCourierNew.Size = New System.Drawing.Size(158, 22)
        Me.OpFuCourierNew.Text = "Courier New"
        '
        'OpFuArial
        '
        Me.OpFuArial.Name = "OpFuArial"
        Me.OpFuArial.Size = New System.Drawing.Size(158, 22)
        Me.OpFuArial.Text = "Arial"
        '
        'OpFuPredeterminada
        '
        Me.OpFuPredeterminada.Name = "OpFuPredeterminada"
        Me.OpFuPredeterminada.Size = New System.Drawing.Size(158, 22)
        Me.OpFuPredeterminada.Text = "Predeterminada"
        '
        'OpcionesTam
        '
        Me.OpcionesTam.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpTam16, Me.OpTam24, Me.OpTamPredeterminado})
        Me.OpcionesTam.Name = "OpcionesTam"
        Me.OpcionesTam.Size = New System.Drawing.Size(116, 22)
        Me.OpcionesTam.Text = "&Tamaño"
        '
        'OpTam16
        '
        Me.OpTam16.Name = "OpTam16"
        Me.OpTam16.Size = New System.Drawing.Size(159, 22)
        Me.OpTam16.Text = "16"
        '
        'OpTam24
        '
        Me.OpTam24.Name = "OpTam24"
        Me.OpTam24.Size = New System.Drawing.Size(159, 22)
        Me.OpTam24.Text = "24"
        '
        'OpTamPredeterminado
        '
        Me.OpTamPredeterminado.Name = "OpTamPredeterminado"
        Me.OpTamPredeterminado.Size = New System.Drawing.Size(159, 22)
        Me.OpTamPredeterminado.Text = "Predeterminado"
        '
        'BarraDeHerramientas
        '
        Me.BarraDeHerramientas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btbarCortar, Me.btbarCopiar, Me.btbarPegar})
        Me.BarraDeHerramientas.Location = New System.Drawing.Point(0, 24)
        Me.BarraDeHerramientas.Name = "BarraDeHerramientas"
        Me.BarraDeHerramientas.Size = New System.Drawing.Size(800, 25)
        Me.BarraDeHerramientas.TabIndex = 5
        Me.BarraDeHerramientas.Text = "ToolStrip1"
        '
        'btbarCortar
        '
        Me.btbarCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btbarCortar.Image = Global.Editor.My.Resources.Resources.imagenbtbarCortar
        Me.btbarCortar.ImageTransparentColor = System.Drawing.Color.Black
        Me.btbarCortar.Name = "btbarCortar"
        Me.btbarCortar.Size = New System.Drawing.Size(23, 22)
        Me.btbarCortar.Text = "ToolStripButton1"
        Me.btbarCortar.ToolTipText = "Cortar"
        '
        'btbarCopiar
        '
        Me.btbarCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btbarCopiar.Image = Global.Editor.My.Resources.Resources.imagenbtbarCopiar
        Me.btbarCopiar.ImageTransparentColor = System.Drawing.Color.Black
        Me.btbarCopiar.Name = "btbarCopiar"
        Me.btbarCopiar.Size = New System.Drawing.Size(23, 22)
        Me.btbarCopiar.Text = "ToolStripButton1"
        Me.btbarCopiar.ToolTipText = "Copiar"
        '
        'btbarPegar
        '
        Me.btbarPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btbarPegar.Image = Global.Editor.My.Resources.Resources.imagenbtbarPegar
        Me.btbarPegar.ImageTransparentColor = System.Drawing.Color.Black
        Me.btbarPegar.Name = "btbarPegar"
        Me.btbarPegar.Size = New System.Drawing.Size(23, 22)
        Me.btbarPegar.Text = "ToolStripButton2"
        Me.btbarPegar.ToolTipText = "Pegar"
        '
        'ctEditor
        '
        Me.ctEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctEditor.Location = New System.Drawing.Point(0, 49)
        Me.ctEditor.Multiline = True
        Me.ctEditor.Name = "ctEditor"
        Me.ctEditor.Size = New System.Drawing.Size(800, 379)
        Me.ctEditor.TabIndex = 6
        '
        'EdicionDeshacer
        '
        Me.EdicionDeshacer.Image = Global.Editor.My.Resources.Resources.imagenEdicionDeshacer
        Me.EdicionDeshacer.ImageTransparentColor = System.Drawing.Color.Black
        Me.EdicionDeshacer.Name = "EdicionDeshacer"
        Me.EdicionDeshacer.Size = New System.Drawing.Size(180, 22)
        Me.EdicionDeshacer.Text = "&Deshacer"
        '
        'Editor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ctEditor)
        Me.Controls.Add(Me.BarraDeHerramientas)
        Me.Controls.Add(Me.BarraDeEstado)
        Me.Controls.Add(Me.BarraDeMenu)
        Me.MainMenuStrip = Me.BarraDeMenu
        Me.Name = "Editor"
        Me.Text = "Editor"
        Me.BarraDeMenu.ResumeLayout(False)
        Me.BarraDeMenu.PerformLayout()
        Me.BarraDeHerramientas.ResumeLayout(False)
        Me.BarraDeHerramientas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraDeEstado As StatusStrip
    Friend WithEvents BarraDeMenu As MenuStrip
    Friend WithEvents menuArchivo As ToolStripMenuItem
    Friend WithEvents ArchivoSalir As ToolStripMenuItem
    Friend WithEvents menuEdicion As ToolStripMenuItem
    Friend WithEvents menuOpciones As ToolStripMenuItem
    Friend WithEvents BarraDeHerramientas As ToolStrip
    Friend WithEvents EdicionCortar As ToolStripMenuItem
    Friend WithEvents EdicionCopiar As ToolStripMenuItem
    Friend WithEvents EdicionPegar As ToolStripMenuItem
    Friend WithEvents OpcionesFuente As ToolStripMenuItem
    Friend WithEvents OpFuCourierNew As ToolStripMenuItem
    Friend WithEvents OpFuArial As ToolStripMenuItem
    Friend WithEvents OpFuPredeterminada As ToolStripMenuItem
    Friend WithEvents OpcionesTam As ToolStripMenuItem
    Friend WithEvents OpTam16 As ToolStripMenuItem
    Friend WithEvents OpTam24 As ToolStripMenuItem
    Friend WithEvents OpTamPredeterminado As ToolStripMenuItem
    Friend WithEvents btbarCortar As ToolStripButton
    Friend WithEvents btbarCopiar As ToolStripButton
    Friend WithEvents btbarPegar As ToolStripButton
    Friend WithEvents ctEditor As TextBox
    Friend WithEvents EdicionDeshacer As ToolStripMenuItem
End Class
