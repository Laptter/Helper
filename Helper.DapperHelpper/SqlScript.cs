using System.Data;

namespace Dapper
{
    public class SqlScript
    {
        public string Sql { get; internal set; }
        public object Param { get; internal set; }
        public CommandType? CommandType { get; internal set; }
    }
}