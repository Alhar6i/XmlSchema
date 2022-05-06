using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using U8Xml;
using Xsd2Code.XmlSchema.UBL;

namespace ConsoleAppUBL
{
    class Program
    {
        static void Main(string[] args)
        {

            string inFile = @"C:\Users\User\Downloads\Zakat\zatca-envoice-sdk_28102021-V1.0.1.0\Samples\VaildInvoices\StandardTaxInvoices\Tax_Invoice.xml";
            string outFile = @"C:\Users\User\Downloads\Zakat\zatca-envoice-sdk_28102021-V1.0.1.0\Samples\VaildInvoices\StandardTaxInvoices\Tax_Invoice_Copy.xml";

            Console.WriteLine("Hello UBL World!");

            Console.WriteLine("Load XML UBL file");
            InvoiceType invoice = InvoiceType.LoadFromFile(inFile);

            //byte[] d1 = Encoding.ASCII.GetBytes("NWZlY2ViNjZmZmM4NmYzOGQ5NTI3ODZjNmQ2OTZjNzljMmRiYzIzOWRkNGU5MWI0NjcyOWQ3M2EyN2ZiNTdlOQ==");
            //byte[] d2 = Encoding.ASCII.GetBytes("AQ1PbWFyIEhvc3BpdGFsAg8zMTAxMjIzOTM1MDAwMDMDFDIwMjEtMDEtMDVUMDk6MzI6NDBaBAYyNTAuMDAFBDAuMDAGLCtuTWtYTUUydFNvdnlrTEtVNlZVbklxODY2N1NNQ29jNkE3dEtjTUtwWTA9B4GwMzA1NjMwMTAwNjA3MmE4NjQ4Y2UzZDAyMDEwNjA1MmI4MTA0MDAwYTAzNDIwMDA0OTZlOGM0OTQwM2ZjMDk0NWM4ZjQwMjU4Y2RkMmQ5ZTkzMDFhNzkyMTJhOTNhN2M4ZmZhZDhlYzJkODE1YzI1ZjJjYjRkZDVmZTUzZmI4ZTdkMGI0YTAyNmZjYTQ1NzIzNTEzZDc3YzBlMzM4ZTkxNTE2OGU1MGQ1OTQwNGRiOTQIIHfALLWTvHti3jFaD8cZAR+Wuh5YLfRsOSgOpN29UPwiCSAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA==");
            //invoice.AdditionalDocumentReference[1].Attachment.EmbeddedDocumentBinaryObject.Value = d2;
            //invoice.AdditionalDocumentReference[2].Attachment.EmbeddedDocumentBinaryObject.Value = d1;

            invoice.SaveToFile(outFile);
        }
    }
}
