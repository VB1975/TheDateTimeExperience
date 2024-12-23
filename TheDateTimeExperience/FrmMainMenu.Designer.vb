<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainMenu))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.LblHeaderShadow = New System.Windows.Forms.Label()
        Me.BtnDisplayDateTime = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHeader.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.Location = New System.Drawing.Point(12, 9)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(797, 79)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "The Date/Time Experience"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHeaderShadow
        '
        Me.LblHeaderShadow.BackColor = System.Drawing.Color.Black
        Me.LblHeaderShadow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblHeaderShadow.Font = New System.Drawing.Font("Algerian", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeaderShadow.Location = New System.Drawing.Point(17, 14)
        Me.LblHeaderShadow.Name = "LblHeaderShadow"
        Me.LblHeaderShadow.Size = New System.Drawing.Size(797, 79)
        Me.LblHeaderShadow.TabIndex = 1
        Me.LblHeaderShadow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnDisplayDateTime
        '
        Me.BtnDisplayDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDisplayDateTime.Location = New System.Drawing.Point(84, 116)
        Me.BtnDisplayDateTime.Name = "BtnDisplayDateTime"
        Me.BtnDisplayDateTime.Size = New System.Drawing.Size(653, 56)
        Me.BtnDisplayDateTime.TabIndex = 2
        Me.BtnDisplayDateTime.Text = "Displaying Dates && Time"
        Me.BtnDisplayDateTime.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Location = New System.Drawing.Point(750, 416)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(59, 57)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 485)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplayDateTime)
        Me.Controls.Add(Me.LblHeader)
        Me.Controls.Add(Me.LblHeaderShadow)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblHeader As Label
    Friend WithEvents LblHeaderShadow As Label
    Friend WithEvents BtnDisplayDateTime As Button
    Friend WithEvents BtnExit As Button
End Class
