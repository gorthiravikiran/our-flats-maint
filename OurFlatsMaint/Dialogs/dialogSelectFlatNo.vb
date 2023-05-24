Imports System.Windows.Forms

Public Class dialogSelectFlatNo

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dialogSelectFlatNo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim datatable1 As DataTable = fetchAllFlatNumbers()
        For i As Integer = 0 To datatable1.Rows.Count - 1
            Me.flatNo.Items.Add(datatable1.Rows(i)("FLAT_NO").ToString)
        Next
    End Sub
End Class
