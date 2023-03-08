<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.lblExt = New System.Windows.Forms.Label()
        Me.txtExt = New System.Windows.Forms.TextBox()
        Me.lblOri = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lvOri = New System.Windows.Forms.ListView()
        Me.chFileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttribute = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreated = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvPreview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TpFilename = New System.Windows.Forms.TabPage()
        Me.txtWithThisF = New System.Windows.Forms.TextBox()
        Me.cbCaseF = New System.Windows.Forms.ComboBox()
        Me.txtRightCropNCharF = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCaseF = New System.Windows.Forms.Label()
        Me.txtLeftCropNCharF = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterF = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeF = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisF = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithF = New System.Windows.Forms.TextBox()
        Me.rbRightCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharF = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterF = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisF = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithF = New System.Windows.Forms.RadioButton()
        Me.TpExtension = New System.Windows.Forms.TabPage()
        Me.txtWithThisE = New System.Windows.Forms.TextBox()
        Me.cbCaseE = New System.Windows.Forms.ComboBox()
        Me.txtRightCropNCharE = New System.Windows.Forms.TextBox()
        Me.lblWithThisE = New System.Windows.Forms.Label()
        Me.lblCaseE = New System.Windows.Forms.Label()
        Me.txtLeftCropNCharE = New System.Windows.Forms.TextBox()
        Me.txtInsertAfterE = New System.Windows.Forms.TextBox()
        Me.txtInsertBeforeE = New System.Windows.Forms.TextBox()
        Me.txtReplaceThisE = New System.Windows.Forms.TextBox()
        Me.txtReplaceWithE = New System.Windows.Forms.TextBox()
        Me.rbRightCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbLeftCropNCharE = New System.Windows.Forms.RadioButton()
        Me.rbInsertAfterE = New System.Windows.Forms.RadioButton()
        Me.rbInsertBeforeE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceThisE = New System.Windows.Forms.RadioButton()
        Me.rbReplaceWithE = New System.Windows.Forms.RadioButton()
        Me.TpAutoNumber = New System.Windows.Forms.TabPage()
        Me.gbWidth = New System.Windows.Forms.GroupBox()
        Me.nudIncrementBy = New System.Windows.Forms.NumericUpDown()
        Me.nudStartWithNumber = New System.Windows.Forms.NumericUpDown()
        Me.lblIncrementBy = New System.Windows.Forms.Label()
        Me.lblStartWithNumber = New System.Windows.Forms.Label()
        Me.gbPlace = New System.Windows.Forms.GroupBox()
        Me.rbBeforeFileName = New System.Windows.Forms.RadioButton()
        Me.rbAfterFileName = New System.Windows.Forms.RadioButton()
        Me.BtnPreview = New System.Windows.Forms.Button()
        Me.BtnRename = New System.Windows.Forms.Button()
        Me.BtnUndo = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TpFilename.SuspendLayout()
        Me.TpExtension.SuspendLayout()
        Me.TpAutoNumber.SuspendLayout()
        Me.gbWidth.SuspendLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPlace.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(22, 23)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(26, 13)
        Me.lblPath.TabIndex = 0
        Me.lblPath.Text = "File:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(81, 20)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.ReadOnly = True
        Me.txtPath.Size = New System.Drawing.Size(654, 20)
        Me.txtPath.TabIndex = 1
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(741, 17)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(46, 23)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'lblExt
        '
        Me.lblExt.AutoSize = True
        Me.lblExt.Location = New System.Drawing.Point(793, 22)
        Me.lblExt.Name = "lblExt"
        Me.lblExt.Size = New System.Drawing.Size(44, 13)
        Me.lblExt.TabIndex = 3
        Me.lblExt.Text = "File Ext:"
        '
        'txtExt
        '
        Me.txtExt.Location = New System.Drawing.Point(843, 19)
        Me.txtExt.Name = "txtExt"
        Me.txtExt.Size = New System.Drawing.Size(89, 20)
        Me.txtExt.TabIndex = 4
        Me.txtExt.Text = "*.*"
        '
        'lblOri
        '
        Me.lblOri.AutoSize = True
        Me.lblOri.Location = New System.Drawing.Point(22, 48)
        Me.lblOri.Name = "lblOri"
        Me.lblOri.Size = New System.Drawing.Size(64, 13)
        Me.lblOri.TabIndex = 5
        Me.lblOri.Text = "Original File:"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(491, 43)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(67, 13)
        Me.lblPreview.TabIndex = 6
        Me.lblPreview.Text = "Preview File:"
        '
        'lvOri
        '
        Me.lvOri.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFileName, Me.chExtension, Me.chAttribute, Me.chCreated, Me.chAccessed, Me.chModified})
        Me.lvOri.GridLines = True
        Me.lvOri.HideSelection = False
        Me.lvOri.Location = New System.Drawing.Point(25, 64)
        Me.lvOri.Name = "lvOri"
        Me.lvOri.Size = New System.Drawing.Size(458, 307)
        Me.lvOri.TabIndex = 7
        Me.lvOri.UseCompatibleStateImageBehavior = False
        Me.lvOri.View = System.Windows.Forms.View.Details
        '
        'chFileName
        '
        Me.chFileName.Text = "File Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chAttribute
        '
        Me.chAttribute.Text = "Attributes"
        '
        'chCreated
        '
        Me.chCreated.Text = "Date Created"
        '
        'chAccessed
        '
        Me.chAccessed.Text = "Date Accessed"
        '
        'chModified
        '
        Me.chModified.Text = "Date Modified"
        '
        'lvPreview
        '
        Me.lvPreview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvPreview.GridLines = True
        Me.lvPreview.HideSelection = False
        Me.lvPreview.Location = New System.Drawing.Point(494, 64)
        Me.lvPreview.Name = "lvPreview"
        Me.lvPreview.Size = New System.Drawing.Size(438, 307)
        Me.lvPreview.TabIndex = 8
        Me.lvPreview.UseCompatibleStateImageBehavior = False
        Me.lvPreview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "File Name"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Extension"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Attributes"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date Created"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date Accessed"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date Modified"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TpFilename)
        Me.TabControl1.Controls.Add(Me.TpExtension)
        Me.TabControl1.Controls.Add(Me.TpAutoNumber)
        Me.TabControl1.Location = New System.Drawing.Point(25, 377)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(826, 172)
        Me.TabControl1.TabIndex = 9
        '
        'TpFilename
        '
        Me.TpFilename.Controls.Add(Me.txtWithThisF)
        Me.TpFilename.Controls.Add(Me.cbCaseF)
        Me.TpFilename.Controls.Add(Me.txtRightCropNCharF)
        Me.TpFilename.Controls.Add(Me.Label1)
        Me.TpFilename.Controls.Add(Me.lblCaseF)
        Me.TpFilename.Controls.Add(Me.txtLeftCropNCharF)
        Me.TpFilename.Controls.Add(Me.txtInsertAfterF)
        Me.TpFilename.Controls.Add(Me.txtInsertBeforeF)
        Me.TpFilename.Controls.Add(Me.txtReplaceThisF)
        Me.TpFilename.Controls.Add(Me.txtReplaceWithF)
        Me.TpFilename.Controls.Add(Me.rbRightCropNCharF)
        Me.TpFilename.Controls.Add(Me.rbLeftCropNCharF)
        Me.TpFilename.Controls.Add(Me.rbInsertAfterF)
        Me.TpFilename.Controls.Add(Me.rbInsertBeforeF)
        Me.TpFilename.Controls.Add(Me.rbReplaceThisF)
        Me.TpFilename.Controls.Add(Me.rbReplaceWithF)
        Me.TpFilename.Location = New System.Drawing.Point(4, 22)
        Me.TpFilename.Name = "TpFilename"
        Me.TpFilename.Padding = New System.Windows.Forms.Padding(3)
        Me.TpFilename.Size = New System.Drawing.Size(818, 146)
        Me.TpFilename.TabIndex = 0
        Me.TpFilename.Text = "Filename"
        Me.TpFilename.UseVisualStyleBackColor = True
        '
        'txtWithThisF
        '
        Me.txtWithThisF.Location = New System.Drawing.Point(537, 44)
        Me.txtWithThisF.Name = "txtWithThisF"
        Me.txtWithThisF.ReadOnly = True
        Me.txtWithThisF.Size = New System.Drawing.Size(275, 20)
        Me.txtWithThisF.TabIndex = 15
        '
        'cbCaseF
        '
        Me.cbCaseF.FormattingEnabled = True
        Me.cbCaseF.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseF.Location = New System.Drawing.Point(537, 16)
        Me.cbCaseF.Name = "cbCaseF"
        Me.cbCaseF.Size = New System.Drawing.Size(271, 21)
        Me.cbCaseF.TabIndex = 14
        '
        'txtRightCropNCharF
        '
        Me.txtRightCropNCharF.Location = New System.Drawing.Point(575, 110)
        Me.txtRightCropNCharF.Name = "txtRightCropNCharF"
        Me.txtRightCropNCharF.ReadOnly = True
        Me.txtRightCropNCharF.Size = New System.Drawing.Size(237, 20)
        Me.txtRightCropNCharF.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(462, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "With This"
        '
        'lblCaseF
        '
        Me.lblCaseF.AutoSize = True
        Me.lblCaseF.Location = New System.Drawing.Point(462, 20)
        Me.lblCaseF.Name = "lblCaseF"
        Me.lblCaseF.Size = New System.Drawing.Size(34, 13)
        Me.lblCaseF.TabIndex = 11
        Me.lblCaseF.Text = "Case:"
        '
        'txtLeftCropNCharF
        '
        Me.txtLeftCropNCharF.Location = New System.Drawing.Point(134, 110)
        Me.txtLeftCropNCharF.Name = "txtLeftCropNCharF"
        Me.txtLeftCropNCharF.ReadOnly = True
        Me.txtLeftCropNCharF.Size = New System.Drawing.Size(238, 20)
        Me.txtLeftCropNCharF.TabIndex = 10
        '
        'txtInsertAfterF
        '
        Me.txtInsertAfterF.Location = New System.Drawing.Point(537, 71)
        Me.txtInsertAfterF.Name = "txtInsertAfterF"
        Me.txtInsertAfterF.ReadOnly = True
        Me.txtInsertAfterF.Size = New System.Drawing.Size(275, 20)
        Me.txtInsertAfterF.TabIndex = 9
        '
        'txtInsertBeforeF
        '
        Me.txtInsertBeforeF.Location = New System.Drawing.Point(103, 68)
        Me.txtInsertBeforeF.Name = "txtInsertBeforeF"
        Me.txtInsertBeforeF.ReadOnly = True
        Me.txtInsertBeforeF.Size = New System.Drawing.Size(351, 20)
        Me.txtInsertBeforeF.TabIndex = 8
        '
        'txtReplaceThisF
        '
        Me.txtReplaceThisF.Location = New System.Drawing.Point(103, 42)
        Me.txtReplaceThisF.Name = "txtReplaceThisF"
        Me.txtReplaceThisF.ReadOnly = True
        Me.txtReplaceThisF.Size = New System.Drawing.Size(351, 20)
        Me.txtReplaceThisF.TabIndex = 7
        '
        'txtReplaceWithF
        '
        Me.txtReplaceWithF.Location = New System.Drawing.Point(103, 16)
        Me.txtReplaceWithF.Name = "txtReplaceWithF"
        Me.txtReplaceWithF.ReadOnly = True
        Me.txtReplaceWithF.Size = New System.Drawing.Size(351, 20)
        Me.txtReplaceWithF.TabIndex = 6
        '
        'rbRightCropNCharF
        '
        Me.rbRightCropNCharF.AutoSize = True
        Me.rbRightCropNCharF.Location = New System.Drawing.Point(460, 111)
        Me.rbRightCropNCharF.Name = "rbRightCropNCharF"
        Me.rbRightCropNCharF.Size = New System.Drawing.Size(109, 17)
        Me.rbRightCropNCharF.TabIndex = 5
        Me.rbRightCropNCharF.TabStop = True
        Me.rbRightCropNCharF.Text = "Right Crop n Char"
        Me.rbRightCropNCharF.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharF
        '
        Me.rbLeftCropNCharF.AutoSize = True
        Me.rbLeftCropNCharF.Location = New System.Drawing.Point(6, 111)
        Me.rbLeftCropNCharF.Name = "rbLeftCropNCharF"
        Me.rbLeftCropNCharF.Size = New System.Drawing.Size(102, 17)
        Me.rbLeftCropNCharF.TabIndex = 4
        Me.rbLeftCropNCharF.TabStop = True
        Me.rbLeftCropNCharF.Text = "Left Crop n Char"
        Me.rbLeftCropNCharF.UseVisualStyleBackColor = True
        '
        'rbInsertAfterF
        '
        Me.rbInsertAfterF.AutoSize = True
        Me.rbInsertAfterF.Location = New System.Drawing.Point(460, 71)
        Me.rbInsertAfterF.Name = "rbInsertAfterF"
        Me.rbInsertAfterF.Size = New System.Drawing.Size(76, 17)
        Me.rbInsertAfterF.TabIndex = 3
        Me.rbInsertAfterF.TabStop = True
        Me.rbInsertAfterF.Text = "Insert After"
        Me.rbInsertAfterF.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeF
        '
        Me.rbInsertBeforeF.AutoSize = True
        Me.rbInsertBeforeF.Location = New System.Drawing.Point(6, 71)
        Me.rbInsertBeforeF.Name = "rbInsertBeforeF"
        Me.rbInsertBeforeF.Size = New System.Drawing.Size(85, 17)
        Me.rbInsertBeforeF.TabIndex = 2
        Me.rbInsertBeforeF.TabStop = True
        Me.rbInsertBeforeF.Text = "Insert Before"
        Me.rbInsertBeforeF.UseVisualStyleBackColor = True
        '
        'rbReplaceThisF
        '
        Me.rbReplaceThisF.AutoSize = True
        Me.rbReplaceThisF.Location = New System.Drawing.Point(6, 45)
        Me.rbReplaceThisF.Name = "rbReplaceThisF"
        Me.rbReplaceThisF.Size = New System.Drawing.Size(88, 17)
        Me.rbReplaceThisF.TabIndex = 1
        Me.rbReplaceThisF.TabStop = True
        Me.rbReplaceThisF.Text = "Replace This"
        Me.rbReplaceThisF.UseVisualStyleBackColor = True
        '
        'rbReplaceWithF
        '
        Me.rbReplaceWithF.Location = New System.Drawing.Point(6, 16)
        Me.rbReplaceWithF.Name = "rbReplaceWithF"
        Me.rbReplaceWithF.Size = New System.Drawing.Size(90, 17)
        Me.rbReplaceWithF.TabIndex = 0
        Me.rbReplaceWithF.TabStop = True
        Me.rbReplaceWithF.Text = "Replace With"
        Me.rbReplaceWithF.UseVisualStyleBackColor = True
        '
        'TpExtension
        '
        Me.TpExtension.Controls.Add(Me.txtWithThisE)
        Me.TpExtension.Controls.Add(Me.cbCaseE)
        Me.TpExtension.Controls.Add(Me.txtRightCropNCharE)
        Me.TpExtension.Controls.Add(Me.lblWithThisE)
        Me.TpExtension.Controls.Add(Me.lblCaseE)
        Me.TpExtension.Controls.Add(Me.txtLeftCropNCharE)
        Me.TpExtension.Controls.Add(Me.txtInsertAfterE)
        Me.TpExtension.Controls.Add(Me.txtInsertBeforeE)
        Me.TpExtension.Controls.Add(Me.txtReplaceThisE)
        Me.TpExtension.Controls.Add(Me.txtReplaceWithE)
        Me.TpExtension.Controls.Add(Me.rbRightCropNCharE)
        Me.TpExtension.Controls.Add(Me.rbLeftCropNCharE)
        Me.TpExtension.Controls.Add(Me.rbInsertAfterE)
        Me.TpExtension.Controls.Add(Me.rbInsertBeforeE)
        Me.TpExtension.Controls.Add(Me.rbReplaceThisE)
        Me.TpExtension.Controls.Add(Me.rbReplaceWithE)
        Me.TpExtension.Location = New System.Drawing.Point(4, 22)
        Me.TpExtension.Name = "TpExtension"
        Me.TpExtension.Padding = New System.Windows.Forms.Padding(3)
        Me.TpExtension.Size = New System.Drawing.Size(818, 146)
        Me.TpExtension.TabIndex = 1
        Me.TpExtension.Text = "Extension"
        Me.TpExtension.UseVisualStyleBackColor = True
        '
        'txtWithThisE
        '
        Me.txtWithThisE.Location = New System.Drawing.Point(537, 44)
        Me.txtWithThisE.Name = "txtWithThisE"
        Me.txtWithThisE.ReadOnly = True
        Me.txtWithThisE.Size = New System.Drawing.Size(275, 20)
        Me.txtWithThisE.TabIndex = 31
        '
        'cbCaseE
        '
        Me.cbCaseE.FormattingEnabled = True
        Me.cbCaseE.Items.AddRange(New Object() {"lowercase", "UPPERCASE", "No Change"})
        Me.cbCaseE.Location = New System.Drawing.Point(537, 16)
        Me.cbCaseE.Name = "cbCaseE"
        Me.cbCaseE.Size = New System.Drawing.Size(271, 21)
        Me.cbCaseE.TabIndex = 30
        '
        'txtRightCropNCharE
        '
        Me.txtRightCropNCharE.Location = New System.Drawing.Point(575, 110)
        Me.txtRightCropNCharE.Name = "txtRightCropNCharE"
        Me.txtRightCropNCharE.ReadOnly = True
        Me.txtRightCropNCharE.Size = New System.Drawing.Size(237, 20)
        Me.txtRightCropNCharE.TabIndex = 29
        '
        'lblWithThisE
        '
        Me.lblWithThisE.AutoSize = True
        Me.lblWithThisE.Location = New System.Drawing.Point(462, 47)
        Me.lblWithThisE.Name = "lblWithThisE"
        Me.lblWithThisE.Size = New System.Drawing.Size(52, 13)
        Me.lblWithThisE.TabIndex = 28
        Me.lblWithThisE.Text = "With This"
        '
        'lblCaseE
        '
        Me.lblCaseE.AutoSize = True
        Me.lblCaseE.Location = New System.Drawing.Point(462, 20)
        Me.lblCaseE.Name = "lblCaseE"
        Me.lblCaseE.Size = New System.Drawing.Size(34, 13)
        Me.lblCaseE.TabIndex = 27
        Me.lblCaseE.Text = "Case:"
        '
        'txtLeftCropNCharE
        '
        Me.txtLeftCropNCharE.Location = New System.Drawing.Point(134, 110)
        Me.txtLeftCropNCharE.Name = "txtLeftCropNCharE"
        Me.txtLeftCropNCharE.ReadOnly = True
        Me.txtLeftCropNCharE.Size = New System.Drawing.Size(238, 20)
        Me.txtLeftCropNCharE.TabIndex = 26
        '
        'txtInsertAfterE
        '
        Me.txtInsertAfterE.Location = New System.Drawing.Point(537, 71)
        Me.txtInsertAfterE.Name = "txtInsertAfterE"
        Me.txtInsertAfterE.ReadOnly = True
        Me.txtInsertAfterE.Size = New System.Drawing.Size(275, 20)
        Me.txtInsertAfterE.TabIndex = 25
        '
        'txtInsertBeforeE
        '
        Me.txtInsertBeforeE.Location = New System.Drawing.Point(103, 68)
        Me.txtInsertBeforeE.Name = "txtInsertBeforeE"
        Me.txtInsertBeforeE.ReadOnly = True
        Me.txtInsertBeforeE.Size = New System.Drawing.Size(351, 20)
        Me.txtInsertBeforeE.TabIndex = 24
        '
        'txtReplaceThisE
        '
        Me.txtReplaceThisE.Location = New System.Drawing.Point(103, 42)
        Me.txtReplaceThisE.Name = "txtReplaceThisE"
        Me.txtReplaceThisE.ReadOnly = True
        Me.txtReplaceThisE.Size = New System.Drawing.Size(351, 20)
        Me.txtReplaceThisE.TabIndex = 23
        '
        'txtReplaceWithE
        '
        Me.txtReplaceWithE.Location = New System.Drawing.Point(103, 16)
        Me.txtReplaceWithE.Name = "txtReplaceWithE"
        Me.txtReplaceWithE.ReadOnly = True
        Me.txtReplaceWithE.Size = New System.Drawing.Size(351, 20)
        Me.txtReplaceWithE.TabIndex = 22
        '
        'rbRightCropNCharE
        '
        Me.rbRightCropNCharE.AutoSize = True
        Me.rbRightCropNCharE.Location = New System.Drawing.Point(460, 111)
        Me.rbRightCropNCharE.Name = "rbRightCropNCharE"
        Me.rbRightCropNCharE.Size = New System.Drawing.Size(109, 17)
        Me.rbRightCropNCharE.TabIndex = 21
        Me.rbRightCropNCharE.TabStop = True
        Me.rbRightCropNCharE.Text = "Right Crop n Char"
        Me.rbRightCropNCharE.UseVisualStyleBackColor = True
        '
        'rbLeftCropNCharE
        '
        Me.rbLeftCropNCharE.AutoSize = True
        Me.rbLeftCropNCharE.Location = New System.Drawing.Point(6, 111)
        Me.rbLeftCropNCharE.Name = "rbLeftCropNCharE"
        Me.rbLeftCropNCharE.Size = New System.Drawing.Size(102, 17)
        Me.rbLeftCropNCharE.TabIndex = 20
        Me.rbLeftCropNCharE.TabStop = True
        Me.rbLeftCropNCharE.Text = "Left Crop n Char"
        Me.rbLeftCropNCharE.UseVisualStyleBackColor = True
        '
        'rbInsertAfterE
        '
        Me.rbInsertAfterE.AutoSize = True
        Me.rbInsertAfterE.Location = New System.Drawing.Point(460, 71)
        Me.rbInsertAfterE.Name = "rbInsertAfterE"
        Me.rbInsertAfterE.Size = New System.Drawing.Size(76, 17)
        Me.rbInsertAfterE.TabIndex = 19
        Me.rbInsertAfterE.TabStop = True
        Me.rbInsertAfterE.Text = "Insert After"
        Me.rbInsertAfterE.UseVisualStyleBackColor = True
        '
        'rbInsertBeforeE
        '
        Me.rbInsertBeforeE.AutoSize = True
        Me.rbInsertBeforeE.Location = New System.Drawing.Point(6, 71)
        Me.rbInsertBeforeE.Name = "rbInsertBeforeE"
        Me.rbInsertBeforeE.Size = New System.Drawing.Size(85, 17)
        Me.rbInsertBeforeE.TabIndex = 18
        Me.rbInsertBeforeE.TabStop = True
        Me.rbInsertBeforeE.Text = "Insert Before"
        Me.rbInsertBeforeE.UseVisualStyleBackColor = True
        '
        'rbReplaceThisE
        '
        Me.rbReplaceThisE.AutoSize = True
        Me.rbReplaceThisE.Location = New System.Drawing.Point(6, 45)
        Me.rbReplaceThisE.Name = "rbReplaceThisE"
        Me.rbReplaceThisE.Size = New System.Drawing.Size(88, 17)
        Me.rbReplaceThisE.TabIndex = 17
        Me.rbReplaceThisE.TabStop = True
        Me.rbReplaceThisE.Text = "Replace This"
        Me.rbReplaceThisE.UseVisualStyleBackColor = True
        '
        'rbReplaceWithE
        '
        Me.rbReplaceWithE.Location = New System.Drawing.Point(6, 16)
        Me.rbReplaceWithE.Name = "rbReplaceWithE"
        Me.rbReplaceWithE.Size = New System.Drawing.Size(90, 17)
        Me.rbReplaceWithE.TabIndex = 16
        Me.rbReplaceWithE.TabStop = True
        Me.rbReplaceWithE.Text = "Replace With"
        Me.rbReplaceWithE.UseVisualStyleBackColor = True
        '
        'TpAutoNumber
        '
        Me.TpAutoNumber.Controls.Add(Me.gbWidth)
        Me.TpAutoNumber.Controls.Add(Me.gbPlace)
        Me.TpAutoNumber.Location = New System.Drawing.Point(4, 22)
        Me.TpAutoNumber.Name = "TpAutoNumber"
        Me.TpAutoNumber.Size = New System.Drawing.Size(818, 146)
        Me.TpAutoNumber.TabIndex = 2
        Me.TpAutoNumber.Text = "Autonumber"
        Me.TpAutoNumber.UseVisualStyleBackColor = True
        '
        'gbWidth
        '
        Me.gbWidth.Controls.Add(Me.nudIncrementBy)
        Me.gbWidth.Controls.Add(Me.nudStartWithNumber)
        Me.gbWidth.Controls.Add(Me.lblIncrementBy)
        Me.gbWidth.Controls.Add(Me.lblStartWithNumber)
        Me.gbWidth.Location = New System.Drawing.Point(329, 18)
        Me.gbWidth.Name = "gbWidth"
        Me.gbWidth.Size = New System.Drawing.Size(314, 100)
        Me.gbWidth.TabIndex = 1
        Me.gbWidth.TabStop = False
        Me.gbWidth.Text = "Width"
        '
        'nudIncrementBy
        '
        Me.nudIncrementBy.Location = New System.Drawing.Point(136, 58)
        Me.nudIncrementBy.Name = "nudIncrementBy"
        Me.nudIncrementBy.Size = New System.Drawing.Size(120, 20)
        Me.nudIncrementBy.TabIndex = 3
        Me.nudIncrementBy.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudStartWithNumber
        '
        Me.nudStartWithNumber.Location = New System.Drawing.Point(136, 30)
        Me.nudStartWithNumber.Name = "nudStartWithNumber"
        Me.nudStartWithNumber.Size = New System.Drawing.Size(120, 20)
        Me.nudStartWithNumber.TabIndex = 2
        Me.nudStartWithNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblIncrementBy
        '
        Me.lblIncrementBy.AutoSize = True
        Me.lblIncrementBy.Location = New System.Drawing.Point(31, 60)
        Me.lblIncrementBy.Name = "lblIncrementBy"
        Me.lblIncrementBy.Size = New System.Drawing.Size(69, 13)
        Me.lblIncrementBy.TabIndex = 1
        Me.lblIncrementBy.Text = "Increment By"
        '
        'lblStartWithNumber
        '
        Me.lblStartWithNumber.AutoSize = True
        Me.lblStartWithNumber.Location = New System.Drawing.Point(31, 32)
        Me.lblStartWithNumber.Name = "lblStartWithNumber"
        Me.lblStartWithNumber.Size = New System.Drawing.Size(94, 13)
        Me.lblStartWithNumber.TabIndex = 0
        Me.lblStartWithNumber.Text = "Start With Number"
        '
        'gbPlace
        '
        Me.gbPlace.Controls.Add(Me.rbBeforeFileName)
        Me.gbPlace.Controls.Add(Me.rbAfterFileName)
        Me.gbPlace.Location = New System.Drawing.Point(15, 18)
        Me.gbPlace.Name = "gbPlace"
        Me.gbPlace.Size = New System.Drawing.Size(308, 100)
        Me.gbPlace.TabIndex = 0
        Me.gbPlace.TabStop = False
        Me.gbPlace.Text = "Place"
        '
        'rbBeforeFileName
        '
        Me.rbBeforeFileName.AutoSize = True
        Me.rbBeforeFileName.Location = New System.Drawing.Point(48, 58)
        Me.rbBeforeFileName.Name = "rbBeforeFileName"
        Me.rbBeforeFileName.Size = New System.Drawing.Size(101, 17)
        Me.rbBeforeFileName.TabIndex = 1
        Me.rbBeforeFileName.TabStop = True
        Me.rbBeforeFileName.Text = "Before Filename"
        Me.rbBeforeFileName.UseVisualStyleBackColor = True
        '
        'rbAfterFileName
        '
        Me.rbAfterFileName.AutoSize = True
        Me.rbAfterFileName.Location = New System.Drawing.Point(48, 32)
        Me.rbAfterFileName.Name = "rbAfterFileName"
        Me.rbAfterFileName.Size = New System.Drawing.Size(92, 17)
        Me.rbAfterFileName.TabIndex = 0
        Me.rbAfterFileName.TabStop = True
        Me.rbAfterFileName.Text = "After Filename"
        Me.rbAfterFileName.UseVisualStyleBackColor = True
        '
        'BtnPreview
        '
        Me.BtnPreview.Location = New System.Drawing.Point(857, 399)
        Me.BtnPreview.Name = "BtnPreview"
        Me.BtnPreview.Size = New System.Drawing.Size(75, 23)
        Me.BtnPreview.TabIndex = 10
        Me.BtnPreview.Text = "Preview"
        Me.BtnPreview.UseVisualStyleBackColor = True
        '
        'BtnRename
        '
        Me.BtnRename.Location = New System.Drawing.Point(856, 429)
        Me.BtnRename.Name = "BtnRename"
        Me.BtnRename.Size = New System.Drawing.Size(75, 23)
        Me.BtnRename.TabIndex = 11
        Me.BtnRename.Text = "Rename"
        Me.BtnRename.UseVisualStyleBackColor = True
        '
        'BtnUndo
        '
        Me.BtnUndo.Location = New System.Drawing.Point(857, 459)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(75, 23)
        Me.BtnUndo.TabIndex = 12
        Me.BtnUndo.Text = "Undo"
        Me.BtnUndo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 561)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.BtnRename)
        Me.Controls.Add(Me.BtnPreview)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lvPreview)
        Me.Controls.Add(Me.lvOri)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblOri)
        Me.Controls.Add(Me.txtExt)
        Me.Controls.Add(Me.lblExt)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.lblPath)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mass Renamer "
        Me.TabControl1.ResumeLayout(False)
        Me.TpFilename.ResumeLayout(False)
        Me.TpFilename.PerformLayout()
        Me.TpExtension.ResumeLayout(False)
        Me.TpExtension.PerformLayout()
        Me.TpAutoNumber.ResumeLayout(False)
        Me.gbWidth.ResumeLayout(False)
        Me.gbWidth.PerformLayout()
        CType(Me.nudIncrementBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudStartWithNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPlace.ResumeLayout(False)
        Me.gbPlace.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents lblPath As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnPath As Button
    Friend WithEvents lblExt As Label
    Friend WithEvents txtExt As TextBox
    Friend WithEvents lblOri As Label
    Friend WithEvents lblPreview As Label
    Friend WithEvents lvOri As ListView
    Friend WithEvents chFileName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chAttribute As ColumnHeader
    Friend WithEvents chCreated As ColumnHeader
    Friend WithEvents chAccessed As ColumnHeader
    Friend WithEvents chModified As ColumnHeader
    Friend WithEvents lvPreview As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TpFilename As TabPage
    Friend WithEvents TpExtension As TabPage
    Friend WithEvents TpAutoNumber As TabPage
    Friend WithEvents BtnPreview As Button
    Friend WithEvents BtnRename As Button
    Friend WithEvents BtnUndo As Button
    Friend WithEvents rbReplaceWithF As RadioButton
    Friend WithEvents rbInsertBeforeF As RadioButton
    Friend WithEvents rbReplaceThisF As RadioButton
    Friend WithEvents rbLeftCropNCharF As RadioButton
    Friend WithEvents rbInsertAfterF As RadioButton
    Friend WithEvents txtWithThisF As TextBox
    Friend WithEvents cbCaseF As ComboBox
    Friend WithEvents txtRightCropNCharF As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCaseF As Label
    Friend WithEvents txtLeftCropNCharF As TextBox
    Friend WithEvents txtInsertAfterF As TextBox
    Friend WithEvents txtInsertBeforeF As TextBox
    Friend WithEvents txtReplaceThisF As TextBox
    Friend WithEvents txtReplaceWithF As TextBox
    Friend WithEvents rbRightCropNCharF As RadioButton
    Friend WithEvents txtWithThisE As TextBox
    Friend WithEvents cbCaseE As ComboBox
    Friend WithEvents txtRightCropNCharE As TextBox
    Friend WithEvents lblWithThisE As Label
    Friend WithEvents lblCaseE As Label
    Friend WithEvents txtLeftCropNCharE As TextBox
    Friend WithEvents txtInsertAfterE As TextBox
    Friend WithEvents txtInsertBeforeE As TextBox
    Friend WithEvents txtReplaceThisE As TextBox
    Friend WithEvents txtReplaceWithE As TextBox
    Friend WithEvents rbRightCropNCharE As RadioButton
    Friend WithEvents rbLeftCropNCharE As RadioButton
    Friend WithEvents rbInsertAfterE As RadioButton
    Friend WithEvents rbInsertBeforeE As RadioButton
    Friend WithEvents rbReplaceThisE As RadioButton
    Friend WithEvents rbReplaceWithE As RadioButton
    Friend WithEvents gbWidth As GroupBox
    Friend WithEvents nudIncrementBy As NumericUpDown
    Friend WithEvents nudStartWithNumber As NumericUpDown
    Friend WithEvents lblIncrementBy As Label
    Friend WithEvents lblStartWithNumber As Label
    Friend WithEvents gbPlace As GroupBox
    Friend WithEvents rbBeforeFileName As RadioButton
    Friend WithEvents rbAfterFileName As RadioButton
End Class
