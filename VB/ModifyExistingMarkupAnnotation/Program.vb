Imports DevExpress.Pdf
Imports System
Imports System.Collections.Generic

Namespace ModifyExistingMarkupAnnotation

    Friend Class Program

        Shared Sub Main(ByVal args As String())
            ' Create a PDF Document Processor.
            Using processor As PdfDocumentProcessor = New PdfDocumentProcessor()
                ' Load a document.
                processor.LoadDocument("..\..\Document.pdf")
                ' Get a list of annotations in the first document page.
                Dim annotations As IList(Of PdfMarkupAnnotationData) = processor.GetMarkupAnnotationData(1)
                If annotations.Count > 0 Then
                    ' Change the properties of the first annotation.
                    annotations(0).Author = "Bill Smith"
                    annotations(0).Contents = "Important!"
                    annotations(0).Color = New PdfRGBColor(0.6, 0.7, 0.3)
                    annotations(0).Opacity = 0.2
                    ' Save the result document.
                    processor.SaveDocument("..\..\Result.pdf")
                Else
                    Console.WriteLine("The specified document page does not contain markup annotations!")
                End If
            End Using
        End Sub
    End Class
End Namespace
