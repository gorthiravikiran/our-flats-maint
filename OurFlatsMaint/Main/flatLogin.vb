Option Strict Off
Option Explicit On
Imports System.Data.OleDb

Public Class flatLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Inherits System.Windows.Forms.Form
    Private mCancel As Boolean
    Dim loginUsername, loginPassword As String
    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Dim LoginResult As Boolean
    Dim gUserName, gPassword As String
    Dim conn As New OleDbConnection

    Public Sub resetMe()
        LoginResult = False
        Me.password.Focus()
        Me.password.Text = ""
        Me.ProgressBar1.Value = 0
        Me.ProgressBar1.Enabled = False
    End Sub

    Private Sub loginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        ' prompt user to enter username and password
        If (password.Text = "") Then
            MsgBox("Password field cannot be Blank. You Should Give an Appropriate Password to Login")
        End If

        ' set various parameters
        mCancel = False
        loginUsername = Me.username.SelectedItem.ToString
        'setUserName(loginUsername)
        loginPassword = Me.password.Text

        ' check the password corresponding to the username from database
        conn.Open()
        Dim dc As New OleDbCommand("SELECT * FROM USERS WHERE USERNAME = '" & loginUsername & "' AND PASSWORD = '" & loginPassword & "'", conn)
        Dim dr As OleDbDataReader = dc.ExecuteReader()

        ' check if the user exits
        If (dr.Read() = True) Then
            ' save the username in the Registry
            SaveSetting(My.Application.Info.ProductName, "Settings", "LastLogIn", loginUsername)

            LoginResult = True
            ' redirect to Public chat room if login successful

            Timer1_Tick(Owner, e)
        Else
            LoginResult = False
            MsgBox("Invalid Login Credentials, Please try again")
            resetMe()
            Me.GetLogIn(gUserName, gPassword, Me)
        End If
        conn.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Enabled = True
        ProgressBar1.Visible = True
        ProgressBar1.Maximum = 100
        Do While ProgressBar1.Value < 100
            ProgressBar1.Value = Int(ProgressBar1.Value) + Val(1)
        Loop
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Me.Close()
            MsgBox("Hello, " & loginUsername & " !   Welcome to " & My.Application.Info.ProductName.ToString & " v" & My.Application.Info.Version.ToString)
            flatHome.Show()
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        mCancel = True
        If (conn.State = ConnectionState.Open) Then
            conn.Close()
        End If
        My.Application.ApplicationContext.ExitThread()
    End Sub

    Private Sub resetBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetBtn.Click
        resetMe()
    End Sub

    Private Sub flatLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If (conn.State = ConnectionState.Open) Then
            conn.Close()
        End If
    End Sub

    Private Sub flatLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'get database connection
        conn = flatsConn.getConnection
    End Sub

    Public Function GetLogIn(ByRef gUserName As String, ByRef gPassword As String, ByVal Owner As Object) As Boolean
        gUserName = loginUsername
        gPassword = loginPassword
        Me.Show()
        GetLogIn = Not mCancel
    End Function

End Class
