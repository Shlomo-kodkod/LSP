using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    //not implemnt LSP
    //internal class DocumentExporter
    //{
    //    public virtual void ExportToPDF()
    //    {
    //        Console.WriteLine("Export");
    //    }
    //}

    //internal class OnlineExporter : DocumentExporter
    //{
    //    public override void ExportToPDF()
    //    {
    //        throw new Exception("can't export");
    //    }
    //}

    //internal static class Test3
    //{
    //    public static void ExportDocument(DocumentExporter exporter)
    //    {
    //        exporter.ExportToPDF();
    //    }
    //}


    //implemnt LSP
    internal interface IPdfExportable
    {
        public void ExportToPDF();
    }

    internal interface IHtmlExportable
    {
        public void ExportToHTML();
    }

    internal class DocumentExporter : IPdfExportable
    {
        public void ExportToPDF()
        {
            Console.WriteLine("Export pdf");
        }
    }

    internal class OnlineExporter : IHtmlExportable
    {
        public void ExportToHTML()
        {
            Console.WriteLine("Export html");
        }
    }

    
}
