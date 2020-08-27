Imports System.Runtime.InteropServices
Public Class KeyboardHooker

    Const WM_KEYDOWN As Integer = &H100
    Const WM_KEYUP As Integer = &H101

    Public Sub New()
        hookproc = AddressOf KeybordHookProc
        hHook = SetWindowsHookEx(WH_KEYBOARD_LL, hookproc, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0)
        If hHook.Equals(0) Then
            MsgBox("SetWindowsHookEx Failed")
        End If
    End Sub

    Dim WH_KEYBOARD_LL As Integer = 13
    Shared hHook As Integer = 0

    Private hookproc As CallBack

    Public Delegate Function CallBack(
        ByVal nCode As Integer,
        ByVal wParam As IntPtr,
        ByVal lParam As IntPtr) As Integer

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Overloads Shared Function SetWindowsHookEx _
          (ByVal idHook As Integer, ByVal HookProc As CallBack,
    ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Overloads Shared Function GetModuleHandle _
    (ByVal lpModuleName As String) As IntPtr
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Overloads Shared Function CallNextHookEx _
          (ByVal idHook As Integer, ByVal nCode As Integer,
    ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)>
    Public Overloads Shared Function UnhookWindowsHookEx _
    (ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)> Public Structure KeyboardLLHookStruct
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure


    Public Function KeybordHookProc(
        ByVal nCode As Integer,
        ByVal wParam As IntPtr,
        ByVal lParam As IntPtr) As Integer

        If (nCode < 0) Then
            Return CallNextHookEx(hHook, nCode, wParam, lParam)
        End If

        Dim hookStruct As New KeyboardLLHookStruct()
        hookStruct = CType(Marshal.PtrToStructure(lParam, hookStruct.GetType()), KeyboardLLHookStruct)

        If wParam = New IntPtr(WM_KEYDOWN) Then
            Dim e As New KeyBoardHookerEventArgs
            e.vkCode = hookStruct.vkCode
            RaiseEvent KeyDown(Me, e)
            Return 0
        End If

        If wParam = New IntPtr(WM_KEYUP) Then
            Dim e As New KeyBoardHookerEventArgs
            e.vkCode = hookStruct.vkCode
            RaiseEvent KeyUp(Me, e)
            Return 0
        End If

        Return CallNextHookEx(hHook, nCode, wParam, lParam)
    End Function

    Public Event KeyDown(ByVal sender As Object, ByVal EventArgs As KeyBoardHookerEventArgs)
    Public Event KeyUp(ByVal sender As Object, ByVal EventArgs As KeyBoardHookerEventArgs)

    Public Sub Dispose()
        Dim ret As Boolean = UnhookWindowsHookEx(hHook)
        If ret.Equals(False) Then
        End If
    End Sub
End Class


Public Class KeyBoardHookerEventArgs
    Inherits EventArgs

    Dim _vkCode As Integer

    Public Property vkCode() As Integer
        Get
            Return _vkCode
        End Get
        Set(ByVal value As Integer)
            _vkCode = value
        End Set
    End Property

End Class