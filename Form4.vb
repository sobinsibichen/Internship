Imports System.IO

Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim writer As New StreamWriter("D:\transpace\Exported txt\info on io.txt")

        For i As Integer = 0 To Form3.DataGridView1.Rows.Count - 2 Step +1

            For j As Integer = 0 To Form3.DataGridView1.Columns.Count - 1 Step +1

                ' if last column
                If j = Form3.DataGridView1.Columns.Count - 1 Then
                    writer.Write(vbTab & Form3.DataGridView1.Rows(i).Cells(j).Value.ToString())
                Else
                    writer.Write(vbTab & Form3.DataGridView1.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                End If


            Next j

            writer.WriteLine("")

        Next i

        writer.Close()
        MessageBox.Show("Data Exported")


        Dim writer1 As New StreamWriter("D:\transpace\Exported txt\input.txt")

        For i As Integer = 0 To Form3.DataGridView2.Rows.Count - 2 Step +1

            For j As Integer = 0 To Form3.DataGridView2.Columns.Count - 1 Step +1

                ' if last column
                If j = Form3.DataGridView1.Columns.Count - 1 Then
                    writer1.Write(vbTab & Form3.DataGridView2.Rows(i).Cells(j).Value.ToString())
                Else
                    writer1.Write(vbTab & Form3.DataGridView2.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                End If


            Next j

            writer1.WriteLine("")

        Next i

        writer1.Close()



        Dim writer2 As New StreamWriter("D:\transpace\Exported txt\output.txt")

        For i As Integer = 0 To Form3.DataGridView3.Rows.Count - 2 Step +1

            For j As Integer = 0 To Form3.DataGridView3.Columns.Count - 1 Step +1

                ' if last column
                If j = Form3.DataGridView1.Columns.Count - 1 Then
                    writer2.Write(vbTab & Form3.DataGridView3.Rows(i).Cells(j).Value.ToString())
                Else
                    writer2.Write(vbTab & Form3.DataGridView3.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                End If


            Next j

            writer2.WriteLine("")

        Next i

        writer2.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        For i = 0 To Form3.DataGridView1.RowCount - 2
            For j = 0 To Form3.DataGridView1.ColumnCount - 1
                For k As Integer = 1 To Form3.DataGridView1.Columns.Count
                    xlWorkSheet.Cells(1, k) = Form3.DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = Form3.DataGridView1(j, i).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet.SaveAs("D:\transpace\Exported excel\info on io.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)


        Dim xlApp1 As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook1 As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet1 As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue1 As Object = System.Reflection.Missing.Value
        Dim i1 As Integer
        Dim j1 As Integer
        xlApp1 = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook1 = xlApp1.Workbooks.Add(misValue1)
        xlWorkSheet1 = xlWorkBook1.Sheets("sheet1")
        For i1 = 0 To Form3.DataGridView2.RowCount - 2
            For j1 = 0 To Form3.DataGridView2.ColumnCount - 1
                For k As Integer = 1 To Form3.DataGridView2.Columns.Count
                    xlWorkSheet1.Cells(1, k) = Form3.DataGridView2.Columns(k - 1).HeaderText
                    xlWorkSheet1.Cells(i1 + 2, j1 + 1) = Form3.DataGridView2(j1, i1).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet1.SaveAs("D:\transpace\Exported excel\input.xlsx")
        xlWorkBook1.Close()
        xlApp1.Quit()
        releaseObject(xlApp1)
        releaseObject(xlWorkBook1)
        releaseObject(xlWorkSheet1)




        Dim xlApp2 As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook2 As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet2 As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue2 As Object = System.Reflection.Missing.Value
        Dim i2 As Integer
        Dim j2 As Integer
        xlApp2 = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook2 = xlApp2.Workbooks.Add(misValue2)
        xlWorkSheet2 = xlWorkBook2.Sheets("sheet1")
        For i2 = 0 To Form3.DataGridView3.RowCount - 2
            For j2 = 0 To Form3.DataGridView3.ColumnCount - 1
                For k As Integer = 1 To Form3.DataGridView3.Columns.Count
                    xlWorkSheet2.Cells(1, k) = Form3.DataGridView3.Columns(k - 1).HeaderText
                    xlWorkSheet2.Cells(i2 + 2, j2 + 1) = Form3.DataGridView3(j2, i2).Value.ToString()
                Next
            Next
        Next
        xlWorkSheet2.SaveAs("D:\transpace\Exported excel\output.xlsx")
        xlWorkBook2.Close()
        xlApp2.Quit()
        releaseObject(xlApp2)
        releaseObject(xlWorkBook2)
        releaseObject(xlWorkSheet2)
        MsgBox("Succesfully Exported As Excel")

    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class