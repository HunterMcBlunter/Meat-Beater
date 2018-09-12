<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTutorialMenu
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
        Me.btn_tut_h2p = New System.Windows.Forms.Button()
        Me.btn_tut_PurchasePT = New System.Windows.Forms.Button()
        Me.btn_tut_save = New System.Windows.Forms.Button()
        Me.btn_tut_Load = New System.Windows.Forms.Button()
        Me.btn_Tut_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_tut_h2p
        '
        Me.btn_tut_h2p.Location = New System.Drawing.Point(94, 29)
        Me.btn_tut_h2p.Name = "btn_tut_h2p"
        Me.btn_tut_h2p.Size = New System.Drawing.Size(103, 23)
        Me.btn_tut_h2p.TabIndex = 0
        Me.btn_tut_h2p.Text = "How to Play"
        Me.btn_tut_h2p.UseVisualStyleBackColor = True
        '
        'btn_tut_PurchasePT
        '
        Me.btn_tut_PurchasePT.Location = New System.Drawing.Point(53, 71)
        Me.btn_tut_PurchasePT.Name = "btn_tut_PurchasePT"
        Me.btn_tut_PurchasePT.Size = New System.Drawing.Size(183, 23)
        Me.btn_tut_PurchasePT.TabIndex = 1
        Me.btn_tut_PurchasePT.Text = "How to Purchase Power Tugs"
        Me.btn_tut_PurchasePT.UseVisualStyleBackColor = True
        '
        'btn_tut_save
        '
        Me.btn_tut_save.Location = New System.Drawing.Point(85, 111)
        Me.btn_tut_save.Name = "btn_tut_save"
        Me.btn_tut_save.Size = New System.Drawing.Size(119, 23)
        Me.btn_tut_save.TabIndex = 2
        Me.btn_tut_save.Text = "How to Save a Game"
        Me.btn_tut_save.UseVisualStyleBackColor = True
        '
        'btn_tut_Load
        '
        Me.btn_tut_Load.Location = New System.Drawing.Point(85, 155)
        Me.btn_tut_Load.Name = "btn_tut_Load"
        Me.btn_tut_Load.Size = New System.Drawing.Size(119, 23)
        Me.btn_tut_Load.TabIndex = 3
        Me.btn_tut_Load.Text = "How to Load a Game"
        Me.btn_tut_Load.UseVisualStyleBackColor = True
        '
        'btn_Tut_exit
        '
        Me.btn_Tut_exit.Location = New System.Drawing.Point(12, 226)
        Me.btn_Tut_exit.Name = "btn_Tut_exit"
        Me.btn_Tut_exit.Size = New System.Drawing.Size(83, 23)
        Me.btn_Tut_exit.TabIndex = 4
        Me.btn_Tut_exit.Text = "Exit Tutorials"
        Me.btn_Tut_exit.UseVisualStyleBackColor = True
        '
        'frmTutorialMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btn_Tut_exit)
        Me.Controls.Add(Me.btn_tut_Load)
        Me.Controls.Add(Me.btn_tut_save)
        Me.Controls.Add(Me.btn_tut_PurchasePT)
        Me.Controls.Add(Me.btn_tut_h2p)
        Me.Name = "frmTutorialMenu"
        Me.Text = "Tutorials"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_tut_h2p As Button
    Friend WithEvents btn_tut_PurchasePT As Button
    Friend WithEvents btn_tut_save As Button
    Friend WithEvents btn_tut_Load As Button
    Friend WithEvents btn_Tut_exit As Button
End Class
