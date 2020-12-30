Imports System.IO

Public Class ShiftEngine
    Public Shared Sub CheckSave(casesave As String)
        If Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Windows Integration System") = True Then
            If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Windows Integration System\ShiftFS\shiftemNET\4thwall.sll") = True Then

            End If
        Else
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Windows Integration System")
        End If
    End Sub
End Class
