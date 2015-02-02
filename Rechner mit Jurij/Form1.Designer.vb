<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbFormeln = New System.Windows.Forms.GroupBox()
        Me.cbAll = New System.Windows.Forms.ComboBox()
        Me.rbProzent = New System.Windows.Forms.RadioButton()
        Me.rbKoerper = New System.Windows.Forms.RadioButton()
        Me.rbFlaechen = New System.Windows.Forms.RadioButton()
        Me.lFormel = New System.Windows.Forms.Label()
        Me.bWerteEingeben = New System.Windows.Forms.Button()
        Me.cbFormelAuswahl = New System.Windows.Forms.ComboBox()
        Me.bBeenden = New System.Windows.Forms.Button()
        Me.gbFormeln.SuspendLayout
        Me.SuspendLayout
        '
        'gbFormeln
        '
        Me.gbFormeln.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.gbFormeln.Controls.Add(Me.cbAll)
        Me.gbFormeln.Controls.Add(Me.rbProzent)
        Me.gbFormeln.Controls.Add(Me.rbKoerper)
        Me.gbFormeln.Controls.Add(Me.rbFlaechen)
        Me.gbFormeln.Location = New System.Drawing.Point(12, 12)
        Me.gbFormeln.Name = "gbFormeln"
        Me.gbFormeln.Size = New System.Drawing.Size(387, 95)
        Me.gbFormeln.TabIndex = 3
        Me.gbFormeln.TabStop = false
        Me.gbFormeln.Text = "Formeln"
        '
        'cbAll
        '
        Me.cbAll.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAll.FormattingEnabled = true
        Me.cbAll.Items.AddRange(New Object() {"Kreis", "Trapez", "Dreieck", "Parallelogramm"})
        Me.cbAll.Location = New System.Drawing.Point(260, 15)
        Me.cbAll.Name = "cbAll"
        Me.cbAll.Size = New System.Drawing.Size(121, 21)
        Me.cbAll.TabIndex = 3
        '
        'rbProzent
        '
        Me.rbProzent.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rbProzent.AutoSize = true
        Me.rbProzent.Location = New System.Drawing.Point(6, 65)
        Me.rbProzent.Name = "rbProzent"
        Me.rbProzent.Size = New System.Drawing.Size(61, 17)
        Me.rbProzent.TabIndex = 2
        Me.rbProzent.TabStop = true
        Me.rbProzent.Text = "Prozent"
        Me.rbProzent.UseVisualStyleBackColor = true
        '
        'rbKoerper
        '
        Me.rbKoerper.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rbKoerper.AutoSize = true
        Me.rbKoerper.Location = New System.Drawing.Point(6, 42)
        Me.rbKoerper.Name = "rbKoerper"
        Me.rbKoerper.Size = New System.Drawing.Size(56, 17)
        Me.rbKoerper.TabIndex = 1
        Me.rbKoerper.TabStop = true
        Me.rbKoerper.Text = "Körper"
        Me.rbKoerper.UseVisualStyleBackColor = true
        '
        'rbFlaechen
        '
        Me.rbFlaechen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rbFlaechen.AutoSize = true
        Me.rbFlaechen.Location = New System.Drawing.Point(6, 19)
        Me.rbFlaechen.Name = "rbFlaechen"
        Me.rbFlaechen.Size = New System.Drawing.Size(63, 17)
        Me.rbFlaechen.TabIndex = 0
        Me.rbFlaechen.TabStop = true
        Me.rbFlaechen.Text = "Flächen"
        Me.rbFlaechen.UseVisualStyleBackColor = true
        '
        'lFormel
        '
        Me.lFormel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lFormel.AutoSize = true
        Me.lFormel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lFormel.Location = New System.Drawing.Point(14, 123)
        Me.lFormel.Name = "lFormel"
        Me.lFormel.Size = New System.Drawing.Size(58, 20)
        Me.lFormel.TabIndex = 4
        Me.lFormel.Text = "Formel"
        Me.lFormel.Visible = false
        '
        'bWerteEingeben
        '
        Me.bWerteEingeben.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.bWerteEingeben.Location = New System.Drawing.Point(272, 120)
        Me.bWerteEingeben.Name = "bWerteEingeben"
        Me.bWerteEingeben.Size = New System.Drawing.Size(121, 23)
        Me.bWerteEingeben.TabIndex = 5
        Me.bWerteEingeben.Text = "Werte eingeben"
        Me.bWerteEingeben.UseVisualStyleBackColor = true
        Me.bWerteEingeben.Visible = false
        '
        'cbFormelAuswahl
        '
        Me.cbFormelAuswahl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cbFormelAuswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormelAuswahl.FormattingEnabled = true
        Me.cbFormelAuswahl.Location = New System.Drawing.Point(18, 146)
        Me.cbFormelAuswahl.Name = "cbFormelAuswahl"
        Me.cbFormelAuswahl.Size = New System.Drawing.Size(121, 21)
        Me.cbFormelAuswahl.TabIndex = 6
        Me.cbFormelAuswahl.Visible = false
        '
        'bBeenden
        '
        Me.bBeenden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.bBeenden.Location = New System.Drawing.Point(12, 226)
        Me.bBeenden.Name = "bBeenden"
        Me.bBeenden.Size = New System.Drawing.Size(75, 23)
        Me.bBeenden.TabIndex = 4
        Me.bBeenden.Text = "Beenden"
        Me.bBeenden.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 261)
        Me.Controls.Add(Me.bBeenden)
        Me.Controls.Add(Me.cbFormelAuswahl)
        Me.Controls.Add(Me.bWerteEingeben)
        Me.Controls.Add(Me.lFormel)
        Me.Controls.Add(Me.gbFormeln)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formelsammlung"
        Me.gbFormeln.ResumeLayout(false)
        Me.gbFormeln.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents gbFormeln As GroupBox
    Friend WithEvents rbProzent As RadioButton
    Friend WithEvents rbKoerper As RadioButton
    Friend WithEvents rbFlaechen As RadioButton
    Friend WithEvents cbAll As ComboBox
    Friend WithEvents lFormel As Label
    Friend WithEvents bWerteEingeben As Button
    Friend WithEvents cbFormelAuswahl As ComboBox
    Friend WithEvents bBeenden As Button
End Class
