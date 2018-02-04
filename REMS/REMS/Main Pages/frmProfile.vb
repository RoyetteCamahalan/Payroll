Public Class frmProfile


    Private Sub frmProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadRecord()
    End Sub

#Region "Variables"
    Private erp As New ErrorProvider
    Private imagename As String
#End Region
#Region "Methods"
    Private Sub LoadRecord()
        txtfname.Text = Current_UserFname
        txtlname.Text = Current_UserLname
        txtmname.Text = Current_UserMname
        If Current_UserGender = "M" Then
            Me.rdmale.Checked = True
        Else
            Me.rdfemale.Checked = True
        End If
        txtuname.Text = CurrentUsername
        Me.pctrProfile.Image = ProfilePic
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
        If Trim(Me.txtfname.Text) = "" Then
            isvalid = False
            SetErrorProvider(Me.panelfname, "This field is required!")
        Else
            SetErrorProvider(Me.panelfname)
        End If
        If Trim(Me.txtlname.Text) = "" Then
            isvalid = False
            SetErrorProvider(Me.panellname, "This field is required!")
        Else
            SetErrorProvider(Me.panellname)
        End If
        If Trim(Me.txtuname.Text) = "" Then
            isvalid = False
            SetErrorProvider(Me.paneluname, "This field is required!")
        Else
            SetErrorProvider(Me.paneluname)
            If Me.txtuname.Text <> CurrentUsername Then
                If clsEmployees.GetUsers(5, Me.txtuname.Text).Rows.Count > 0 Then
                    isvalid = False
                    SetErrorProvider(paneluname, "Username already exist!")
                End If
            End If

        End If

        Return isvalid
    End Function
    Private Sub SaveProfile()
        If isallfieldvalid() Then
            Dim x As New clsEmployees
            x.employeeid = Current_UserID
            x.firstname = Me.txtfname.Text
            x.lastname = Me.txtlname.Text
            x.middlename = Me.txtmname.Text
            If Me.rdmale.Checked Then
                x.gender = "M"
            Else
                x.gender = "F"
            End If
            x.username = Me.txtuname.Text
            If x.UpdateProfile(2) Then
                Current_UserFname = Me.txtfname.Text
                Current_UserLname = Me.txtlname.Text
                Current_UserMname = Me.txtmname.Text
                Current_UserGender = x.gender
                CurrentUsername = Me.txtuname.Text
                Call AdminLayout.LoadHeader()
                CustommsgBox(msgstyle.info, msgtype.okonly, "User Profile", "Your profile has been updated successfully.")
            End If
        End If

    End Sub
    Private Sub SavePhoto()
        If imagename <> "" Then
            If System.IO.File.Exists(imagename) Then
                Dim x As New clsEmployees
                Dim byt As Byte() = IO.File.ReadAllBytes(imagename)
                x.employeeid = Current_UserID
                x.photo = byt
                If x.UpdateProfile(3) Then
                    ProfilePic = pctrProfile.Image
                    Call AdminLayout.LoadHeader()
                    CustommsgBox(msgstyle.info, msgtype.okonly, "User Profile", "Your profile picture has been updated successfully.")
                    Me.imagename = ""
                Else
                    CustommsgBox(msgstyle.critical, msgtype.okonly, "User Profile", "File '" & imagename & "' does not exist!")
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
        Call selectImage(Me.pctrProfile)
    End Sub

    Private Sub btnchangepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangepass.Click
        Dim fchangepassword As New frmUpdatePassword
        fchangepassword.ShowDialog()
        fchangepassword.Dispose()
    End Sub
End Class