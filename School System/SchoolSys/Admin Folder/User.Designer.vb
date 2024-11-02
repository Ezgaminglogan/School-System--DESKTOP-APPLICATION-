<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbUser = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnDelete = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbFname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.tbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgTables = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(354, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(56, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(19, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(335, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "User Type"
        '
        'cbUser
        '
        Me.cbUser.AutoRoundedCorners = True
        Me.cbUser.BackColor = System.Drawing.Color.Transparent
        Me.cbUser.BorderColor = System.Drawing.Color.Blue
        Me.cbUser.BorderRadius = 17
        Me.cbUser.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUser.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbUser.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbUser.ForeColor = System.Drawing.Color.Black
        Me.cbUser.HoverState.BorderColor = System.Drawing.Color.White
        Me.cbUser.HoverState.FillColor = System.Drawing.Color.Blue
        Me.cbUser.HoverState.ForeColor = System.Drawing.Color.Black
        Me.cbUser.ItemHeight = 30
        Me.cbUser.Items.AddRange(New Object() {"Student", "Teacher"})
        Me.cbUser.Location = New System.Drawing.Point(424, 66)
        Me.cbUser.Name = "cbUser"
        Me.cbUser.Size = New System.Drawing.Size(200, 36)
        Me.cbUser.TabIndex = 6
        Me.cbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnDelete.HoverState.FillColor = System.Drawing.Color.White
        Me.btnDelete.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(537, 108)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.ShadowDecoration.BorderRadius = 17
        Me.btnDelete.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnDelete.ShadowDecoration.Enabled = True
        Me.btnDelete.Size = New System.Drawing.Size(110, 37)
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
        Me.btnUpdate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.btnUpdate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnUpdate.Location = New System.Drawing.Point(411, 153)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.ShadowDecoration.BorderRadius = 17
        Me.btnUpdate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnUpdate.ShadowDecoration.Enabled = True
        Me.btnUpdate.Size = New System.Drawing.Size(117, 37)
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
        Me.btnCreate.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.HoverState.CustomBorderColor = System.Drawing.Color.Blue
        Me.btnCreate.HoverState.FillColor = System.Drawing.Color.White
        Me.btnCreate.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnCreate.Location = New System.Drawing.Point(411, 108)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.ShadowDecoration.BorderRadius = 17
        Me.btnCreate.ShadowDecoration.Color = System.Drawing.Color.Blue
        Me.btnCreate.ShadowDecoration.Enabled = True
        Me.btnCreate.Size = New System.Drawing.Size(120, 37)
        Me.btnCreate.TabIndex = 0
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.tbFname)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnCreate)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbUser)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbPassword)
        Me.GroupBox1.Controls.Add(Me.tbSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbUsername)
        Me.GroupBox1.Controls.Add(Me.tbEmail)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 210)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fields"
        '
        'tbFname
        '
        Me.tbFname.Animated = True
        Me.tbFname.AutoRoundedCorners = True
        Me.tbFname.BackColor = System.Drawing.Color.Transparent
        Me.tbFname.BorderColor = System.Drawing.Color.Blue
        Me.tbFname.BorderRadius = 16
        Me.tbFname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbFname.DefaultText = ""
        Me.tbFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbFname.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.tbFname.ForeColor = System.Drawing.Color.Black
        Me.tbFname.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.tbFname.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbFname.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbFname.IconLeft = Global.School_System.My.Resources.Resources.user
        Me.tbFname.Location = New System.Drawing.Point(113, 25)
        Me.tbFname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbFname.Name = "tbFname"
        Me.tbFname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFname.PlaceholderText = ""
        Me.tbFname.SelectedText = ""
        Me.tbFname.Size = New System.Drawing.Size(200, 35)
        Me.tbFname.TabIndex = 5
        '
        'tbPassword
        '
        Me.tbPassword.Animated = True
        Me.tbPassword.AutoRoundedCorners = True
        Me.tbPassword.BackColor = System.Drawing.Color.Transparent
        Me.tbPassword.BorderColor = System.Drawing.Color.Blue
        Me.tbPassword.BorderRadius = 16
        Me.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPassword.DefaultText = ""
        Me.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbPassword.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.tbPassword.ForeColor = System.Drawing.Color.Black
        Me.tbPassword.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.tbPassword.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbPassword.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbPassword.IconLeft = Global.School_System.My.Resources.Resources.reset_password
        Me.tbPassword.Location = New System.Drawing.Point(113, 147)
        Me.tbPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.tbPassword.PlaceholderText = ""
        Me.tbPassword.SelectedText = ""
        Me.tbPassword.Size = New System.Drawing.Size(200, 35)
        Me.tbPassword.TabIndex = 5
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'tbSearch
        '
        Me.tbSearch.Animated = True
        Me.tbSearch.AutoRoundedCorners = True
        Me.tbSearch.BackColor = System.Drawing.Color.Transparent
        Me.tbSearch.BorderColor = System.Drawing.Color.Blue
        Me.tbSearch.BorderRadius = 16
        Me.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbSearch.DefaultText = ""
        Me.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbSearch.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearch.ForeColor = System.Drawing.Color.Black
        Me.tbSearch.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.tbSearch.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbSearch.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbSearch.IconLeft = Global.School_System.My.Resources.Resources.folder_15127384
        Me.tbSearch.Location = New System.Drawing.Point(424, 25)
        Me.tbSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSearch.PlaceholderText = ""
        Me.tbSearch.SelectedText = ""
        Me.tbSearch.Size = New System.Drawing.Size(200, 35)
        Me.tbSearch.TabIndex = 5
        '
        'tbUsername
        '
        Me.tbUsername.Animated = True
        Me.tbUsername.AutoRoundedCorners = True
        Me.tbUsername.BackColor = System.Drawing.Color.Transparent
        Me.tbUsername.BorderColor = System.Drawing.Color.Blue
        Me.tbUsername.BorderRadius = 16
        Me.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbUsername.DefaultText = ""
        Me.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbUsername.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.tbUsername.ForeColor = System.Drawing.Color.Black
        Me.tbUsername.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.tbUsername.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbUsername.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbUsername.IconLeft = Global.School_System.My.Resources.Resources.profile
        Me.tbUsername.Location = New System.Drawing.Point(113, 106)
        Me.tbUsername.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUsername.Name = "tbUsername"
        Me.tbUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsername.PlaceholderText = ""
        Me.tbUsername.SelectedText = ""
        Me.tbUsername.Size = New System.Drawing.Size(200, 35)
        Me.tbUsername.TabIndex = 5
        '
        'tbEmail
        '
        Me.tbEmail.Animated = True
        Me.tbEmail.AutoRoundedCorners = True
        Me.tbEmail.BackColor = System.Drawing.Color.Transparent
        Me.tbEmail.BorderColor = System.Drawing.Color.Blue
        Me.tbEmail.BorderRadius = 16
        Me.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbEmail.DefaultText = ""
        Me.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.tbEmail.ForeColor = System.Drawing.Color.Black
        Me.tbEmail.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.tbEmail.HoverState.FillColor = System.Drawing.Color.Blue
        Me.tbEmail.HoverState.ForeColor = System.Drawing.Color.Black
        Me.tbEmail.IconLeft = Global.School_System.My.Resources.Resources.gmail
        Me.tbEmail.Location = New System.Drawing.Point(113, 65)
        Me.tbEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbEmail.Name = "tbEmail"
        Me.tbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbEmail.PlaceholderText = ""
        Me.tbEmail.SelectedText = ""
        Me.tbEmail.Size = New System.Drawing.Size(200, 35)
        Me.tbEmail.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sunshine Tropical", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1039, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 74)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "USER'S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SECTION"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgTables)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1220, 479)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TABLES"
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
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgTables.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgTables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTables.GridColor = System.Drawing.Color.Black
        Me.dgTables.Location = New System.Drawing.Point(3, 23)
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
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = Global.School_System.My.Resources.Resources.user
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(792, 29)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(191, 172)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 11
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1220, 700)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "User"
        Me.Text = "User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgTables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbUser As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents tbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbFname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents tbSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnDelete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgTables As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
End Class
