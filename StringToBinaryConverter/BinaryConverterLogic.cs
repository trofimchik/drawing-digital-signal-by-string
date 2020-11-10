using System;
using System.Text;

namespace StringToBinaryConverter
{
    public class BinaryConverterLogic
    {
        public static string GetBinaryString(string receivedString, Encoding selectedEncoding)
        {
            byte[] binaryCode = selectedEncoding.GetBytes(receivedString);
            string result = "";

            foreach (byte bit in binaryCode)
            {
                result += Convert.ToString(bit, 2).PadLeft(8, '0') + " ";
            }
            return result;
        }
    }
}
