# NetLandApp

NetLandApp is a  simple .NET 6 web application that provides a REST API for querying order data stored in a CSV file. 

For api to works correctly we CSV file should be formated like this:

-First row contains column headers.
-Column separator is a comma (,).
-Decimal separator for real numbers is a period (.).
-Date format is dd.MM.yyyy.
-Boolean values are represented as 1 or 0.

Use user secrets to determine csv file path, or set in directly in appsetting.json like this:

{
  "CSVSettings": {
    "OrderCsvPath": "C:\\Users\\YourName\\Documents\\orders.csv"
  }
}
