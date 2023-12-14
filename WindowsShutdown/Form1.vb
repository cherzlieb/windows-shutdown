Public Class Form1

#Region "~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Globale Variablendeklaration ~~~~~~~~~~~~~~~~~~~~~~~~~~~~"
    Dim WindowsLaufzeit As TimeSpan             'Windows-CPU-Laufzeit TickCount
    Dim WinDays As String                       'Windows-CPU-Laufzeit Tage
    Dim WinHours As String                      'Windows-CPU-Laufzeit Stunden
    Dim WinMinutes As String                    'Windows-CPU-Laufzeit Minuten
    Dim WinSeconds As String                    'Windows-CPU-Laufzeit Sekunden

    Dim seconds As Int32                        'Zeiteinstellung über num_seconds
    Dim minutes As Int32                        'Zeiteinstellung über num_minutes 
    Dim hours As Int32                          'Zeiteinstellung über num_hours
    Dim time_shutdown As Int32                  'Zusammengerechnete Sekunden für den cmd-Befehl

    Dim cmd As New ProcessStartInfo("cmd.exe")  'Sub: btn_start_Click,
    Dim time_counter As Date
    Dim timer_start As Boolean
    Dim zaehler As Int32
#End Region

#Region "Timer01: Dieser Timer wird einmal pro Sekunde ausgelöst"
    Private Sub Timer01_Tick(sender As Object, e As EventArgs) Handles Me.Load
        Timer01.Interval = 1000 ' 1000ms = 1 Sekunde, nun wird jede Sekunde aktualisiert
        Timer01.Start()
    End Sub
#End Region

#Region "txt_WindowsLaufzeit: Auslesen der CPU Laufzeit und ausgeben in txt_WinLaufzeit"
    Private Sub txt_WindowsLaufzeit(sender As Object, e As EventArgs) Handles Timer01.Tick
        WindowsLaufzeit = TimeSpan.FromMilliseconds(My.Computer.Clock.TickCount)

        If Debugger.IsAttached Then
            Debug.Print(WindowsLaufzeit.ToString)
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Formatierung der Tage ~~~~~~~~~~~~~~~~~~~~~~~~~~~
        If WindowsLaufzeit.Days < 10 Then
            WinDays = "0" & WindowsLaufzeit.Days
        Else
            WinDays = WindowsLaufzeit.Days
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~ Formatierung der Stunden ~~~~~~~~~~~~~~~~~~~~~~~~~
        If WindowsLaufzeit.Hours < 10 Then
            WinHours = "0" & WindowsLaufzeit.Hours
        Else
            WinHours = WindowsLaufzeit.Hours
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~ Formatierung der Minuten ~~~~~~~~~~~~~~~~~~~~~~~~~
        If WindowsLaufzeit.Minutes < 10 Then
            WinMinutes = "0" & WindowsLaufzeit.Minutes
        Else
            WinMinutes = WindowsLaufzeit.Minutes
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~ Formatierung der Sekunden ~~~~~~~~~~~~~~~~~~~~~~~~~
        If WindowsLaufzeit.Seconds < 10 Then
            WinSeconds = "0" & WindowsLaufzeit.Seconds
        Else
            WinSeconds = WindowsLaufzeit.Seconds
        End If

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Variablendeklaration ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        txt_EA_win_time.Text = WinDays & " Tage, " & WinHours & " h, " & WinMinutes & " min, " & WinSeconds & " sec."
    End Sub
#End Region

#Region "txt_EA_time_shutdown_TextChanged: Hier wird der Wert bei Änderung von den Eingabefeldern umgerechnet in Sekunden und ausgegeben in txt_WinLaufzeit"
    Private Sub txt_EA_time_shutdown_TextChanged(sender As Object, e As EventArgs) Handles num_seconds.ValueChanged, num_minutes.ValueChanged, num_hours.ValueChanged
        '~~~~~~~~~~~~~~~~~~~~~~~~~~ Umrechnungen in Sekunden ~~~~~~~~~~~~~~~~~~~~~~~~~~
        seconds = num_seconds.Value
        minutes = num_minutes.Value * 60
        hours = num_hours.Value * 60 * 60

        '~~~~~~~ Die Zeit als Sekunden in die Variable "time_shutdown" schreiben ~~~~~~
        time_shutdown = seconds + minutes + hours
        ProgressBar1.Maximum = time_shutdown

        '~~~~~~~~~~~~~~~~ Ausgeben der Shutdown Zeit in txt_WinLaufzeit ~~~~~~~~~~~~~~~
        txt_EA_time_shutdown.Text = (time_shutdown & " sec.")
    End Sub
#End Region

#Region "btn_start_Click: Herunterfahren wird gestartet!"
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Prozesseinstellungen ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        cmd.Arguments = "/k shutdown -s -t " & time_shutdown
        cmd.WindowStyle = ProcessWindowStyle.Hidden

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Prozess starten ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Process.Start(cmd)

        time_counter = Now
        time_counter = time_counter.AddSeconds(num_seconds.Value)
        time_counter = time_counter.AddMinutes(num_minutes.Value)
        time_counter = time_counter.AddHours(num_hours.Value)

        timer_start = True
    End Sub
#End Region

#Region "btn_cancel_Click: Herunterfahren wird abgebrochen!"
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Prozesseinstellungen ~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        cmd.Arguments = "/k shutdown -a "
        cmd.WindowStyle = ProcessWindowStyle.Hidden

        '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Prozess starten ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        Process.Start(cmd)

        timer_start = False
    End Sub
#End Region

#Region "txt_EA_time_rest_TextChanged: Berechnung der Restzeit bis zum runterfahren des PC´s"
    Private Sub txt_EA_time_rest_TextChanged(sender As Object, e As EventArgs) Handles Timer01.Tick
        If timer_start = True Then
            txt_EA_time_rest.Text = Strings.Left((time_counter - Now).ToString, Strings.Len((time_counter - Now).ToString) - 8)
            zaehler += 1
        Else
            txt_EA_time_rest.Text = ""
            zaehler = 0
        End If
        If zaehler <= ProgressBar1.Maximum Then
            ProgressBar1.Value = zaehler
        Else
            ProgressBar1.Value = 0
        End If
    End Sub
#End Region

End Class
