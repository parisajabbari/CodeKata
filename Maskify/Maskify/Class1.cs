using System;

namespace Maskify
{
    public static class Kata
    {
        public static string Maskify(string strInput)
        {
            
            if( strInput.Length < 4 )
            {
                return strInput;
            }
            
            var iRevertStringLengh = strInput.Length - 4;

            string strOutput = "";
            
            for (int i = 0; i < iRevertStringLengh; i++)
            {
                strOutput += '#';               
            }
            strOutput += strInput.Substring(iRevertStringLengh, 4);
            
            return strOutput;
        }
    }
}
