using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
  public class DataSource
  {
    List<DataRow> rows;

    public DataSource(int rowCount)
    {
      rows = new List<DataRow>(rowCount);
    }

    public void addRow(Object[] values)
    {
      rows.Add(new DataRow(values));
    }
  }

  public class DataRow
  {
    List<DataField> fields; 

    public DataRow(object[] values)
    {
      fields = new List<DataField>(values.Length);
      foreach( object f in values)
      {
        fields.Add(new DataField(f));
      }
    }
  }

  public class DataField
  {
    private object f;

    public DataField(object f)
    {
      this.f = f;
    }

    public string GetValue()
    {
      return f?.ToString();
    }
  }
}