Imports System.IO

Public Class Main_Screen
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Overwrite_Data As System.Windows.Forms.CheckBox
    Friend WithEvents IUser_counter As System.Windows.Forms.TextBox
    Friend WithEvents End_Position As System.Windows.Forms.TextBox
    Friend WithEvents Start_Position As System.Windows.Forms.TextBox
    Friend WithEvents Line_Pattern As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents bootconfig_file As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents save_directory As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents MAC_Address_Length As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBar_Right As System.Windows.Forms.Label
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main_Screen))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.bootconfig_file = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Line_Pattern = New System.Windows.Forms.TextBox
        Me.End_Position = New System.Windows.Forms.TextBox
        Me.Start_Position = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.IUser_counter = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.save_directory = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.Overwrite_Data = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Label10 = New System.Windows.Forms.Label
        Me.MAC_Address_Length = New System.Windows.Forms.TextBox
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBar_Right = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'bootconfig_file
        '
        Me.bootconfig_file.Location = New System.Drawing.Point(192, 24)
        Me.bootconfig_file.Name = "bootconfig_file"
        Me.bootconfig_file.Size = New System.Drawing.Size(224, 20)
        Me.bootconfig_file.TabIndex = 0
        Me.bootconfig_file.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "File to Parse for MAC Addresses:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Line Pattern:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "MAC String Position:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Line_Pattern
        '
        Me.Line_Pattern.Location = New System.Drawing.Point(192, 56)
        Me.Line_Pattern.Name = "Line_Pattern"
        Me.Line_Pattern.Size = New System.Drawing.Size(304, 20)
        Me.Line_Pattern.TabIndex = 4
        Me.Line_Pattern.Text = "0x110"
        '
        'End_Position
        '
        Me.End_Position.Location = New System.Drawing.Point(384, 88)
        Me.End_Position.Name = "End_Position"
        Me.End_Position.Size = New System.Drawing.Size(32, 20)
        Me.End_Position.TabIndex = 5
        Me.End_Position.Text = "21"
        '
        'Start_Position
        '
        Me.Start_Position.Location = New System.Drawing.Point(272, 88)
        Me.Start_Position.Name = "Start_Position"
        Me.Start_Position.Size = New System.Drawing.Size(32, 20)
        Me.Start_Position.TabIndex = 6
        Me.Start_Position.Text = "10"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(192, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Start Position:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(312, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "End Position:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "IUser Counter:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(192, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Start From:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IUser_counter
        '
        Me.IUser_counter.Location = New System.Drawing.Point(256, 144)
        Me.IUser_counter.Name = "IUser_counter"
        Me.IUser_counter.Size = New System.Drawing.Size(32, 20)
        Me.IUser_counter.TabIndex = 11
        Me.IUser_counter.Text = "21"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Folder to Create Output:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'save_directory
        '
        Me.save_directory.Location = New System.Drawing.Point(192, 176)
        Me.save_directory.Name = "save_directory"
        Me.save_directory.Size = New System.Drawing.Size(232, 20)
        Me.save_directory.TabIndex = 13
        Me.save_directory.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Create Files"
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Help"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "About"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = ""
        '
        'Overwrite_Data
        '
        Me.Overwrite_Data.Checked = True
        Me.Overwrite_Data.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Overwrite_Data.Location = New System.Drawing.Point(304, 232)
        Me.Overwrite_Data.Name = "Overwrite_Data"
        Me.Overwrite_Data.TabIndex = 15
        Me.Overwrite_Data.Text = "Overwrite Data"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial Black", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 64)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = ">>"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(424, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 16)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Browse"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(432, 176)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 16)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Browse"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Select a Folder to create the results in"
        Me.FolderBrowserDialog1.ShowNewFolderButton = False
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "MAC Address Length:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MAC_Address_Length
        '
        Me.MAC_Address_Length.Location = New System.Drawing.Point(192, 120)
        Me.MAC_Address_Length.Name = "MAC_Address_Length"
        Me.MAC_Address_Length.Size = New System.Drawing.Size(32, 20)
        Me.MAC_Address_Length.TabIndex = 20
        Me.MAC_Address_Length.Text = "12"
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 283)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(514, 24)
        Me.StatusBar1.SizingGrip = False
        Me.StatusBar1.TabIndex = 21
        '
        'StatusBar_Right
        '
        Me.StatusBar_Right.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusBar_Right.Location = New System.Drawing.Point(0, 288)
        Me.StatusBar_Right.Name = "StatusBar_Right"
        Me.StatusBar_Right.Size = New System.Drawing.Size(512, 16)
        Me.StatusBar_Right.TabIndex = 22
        Me.StatusBar_Right.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Main_Screen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(514, 307)
        Me.Controls.Add(Me.StatusBar_Right)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.MAC_Address_Length)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Overwrite_Data)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.save_directory)
        Me.Controls.Add(Me.IUser_counter)
        Me.Controls.Add(Me.Start_Position)
        Me.Controls.Add(Me.End_Position)
        Me.Controls.Add(Me.Line_Pattern)
        Me.Controls.Add(Me.bootconfig_file)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "Main_Screen"
        Me.Text = "ISYS.ini File Generator 1.0"
        Me.ResumeLayout(False)

    End Sub

#End Region






    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Try
            Dim about1 As New About
            about1.Show()
        Catch ex As Exception
            MsgBox("Error in displaying About Dialog Box. Error message trapped is: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Line_Pattern.Text = "") Or (bootconfig_file.Text = "") Or (Start_Position.Text = "") Or (End_Position.Text = "") Or (IUser_counter.Text = "") Or (save_directory.Text = "") Then
            MsgBox("Please ensure that all input boxes are filled in correctly.")
        Else
            Try
                Dim filereader As New StreamReader(bootconfig_file.Text, True)
                Dim lineread As String = filereader.ReadLine
                Dim MAC_Folder As String
                Dim counter As Integer = Integer.Parse(IUser_counter.Text)
                Dim startpos As Integer = Integer.Parse(Start_Position.Text)
                Dim endpos As Integer = Integer.Parse(End_Position.Text)
                Dim MAC_Length As Integer = Integer.Parse(MAC_Address_Length.Text)
                Dim execution_counter As Integer = 0


                StatusBar_Right.Text = "Processing"
                Button1.Enabled = False
                Do While Not lineread Is Nothing
                    StatusBar_Right.Text = StatusBar_Right.Text & "."
                    If StatusBar_Right.Text.Length() > 16 Then
                        StatusBar_Right.Text = "Processing"
                    End If
                    lineread = lineread.Trim()


                    If lineread.StartsWith(Line_Pattern.Text) Then

                        MAC_Folder = lineread.Substring((startpos - 1), ((endpos - 1) - (startpos - 1)) + 1)
                        MAC_Folder = MAC_Folder.Remove(0, 1)
                        MAC_Folder = MAC_Folder.Insert(MAC_Folder.Length() - 3, ".")
                        MAC_Folder = MAC_Folder.Trim()
                        If (MAC_Folder.Length() = MAC_Length) Then
                            Generate_ISYS_File(MAC_Folder, counter)
                            counter = counter + 1
                            execution_counter = execution_counter + 1
                        End If
                    End If
                    lineread = filereader.ReadLine
                Loop

                filereader.Close()
                StatusBar_Right.Text = "Process Completed Successfully. " & execution_counter.ToString() & " MAC addresses processed."
                MsgBox("Process Completed")
                Button1.Enabled = True
            Catch formatexcept As FormatException
                MsgBox("One or more of the input boxes contain a value in the wrong format. Please ensure that you have filled in all the input boxes correctly.", MsgBoxStyle.Exclamation)
            Catch filenotfoundexcept As FileNotFoundException
                MsgBox(filenotfoundexcept.Message, MsgBoxStyle.Exclamation)
            Catch ex As Exception
                MsgBox("An unhandled error has occurred in processing your request. The error message trapped is: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Generate_ISYS_File(ByVal foldername As String, ByVal counter As Integer)
        Try
            Dim f As FileInfo
            f = New FileInfo(Application.ExecutablePath())
            Dim dir As Directory
            If dir.Exists((save_directory.Text & "\" & foldername)) = False Then
                dir.CreateDirectory((save_directory.Text & "\" & foldername))
            End If
            Dim fil As File
            If (fil.Exists((save_directory.Text & "\" & foldername & "\ISYS.INI")) = True) And (Overwrite_Data.Checked = True) Then
                fil.Delete((save_directory.Text & "\" & foldername & "\ISYS.INI"))
            End If
            If (fil.Exists((save_directory.Text & "\" & foldername & "\ISYS.INI")) = False) Then
                Dim filereader As New StreamReader(f.DirectoryName() & "\ISYS_Template.ini", True)
                Dim lineread As String = filereader.ReadLine
                Dim filewriter As New StreamWriter((save_directory.Text & "\" & foldername & "\ISYS.INI"), False, System.Text.Encoding.ASCII)
                Dim MAC_Folder As String
                Do While Not lineread Is Nothing
                    lineread = lineread.Trim()


                    If lineread.StartsWith("IUser=") Then
                        filewriter.WriteLine(lineread.Replace("###counter###", counter.ToString()))
                    Else
                        filewriter.WriteLine(lineread)

                    End If
                    lineread = filereader.ReadLine
                Loop

                filereader.Close()
                filewriter.Close()
            End If
        Catch ex As Exception
            MsgBox("An unhandled error has occurred in processing your request. The error message trapped is: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DialogResult = OpenFileDialog1.ShowDialog()
        If DialogResult = DialogResult.OK Or DialogResult = DialogResult.Yes Then
            bootconfig_file.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DialogResult = FolderBrowserDialog1.ShowDialog()
        If DialogResult = DialogResult.OK Or DialogResult = DialogResult.Yes Then
            save_directory.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub


    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        Try
            Dim help1 As New Help
            help1.Show()
        Catch ex As Exception
            MsgBox("Error in displaying Help Dialog Box. Error message trapped is: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim f As FileInfo
            f = New FileInfo(Application.ExecutablePath())

            Dim filereader As New StreamReader(f.DirectoryName() & "\ISYS_File_Generator_Config.txt", True)
            Dim lineread As String = filereader.ReadLine

            Do While Not lineread Is Nothing
                lineread = lineread.Trim()
                If lineread.StartsWith("Pattern:") Then
                    Line_Pattern.Text = lineread.Remove(0, 8)
                End If
                If lineread.StartsWith("Position_Start:") Then
                    Start_Position.Text = lineread.Remove(0, 15)
                End If
                If lineread.StartsWith("Position_End:") Then
                    End_Position.Text = lineread.Remove(0, 13)
                End If
                If lineread.StartsWith("Address_Length:") Then
                    MAC_Address_Length.Text = lineread.Remove(0, 15)
                End If
                If lineread.StartsWith("IUser_Counter:") Then
                    IUser_counter.Text = lineread.Remove(0, 14)
                End If
                If lineread.StartsWith("Overwrite:") Then
                    If lineread.Remove(0, 10).Equals("1") Then
                        Overwrite_Data.Checked = True
                    Else
                        Overwrite_Data.Checked = False
                    End If
                End If
                lineread = filereader.ReadLine
            Loop

            filereader.Close()

        Catch ex As Exception
            MsgBox("An unhandled error has occurred in processing your request. The error message trapped is: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
