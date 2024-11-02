<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vacancy
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numUPDVacancy = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.cbSectionID = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbCourseNumber = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgTables = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numUPDVacancy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 30
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Blue
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(510, 38)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Vacany Section"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BorderRadius = 15
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(420, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 38)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderRadius = 15
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(465, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 38)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numUPDVacancy)
        Me.GroupBox1.Controls.Add(Me.cbSectionID)
        Me.GroupBox1.Controls.Add(Me.cbCourseNumber)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnCreate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 159)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fields"
        '
        'numUPDVacancy
        '
        Me.numUPDVacancy.AutoRoundedCorners = True
        Me.numUPDVacancy.BackColor = System.Drawing.Color.Transparent
        Me.numUPDVacancy.BorderColor = System.Drawing.Color.Blue
        Me.numUPDVacancy.BorderRadius = 19
        Me.numUPDVacancy.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.numUPDVacancy.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numUPDVacancy.Location = New System.Drawing.Point(153, 106)
        Me.numUPDVacancy.Name = "numUPDVacancy"
        Me.numUPDVacancy.Size = New System.Drawing.Size(158, 40)
        Me.numUPDVacancy.TabIndex = 7
        Me.numUPDVacancy.TextOffset = New System.Drawing.Point(50, 0)
        '
        'cbSectionID
        '
        Me.cbSectionID.AutoRoundedCorners = True
        Me.cbSectionID.BackColor = System.Drawing.Color.Transparent
        Me.cbSectionID.BorderColor = System.Drawing.Color.Blue
        Me.cbSectionID.BorderRadius = 17
        Me.cbSectionID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSectionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSectionID.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSectionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSectionID.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSectionID.ForeColor = System.Drawing.Color.Black
        Me.cbSectionID.ItemHeight = 30
        Me.cbSectionID.Location = New System.Drawing.Point(153, 65)
        Me.cbSectionID.Name = "cbSectionID"
        Me.cbSectionID.Size = New System.Drawing.Size(158, 36)
        Me.cbSectionID.TabIndex = 6
        Me.cbSectionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCourseNumber
        '
        Me.cbCourseNumber.AutoRoundedCorners = True
        Me.cbCourseNumber.BackColor = System.Drawing.Color.Transparent
        Me.cbCourseNumber.BorderColor = System.Drawing.Color.Blue
        Me.cbCourseNumber.BorderRadius = 17
        Me.cbCourseNumber.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCourseNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourseNumber.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCourseNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCourseNumber.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbCourseNumber.ForeColor = System.Drawing.Color.Black
        Me.cbCourseNumber.ItemHeight = 30
        Me.cbCourseNumber.Location = New System.Drawing.Point(153, 25)
        Me.cbCourseNumber.Name = "cbCourseNumber"
        Me.cbCourseNumber.Size = New System.Drawing.Size(158, 36)
        Me.cbCourseNumber.TabIndex = 6
        Me.cbCourseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDelete
        '
        Me.btnDelete.Animated = True
        Me.btnDelete.AutoRoundedCorners = True
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BorderRadius = 15
        Me.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDelete.FillColor = System.Drawing.Color.Blue
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Image = Global.School_System.My.Resources.Resources.delete
        Me.btnDelete.IndicateFocus = True
        Me.btnDelete.Location = New System.Drawing.Point(348, 68)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.BorderRadius = 15
        Me.btnDelete.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.Size = New System.Drawing.Size(105, 33)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AutoRoundedCorners = True
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderRadius = 15
        Me.btnUpdate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.Blue
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Image = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnUpdate.IndicateFocus = True
        Me.btnUpdate.Location = New System.Drawing.Point(348, 106)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.BorderRadius = 15
        Me.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnUpdate.ShadowDecoration.Enabled = True
        Me.btnUpdate.Size = New System.Drawing.Size(105, 33)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        '
        'btnCreate
        '
        Me.btnCreate.Animated = True
        Me.btnCreate.AutoRoundedCorners = True
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BorderColor = System.Drawing.Color.White
        Me.btnCreate.BorderRadius = 15
        Me.btnCreate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.Blue
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnCreate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnCreate.Image = Global.School_System.My.Resources.Resources.plus
        Me.btnCreate.IndicateFocus = True
        Me.btnCreate.Location = New System.Drawing.Point(348, 28)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.ShadowDecoration.BorderRadius = 15
        Me.btnCreate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnCreate.ShadowDecoration.Enabled = True
        Me.btnCreate.Size = New System.Drawing.Size(105, 33)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(66, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Vacancy"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Section Identifier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgTables)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 209)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(486, 229)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tables"
        '
        'dgTables
        '
        Me.dgTables.AllowUserToAddRows = False
        Me.dgTables.AllowUserToDeleteRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgTables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgTables.ColumnHeadersHeight = 40
        Me.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTables.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTables.GridColor = System.Drawing.Color.Black
        Me.dgTables.Location = New System.Drawing.Point(3, 22)
        Me.dgTables.Name = "dgTables"
        Me.dgTables.ReadOnly = True
        Me.dgTables.RowHeadersVisible = False
        Me.dgTables.RowTemplate.Height = 30
        Me.dgTables.Size = New System.Drawing.Size(480, 204)
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
        Me.dgTables.ThemeStyle.ReadOnly = True
        Me.dgTables.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgTables.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgTables.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgTables.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgTables.ThemeStyle.RowsStyle.Height = 30
        Me.dgTables.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgTables.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Vacancy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(510, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vacancy"
        Me.Text = "Vacancy"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numUPDVacancy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbSectionID As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbCourseNumber As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents numUPDVacancy As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents dgTables As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
