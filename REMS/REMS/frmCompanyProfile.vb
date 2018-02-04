Public Class frmCompanyProfile


    Private Sub frmProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadRecord()
    End Sub

#Region "Variables"
    Private erp As New ErrorProvider
    Private imagename As String
    Public issave As Boolean = False
#End Region
#Region "Methods"
    Private Sub LoadRecord()
        txtcname.Text = Company_Name
        txtccontact.Text = CompanyContact
        txtcaddress.Text = CompanyAddress
        Me.pctrCompanyLogo.Image = CompanyLogo
    End Sub
    Private Sub selectImage(ByVal pctr As PictureBox)
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg"
        Dim dlgRes As DialogResult = dlg.ShowDialog()
        If dlgRes <> DialogResult.Cancel Then
            pctr.Image = Image.FromFile(dlg.FileName)
            Me.imagename = dlg.FileName
        End If
        dlg.Dispose()
    End Sub
    Private Sub SetErrorProvider(ByRef ctr As Control, Optional ByRef msg As String = "")
        erp.SetError(ctr, msg)
    End Sub

    Private Function isallfieldvalid() As Boolean
        Dim isvalid As Boolean = True
        If Trim(Me.txtcname.Text) = "" Then
            isvalid = False
            SetErrorProvider(Me.panelcname, "This field is required!")
        Else
            SetErrorProvider(Me.panelcname)
        End If
        If Trim(Me.txtccontact.Text) = "" Then
            isvalid = False
            SetErrorProvider(Me.panelccontact, "This field is required!")
        Else
            SetErrorProvider(Me.panelccontact)
        End If

        Return isvalid
    End Function
    Private Sub SaveProfile()
        If isallfieldvalid() Then
            Dim x As New clsMain
            x.companyname = Me.txtcname.Text
            x.address = Me.txtcaddress.Text
            x.contact = Me.txtccontact.Text
            
            If x.SaveCompanyInfo(14) Then
                Company_Name = Me.txtcname.Text
                CompanyAddress = Me.txtcaddress.Text
                CompanyContact = Me.txtccontact.Text
                Me.issave = True
                CustommsgBox(msgstyle.info, msgtype.okonly, "Company Profile", "Company profile has been updated successfully.")
            End If
        End If

    End Sub
    Private Sub SavePhoto()
        If imagename <> "" Then
            If System.IO.File.Exists(imagename) Then
                Dim x As New clsMain
                Dim byt As Byte() = IO.File.ReadAllBytes(imagename)
                x.photo = byt
                If x.SaveCompanyInfo(13) Then
                    CompanyLogo = pctrCompanyLogo.Image
                    Me.issave = True
                    CustommsgBox(msgstyle.info, msgtype.okonly, "Company Profile", "Company Logo has been updated successfully.")
                    Me.imagename = ""
                Else
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "Company Profile", "File '" & imagename & "' does not exist!")
                End If
            End If

        End If
    End Sub
#End Region

    Private Sub btnupdateinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdateinfo.Click
        Call SaveProfile()
    End Sub

    Private Sub btnsubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsubmit.Click
        Call SavePhoto()
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        Call selectImage(Me.pctrCompanyLogo)
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub
End Class