using System;
using System.Data;

namespace ConApp_ADO.NET {
    public class Data {
        DataTable cars = new DataTable ();
        public void AddCols () {
            DataColumn vin = new DataColumn ("Vin");
            vin.DataType = typeof (string);
            vin.MaxLength = 23;
            vin.AllowDBNull = false;
            vin.Unique = true;
            vin.Caption = "VIN";
            cars.Columns.Add (vin);

            DataColumn brand = new DataColumn ("Brand");
            brand.DataType = typeof (string);
            brand.AllowDBNull = false;
            brand.MaxLength = 35;
            cars.Columns.Add (brand);

            DataColumn model = new DataColumn ("Model");
            model.DataType = typeof (string);
            model.AllowDBNull = false;
            model.MaxLength = 15;
            cars.Columns.Add (model);

            DataColumn year = new DataColumn ("Year", typeof (int));
            year.AllowDBNull = false;
            cars.Columns.Add (year);

            DataColumn bm = new DataColumn ("Brand and Model");
            bm.Expression = "Brand + ' ' + Model";
            cars.Columns.Add (bm);

            cars.PrimaryKey = new DataColumn[] { vin };
        }
        public void AddRows () {
            DataRow newCar = cars.NewRow ();
            newCar["Vin"] = "987654321";
            newCar["Brand"] = "Ford";
            newCar["Model"] = "GH254";
            newCar["Year"] = 2010;
            cars.Rows.Add (newCar);

            cars.Rows.Add ("123456789", "Audi", "AX150", 2012);
            cars.Rows.Add ("213456789", "Nexus", "NX205", 2013);

            cars.LoadDataRow (new object[] { "213456789", "Nano", "ST400", 2015 }, LoadOption.OverwriteChanges);
        }
        public void GetColInfo () {
            System.Console.WriteLine ("\n\n__________Column Information__________\n");
            foreach (DataColumn col in cars.Columns) {
                System.Console.WriteLine ("Column Name: {0}, DataType: {1}", col, col.DataType);
            }
        }
        public void ShowAllRows () {
            System.Console.WriteLine ("\n\n__________All Data__________\n");
            foreach (DataRow row in cars.Rows)
            {
                foreach (DataColumn col in cars.Columns)
                {
                    System.Console.Write(row[col] + "\t");
                }
                System.Console.WriteLine();
            }
        }
    }
}