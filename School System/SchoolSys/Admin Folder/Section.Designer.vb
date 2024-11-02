<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Section
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Fields = New System.Windows.Forms.GroupBox()
        Me.cbSemester = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cbCourseN = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.tbRoomNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbYear = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.tbStartTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEndTime = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbClassD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbSectionID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgTables = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tbInstructor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Fields.SuspendLayout()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fields
        '
        Me.Fields.Controls.Add(Me.cbSemester)
        Me.Fields.Controls.Add(Me.cbCourseN)
        Me.Fields.Controls.Add(Me.tbRoomNumber)
        Me.Fields.Controls.Add(Me.tbYear)
        Me.Fields.Controls.Add(Me.Guna2GroupBox1)
        Me.Fields.Controls.Add(Me.tbStartTime)
        Me.Fields.Controls.Add(Me.tbEndTime)
        Me.Fields.Controls.Add(Me.tbClassD)
        Me.Fields.Controls.Add(Me.tbInstructor)
        Me.Fields.Controls.Add(Me.tbSectionID)
        Me.Fields.Controls.Add(Me.Label9)
        Me.Fields.Controls.Add(Me.Label8)
        Me.Fields.Controls.Add(Me.Label7)
        Me.Fields.Controls.Add(Me.Label6)
        Me.Fields.Controls.Add(Me.Label5)
        Me.Fields.Controls.Add(Me.Label4)
        Me.Fields.Controls.Add(Me.Label3)
        Me.Fields.Controls.Add(Me.Label2)
        Me.Fields.Controls.Add(Me.Label1)
        Me.Fields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fields.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fields.Location = New System.Drawing.Point(6, 6)
        Me.Fields.Name = "Fields"
        Me.Fields.Size = New System.Drawing.Size(1024, 216)
        Me.Fields.TabIndex = 0
        Me.Fields.TabStop = False
        Me.Fields.Text = "Fields"
        '
        'cbSemester
        '
        Me.cbSemester.AutoRoundedCorners = True
        Me.cbSemester.BackColor = System.Drawing.Color.Transparent
        Me.cbSemester.BorderColor = System.Drawing.Color.Blue
        Me.cbSemester.BorderRadius = 14
        Me.cbSemester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSemester.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSemester.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbSemester.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbSemester.ForeColor = System.Drawing.Color.Black
        Me.cbSemester.ItemHeight = 25
        Me.cbSemester.Items.AddRange(New Object() {"Fall", "Spring"})
        Me.cbSemester.Location = New System.Drawing.Point(126, 105)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(200, 31)
        Me.cbSemester.TabIndex = 7
        Me.cbSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbCourseN
        '
        Me.cbCourseN.AutoRoundedCorners = True
        Me.cbCourseN.BackColor = System.Drawing.Color.Transparent
        Me.cbCourseN.BorderColor = System.Drawing.Color.Blue
        Me.cbCourseN.BorderRadius = 14
        Me.cbCourseN.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbCourseN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCourseN.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCourseN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbCourseN.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbCourseN.ForeColor = System.Drawing.Color.Black
        Me.cbCourseN.ItemHeight = 25
        Me.cbCourseN.Location = New System.Drawing.Point(126, 68)
        Me.cbCourseN.Name = "cbCourseN"
        Me.cbCourseN.Size = New System.Drawing.Size(200, 31)
        Me.cbCourseN.TabIndex = 6
        Me.cbCourseN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbRoomNumber
        '
        Me.tbRoomNumber.Animated = True
        Me.tbRoomNumber.AutoRoundedCorners = True
        Me.tbRoomNumber.BorderColor = System.Drawing.Color.Blue
        Me.tbRoomNumber.BorderRadius = 14
        Me.tbRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbRoomNumber.DefaultText = ""
        Me.tbRoomNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbRoomNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbRoomNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRoomNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbRoomNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbRoomNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbRoomNumber.ForeColor = System.Drawing.Color.Black
        Me.tbRoomNumber.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbRoomNumber.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbRoomNumber.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbRoomNumber.IconLeft = Global.School_System.My.Resources.Resources.presentation
        Me.tbRoomNumber.Location = New System.Drawing.Point(461, 44)
        Me.tbRoomNumber.Name = "tbRoomNumber"
        Me.tbRoomNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRoomNumber.PlaceholderText = ""
        Me.tbRoomNumber.SelectedText = ""
        Me.tbRoomNumber.Size = New System.Drawing.Size(200, 31)
        Me.tbRoomNumber.TabIndex = 3
        '
        'tbYear
        '
        Me.tbYear.Animated = True
        Me.tbYear.AutoRoundedCorners = True
        Me.tbYear.BorderColor = System.Drawing.Color.Blue
        Me.tbYear.BorderRadius = 14
        Me.tbYear.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbYear.DefaultText = ""
        Me.tbYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbYear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbYear.ForeColor = System.Drawing.Color.Black
        Me.tbYear.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbYear.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbYear.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbYear.IconLeft = Global.School_System.My.Resources.Resources._31_9332412
        Me.tbYear.Location = New System.Drawing.Point(127, 142)
        Me.tbYear.Name = "tbYear"
        Me.tbYear.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbYear.PlaceholderText = ""
        Me.tbYear.SelectedText = ""
        Me.tbYear.Size = New System.Drawing.Size(199, 31)
        Me.tbYear.TabIndex = 3
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.BorderColor = System.Drawing.Color.Blue
        Me.Guna2GroupBox1.BorderRadius = 10
        Me.Guna2GroupBox1.Controls.Add(Me.btnDelete)
        Me.Guna2GroupBox1.Controls.Add(Me.btnUpdate)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCreate)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Blue
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(698, 54)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(304, 95)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "MENU"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnDelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(203, 46)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.BorderRadius = 17
        Me.btnDelete.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.Size = New System.Drawing.Size(95, 37)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AutoRoundedCorners = True
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderRadius = 17
        Me.btnUpdate.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnUpdate.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnUpdate.CustomImages.Image = Global.School_System.My.Resources.Resources.circular_arrow
        Me.btnUpdate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.Blue
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(102, 46)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.BorderRadius = 17
        Me.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnUpdate.ShadowDecoration.Enabled = True
        Me.btnUpdate.Size = New System.Drawing.Size(95, 37)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCreate
        '
        Me.btnCreate.Animated = True
        Me.btnCreate.AutoRoundedCorners = True
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BorderRadius = 17
        Me.btnCreate.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.plus
        Me.btnCreate.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.plus
        Me.btnCreate.CustomImages.Image = Global.School_System.My.Resources.Resources.plus
        Me.btnCreate.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.Blue
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnCreate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnCreate.Location = New System.Drawing.Point(4, 46)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.ShadowDecoration.BorderRadius = 17
        Me.btnCreate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnCreate.ShadowDecoration.Enabled = True
        Me.btnCreate.Size = New System.Drawing.Size(92, 37)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbStartTime
        '
        Me.tbStartTime.Animated = True
        Me.tbStartTime.AutoRoundedCorners = True
        Me.tbStartTime.BorderColor = System.Drawing.Color.Blue
        Me.tbStartTime.BorderRadius = 14
        Me.tbStartTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbStartTime.DefaultText = ""
        Me.tbStartTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbStartTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbStartTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbStartTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbStartTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbStartTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbStartTime.ForeColor = System.Drawing.Color.Black
        Me.tbStartTime.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbStartTime.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbStartTime.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbStartTime.IconLeft = Global.School_System.My.Resources.Resources.start
        Me.tbStartTime.Location = New System.Drawing.Point(461, 118)
        Me.tbStartTime.Name = "tbStartTime"
        Me.tbStartTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbStartTime.PlaceholderText = ""
        Me.tbStartTime.SelectedText = ""
        Me.tbStartTime.Size = New System.Drawing.Size(200, 31)
        Me.tbStartTime.TabIndex = 1
        '
        'tbEndTime
        '
        Me.tbEndTime.Animated = True
        Me.tbEndTime.AutoRoundedCorners = True
        Me.tbEndTime.BorderColor = System.Drawing.Color.Blue
        Me.tbEndTime.BorderRadius = 14
        Me.tbEndTime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEndTime.DefaultText = ""
        Me.tbEndTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEndTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEndTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEndTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEndTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEndTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbEndTime.ForeColor = System.Drawing.Color.Black
        Me.tbEndTime.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbEndTime.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbEndTime.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbEndTime.IconLeft = Global.School_System.My.Resources.Resources.time_left
        Me.tbEndTime.Location = New System.Drawing.Point(461, 155)
        Me.tbEndTime.Name = "tbEndTime"
        Me.tbEndTime.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEndTime.PlaceholderText = ""
        Me.tbEndTime.SelectedText = ""
        Me.tbEndTime.Size = New System.Drawing.Size(200, 31)
        Me.tbEndTime.TabIndex = 1
        '
        'tbClassD
        '
        Me.tbClassD.Animated = True
        Me.tbClassD.AutoRoundedCorners = True
        Me.tbClassD.BorderColor = System.Drawing.Color.Blue
        Me.tbClassD.BorderRadius = 14
        Me.tbClassD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbClassD.DefaultText = ""
        Me.tbClassD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbClassD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbClassD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbClassD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbClassD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbClassD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbClassD.ForeColor = System.Drawing.Color.Black
        Me.tbClassD.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbClassD.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbClassD.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbClassD.IconLeft = Global.School_System.My.Resources.Resources.teacher
        Me.tbClassD.Location = New System.Drawing.Point(461, 81)
        Me.tbClassD.Name = "tbClassD"
        Me.tbClassD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbClassD.PlaceholderText = ""
        Me.tbClassD.SelectedText = ""
        Me.tbClassD.Size = New System.Drawing.Size(200, 31)
        Me.tbClassD.TabIndex = 1
        '
        'tbSectionID
        '
        Me.tbSectionID.Animated = True
        Me.tbSectionID.AutoRoundedCorners = True
        Me.tbSectionID.BorderColor = System.Drawing.Color.Blue
        Me.tbSectionID.BorderRadius = 14
        Me.tbSectionID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSectionID.DefaultText = ""
        Me.tbSectionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSectionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSectionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSectionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSectionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSectionID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSectionID.ForeColor = System.Drawing.Color.Black
        Me.tbSectionID.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbSectionID.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbSectionID.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbSectionID.IconLeft = Global.School_System.My.Resources.Resources.travel_13609008
        Me.tbSectionID.Location = New System.Drawing.Point(127, 31)
        Me.tbSectionID.Name = "tbSectionID"
        Me.tbSectionID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSectionID.PlaceholderText = ""
        Me.tbSectionID.SelectedText = ""
        Me.tbSectionID.Size = New System.Drawing.Size(200, 31)
        Me.tbSectionID.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(390, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "End Time"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(385, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 17)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Start Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Class Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(352, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Room Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Instructor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(84, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Year"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Semester"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Course Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Section Identifier"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sunshine Tropical", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1063, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 74)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "SECTION'S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SECTION"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgTables)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 222)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1220, 478)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tables"
        '
        'dgTables
        '
        Me.dgTables.AllowUserToAddRows = False
        Me.dgTables.AllowUserToDeleteRows = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.dgTables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgTables.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgTables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgTables.ColumnHeadersHeight = 40
        Me.dgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTables.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTables.GridColor = System.Drawing.Color.Black
        Me.dgTables.Location = New System.Drawing.Point(3, 22)
        Me.dgTables.Name = "dgTables"
        Me.dgTables.ReadOnly = True
        Me.dgTables.RowHeadersVisible = False
        Me.dgTables.RowTemplate.Height = 30
        Me.dgTables.Size = New System.Drawing.Size(1214, 453)
        Me.dgTables.TabIndex = 1
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
        'tbInstructor
        '
        Me.tbInstructor.Animated = True
        Me.tbInstructor.AutoRoundedCorners = True
        Me.tbInstructor.BorderColor = System.Drawing.Color.Blue
        Me.tbInstructor.BorderRadius = 14
        Me.tbInstructor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbInstructor.DefaultText = ""
        Me.tbInstructor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbInstructor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbInstructor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbInstructor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbInstructor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbInstructor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbInstructor.ForeColor = System.Drawing.Color.Black
        Me.tbInstructor.HoverState.BorderColor = System.Drawing.Color.White
        Me.tbInstructor.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbInstructor.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbInstructor.IconLeft = Global.School_System.My.Resources.Resources.teacher_11256757
        Me.tbInstructor.Location = New System.Drawing.Point(126, 178)
        Me.tbInstructor.Name = "tbInstructor"
        Me.tbInstructor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbInstructor.PlaceholderText = ""
        Me.tbInstructor.SelectedText = ""
        Me.tbInstructor.Size = New System.Drawing.Size(200, 31)
        Me.tbInstructor.TabIndex = 1
        '
        'Section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1220, 700)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Fields)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Section"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Section"
        Me.Fields.ResumeLayout(False)
        Me.Fields.PerformLayout()
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Fields As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSectionID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbClassD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgTables As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents tbRoomNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbYear As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbStartTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEndTime As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbSemester As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cbCourseN As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbInstructor As Guna.UI2.WinForms.Guna2TextBox
End Class
