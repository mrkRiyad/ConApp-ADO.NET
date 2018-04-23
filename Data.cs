using System;
using System.Data;

namespace ConApp_ADO.NET
{
    public class Data
    {
        DataTable cars = new DataTable();
        public void AddCols() 
        {
            DataColumn vin = new DataColumn("Vin");
            vin.DataType = typeof(string);
            vin.MaxLength = 23;
            vin.AllowDBNull = false;
            vin.Unique = true;
            vin.Caption = "VIN";
            cars.Columns.Add(vin);

            DataColumn brand = new DataColumn("Brand");
            brand.DataType = typeof(string);
            brand.AllowDBNull = false;
            brand.MaxLength = 35;
            cars.Columns.Add(brand);

            DataColumn model = new DataColumn("Model");
            model.DataType = typeof(string);
            model.AllowDBNull = false;
            model.MaxLength = 15;
            cars.Columns.Add(model);

            DataColumn year = new DataColumn("Year", typeof(int));
            year.AllowDBNull = false;
            year.MaxLength = 4;
            cars.Columns.Add(year);

            DataColumn bm = new DataColumn("Brand and Model");
            bm.Expression = "Brand + ' ' + Model";
            cars.Columns.Add(bm);
        }
    }
}