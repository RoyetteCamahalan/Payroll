Public Class CustomReportViewer

    Private mReport As Object
    Private mIsPrinted As Boolean
    Public Sub setReport(ByRef report As Object)
        Me.mReport = report
    End Sub

    Public Function IsPrinted() As Boolean
        Return mIsPrinted
    End Function
    Public Sub setIsPrinted(ByRef isprinted As Boolean)
        mIsPrinted = isprinted
    End Sub

    Private Sub tsPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrint.Click
        If mIsPrinted Then
            Dim f As New frmOverride
            f.mmoduleid = applicationmodule.modCommissions
            f.ShowDialog()
            If f.isoverride Then
                Call Print()
            Else
                CustommsgBox(msgstyle.critical, msgtype.okonly, "Reprint Voucher", "Reprint Override Failed")
            End If
        Else
            Call Print()
        End If
        
    End Sub

    Private Sub CustomReportViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = mReport
    End Sub
    Private Sub Print()
        Dim f As New PrintDialog
        f.AllowSomePages = True
        f.AllowPrintToFile = False
        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim copies As Integer = f.PrinterSettings.Copies
            Dim fromPage As Integer = f.PrinterSettings.FromPage
            Dim toPage As Integer = f.PrinterSettings.ToPage
            Dim collate As Boolean = f.PrinterSettings.Collate


            mReport.PrintOptions.PrinterName = f.PrinterSettings.PrinterName
            mReport.PrintToPrinter(copies, collate, fromPage, toPage)
            Me.mIsPrinted = True
        End If

        f.Dispose()
        mReport.Dispose()
    End Sub
End Class