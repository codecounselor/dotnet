using System;
using System.Data;
using System.IO;
using Excel;

namespace Data
{
  public class ExcelReader
  {

    public ExcelReader()
    {


    }

    public DataSource readFile(String filePath)
    {
      FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);

      IExcelDataReader excelReader;
      if (filePath.EndsWith("xls"))
      {
        excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
      }
      else
      {
        excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
      }

      //3. DataSet - The result of each spreadsheet will be created in the result.Tables
      excelReader.IsFirstRowAsColumnNames = true;
      DataSet result = excelReader.AsDataSet();

      int rowCount = excelReader.ResultsCount;
      DataSource dataSource = new DataSource(rowCount);

      while (excelReader.Read())
      {
        object[] cells = new object[excelReader.FieldCount];
        for( int c=0; c < excelReader.FieldCount; c++)
        {
          cells[c] = excelReader.GetString(c);
        }
        //excelReader.GetValues(cells);
        dataSource.addRow(cells);
      }

      //6. Free resources (IExcelDataReader is IDisposable)
      excelReader.Close();

      return dataSource;
    }
  }


}
