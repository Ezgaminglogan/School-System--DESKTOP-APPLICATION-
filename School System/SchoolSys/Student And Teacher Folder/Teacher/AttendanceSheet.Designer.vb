<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AttendanceSheet
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnInsertDate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.cbSectionIdentifier = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgTables = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Blue
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Sunshine Tropical", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1287, 695)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "ATTENDANCE"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2GroupBox1.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.btnInsertDate)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.DatePicker)
        Me.Guna2Panel1.Controls.Add(Me.btnSave)
        Me.Guna2Panel1.Controls.Add(Me.cbSectionIdentifier)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.dgTables)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 40)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1287, 655)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnInsertDate
        '
        Me.btnInsertDate.Animated = True
        Me.btnInsertDate.AutoRoundedCorners = True
        Me.btnInsertDate.BackColor = System.Drawing.Color.Transparent
        Me.btnInsertDate.BorderRadius = 20
        Me.btnInsertDate.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.plus
        Me.btnInsertDate.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.plus
        Me.btnInsertDate.CustomImages.Image = Global.School_System.My.Resources.Resources.plus
        Me.btnInsertDate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnInsertDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnInsertDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnInsertDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnInsertDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnInsertDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnInsertDate.FillColor = System.Drawing.Color.Blue
        Me.btnInsertDate.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.btnInsertDate.ForeColor = System.Drawing.Color.White
        Me.btnInsertDate.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnInsertDate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnInsertDate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnInsertDate.Location = New System.Drawing.Point(955, 0)
        Me.btnInsertDate.Name = "btnInsertDate"
        Me.btnInsertDate.ShadowDecoration.BorderRadius = 17
        Me.btnInsertDate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnInsertDate.ShadowDecoration.Enabled = True
        Me.btnInsertDate.Size = New System.Drawing.Size(244, 42)
        Me.btnInsertDate.TabIndex = 8
        Me.btnInsertDate.Text = "Insert Attendance Date"
        Me.btnInsertDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(337, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Attendace Date"
        '
        'DatePicker
        '
        Me.DatePicker.Location = New System.Drawing.Point(486, 7)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(295, 27)
        Me.DatePicker.TabIndex = 6
        Me.DatePicker.Value = New Date(2024, 10, 24, 19, 23, 21, 0)
        '
        'btnSave
        '
        Me.btnSave.Animated = True
        Me.btnSave.AutoRoundedCorners = True
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 20
        Me.btnSave.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnSave.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnSave.CustomImages.Image = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnSave.FillColor = System.Drawing.Color.Blue
        Me.btnSave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.White
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(1199, 0)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 17
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.Size = New System.Drawing.Size(88, 42)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.cbSectionIdentifier.Location = New System.Drawing.Point(104, 5)
        Me.cbSectionIdentifier.Name = "cbSectionIdentifier"
        Me.cbSectionIdentifier.Size = New System.Drawing.Size(214, 31)
        Me.cbSectionIdentifier.TabIndex = 4
        Me.cbSectionIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "SECTION ID"
        '
        'dgTables
        '
        Me.dgTables.AllowUserToAddRows = False
        Me.dgTables.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgTables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgTables.ColumnHeadersHeight = 40
        Me.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTables.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTables.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgTables.GridColor = System.Drawing.Color.Black
        Me.dgTables.Location = New System.Drawing.Point(0, 42)
        Me.dgTables.Name = "dgTables"
        Me.dgTables.RowHeadersVisible = False
        Me.dgTables.RowTemplate.Height = 30
        Me.dgTables.Size = New System.Drawing.Size(1287, 613)
        Me.dgTables.TabIndex = 2
        Me.dgTables.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgTables.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgTables.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgTables.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgTables.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgTables.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgTables.ThemeStyle.GridColor = System.Drawing.Color.Black
        Me.dgTables.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTables.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgTables.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTables.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgTables.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgTables.ThemeStyle.HeaderStyle.Height = 40
        Me.dgTables.ThemeStyle.ReadOnly = False
        Me.dgTables.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgTables.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgTables.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTables.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgTables.ThemeStyle.RowsStyle.Height = 30
        Me.dgTables.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTables.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'AttendanceSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 695)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttendanceSheet"
        Me.Text = "AttendanceSheet"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgTables As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSectionIdentifier As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DatePicker As DateTimePicker
    Friend WithEvents btnInsertDate As Guna.UI2.WinForms.Guna2Button
End Class
