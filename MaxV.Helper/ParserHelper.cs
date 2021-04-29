using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MaxV.Helper
{
    public static class ParserHelper
    {
        /// <summary>
        /// Parse a object to string of json structure
        /// </summary>
        public static string TryParseToString<T>(T data)
        {
            string result = string.Empty;
            try
            {
                result = JsonConvert.SerializeObject(data);
                return result;
            }
            catch
            {
                return result;
            }
        }
    }
}
