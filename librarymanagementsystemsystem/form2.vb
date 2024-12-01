Public Class form2
    Dim bookloan As Short

    Private Sub LibraryTBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibraryTBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.LibraryTBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LIBRARYDBDataSet)

    End Sub

    Private Sub form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LIBRARYDBDataSet.LibraryT' table. You can move, or remove it, as needed.
        Me.LibraryTTableAdapter.Fill(Me.LIBRARYDBDataSet.LibraryT)
        DATEBORROWEDTextBox.Text = Today

        cmbsearch.Items.Add("BookID")
        cmbsearch.Items.Add("BookTitle")
        cmbsearch.Items.Add("Author")


    End Sub

    Private Sub DATEDUEBACKTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATEDUEBACKTextBox.TextChanged

    End Sub

    Private Sub LATERETURNFINETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LATERETURNFINETextBox.TextChanged

    End Sub

    Private Sub DATEOVERDUETextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbloverdue.TextChanged

    End Sub

    Private Sub btnborrowed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnborrowed.Click
        Dim bookduedate As Date
        DATEBORROWEDTextBox.Text = Today
        Select Case NumericUpDown1.Value
            Case 0
                bookloan = 1
            Case 1
                bookloan = 3
            Case 2
                bookloan = 5
            Case 3
                bookloan = 10
            Case 4
                bookloan = 15
            Case 5
                bookloan = 20
            Case 6
                bookloan = 25
            Case 7
                bookloan = 25
        End Select
        bookduedate = Today.AddDays(bookloan)
        DATEDUEBACKTextBox.Text = Format(bookduedate, "dddd dd MMMM  yyyy")
    End Sub

    Private Sub btndatereturned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndatereturned.Click
        Dim datedueback As Date
        Dim daysoverdue As Short
        Dim finerate As Decimal
        Dim fine As Decimal
        datedueback = DATEDUEBACKTextBox.Text


        daysoverdue = DateDiff("d", datedueback, DATERETURNEDTextBox.Text)


        '==========================

        Select Case NumericUpDown1.Value
            Case 0
                bookloan = 1
                finerate = 100
            Case 1
                bookloan = 3
                finerate = 200
            Case 2
                bookloan = 10
                finerate = 300
            Case 3
                bookloan = 30
                finerate = 400
            Case 4
                bookloan = 40
                finerate = 500
            Case 5
                bookloan = 10
                finerate = 600
            Case 6
                bookloan = 50
                finerate = 700
            Case 7
                bookloan = 60
                finerate = 800

        End Select

        '==========================

        If daysoverdue <= 0 Then
            daysoverdue = 0
        End If

        If daysoverdue > 0 Then
            fine = finerate * daysoverdue
        Else
            fine = 0
        End If
        lbloverdue.Text = daysoverdue & "days overdue"
        LATERETURNFINETextBox.Text = "fine of " & Format(fine, "currency") & "to pay"
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        Dim library As String
        library = cmbsearch.Text
        Select Case library
            Case "BookID"
                Me.LibraryTBindingSource.Filter = "BookID = '" & txtsearch.Text & "'"
            Case "BookTitle"
                Me.LibraryTBindingSource.Filter = "BookTitle = '" & txtsearch.Text & "'"
            Case "Author"
                Me.LibraryTBindingSource.Filter = "Author = '" & txtsearch.Text & "'"

        End Select

    End Sub
End Class