Imports System.IO
Public Class frmBTB

    Private Sub DebitCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadBankAccounts()
        Call EnableFields()
        tempfilename = Path.GetTempFileName
        tempfilename = Path.ChangeExtension(tempfilename, ".jpg")
        If myCurrentFormStatus <> enFormStatus.add Then
            Call LoadRecord()
            If Me.myCurrentFormStatus = enFormStatus.edit Or Me.myCurrentFormStatus = enFormStatus.view Then
                LoadRecord()
            End If
        End If
    End Sub
#Region "Variable"
    Public myCurrentFormStatus As enFormStatus
    Dim erp As New ErrorProvider
    Public issave As Boolean = False
    Public paymentbtbid, paymentid, bankaccountid As Long
    Public paymentdate As Date
    Public memo As String
    Public amount As Double
    Public img As Byte()
    Dim tempfilename As String
    Private hasimage As Boolean

    Private WithEvents myProcess As New Process
    Enum enFormStatus
        add = 0
        edit = 1
        view = 2
    End Enum
#End Region
#Region "Methods"
    Private Sub EnableFields()
        If myCurrentFormStatus = enFormStatus.view Then
            Me.cmbAccount.Enabled = False
            Me.txtAmount.Enabled = False
            Me.txtMemo.Enabled = False
            Me.btnOK.Enabled = False
            Me.btnbrowse.Text = "Export"
            Me.btnclear.Text = "Full Screen"
            Me.btnclear.BackColor = Color.MediumSeaGreen
        ElseIf myCurrentFormStatus = enFormStatus.add Or myCurrentFormStatus = enFormStatus.edit Then
            Me.cmbAccount.Enabled = True
            Me.txtAmount.Enabled = True
            Me.txtMemo.Enabled = True
            Me.btnOK.Enabled = True
            Me.btnbrowse.Text = "Browse"
            Me.btnclear.Text = "Clear"
            Me.btnclear.BackColor = Color.Firebrick
        End If
    End Sub
    Private Sub LoadRecord()
        Me.cmbAccount.SelectedValue = Me.bankaccountid
        Me.txtAmount.Text = CDbl(Me.amount).ToString("N2")
        Me.txtMemo.Text = Me.memo
        Try
            Dim Imgstr As New MemoryStream
            Imgstr = New MemoryStream(img)
            pctrimage.Image = System.Drawing.Image.FromStream(Imgstr)
            pctrimage.Image.Save(tempfilename, Imaging.ImageFormat.Jpeg)
            hasimage = True
        Catch ex As Exception
            pctrimage.Image = Nothing
            hasimage = False
        End Try

    End Sub
    Private Sub LoadBankAccounts()
        With cmbAccount
            .DataSource = clsPayment.Fetch(0, "")
            .DisplayMember = "accountname"
            .ValueMember = "accountid"
            If .Items.Count > 0 Then
                .SelectedIndex = 0
            End If
        End With

    End Sub
    Private Sub selectImage(ByVal pctr As PictureBox)
        Dim dlg As New OpenFileDialog()
        dlg.Filter = "Image Files|*.jpg;*.gif;*.bmp;*.png;*.jpeg"
        Dim dlgRes As DialogResult = dlg.ShowDialog()
        If dlgRes <> DialogResult.Cancel Then
            pctr.Image = Image.FromFile(dlg.FileName)
            hasimage = True
        End If
    End Sub
    Private Sub ExportImage()
        Try
            Dim dlg As New SaveFileDialog()
            dlg.Filter = "Image Files|*.jpg;*.bmp;*.png;*.jpeg"
            Dim dlgRes As DialogResult = dlg.ShowDialog()
            If dlgRes <> DialogResult.Cancel Then
                pctrimage.Image.Save(dlg.FileName)
                MsgBox("Image successfully exported", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Bank to Bank Tender", "Failed to export image.")
        End Try
    End Sub
    Private Sub ViewFullScreen()
        Try
            If File.Exists(tempfilename) Then
                myProcess.StartInfo.FileName = tempfilename
                myProcess.StartInfo.CreateNoWindow = True
                myProcess.EnableRaisingEvents = True
                myProcess.Start()
            End If
        Catch ex As Exception
            CustommsgBox(msgstyle.critical, msgtype.okonly, "Bank to Bank Tender", "Failed to open in fullscreen.")
        End Try
    End Sub
    Private Function isfieldvalid(ByRef ctr As Control) As Boolean
        If ctr.Text = "" Then
            SetErrorProvider(ctr, "This field is required!")
            Return False
        Else
            SetErrorProvider(ctr)
            Return True
        End If
    End Function
    Private Sub SetErrorProvider(ByVal ctl As Control, Optional ByVal strErrorMessage As String = "")
        erp.SetError(ctl, strErrorMessage)
    End Sub
    Private Function isAllFieldValid() As Boolean
        Dim isvalid As Boolean = True
        Try
            If cmbAccount.SelectedValue <= 0 Then
                SetErrorProvider(panelaccount, "This field is required!")
                isvalid = False
            Else
                SetErrorProvider(panelaccount)
            End If
            If isfieldvalid(Me.txtAmount) Then
                If CDbl(Me.txtAmount.Text) <= 0 Then
                    SetErrorProvider(Me.txtAmount, "Invalid Amount")
                    isvalid = False
                Else
                    SetErrorProvider(Me.txtAmount)
                End If
            Else
                isvalid = False
            End If
        Catch ex As Exception
            isvalid = False
        End Try

        Return isvalid
    End Function
    Private Sub Save()
        If isAllFieldValid() Then
            Me.issave = True
            Me.bankaccountid = cmbAccount.SelectedValue
            Me.paymentdate = Me.dtppaymentsched.Value
            Me.amount = CDbl(Me.txtAmount.Text)
            Me.memo = Me.txtMemo.Text
            If Not hasimage Then
                Me.img = Nothing
            Else
                pctrimage.Image.Save(tempfilename, Imaging.ImageFormat.Jpeg)
                Me.img = File.ReadAllBytes(tempfilename)
            End If
            Me.Close()
        End If
    End Sub
#End Region
    Private Sub txtAmount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAmount.KeyPress
        If IsNumeric(sender.Text + e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub frmDebitCard_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyData = Keys.Enter Then
            Call Save()
        End If
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Call Save()
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        If myCurrentFormStatus <> enFormStatus.view Then
            Call selectImage(pctrimage)
        Else
            Call ExportImage()
        End If
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        If myCurrentFormStatus <> enFormStatus.view Then
            Me.pctrimage.Image = My.Resources.no_image
            hasimage = False
        Else
            Call ViewFullScreen()
        End If
    End Sub

    Private Sub frmBTB_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If File.Exists(tempfilename) Then
            File.Delete(tempfilename)
        End If
    End Sub
End Class