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
        Me.btn_start = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txt_ordner = New System.Windows.Forms.TextBox()
        Me.btn_openfd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_interval = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.btn_hide = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.logbox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(253, 79)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(87, 24)
        Me.btn_start.TabIndex = 0
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'txt_ordner
        '
        Me.txt_ordner.Location = New System.Drawing.Point(12, 34)
        Me.txt_ordner.Name = "txt_ordner"
        Me.txt_ordner.Size = New System.Drawing.Size(381, 20)
        Me.txt_ordner.TabIndex = 1
        Me.txt_ordner.Text = "E:\Screenshots"
        '
        'btn_openfd
        '
        Me.btn_openfd.Location = New System.Drawing.Point(399, 31)
        Me.btn_openfd.Name = "btn_openfd"
        Me.btn_openfd.Size = New System.Drawing.Size(34, 23)
        Me.btn_openfd.TabIndex = 2
        Me.btn_openfd.Text = "..."
        Me.btn_openfd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ordner:"
        '
        'txt_interval
        '
        Me.txt_interval.Location = New System.Drawing.Point(12, 81)
        Me.txt_interval.Name = "txt_interval"
        Me.txt_interval.Size = New System.Drawing.Size(105, 20)
        Me.txt_interval.TabIndex = 4
        Me.txt_interval.Text = "60"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Intervall (Sekunden):"
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "AutoScreenshot"
        Me.NotifyIcon1.Visible = True
        '
        'btn_hide
        '
        Me.btn_hide.Location = New System.Drawing.Point(253, 122)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(180, 23)
        Me.btn_hide.TabIndex = 6
        Me.btn_hide.Text = "Hide"
        Me.btn_hide.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 122)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(118, 23)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Visible = False
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(346, 79)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(87, 24)
        Me.btn_stop.TabIndex = 8
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'logbox
        '
        Me.logbox.FormattingEnabled = True
        Me.logbox.Location = New System.Drawing.Point(12, 157)
        Me.logbox.Name = "logbox"
        Me.logbox.Size = New System.Drawing.Size(421, 69)
        Me.logbox.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 233)
        Me.Controls.Add(Me.logbox)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_interval)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_openfd)
        Me.Controls.Add(Me.txt_ordner)
        Me.Controls.Add(Me.btn_start)
        Me.Name = "Form1"
        Me.Text = "Auto-Screenshots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txt_ordner As System.Windows.Forms.TextBox
    Friend WithEvents btn_openfd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_interval As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents btn_hide As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents logbox As System.Windows.Forms.ListBox

End Class
