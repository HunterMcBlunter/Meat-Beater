<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMeatBeater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMeatBeater))
        Me.lblMeatBeaten = New System.Windows.Forms.Label()
        Me.TimerMinute = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10Secs = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.lblMRSTitle = New System.Windows.Forms.Label()
        Me.lblRPTitle = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblQSTitle = New System.Windows.Forms.Label()
        Me.lblQSDesc = New System.Windows.Forms.Label()
        Me.lblRPDesc = New System.Windows.Forms.Label()
        Me.lblMRSDesc = New System.Windows.Forms.Label()
        Me.lbl_MRS_BPS = New System.Windows.Forms.Label()
        Me.lbl_MRS_NumberOwned = New System.Windows.Forms.Label()
        Me.btnPowerTugs_MRS = New System.Windows.Forms.Button()
        Me.lbl_RP_BPS = New System.Windows.Forms.Label()
        Me.lbl_RP_NumberOwned = New System.Windows.Forms.Label()
        Me.btnPowerTugs_RP = New System.Windows.Forms.Button()
        Me.lbl_QS_BPS = New System.Windows.Forms.Label()
        Me.lbl_QS_NumberOwned = New System.Windows.Forms.Label()
        Me.btnPowerTug_QS = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabAch = New System.Windows.Forms.TabPage()
        Me.list_Ach = New System.Windows.Forms.ListBox()
        Me.TabStats = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.StatAchievementTabs = New System.Windows.Forms.TabControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_Load = New System.Windows.Forms.Button()
        Me.txtMeatCheat = New System.Windows.Forms.TextBox()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.pbMeat = New System.Windows.Forms.PictureBox()
        Me.btnTutorial = New System.Windows.Forms.Button()
        Me.lbl_Timer_Carpal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer5Mins = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabAch.SuspendLayout()
        Me.StatAchievementTabs.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMeat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMeatBeaten
        '
        Me.lblMeatBeaten.AutoSize = True
        Me.lblMeatBeaten.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblMeatBeaten.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeatBeaten.ForeColor = System.Drawing.Color.Red
        Me.lblMeatBeaten.Location = New System.Drawing.Point(91, 73)
        Me.lblMeatBeaten.Name = "lblMeatBeaten"
        Me.lblMeatBeaten.Size = New System.Drawing.Size(25, 25)
        Me.lblMeatBeaten.TabIndex = 22
        Me.lblMeatBeaten.Text = "0"
        '
        'TimerMinute
        '
        '
        'Timer10Secs
        '
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(233, 324)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Secondary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblMRSTitle
        '
        Me.lblMRSTitle.AutoSize = True
        Me.lblMRSTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMRSTitle.Location = New System.Drawing.Point(83, 234)
        Me.lblMRSTitle.Name = "lblMRSTitle"
        Me.lblMRSTitle.Size = New System.Drawing.Size(65, 13)
        Me.lblMRSTitle.TabIndex = 20
        Me.lblMRSTitle.Text = "Mr. Socko"
        '
        'lblRPTitle
        '
        Me.lblRPTitle.AutoSize = True
        Me.lblRPTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRPTitle.Location = New System.Drawing.Point(70, 119)
        Me.lblRPTitle.Name = "lblRPTitle"
        Me.lblRPTitle.Size = New System.Drawing.Size(79, 13)
        Me.lblRPTitle.TabIndex = 19
        Me.lblRPTitle.Text = "Rosey Palms"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(410, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(241, 350)
        Me.TabControl1.TabIndex = 44
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblMRSTitle)
        Me.TabPage1.Controls.Add(Me.lblRPTitle)
        Me.TabPage1.Controls.Add(Me.lblQSTitle)
        Me.TabPage1.Controls.Add(Me.lblQSDesc)
        Me.TabPage1.Controls.Add(Me.lblRPDesc)
        Me.TabPage1.Controls.Add(Me.lblMRSDesc)
        Me.TabPage1.Controls.Add(Me.lbl_MRS_BPS)
        Me.TabPage1.Controls.Add(Me.lbl_MRS_NumberOwned)
        Me.TabPage1.Controls.Add(Me.btnPowerTugs_MRS)
        Me.TabPage1.Controls.Add(Me.lbl_RP_BPS)
        Me.TabPage1.Controls.Add(Me.lbl_RP_NumberOwned)
        Me.TabPage1.Controls.Add(Me.btnPowerTugs_RP)
        Me.TabPage1.Controls.Add(Me.lbl_QS_BPS)
        Me.TabPage1.Controls.Add(Me.lbl_QS_NumberOwned)
        Me.TabPage1.Controls.Add(Me.btnPowerTug_QS)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(233, 324)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Primary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblQSTitle
        '
        Me.lblQSTitle.AutoSize = True
        Me.lblQSTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQSTitle.Location = New System.Drawing.Point(70, 3)
        Me.lblQSTitle.Name = "lblQSTitle"
        Me.lblQSTitle.Size = New System.Drawing.Size(88, 13)
        Me.lblQSTitle.TabIndex = 18
        Me.lblQSTitle.Text = "Quick Scratch"
        '
        'lblQSDesc
        '
        Me.lblQSDesc.AutoSize = True
        Me.lblQSDesc.Location = New System.Drawing.Point(8, 46)
        Me.lblQSDesc.Name = "lblQSDesc"
        Me.lblQSDesc.Size = New System.Drawing.Size(214, 26)
        Me.lblQSDesc.TabIndex = 17
        Me.lblQSDesc.Text = "Automatically adds 0.1 Beats to Meat every " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10 seconds for each one purchased."
        Me.lblQSDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRPDesc
        '
        Me.lblRPDesc.AutoSize = True
        Me.lblRPDesc.Location = New System.Drawing.Point(17, 165)
        Me.lblRPDesc.Name = "lblRPDesc"
        Me.lblRPDesc.Size = New System.Drawing.Size(205, 26)
        Me.lblRPDesc.TabIndex = 16
        Me.lblRPDesc.Text = "Automatically adds 2 Beats to Meat every " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "second for each one purchased."
        Me.lblRPDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMRSDesc
        '
        Me.lblMRSDesc.AutoSize = True
        Me.lblMRSDesc.Location = New System.Drawing.Point(8, 282)
        Me.lblMRSDesc.Name = "lblMRSDesc"
        Me.lblMRSDesc.Size = New System.Drawing.Size(219, 13)
        Me.lblMRSDesc.TabIndex = 15
        Me.lblMRSDesc.Text = "Doubles the Value of Beats to Meat per Click"
        '
        'lbl_MRS_BPS
        '
        Me.lbl_MRS_BPS.AutoSize = True
        Me.lbl_MRS_BPS.Location = New System.Drawing.Point(114, 302)
        Me.lbl_MRS_BPS.Name = "lbl_MRS_BPS"
        Me.lbl_MRS_BPS.Size = New System.Drawing.Size(0, 13)
        Me.lbl_MRS_BPS.TabIndex = 14
        '
        'lbl_MRS_NumberOwned
        '
        Me.lbl_MRS_NumberOwned.AutoSize = True
        Me.lbl_MRS_NumberOwned.Location = New System.Drawing.Point(70, 302)
        Me.lbl_MRS_NumberOwned.Name = "lbl_MRS_NumberOwned"
        Me.lbl_MRS_NumberOwned.Size = New System.Drawing.Size(93, 13)
        Me.lbl_MRS_NumberOwned.TabIndex = 13
        Me.lbl_MRS_NumberOwned.Text = "Number Owned: 0"
        '
        'btnPowerTugs_MRS
        '
        Me.btnPowerTugs_MRS.Location = New System.Drawing.Point(3, 254)
        Me.btnPowerTugs_MRS.Name = "btnPowerTugs_MRS"
        Me.btnPowerTugs_MRS.Size = New System.Drawing.Size(228, 25)
        Me.btnPowerTugs_MRS.TabIndex = 12
        Me.btnPowerTugs_MRS.Text = "Cost in Beats: 1500" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPowerTugs_MRS.UseVisualStyleBackColor = True
        '
        'lbl_RP_BPS
        '
        Me.lbl_RP_BPS.AutoSize = True
        Me.lbl_RP_BPS.Location = New System.Drawing.Point(114, 199)
        Me.lbl_RP_BPS.Name = "lbl_RP_BPS"
        Me.lbl_RP_BPS.Size = New System.Drawing.Size(105, 13)
        Me.lbl_RP_BPS.TabIndex = 11
        Me.lbl_RP_BPS.Text = "Beats Per Second: 0"
        '
        'lbl_RP_NumberOwned
        '
        Me.lbl_RP_NumberOwned.AutoSize = True
        Me.lbl_RP_NumberOwned.Location = New System.Drawing.Point(4, 199)
        Me.lbl_RP_NumberOwned.Name = "lbl_RP_NumberOwned"
        Me.lbl_RP_NumberOwned.Size = New System.Drawing.Size(93, 13)
        Me.lbl_RP_NumberOwned.TabIndex = 10
        Me.lbl_RP_NumberOwned.Text = "Number Owned: 0"
        '
        'btnPowerTugs_RP
        '
        Me.btnPowerTugs_RP.Location = New System.Drawing.Point(3, 135)
        Me.btnPowerTugs_RP.Name = "btnPowerTugs_RP"
        Me.btnPowerTugs_RP.Size = New System.Drawing.Size(228, 23)
        Me.btnPowerTugs_RP.TabIndex = 9
        Me.btnPowerTugs_RP.Text = "Cost in Beats: 150 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPowerTugs_RP.UseVisualStyleBackColor = True
        '
        'lbl_QS_BPS
        '
        Me.lbl_QS_BPS.AutoSize = True
        Me.lbl_QS_BPS.Location = New System.Drawing.Point(97, 81)
        Me.lbl_QS_BPS.Name = "lbl_QS_BPS"
        Me.lbl_QS_BPS.Size = New System.Drawing.Size(125, 13)
        Me.lbl_QS_BPS.TabIndex = 8
        Me.lbl_QS_BPS.Text = "Beats Per 10 Seconds: 0"
        '
        'lbl_QS_NumberOwned
        '
        Me.lbl_QS_NumberOwned.AutoSize = True
        Me.lbl_QS_NumberOwned.Location = New System.Drawing.Point(0, 81)
        Me.lbl_QS_NumberOwned.Name = "lbl_QS_NumberOwned"
        Me.lbl_QS_NumberOwned.Size = New System.Drawing.Size(93, 13)
        Me.lbl_QS_NumberOwned.TabIndex = 6
        Me.lbl_QS_NumberOwned.Text = "Number Owned: 0"
        '
        'btnPowerTug_QS
        '
        Me.btnPowerTug_QS.Location = New System.Drawing.Point(2, 19)
        Me.btnPowerTug_QS.Name = "btnPowerTug_QS"
        Me.btnPowerTug_QS.Size = New System.Drawing.Size(228, 22)
        Me.btnPowerTug_QS.TabIndex = 0
        Me.btnPowerTug_QS.Text = "Cost in Beats: 15" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnPowerTug_QS.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Power Tugs"
        '
        'TabAch
        '
        Me.TabAch.Controls.Add(Me.list_Ach)
        Me.TabAch.Location = New System.Drawing.Point(4, 22)
        Me.TabAch.Name = "TabAch"
        Me.TabAch.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAch.Size = New System.Drawing.Size(633, 134)
        Me.TabAch.TabIndex = 0
        Me.TabAch.Text = "Achievements"
        Me.TabAch.UseVisualStyleBackColor = True
        '
        'list_Ach
        '
        Me.list_Ach.FormattingEnabled = True
        Me.list_Ach.Location = New System.Drawing.Point(0, 0)
        Me.list_Ach.Name = "list_Ach"
        Me.list_Ach.Size = New System.Drawing.Size(633, 134)
        Me.list_Ach.TabIndex = 0
        '
        'TabStats
        '
        Me.TabStats.Location = New System.Drawing.Point(4, 22)
        Me.TabStats.Name = "TabStats"
        Me.TabStats.Padding = New System.Windows.Forms.Padding(3)
        Me.TabStats.Size = New System.Drawing.Size(633, 134)
        Me.TabStats.TabIndex = 1
        Me.TabStats.Text = "Statistics"
        Me.TabStats.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(545, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Cheat your Meat "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(167, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 25)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Times"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(55, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(305, 25)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "You have Beaten your Meat"
        '
        'StatAchievementTabs
        '
        Me.StatAchievementTabs.Controls.Add(Me.TabAch)
        Me.StatAchievementTabs.Controls.Add(Me.TabStats)
        Me.StatAchievementTabs.Location = New System.Drawing.Point(4, 442)
        Me.StatAchievementTabs.Name = "StatAchievementTabs"
        Me.StatAchievementTabs.SelectedIndex = 0
        Me.StatAchievementTabs.Size = New System.Drawing.Size(641, 160)
        Me.StatAchievementTabs.TabIndex = 51
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(86, 72)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(261, 27)
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        '
        'btn_Load
        '
        Me.btn_Load.Location = New System.Drawing.Point(106, 348)
        Me.btn_Load.Name = "btn_Load"
        Me.btn_Load.Size = New System.Drawing.Size(75, 23)
        Me.btn_Load.TabIndex = 50
        Me.btn_Load.Text = "Load"
        Me.btn_Load.UseVisualStyleBackColor = True
        '
        'txtMeatCheat
        '
        Me.txtMeatCheat.Location = New System.Drawing.Point(534, 421)
        Me.txtMeatCheat.Name = "txtMeatCheat"
        Me.txtMeatCheat.Size = New System.Drawing.Size(100, 20)
        Me.txtMeatCheat.TabIndex = 43
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(14, 348)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(75, 23)
        Me.btn_Save.TabIndex = 49
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'pbMeat
        '
        Me.pbMeat.Image = Global.MeatBeater.My.Resources.Resources.meat1
        Me.pbMeat.Location = New System.Drawing.Point(6, 186)
        Me.pbMeat.Name = "pbMeat"
        Me.pbMeat.Size = New System.Drawing.Size(398, 128)
        Me.pbMeat.TabIndex = 52
        Me.pbMeat.TabStop = False
        '
        'btnTutorial
        '
        Me.btnTutorial.Location = New System.Drawing.Point(14, 377)
        Me.btnTutorial.Name = "btnTutorial"
        Me.btnTutorial.Size = New System.Drawing.Size(167, 23)
        Me.btnTutorial.TabIndex = 53
        Me.btnTutorial.Text = "Tutorials"
        Me.btnTutorial.UseVisualStyleBackColor = True
        '
        'lbl_Timer_Carpal
        '
        Me.lbl_Timer_Carpal.AutoSize = True
        Me.lbl_Timer_Carpal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_Timer_Carpal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Timer_Carpal.ForeColor = System.Drawing.Color.Red
        Me.lbl_Timer_Carpal.Location = New System.Drawing.Point(302, 341)
        Me.lbl_Timer_Carpal.Name = "lbl_Timer_Carpal"
        Me.lbl_Timer_Carpal.Size = New System.Drawing.Size(51, 25)
        Me.lbl_Timer_Carpal.TabIndex = 54
        Me.lbl_Timer_Carpal.Text = "300"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(260, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 50)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Seconds Until" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Carpal Tunnel"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer5Mins
        '
        '
        'frmMeatBeater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 614)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Timer_Carpal)
        Me.Controls.Add(Me.btnTutorial)
        Me.Controls.Add(Me.pbMeat)
        Me.Controls.Add(Me.lblMeatBeaten)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.StatAchievementTabs)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_Load)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMeatCheat)
        Me.Controls.Add(Me.btn_Save)
        Me.Name = "frmMeatBeater"
        Me.Text = "MeatBeater"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabAch.ResumeLayout(False)
        Me.StatAchievementTabs.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMeat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMeatBeaten As Label
    Friend WithEvents TimerMinute As Timer
    Friend WithEvents Timer10Secs As Timer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lblMRSTitle As Label
    Friend WithEvents lblRPTitle As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lblQSTitle As Label
    Friend WithEvents lblQSDesc As Label
    Friend WithEvents lblRPDesc As Label
    Friend WithEvents lblMRSDesc As Label
    Friend WithEvents lbl_MRS_NumberOwned As Label
    Friend WithEvents btnPowerTugs_MRS As Button
    Friend WithEvents lbl_RP_BPS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_RP_NumberOwned As Label
    Friend WithEvents btnPowerTugs_RP As Button
    Friend WithEvents lbl_QS_BPS As Label
    Friend WithEvents lbl_QS_NumberOwned As Label
    Friend WithEvents btnPowerTug_QS As Button
    Friend WithEvents TabAch As TabPage
    Friend WithEvents TabStats As TabPage
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents StatAchievementTabs As TabControl
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_Load As Button
    Friend WithEvents txtMeatCheat As TextBox
    Friend WithEvents btn_Save As Button
    Friend WithEvents pbMeat As PictureBox
    Friend WithEvents btnTutorial As Button
    Friend WithEvents lbl_MRS_BPS As Label
    Friend WithEvents lbl_Timer_Carpal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer5Mins As Timer
    Friend WithEvents list_Ach As ListBox
End Class
