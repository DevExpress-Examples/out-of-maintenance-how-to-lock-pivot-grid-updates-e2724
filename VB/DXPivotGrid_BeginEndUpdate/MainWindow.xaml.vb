Imports System
Imports System.Data
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid

Namespace DXPivotGrid_BeginEndUpdate

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = GetDataTable()
        End Sub

        Private Sub btnRun_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim startTime As Date = Date.Now
            ' If an appropriate option is enabled, 
            ' locks the pivot grid to prevent further updates.
            If Me.rbLocked.IsChecked = True Then Me.pivotGridControl1.BeginUpdate()
            Try
                ' Initiates transposition.
                Transpose()
            Finally
                ' If the pivot grid has been locked, unlocks it, allowing further updates.
                If Me.rbLocked.IsChecked = True Then Me.pivotGridControl1.EndUpdate()
            End Try

            ' Displays the amount of time taken by the transposition.
            Dim duration As TimeSpan = Date.Now - startTime
            MessageBox.Show("Transposition took " & duration.TotalSeconds.ToString("F2") & " seconds")
        End Sub

        ' Transposes the pivot grid by moving Row Fields to the Column Area, and vice versa.
        Private Sub Transpose()
            For Each field As PivotGridField In Me.pivotGridControl1.Fields
                If field.Area = FieldArea.RowArea Then
                    field.Area = FieldArea.ColumnArea
                ElseIf field.Area = FieldArea.ColumnArea Then
                    field.Area = FieldArea.RowArea
                End If
            Next
        End Sub

        ' Generates pivot grid data.
        Public Shared Function GetDataTable() As DataTable
            Dim table As DataTable = New DataTable()
            table.Columns.Add("A", GetType(String))
            table.Columns.Add("B", GetType(String))
            table.Columns.Add("Data", GetType(Integer))
            For i As Integer = 0 To 1000 - 1
                For j As Integer = 0 To 500 - 1
                    table.Rows.Add("A"c & i.ToString(), "B"c & j.ToString(), (CInt(i) \ 100))
                Next
            Next

            Return table
        End Function
    End Class
End Namespace
