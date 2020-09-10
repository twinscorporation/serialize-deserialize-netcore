using System;
using NUnit.Framework;

namespace serialize_deserialize_netcore
{
    public class GeneralHelpers
    {

        public static string GetProjectPath()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;

            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));

            return new Uri(actualPath).LocalPath;
        }


    }//end class
}//end namespace