<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form2))
        Dim IDLabel As System.Windows.Forms.Label
        Dim BOOKIDLabel As System.Windows.Forms.Label
        Dim BOOKTITLELabel As System.Windows.Forms.Label
        Dim AUTHORLabel As System.Windows.Forms.Label
        Dim RRPLabel As System.Windows.Forms.Label
        Dim SELLINGPRICELabel As System.Windows.Forms.Label
        Dim TITLELabel As System.Windows.Forms.Label
        Dim FIRSTNAMELabel As System.Windows.Forms.Label
        Dim LASTNAMELabel As System.Windows.Forms.Label
        Dim ADDRESSLabel As System.Windows.Forms.Label
        Dim CUSTOMERIDLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim DATEBORROWEDLabel As System.Windows.Forms.Label
        Dim DATEDUEBACKLabel As System.Windows.Forms.Label
        Dim DATERETURNEDLabel As System.Windows.Forms.Label
        Dim LATERETURNFINELabel As System.Windows.Forms.Label
        Dim DATEOVERDUELabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.LIBRARYDBDataSet = New librarymanagementsystemsystem.LIBRARYDBDataSet()
        Me.LibraryTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LibraryTTableAdapter = New librarymanagementsystemsystem.LIBRARYDBDataSetTableAdapters.LibraryTTableAdapter()
        Me.TableAdapterManager = New librarymanagementsystemsystem.LIBRARYDBDataSetTableAdapters.TableAdapterManager()
        Me.LibraryTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.LibraryTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.BOOKIDTextBox = New System.Windows.Forms.TextBox()
        Me.BOOKTITLETextBox = New System.Windows.Forms.TextBox()
        Me.AUTHORTextBox = New System.Windows.Forms.TextBox()
        Me.RRPTextBox = New System.Windows.Forms.TextBox()
        Me.SELLINGPRICETextBox = New System.Windows.Forms.TextBox()
        Me.TITLETextBox = New System.Windows.Forms.TextBox()
        Me.FIRSTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.LASTNAMETextBox = New System.Windows.Forms.TextBox()
        Me.ADDRESSTextBox = New System.Windows.Forms.TextBox()
        Me.CUSTOMERIDTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.DATEBORROWEDTextBox = New System.Windows.Forms.TextBox()
        Me.DATEDUEBACKTextBox = New System.Windows.Forms.TextBox()
        Me.DATERETURNEDTextBox = New System.Windows.Forms.TextBox()
        Me.LATERETURNFINETextBox = New System.Windows.Forms.TextBox()
        Me.lbloverdue = New System.Windows.Forms.TextBox()
        Me.btndatereturned = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.btnborrowed = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.cmbsearch = New System.Windows.Forms.ComboBox()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        BOOKIDLabel = New System.Windows.Forms.Label()
        BOOKTITLELabel = New System.Windows.Forms.Label()
        AUTHORLabel = New System.Windows.Forms.Label()
        RRPLabel = New System.Windows.Forms.Label()
        SELLINGPRICELabel = New System.Windows.Forms.Label()
        TITLELabel = New System.Windows.Forms.Label()
        FIRSTNAMELabel = New System.Windows.Forms.Label()
        LASTNAMELabel = New System.Windows.Forms.Label()
        ADDRESSLabel = New System.Windows.Forms.Label()
        CUSTOMERIDLabel = New System.Windows.Forms.Label()
        DOBLabel = New System.Windows.Forms.Label()
        DATEBORROWEDLabel = New System.Windows.Forms.Label()
        DATEDUEBACKLabel = New System.Windows.Forms.Label()
        DATERETURNEDLabel = New System.Windows.Forms.Label()
        LATERETURNFINELabel = New System.Windows.Forms.Label()
        DATEOVERDUELabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.LIBRARYDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LibraryTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LibraryTBindingNavigator.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LIBRARYDBDataSet
        '
        Me.LIBRARYDBDataSet.DataSetName = "LIBRARYDBDataSet"
        Me.LIBRARYDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LibraryTBindingSource
        '
        Me.LibraryTBindingSource.DataMember = "LibraryT"
        Me.LibraryTBindingSource.DataSource = Me.LIBRARYDBDataSet
        '
        'LibraryTTableAdapter
        '
        Me.LibraryTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LibraryTTableAdapter = Me.LibraryTTableAdapter
        Me.TableAdapterManager.UpdateOrder = librarymanagementsystemsystem.LIBRARYDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LibraryTBindingNavigator
        '
        Me.LibraryTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.LibraryTBindingNavigator.BindingSource = Me.LibraryTBindingSource
        Me.LibraryTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.LibraryTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.LibraryTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.LibraryTBindingNavigatorSaveItem})
        Me.LibraryTBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.LibraryTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.LibraryTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.LibraryTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.LibraryTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.LibraryTBindingNavigator.Name = "LibraryTBindingNavigator"
        Me.LibraryTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.LibraryTBindingNavigator.Size = New System.Drawing.Size(1103, 25)
        Me.LibraryTBindingNavigator.TabIndex = 0
        Me.LibraryTBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'LibraryTBindingNavigatorSaveItem
        '
        Me.LibraryTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.LibraryTBindingNavigatorSaveItem.Image = CType(resources.GetObject("LibraryTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.LibraryTBindingNavigatorSaveItem.Name = "LibraryTBindingNavigatorSaveItem"
        Me.LibraryTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.LibraryTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(326, 179)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(31, 21)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(466, 173)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.IDTextBox.TabIndex = 2
        '
        'BOOKIDLabel
        '
        BOOKIDLabel.AutoSize = True
        BOOKIDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BOOKIDLabel.Location = New System.Drawing.Point(326, 224)
        BOOKIDLabel.Name = "BOOKIDLabel"
        BOOKIDLabel.Size = New System.Drawing.Size(75, 21)
        BOOKIDLabel.TabIndex = 3
        BOOKIDLabel.Text = "BOOKID:"
        '
        'BOOKIDTextBox
        '
        Me.BOOKIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "BOOKID", True))
        Me.BOOKIDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOOKIDTextBox.Location = New System.Drawing.Point(466, 218)
        Me.BOOKIDTextBox.Name = "BOOKIDTextBox"
        Me.BOOKIDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.BOOKIDTextBox.TabIndex = 4
        '
        'BOOKTITLELabel
        '
        BOOKTITLELabel.AutoSize = True
        BOOKTITLELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BOOKTITLELabel.Location = New System.Drawing.Point(326, 274)
        BOOKTITLELabel.Name = "BOOKTITLELabel"
        BOOKTITLELabel.Size = New System.Drawing.Size(98, 21)
        BOOKTITLELabel.TabIndex = 5
        BOOKTITLELabel.Text = "BOOKTITLE:"
        '
        'BOOKTITLETextBox
        '
        Me.BOOKTITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "BOOKTITLE", True))
        Me.BOOKTITLETextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BOOKTITLETextBox.Location = New System.Drawing.Point(466, 268)
        Me.BOOKTITLETextBox.Name = "BOOKTITLETextBox"
        Me.BOOKTITLETextBox.Size = New System.Drawing.Size(100, 29)
        Me.BOOKTITLETextBox.TabIndex = 6
        '
        'AUTHORLabel
        '
        AUTHORLabel.AutoSize = True
        AUTHORLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AUTHORLabel.Location = New System.Drawing.Point(326, 321)
        AUTHORLabel.Name = "AUTHORLabel"
        AUTHORLabel.Size = New System.Drawing.Size(80, 21)
        AUTHORLabel.TabIndex = 7
        AUTHORLabel.Text = "AUTHOR:"
        '
        'AUTHORTextBox
        '
        Me.AUTHORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "AUTHOR", True))
        Me.AUTHORTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AUTHORTextBox.Location = New System.Drawing.Point(466, 315)
        Me.AUTHORTextBox.Name = "AUTHORTextBox"
        Me.AUTHORTextBox.Size = New System.Drawing.Size(100, 29)
        Me.AUTHORTextBox.TabIndex = 8
        '
        'RRPLabel
        '
        RRPLabel.AutoSize = True
        RRPLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RRPLabel.Location = New System.Drawing.Point(326, 364)
        RRPLabel.Name = "RRPLabel"
        RRPLabel.Size = New System.Drawing.Size(44, 21)
        RRPLabel.TabIndex = 9
        RRPLabel.Text = "RRP:"
        '
        'RRPTextBox
        '
        Me.RRPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "RRP", True))
        Me.RRPTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RRPTextBox.Location = New System.Drawing.Point(466, 358)
        Me.RRPTextBox.Name = "RRPTextBox"
        Me.RRPTextBox.Size = New System.Drawing.Size(100, 29)
        Me.RRPTextBox.TabIndex = 10
        '
        'SELLINGPRICELabel
        '
        SELLINGPRICELabel.AutoSize = True
        SELLINGPRICELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SELLINGPRICELabel.Location = New System.Drawing.Point(326, 422)
        SELLINGPRICELabel.Name = "SELLINGPRICELabel"
        SELLINGPRICELabel.Size = New System.Drawing.Size(121, 21)
        SELLINGPRICELabel.TabIndex = 11
        SELLINGPRICELabel.Text = "SELLINGPRICE:"
        '
        'SELLINGPRICETextBox
        '
        Me.SELLINGPRICETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "SELLINGPRICE", True))
        Me.SELLINGPRICETextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SELLINGPRICETextBox.Location = New System.Drawing.Point(466, 414)
        Me.SELLINGPRICETextBox.Name = "SELLINGPRICETextBox"
        Me.SELLINGPRICETextBox.Size = New System.Drawing.Size(100, 29)
        Me.SELLINGPRICETextBox.TabIndex = 12
        '
        'TITLELabel
        '
        TITLELabel.AutoSize = True
        TITLELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TITLELabel.Location = New System.Drawing.Point(34, 232)
        TITLELabel.Name = "TITLELabel"
        TITLELabel.Size = New System.Drawing.Size(54, 21)
        TITLELabel.TabIndex = 13
        TITLELabel.Text = "TITLE:"
        '
        'TITLETextBox
        '
        Me.TITLETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "TITLE", True))
        Me.TITLETextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TITLETextBox.Location = New System.Drawing.Point(182, 229)
        Me.TITLETextBox.Name = "TITLETextBox"
        Me.TITLETextBox.Size = New System.Drawing.Size(100, 29)
        Me.TITLETextBox.TabIndex = 14
        '
        'FIRSTNAMELabel
        '
        FIRSTNAMELabel.AutoSize = True
        FIRSTNAMELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FIRSTNAMELabel.Location = New System.Drawing.Point(34, 274)
        FIRSTNAMELabel.Name = "FIRSTNAMELabel"
        FIRSTNAMELabel.Size = New System.Drawing.Size(103, 21)
        FIRSTNAMELabel.TabIndex = 15
        FIRSTNAMELabel.Text = "FIRSTNAME:"
        '
        'FIRSTNAMETextBox
        '
        Me.FIRSTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "FIRSTNAME", True))
        Me.FIRSTNAMETextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIRSTNAMETextBox.Location = New System.Drawing.Point(182, 271)
        Me.FIRSTNAMETextBox.Name = "FIRSTNAMETextBox"
        Me.FIRSTNAMETextBox.Size = New System.Drawing.Size(100, 29)
        Me.FIRSTNAMETextBox.TabIndex = 16
        '
        'LASTNAMELabel
        '
        LASTNAMELabel.AutoSize = True
        LASTNAMELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LASTNAMELabel.Location = New System.Drawing.Point(34, 317)
        LASTNAMELabel.Name = "LASTNAMELabel"
        LASTNAMELabel.Size = New System.Drawing.Size(99, 21)
        LASTNAMELabel.TabIndex = 17
        LASTNAMELabel.Text = "LASTNAME:"
        '
        'LASTNAMETextBox
        '
        Me.LASTNAMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "LASTNAME", True))
        Me.LASTNAMETextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LASTNAMETextBox.Location = New System.Drawing.Point(182, 314)
        Me.LASTNAMETextBox.Name = "LASTNAMETextBox"
        Me.LASTNAMETextBox.Size = New System.Drawing.Size(100, 29)
        Me.LASTNAMETextBox.TabIndex = 18
        '
        'ADDRESSLabel
        '
        ADDRESSLabel.AutoSize = True
        ADDRESSLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ADDRESSLabel.Location = New System.Drawing.Point(34, 364)
        ADDRESSLabel.Name = "ADDRESSLabel"
        ADDRESSLabel.Size = New System.Drawing.Size(86, 21)
        ADDRESSLabel.TabIndex = 19
        ADDRESSLabel.Text = "ADDRESS:"
        '
        'ADDRESSTextBox
        '
        Me.ADDRESSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "ADDRESS", True))
        Me.ADDRESSTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDRESSTextBox.Location = New System.Drawing.Point(182, 361)
        Me.ADDRESSTextBox.Name = "ADDRESSTextBox"
        Me.ADDRESSTextBox.Size = New System.Drawing.Size(100, 29)
        Me.ADDRESSTextBox.TabIndex = 20
        '
        'CUSTOMERIDLabel
        '
        CUSTOMERIDLabel.AutoSize = True
        CUSTOMERIDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CUSTOMERIDLabel.Location = New System.Drawing.Point(34, 187)
        CUSTOMERIDLabel.Name = "CUSTOMERIDLabel"
        CUSTOMERIDLabel.Size = New System.Drawing.Size(116, 21)
        CUSTOMERIDLabel.TabIndex = 21
        CUSTOMERIDLabel.Text = "CUSTOMERID:"
        '
        'CUSTOMERIDTextBox
        '
        Me.CUSTOMERIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "CUSTOMERID", True))
        Me.CUSTOMERIDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUSTOMERIDTextBox.Location = New System.Drawing.Point(182, 184)
        Me.CUSTOMERIDTextBox.Name = "CUSTOMERIDTextBox"
        Me.CUSTOMERIDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.CUSTOMERIDTextBox.TabIndex = 22
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DOBLabel.Location = New System.Drawing.Point(34, 417)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(48, 21)
        DOBLabel.TabIndex = 23
        DOBLabel.Text = "DOB:"
        '
        'DOBTextBox
        '
        Me.DOBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "DOB", True))
        Me.DOBTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOBTextBox.Location = New System.Drawing.Point(182, 414)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(100, 29)
        Me.DOBTextBox.TabIndex = 24
        '
        'DATEBORROWEDLabel
        '
        DATEBORROWEDLabel.AutoSize = True
        DATEBORROWEDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATEBORROWEDLabel.Location = New System.Drawing.Point(603, 174)
        DATEBORROWEDLabel.Name = "DATEBORROWEDLabel"
        DATEBORROWEDLabel.Size = New System.Drawing.Size(145, 21)
        DATEBORROWEDLabel.TabIndex = 25
        DATEBORROWEDLabel.Text = "DATEBORROWED:"
        '
        'DATEBORROWEDTextBox
        '
        Me.DATEBORROWEDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "DATEBORROWED", True))
        Me.DATEBORROWEDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATEBORROWEDTextBox.Location = New System.Drawing.Point(788, 169)
        Me.DATEBORROWEDTextBox.Name = "DATEBORROWEDTextBox"
        Me.DATEBORROWEDTextBox.Size = New System.Drawing.Size(121, 29)
        Me.DATEBORROWEDTextBox.TabIndex = 26
        '
        'DATEDUEBACKLabel
        '
        DATEDUEBACKLabel.AutoSize = True
        DATEDUEBACKLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATEDUEBACKLabel.Location = New System.Drawing.Point(602, 222)
        DATEDUEBACKLabel.Name = "DATEDUEBACKLabel"
        DATEDUEBACKLabel.Size = New System.Drawing.Size(128, 21)
        DATEDUEBACKLabel.TabIndex = 27
        DATEDUEBACKLabel.Text = "DATEDUEBACK:"
        '
        'DATEDUEBACKTextBox
        '
        Me.DATEDUEBACKTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "DATEDUEBACK", True))
        Me.DATEDUEBACKTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATEDUEBACKTextBox.Location = New System.Drawing.Point(788, 214)
        Me.DATEDUEBACKTextBox.Name = "DATEDUEBACKTextBox"
        Me.DATEDUEBACKTextBox.Size = New System.Drawing.Size(121, 29)
        Me.DATEDUEBACKTextBox.TabIndex = 28
        '
        'DATERETURNEDLabel
        '
        DATERETURNEDLabel.AutoSize = True
        DATERETURNEDLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATERETURNEDLabel.Location = New System.Drawing.Point(602, 269)
        DATERETURNEDLabel.Name = "DATERETURNEDLabel"
        DATERETURNEDLabel.Size = New System.Drawing.Size(138, 21)
        DATERETURNEDLabel.TabIndex = 29
        DATERETURNEDLabel.Text = "DATERETURNED:"
        '
        'DATERETURNEDTextBox
        '
        Me.DATERETURNEDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "DATERETURNED", True))
        Me.DATERETURNEDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATERETURNEDTextBox.Location = New System.Drawing.Point(788, 266)
        Me.DATERETURNEDTextBox.Name = "DATERETURNEDTextBox"
        Me.DATERETURNEDTextBox.Size = New System.Drawing.Size(121, 29)
        Me.DATERETURNEDTextBox.TabIndex = 30
        '
        'LATERETURNFINELabel
        '
        LATERETURNFINELabel.AutoSize = True
        LATERETURNFINELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LATERETURNFINELabel.Location = New System.Drawing.Point(599, 322)
        LATERETURNFINELabel.Name = "LATERETURNFINELabel"
        LATERETURNFINELabel.Size = New System.Drawing.Size(148, 21)
        LATERETURNFINELabel.TabIndex = 31
        LATERETURNFINELabel.Text = "LATERETURNFINE:"
        '
        'LATERETURNFINETextBox
        '
        Me.LATERETURNFINETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "LATERETURNFINE", True))
        Me.LATERETURNFINETextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LATERETURNFINETextBox.Location = New System.Drawing.Point(788, 319)
        Me.LATERETURNFINETextBox.Name = "LATERETURNFINETextBox"
        Me.LATERETURNFINETextBox.Size = New System.Drawing.Size(121, 29)
        Me.LATERETURNFINETextBox.TabIndex = 32
        '
        'DATEOVERDUELabel
        '
        DATEOVERDUELabel.AutoSize = True
        DATEOVERDUELabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DATEOVERDUELabel.Location = New System.Drawing.Point(603, 364)
        DATEOVERDUELabel.Name = "DATEOVERDUELabel"
        DATEOVERDUELabel.Size = New System.Drawing.Size(129, 21)
        DATEOVERDUELabel.TabIndex = 33
        DATEOVERDUELabel.Text = "DATEOVERDUE:"
        '
        'lbloverdue
        '
        Me.lbloverdue.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LibraryTBindingSource, "DATEOVERDUE", True))
        Me.lbloverdue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloverdue.Location = New System.Drawing.Point(788, 364)
        Me.lbloverdue.Name = "lbloverdue"
        Me.lbloverdue.Size = New System.Drawing.Size(121, 29)
        Me.lbloverdue.TabIndex = 34
        '
        'btndatereturned
        '
        Me.btndatereturned.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndatereturned.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndatereturned.Location = New System.Drawing.Point(747, 449)
        Me.btndatereturned.Name = "btndatereturned"
        Me.btndatereturned.Size = New System.Drawing.Size(180, 32)
        Me.btndatereturned.TabIndex = 42
        Me.btndatereturned.Text = "DATE RETURNED"
        Me.btndatereturned.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(609, 412)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(127, 33)
        Me.NumericUpDown1.TabIndex = 41
        '
        'btnborrowed
        '
        Me.btnborrowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrowed.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrowed.Location = New System.Drawing.Point(772, 412)
        Me.btnborrowed.Name = "btnborrowed"
        Me.btnborrowed.Size = New System.Drawing.Size(137, 30)
        Me.btnborrowed.TabIndex = 40
        Me.btnborrowed.Text = "BORROWED"
        Me.btnborrowed.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.LibraryTBindingSource
        Me.ListBox1.DisplayMember = "BOOKTITLE"
        Me.ListBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(929, 174)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(154, 214)
        Me.ListBox1.TabIndex = 43
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Label4.Font = New System.Drawing.Font("Segoe UI", 50.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Label4.Location = New System.Drawing.Point(3, 57)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(1088, 89)
        Label4.TabIndex = 44
        Label4.Text = "LIBRARY MANAGEMENT SYSTEM"
        '
        'btnsearch
        '
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(953, 19)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(103, 30)
        Me.btnsearch.TabIndex = 47
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'cmbsearch
        '
        Me.cmbsearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsearch.FormattingEnabled = True
        Me.cmbsearch.Location = New System.Drawing.Point(826, 17)
        Me.cmbsearch.Name = "cmbsearch"
        Me.cmbsearch.Size = New System.Drawing.Size(121, 33)
        Me.cmbsearch.TabIndex = 46
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(677, 17)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(143, 33)
        Me.txtsearch.TabIndex = 45
        '
        'form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 619)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.cmbsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btndatereturned)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnborrowed)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(BOOKIDLabel)
        Me.Controls.Add(Me.BOOKIDTextBox)
        Me.Controls.Add(BOOKTITLELabel)
        Me.Controls.Add(Me.BOOKTITLETextBox)
        Me.Controls.Add(AUTHORLabel)
        Me.Controls.Add(Me.AUTHORTextBox)
        Me.Controls.Add(RRPLabel)
        Me.Controls.Add(Me.RRPTextBox)
        Me.Controls.Add(SELLINGPRICELabel)
        Me.Controls.Add(Me.SELLINGPRICETextBox)
        Me.Controls.Add(TITLELabel)
        Me.Controls.Add(Me.TITLETextBox)
        Me.Controls.Add(FIRSTNAMELabel)
        Me.Controls.Add(Me.FIRSTNAMETextBox)
        Me.Controls.Add(LASTNAMELabel)
        Me.Controls.Add(Me.LASTNAMETextBox)
        Me.Controls.Add(ADDRESSLabel)
        Me.Controls.Add(Me.ADDRESSTextBox)
        Me.Controls.Add(CUSTOMERIDLabel)
        Me.Controls.Add(Me.CUSTOMERIDTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(DATEBORROWEDLabel)
        Me.Controls.Add(Me.DATEBORROWEDTextBox)
        Me.Controls.Add(DATEDUEBACKLabel)
        Me.Controls.Add(Me.DATEDUEBACKTextBox)
        Me.Controls.Add(DATERETURNEDLabel)
        Me.Controls.Add(Me.DATERETURNEDTextBox)
        Me.Controls.Add(LATERETURNFINELabel)
        Me.Controls.Add(Me.LATERETURNFINETextBox)
        Me.Controls.Add(DATEOVERDUELabel)
        Me.Controls.Add(Me.lbloverdue)
        Me.Controls.Add(Me.LibraryTBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form2"
        CType(Me.LIBRARYDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LibraryTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LibraryTBindingNavigator.ResumeLayout(False)
        Me.LibraryTBindingNavigator.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LIBRARYDBDataSet As librarymanagementsystemsystem.LIBRARYDBDataSet
    Friend WithEvents LibraryTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LibraryTTableAdapter As librarymanagementsystemsystem.LIBRARYDBDataSetTableAdapters.LibraryTTableAdapter
    Friend WithEvents TableAdapterManager As librarymanagementsystemsystem.LIBRARYDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LibraryTBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LibraryTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BOOKIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BOOKTITLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents AUTHORTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RRPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SELLINGPRICETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TITLETextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIRSTNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents LASTNAMETextBox As System.Windows.Forms.TextBox
    Friend WithEvents ADDRESSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CUSTOMERIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATEBORROWEDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATEDUEBACKTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DATERETURNEDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LATERETURNFINETextBox As System.Windows.Forms.TextBox
    Friend WithEvents lbloverdue As System.Windows.Forms.TextBox
    Friend WithEvents btndatereturned As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnborrowed As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents cmbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
End Class
