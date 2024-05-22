<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPotion = New System.Windows.Forms.Label()
        Me.cbxPotion = New System.Windows.Forms.ComboBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.nudDays = New System.Windows.Forms.NumericUpDown()
        Me.nudHours = New System.Windows.Forms.NumericUpDown()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.nudMinutes = New System.Windows.Forms.NumericUpDown()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.nudSeconds = New System.Windows.Forms.NumericUpDown()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblPotions = New System.Windows.Forms.Label()
        Me.nudPotions = New System.Windows.Forms.NumericUpDown()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnTimer = New System.Windows.Forms.Button()
        Me.tmrClock = New System.Windows.Forms.Timer(Me.components)
        Me.grpTimerMaker = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tlpUiSeperator = New System.Windows.Forms.TableLayoutPanel()
        Me.grpTimers = New System.Windows.Forms.GroupBox()
        Me.flpTimers = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCountdownName = New System.Windows.Forms.Label()
        Me.txtCountdownName = New System.Windows.Forms.TextBox()
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPotions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTimerMaker.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tlpUiSeperator.SuspendLayout()
        Me.grpTimers.SuspendLayout()
        Me.flpTimers.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPotion
        '
        Me.lblPotion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPotion.Location = New System.Drawing.Point(4, 0)
        Me.lblPotion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPotion.Name = "lblPotion"
        Me.lblPotion.Size = New System.Drawing.Size(92, 45)
        Me.lblPotion.TabIndex = 0
        Me.lblPotion.Text = "Potion Type:"
        Me.lblPotion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxPotion
        '
        Me.cbxPotion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cbxPotion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPotion.FormattingEnabled = True
        Me.cbxPotion.Items.AddRange(New Object() {""})
        Me.cbxPotion.Location = New System.Drawing.Point(104, 10)
        Me.cbxPotion.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxPotion.Name = "cbxPotion"
        Me.cbxPotion.Size = New System.Drawing.Size(219, 24)
        Me.cbxPotion.TabIndex = 1
        '
        'lblDays
        '
        Me.lblDays.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDays.Location = New System.Drawing.Point(4, 90)
        Me.lblDays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(92, 45)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Days:"
        Me.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudDays
        '
        Me.nudDays.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudDays.Location = New System.Drawing.Point(104, 101)
        Me.nudDays.Margin = New System.Windows.Forms.Padding(4)
        Me.nudDays.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.nudDays.Name = "nudDays"
        Me.nudDays.Size = New System.Drawing.Size(62, 22)
        Me.nudDays.TabIndex = 3
        '
        'nudHours
        '
        Me.nudHours.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudHours.Location = New System.Drawing.Point(104, 146)
        Me.nudHours.Margin = New System.Windows.Forms.Padding(4)
        Me.nudHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.nudHours.Name = "nudHours"
        Me.nudHours.Size = New System.Drawing.Size(62, 22)
        Me.nudHours.TabIndex = 5
        '
        'lblHours
        '
        Me.lblHours.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHours.Location = New System.Drawing.Point(4, 135)
        Me.lblHours.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(92, 45)
        Me.lblHours.TabIndex = 4
        Me.lblHours.Text = "Hours:"
        Me.lblHours.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudMinutes
        '
        Me.nudMinutes.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudMinutes.Location = New System.Drawing.Point(104, 191)
        Me.nudMinutes.Margin = New System.Windows.Forms.Padding(4)
        Me.nudMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinutes.Name = "nudMinutes"
        Me.nudMinutes.Size = New System.Drawing.Size(62, 22)
        Me.nudMinutes.TabIndex = 7
        '
        'lblMinutes
        '
        Me.lblMinutes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMinutes.Location = New System.Drawing.Point(4, 180)
        Me.lblMinutes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(92, 45)
        Me.lblMinutes.TabIndex = 6
        Me.lblMinutes.Text = "Minutes:"
        Me.lblMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudSeconds
        '
        Me.nudSeconds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudSeconds.Location = New System.Drawing.Point(104, 236)
        Me.nudSeconds.Margin = New System.Windows.Forms.Padding(4)
        Me.nudSeconds.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSeconds.Name = "nudSeconds"
        Me.nudSeconds.Size = New System.Drawing.Size(62, 22)
        Me.nudSeconds.TabIndex = 9
        '
        'lblSeconds
        '
        Me.lblSeconds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSeconds.Location = New System.Drawing.Point(4, 225)
        Me.lblSeconds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(92, 45)
        Me.lblSeconds.TabIndex = 8
        Me.lblSeconds.Text = "Seconds:"
        Me.lblSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPotions
        '
        Me.lblPotions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPotions.Location = New System.Drawing.Point(4, 45)
        Me.lblPotions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPotions.Name = "lblPotions"
        Me.lblPotions.Size = New System.Drawing.Size(92, 45)
        Me.lblPotions.TabIndex = 10
        Me.lblPotions.Text = "Quantity:"
        Me.lblPotions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'nudPotions
        '
        Me.nudPotions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.nudPotions.Location = New System.Drawing.Point(104, 56)
        Me.nudPotions.Margin = New System.Windows.Forms.Padding(4)
        Me.nudPotions.Maximum = New Decimal(New Integer() {75, 0, 0, 0})
        Me.nudPotions.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudPotions.Name = "nudPotions"
        Me.nudPotions.Size = New System.Drawing.Size(62, 22)
        Me.nudPotions.TabIndex = 11
        Me.nudPotions.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblResult
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblResult, 2)
        Me.lblResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(4, 270)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(330, 122)
        Me.lblResult.TabIndex = 12
        Me.lblResult.Text = "0 Days, 0 Hours, 0 Minutes, 0 Seconds"
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTimer
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnTimer, 2)
        Me.btnTimer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimer.Location = New System.Drawing.Point(15, 452)
        Me.btnTimer.Margin = New System.Windows.Forms.Padding(15)
        Me.btnTimer.Name = "btnTimer"
        Me.btnTimer.Size = New System.Drawing.Size(308, 121)
        Me.btnTimer.TabIndex = 13
        Me.btnTimer.Text = "Set Timer"
        Me.btnTimer.UseVisualStyleBackColor = True
        '
        'tmrClock
        '
        Me.tmrClock.Interval = 1000
        '
        'grpTimerMaker
        '
        Me.grpTimerMaker.Controls.Add(Me.TableLayoutPanel1)
        Me.grpTimerMaker.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTimerMaker.Location = New System.Drawing.Point(3, 3)
        Me.grpTimerMaker.Name = "grpTimerMaker"
        Me.grpTimerMaker.Size = New System.Drawing.Size(344, 609)
        Me.grpTimerMaker.TabIndex = 15
        Me.grpTimerMaker.TabStop = False
        Me.grpTimerMaker.Text = "Add New Timer"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblResult, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCountdownName, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.nudMinutes, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nudSeconds, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPotion, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudHours, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.nudDays, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxPotion, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudPotions, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSeconds, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDays, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPotions, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblMinutes, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblHours, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnTimer, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.txtCountdownName, 1, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(338, 588)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'tlpUiSeperator
        '
        Me.tlpUiSeperator.ColumnCount = 2
        Me.tlpUiSeperator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.tlpUiSeperator.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUiSeperator.Controls.Add(Me.grpTimerMaker, 0, 0)
        Me.tlpUiSeperator.Controls.Add(Me.grpTimers, 1, 0)
        Me.tlpUiSeperator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpUiSeperator.Location = New System.Drawing.Point(0, 0)
        Me.tlpUiSeperator.Name = "tlpUiSeperator"
        Me.tlpUiSeperator.RowCount = 1
        Me.tlpUiSeperator.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpUiSeperator.Size = New System.Drawing.Size(893, 615)
        Me.tlpUiSeperator.TabIndex = 14
        '
        'grpTimers
        '
        Me.grpTimers.Controls.Add(Me.flpTimers)
        Me.grpTimers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTimers.Location = New System.Drawing.Point(353, 3)
        Me.grpTimers.Name = "grpTimers"
        Me.grpTimers.Size = New System.Drawing.Size(537, 609)
        Me.grpTimers.TabIndex = 16
        Me.grpTimers.TabStop = False
        Me.grpTimers.Text = "Ongoing Timers"
        '
        'flpTimers
        '
        Me.flpTimers.AutoScroll = True
        Me.flpTimers.Controls.Add(Me.GroupBox1)
        Me.flpTimers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpTimers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpTimers.Location = New System.Drawing.Point(3, 18)
        Me.flpTimers.Name = "flpTimers"
        Me.flpTimers.Size = New System.Drawing.Size(531, 588)
        Me.flpTimers.TabIndex = 0
        Me.flpTimers.WrapContents = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(497, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "for Reference Purposes"
        Me.GroupBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(403, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 76)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(387, 34)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 1
        Me.ProgressBar1.Value = 50
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(491, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "364 Days, 23 Hours, 59 Minutes, 59 Seconds"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCountdownName
        '
        Me.lblCountdownName.Location = New System.Drawing.Point(4, 392)
        Me.lblCountdownName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCountdownName.Name = "lblCountdownName"
        Me.lblCountdownName.Size = New System.Drawing.Size(92, 45)
        Me.lblCountdownName.TabIndex = 14
        Me.lblCountdownName.Text = "Label:"
        Me.lblCountdownName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCountdownName
        '
        Me.txtCountdownName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtCountdownName.Location = New System.Drawing.Point(103, 403)
        Me.txtCountdownName.Name = "txtCountdownName"
        Me.txtCountdownName.Size = New System.Drawing.Size(220, 22)
        Me.txtCountdownName.TabIndex = 15
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 615)
        Me.Controls.Add(Me.tlpUiSeperator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Clash of Clans Potion Calculator"
        CType(Me.nudDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSeconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPotions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTimerMaker.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tlpUiSeperator.ResumeLayout(False)
        Me.grpTimers.ResumeLayout(False)
        Me.flpTimers.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPotion As Label
    Friend WithEvents cbxPotion As ComboBox
    Friend WithEvents lblDays As Label
    Friend WithEvents nudDays As NumericUpDown
    Friend WithEvents nudHours As NumericUpDown
    Friend WithEvents lblHours As Label
    Friend WithEvents nudMinutes As NumericUpDown
    Friend WithEvents lblMinutes As Label
    Friend WithEvents nudSeconds As NumericUpDown
    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblPotions As Label
    Friend WithEvents nudPotions As NumericUpDown
    Friend WithEvents lblResult As Label
    Friend WithEvents btnTimer As Button
    Friend WithEvents tmrClock As Timer
    Friend WithEvents grpTimerMaker As GroupBox
    Friend WithEvents tlpUiSeperator As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents grpTimers As GroupBox
    Friend WithEvents flpTimers As FlowLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCountdownName As Label
    Friend WithEvents txtCountdownName As TextBox
End Class
