using AdapterPattern.Library;
using System;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using AdapterPattern.Test;
using System.Data.OleDb;

namespace AdapterPattern
{
    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void RenderOneRowGivenStubDBAdapter()
        {
            var myRenderer = new DataRenderer(new StubDBAdapter());
            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.WriteLine(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }
        [TestMethod]
        public void RenderTwoRowsGivenOleDbDataAdapter()
        {
            var adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM Pattern");
            adapter.SelectCommand.Connection =  new OleDbConnection(@"
              Provider=Microsoft.SQLSERVER.CE.OLEDB.4.0;Data Source=C:\Apps\DesignPatterns\AdapterPattern\Sample.sdf");
            var myRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(4, lineCount);
        }
     }  
   }
