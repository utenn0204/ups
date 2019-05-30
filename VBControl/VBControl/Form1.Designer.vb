<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.modeview = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.Label()
        Me.EndButton = New System.Windows.Forms.Button()
        Me.DownButton = New System.Windows.Forms.Button()
        Me.UpButton = New System.Windows.Forms.Button()
        Me.lowestcharging = New System.Windows.Forms.Label()
        Me.highestcharging = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ModeButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.X_Combo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.clickreturn = New System.Windows.Forms.Timer(Me.components)
        Me.shutdownscan = New System.Windows.Forms.Timer(Me.components)
        Me.DebugTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(216, 48)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "P0:充電模式切換(自動充電模式C，勿動)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P1:下限電壓調整" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P2:上限電壓調整" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P3:自動倒數計時(無規劃使用)"
        '
        'modeview
        '
        Me.modeview.AutoSize = True
        Me.modeview.Location = New System.Drawing.Point(133, 240)
        Me.modeview.Name = "modeview"
        Me.modeview.Size = New System.Drawing.Size(0, 12)
        Me.modeview.TabIndex = 62
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(47, 240)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(80, 24)
        Me.status.TabIndex = 61
        Me.status.Text = "當前切換狀況:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'EndButton
        '
        Me.EndButton.Location = New System.Drawing.Point(331, 303)
        Me.EndButton.Name = "EndButton"
        Me.EndButton.Size = New System.Drawing.Size(75, 23)
        Me.EndButton.TabIndex = 60
        Me.EndButton.Text = "關閉"
        Me.EndButton.UseVisualStyleBackColor = True
        '
        'DownButton
        '
        Me.DownButton.Location = New System.Drawing.Point(222, 303)
        Me.DownButton.Name = "DownButton"
        Me.DownButton.Size = New System.Drawing.Size(82, 23)
        Me.DownButton.TabIndex = 59
        Me.DownButton.Text = "下降/下一個"
        Me.DownButton.UseVisualStyleBackColor = True
        '
        'UpButton
        '
        Me.UpButton.Location = New System.Drawing.Point(117, 303)
        Me.UpButton.Name = "UpButton"
        Me.UpButton.Size = New System.Drawing.Size(89, 23)
        Me.UpButton.TabIndex = 58
        Me.UpButton.Text = "增加/上一個"
        Me.UpButton.UseVisualStyleBackColor = True
        '
        'lowestcharging
        '
        Me.lowestcharging.AutoEllipsis = True
        Me.lowestcharging.AutoSize = True
        Me.lowestcharging.Location = New System.Drawing.Point(47, 217)
        Me.lowestcharging.Name = "lowestcharging"
        Me.lowestcharging.Size = New System.Drawing.Size(80, 12)
        Me.lowestcharging.TabIndex = 57
        Me.lowestcharging.Text = "充電下限電壓:"
        '
        'highestcharging
        '
        Me.highestcharging.AutoEllipsis = True
        Me.highestcharging.AutoSize = True
        Me.highestcharging.Location = New System.Drawing.Point(47, 194)
        Me.highestcharging.Name = "highestcharging"
        Me.highestcharging.Size = New System.Drawing.Size(80, 12)
        Me.highestcharging.TabIndex = 56
        Me.highestcharging.Text = "充電上限電壓:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "切換功能"
        '
        'ModeButton
        '
        Me.ModeButton.Location = New System.Drawing.Point(23, 303)
        Me.ModeButton.Name = "ModeButton"
        Me.ModeButton.Size = New System.Drawing.Size(75, 23)
        Me.ModeButton.TabIndex = 54
        Me.ModeButton.Text = "模式切換"
        Me.ModeButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 12)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "電壓:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 12)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "UPS系統狀況:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "傳輸率"
        '
        'X_Combo
        '
        Me.X_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.X_Combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X_Combo.FormattingEnabled = True
        Me.X_Combo.Items.AddRange(New Object() {"9600", "19200", "38400"})
        Me.X_Combo.Location = New System.Drawing.Point(26, 108)
        Me.X_Combo.Name = "X_Combo"
        Me.X_Combo.Size = New System.Drawing.Size(121, 28)
        Me.X_Combo.TabIndex = 50
        Me.X_Combo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 49
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(149, 21)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(81, 20)
        Me.Timer_LBL.TabIndex = 48
        Me.Timer_LBL.Text = "連接: OFF"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(26, 46)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.comPort_ComboBox.TabIndex = 45
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(22, 21)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(89, 20)
        Me.COMport_LBL.TabIndex = 44
        Me.COMport_LBL.Text = "連接傳送埠"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(153, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "資料"
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(153, 46)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(120, 30)
        Me.connect_BTN.TabIndex = 46
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 999
        '
        'clickreturn
        '
        Me.clickreturn.Interval = 8000
        '
        'shutdownscan
        '
        Me.shutdownscan.Interval = 10000
        '
        'DebugTimer
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 366)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.modeview)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.EndButton)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.lowestcharging)
        Me.Controls.Add(Me.highestcharging)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ModeButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.X_Combo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.COMport_LBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.connect_BTN)
        Me.Name = "Form1"
        Me.Text = "UPS監控"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents modeview As Label
    Friend WithEvents status As Label
    Friend WithEvents EndButton As Button
    Friend WithEvents DownButton As Button
    Friend WithEvents UpButton As Button
    Friend WithEvents lowestcharging As Label
    Friend WithEvents highestcharging As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ModeButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents X_Combo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents COMport_LBL As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents connect_BTN As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents clickreturn As Timer
    Friend WithEvents shutdownscan As Timer
    Friend WithEvents DebugTimer As Timer
End Class
