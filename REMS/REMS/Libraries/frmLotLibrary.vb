Public Class frmLotLibrary
    Private Sub frmCustomerLibrary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadType()
        Call PaintForm()
        Call EnableFields()
        If myformstatus <> formstatus.add Then
            Call LoadRecord()
        End If
    End Sub

#Region "Variables"
    Dim erp As New ErrorProvider
    Public issave As Boolean
    Public propertyid As Integer
    Private typeid As Integer
    Public lotid As Long
    Private dtLotType As DataTable
    Public myformstatus As formstatus
    Enum formstatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub LoadRecord()
        Dim dtRecord As DataTable = clsProperty.Fetch(5, Me.lotid)
        Me.txtlotname.Text = dtRecord.Rows(0).Item("NAME")
        Me.txtarea.Text = dtRecord.Rows(0).Item("AREA")
        Me.txtprice.Text = CDbl(dtRecord.Rows(0).Item("DEFAULT_PRICE")).ToString("N2")
        Me.txtdown.Text = CDbl(dtRecord.Rows(0).Item("MIN_DOWN")).ToString("N2")
        Me.txtcom.Text = CDbl(dtRecord.Rows(0).Item("compercentage")).ToString("N2")
        Me.txtcommissionableamount.Text = CDbl(dtRecord.Rows(0).Item("commissionableamount")).ToString("N2")
        Me.txthousearea.Text = CDbl(dtRecord.Rows(0).Item("housearea")).ToString("N2")
        Me.txtparking.Text = CDbl(dtRecord.Rows(0).Item("parkingarea")).ToString("N2")
        Me.cmbtype.SelectedValue = dtRecord.Rows(0).Item("TYPE")
    End Sub
    Private Sub LoadType()
        dtLotType = clsProperty.Fetch(4, "", propertyid)
        With cmbtype
            .DataSource = dtLotType
            .DisplayMember = "NAME"
            .ValueMember = "TYPE_ID"
            .SelectedIndex = -1
        End With
    End Sub
    Public Sub EnableFields()
        If Me.myformstatus = formstatus.view Then
            Me.txtlotname.Enabled = False
            Me.txtprice.Enabled = False
            Me.txtarea.Enabled = False
            Me.txtdown.Enabled = False
            Me.cmbtype.Enabled = False
            Me.btnpositive.Visible = False
        End If
    End Sub
    Private Sub PaintForm()
        If Me.myformstatus = formstatus.add Then
            Me.BackColor = newcolor
            Me.btnpositive.BackColor = newcolor
        ElseIf myformstatus = formstatus.edit Then
            Me.BackColor = editcolor
            Me.btnpositive.BackColor = editcolor
            Me.lblTitle.Text = "Edit Lot"
        Else
            Me.BackColor = viewcolor
            Me.btnpositive.BackColor = viewcolor
            Me.lblTitle.Text = "View Lot"
        End If
    End Sub
    Private Sub seterror(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub
    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtlotname.Text) = "" Then
            isvalid = False
            seterror(panellotname, "This field is required!")
        Else
            seterror(panellotname)
        End If

        If Trim(Me.txtarea.Text) = "" Then
            isvalid = False
            seterror(panelarea, "This field is required!")
        Else
            seterror(panelarea)
        End If

        If Trim(Me.txtprice.Text) = "" Then
            isvalid = False
            seterror(panelprice, "This field is required!")
        Else
            seterror(panelprice)
        End If

        If Trim(Me.txtdown.Text) = "" Then
            isvalid = False
            seterror(paneldown, "This field is required!")
        Else
            seterror(paneldown)
        End If
        If Trim(Me.txtcom.Text) = "" Then
            isvalid = False
            seterror(panelcom, "This field is required!")
        Else
            seterror(panelcom)
        End If
        If Trim(Me.txtcommissionableamount.Text) = "" Then
            isvalid = False
            seterror(panelcommissionable, "This field is required!")
        Else
            seterror(panelcommissionable)
        End If
        If Trim(Me.txthousearea.Text) = "" Then
            isvalid = False
            seterror(panelhousearea, "This field is required!")
        Else
            seterror(panelhousearea)
        End If
        If Trim(Me.txtparking.Text) = "" Then
            isvalid = False
            seterror(panelparking, "This field is required!")
        Else
            seterror(panelparking)
        End If
        If cmbtype.SelectedIndex < 0 Then
            isvalid = False
            seterror(paneltype, "This field is required!")
        Else
            seterror(paneltype)
        End If
        If isvalid Then
            If CDbl(Me.txtprice.Text) < CDbl(Me.txtcommissionableamount.Text) Then
                isvalid = False
                seterror(panelcommissionable, "Commissionable price must not exceed the selling price!")
            Else
                seterror(panelcommissionable)
            End If
            If CDbl(Me.txthousearea.Text) + CDbl(Me.txtparking.Text) > CDbl(Me.txtarea.Text) Then
                isvalid = False
                CustommsgBox(msgstyle.critical, msgtype.okonly, "Lot", "House Area and Parking Area must not be greater than the total area.")
            End If
        End If
        Return isvalid
    End Function
    Private Sub Save()
        If isallfieldvalid() Then
            If CustommsgBox(msgstyle.info, msgtype.yesno, "Lot", "Are you sure you want to save this information?") Then
                Dim x As New clsProperty
                x.lotid = Me.lotid
                x.propertyid = Me.propertyid
                x.lotname = Me.txtlotname.Text
                x.area = CDbl(Me.txtarea.Text)
                x.price = CDbl(Me.txtprice.Text)
                x.compercentage = CDbl(Me.txtcom.Text)
                x.down = CDbl(Me.txtdown.Text)
                x.commissionableamount = CDbl(Me.txtcommissionableamount.Text)
                x.housearea = CDbl(Me.txthousearea.Text)
                x.parkingarea = CDbl(Me.txtparking.Text)
                x.lottypeid = Me.cmbtype.SelectedValue
                If Me.myformstatus = formstatus.add Then
                    Me.lotid = x.SaveLot(True)
                Else
                    Me.lotid = x.SaveLot(False)
                End If
                If lotid > 0 Then
                    If Me.myformstatus = formstatus.add Then
                        Call SaveLogs(applicationmodule.modProperties, "Lots", "Added New Lot : " & Me.txtlotname.Text)
                    Else
                        Call SaveLogs(applicationmodule.modProperties, "Lots", "Updated Lot : " & Me.txtlotname.Text)
                    End If
                    Me.myformstatus = formstatus.view
                    Me.issave = True
                    Me.Dispose()
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub btnpositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpositive.Click
        Call Save()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub txtcom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtprice.KeyPress, txtdown.KeyPress, txtcom.KeyPress, txtarea.KeyPress, txtcommissionableamount.KeyPress, txthousearea.KeyPress, txtparking.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtarea_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtprice.Leave, txtdown.Leave, txtcommissionableamount.Leave, txtcom.Leave, txtarea.Leave, txtparking.Leave, txthousearea.Leave
        Try
            CType(sender, TextBox).Text = CDbl(sender.Text).ToString("N2")
        Catch ex As Exception
            sender.Text = "0"
        End Try
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbtype.SelectedIndexChanged
        Try
            If cmbtype.SelectedValue > 0 Then
                If dtLotType.Rows(cmbtype.SelectedIndex).Item("lotcategory") = 0 Then
                    Me.Panel2.Height = 437
                    Me.Height = 484
                    Me.btnpositive.Location = New Point(307, 395)
                    Me.lblhousearea.Visible = False
                    panelhousearea.Visible = False
                    Me.lblParking.Visible = False
                    Me.panelparking.Visible = False
                Else
                    Me.Panel2.Height = 542
                    Me.Height = 589
                    Me.btnpositive.Location = New Point(306, 499)
                    Me.lblhousearea.Visible = True
                    panelhousearea.Visible = True
                    Me.lblParking.Visible = True
                    Me.panelparking.Visible = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class