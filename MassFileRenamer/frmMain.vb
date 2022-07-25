Imports System.IO
Imports System.Text.RegularExpressions


Public Class frmMain

    Dim FileList As String()

    '===========================================================================================================================
    '                                         Open Directory Controls
    '===========================================================================================================================

    Private Sub Form1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub Form1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            If Directory.Exists(MyFiles(0)) Then
                txtDirectory.ForeColor = Color.Black
                txtDirectory.Text = MyFiles(0)
            End If
        End If

    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        dlgOpenFolder.ShowDialog()
        txtDirectory.Text = dlgOpenFolder.SelectedPath
        txtDirectory.ForeColor = Color.Black

    End Sub

    Private Sub txtDirectory_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirectory.GotFocus
        If txtDirectory.Text = "Path To Directory" Then
            txtDirectory.Text = ""
            txtDirectory.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtDirectory_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDirectory.LostFocus
        If txtDirectory.Text = "" Then
            txtDirectory.Text = "Path To Directory"
            txtDirectory.ForeColor = Color.Silver
        End If
    End Sub

    '===========================================================================================================================
    '                                       Search and Remove Controls
    '===========================================================================================================================

    Private Sub txtSearchRemove_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRemove.GotFocus
        If txtSearchRemove.Text = "Search For Text to Remove" Then
            txtSearchRemove.Text = ""
            txtSearchRemove.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchRemove_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchRemove.LostFocus
        If txtSearchRemove.Text = "" Then
            txtSearchRemove.Text = "Search For Text to Remove"
            txtSearchRemove.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnSearchRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRemove.Click
        '=========== Error Checking ===============
        If CheckforPathError() = True Then Exit Sub
        If txtSearchRemove.Text = "Search For Text to Remove" Or txtSearchRemove.Text = "" Then
            MsgBox("You need to enter a term to remove from files first.", MsgBoxStyle.Critical, "search and remove error")
            Exit Sub
        End If
        '=========== Error Checking ===============
        SearchandRemove(txtSearchRemove.Text)

    End Sub

    Private Sub chkRegexRemove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegexRemove.CheckedChanged
        If chkRegexRemove.Checked Then
            btnShowRegexHelp.Visible = True
            chkTestRemove.Enabled = True
            chkTestRemove.Checked = True
        Else
            If chkRegex.Checked = False Then
                btnShowRegexHelp.Visible = False
            End If
            chkTestRemove.Enabled = False
            chkTestRemove.Checked = False
            End If
    End Sub

    '===========================================================================================================================
    '                                           Strip X Controls
    '===========================================================================================================================
    Private Sub txtStripX_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStripX.GotFocus
        If txtStripX.Text = "On Files That End With" Then
            txtStripX.Text = ""
            txtStripX.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtStripX_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtStripX.LostFocus
        If txtStripX.Text = "" Then
            txtStripX.Text = "File Ext"
            txtStripX.ForeColor = Color.Silver
        Else
            If Strings.Left(txtStripX.Text, 1) <> "." Then
                txtStripX.Text = "." & txtStripX.Text
            End If
        End If
    End Sub

    Private Sub btnStripX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStripX.Click
        '=========== Error Checking ===============
        If CheckforPathError() = True Then Exit Sub

        If txtStripX.Text = "" Or txtStripX.Text = "On Files That End With" Then
            MsgBox("You need to enter an extension.", MsgBoxStyle.Critical, "Strip x Error")
            Exit Sub
        End If
        '=========== Error Checking ===============


        If RadioBeginning.Checked = True Then
            StripXfromBeginning(numStripX.Value)
        Else
            StripXfromEnd(numStripX.Value)
        End If



    End Sub

    '===========================================================================================================================
    '                                   Search and Replace Text Controls
    '===========================================================================================================================

    Private Sub txtSearchandReplaceSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchandReplaceSearch.GotFocus
        If txtSearchandReplaceSearch.Text = "Search String" Then
            txtSearchandReplaceSearch.Text = ""
            txtSearchandReplaceSearch.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchandReplaceSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchandReplaceSearch.LostFocus
        If txtSearchandReplaceSearch.Text = "" Then
            txtSearchandReplaceSearch.Text = "Search String"
            txtSearchandReplaceSearch.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtSearchandReplaceReplace_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchandReplaceReplace.GotFocus
        If txtSearchandReplaceReplace.Text = "Replacement String" Then
            txtSearchandReplaceReplace.Text = ""
            txtSearchandReplaceReplace.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSearchandReplaceReplace_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearchandReplaceReplace.LostFocus
        If txtSearchandReplaceReplace.Text = "" Then
            txtSearchandReplaceReplace.Text = "Replacement String"
            txtSearchandReplaceReplace.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub btnSearchandReplace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSearchandReplace.Click
        '=========== Error Checking ===============
        If CheckforPathError() = True Then Exit Sub

        If txtSearchandReplaceSearch.Text = "Search String" Or txtSearchandReplaceSearch.Text = "" Then
            MsgBox("Please Enter a Search String", MsgBoxStyle.Critical, "search and replace error")
            Exit Sub
        End If


        If txtSearchandReplaceReplace.Text = "Replacement String" Or txtSearchandReplaceReplace.Text = "" Then
            MsgBox("Please Enter a Replacement Term", MsgBoxStyle.Critical, "search and replace error")
            Exit Sub
        End If
        '=========== Error Checking ===============
        SearchandReplace(txtSearchandReplaceSearch.Text, txtSearchandReplaceReplace.Text)
    End Sub

    Private Sub chkRegex_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRegex.CheckedChanged
        If chkRegex.Checked Then
            btnShowRegexHelp.Visible = True
            chkTestMode.Enabled = True
            chkTestMode.Checked = True
        Else
            If chkRegexRemove.Checked = False Then
                btnShowRegexHelp.Visible = False
            End If
            chkTestMode.Enabled = False
            chkTestMode.Checked = False
        End If
    End Sub

    Private Sub btnShowRegexHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowRegexHelp.Click
        frmRegExHelp.Show()
    End Sub

    '===========================================================================================================================
    '                                           Error Checking
    '===========================================================================================================================

    Public Function CheckforPathError() As Boolean
        Dim foundError As Boolean = False
        If txtDirectory.Text = "Path To Directory" Or txtDirectory.Text = "" Then
            MsgBox("You need to select a path first.", MsgBoxStyle.Critical, "Error in pathname")
            foundError = True
        End If

        If Directory.Exists(txtDirectory.Text) = False Then
            MsgBox("The path " & txtDirectory.Text & " Does not exist", MsgBoxStyle.Critical, "Error in pathname")
            foundError = True
        End If

        CheckforPathError = foundError
    End Function

    '===========================================================================================================================
    '                                           File Functions
    '===========================================================================================================================

    Public Sub GetFileArray()
        FileList = Directory.GetFiles(txtDirectory.Text)
    End Sub

    Public Function ExtractFileNamefromPath(ByVal FullPathName As String) As String
        ExtractFileNamefromPath = Mid(FullPathName, InStrRev(FullPathName, "\") + 1)
    End Function

    Private Sub SearchandRemove(ByVal SearchTerm As String)
        Dim JustFileName As String
        Dim TestModeBuffer As String = ""

        GetFileArray()
        For Each fileNameToProcess In FileList
            JustFileName = ExtractFileNamefromPath(fileNameToProcess)
            If chkRegexRemove.Checked Then
                If chkTestRemove.Checked Then
                    TestModeBuffer &= Regex.Replace(JustFileName, SearchTerm, "") & vbCrLf
                Else
                    JustFileName = Regex.Replace(JustFileName, SearchTerm, "")
                    System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                End If
            Else
                JustFileName = JustFileName.Replace(SearchTerm, "")
                System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
            End If
        Next fileNameToProcess

        If chkTestRemove.Checked Then
            MsgBox(TestModeBuffer)
        Else
            MsgBox("Search and Remove Complete!", MsgBoxStyle.Information, "Done!")
        End If
    End Sub

    Private Sub SearchandReplace(ByVal SearchTerm As String, ByVal Replacementtxt As String)
        Dim JustFileName As String = ""
        Dim TestModeBuffer As String = ""

        GetFileArray()
        For Each fileNameToProcess In FileList
            JustFileName = ExtractFileNamefromPath(fileNameToProcess)

            If chkRegex.Checked Then
                If chkTestMode.Checked Then
                    TestModeBuffer &= Regex.Replace(JustFileName, SearchTerm, Replacementtxt) & vbCrLf
                Else
                    JustFileName = Regex.Replace(JustFileName, SearchTerm, Replacementtxt)
                    System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                End If
            Else
                JustFileName = JustFileName.Replace(SearchTerm, Replacementtxt)
                System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
            End If
        Next fileNameToProcess
        If chkTestMode.Checked Then
            MsgBox(TestModeBuffer)
        Else
            MsgBox("Search and Replace Complete!", MsgBoxStyle.Information, "Done!")
        End If
    End Sub

    Private Sub StripXfromBeginning(ByVal strip As Integer)
        Dim JustFileName As String
        Dim attributes As FileAttributes


        GetFileArray()
        For Each fileNameToProcess In FileList
            JustFileName = ExtractFileNamefromPath(fileNameToProcess)
            attributes = File.GetAttributes(fileNameToProcess)
            If (attributes And FileAttributes.System) = FileAttributes.System Then
                ' ALWAYS Ignore SYSTEM files
            Else
                ' Check for hidden files
                If (attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    If chkIgonreHidden.Checked = False Then
                        If Strings.Right(JustFileName, Len(txtStripX.Text)) = txtStripX.Text Then
                            JustFileName = Mid(JustFileName, strip + 1)
                            System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                        End If
                    End If
                Else

                    If Strings.Right(JustFileName, Len(txtStripX.Text)) = txtStripX.Text Then
                        JustFileName = Mid(JustFileName, strip + 1)
                        System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                    End If
                End If
            End If
        Next fileNameToProcess
        MsgBox("Strip X From Beginning Complete!", MsgBoxStyle.Information, "Done!")
    End Sub

    Private Sub StripXfromEnd(ByVal strip As Integer)
        Dim JustFileName As String
        Dim attributes As FileAttributes


        GetFileArray()
        For Each fileNameToProcess In FileList
            JustFileName = ExtractFileNamefromPath(fileNameToProcess)
            attributes = File.GetAttributes(fileNameToProcess)
            If (attributes And FileAttributes.System) = FileAttributes.System Then
                ' ALWAYS Ignore SYSTEM files
            Else
                ' Check for hidden files
                If (attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    If chkIgonreHidden.Checked = False Then
                        If Strings.Right(JustFileName, Len(txtStripX.Text)) = txtStripX.Text Then
                            JustFileName = Mid(JustFileName, 1, Len(JustFileName) - (strip + Len(txtStripX.Text))) & txtStripX.Text
                            System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                        End If
                    End If
                Else

                    If Strings.Right(JustFileName, Len(txtStripX.Text)) = txtStripX.Text Then
                        JustFileName = Mid(JustFileName, 1, Len(JustFileName) - (strip + Len(txtStripX.Text))) & txtStripX.Text
                        System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                    End If
                End If
            End If
        Next fileNameToProcess
        MsgBox("Strip X From End Complete!", MsgBoxStyle.Information, "Done!")
    End Sub

    Private Sub BtnProperCase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProperCase.Click
        '=========== Error Checking ===============
        If CheckforPathError() = True Then Exit Sub
        '=========== Error Checking ===============

        Dim JustFileName As String
        Dim JustFileNameNoExt As String
        Dim attributes As FileAttributes

        GetFileArray()

        For Each fileNameToProcess In FileList
            attributes = File.GetAttributes(fileNameToProcess)
            If (attributes And FileAttributes.System) = FileAttributes.System Then
                ' ALWAYS Ignore SYSTEM files
            Else
                If (attributes And FileAttributes.Hidden) = FileAttributes.Hidden Then
                    ' ALWAYS Ignore Hidden files
                Else
                    JustFileName = ExtractFileNamefromPath(fileNameToProcess)
                    JustFileNameNoExt = Mid(JustFileName, 1, InStrRev(JustFileName, ".") - 1)
                    JustFileName = JustFileName.Replace(JustFileNameNoExt, StrConv(JustFileNameNoExt, VbStrConv.ProperCase))
                    System.IO.File.Move(fileNameToProcess, txtDirectory.Text & "\" & JustFileName)
                End If
            End If

        Next fileNameToProcess
        MsgBox("Search and Remove Complete!", MsgBoxStyle.Information, "Done!")
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        frmAbout.Show()
    End Sub

End Class
