<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCarpalTunnelBossBattle
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCarpalTunnelBossBattle))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lbl_BPS_HBN = New System.Windows.Forms.Label()
        Me.lbl_BPS_HL = New System.Windows.Forms.Label()
        Me.btnPowerTug_HL = New System.Windows.Forms.Button()
        Me.lbl_HL_Title = New System.Windows.Forms.Label()
        Me.btnPowerTug_HBN = New System.Windows.Forms.Button()
        Me.lbl_HL_Desc = New System.Windows.Forms.Label()
        Me.lbl_MRS_BPS = New System.Windows.Forms.Label()
        Me.lbl_HL_NumberOwned = New System.Windows.Forms.Label()
        Me.lbl_HBN_Title = New System.Windows.Forms.Label()
        Me.lbl_HBN_NumberOwned = New System.Windows.Forms.Label()
        Me.lbl_HBN_Desc = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHP_CarpalTunnel = New System.Windows.Forms.Label()
        Me.pbCarpalTunnel = New System.Windows.Forms.PictureBox()
        Me.lblMeatBeaten = New System.Windows.Forms.Label()
        Me.TimerCarpalTunnel = New System.Windows.Forms.Timer(Me.components)
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbCarpalTunnel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(66, 29)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(231, 31)
        Me.PictureBox2.TabIndex = 60
        Me.PictureBox2.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(343, 33)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(241, 241)
        Me.TabControl1.TabIndex = 59
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lbl_BPS_HBN)
        Me.TabPage1.Controls.Add(Me.lbl_BPS_HL)
        Me.TabPage1.Controls.Add(Me.btnPowerTug_HL)
        Me.TabPage1.Controls.Add(Me.lbl_HL_Title)
        Me.TabPage1.Controls.Add(Me.btnPowerTug_HBN)
        Me.TabPage1.Controls.Add(Me.lbl_HL_Desc)
        Me.TabPage1.Controls.Add(Me.lbl_MRS_BPS)
        Me.TabPage1.Controls.Add(Me.lbl_HL_NumberOwned)
        Me.TabPage1.Controls.Add(Me.lbl_HBN_Title)
        Me.TabPage1.Controls.Add(Me.lbl_HBN_NumberOwned)
        Me.TabPage1.Controls.Add(Me.lbl_HBN_Desc)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(233, 215)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Primary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lbl_BPS_HBN
        '
        Me.lbl_BPS_HBN.AutoSize = True
        Me.lbl_BPS_HBN.Location = New System.Drawing.Point(169, 77)
        Me.lbl_BPS_HBN.Name = "lbl_BPS_HBN"
        Me.lbl_BPS_HBN.Size = New System.Drawing.Size(0, 13)
        Me.lbl_BPS_HBN.TabIndex = 23
        '
        'lbl_BPS_HL
        '
        Me.lbl_BPS_HL.AutoSize = True
        Me.lbl_BPS_HL.Location = New System.Drawing.Point(169, 187)
        Me.lbl_BPS_HL.Name = "lbl_BPS_HL"
        Me.lbl_BPS_HL.Size = New System.Drawing.Size(0, 13)
        Me.lbl_BPS_HL.TabIndex = 22
        '
        'btnPowerTug_HL
        '
        Me.btnPowerTug_HL.Location = New System.Drawing.Point(3, 131)
        Me.btnPowerTug_HL.Name = "btnPowerTug_HL"
        Me.btnPowerTug_HL.Size = New System.Drawing.Size(228, 22)
        Me.btnPowerTug_HL.TabIndex = 20
        Me.btnPowerTug_HL.Text = "Cost in Beats: 50"
        Me.btnPowerTug_HL.UseVisualStyleBackColor = True
        '
        'lbl_HL_Title
        '
        Me.lbl_HL_Title.AutoSize = True
        Me.lbl_HL_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HL_Title.Location = New System.Drawing.Point(77, 115)
        Me.lbl_HL_Title.Name = "lbl_HL_Title"
        Me.lbl_HL_Title.Size = New System.Drawing.Size(76, 13)
        Me.lbl_HL_Title.TabIndex = 18
        Me.lbl_HL_Title.Text = "Hand Lotion"
        '
        'btnPowerTug_HBN
        '
        Me.btnPowerTug_HBN.Location = New System.Drawing.Point(3, 19)
        Me.btnPowerTug_HBN.Name = "btnPowerTug_HBN"
        Me.btnPowerTug_HBN.Size = New System.Drawing.Size(228, 23)
        Me.btnPowerTug_HBN.TabIndex = 21
        Me.btnPowerTug_HBN.Text = "Cost in Beats: 0.5"
        Me.btnPowerTug_HBN.UseVisualStyleBackColor = True
        '
        'lbl_HL_Desc
        '
        Me.lbl_HL_Desc.AutoSize = True
        Me.lbl_HL_Desc.Location = New System.Drawing.Point(27, 156)
        Me.lbl_HL_Desc.Name = "lbl_HL_Desc"
        Me.lbl_HL_Desc.Size = New System.Drawing.Size(181, 26)
        Me.lbl_HL_Desc.TabIndex = 17
        Me.lbl_HL_Desc.Text = "Adds +1 Damage per Attack against " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Carpal Tunnel"
        Me.lbl_HL_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_MRS_BPS
        '
        Me.lbl_MRS_BPS.AutoSize = True
        Me.lbl_MRS_BPS.Location = New System.Drawing.Point(114, 302)
        Me.lbl_MRS_BPS.Name = "lbl_MRS_BPS"
        Me.lbl_MRS_BPS.Size = New System.Drawing.Size(0, 13)
        Me.lbl_MRS_BPS.TabIndex = 14
        '
        'lbl_HL_NumberOwned
        '
        Me.lbl_HL_NumberOwned.AutoSize = True
        Me.lbl_HL_NumberOwned.Location = New System.Drawing.Point(70, 187)
        Me.lbl_HL_NumberOwned.Name = "lbl_HL_NumberOwned"
        Me.lbl_HL_NumberOwned.Size = New System.Drawing.Size(93, 13)
        Me.lbl_HL_NumberOwned.TabIndex = 6
        Me.lbl_HL_NumberOwned.Text = "Number Owned: 0"
        '
        'lbl_HBN_Title
        '
        Me.lbl_HBN_Title.AutoSize = True
        Me.lbl_HBN_Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HBN_Title.Location = New System.Drawing.Point(56, 3)
        Me.lbl_HBN_Title.Name = "lbl_HBN_Title"
        Me.lbl_HBN_Title.Size = New System.Drawing.Size(126, 13)
        Me.lbl_HBN_Title.TabIndex = 19
        Me.lbl_HBN_Title.Text = "Home Brand Napkins"
        '
        'lbl_HBN_NumberOwned
        '
        Me.lbl_HBN_NumberOwned.AutoSize = True
        Me.lbl_HBN_NumberOwned.Location = New System.Drawing.Point(70, 77)
        Me.lbl_HBN_NumberOwned.Name = "lbl_HBN_NumberOwned"
        Me.lbl_HBN_NumberOwned.Size = New System.Drawing.Size(93, 13)
        Me.lbl_HBN_NumberOwned.TabIndex = 10
        Me.lbl_HBN_NumberOwned.Text = "Number Owned: 0"
        '
        'lbl_HBN_Desc
        '
        Me.lbl_HBN_Desc.AutoSize = True
        Me.lbl_HBN_Desc.Location = New System.Drawing.Point(26, 45)
        Me.lbl_HBN_Desc.Name = "lbl_HBN_Desc"
        Me.lbl_HBN_Desc.Size = New System.Drawing.Size(185, 26)
        Me.lbl_HBN_Desc.TabIndex = 16
        Me.lbl_HBN_Desc.Text = "Reduces the cost of Beats per Attack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "against Carpal Tunnel by 0.01"
        Me.lbl_HBN_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(233, 215)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Secondary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(399, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 26)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Power Tugs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Beats Left"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(121, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 25)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "You Have"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 25)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Carpal Tunnel's HP:"
        '
        'lblHP_CarpalTunnel
        '
        Me.lblHP_CarpalTunnel.AutoSize = True
        Me.lblHP_CarpalTunnel.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblHP_CarpalTunnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHP_CarpalTunnel.ForeColor = System.Drawing.Color.Red
        Me.lblHP_CarpalTunnel.Location = New System.Drawing.Point(235, 375)
        Me.lblHP_CarpalTunnel.Name = "lblHP_CarpalTunnel"
        Me.lblHP_CarpalTunnel.Size = New System.Drawing.Size(30, 31)
        Me.lblHP_CarpalTunnel.TabIndex = 56
        Me.lblHP_CarpalTunnel.Text = "0"
        '
        'pbCarpalTunnel
        '
        Me.pbCarpalTunnel.Image = Global.MeatBeater.My.Resources.Resources.hand
        Me.pbCarpalTunnel.Location = New System.Drawing.Point(-50, 91)
        Me.pbCarpalTunnel.Name = "pbCarpalTunnel"
        Me.pbCarpalTunnel.Size = New System.Drawing.Size(377, 281)
        Me.pbCarpalTunnel.TabIndex = 53
        Me.pbCarpalTunnel.TabStop = False
        '
        'lblMeatBeaten
        '
        Me.lblMeatBeaten.AutoSize = True
        Me.lblMeatBeaten.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMeatBeaten.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeatBeaten.ForeColor = System.Drawing.Color.Red
        Me.lblMeatBeaten.Location = New System.Drawing.Point(67, 32)
        Me.lblMeatBeaten.Name = "lblMeatBeaten"
        Me.lblMeatBeaten.Size = New System.Drawing.Size(25, 25)
        Me.lblMeatBeaten.TabIndex = 61
        Me.lblMeatBeaten.Text = "0"
        '
        'TimerCarpalTunnel
        '
        Me.TimerCarpalTunnel.Interval = 1000
        '
        'btn_Load
        '
        Me.btn_Load.Location = New System.Drawing.Point(464, 379)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(75, 23)
        Me.btn_Load.TabIndex = 63
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(372, 379)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 62
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'frmCarpalTunnelBossBattle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 430)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.lblMeatBeaten)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblHP_CarpalTunnel)
        Me.Controls.Add(Me.pbCarpalTunnel)
        Me.Name = "frmCarpalTunnelBossBattle"
        Me.Text = "Boss Battle: Carpal Tunnel"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbCarpalTunnel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnPowerTug_HBN As Button
    Friend WithEvents btnPowerTug_HL As Button
    Friend WithEvents lbl_HBN_Title As Label
    Friend WithEvents lbl_HL_Title As Label
    Friend WithEvents lbl_HL_Desc As Label
    Friend WithEvents lbl_HBN_Desc As Label
    Friend WithEvents lbl_MRS_BPS As Label
    Friend WithEvents lbl_HBN_NumberOwned As Label
    Friend WithEvents lbl_HL_NumberOwned As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHP_CarpalTunnel As Label
    Friend WithEvents pbCarpalTunnel As PictureBox
    Friend WithEvents lblMeatBeaten As Label
    Friend WithEvents TimerCarpalTunnel As Timer
    Friend WithEvents lbl_BPS_HBN As Label
    Friend WithEvents lbl_BPS_HL As Label
    Friend WithEvents btn_Load As Button
    Friend WithEvents btn_Save As Button
End Class
