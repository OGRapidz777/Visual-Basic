<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlagSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFlagSelector))
        Me.PicBrazil = New System.Windows.Forms.PictureBox()
        Me.lblNamesOfFlags = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PicAlemania = New System.Windows.Forms.PictureBox()
        Me.PicPuertoRico = New System.Windows.Forms.PictureBox()
        Me.PicJapan = New System.Windows.Forms.PictureBox()
        Me.PicFrance = New System.Windows.Forms.PictureBox()
        Me.PicUnitedStates = New System.Windows.Forms.PictureBox()
        CType(Me.PicBrazil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicAlemania, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicPuertoRico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJapan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFrance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicUnitedStates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicBrazil
        '
        Me.PicBrazil.Image = CType(resources.GetObject("PicBrazil.Image"), System.Drawing.Image)
        Me.PicBrazil.Location = New System.Drawing.Point(222, 2)
        Me.PicBrazil.Name = "PicBrazil"
        Me.PicBrazil.Size = New System.Drawing.Size(192, 121)
        Me.PicBrazil.TabIndex = 0
        Me.PicBrazil.TabStop = False
        '
        'lblNamesOfFlags
        '
        Me.lblNamesOfFlags.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNamesOfFlags.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNamesOfFlags.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamesOfFlags.Location = New System.Drawing.Point(70, 274)
        Me.lblNamesOfFlags.Name = "lblNamesOfFlags"
        Me.lblNamesOfFlags.Size = New System.Drawing.Size(524, 55)
        Me.lblNamesOfFlags.TabIndex = 1
        Me.lblNamesOfFlags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(222, 348)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(198, 52)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close "
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PicAlemania
        '
        Me.PicAlemania.Image = CType(resources.GetObject("PicAlemania.Image"), System.Drawing.Image)
        Me.PicAlemania.Location = New System.Drawing.Point(3, 129)
        Me.PicAlemania.Name = "PicAlemania"
        Me.PicAlemania.Size = New System.Drawing.Size(204, 131)
        Me.PicAlemania.TabIndex = 3
        Me.PicAlemania.TabStop = False
        '
        'PicPuertoRico
        '
        Me.PicPuertoRico.Image = CType(resources.GetObject("PicPuertoRico.Image"), System.Drawing.Image)
        Me.PicPuertoRico.Location = New System.Drawing.Point(3, 2)
        Me.PicPuertoRico.Name = "PicPuertoRico"
        Me.PicPuertoRico.Size = New System.Drawing.Size(204, 121)
        Me.PicPuertoRico.TabIndex = 4
        Me.PicPuertoRico.TabStop = False
        '
        'PicJapan
        '
        Me.PicJapan.Image = CType(resources.GetObject("PicJapan.Image"), System.Drawing.Image)
        Me.PicJapan.Location = New System.Drawing.Point(222, 129)
        Me.PicJapan.Name = "PicJapan"
        Me.PicJapan.Size = New System.Drawing.Size(192, 131)
        Me.PicJapan.TabIndex = 6
        Me.PicJapan.TabStop = False
        '
        'PicFrance
        '
        Me.PicFrance.Image = CType(resources.GetObject("PicFrance.Image"), System.Drawing.Image)
        Me.PicFrance.Location = New System.Drawing.Point(438, 2)
        Me.PicFrance.Name = "PicFrance"
        Me.PicFrance.Size = New System.Drawing.Size(204, 121)
        Me.PicFrance.TabIndex = 7
        Me.PicFrance.TabStop = False
        '
        'PicUnitedStates
        '
        Me.PicUnitedStates.Image = CType(resources.GetObject("PicUnitedStates.Image"), System.Drawing.Image)
        Me.PicUnitedStates.Location = New System.Drawing.Point(438, 129)
        Me.PicUnitedStates.Name = "PicUnitedStates"
        Me.PicUnitedStates.Size = New System.Drawing.Size(204, 131)
        Me.PicUnitedStates.TabIndex = 8
        Me.PicUnitedStates.TabStop = False
        '
        'frmFlagSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 412)
        Me.Controls.Add(Me.PicUnitedStates)
        Me.Controls.Add(Me.PicFrance)
        Me.Controls.Add(Me.PicJapan)
        Me.Controls.Add(Me.PicPuertoRico)
        Me.Controls.Add(Me.PicAlemania)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblNamesOfFlags)
        Me.Controls.Add(Me.PicBrazil)
        Me.Name = "frmFlagSelector"
        Me.Text = "Flag Selector"
        CType(Me.PicBrazil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicAlemania, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicPuertoRico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJapan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFrance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicUnitedStates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PicBrazil As PictureBox
    Friend WithEvents lblNamesOfFlags As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PicAlemania As PictureBox
    Friend WithEvents PicPuertoRico As PictureBox
    Friend WithEvents PicJapan As PictureBox
    Friend WithEvents PicFrance As PictureBox
    Friend WithEvents PicUnitedStates As PictureBox
End Class
