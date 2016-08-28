
Imports Newtonsoft.Json
Imports System.IO

Public Class Form1
    Dim SteamPath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbOutput.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        SteamPath = GetSteamPath()

        Dim appids As List(Of String) = GetInstalledGames()
        For Each appid In appids.Distinct
            lbGames.Items.Add(appid)
        Next

    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        For Each appid In lbGames.SelectedItems
            Try
                Dim json As String = New Net.WebClient().DownloadString("https://steampics-mckay.rhcloud.com/info?apps=" & appid & "&prettyprint=1")
                Dim jsonResult = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(json).Item("apps").Item(appid)

                Dim name As String = jsonResult.Item("common").Item("name").ToString.Replace(":", "").Replace("\", "").Replace("/", "")
                Dim target As String
                Dim workingdirectory As String
                Dim iconpath As String
                If jsonResult.Item("common").Item("clienticon") <> Nothing Then
                    iconpath = SteamPath & "\steam\games\" & jsonResult.Item("common").Item("clienticon").ToString & ".ico"
                ElseIf jsonResult.Item("common").Item("icon") <> Nothing Then
                    iconpath = SteamPath & "\steam\games\" & jsonResult.Item("common").Item("icon").ToString & ".ico"
                Else
                    iconpath = ""
                End If
                Dim savepath As String = tbOutput.Text

                If cbSteamLink.Checked Then
                    target = "steam://rungameid/" & appid

                    Dim objWriter As New StreamWriter(savepath & "\" & name & ".url", True)
                    objWriter.WriteLine("[InternetShortcut]")
                    objWriter.WriteLine("IconIndex=0")
                    objWriter.WriteLine("URL=" & target)
                    objWriter.WriteLine("IconFile=" & iconpath)
                    objWriter.Close()
                End If

                If cbGameExe.Checked Then
                    Dim first = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(jsonResult.Item("config").Item("launch").ToString).Keys(0).ToString
                    target = SteamPath & "\steamapps\common\" & jsonResult.Item("config").Item("installdir").ToString & "\" & jsonResult.Item("config").Item("launch").Item(first).Item("executable").ToString.Replace("/", "\")
                    workingdirectory = Path.GetDirectoryName(target).ToString
                    If (File.Exists(target)) Then
                        Dim objShell, objLink
                        objShell = CreateObject("WScript.Shell")
                        objLink = objShell.CreateShortcut(savepath & "\" & name & ".lnk")
                        objLink.TargetPath = target
                        objLink.Description = "Created by Steam Shortcut Creator"
                        objLink.WindowStyle = 1
                        objLink.WorkingDirectory = workingdirectory
                        objLink.Save
                    End If
                End If
            Catch ex As Exception
                MsgBox("Failed to create shortcut: " & appid)
            End Try
        Next

        MsgBox("Done!")
    End Sub

    Function GetSteamPath()
        If System.Environment.Is64BitOperatingSystem = True Then
            Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", Nothing)
        Else
            Return My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", Nothing)
        End If
    End Function

    Function GetInstalledGames()
        Dim files As List(Of String) = IO.Directory.GetFiles(SteamPath & "\steamapps").ToList
        Dim appids As New List(Of String)

        For Each file In files.Distinct
            If file.Contains("appmanifest_") And file.Contains(".acf") Then
                appids.Add(Path.GetFileName(file).Replace("appmanifest_", "").Replace(".acf", ""))
            End If
        Next

        Return appids
    End Function

    Private Sub btnInvert_Click(sender As Object, e As EventArgs) Handles btnInvert.Click

        For i = 0 To lbGames.Items.Count - 1
            If lbGames.SelectedItems.Contains(lbGames.Items(i)) Then
                lbGames.SetSelected(i, False)
            Else
                lbGames.SetSelected(i, True)
            End If
        Next

    End Sub
End Class
