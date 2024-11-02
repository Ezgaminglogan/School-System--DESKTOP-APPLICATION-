<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teacher
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
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTeach = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.panelForm = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogOut = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSchedule = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSubjects = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGrades = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAttendance = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlToolTip1 = New Guna.UI2.WinForms.Guna2HtmlToolTip()
        Me.panelForms = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.panelForm.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimateWindow = True
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.ResizeForm = False
        Me.Guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Blue
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Blue
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1366, 33)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.Controls.Add(Me.lblTeach)
        Me.Guna2Panel4.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(213, 33)
        Me.Guna2Panel4.TabIndex = 4
        '
        'lblTeach
        '
        Me.lblTeach.AutoSize = True
        Me.lblTeach.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeach.ForeColor = System.Drawing.Color.Black
        Me.lblTeach.Location = New System.Drawing.Point(62, 6)
        Me.lblTeach.Name = "lblTeach"
        Me.lblTeach.Size = New System.Drawing.Size(129, 20)
        Me.lblTeach.TabIndex = 2
        Me.lblTeach.Text = "[Teacher' Name]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sunshine Tropical", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(639, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "WELCOME!"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BorderRadius = 10
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1276, 0)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 33)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BorderRadius = 10
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.Blue
        Me.Guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red
        Me.Guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1321, 0)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 33)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Blue
        Me.Guna2Panel2.BorderRadius = 15
        Me.Guna2Panel2.Controls.Add(Me.lblDate)
        Me.Guna2Panel2.Controls.Add(Me.Label3)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 33)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1366, 34)
        Me.Guna2Panel2.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.Black
        Me.lblDate.Location = New System.Drawing.Point(5, 6)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "[DATE]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Sunshine Tropical", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(583, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 31)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TEACHER'S DASHBOARD"
        '
        'panelForm
        '
        Me.panelForm.BackColor = System.Drawing.Color.Transparent
        Me.panelForm.Controls.Add(Me.panelForms)
        Me.panelForm.Controls.Add(Me.Guna2Panel3)
        Me.panelForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelForm.Location = New System.Drawing.Point(0, 67)
        Me.panelForm.Name = "panelForm"
        Me.panelForm.Size = New System.Drawing.Size(1366, 701)
        Me.panelForm.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.Controls.Add(Me.btnLogOut)
        Me.Guna2Panel3.Controls.Add(Me.btnSchedule)
        Me.Guna2Panel3.Controls.Add(Me.btnSubjects)
        Me.Guna2Panel3.Controls.Add(Me.btnGrades)
        Me.Guna2Panel3.Controls.Add(Me.btnAttendance)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.Blue
        Me.Guna2Panel3.Location = New System.Drawing.Point(12, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(58, 695)
        Me.Guna2Panel3.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.Animated = True
        Me.btnLogOut.AutoRoundedCorners = True
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BorderRadius = 21
        Me.btnLogOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnLogOut.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnLogOut.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnLogOut.CheckedState.FillColor2 = System.Drawing.Color.White
        Me.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.logout
        Me.btnLogOut.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.logout
        Me.btnLogOut.CustomImages.Image = Global.School_System.My.Resources.Resources.logout
        Me.btnLogOut.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogOut.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogOut.FillColor = System.Drawing.Color.Blue
        Me.btnLogOut.FillColor2 = System.Drawing.Color.Blue
        Me.btnLogOut.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.HoverState.BorderColor = System.Drawing.Color.White
        Me.btnLogOut.HoverState.FillColor = System.Drawing.Color.White
        Me.btnLogOut.HoverState.FillColor2 = System.Drawing.Color.White
        Me.btnLogOut.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnLogOut.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnLogOut.Location = New System.Drawing.Point(3, 633)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(103, 45)
        Me.btnLogOut.TabIndex = 4
        Me.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnLogOut.TextOffset = New System.Drawing.Point(-8, 0)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnLogOut, "LOG OUT")
        Me.btnLogOut.UseTransparentBackground = True
        '
        'btnSchedule
        '
        Me.btnSchedule.Animated = True
        Me.btnSchedule.AutoRoundedCorners = True
        Me.btnSchedule.BackColor = System.Drawing.Color.Transparent
        Me.btnSchedule.BorderRadius = 16
        Me.btnSchedule.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSchedule.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnSchedule.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnSchedule.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnSchedule.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.project
        Me.btnSchedule.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.project
        Me.btnSchedule.CustomImages.Image = Global.School_System.My.Resources.Resources.project
        Me.btnSchedule.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSchedule.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSchedule.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSchedule.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSchedule.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSchedule.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSchedule.FillColor = System.Drawing.Color.Blue
        Me.btnSchedule.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSchedule.ForeColor = System.Drawing.Color.White
        Me.btnSchedule.HoverState.BorderColor = System.Drawing.Color.White
        Me.btnSchedule.HoverState.FillColor = System.Drawing.Color.White
        Me.btnSchedule.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSchedule.Location = New System.Drawing.Point(3, 142)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(103, 35)
        Me.btnSchedule.TabIndex = 3
        Me.btnSchedule.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnSchedule.TextOffset = New System.Drawing.Point(-2, 0)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnSchedule, "CLASS SCHEDULES")
        Me.btnSchedule.UseTransparentBackground = True
        '
        'btnSubjects
        '
        Me.btnSubjects.Animated = True
        Me.btnSubjects.AutoRoundedCorners = True
        Me.btnSubjects.BackColor = System.Drawing.Color.Transparent
        Me.btnSubjects.BorderRadius = 16
        Me.btnSubjects.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnSubjects.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnSubjects.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnSubjects.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnSubjects.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.elearning
        Me.btnSubjects.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.elearning
        Me.btnSubjects.CustomImages.Image = Global.School_System.My.Resources.Resources.elearning
        Me.btnSubjects.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSubjects.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSubjects.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSubjects.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSubjects.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSubjects.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSubjects.FillColor = System.Drawing.Color.Blue
        Me.btnSubjects.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubjects.ForeColor = System.Drawing.Color.White
        Me.btnSubjects.HoverState.BorderColor = System.Drawing.Color.White
        Me.btnSubjects.HoverState.FillColor = System.Drawing.Color.White
        Me.btnSubjects.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSubjects.Location = New System.Drawing.Point(3, 101)
        Me.btnSubjects.Name = "btnSubjects"
        Me.btnSubjects.Size = New System.Drawing.Size(103, 35)
        Me.btnSubjects.TabIndex = 2
        Me.btnSubjects.TextOffset = New System.Drawing.Point(20, 0)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnSubjects, "SUBJECTS")
        Me.btnSubjects.UseTransparentBackground = True
        '
        'btnGrades
        '
        Me.btnGrades.Animated = True
        Me.btnGrades.AutoRoundedCorners = True
        Me.btnGrades.BackColor = System.Drawing.Color.Transparent
        Me.btnGrades.BorderRadius = 16
        Me.btnGrades.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnGrades.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnGrades.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnGrades.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnGrades.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.score
        Me.btnGrades.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.score
        Me.btnGrades.CustomImages.Image = Global.School_System.My.Resources.Resources.score
        Me.btnGrades.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnGrades.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnGrades.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGrades.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGrades.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGrades.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGrades.FillColor = System.Drawing.Color.Blue
        Me.btnGrades.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.White
        Me.btnGrades.HoverState.BorderColor = System.Drawing.Color.White
        Me.btnGrades.HoverState.FillColor = System.Drawing.Color.White
        Me.btnGrades.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnGrades.Location = New System.Drawing.Point(3, 60)
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(103, 35)
        Me.btnGrades.TabIndex = 1
        Me.btnGrades.TextOffset = New System.Drawing.Point(12, 0)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnGrades, "GRADES FOR STUDENT")
        Me.btnGrades.UseTransparentBackground = True
        '
        'btnAttendance
        '
        Me.btnAttendance.Animated = True
        Me.btnAttendance.AutoRoundedCorners = True
        Me.btnAttendance.BackColor = System.Drawing.Color.Transparent
        Me.btnAttendance.BorderRadius = 16
        Me.btnAttendance.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.btnAttendance.CheckedState.BorderColor = System.Drawing.Color.White
        Me.btnAttendance.CheckedState.FillColor = System.Drawing.Color.White
        Me.btnAttendance.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.btnAttendance.CustomImages.CheckedImage = Global.School_System.My.Resources.Resources.immigration
        Me.btnAttendance.CustomImages.HoveredImage = Global.School_System.My.Resources.Resources.immigration
        Me.btnAttendance.CustomImages.Image = Global.School_System.My.Resources.Resources.immigration
        Me.btnAttendance.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAttendance.CustomImages.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnAttendance.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAttendance.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAttendance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAttendance.FillColor = System.Drawing.Color.Blue
        Me.btnAttendance.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttendance.ForeColor = System.Drawing.Color.White
        Me.btnAttendance.HoverState.BorderColor = System.Drawing.Color.White
        Me.btnAttendance.HoverState.FillColor = System.Drawing.Color.White
        Me.btnAttendance.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnAttendance.Location = New System.Drawing.Point(3, 19)
        Me.btnAttendance.Name = "btnAttendance"
        Me.btnAttendance.Size = New System.Drawing.Size(103, 35)
        Me.btnAttendance.TabIndex = 0
        Me.btnAttendance.TextOffset = New System.Drawing.Point(16, 0)
        Me.Guna2HtmlToolTip1.SetToolTip(Me.btnAttendance, "ATTENDANCE")
        Me.btnAttendance.UseTransparentBackground = True
        '
        'Guna2HtmlToolTip1
        '
        Me.Guna2HtmlToolTip1.AllowLinksHandling = True
        Me.Guna2HtmlToolTip1.BorderColor = System.Drawing.Color.Blue
        Me.Guna2HtmlToolTip1.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlToolTip1.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlToolTip1.IsBalloon = True
        Me.Guna2HtmlToolTip1.MaximumSize = New System.Drawing.Size(0, 0)
        Me.Guna2HtmlToolTip1.TitleFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlToolTip1.TitleForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Guna2HtmlToolTip1.ToolTipTitle = "ToolTip"
        '
        'panelForms
        '
        Me.panelForms.BackgroundImage = Global.School_System.My.Resources.Resources.Students
        Me.panelForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelForms.Location = New System.Drawing.Point(76, 3)
        Me.panelForms.Name = "panelForms"
        Me.panelForms.Size = New System.Drawing.Size(1287, 695)
        Me.panelForms.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2PictureBox1.Image = Global.School_System.My.Resources.Resources.teacher_11256757
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(51, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 3
        Me.Guna2PictureBox1.TabStop = False
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.panelForm)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teacher"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Teacher"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.panelForm.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblTeach As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents panelForm As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGrades As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSubjects As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSchedule As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents panelForms As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLogOut As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlToolTip1 As Guna.UI2.WinForms.Guna2HtmlToolTip
End Class
