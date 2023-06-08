
Imports ClosedXML.Excel


Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form2.ComboBox1.Text
        TextBox2.Text = Form2.TextBox1.Text
        TextBox3.Text = Form2.TextBox3.Text
        TextBox4.Text = Form2.ComboBox2.Text
        TextBox5.Text = Form2.TextBox2.Text
        TextBox6.Text = Form2.TextBox4.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "D:\transpace\Info on i-o.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try



        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "D:\transpace\INPUT.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView2.DataSource = dataSet.Tables(0)

            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        Try

            Dim MyConnection As System.Data.OleDb.OleDbConnection
            Dim dataSet As System.Data.DataSet
            Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
            Dim path As String = "D:\transpace\output table.xlsx"

            MyConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection)

            dataSet = New System.Data.DataSet
            MyCommand.Fill(dataSet)
            DataGridView3.DataSource = dataSet.Tables(0)

            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim writer As New StreamWriter("D:\transpace\Exported txt\info on io.txt")

        For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1

            For j As Integer = 0 To DataGridView1.Columns.Count - 1 Step +1

                ' if last column
                If j = DataGridView1.Columns.Count - 1 Then
                    writer.Write(vbTab & DataGridView1.Rows(i).Cells(j).Value.ToString())
                Else
                    writer.Write(vbTab & DataGridView1.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                End If


            Next j

            writer.WriteLine("")

        Next i

        writer.Close()
        MessageBox.Show("Data Exported")


        Dim writer1 As New StreamWriter("D:\transpace\Exported txt\input.txt")

        For i As Integer = 0 To DataGridView2.Rows.Count - 2 Step +1

            For j As Integer = 0 To DataGridView2.Columns.Count - 1 Step +1

                ' if last column
                If j = DataGridView1.Columns.Count - 1 Then
                    writer1.Write(vbTab & DataGridView2.Rows(i).Cells(j).Value.ToString())
                Else
                    writer1.Write(vbTab & DataGridView2.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                End If


            Next j

            writer1.WriteLine("")

        Next i

        writer1.Close()



        Dim writer2 As New StreamWriter("D:\transpace\Exported txt\output.txt")

        For i As Integer = 0 To DataGridView3.Rows.Count - 2 Step +1

            For j As Integer = 0 To DataGridView3.Columns.Count - 1 Step +1

                ' if last column
                If j = DataGridView1.Columns.Count - 1 Then
                    writer2.Write(vbTab & DataGridView3.Rows(i).Cells(j).Value.ToString())
                Else
                    writer2.Write(vbTab & DataGridView3.Rows(i).Cells(j).Value.ToString() & vbTab & "|")
                End If


            Next j

            writer2.WriteLine("")

        Next i

        writer2.Close()


    End Sub

End Class