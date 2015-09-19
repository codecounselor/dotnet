using System;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data
{
  [TestClass]
  public class ExcelReaderTest
  {
    [TestMethod]
    public void readFile()
    {
      ExcelReader reader = new ExcelReader();
      DataSource ds = reader.readFile("c:\\development\\testFile.xlsx");
    }
  }
}