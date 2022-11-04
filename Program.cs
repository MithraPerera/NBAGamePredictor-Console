using System.Formats.Asn1;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using NBAGamePredictor;

string csv_file_path = @"/Users/mithraperera/DEV/PROJECTS/NBA Game Predictor/NBAGamePredictor/nba-2021-UTC.csv";

var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    PrepareHeaderForMatch = args => args.Header.ToLower().Trim(),
};

using (var reader = new StreamReader(csv_file_path))
using (var csv = new CsvReader(reader, config))
{
    var records = csv.GetRecords<NbaGame>();
    Console.WriteLine(records);
}