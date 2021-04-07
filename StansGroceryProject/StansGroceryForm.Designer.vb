<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
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
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemNameLabel = New System.Windows.Forms.Label()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterByCategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.FilterByAisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ContextMenuStrip.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearchTextBox
        '
        Me.SearchTextBox.ContextMenuStrip = Me.ContextMenuStrip
        Me.SearchTextBox.Location = New System.Drawing.Point(137, 92)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(156, 20)
        Me.SearchTextBox.TabIndex = 0
        Me.MainToolTip.SetToolTip(Me.SearchTextBox, "Enter Item Name to Search (and press 'Search' Button)")
        '
        'ContextMenuStrip
        '
        Me.ContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip.Name = "ContextMenuStrip"
        Me.ContextMenuStrip.Size = New System.Drawing.Size(110, 48)
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.AutoSize = True
        Me.ItemNameLabel.Location = New System.Drawing.Point(18, 99)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(113, 13)
        Me.ItemNameLabel.TabIndex = 1
        Me.ItemNameLabel.Text = "Search By Item Name:"
        Me.MainToolTip.SetToolTip(Me.ItemNameLabel, "Label for item name")
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(312, 90)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Search"
        Me.MainToolTip.SetToolTip(Me.SearchButton, "Press to search what is in the textbox to the left")
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(266, 177)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FilterComboBox.TabIndex = 3
        Me.MainToolTip.SetToolTip(Me.FilterComboBox, "Drop Down to select which aisle/category you are filtering for")
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.Location = New System.Drawing.Point(430, 27)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(358, 329)
        Me.DisplayListBox.Sorted = True
        Me.DisplayListBox.TabIndex = 4
        Me.MainToolTip.SetToolTip(Me.DisplayListBox, "Items shown either by searching or filtering")
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(243, 402)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(99, 20)
        Me.DisplayLabel.TabIndex = 5
        Me.DisplayLabel.Text = "DisplayLabel"
        Me.MainToolTip.SetToolTip(Me.DisplayLabel, "Result Label on where to find the selected grocery item")
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.FilterByCategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.FilterByAisleRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(21, 127)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.FilterGroupBox.TabIndex = 6
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter Types"
        '
        'FilterByCategoryRadioButton
        '
        Me.FilterByCategoryRadioButton.AutoSize = True
        Me.FilterByCategoryRadioButton.Location = New System.Drawing.Point(32, 66)
        Me.FilterByCategoryRadioButton.Name = "FilterByCategoryRadioButton"
        Me.FilterByCategoryRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.FilterByCategoryRadioButton.TabIndex = 1
        Me.FilterByCategoryRadioButton.Text = "Filter By Category"
        Me.MainToolTip.SetToolTip(Me.FilterByCategoryRadioButton, "Filter Items By Category")
        Me.FilterByCategoryRadioButton.UseVisualStyleBackColor = True
        '
        'FilterByAisleRadioButton
        '
        Me.FilterByAisleRadioButton.AutoSize = True
        Me.FilterByAisleRadioButton.Checked = True
        Me.FilterByAisleRadioButton.Location = New System.Drawing.Point(32, 20)
        Me.FilterByAisleRadioButton.Name = "FilterByAisleRadioButton"
        Me.FilterByAisleRadioButton.Size = New System.Drawing.Size(87, 17)
        Me.FilterByAisleRadioButton.TabIndex = 0
        Me.FilterByAisleRadioButton.TabStop = True
        Me.FilterByAisleRadioButton.Text = "Filter By Aisle"
        Me.MainToolTip.SetToolTip(Me.FilterByAisleRadioButton, "Filter Items By Aisle")
        Me.FilterByAisleRadioButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(800, 24)
        Me.TopMenuStrip.TabIndex = 7
        Me.TopMenuStrip.Text = "TopMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SearchToolStripMenuItem1.Text = "&Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem1.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterComboBox)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.SearchTextBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "StansGroceryForm"
        Me.Text = "Stan's Grocery"
        Me.MainToolTip.SetToolTip(Me, "Form To Search For Groceries at Stan's")
        Me.ContextMenuStrip.ResumeLayout(False)
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents ItemNameLabel As Label
    Friend WithEvents SearchButton As Button
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents FilterByCategoryRadioButton As RadioButton
    Friend WithEvents FilterByAisleRadioButton As RadioButton
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents ContextMenuStrip As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
