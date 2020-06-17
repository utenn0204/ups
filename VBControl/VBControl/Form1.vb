Imports System
Imports System.IO.Ports
Imports System.Text
Public Class Form1
    Dim comPORT As String
    Dim receivedData As String = ""
    Dim rate As String
    Dim lasthigh As String, lastlow As String
    Dim high As String, low As String
    Dim clear As String, temp As String
    Dim scandata As Double
    Dim debug As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        comPORT = ""
        clear = ""
        If My.Computer.FileSystem.DirectoryExists("C:\UPSVoltagesettings") = False Then
            My.Computer.FileSystem.CreateDirectory("C:\UPSVoltagesettings")
        End If
        If System.IO.File.Exists("C:\UPSVoltagesettings\config.txt") Then
            FileOpen(1, "C:\UPSVoltagesettings\config.txt", OpenMode.Input)
            high = LineInput(1)
            low = LineInput(1)
            FileClose(1)
            highestcharging.Text = "充電上限電壓:" & high
            lowestcharging.Text = "充電下限電壓:" & low
            modeview.Text = "無"
        Else
            high = 14.1
            low = 12
            temp = high & vbNewLine & low
            System.IO.File.AppendAllText("C:\UPSVoltagesettings\config.txt", temp)
            highestcharging.Text = "充電上限電壓:" & high
            lowestcharging.Text = "充電下限電壓:" & low
            modeview.Text = "無"
        End If
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
    End Sub
    Private Sub X_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles X_Combo.SelectedIndexChanged
        rate = X_Combo.SelectedItem
    End Sub
    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub
    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = rate
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default
                SerialPort1.ReadTimeout = 10000
                'USB通訊
                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                Timer1.Enabled = True '計時器同步啟動
                Timer2.Enabled = True
                Timer_LBL.Text = "Timer: ON"
                shutdownscan.Enabled = True
            Else
                MsgBox("Select a COM port first")
            End If
        Else
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            Timer1.Enabled = False
            Timer2.Enabled = False
            shutdownscan.Enabled = False
            Timer_LBL.Text = "Timer: OFF"
            Label2.Text = ""
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        receivedData = ReceiveSerialData()
        Label2.Text &= receivedData
    End Sub
    Function ReceiveSerialData() As String
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try
    End Function
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = "" '同步輸入新的電壓且清除
    End Sub
    Private Sub ModeButton_Click(sender As Object, e As EventArgs) Handles ModeButton.Click
        clickreturn.Enabled = False
        Dim cont As String
        If (modeview.Text = "無") Then
            cont = "m"
            SerialPort1.Write(cont)
            modeview.Text = "P0"
        ElseIf (modeview.Text = "P0") Then
            MsgBox("不可操作!")
        ElseIf (modeview.Text = "P3") Then
            MsgBox("不可操作!")
        ElseIf (modeview.Text = "P1") Then
            cont = "m"
            SerialPort1.Write(cont)
            modeview.Text = "P1設定中"
        ElseIf (modeview.Text = "P2") Then
            cont = "m"
            SerialPort1.Write(cont)
            modeview.Text = "P2設定中"
        ElseIf (modeview.Text = "P1設定中") Then
            cont = "m"
            SerialPort1.Write(cont)
            modeview.Text = "P1"
        ElseIf (modeview.Text = "P2設定中") Then
            cont = "m"
            SerialPort1.Write(cont)
            modeview.Text = "P2"
        End If
        clickreturn.Enabled = True '啟動延遲歸位計時器
    End Sub
    Private Sub UpButton_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        clickreturn.Enabled = False
        Dim cont As String
        If (modeview.Text = "P0") Then
            cont = "u"
            SerialPort1.Write(cont)
            modeview.Text = "P1"
        ElseIf (modeview.Text = "P1") Then
            cont = "u"
            SerialPort1.Write(cont)
            modeview.Text = "P2"
        ElseIf (modeview.Text = "P2") Then
            cont = "u"
            SerialPort1.Write(cont)
            modeview.Text = "P3"
        ElseIf (modeview.Text = "P3") Then
            cont = "u"
            SerialPort1.Write(cont)
            modeview.Text = "P0"
        End If
        If (modeview.Text = "P1設定中") Then
            If (low <= 12.5) Then
                cont = "u"
                SerialPort1.Write(cont)
                low = low + 0.1
                lowestcharging.Text = "充電下限電壓:" & low
                FileOpen(1, "C:\UPSVoltagesettings\config.txt", OpenMode.Output)
                lastlow = vbNewLine & low
                Print(1, clear)
                Print(1, high)
                PrintLine(1, lastlow)
                FileClose(1)
            Else
                MsgBox("低電壓過高，將導致過充!")
            End If
        End If
        lastlow = vbNewLine & low
        If (modeview.Text = "P2設定中") Then
            If (high < 14.5) Then
                cont = "u"
                SerialPort1.Write(cont)
                high = high + 0.1
                highestcharging.Text = "充電上限電壓:" & high
                FileOpen(1, "C:\UPSVoltagesettings\config.txt", OpenMode.Output)
                lastlow = vbNewLine & low
                Print(1, clear)
                Print(1, high)
                PrintLine(1, lastlow)
                FileClose(1)
            Else
                MsgBox("高電壓過高，將導致過充!")
            End If
        End If
        clickreturn.Enabled = True '啟動延遲歸位計時器
    End Sub
    Private Sub DownButton_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        clickreturn.Enabled = False
        Dim cont As String
        If (modeview.Text = "P0") Then
            cont = "d"
            SerialPort1.Write(cont)
            modeview.Text = "P3"
        ElseIf (modeview.Text = "P3") Then
            cont = "d"
            SerialPort1.Write(cont)
            modeview.Text = "P2"
        ElseIf (modeview.Text = "P2") Then
            cont = "d"
            SerialPort1.Write(cont)
            modeview.Text = "P1"
        ElseIf (modeview.Text = "P1") Then
            cont = "d"
            SerialPort1.Write(cont)
            modeview.Text = "P0"
        End If
        If (modeview.Text = "P1設定中") Then
            If (low > 11.5) Then
                cont = "d"
                SerialPort1.Write(cont)
                low = low - 0.1
                lowestcharging.Text = "充電下限電壓:" & low
                FileOpen(1, "C:\UPSVoltagesettings\config.txt", OpenMode.Output)
                lastlow = vbNewLine & low
                Print(1, clear)
                Print(1, high)
                PrintLine(1, lastlow)
                FileClose(1)
            Else
                MsgBox("低電壓過低，將導致過放!")
            End If
        End If
        If (modeview.Text = "P2設定中") Then
            If (high > 13.0) Then
                cont = "d"
                SerialPort1.Write(cont)
                high = high - 0.1
                highestcharging.Text = "充電上限電壓:" & high
                FileOpen(1, "C:\UPSVoltagesettings\config.txt", OpenMode.Output)
                lastlow = vbNewLine & low
                Print(1, clear)
                Print(1, high)
                PrintLine(1, lastlow)
                FileClose(1)
            Else
                MsgBox("高電壓過低，將導致過放!")
            End If
        End If
        clickreturn.Enabled = True '啟動延遲歸位計時器
    End Sub
    Private Sub DebugTimer_Tick(sender As Object, e As EventArgs) Handles DebugTimer.Tick
        If shutdownscan.Enabled = False Then
            temp = Label2.Text
            debug = Val(temp)
            If (debug > 10) Then
                Shell("cmd.exe /C shutdown -a")
                DebugTimer.Enabled = False
                shutdownscan.Enabled = True
            End If
        End If
    End Sub
    Private Sub clickreturn_Tick(sender As Object, e As EventArgs) Handles clickreturn.Tick
        modeview.Text = "無" '歸位
        clickreturn.Enabled = False '關閉計時器
    End Sub
    Private Sub shutdownscan_Tick(sender As Object, e As EventArgs) Handles shutdownscan.Tick
        Dim temp1 As Double
        temp = Label2.Text
        temp1 = Val(temp)
        If (temp1 < "10" Or temp1 = " ") Then
            temp1 = "12"
        End If
        scandata = temp1
        If (scandata < 11 And scandata > 10) Then
            Shell("cmd.exe /C shutdown -s -t 60")
            DebugTimer.Enabled = True
            shutdownscan.Enabled = False
        End If
    End Sub
    Private Sub EndButton_Click(sender As Object, e As EventArgs) Handles EndButton.Click
        Shell("cmd.exe /C shutdown -a")
        End
    End Sub
End Class
