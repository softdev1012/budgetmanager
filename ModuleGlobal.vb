Module ModuleGlobal
    Public IDMorAccess As String = "IDM"
    'Public GlobalProviderForIDM As String = "server=192.168.1.2; database=Prooptic; user=Prooptic; password=IDM; pooling = false; convert zero datetime=True"
    Public GlobalProviderForIDM As String = "server=localhost; database=PandaBudget; user=Admin; password=Apple77600"
    Public GlobalProvider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =c:\Takeoff\takeoff.mdb;"
    Public IndexMenuPrincipalClicked As Integer = 0
    Public GlobalProviderForLocalHost As String = "server=LOCALHOST; database=PandaBudget; user=Admin; password=Apple77600;"
    'Public GlobalProviderForLocalHost As String = "server=localhost; database=PandaBudget; user=Admin; password=Apple77600;"
    Public Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        '' Note: call this from frm's Load event!
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).WorkingArea
        End If

        Dim x = r.Left + (r.Width - frm.Width) \ 2
        Dim y = r.Top + (r.Height - frm.Height) \ 2
        frm.Location = New Point(x, y)
    End Sub
End Module
