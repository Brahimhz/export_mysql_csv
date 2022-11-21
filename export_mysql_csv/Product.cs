using LINQtoCSV;

namespace export_mysql_csv
{

    class Product
    {
        [CsvColumn(Name = "ProductName", FieldIndex = 1)]
        public string Name { get; set; }
        [CsvColumn(FieldIndex = 2, OutputFormat = "dd MMM HH:mm:ss")]
        public DateTime LaunchDate { get; set; }
        [CsvColumn(FieldIndex = 3, CanBeNull = false, OutputFormat = "C")]
        public decimal Price { get; set; }
        [CsvColumn(FieldIndex = 4)]
        public string Country { get; set; }
        [CsvColumn(FieldIndex = 5)]
        public string Description { get; set; }
    }
}
