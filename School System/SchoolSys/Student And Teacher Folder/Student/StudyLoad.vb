Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Drawing.Printing
Imports System.IO

Public Class StudyLoad
    Dim conn As MySqlConnection = Connect.cons

    Private Sub StudyLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the function to load study load
        LoadStudyLoad(dgTables)
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        ExportToPDF(dgTables, "StudyLoad.pdf")
    End Sub



    ' Function to export DataGridView content to PDF with neumorphic-inspired design
    Private Sub ExportToPDF(dgView As DataGridView, fileName As String)
        Dim pdfDoc As New Document(PageSize.A4, 30, 30, 50, 50)
        Dim pdfWriter As PdfWriter = pdfWriter.GetInstance(pdfDoc, New FileStream(fileName, FileMode.Create))
        pdfDoc.Open()

        ' Neumorphic-inspired background color
        Dim backgroundColor As BaseColor = New BaseColor(236, 240, 243) ' Light gray background
        pdfDoc.Add(New Rectangle(pdfDoc.PageSize) With {.BackgroundColor = backgroundColor})

        ' Create the table with the same number of columns as the DataGridView
        Dim pdfTable As New PdfPTable(dgView.ColumnCount)
        pdfTable.WidthPercentage = 100 ' Full width table
        pdfTable.SpacingBefore = 20
        pdfTable.SpacingAfter = 20

        ' Simulating neumorphic effect on table header cells
        For Each column As DataGridViewColumn In dgView.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText, FontFactory.GetFont("Arial", 10, Font.Bold, New BaseColor(69, 90, 100)))) ' Dark text
            cell.BackgroundColor = New BaseColor(255, 255, 255) ' White background for neumorphic look
            cell.BorderWidth = 1
            cell.BorderColor = New BaseColor(189, 189, 189) ' Light border to simulate soft shadows
            cell.Padding = 10
            cell.HorizontalAlignment = Element.ALIGN_CENTER
            cell.VerticalAlignment = Element.ALIGN_MIDDLE
            pdfTable.AddCell(cell)
        Next

        ' Adding rows from DataGridView to the PDF table
        For Each row As DataGridViewRow In dgView.Rows
            If Not row.IsNewRow Then
                For Each cell As DataGridViewCell In row.Cells
                    Dim dataCell As New PdfPCell(New Phrase(cell.Value.ToString(), FontFactory.GetFont("Arial", 9, New BaseColor(60, 60, 60)))) ' Darker text
                    dataCell.BackgroundColor = New BaseColor(255, 255, 255) ' White background for neumorphic effect
                    dataCell.BorderWidth = 1
                    dataCell.BorderColor = New BaseColor(240, 240, 240) ' Light border for soft shadows
                    dataCell.Padding = 8
                    dataCell.HorizontalAlignment = Element.ALIGN_CENTER
                    dataCell.VerticalAlignment = Element.ALIGN_MIDDLE
                    pdfTable.AddCell(dataCell)
                Next
            End If
        Next

        ' Adding a neumorphic-styled header
        Dim titleFont As Font = FontFactory.GetFont("Arial", 16, Font.Bold, New BaseColor(40, 40, 40))
        Dim header As New Paragraph("Study Load Report", titleFont)
        header.Alignment = Element.ALIGN_CENTER
        header.SpacingAfter = 20
        pdfDoc.Add(header)

        ' Add the table to the PDF document
        pdfDoc.Add(pdfTable)

        ' Adding a neumorphic-styled footer
        Dim footerFont As Font = FontFactory.GetFont("Arial", 10, Font.Italic, New BaseColor(90, 90, 90))
        Dim footer As New Paragraph("Generated on: " & DateTime.Now.ToString(), footerFont)
        footer.Alignment = Element.ALIGN_RIGHT
        pdfDoc.Add(footer)

        ' Close the document
        pdfDoc.Close()

        ' Open the PDF after export
        MessageBox.Show("PDF Exported Successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start(fileName) ' This will open the generated PDF file
    End Sub
End Class
