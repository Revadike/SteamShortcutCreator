Imports System.IO
Public Class ACF

    Private _lines() As String
    Private _gameTitle As String
    Private _installDir As String
    Private _appId As String
    Private _lastUpdated As Integer
    Private _mountedDepots As New List(Of String)

    Public Sub New(ByVal path As String)
        Dim Lines() As String = File.ReadAllLines(path)


        For i = 0 To Lines.Length - 1
            Dim line As String = Lines(i)
            If line.ToLower.Contains("name") Then _gameTitle = line.Split("""")(3)
            If line.ToLower.Contains("installdir") Then _installDir = line.Split("""")(3)
            If line.ToLower.Contains("lastowner") Then Lines(i) = Lines(i).Replace(line.Split("""")(3), "DepotDB")
            If line.ToLower.Contains("appid") Then _appId = line.Split("""")(3)
            If line.ToLower.Contains("lastupdated") Then _lastUpdated = line.Split("""")(3)
            If line.ToLower.Contains("mounteddepots") Then
                For currentLine = i + 1 To i + 50
                    Dim depotLine As String = Lines(currentLine)
                    If depotLine.Contains("{") Then Continue For
                    If depotLine.Contains("}") Then Exit For

                    _mountedDepots.Add(depotLine.Split("""")(1) & "_" & depotLine.Split("""")(3) & ".manifest")
                Next
            End If
        Next

        _lines = Lines

    End Sub

    Public Sub SaveACF(ByVal SavePath As String)
        Dim ACFWriter As New StreamWriter(SavePath & "\appmanifest_" & AppID & ".acf")
        For Each line As String In _lines
            ACFWriter.WriteLine(line)
        Next
        ACFWriter.Close()
    End Sub

    Public ReadOnly Property InstallDir() As String
        Get
            Return _installDir
        End Get
    End Property
    Public ReadOnly Property GameTitle() As String
        Get
            Return _gameTitle
        End Get
    End Property
    Public ReadOnly Property LastUpdated() As Integer
        Get
            Return _lastUpdated
        End Get
    End Property
    Public ReadOnly Property AppID() As String
        Get
            Return _appId
        End Get
    End Property
    Public ReadOnly Property MountedDepots() As List(Of String)
        Get
            Return _mountedDepots
        End Get
    End Property



End Class
