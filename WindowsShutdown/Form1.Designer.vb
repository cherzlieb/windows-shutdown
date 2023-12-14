<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_note_00 = New System.Windows.Forms.TextBox()
        Me.line_04 = New System.Windows.Forms.Label()
        Me.txt_EA_time_rest = New System.Windows.Forms.TextBox()
        Me.txt_time_rest = New System.Windows.Forms.TextBox()
        Me.line_03 = New System.Windows.Forms.Label()
        Me.line_01 = New System.Windows.Forms.Label()
        Me.line_02 = New System.Windows.Forms.Label()
        Me.line_00 = New System.Windows.Forms.Label()
        Me.txt_Contdown_stop = New System.Windows.Forms.TextBox()
        Me.txt_Contdown_start = New System.Windows.Forms.TextBox()
        Me.num_seconds = New System.Windows.Forms.NumericUpDown()
        Me.num_minutes = New System.Windows.Forms.NumericUpDown()
        Me.num_hours = New System.Windows.Forms.NumericUpDown()
        Me.txt_seconds = New System.Windows.Forms.TextBox()
        Me.txt_EA_time_shutdown = New System.Windows.Forms.TextBox()
        Me.txt_time_shutdown = New System.Windows.Forms.TextBox()
        Me.txt_EA_win_time = New System.Windows.Forms.TextBox()
        Me.txt_win_time = New System.Windows.Forms.TextBox()
        Me.txt_hours = New System.Windows.Forms.TextBox()
        Me.txt_minutes = New System.Windows.Forms.TextBox()
        Me.txt_windows_shutdown_question = New System.Windows.Forms.TextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Timer01 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_start = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.num_seconds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_minutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_hours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_note_00
        '
        Me.txt_note_00.BackColor = System.Drawing.SystemColors.Control
        Me.txt_note_00.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_note_00, "txt_note_00")
        Me.txt_note_00.ForeColor = System.Drawing.Color.Red
        Me.txt_note_00.Name = "txt_note_00"
        Me.txt_note_00.ReadOnly = True
        '
        'line_04
        '
        Me.line_04.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.line_04, "line_04")
        Me.line_04.Name = "line_04"
        '
        'txt_EA_time_rest
        '
        Me.txt_EA_time_rest.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Me.txt_EA_time_rest, "txt_EA_time_rest")
        Me.txt_EA_time_rest.Name = "txt_EA_time_rest"
        Me.txt_EA_time_rest.ReadOnly = True
        '
        'txt_time_rest
        '
        Me.txt_time_rest.BackColor = System.Drawing.SystemColors.Control
        Me.txt_time_rest.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_time_rest, "txt_time_rest")
        Me.txt_time_rest.Name = "txt_time_rest"
        Me.txt_time_rest.ReadOnly = True
        '
        'line_03
        '
        Me.line_03.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.line_03, "line_03")
        Me.line_03.Name = "line_03"
        '
        'line_01
        '
        Me.line_01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.line_01, "line_01")
        Me.line_01.Name = "line_01"
        '
        'line_02
        '
        Me.line_02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.line_02, "line_02")
        Me.line_02.Name = "line_02"
        '
        'line_00
        '
        Me.line_00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        resources.ApplyResources(Me.line_00, "line_00")
        Me.line_00.Name = "line_00"
        '
        'txt_Contdown_stop
        '
        Me.txt_Contdown_stop.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Contdown_stop.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_Contdown_stop, "txt_Contdown_stop")
        Me.txt_Contdown_stop.Name = "txt_Contdown_stop"
        Me.txt_Contdown_stop.ReadOnly = True
        '
        'txt_Contdown_start
        '
        Me.txt_Contdown_start.BackColor = System.Drawing.SystemColors.Control
        Me.txt_Contdown_start.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_Contdown_start, "txt_Contdown_start")
        Me.txt_Contdown_start.Name = "txt_Contdown_start"
        Me.txt_Contdown_start.ReadOnly = True
        '
        'num_seconds
        '
        resources.ApplyResources(Me.num_seconds, "num_seconds")
        Me.num_seconds.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_seconds.Name = "num_seconds"
        '
        'num_minutes
        '
        resources.ApplyResources(Me.num_minutes, "num_minutes")
        Me.num_minutes.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_minutes.Name = "num_minutes"
        '
        'num_hours
        '
        resources.ApplyResources(Me.num_hours, "num_hours")
        Me.num_hours.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.num_hours.Name = "num_hours"
        '
        'txt_seconds
        '
        Me.txt_seconds.BackColor = System.Drawing.SystemColors.Control
        Me.txt_seconds.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_seconds, "txt_seconds")
        Me.txt_seconds.Name = "txt_seconds"
        Me.txt_seconds.ReadOnly = True
        '
        'txt_EA_time_shutdown
        '
        Me.txt_EA_time_shutdown.BackColor = System.Drawing.SystemColors.ControlLight
        resources.ApplyResources(Me.txt_EA_time_shutdown, "txt_EA_time_shutdown")
        Me.txt_EA_time_shutdown.Name = "txt_EA_time_shutdown"
        Me.txt_EA_time_shutdown.ReadOnly = True
        '
        'txt_time_shutdown
        '
        Me.txt_time_shutdown.BackColor = System.Drawing.SystemColors.Control
        Me.txt_time_shutdown.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_time_shutdown, "txt_time_shutdown")
        Me.txt_time_shutdown.Name = "txt_time_shutdown"
        Me.txt_time_shutdown.ReadOnly = True
        '
        'txt_EA_win_time
        '
        Me.txt_EA_win_time.BackColor = System.Drawing.SystemColors.Control
        Me.txt_EA_win_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txt_EA_win_time, "txt_EA_win_time")
        Me.txt_EA_win_time.Name = "txt_EA_win_time"
        Me.txt_EA_win_time.ReadOnly = True
        '
        'txt_win_time
        '
        Me.txt_win_time.BackColor = System.Drawing.SystemColors.Control
        Me.txt_win_time.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_win_time, "txt_win_time")
        Me.txt_win_time.Name = "txt_win_time"
        Me.txt_win_time.ReadOnly = True
        '
        'txt_hours
        '
        Me.txt_hours.BackColor = System.Drawing.SystemColors.Control
        Me.txt_hours.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_hours, "txt_hours")
        Me.txt_hours.Name = "txt_hours"
        Me.txt_hours.ReadOnly = True
        '
        'txt_minutes
        '
        Me.txt_minutes.BackColor = System.Drawing.SystemColors.Control
        Me.txt_minutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_minutes, "txt_minutes")
        Me.txt_minutes.Name = "txt_minutes"
        Me.txt_minutes.ReadOnly = True
        '
        'txt_windows_shutdown_question
        '
        Me.txt_windows_shutdown_question.BackColor = System.Drawing.SystemColors.Control
        Me.txt_windows_shutdown_question.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txt_windows_shutdown_question, "txt_windows_shutdown_question")
        Me.txt_windows_shutdown_question.Name = "txt_windows_shutdown_question"
        Me.txt_windows_shutdown_question.ReadOnly = True
        '
        'btn_cancel
        '
        resources.ApplyResources(Me.btn_cancel, "btn_cancel")
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Timer01
        '
        '
        'btn_start
        '
        resources.ApplyResources(Me.btn_start, "btn_start")
        Me.btn_start.Name = "btn_start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txt_note_00)
        Me.Controls.Add(Me.line_04)
        Me.Controls.Add(Me.txt_EA_time_rest)
        Me.Controls.Add(Me.txt_time_rest)
        Me.Controls.Add(Me.line_03)
        Me.Controls.Add(Me.line_01)
        Me.Controls.Add(Me.line_02)
        Me.Controls.Add(Me.line_00)
        Me.Controls.Add(Me.txt_Contdown_stop)
        Me.Controls.Add(Me.txt_Contdown_start)
        Me.Controls.Add(Me.num_seconds)
        Me.Controls.Add(Me.num_minutes)
        Me.Controls.Add(Me.num_hours)
        Me.Controls.Add(Me.txt_seconds)
        Me.Controls.Add(Me.txt_EA_time_shutdown)
        Me.Controls.Add(Me.txt_time_shutdown)
        Me.Controls.Add(Me.txt_EA_win_time)
        Me.Controls.Add(Me.txt_win_time)
        Me.Controls.Add(Me.txt_hours)
        Me.Controls.Add(Me.txt_minutes)
        Me.Controls.Add(Me.txt_windows_shutdown_question)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_start)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        CType(Me.num_seconds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_minutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_hours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_note_00 As System.Windows.Forms.TextBox
    Friend WithEvents line_04 As System.Windows.Forms.Label
    Friend WithEvents txt_EA_time_rest As System.Windows.Forms.TextBox
    Friend WithEvents txt_time_rest As System.Windows.Forms.TextBox
    Friend WithEvents line_03 As System.Windows.Forms.Label
    Friend WithEvents line_01 As System.Windows.Forms.Label
    Friend WithEvents line_02 As System.Windows.Forms.Label
    Friend WithEvents line_00 As System.Windows.Forms.Label
    Friend WithEvents txt_Contdown_stop As System.Windows.Forms.TextBox
    Friend WithEvents txt_Contdown_start As System.Windows.Forms.TextBox
    Friend WithEvents num_seconds As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_minutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents num_hours As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_seconds As System.Windows.Forms.TextBox
    Friend WithEvents txt_EA_time_shutdown As System.Windows.Forms.TextBox
    Friend WithEvents txt_time_shutdown As System.Windows.Forms.TextBox
    Friend WithEvents txt_EA_win_time As System.Windows.Forms.TextBox
    Friend WithEvents txt_win_time As System.Windows.Forms.TextBox
    Friend WithEvents txt_hours As System.Windows.Forms.TextBox
    Friend WithEvents txt_minutes As System.Windows.Forms.TextBox
    Friend WithEvents txt_windows_shutdown_question As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Timer01 As System.Windows.Forms.Timer
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar

End Class
