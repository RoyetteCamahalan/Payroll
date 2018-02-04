Public Class frmSettings

    Private Sub frmSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadSystemDefaults()
    End Sub

#Region "Environment"
    Private maxagentlvl,
            maxbroker,
            maxdirector,
            maxmanager,
            maxsaleperson,
            maxspdownline,
            reservatioduration,
            paymentterm,
            paymentextension,
            commissionterm As Integer
    Private defaultadcom, commissionovertime, interest As Double
#End Region
#Region "Methods"

    Public Sub LoadSystemDefaults()
        Dim dt As DataTable = Utility.SystemSetting()
        'agents
        Me.maxagentlvl = dt.Rows(0).Item("maxagentlevel")
        Me.txtmaxagentlvl.Text = Me.maxagentlvl
        Me.maxbroker = dt.Rows(0).Item("maxbroker")
        Me.txtmaxbroker.Text = Me.maxbroker
        Me.maxdirector = dt.Rows(0).Item("maxsalesdirector")
        Me.txtmaxdirector.Text = Me.maxdirector
        Me.maxmanager = dt.Rows(0).Item("maxsalemanager")
        Me.txtmaxmanager.Text = Me.maxmanager
        Me.maxsaleperson = dt.Rows(0).Item("maxsalesperson")
        Me.txtmaxsalesperson.Text = Me.maxsaleperson
        Me.maxspdownline = dt.Rows(0).Item("maxsalespersondownline")
        Me.txtmaxspdownline.Text = Me.maxspdownline
        'Me.commissionovertime = dt.Rows(0).Item("compercentageoverterm")
        'Me.txtcomoverterm.Text = Me.commissionovertime
        Me.reservatioduration = dt.Rows(0).Item("reservationduration")
        Me.txtreserveduration.Text = Me.reservatioduration
        'Me.paymentterm = dt.Rows(0).Item("paymentterm")
        'Me.txtpaymenterm.Text = Me.paymentterm
        'Me.interest = dt.Rows(0).Item("interest")
        'Me.txtinterest.Text = Me.interest
        'Me.paymentextension = dt.Rows(0).Item("paymentextension")
        'Me.txtpaymentextension.Text = Me.paymentextension
        'Me.commissionterm = dt.Rows(0).Item("commissionterm")
        'Me.txtCommissionTerm.Text = Me.commissionterm
    End Sub

#End Region

    Private Sub TextBox5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtmaxspdownline.KeyPress, txtmaxsalesperson.KeyPress, txtmaxmanager.KeyPress, txtmaxdirector.KeyPress, txtmaxbroker.KeyPress, txtmaxagentlvl.KeyPress, txtreserveduration.KeyPress, txtpaymenterm.KeyPress, txtpaymentextension.KeyPress
        If Asc(e.KeyChar) <> 8 Then 'backspace
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtmaxbroker_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxbroker.Leave
        Me.txtmaxbroker.Text = Val(Me.txtmaxbroker.Text)
        If Me.maxbroker <> Val(Me.txtmaxbroker.Text) Then
            If Not clsMain.Save(0, Me.txtmaxbroker.Text) Then
                Me.txtmaxbroker.Text = Me.maxbroker
            End If
        End If
    End Sub

    Private Sub txtmaxdirector_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxdirector.Leave
        Me.txtmaxdirector.Text = Val(Me.txtmaxdirector.Text)
        If Me.maxdirector <> Val(Me.txtmaxdirector.Text) Then
            If Not clsMain.Save(1, Me.txtmaxdirector.Text) Then
                Me.txtmaxdirector.Text = Me.maxdirector
            End If
        End If
    End Sub

    Private Sub txtmaxmanager_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxmanager.Leave
        Me.txtmaxmanager.Text = Val(Me.txtmaxmanager.Text)
        If Me.maxmanager <> Val(Me.txtmaxmanager.Text) Then
            If Not clsMain.Save(2, Me.txtmaxmanager.Text) Then
                Me.txtmaxmanager.Text = Me.maxmanager
            End If
        End If
    End Sub

    Private Sub txtmaxsalesperson_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxsalesperson.Leave
        Me.txtmaxsalesperson.Text = Val(Me.txtmaxsalesperson.Text)
        If Me.maxsaleperson <> Val(Me.txtmaxsalesperson.Text) Then
            If Not clsMain.Save(3, Me.txtmaxsalesperson.Text) Then
                Me.txtmaxsalesperson.Text = Me.maxsaleperson
            End If
        End If
    End Sub

    Private Sub txtmaxspdownline_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxspdownline.Leave
        Me.txtmaxspdownline.Text = Val(Me.txtmaxspdownline.Text)
        If Me.maxspdownline <> Val(Me.txtmaxspdownline.Text) Then
            If Not clsMain.Save(4, Me.txtmaxspdownline.Text) Then
                Me.txtmaxspdownline.Text = Me.maxspdownline
            End If
        End If
    End Sub

    Private Sub txtmaxagentlvl_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxagentlvl.Leave
        Me.txtmaxagentlvl.Text = Val(Me.txtmaxagentlvl.Text)
        If Me.maxagentlvl <> Val(Me.txtmaxagentlvl.Text) Then
            If Not clsMain.Save(5, Me.txtmaxagentlvl.Text) Then
                Me.txtmaxagentlvl.Text = Me.maxagentlvl
            End If
        End If
    End Sub


    Private Sub txtdefaultadcom_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdefaultadcom.Leave
        Try
            Me.txtdefaultadcom.Text = CDbl(Me.txtdefaultadcom.Text)
        Catch ex As Exception
            Me.txtdefaultadcom.Text = Val(Me.txtdefaultadcom.Text)
        End Try

        If Me.defaultadcom <> CDbl(Me.txtdefaultadcom.Text) Then
            If Not clsMain.Save(6, Me.txtdefaultadcom.Text) Then
                Me.txtdefaultadcom.Text = Me.defaultadcom
            End If
        End If
    End Sub

    Private Sub txtcomoverterm_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdefaultadcom.KeyPress, txtcomoverterm.KeyPress, txtinterest.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtcomoverterm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcomoverterm.Leave
        Try
            Me.txtcomoverterm.Text = CDbl(Me.txtcomoverterm.Text)
        Catch ex As Exception
            Me.txtcomoverterm.Text = Val(Me.txtcomoverterm.Text)
        End Try

        If Me.commissionovertime <> CDbl(Me.txtcomoverterm.Text) Then
            If Not clsMain.Save(7, Me.txtcomoverterm.Text) Then
                Me.txtcomoverterm.Text = Me.commissionovertime
            End If
        End If
    End Sub

    Private Sub txtreserveduration_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtreserveduration.Leave
        Me.txtreserveduration.Text = Val(Me.txtreserveduration.Text)
        If Me.maxagentlvl <> Val(Me.txtreserveduration.Text) Then
            If Not clsMain.Save(8, Me.txtreserveduration.Text) Then
                Me.txtreserveduration.Text = Me.maxagentlvl
            End If
        End If
    End Sub


    Private Sub txtpaymenterm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaymenterm.Leave
        Me.txtpaymenterm.Text = Val(Me.txtpaymenterm.Text)
        If Me.paymentterm <> Val(Me.txtpaymenterm.Text) Then
            If Not clsMain.Save(9, Me.txtpaymenterm.Text) Then
                Me.txtpaymenterm.Text = Me.paymentterm
            End If
        End If
    End Sub

    Private Sub txtinterest_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtinterest.Leave
        Try
            Me.txtinterest.Text = CDbl(Me.txtinterest.Text)
        Catch ex As Exception
            Me.txtinterest.Text = Val(Me.txtinterest.Text)
        End Try

        If Me.interest <> CDbl(Me.txtinterest.Text) Then
            If Not clsMain.Save(10, Me.txtinterest.Text) Then
                Me.txtinterest.Text = Me.interest
            End If
        End If
    End Sub

    Private Sub txtpaymentextension_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpaymentextension.Leave
        Me.txtpaymentextension.Text = Val(Me.txtpaymentextension.Text)
        If Me.paymentextension <> Val(Me.txtpaymentextension.Text) Then
            If Not clsMain.Save(11, Me.txtpaymentextension.Text) Then
                Me.txtpaymentextension.Text = Me.paymentextension
            End If
        End If
    End Sub

    Private Sub txtCommissionTerm_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCommissionTerm.Leave
        Me.txtCommissionTerm.Text = Val(Me.txtCommissionTerm.Text)
        If Me.commissionterm <> Val(Me.txtCommissionTerm.Text) Then
            If Not clsMain.Save(12, Me.txtCommissionTerm.Text) Then
                Me.txtCommissionTerm.Text = Me.commissionterm
            End If
        End If
    End Sub

    Private Sub btnviewLogs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnviewLogs.Click

    End Sub

    Private Sub btnCompanyProfile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompanyProfile.Click
        Dim f As New frmCompanyProfile
        f.ShowDialog()
        If f.issave Then
            Call AdminLayout.LoadHeader()
        End If
        f.Dispose()
    End Sub
End Class