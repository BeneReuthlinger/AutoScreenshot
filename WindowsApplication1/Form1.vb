Imports System
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class Form1

    ''' <summary>
    ''' timercounter
    ''' </summary>
    Private timercounter As Integer = 0

    ''' <summary>
    ''' bitmap
    ''' </summary>
    Private b As Bitmap = Nothing

    ''' <summary>
    ''' Screenshot erstellen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_start.Click
        Try
            Me.ProgressBar1.Maximum = CInt(txt_interval.Text)
        Catch ex As Exception
            logbox.Items.Add("C: " & ex.Message)
        End Try

        starttimer()
    End Sub

    ''' <summary>
    ''' Stop Button klicken
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        stoptimer()
    End Sub

    ''' <summary>
    ''' Timer starten
    ''' </summary>
    Private Sub starttimer()
        Try
            Me.Timer1.Enabled = True
            Me.ProgressBar1.Visible = True
        Catch ex As Exception
            logbox.Items.Add("A: " & ex.Message)
        End Try

        start()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub stoptimer()
        Me.Timer1.Enabled = False
        Me.ProgressBar1.Visible = False
    End Sub

    ''' <summary>
    ''' Screenshot erstellen und speichern
    ''' </summary>
    Private Sub start()
        If System.IO.Directory.Exists(txt_ordner.Text) Then
            Dim jgpEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)
            Dim myEncoder As System.Drawing.Imaging.Encoder = System.Drawing.Imaging.Encoder.Quality
            Dim myEncoderParameters As New EncoderParameters(1)
            Dim myEncoderParameter As New EncoderParameter(myEncoder, 10&)
            myEncoderParameters.Param(0) = myEncoderParameter

            Try
                Dim b As Bitmap = New Bitmap(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height)
                Dim g As Graphics = Graphics.FromImage(b)
                Dim myzfolder As String = Me.txt_ordner.Text.TrimEnd(CChar("\")) & "\" & My.Computer.Clock.LocalTime.Date.Year & "-" & My.Computer.Clock.LocalTime.Date.Month & "-" & My.Computer.Clock.LocalTime.Date.Day
                My.Computer.FileSystem.CreateDirectory(myzfolder)

                g.CopyFromScreen(SystemInformation.VirtualScreen.X, SystemInformation.VirtualScreen.Y, 0, 0, b.Size)
                g.Dispose()
                b.Save(myzfolder & "\" & DateTime.Now.ToString("yyyyMMdd-HHmmss") & ".jpg", jgpEncoder, myEncoderParameters)
                b.Dispose()
            Catch ex As Exception
                logbox.Items.Add("E: " & ex.Message)
            End Try
        Else
            MsgBox("Ziel-Ordner existiert nicht")
            stoptimer()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_openfd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_openfd.Click
        Dim a As System.Windows.Forms.DialogResult = FolderBrowserDialog1.ShowDialog
        If a = System.Windows.Forms.DialogResult.OK Then
            Me.txt_ordner.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.speicherpfad = Me.txt_ordner.Text
            My.Settings.Save()
        End If
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btn_hide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hide.Click
        Me.Visible = False
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Visible = True
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            If timercounter = CInt(txt_interval.Text) Then
                timercounter = 0
                start()

                System.GC.Collect()
            End If
        Catch ex As Exception
            logbox.Items.Add("B: " & ex.Message)
        End Try

        timercounter = timercounter + 1
        ProgressBar1.Value = timercounter
    End Sub

    ''' <summary>
    ''' beim Formular laden
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Interval = 1000
        Me.txt_ordner.Text = My.Settings.speicherpfad
    End Sub

    ''' <summary>
    ''' Encoder für Bildkonvertierung
    ''' </summary>
    ''' <param name="format"></param>
    ''' <returns></returns>
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo
        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then
                Return codec
            End If
        Next codec
        Return Nothing
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
    End Sub
End Class
