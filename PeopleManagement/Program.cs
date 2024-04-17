string filePath = @"C:\Users\ASUS ZENBOOK\Desktop\Intern\PeopleManagement\People.csv";

 CSVParser csvParser = new CSVParser();
 csvParser.Parse(filePath);
 csvParser.PrintNames();