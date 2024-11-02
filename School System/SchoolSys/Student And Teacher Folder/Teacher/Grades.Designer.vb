<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grades
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgGrade = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.cbSectionIdentifier = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.AutoRoundedCorners = True
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderRadius = 17
        Me.btnDelete.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.delete
        Me.btnDelete.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.delete
        Me.btnDelete.CustomImages.Image = Global.School_System.My.Resources.Resources.delete
        Me.btnDelete.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.Blue
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(1177, 646)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.BorderRadius = 17
        Me.btnDelete.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.Size = New System.Drawing.Size(104, 37)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.AutoRoundedCorners = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 17
        Me.btnSave.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.plus
        Me.btnSave.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.plus
        Me.btnSave.CustomImages.Image = Global.School_System.My.Resources.Resources.plus
        Me.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.White
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1079, 646)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 17
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.Size = New System.Drawing.Size(92, 37)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSave.TextOffset = New System.Drawing.Point(-2, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sunshine Tropical", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(466, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 31)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "GRADE REPORTS SECTION"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.dgGrade)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1275, 588)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fields"
        '
        'dgGrade
        '
        Me.dgGrade.AllowUserToAddRows = False
        Me.dgGrade.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgGrade.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGrade.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgGrade.ColumnHeadersHeight = 40
        Me.dgGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGrade.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgGrade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrade.GridColor = System.Drawing.Color.Black
        Me.dgGrade.Location = New System.Drawing.Point(3, 22)
        Me.dgGrade.Name = "dgGrade"
        Me.dgGrade.RowHeadersVisible = False
        Me.dgGrade.RowTemplate.Height = 30
        Me.dgGrade.Size = New System.Drawing.Size(1269, 563)
        Me.dgGrade.TabIndex = 1
        Me.dgGrade.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgGrade.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgGrade.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgGrade.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgGrade.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgGrade.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgGrade.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgGrade.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGrade.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgGrade.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGrade.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgGrade.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgGrade.ThemeStyle.HeaderStyle.Height = 40
        Me.dgGrade.ThemeStyle.ReadOnly = False
        Me.dgGrade.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgGrade.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgGrade.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGrade.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgGrade.ThemeStyle.RowsStyle.Height = 30
        Me.dgGrade.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgGrade.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'cbSectionIdentifier
        '
        Me.cbSectionIdentifier.AutoRoundedCorners = True
        Me.cbSectionIdentifier.BackColor = System.Drawing.Color.Transparent
        Me.cbSectionIdentifier.BorderColor = System.Drawing.Color.Blue
        Me.cbSectionIdentifier.BorderRadius = 14
        Me.cbSectionIdentifier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSectionIdentifier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSectionIdentifier.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSectionIdentifier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSectionIdentifier.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbSectionIdentifier.ForeColor = System.Drawing.Color.Black
        Me.cbSectionIdentifier.ItemHeight = 25
        Me.cbSectionIdentifier.Location = New System.Drawing.Point(144, 12)
        Me.cbSectionIdentifier.Name = "cbSectionIdentifier"
        Me.cbSectionIdentifier.Size = New System.Drawing.Size(214, 31)
        Me.cbSectionIdentifier.TabIndex = 1
        Me.cbSectionIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Section Identifier"
        '
        'Grades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1287, 695)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cbSectionIdentifier)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Grades"
        Me.Text = "Grades"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgGrade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgGrade As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents cbSectionIdentifier As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
End Class
