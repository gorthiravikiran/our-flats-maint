Imports System.Windows.Forms

Public Class dialogDone

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim redirectMe As String = getRoutedFrom()
        If redirectMe = "income" Then
            Dim child1 As New cashReceipt
            child1.MdiParent = flatHome
            child1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            child1.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

End Class
