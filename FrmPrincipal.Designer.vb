<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACIONToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESUMENDEVENTAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACIONToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACELECTRONICAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RESUMENDEFACTURAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENVIARAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTORYToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem, Me.FACTURACIONToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1484, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FACTURACIONToolStripMenuItem1, Me.RESUMENDEVENTAToolStripMenuItem, Me.CLIENTESToolStripMenuItem})
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.FacturacionToolStripMenuItem.Text = "POS"
        '
        'FACTURACIONToolStripMenuItem1
        '
        Me.FACTURACIONToolStripMenuItem1.Name = "FACTURACIONToolStripMenuItem1"
        Me.FACTURACIONToolStripMenuItem1.Size = New System.Drawing.Size(182, 22)
        Me.FACTURACIONToolStripMenuItem1.Text = "FACTURACION"
        '
        'RESUMENDEVENTAToolStripMenuItem
        '
        Me.RESUMENDEVENTAToolStripMenuItem.Name = "RESUMENDEVENTAToolStripMenuItem"
        Me.RESUMENDEVENTAToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.RESUMENDEVENTAToolStripMenuItem.Text = "RESUMEN DE VENTA"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'FACTURACIONToolStripMenuItem2
        '
        Me.FACTURACIONToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FACELECTRONICAToolStripMenuItem, Me.RESUMENDEFACTURAToolStripMenuItem, Me.ENVIARAToolStripMenuItem, Me.FACTORYToolStripMenuItem})
        Me.FACTURACIONToolStripMenuItem2.Name = "FACTURACIONToolStripMenuItem2"
        Me.FACTURACIONToolStripMenuItem2.Size = New System.Drawing.Size(62, 20)
        Me.FACTURACIONToolStripMenuItem2.Text = "NO POS"
        '
        'FACELECTRONICAToolStripMenuItem
        '
        Me.FACELECTRONICAToolStripMenuItem.Name = "FACELECTRONICAToolStripMenuItem"
        Me.FACELECTRONICAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.FACELECTRONICAToolStripMenuItem.Text = "FAC. ELECTRONICA"
        '
        'RESUMENDEFACTURAToolStripMenuItem
        '
        Me.RESUMENDEFACTURAToolStripMenuItem.Name = "RESUMENDEFACTURAToolStripMenuItem"
        Me.RESUMENDEFACTURAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RESUMENDEFACTURAToolStripMenuItem.Text = "RESUMEN DE FACTURA"
        '
        'ENVIARAToolStripMenuItem
        '
        Me.ENVIARAToolStripMenuItem.Name = "ENVIARAToolStripMenuItem"
        Me.ENVIARAToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.ENVIARAToolStripMenuItem.Text = "ENVIAR A"
        '
        'FACTORYToolStripMenuItem
        '
        Me.FACTORYToolStripMenuItem.Name = "FACTORYToolStripMenuItem"
        Me.FACTORYToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.FACTORYToolStripMenuItem.Text = "FACTORY"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 834)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "JDS - Control Total"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FACTURACIONToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RESUMENDEVENTAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CLIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FACTURACIONToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents FACELECTRONICAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RESUMENDEFACTURAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENVIARAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FACTORYToolStripMenuItem As ToolStripMenuItem
End Class
