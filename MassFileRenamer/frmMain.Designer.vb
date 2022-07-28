<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.GrpSearchandRemove = New System.Windows.Forms.GroupBox()
        Me.chkTestRemove = New System.Windows.Forms.CheckBox()
        Me.chkRegexRemove = New System.Windows.Forms.CheckBox()
        Me.txtSearchRemove = New System.Windows.Forms.TextBox()
        Me.btnSearchRemove = New System.Windows.Forms.Button()
        Me.grpStripXBeginning = New System.Windows.Forms.GroupBox()
        Me.RadioEnd = New System.Windows.Forms.RadioButton()
        Me.RadioBeginning = New System.Windows.Forms.RadioButton()
        Me.chkIgonreHidden = New System.Windows.Forms.CheckBox()
        Me.txtStripX = New System.Windows.Forms.TextBox()
        Me.btnStripX = New System.Windows.Forms.Button()
        Me.numStripX = New System.Windows.Forms.NumericUpDown()
        Me.grpSearchandReplace = New System.Windows.Forms.GroupBox()
        Me.chkTestMode = New System.Windows.Forms.CheckBox()
        Me.chkRegex = New System.Windows.Forms.CheckBox()
        Me.btnSearchandReplace = New System.Windows.Forms.Button()
        Me.txtSearchandReplaceReplace = New System.Windows.Forms.TextBox()
        Me.txtSearchandReplaceSearch = New System.Windows.Forms.TextBox()
        Me.dlgOpenFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnProperCase = New System.Windows.Forms.Button()
        Me.btnShowRegexHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.GrpSearchandRemove.SuspendLayout()
        Me.grpStripXBeginning.SuspendLayout()
        CType(Me.numStripX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearchandReplace.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(471, 12)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(60, 24)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtDirectory
        '
        Me.txtDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDirectory.ForeColor = System.Drawing.Color.Silver
        Me.txtDirectory.Location = New System.Drawing.Point(12, 16)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(453, 20)
        Me.txtDirectory.TabIndex = 0
        Me.txtDirectory.Text = "Path To Directory"
        '
        'GrpSearchandRemove
        '
        Me.GrpSearchandRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSearchandRemove.Controls.Add(Me.chkTestRemove)
        Me.GrpSearchandRemove.Controls.Add(Me.chkRegexRemove)
        Me.GrpSearchandRemove.Controls.Add(Me.txtSearchRemove)
        Me.GrpSearchandRemove.Controls.Add(Me.btnSearchRemove)
        Me.GrpSearchandRemove.Location = New System.Drawing.Point(12, 52)
        Me.GrpSearchandRemove.Name = "GrpSearchandRemove"
        Me.GrpSearchandRemove.Size = New System.Drawing.Size(519, 68)
        Me.GrpSearchandRemove.TabIndex = 2
        Me.GrpSearchandRemove.TabStop = False
        Me.GrpSearchandRemove.Text = "Search and Remove text"
        '
        'chkTestRemove
        '
        Me.chkTestRemove.AutoSize = True
        Me.chkTestRemove.Enabled = False
        Me.chkTestRemove.Location = New System.Drawing.Point(130, 45)
        Me.chkTestRemove.Name = "chkTestRemove"
        Me.chkTestRemove.Size = New System.Drawing.Size(316, 17)
        Me.chkTestRemove.TabIndex = 5
        Me.chkTestRemove.Text = "Test Mode - Show findings on regex and don't make changes"
        Me.chkTestRemove.UseVisualStyleBackColor = True
        '
        'chkRegexRemove
        '
        Me.chkRegexRemove.AutoSize = True
        Me.chkRegexRemove.Location = New System.Drawing.Point(11, 46)
        Me.chkRegexRemove.Name = "chkRegexRemove"
        Me.chkRegexRemove.Size = New System.Drawing.Size(113, 17)
        Me.chkRegexRemove.TabIndex = 4
        Me.chkRegexRemove.Text = "Search is a Regex"
        Me.chkRegexRemove.UseVisualStyleBackColor = True
        '
        'txtSearchRemove
        '
        Me.txtSearchRemove.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchRemove.ForeColor = System.Drawing.Color.Silver
        Me.txtSearchRemove.Location = New System.Drawing.Point(11, 20)
        Me.txtSearchRemove.Name = "txtSearchRemove"
        Me.txtSearchRemove.Size = New System.Drawing.Size(440, 20)
        Me.txtSearchRemove.TabIndex = 2
        Me.txtSearchRemove.Text = "Search For Text to Remove"
        '
        'btnSearchRemove
        '
        Me.btnSearchRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchRemove.Location = New System.Drawing.Point(457, 16)
        Me.btnSearchRemove.Name = "btnSearchRemove"
        Me.btnSearchRemove.Size = New System.Drawing.Size(50, 24)
        Me.btnSearchRemove.TabIndex = 3
        Me.btnSearchRemove.Text = "Go"
        Me.btnSearchRemove.UseVisualStyleBackColor = True
        '
        'grpStripXBeginning
        '
        Me.grpStripXBeginning.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpStripXBeginning.Controls.Add(Me.RadioEnd)
        Me.grpStripXBeginning.Controls.Add(Me.RadioBeginning)
        Me.grpStripXBeginning.Controls.Add(Me.chkIgonreHidden)
        Me.grpStripXBeginning.Controls.Add(Me.txtStripX)
        Me.grpStripXBeginning.Controls.Add(Me.btnStripX)
        Me.grpStripXBeginning.Controls.Add(Me.numStripX)
        Me.grpStripXBeginning.Location = New System.Drawing.Point(12, 126)
        Me.grpStripXBeginning.Name = "grpStripXBeginning"
        Me.grpStripXBeginning.Size = New System.Drawing.Size(519, 69)
        Me.grpStripXBeginning.TabIndex = 3
        Me.grpStripXBeginning.TabStop = False
        Me.grpStripXBeginning.Text = "Strip X From Beginning or End"
        '
        'RadioEnd
        '
        Me.RadioEnd.AutoSize = True
        Me.RadioEnd.Location = New System.Drawing.Point(11, 40)
        Me.RadioEnd.Name = "RadioEnd"
        Me.RadioEnd.Size = New System.Drawing.Size(44, 17)
        Me.RadioEnd.TabIndex = 7
        Me.RadioEnd.Text = "End"
        Me.RadioEnd.UseVisualStyleBackColor = True
        '
        'RadioBeginning
        '
        Me.RadioBeginning.AutoSize = True
        Me.RadioBeginning.Checked = True
        Me.RadioBeginning.Location = New System.Drawing.Point(11, 19)
        Me.RadioBeginning.Name = "RadioBeginning"
        Me.RadioBeginning.Size = New System.Drawing.Size(72, 17)
        Me.RadioBeginning.TabIndex = 6
        Me.RadioBeginning.TabStop = True
        Me.RadioBeginning.Text = "Beginning"
        Me.RadioBeginning.UseVisualStyleBackColor = True
        '
        'chkIgonreHidden
        '
        Me.chkIgonreHidden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIgonreHidden.AutoSize = True
        Me.chkIgonreHidden.Checked = True
        Me.chkIgonreHidden.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIgonreHidden.Location = New System.Drawing.Point(401, 30)
        Me.chkIgonreHidden.Name = "chkIgonreHidden"
        Me.chkIgonreHidden.Size = New System.Drawing.Size(93, 17)
        Me.chkIgonreHidden.TabIndex = 11
        Me.chkIgonreHidden.Text = "Ignore Hidden"
        Me.chkIgonreHidden.UseVisualStyleBackColor = True
        '
        'txtStripX
        '
        Me.txtStripX.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtStripX.ForeColor = System.Drawing.Color.Silver
        Me.txtStripX.Location = New System.Drawing.Point(273, 29)
        Me.txtStripX.Name = "txtStripX"
        Me.txtStripX.Size = New System.Drawing.Size(108, 20)
        Me.txtStripX.TabIndex = 10
        Me.txtStripX.Text = "File Ext"
        '
        'btnStripX
        '
        Me.btnStripX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStripX.Location = New System.Drawing.Point(191, 20)
        Me.btnStripX.Name = "btnStripX"
        Me.btnStripX.Size = New System.Drawing.Size(72, 37)
        Me.btnStripX.TabIndex = 9
        Me.btnStripX.Text = "Go"
        Me.btnStripX.UseVisualStyleBackColor = True
        '
        'numStripX
        '
        Me.numStripX.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numStripX.Location = New System.Drawing.Point(107, 30)
        Me.numStripX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numStripX.Name = "numStripX"
        Me.numStripX.Size = New System.Drawing.Size(68, 20)
        Me.numStripX.TabIndex = 8
        Me.numStripX.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'grpSearchandReplace
        '
        Me.grpSearchandReplace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpSearchandReplace.Controls.Add(Me.chkTestMode)
        Me.grpSearchandReplace.Controls.Add(Me.chkRegex)
        Me.grpSearchandReplace.Controls.Add(Me.btnSearchandReplace)
        Me.grpSearchandReplace.Controls.Add(Me.txtSearchandReplaceReplace)
        Me.grpSearchandReplace.Controls.Add(Me.txtSearchandReplaceSearch)
        Me.grpSearchandReplace.Location = New System.Drawing.Point(12, 201)
        Me.grpSearchandReplace.Name = "grpSearchandReplace"
        Me.grpSearchandReplace.Size = New System.Drawing.Size(519, 97)
        Me.grpSearchandReplace.TabIndex = 4
        Me.grpSearchandReplace.TabStop = False
        Me.grpSearchandReplace.Text = "Search and Replace Text"
        '
        'chkTestMode
        '
        Me.chkTestMode.AutoSize = True
        Me.chkTestMode.Enabled = False
        Me.chkTestMode.Location = New System.Drawing.Point(130, 72)
        Me.chkTestMode.Name = "chkTestMode"
        Me.chkTestMode.Size = New System.Drawing.Size(316, 17)
        Me.chkTestMode.TabIndex = 16
        Me.chkTestMode.Text = "Test Mode - Show findings on regex and don't make changes"
        Me.chkTestMode.UseVisualStyleBackColor = True
        '
        'chkRegex
        '
        Me.chkRegex.AutoSize = True
        Me.chkRegex.Location = New System.Drawing.Point(11, 72)
        Me.chkRegex.Name = "chkRegex"
        Me.chkRegex.Size = New System.Drawing.Size(113, 17)
        Me.chkRegex.TabIndex = 15
        Me.chkRegex.Text = "Search is a Regex"
        Me.chkRegex.UseVisualStyleBackColor = True
        '
        'btnSearchandReplace
        '
        Me.btnSearchandReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchandReplace.Location = New System.Drawing.Point(459, 19)
        Me.btnSearchandReplace.Name = "btnSearchandReplace"
        Me.btnSearchandReplace.Size = New System.Drawing.Size(47, 50)
        Me.btnSearchandReplace.TabIndex = 14
        Me.btnSearchandReplace.Text = "Go"
        Me.btnSearchandReplace.UseVisualStyleBackColor = True
        '
        'txtSearchandReplaceReplace
        '
        Me.txtSearchandReplaceReplace.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchandReplaceReplace.ForeColor = System.Drawing.Color.Silver
        Me.txtSearchandReplaceReplace.Location = New System.Drawing.Point(11, 49)
        Me.txtSearchandReplaceReplace.Name = "txtSearchandReplaceReplace"
        Me.txtSearchandReplaceReplace.Size = New System.Drawing.Size(440, 20)
        Me.txtSearchandReplaceReplace.TabIndex = 13
        Me.txtSearchandReplaceReplace.Text = "Replacement String"
        '
        'txtSearchandReplaceSearch
        '
        Me.txtSearchandReplaceSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchandReplaceSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearchandReplaceSearch.Location = New System.Drawing.Point(11, 23)
        Me.txtSearchandReplaceSearch.Name = "txtSearchandReplaceSearch"
        Me.txtSearchandReplaceSearch.Size = New System.Drawing.Size(440, 20)
        Me.txtSearchandReplaceSearch.TabIndex = 12
        Me.txtSearchandReplaceSearch.Text = "Search String"
        '
        'BtnProperCase
        '
        Me.BtnProperCase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnProperCase.Location = New System.Drawing.Point(203, 305)
        Me.BtnProperCase.Name = "BtnProperCase"
        Me.BtnProperCase.Size = New System.Drawing.Size(176, 32)
        Me.BtnProperCase.TabIndex = 18
        Me.BtnProperCase.Text = "Proper Case Files"
        Me.BtnProperCase.UseVisualStyleBackColor = True
        '
        'btnShowRegexHelp
        '
        Me.btnShowRegexHelp.Location = New System.Drawing.Point(23, 305)
        Me.btnShowRegexHelp.Name = "btnShowRegexHelp"
        Me.btnShowRegexHelp.Size = New System.Drawing.Size(83, 32)
        Me.btnShowRegexHelp.TabIndex = 17
        Me.btnShowRegexHelp.Text = "RegEx Help"
        Me.btnShowRegexHelp.UseVisualStyleBackColor = True
        Me.btnShowRegexHelp.Visible = False
        '
        'btnAbout
        '
        Me.btnAbout.Location = New System.Drawing.Point(450, 305)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(80, 31)
        Me.btnAbout.TabIndex = 19
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 349)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.btnShowRegexHelp)
        Me.Controls.Add(Me.BtnProperCase)
        Me.Controls.Add(Me.grpSearchandReplace)
        Me.Controls.Add(Me.grpStripXBeginning)
        Me.Controls.Add(Me.GrpSearchandRemove)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.btnOpen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Mass File Renamer"
        Me.GrpSearchandRemove.ResumeLayout(False)
        Me.GrpSearchandRemove.PerformLayout()
        Me.grpStripXBeginning.ResumeLayout(False)
        Me.grpStripXBeginning.PerformLayout()
        CType(Me.numStripX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearchandReplace.ResumeLayout(False)
        Me.grpSearchandReplace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtDirectory As System.Windows.Forms.TextBox
    Friend WithEvents GrpSearchandRemove As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearchRemove As System.Windows.Forms.TextBox
    Friend WithEvents btnSearchRemove As System.Windows.Forms.Button
    Friend WithEvents grpStripXBeginning As System.Windows.Forms.GroupBox
    Friend WithEvents btnStripX As System.Windows.Forms.Button
    Friend WithEvents numStripX As System.Windows.Forms.NumericUpDown
    Friend WithEvents grpSearchandReplace As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchandReplace As System.Windows.Forms.Button
    Friend WithEvents txtSearchandReplaceReplace As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchandReplaceSearch As System.Windows.Forms.TextBox
    Friend WithEvents dlgOpenFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtStripX As System.Windows.Forms.TextBox
    Friend WithEvents BtnProperCase As System.Windows.Forms.Button
    Friend WithEvents chkIgonreHidden As System.Windows.Forms.CheckBox
    Friend WithEvents RadioEnd As System.Windows.Forms.RadioButton
    Friend WithEvents RadioBeginning As System.Windows.Forms.RadioButton
    Friend WithEvents chkTestMode As System.Windows.Forms.CheckBox
    Friend WithEvents chkRegex As System.Windows.Forms.CheckBox
    Friend WithEvents btnShowRegexHelp As System.Windows.Forms.Button
    Friend WithEvents chkRegexRemove As System.Windows.Forms.CheckBox
    Friend WithEvents chkTestRemove As System.Windows.Forms.CheckBox
    Friend WithEvents btnAbout As System.Windows.Forms.Button

End Class
