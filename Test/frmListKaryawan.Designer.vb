<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListKaryawan
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.btn_add = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_edit = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_del = New DevExpress.XtraBars.BarButtonItem()
        Me.btn_refresh = New DevExpress.XtraBars.BarButtonItem()
        Me.mnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.cmdPrintInv = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdPrintSO = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdBatal = New DevExpress.XtraBars.BarButtonItem()
        Me.cmdBayar = New DevExpress.XtraBars.BarButtonItem()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsia2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsia1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNmKar2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNmKar1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtTglKerjaIn1 = New DevExpress.XtraEditors.DateEdit()
        Me.dtTglKerjaIn2 = New DevExpress.XtraEditors.DateEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTglMasuk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUsia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtUsia2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsia1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNmKar2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNmKar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTglKerjaIn1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTglKerjaIn1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTglKerjaIn2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtTglKerjaIn2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_add, Me.btn_edit, Me.btn_del, Me.btn_refresh, Me.mnClose, Me.cmdPrintInv, Me.cmdPrintSO, Me.cmdBatal, Me.cmdBayar})
        Me.BarManager1.MaxItemId = 9
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar2
        '
        Me.Bar2.BarName = "Tools"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btn_add), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_edit), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_del), New DevExpress.XtraBars.LinkPersistInfo(Me.btn_refresh), New DevExpress.XtraBars.LinkPersistInfo(Me.mnClose)})
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Tools"
        '
        'btn_add
        '
        Me.btn_add.Caption = "Add"
        Me.btn_add.Id = 0
        Me.btn_add.Name = "btn_add"
        Me.btn_add.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_edit
        '
        Me.btn_edit.Caption = "Edit"
        Me.btn_edit.Id = 1
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_del
        '
        Me.btn_del.Caption = "Delete"
        Me.btn_del.Id = 2
        Me.btn_del.Name = "btn_del"
        Me.btn_del.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'btn_refresh
        '
        Me.btn_refresh.Caption = "Refresh"
        Me.btn_refresh.Id = 3
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'mnClose
        '
        Me.mnClose.Caption = "Close"
        Me.mnClose.Id = 4
        Me.mnClose.Name = "mnClose"
        Me.mnClose.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1100, 45)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 423)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1100, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 45)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 378)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1100, 45)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 378)
        '
        'cmdPrintInv
        '
        Me.cmdPrintInv.Caption = "Cetak Faktur"
        Me.cmdPrintInv.Id = 5
        Me.cmdPrintInv.Name = "cmdPrintInv"
        '
        'cmdPrintSO
        '
        Me.cmdPrintSO.Caption = "Cetak SO"
        Me.cmdPrintSO.Id = 6
        Me.cmdPrintSO.Name = "cmdPrintSO"
        '
        'cmdBatal
        '
        Me.cmdBatal.Caption = "Batal"
        Me.cmdBatal.Id = 7
        Me.cmdBatal.Name = "cmdBatal"
        '
        'cmdBayar
        '
        Me.cmdBayar.Caption = "Bayar"
        Me.cmdBayar.Id = 8
        Me.cmdBayar.Name = "cmdBayar"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.PanelControl1)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 45)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1100, 378)
        Me.LayoutControl1.TabIndex = 4
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelControl1.Controls.Add(Me.SimpleButton2)
        Me.PanelControl1.Controls.Add(Me.SimpleButton1)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtUsia2)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtUsia1)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtNmKar2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtNmKar1)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.dtTglKerjaIn1)
        Me.PanelControl1.Controls.Add(Me.dtTglKerjaIn2)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1076, 159)
        Me.PanelControl1.TabIndex = 5
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(731, 43)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(207, 34)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "Search"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(435, 111)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "s.d."
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(43, 111)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(113, 19)
        Me.LabelControl6.TabIndex = 10
        Me.LabelControl6.Text = "Tgl Masuk Kerja"
        '
        'txtUsia2
        '
        Me.txtUsia2.Location = New System.Drawing.Point(478, 77)
        Me.txtUsia2.MenuManager = Me.BarManager1
        Me.txtUsia2.Name = "txtUsia2"
        Me.txtUsia2.Size = New System.Drawing.Size(226, 28)
        Me.txtUsia2.TabIndex = 9
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(435, 77)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "s.d."
        '
        'txtUsia1
        '
        Me.txtUsia1.Location = New System.Drawing.Point(193, 77)
        Me.txtUsia1.MenuManager = Me.BarManager1
        Me.txtUsia1.Name = "txtUsia1"
        Me.txtUsia1.Size = New System.Drawing.Size(226, 28)
        Me.txtUsia1.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(43, 77)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 19)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Usia"
        '
        'txtNmKar2
        '
        Me.txtNmKar2.Location = New System.Drawing.Point(478, 43)
        Me.txtNmKar2.MenuManager = Me.BarManager1
        Me.txtNmKar2.Name = "txtNmKar2"
        Me.txtNmKar2.Size = New System.Drawing.Size(226, 28)
        Me.txtNmKar2.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(435, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(26, 19)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "s.d."
        '
        'txtNmKar1
        '
        Me.txtNmKar1.Location = New System.Drawing.Point(193, 43)
        Me.txtNmKar1.MenuManager = Me.BarManager1
        Me.txtNmKar1.Name = "txtNmKar1"
        Me.txtNmKar1.Size = New System.Drawing.Size(226, 28)
        Me.txtNmKar1.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(43, 43)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(114, 19)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Nama Karyawan"
        '
        'dtTglKerjaIn1
        '
        Me.dtTglKerjaIn1.EditValue = Nothing
        Me.dtTglKerjaIn1.Location = New System.Drawing.Point(193, 111)
        Me.dtTglKerjaIn1.MenuManager = Me.BarManager1
        Me.dtTglKerjaIn1.Name = "dtTglKerjaIn1"
        Me.dtTglKerjaIn1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTglKerjaIn1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTglKerjaIn1.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtTglKerjaIn1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTglKerjaIn1.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtTglKerjaIn1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTglKerjaIn1.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtTglKerjaIn1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtTglKerjaIn1.Size = New System.Drawing.Size(226, 28)
        Me.dtTglKerjaIn1.TabIndex = 11
        '
        'dtTglKerjaIn2
        '
        Me.dtTglKerjaIn2.EditValue = Nothing
        Me.dtTglKerjaIn2.Location = New System.Drawing.Point(478, 111)
        Me.dtTglKerjaIn2.MenuManager = Me.BarManager1
        Me.dtTglKerjaIn2.Name = "dtTglKerjaIn2"
        Me.dtTglKerjaIn2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTglKerjaIn2.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtTglKerjaIn2.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dtTglKerjaIn2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTglKerjaIn2.Properties.EditFormat.FormatString = "MM/dd/yyyy"
        Me.dtTglKerjaIn2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtTglKerjaIn2.Properties.Mask.EditMask = "MM/dd/yyyy"
        Me.dtTglKerjaIn2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.dtTglKerjaIn2.Size = New System.Drawing.Size(226, 28)
        Me.dtTglKerjaIn2.TabIndex = 13
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 175)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.BarManager1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1076, 191)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNama, Me.colTglMasuk, Me.colUsia})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.Caption = "ID"
        Me.colId.FieldName = "idKaryawan"
        Me.colId.MinWidth = 30
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowEdit = False
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 67
        '
        'colNama
        '
        Me.colNama.Caption = "Nama Karyawan"
        Me.colNama.FieldName = "NmKaryawan"
        Me.colNama.MinWidth = 30
        Me.colNama.Name = "colNama"
        Me.colNama.OptionsColumn.AllowEdit = False
        Me.colNama.Visible = True
        Me.colNama.VisibleIndex = 1
        Me.colNama.Width = 253
        '
        'colTglMasuk
        '
        Me.colTglMasuk.Caption = "Tanggal Masuk Kerja"
        Me.colTglMasuk.FieldName = "TglMasukKerja"
        Me.colTglMasuk.MinWidth = 30
        Me.colTglMasuk.Name = "colTglMasuk"
        Me.colTglMasuk.OptionsColumn.AllowEdit = False
        Me.colTglMasuk.Visible = True
        Me.colTglMasuk.VisibleIndex = 2
        Me.colTglMasuk.Width = 212
        '
        'colUsia
        '
        Me.colUsia.Caption = "Usia"
        Me.colUsia.FieldName = "Usia"
        Me.colUsia.MinWidth = 30
        Me.colUsia.Name = "colUsia"
        Me.colUsia.OptionsColumn.AllowEdit = False
        Me.colUsia.Visible = True
        Me.colUsia.VisibleIndex = 3
        Me.colUsia.Width = 201
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1100, 378)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 163)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1080, 195)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.PanelControl1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(1080, 163)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(1080, 163)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1080, 163)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(731, 83)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(207, 34)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Show All"
        '
        'frmListKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 448)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmListKaryawan"
        Me.Text = "Daftar Karyawan"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtUsia2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsia1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNmKar2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNmKar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTglKerjaIn1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTglKerjaIn1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTglKerjaIn2.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtTglKerjaIn2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btn_add As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_del As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btn_refresh As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTglMasuk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUsia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents cmdPrintInv As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdPrintSO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdBatal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdBayar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsia2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsia1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNmKar2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNmKar1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtTglKerjaIn1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtTglKerjaIn2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
