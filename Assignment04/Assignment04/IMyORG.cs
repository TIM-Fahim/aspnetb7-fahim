using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04
{
    //internal class IMyORG
    //{
    //}

    public interface IMyORM
    {
        Task ExecuteCommandAsync(string command, Dictionary<string, object> parameters,
            CommandType commandType);
        Task<List<Dictionary<string, object>>> GetDataAsync(string command,
            Dictionary<string, object> parameters, CommandType commandType);
    }
}
