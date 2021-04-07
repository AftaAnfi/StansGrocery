Option Strict On
Option Explicit On
'Aftanom Anfilofieff
'RCET0265
'Spring 2021
'Stan's Grocery
'https://github.com/AftaAnfi/StansGrocery.git

Public Class StansGroceryForm
    Dim groceryArray(256, 2) As String
    Dim categoryArray() As String

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempArray() As String = Split(My.Resources.Grocery, vbNewLine)

        'cycled through the tempArray
        For i = 0 To (tempArray.GetUpperBound(0))
            Dim tempTwoArray() As String = Split(tempArray(i), ",")

            'Loads the name of the item
            Dim thirdArray() As String = Split(tempTwoArray(0), "ITM")
            groceryArray(i, 0) = thirdArray(1).Trim(Chr(34), Chr(35), Chr(36), Chr(37), Chr(42))

            'load the location of the item
            Dim fourthArray() As String = Split(tempTwoArray(1), "LOC")
            groceryArray(i, 1) = fourthArray(1).Trim(Chr(34), Chr(35), Chr(36), Chr(37), Chr(42))

            'load the category of the item 
            Dim fifthArray() As String = Split(tempTwoArray(2), "CAT")
            groceryArray(i, 2) = fifthArray(1).Trim(Chr(34), Chr(35), Chr(36), Chr(37), Chr(42))

        Next

        'load the items from the array to the displaybox
        LoadAllItemsToDisplayBoxCat("")

        'add show all to the combobox and set the index to it
        FilterComboBox.Items.Add("Show All")
        FilterComboBox.SelectedIndex = 0

        'set filtercombobox to all aisles
        '---------------------------------
        FilterComboBox.Items.Clear()

        If FilterByAisleRadioButton.Checked = True Then

            'change combo box to have all aisles from groceryArray
            For i = 0 To 255

                'no aisles added if blank
                If groceryArray(i, 1) = "" Then
                Else
                    'add only distinct items
                    If FilterComboBox.Items.Contains(groceryArray(i, 1).ToString.PadLeft(2)) Then
                    Else
                        FilterComboBox.Items.Add((groceryArray(i, 1).ToString.PadLeft(2)))
                    End If
                End If
            Next

            'sort the items numerically 
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False


            'insert the show all to the filtercombobox and make that the selected index
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0
        End If
        '---------------------------------

        'set displayLabel to not selected item
        DisplayLabel.Text = "No Item Selected"


    End Sub

    Sub LoadAllItemsToDisplayBoxCat(ByVal catName As String)
        DisplayListBox.Items.Clear()
        'cycle through the entire groceryArray
        For i = 0 To 255

            'add the item name to the listbox if it is not blank
            If groceryArray(i, 0).ToString = "" Then
            Else
                'only add distinct values
                If DisplayListBox.Items.Contains(groceryArray(i, 0).ToString) Then
                Else
                    'only add the non-blank items
                    If groceryArray(i, 2).ToString = catName Then
                        DisplayListBox.Items.Add(groceryArray(i, 0).ToString)
                    ElseIf catName = "" Then
                        DisplayListBox.Items.Add(groceryArray(i, 0).ToString)
                    End If

                End If
            End If
        Next
    End Sub

    Sub LoadAllItemsToDisplayBoxLoc(ByVal locName As String)
        DisplayListBox.Items.Clear()
        'cycle through the entire groceryArray
        For i = 0 To 255

            'add the item name to the listbox if it is not blank
            If groceryArray(i, 0).ToString = "" Then
            Else
                'only add distinct values
                If DisplayListBox.Items.Contains(groceryArray(i, 0).ToString) Then
                Else
                    'only add the non-blank items
                    If groceryArray(i, 1).ToString = locName Then
                        DisplayListBox.Items.Add(groceryArray(i, 0).ToString)
                    ElseIf locName = "" Then
                        DisplayListBox.Items.Add(groceryArray(i, 0).ToString)
                    End If

                End If
            End If
        Next
    End Sub

    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        'exit program if user enters zzz into searchtextbox
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        End If
    End Sub

    'find the indexvalue from groceryArray from an itemName
    Function FindItemFromName(ByVal itemName As String) As Integer
        Dim indexValue As Integer = -1

        'check all values to see if itemname matches one in array
        For i = 0 To 255
            If itemName = (groceryArray(i, 0).ToString) Then
                Return i
            End If
        Next

        'if no values equal itemName return -1
        Return -1
    End Function

    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged
        Dim selectedItemName As String = DisplayListBox.SelectedItem.ToString
        Dim selectedItemLoc As String = groceryArray(FindItemFromName(selectedItemName), 1)
        Dim selectedItemCat As String = groceryArray(FindItemFromName(selectedItemName), 2)

        'display the item selected in the displaylistbox
        DisplayLabel.Text = "You will find " & selectedItemName & " on aisle " & selectedItemLoc & " with the " & selectedItemCat

    End Sub

    Sub DisplayAllFromString(ByVal itemName As String)
        'clear the displaylsitbox of its items
        DisplayListBox.Items.Clear()

        'make sure the itemName is not blank
        If itemName = "" Then
        Else
            'cycle through all items of groceryArray
            For i = 0 To 255
                'add items that contain the itemName text
                If groceryArray(i, 0).Contains(itemName) Then
                    'add only distinct items
                    If DisplayListBox.Items.Contains(groceryArray(i, 0).ToString) Then
                    Else
                        'add the item to the displaybox
                        DisplayListBox.Items.Add(groceryArray(i, 0))
                    End If
                End If
            Next
        End If

    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click, SearchToolStripMenuItem1.Click
        'display the items that match the string
        DisplayAllFromString(SearchTextBox.Text)

        'if there is no items added, prompt user and reset textbox
        If DisplayListBox.Items.Count = 0 Then
            DisplayLabel.Text = ($"Sorry no matches for {SearchTextBox.Text}")
            SearchTextBox.Text = ""

            'call the FilterByAisleRadioButton_click function to redo processes
            '-----------------------------------------
            FilterByAisleRadioButton.Checked = True
            LoadAllItemsToDisplayBoxLoc("")
            '-----------------------------------------
        End If


        FilterComboBox.SelectedItem = "Show All"

        'set filter back to default
        FilterByAisleRadioButton.Checked = True


    End Sub

    Private Sub FilterByAisleRadioButton_CheckChanged(sender As Object, e As EventArgs) Handles FilterByAisleRadioButton.Click
        FilterComboBox.Items.Clear()

        If FilterByAisleRadioButton.Checked = True Then

            'change combo box to have all aisles from groceryArray
            For i = 0 To 255

                'no aisles added if blank
                If groceryArray(i, 1) = "" Then
                Else
                    'add only distinct items
                    If FilterComboBox.Items.Contains(groceryArray(i, 1).ToString.PadLeft(2)) Then
                    Else
                        FilterComboBox.Items.Add((groceryArray(i, 1).ToString.PadLeft(2)))
                    End If
                End If
            Next

            'sort the items numerically 
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False


            'insert the show all to the filtercombobox and make that the selected index
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0

            'redisplay the items
            LoadAllItemsToDisplayBoxCat("")
        End If

    End Sub

    Private Sub FilterByCategoryRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles FilterByCategoryRadioButton.CheckedChanged
        FilterComboBox.Items.Clear()

        If FilterByCategoryRadioButton.Checked = True Then

            'change combo box to have all categories from groceryArray
            For i = 0 To 255
                'only non-blank categories to be added to combobox
                If (groceryArray(i, 2).ToString) = "" Then
                Else
                    'only add distinct categories
                    If FilterComboBox.Items.Contains(groceryArray(i, 2)) Then
                    Else
                        FilterComboBox.Items.Add((groceryArray(i, 2).ToString))
                    End If
                End If
            Next

            'sort the items alphabetically
            FilterComboBox.Sorted = True
            FilterComboBox.Sorted = False

            'insert the show all to the filtercombobox and make that the selected index
            FilterComboBox.Items.Insert(0, "Show All")
            FilterComboBox.SelectedIndex = 0

            'redisplay the items
            LoadAllItemsToDisplayBoxCat("")
        End If
    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FilterComboBox.SelectedIndexChanged
        If FilterComboBox.Items.Count > 0 Then
            'sort by category and load those items to the displayListBox
            If FilterByCategoryRadioButton.Checked Then
                If FilterComboBox.SelectedItem.ToString = "Show All" Then
                    'load all items if show all is selected
                    LoadAllItemsToDisplayBoxCat("")
                Else
                    'load all the items pertaining to the selected item in comboBox
                    LoadAllItemsToDisplayBoxCat(FilterComboBox.SelectedItem.ToString)
                End If
            ElseIf FilterByAisleRadioButton.Checked Then
                If FilterComboBox.SelectedItem.ToString = "Show All" Then
                    LoadAllItemsToDisplayBoxLoc("")
                Else

                    'load the items for location and add filtercombobox.selecteditem.tostring - blank spaces
                    LoadAllItemsToDisplayBoxLoc(FilterComboBox.SelectedItem.ToString.Trim)

                End If
            End If
        End If


    End Sub

    Sub ExitProgram() Handles ExitToolStripMenuItem.Click, ExitToolStripMenuItem1.Click
        Me.Close()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
        Me.Hide()
    End Sub
End Class
