Imports System.Windows.Forms

Public Class flatChgPwd
    Dim dataset1 As DataSet

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub formChgPwd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dataset1 = fetchPassword()
        'Add Data Bindings
        userid.Text = dataset1.Tables(0).Rows(0)("USER_ID").ToString
        uname.Text = dataset1.Tables(0).Rows(0)("USERNAME").ToString
        pwd.Text = dataset1.Tables(0).Rows(0)("PASSWORD").ToString

        Me.MdiParent = flatHome
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        pic1.Visible = False
        pic2.Visible = False
        check1.Visible = True
        check2.Visible = True
        check1.Text = "Enter Old Password"
        check2.Text = "Enter New Password"
    End Sub

    Private Sub changeButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles changeButton.Click
        dataset1.Tables(0).Rows(0).BeginEdit()
        dataset1.Tables(0).Rows(0)("USER_ID") = userid.Text
        dataset1.Tables(0).Rows(0)("USERNAME") = uname.Text
        dataset1.Tables(0).Rows(0)("PASSWORD") = pwd.Text
        dataset1.Tables(0).Rows(0).EndEdit()

        If commonMod.updPassword(dataset1) Then
            Dim child1 As New dialogPwdChngd
            child1.MdiParent = flatHome
            child1.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            If myWinStatus.getWinState("cuf") = False Then
                child1.Show()
                myWinStatus.setWinState("cufopen")
            Else
                Dim child2 As New dialogMultiInst
                child2.MdiParent = flatHome
                child2.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
                child2.Show()
            End If
            Me.Close()
        Else
            dialogSorry.Show()
        End If

    End Sub

    Private Sub oldPwd_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles oldPwd.GotFocus, userid.GotFocus, uname.GotFocus, pwd.GotFocus
        If Not oldPwd.Text = "" Then
            If Not checkOldPwd(oldPwd.Text) Then
                oldPwd.Text = ""
            End If
        Else
        End If
    End Sub

    Private Sub oldPwd_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles oldPwd.LostFocus, userid.LostFocus, uname.LostFocus, pwd.LostFocus
        If Not oldPwd.Text = "" Then
            If commonMod.checkOldPwd(oldPwd.Text) Then
                'pic1.Image = Global.OurFlatsMaint.My.Resources.thumbs_up
                pic1.BackgroundImage = Global.OurFlatsMaint.My.Resources.thumbs_up
                check1.Text = "Password is Correct"
            End If
        ElseIf oldPwd.Text = "" Then
            pic1.BackgroundImage = Global.OurFlatsMaint.My.Resources.thumbs_down
            check1.Text = "Password is Incorrect"
        End If
        pic1.Visible = True
        check1.Visible = True
    End Sub

    Private Sub newPwd2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles newPwd2.LostFocus
        If Not newPwd1.Text = "" Then
            If newPwd1.Text = newPwd2.Text Then
                pic2.BackgroundImage = Global.OurFlatsMaint.My.Resources.thumbs_up
                check2.Text = "Both Passwords Match"
                pwd.Text = newPwd1.Text
            ElseIf Not newPwd1.Text = newPwd2.Text Then
                pic2.BackgroundImage = Global.OurFlatsMaint.My.Resources.thumbs_down
                check2.Text = "Passwords does not Match"
            ElseIf newPwd2.Text = "" Then
                pic2.Image = Global.OurFlatsMaint.My.Resources.thumbs_down
                check2.Text = "Confirm Password can't be Blank"
            End If
        ElseIf newPwd1.Text = "" And newPwd2.Text = "" Then
            check2.Text = "Enter New Password"
        End If
        pic2.Visible = True
    End Sub

    Private Sub newPwd1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles newPwd1.LostFocus
        If newPwd1.Text = "" Then
            pic2.Image = Global.OurFlatsMaint.My.Resources.thumbs_down
            check2.Text = "New Password can't be Blank"
            pic2.Visible = True
        End If
    End Sub
End Class
