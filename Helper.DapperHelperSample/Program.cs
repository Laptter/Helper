
using Dapper;
using System.Data.OleDb;

var path = @"E:\临时\重庆=溯联二厂设备数据库拷贝20220830\SLA-ZP-22\AT_Data.mdb";
var connString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={path}";

IDapperHelper _dapperHelper =
    new DapperHelper<OleDbConnection>(connString);
MySql.Data.MySqlClient.MySqlConnection sq;

var tables = _dapperHelper.GetTables("show tables");

Console.ReadKey();
