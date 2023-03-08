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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tvDrive = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.lvMp3 = New System.Windows.Forms.ListView()
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chExtension = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chFileSize = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastModified = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chLastAccessed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCreatedDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAttributes = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtAlbum = New System.Windows.Forms.TextBox()
        Me.txtArtist = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtTrack = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblAlbum = New System.Windows.Forms.Label()
        Me.lblArtist = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTrack = New System.Windows.Forms.Label()
        Me.lblMp3Editor = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblPlaying = New System.Windows.Forms.Label()
        Me.lblTextDuration = New System.Windows.Forms.Label()
        Me.lblTextPlaying = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvDrive
        '
        Me.tvDrive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvDrive.ImageIndex = 0
        Me.tvDrive.ImageList = Me.ImageList1
        Me.tvDrive.Location = New System.Drawing.Point(0, 0)
        Me.tvDrive.Name = "tvDrive"
        Me.tvDrive.SelectedImageIndex = 0
        Me.tvDrive.Size = New System.Drawing.Size(266, 450)
        Me.tvDrive.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "drive.png")
        Me.ImageList1.Images.SetKeyName(1, "folder.png")
        '
        'lvMp3
        '
        Me.lvMp3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chName, Me.chExtension, Me.chFileSize, Me.chLastModified, Me.chLastAccessed, Me.chCreatedDate, Me.chAttributes})
        Me.lvMp3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvMp3.GridLines = True
        Me.lvMp3.HideSelection = False
        Me.lvMp3.Location = New System.Drawing.Point(0, 0)
        Me.lvMp3.Name = "lvMp3"
        Me.lvMp3.Size = New System.Drawing.Size(530, 225)
        Me.lvMp3.SmallImageList = Me.ImageList1
        Me.lvMp3.TabIndex = 1
        Me.lvMp3.UseCompatibleStateImageBehavior = False
        Me.lvMp3.View = System.Windows.Forms.View.Details
        '
        'chName
        '
        Me.chName.Text = "Name"
        '
        'chExtension
        '
        Me.chExtension.Text = "Extension"
        '
        'chFileSize
        '
        Me.chFileSize.Text = "File Size"
        '
        'chLastModified
        '
        Me.chLastModified.Text = "Last Modified"
        '
        'chLastAccessed
        '
        Me.chLastAccessed.Text = "Last Accessed"
        '
        'chCreatedDate
        '
        Me.chCreatedDate.Text = "Created Date"
        '
        'chAttributes
        '
        Me.chAttributes.Text = "Attributes"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tvDrive)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 2
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvMp3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(530, 450)
        Me.SplitContainer2.SplitterDistance = 225
        Me.SplitContainer2.TabIndex = 2
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer3.Panel1.Controls.Add(Me.btnEdit)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtYear)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtAlbum)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtArtist)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtTitle)
        Me.SplitContainer3.Panel1.Controls.Add(Me.txtTrack)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblYear)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblAlbum)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblArtist)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblTitle)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblTrack)
        Me.SplitContainer3.Panel1.Controls.Add(Me.lblMp3Editor)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Size = New System.Drawing.Size(530, 221)
        Me.SplitContainer3.SplitterDistance = 343
        Me.SplitContainer3.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(217, 172)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(81, 157)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(63, 20)
        Me.txtYear.TabIndex = 10
        '
        'txtAlbum
        '
        Me.txtAlbum.Location = New System.Drawing.Point(81, 125)
        Me.txtAlbum.Name = "txtAlbum"
        Me.txtAlbum.Size = New System.Drawing.Size(232, 20)
        Me.txtAlbum.TabIndex = 9
        '
        'txtArtist
        '
        Me.txtArtist.Location = New System.Drawing.Point(81, 93)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.Size = New System.Drawing.Size(232, 20)
        Me.txtArtist.TabIndex = 8
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(81, 61)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(232, 20)
        Me.txtTitle.TabIndex = 7
        '
        'txtTrack
        '
        Me.txtTrack.Location = New System.Drawing.Point(82, 29)
        Me.txtTrack.Name = "txtTrack"
        Me.txtTrack.Size = New System.Drawing.Size(46, 20)
        Me.txtTrack.TabIndex = 6
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(36, 160)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(32, 13)
        Me.lblYear.TabIndex = 5
        Me.lblYear.Text = "Year:"
        '
        'lblAlbum
        '
        Me.lblAlbum.AutoSize = True
        Me.lblAlbum.Location = New System.Drawing.Point(36, 128)
        Me.lblAlbum.Name = "lblAlbum"
        Me.lblAlbum.Size = New System.Drawing.Size(39, 13)
        Me.lblAlbum.TabIndex = 4
        Me.lblAlbum.Text = "Album:"
        '
        'lblArtist
        '
        Me.lblArtist.AutoSize = True
        Me.lblArtist.Location = New System.Drawing.Point(36, 96)
        Me.lblArtist.Name = "lblArtist"
        Me.lblArtist.Size = New System.Drawing.Size(33, 13)
        Me.lblArtist.TabIndex = 3
        Me.lblArtist.Text = "Artist:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(36, 64)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title:"
        '
        'lblTrack
        '
        Me.lblTrack.AutoSize = True
        Me.lblTrack.Location = New System.Drawing.Point(36, 32)
        Me.lblTrack.Name = "lblTrack"
        Me.lblTrack.Size = New System.Drawing.Size(38, 13)
        Me.lblTrack.TabIndex = 1
        Me.lblTrack.Text = "Track:"
        '
        'lblMp3Editor
        '
        Me.lblMp3Editor.AutoSize = True
        Me.lblMp3Editor.Location = New System.Drawing.Point(3, -1)
        Me.lblMp3Editor.Name = "lblMp3Editor"
        Me.lblMp3Editor.Size = New System.Drawing.Size(79, 13)
        Me.lblMp3Editor.TabIndex = 0
        Me.lblMp3Editor.Text = "MP3 ID3 Editor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.GroupBox1.Controls.Add(Me.btnStop)
        Me.GroupBox1.Controls.Add(Me.btnPlay)
        Me.GroupBox1.Controls.Add(Me.lblDuration)
        Me.GroupBox1.Controls.Add(Me.lblPlaying)
        Me.GroupBox1.Controls.Add(Me.lblTextDuration)
        Me.GroupBox1.Controls.Add(Me.lblTextPlaying)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 221)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(124, 99)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(47, 23)
        Me.btnStop.TabIndex = 5
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(38, 99)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(47, 23)
        Me.btnPlay.TabIndex = 4
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Location = New System.Drawing.Point(121, 65)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(34, 13)
        Me.lblDuration.TabIndex = 3
        Me.lblDuration.Text = "00:00"
        '
        'lblPlaying
        '
        Me.lblPlaying.AutoSize = True
        Me.lblPlaying.Location = New System.Drawing.Point(121, 33)
        Me.lblPlaying.Name = "lblPlaying"
        Me.lblPlaying.Size = New System.Drawing.Size(34, 13)
        Me.lblPlaying.TabIndex = 2
        Me.lblPlaying.Text = "00:00"
        '
        'lblTextDuration
        '
        Me.lblTextDuration.AutoSize = True
        Me.lblTextDuration.Location = New System.Drawing.Point(35, 65)
        Me.lblTextDuration.Name = "lblTextDuration"
        Me.lblTextDuration.Size = New System.Drawing.Size(50, 13)
        Me.lblTextDuration.TabIndex = 1
        Me.lblTextDuration.Text = "Duration:"
        '
        'lblTextPlaying
        '
        Me.lblTextPlaying.AutoSize = True
        Me.lblTextPlaying.Location = New System.Drawing.Point(35, 33)
        Me.lblTextPlaying.Name = "lblTextPlaying"
        Me.lblTextPlaying.Size = New System.Drawing.Size(44, 13)
        Me.lblTextPlaying.TabIndex = 0
        Me.lblTextPlaying.Text = "Playing:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(26, 144)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(145, 65)
        Me.AxWindowsMediaPlayer1.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MP3TagEditor"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel1.PerformLayout()
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvDrive As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents lvMp3 As ListView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents chName As ColumnHeader
    Friend WithEvents chExtension As ColumnHeader
    Friend WithEvents chFileSize As ColumnHeader
    Friend WithEvents chLastModified As ColumnHeader
    Friend WithEvents chLastAccessed As ColumnHeader
    Friend WithEvents chCreatedDate As ColumnHeader
    Friend WithEvents chAttributes As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblPlaying As Label
    Friend WithEvents lblTextDuration As Label
    Friend WithEvents lblTextPlaying As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtAlbum As TextBox
    Friend WithEvents txtArtist As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtTrack As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents lblAlbum As Label
    Friend WithEvents lblArtist As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTrack As Label
    Friend WithEvents lblMp3Editor As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
