Public Class frmProperties
    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myactivepage = activepage.pagelots
        Me.dgvmain.RowTemplate.Height = Default_Row_Height
        Call LoadProperty()
        Call InitializePage()
    End Sub
#Region "Variables"
    Private myactivepage As activepage
    Enum activepage
        pagelots = 0
        pageproperty = 1
        pagetype = 2
    End Enum
#End Region

#Region "Methods"
    Private Sub InitializePage()
        Me.txtSearch.Text = ""
        If myactivepage = activepage.pagelots Then
            panellots.Visible = True
            panelproperty.Visible = False
            paneltype.Visible = False
            lblproperty.Visible = True
            Me.panelpropertycmb.Visible = True
        ElseIf myactivepage = activepage.pageproperty Then
            panellots.Visible = False
            panelproperty.Visible = True
            paneltype.Visible = False
            lblproperty.Visible = False
            Me.panelpropertycmb.Visible = False
        Else
            panellots.Visible = False
            panelproperty.Visible = False
            paneltype.Visible = True
            lblproperty.Visible = True
            Me.panelpropertycmb.Visible = True
        End If
        Call DisplayList()
    End Sub
    Private Sub LoadProperty()
        With cmbproperties
            .DataSource = clsProperty.Fetch(0, "")
            .DisplayMember = "PROPERTYNAME"
            .ValueMember = "PROPERTYID"
            .SelectedIndex = 0
        End With
    End Sub
    Private Sub DisplayList()
        If myactivepage = activepage.pagelots Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing top 100 results"
            Else
                Me.lblshowing.Text = "Showing top 100 results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsProperty.Fetch(1, Me.txtSearch.Text, Me.cmbproperties.SelectedValue)
                .Columns(0).HeaderText = "Lot ID"
                .Columns(0).Width = 108
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Lot Name"
                .Columns(1).Width = 220
                .Columns(2).HeaderText = "Area"
                .Columns(2).Width = 220
                .Columns(3).HeaderText = "Price"
                .Columns(3).Width = 110
                .Columns(4).HeaderText = "Down"
                .Columns(4).Width = 120
                .Columns(5).HeaderText = "Type/Model"
                .Columns(5).Width = 110
                .Columns(6).Visible = False
                .Columns(7).HeaderText = "Status"
                .Columns(7).Width = 110
                .Columns(8).Visible = False
                .Columns(9).Visible = False

            End With
        ElseIf myactivepage = activepage.pageproperty Then
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsProperty.Fetch(2, Me.txtSearch.Text)
                .Columns(0).HeaderText = "Property #"
                .Columns(0).Width = 108
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Property Name"
                .Columns(1).Width = 320
                .Columns(2).HeaderText = "Address"
                .Columns(2).Width = 430
                .Columns(3).HeaderText = "Area"
                .Columns(3).Width = 140
            End With
        Else
            If Trim(Me.txtSearch.Text) = "" Then
                Me.lblshowing.Text = "Showing all results"
            Else
                Me.lblshowing.Text = "Showing results for '" & Me.txtSearch.Text & "'"
            End If
            With dgvmain
                .DataSource = Nothing
                .DataSource = clsProperty.Fetch(4, Me.txtSearch.Text, Me.cmbproperties.SelectedValue)
                .Columns(0).HeaderText = "Type/Model #"
                .Columns(0).Width = 258
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).HeaderText = "Type/Model Name"
                .Columns(1).Width = 640
                .Columns(2).HeaderText = "Category"
                .Columns(2).Width = 140
                .Columns(3).Visible = False
            End With
        End If

    End Sub
#End Region

    Private Sub txtSearch_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyUp
        If e.KeyData = Keys.Enter Then
            DisplayList()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        DisplayList()
    End Sub

    Private Sub txtSearch_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.Leave
        If Trim(Me.txtSearch.Text) = "" Then
            DisplayList()
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Me.myactivepage = activepage.pagelots Then
            Dim f As New frmLotLibrary
            f.propertyid = cmbproperties.SelectedValue
            f.myformstatus = frmLotLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        ElseIf Me.myactivepage = activepage.pageproperty Then
            Dim f As New frmPropertyLibrary
            f.myformstatus = frmPropertyLibrary.formstatus.add
            f.ShowDialog()
            If f.issave Then
                Call LoadProperty()
                Call DisplayList()
            End If
        Else
            Dim f As New frmPropertyTypeLibrary
            f.myformstatus = frmPropertyTypeLibrary.formstatus.add
            f.propertyid = Me.cmbproperties.SelectedValue
            f.ShowDialog()
            If f.issave Then
                Call DisplayList()
            End If
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If dgvmain.CurrentRow.Index >= 0 Then
            If Me.myactivepage = activepage.pagelots Then
                Dim f As New frmLotLibrary
                f.propertyid = cmbproperties.SelectedValue
                f.lotid = Me.dgvmain.CurrentRow.Cells("LOT_ID").Value
                f.myformstatus = frmLotLibrary.formstatus.edit
                f.ShowDialog()
                If f.issave Then
                    Call DisplayList()
                End If
            ElseIf Me.myactivepage = activepage.pageproperty Then
                Dim f As New frmPropertyLibrary
                f.propertyid = cmbproperties.SelectedValue
                f.propertyid = Me.dgvmain.CurrentRow.Cells("PROPERTYID").Value
                f.myformstatus = frmPropertyLibrary.formstatus.edit
                f.ShowDialog()
                If f.issave Then
                    Call LoadProperty()
                    Call DisplayList()
                End If
            Else
                Dim f As New frmPropertyTypeLibrary
                f.myformstatus = frmPropertyTypeLibrary.formstatus.edit
                f.typeid = Me.dgvmain.CurrentRow.Cells("TYPE_ID").Value
                f.typecategory = Me.dgvmain.CurrentRow.Cells("lotcategory").Value
                f.propertyid = Me.cmbproperties.SelectedValue
                f.typename = Me.dgvmain.CurrentRow.Cells("NAME").Value
                f.ShowDialog()
                If f.issave Then
                    Call DisplayList()
                End If
            End If
        End If

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If dgvmain.CurrentRow.Index >= 0 Then
            If Me.myactivepage = activepage.pagelots Then
                Dim f As New frmLotLibrary
                f.propertyid = cmbproperties.SelectedValue
                f.lotid = Me.dgvmain.CurrentRow.Cells("LOT_ID").Value
                f.myformstatus = frmLotLibrary.formstatus.view
                f.ShowDialog()
            ElseIf Me.myactivepage = activepage.pageproperty Then
                Dim f As New frmPropertyLibrary
                f.propertyid = Me.dgvmain.CurrentRow.Cells("PROPERTYID").Value
                f.myformstatus = frmPropertyLibrary.formstatus.view
                f.ShowDialog()
            Else
                Dim f As New frmPropertyTypeLibrary
                f.myformstatus = frmPropertyTypeLibrary.formstatus.view
                f.typeid = Me.dgvmain.CurrentRow.Cells("TYPE_ID").Value
                f.typecategory = Me.dgvmain.CurrentRow.Cells("lotcategory").Value
                f.propertyid = Me.cmbproperties.SelectedValue
                f.typename = Me.dgvmain.CurrentRow.Cells("NAME").Value
                f.ShowDialog()
            End If
        End If

    End Sub

    Private Sub btnMenuLots_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuLots.MouseEnter
        If myactivepage <> activepage.pagelots Then
            Me.btnMenuLots.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMenuLots_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuLots.MouseLeave
        Me.btnMenuLots.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnMenuProperties_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuProperties.MouseEnter
        If myactivepage <> activepage.pageproperty Then
            Me.btnMenuProperties.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnMenuProperties_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuProperties.MouseLeave
        Me.btnMenuProperties.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btnMenuLots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuLots.Click
        If myactivepage <> activepage.pagelots Then
            myactivepage = activepage.pagelots
            Call InitializePage()
        End If
    End Sub

    Private Sub btnMenuProperties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuProperties.Click
        If myactivepage <> activepage.pageproperty Then
            myactivepage = activepage.pageproperty
            Call InitializePage()
        End If
    End Sub

    Private Sub cmbproperties_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbproperties.SelectedValueChanged
        Try
            If cmbproperties.SelectedValue > 0 And myactivepage <> activepage.pageproperty Then
                Call DisplayList()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btntype_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuType.MouseEnter
        If myactivepage <> activepage.pagetype Then
            Me.btnMenuType.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btntype_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuType.MouseLeave
        Me.btnMenuType.ForeColor = System.Drawing.SystemColors.WindowFrame
    End Sub

    Private Sub btntype_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenuType.Click
        If myactivepage <> activepage.pagetype Then
            myactivepage = activepage.pagetype
            Call InitializePage()
        End If
    End Sub
End Class