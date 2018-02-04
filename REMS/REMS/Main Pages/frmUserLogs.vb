Public Class frmUserLogs


    Private Sub frmUserLogs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call LoadRecord()
    End Sub
#Region "Methods"
    
    Private Sub LoadRecord()
        With dgvmain
            .DataSource = clsMain.Fetch(3, Me.txtSearch.Text)
            .Columns(0).HeaderText = "Module"
            .Columns(0).Width = 150
            .Columns(1).HeaderText = "Action"
            .Columns(1).Width = 260
            .Columns(2).HeaderText = "Date"
            .Columns(2).Width = 120
            .Columns(3).HeaderText = "Employee"
            .Columns(3).Width = 150
        End With
    End Sub
  
#End Region

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        Call LoadRecord()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Call LoadRecord()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class