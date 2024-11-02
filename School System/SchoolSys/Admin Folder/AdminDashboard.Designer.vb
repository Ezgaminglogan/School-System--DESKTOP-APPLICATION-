<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Me.panelForms = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Guna2CirclePictureBox6 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblTeacherC = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Guna2CirclePictureBox5 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblUsers = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Guna2CirclePictureBox4 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblSections = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblStudent = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbTables = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgTables = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.panelForms.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Guna2CirclePictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Guna2CirclePictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Guna2CirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelForms
        '
        Me.panelForms.BackColor = System.Drawing.Color.White
        Me.panelForms.Controls.Add(Me.GroupBox6)
        Me.panelForms.Controls.Add(Me.GroupBox5)
        Me.panelForms.Controls.Add(Me.GroupBox3)
        Me.panelForms.Controls.Add(Me.GroupBox2)
        Me.panelForms.Controls.Add(Me.GroupBox1)
        Me.panelForms.Controls.Add(Me.GroupBox4)
        Me.panelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelForms.Location = New System.Drawing.Point(0, 0)
        Me.panelForms.Name = "panelForms"
        Me.panelForms.Size = New System.Drawing.Size(1220, 700)
        Me.panelForms.TabIndex = 3
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Guna2CirclePictureBox6)
        Me.GroupBox6.Controls.Add(Me.lblTeacherC)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox6.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(877, 18)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(144, 132)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "TEACHER'S"
        '
        'Guna2CirclePictureBox6
        '
        Me.Guna2CirclePictureBox6.Image = Global.School_System.My.Resources.Resources.teacher
        Me.Guna2CirclePictureBox6.ImageRotate = 0!
        Me.Guna2CirclePictureBox6.Location = New System.Drawing.Point(6, 41)
        Me.Guna2CirclePictureBox6.Name = "Guna2CirclePictureBox6"
        Me.Guna2CirclePictureBox6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox6.Size = New System.Drawing.Size(64, 64)
        Me.Guna2CirclePictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox6.TabIndex = 1
        Me.Guna2CirclePictureBox6.TabStop = False
        '
        'lblTeacherC
        '
        Me.lblTeacherC.AutoSize = True
        Me.lblTeacherC.Location = New System.Drawing.Point(76, 61)
        Me.lblTeacherC.Name = "lblTeacherC"
        Me.lblTeacherC.Size = New System.Drawing.Size(34, 22)
        Me.lblTeacherC.TabIndex = 0
        Me.lblTeacherC.Text = "[0]"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Guna2CirclePictureBox5)
        Me.GroupBox5.Controls.Add(Me.lblUsers)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox5.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(718, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(144, 132)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "USER'S"
        '
        'Guna2CirclePictureBox5
        '
        Me.Guna2CirclePictureBox5.Image = Global.School_System.My.Resources.Resources.user
        Me.Guna2CirclePictureBox5.ImageRotate = 0!
        Me.Guna2CirclePictureBox5.Location = New System.Drawing.Point(6, 41)
        Me.Guna2CirclePictureBox5.Name = "Guna2CirclePictureBox5"
        Me.Guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox5.Size = New System.Drawing.Size(64, 64)
        Me.Guna2CirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox5.TabIndex = 1
        Me.Guna2CirclePictureBox5.TabStop = False
        '
        'lblUsers
        '
        Me.lblUsers.AutoSize = True
        Me.lblUsers.Location = New System.Drawing.Point(76, 61)
        Me.lblUsers.Name = "lblUsers"
        Me.lblUsers.Size = New System.Drawing.Size(34, 22)
        Me.lblUsers.TabIndex = 0
        Me.lblUsers.Text = "[0]"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Guna2CirclePictureBox4)
        Me.GroupBox3.Controls.Add(Me.lblSections)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(558, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 132)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SECTION'S"
        '
        'Guna2CirclePictureBox4
        '
        Me.Guna2CirclePictureBox4.Image = Global.School_System.My.Resources.Resources.videos
        Me.Guna2CirclePictureBox4.ImageRotate = 0!
        Me.Guna2CirclePictureBox4.Location = New System.Drawing.Point(11, 41)
        Me.Guna2CirclePictureBox4.Name = "Guna2CirclePictureBox4"
        Me.Guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox4.Size = New System.Drawing.Size(64, 64)
        Me.Guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox4.TabIndex = 1
        Me.Guna2CirclePictureBox4.TabStop = False
        '
        'lblSections
        '
        Me.lblSections.AutoSize = True
        Me.lblSections.Location = New System.Drawing.Point(81, 61)
        Me.lblSections.Name = "lblSections"
        Me.lblSections.Size = New System.Drawing.Size(34, 22)
        Me.lblSections.TabIndex = 0
        Me.lblSections.Text = "[0]"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.GroupBox2.Controls.Add(Me.lblCourse)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(398, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 132)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "COURSE'S"
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.Image = Global.School_System.My.Resources.Resources.online_learning
        Me.Guna2CirclePictureBox3.ImageRotate = 0!
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(6, 41)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.Guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox3.TabIndex = 1
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(76, 61)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(34, 22)
        Me.lblCourse.TabIndex = 0
        Me.lblCourse.Text = "[0]"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.GroupBox1.Controls.Add(Me.lblStudent)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Californian FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(238, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 132)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STUDENT'S"
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Image = Global.School_System.My.Resources.Resources.student_837723
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(6, 41)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(64, 64)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 1
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'lblStudent
        '
        Me.lblStudent.AutoSize = True
        Me.lblStudent.Location = New System.Drawing.Point(82, 61)
        Me.lblStudent.Name = "lblStudent"
        Me.lblStudent.Size = New System.Drawing.Size(34, 22)
        Me.lblStudent.TabIndex = 0
        Me.lblStudent.Text = "[0]"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbTables)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.dgTables)
        Me.GroupBox4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1214, 525)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TABLES"
        '
        'cbTables
        '
        Me.cbTables.BackColor = System.Drawing.Color.Transparent
        Me.cbTables.BorderColor = System.Drawing.Color.Blue
        Me.cbTables.BorderRadius = 5
        Me.cbTables.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTables.FillColor = System.Drawing.Color.WhiteSmoke
        Me.cbTables.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTables.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbTables.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbTables.ForeColor = System.Drawing.Color.Black
        Me.cbTables.ItemHeight = 30
        Me.cbTables.Items.AddRange(New Object() {"STUDENT TABLE", "COURSE TABLE", "SECTION TABLE", "USER TABLE", "TEACHER TABLE", "PREREQUISITE TABLE"})
        Me.cbTables.Location = New System.Drawing.Point(167, 25)
        Me.cbTables.Name = "cbTables"
        Me.cbTables.Size = New System.Drawing.Size(198, 36)
        Me.cbTables.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SELECT A TABLE"
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTables.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTables.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgTables.GridColor = System.Drawing.Color.Black
        Me.dgTables.Location = New System.Drawing.Point(3, 67)
        Me.dgTables.Name = "dgTables"
        Me.dgTables.ReadOnly = True
        Me.dgTables.RowHeadersVisible = False
        Me.dgTables.RowTemplate.Height = 30
        Me.dgTables.Size = New System.Drawing.Size(1208, 455)
        Me.dgTables.TabIndex = 0
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
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 700)
        Me.Controls.Add(Me.panelForms)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        Me.panelForms.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Guna2CirclePictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Guna2CirclePictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Guna2CirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelForms As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbTables As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgTables As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Guna2CirclePictureBox6 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblTeacherC As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Guna2CirclePictureBox5 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblUsers As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Guna2CirclePictureBox4 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblSections As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblStudent As Label
End Class
