using System;

namespace ConApp_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.AddCols();
            data.AddRows();
            data.GetColInfo();
            data.ShowAllRows();
        }
    }
}
