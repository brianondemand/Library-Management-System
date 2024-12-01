Imports System.Speech.Synthesis

Public Class Form1
    Dim sapi As New SpeechSynthesizer

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            If txtusername.Text = "Library" And txtpassword.Text = "123@" Then
                sapi.SpeakAsync("Hey Mercy You have successfully logged in to the library management system")
                Form2.Show()
                Me.Hide()

            Else
                sapi.SpeakAsync("Invalid login details")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnreset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnreset.Click
        Try
            Dim ireset As DialogResult
            sapi.SpeakAsync("Confirm if you want to reset")
            ireset = MessageBox.Show("Confirm if you want to reset", "Login system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If (ireset = DialogResult.Yes) Then
                txtusername.Text = ""
                txtpassword.Clear()
                txtusername.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Try
            Dim iexit As DialogResult
            sapi.SpeakAsync("Confirm if you want to exit")
            iexit = MessageBox.Show("Confirm if you want to exit", "Login system", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If (iexit = DialogResult.Yes) Then
                Application.Exit()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub
End Class
