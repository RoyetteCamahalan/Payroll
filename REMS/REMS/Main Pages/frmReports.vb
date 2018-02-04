Public Class frmReports


    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadChart()
        Call LoadProperty()
    End Sub

#Region "Variables"
    Private CAgentid As Long
    Private CCustomerid As Long
#End Region
#Region "Methods"
    Private Sub LoadChart()
        Me.crtsales.Series("srsSales").Points.AddXY("Jan", 1000000)
        Me.crtsales.Series("srsSales").Label = "10000"
        Me.crtsales.Series("srsSales").Points.AddXY("Feb", 50000)
        Me.crtsales.Series("srsSales").Points.AddXY("Mar", 600000)
        Me.crtsales.Series("srsSales").Points.AddXY("Apr", 150000)
        Me.crtsales.Series("srsSales").Points.AddXY("May", 20000)
        Me.crtsales.Series("srsSales").Points.AddXY("Jun", 1000000)
        Me.crtsales.Series("srsSales").Points.AddXY("Jul", 50000)
        Me.crtsales.Series("srsSales").Points.AddXY("Aug", 600000)
        Me.crtsales.Series("srsSales").Points.AddXY("Sep", 150000)
        Me.crtsales.Series("srsSales").Points.AddXY("Oct", 20000)
        Me.crtsales.Series("srsSales").Points.AddXY("Nov", 1000000)
        Me.crtsales.Series("srsSales").Points.AddXY("Dec", 50000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Jan", 10000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Feb", 5000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Mar", 60000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Apr", 15000)
        Me.crtsales.Series("srsExpense").Points.AddXY("May", 30000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Jun", 10000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Jul", 50000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Aug", 60000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Sep", 15000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Oct", 2000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Nov", 100000)
        Me.crtsales.Series("srsExpense").Points.AddXY("Dec", 5000)
    End Sub
    Private Sub LoadProperty()
        With cmbproperties
            .DataSource = clsProperty.Fetch(0, "")
            .DisplayMember = "PROPERTYNAME"
            .ValueMember = "PROPERTYID"
            .SelectedIndex = 0
        End With
    End Sub

    Private Sub Display()

    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True

        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            CustommsgBox(msgstyle.info, msgtype.okonly, "User Profile", "Your profile has been updated successfully.")
        End If

    End Sub
#End Region

    Private Sub btnupdateinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Save()
    End Sub

    Private Sub pctrSearchAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctrSearchAgent.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchagent
        f.ShowDialog()
        If f.issave Then
            Me.CAgentid = f.mkey
            Me.txtAgent.Text = f.mvalue
        End If
        f.Dispose()
    End Sub

    Private Sub btnPrintPayableCommission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPayableCommission.Click

    End Sub


    Private Sub btn_showallagents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_showallagents.Click
        Call clsReports.PrintAgentslist()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim f As New frmSearchEngine
        f.searchstatus = frmSearchEngine.searchmodule.searchcustomer
        f.ShowDialog()
        If f.issave Then
            Me.CCustomerid = f.mkey
            Me.txtCustomer.Text = f.mvalue
        End If
        f.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clsReports.PrintDownlines(CAgentid)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmountDue.Click
        Dim f As New frmCustomDialog
        f.myformstatus = frmCustomDialog.formstatus.MonthsDue
        f.setTitle("Pick No. of Months Due")
        f.ShowDialog()
    End Sub
End Class