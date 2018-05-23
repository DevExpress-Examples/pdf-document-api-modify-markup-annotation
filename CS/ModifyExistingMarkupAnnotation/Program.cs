using DevExpress.Pdf;
using System;
using System.Collections.Generic;

namespace ModifyExistingMarkupAnnotation {

    class Program {
        static void Main(string[] args) {

            // Create a PDF Document Processor.
            using (PdfDocumentProcessor processor = new PdfDocumentProcessor()) {

                // Load a document.
                processor.LoadDocument("..\\..\\Document.pdf");

                // Get a list of annotations in the first document page.
                IList<PdfMarkupAnnotationData> annotations = processor.GetMarkupAnnotationData(1);

                if (annotations.Count > 0) {

                    // Change the properties of the first annotation.
                    annotations[0].Author = "Bill Smith";
                    annotations[0].Contents = "Important!";
                    annotations[0].Color = new PdfRGBColor(0.6, 0.7, 0.3);
                    annotations[0].Opacity = 0.2;

                    // Save the result document.
                    processor.SaveDocument("..\\..\\Result.pdf");
                }
                else
                    Console.WriteLine("The specified document page does not contain markup annotations!");
            }
        }
    }
}


