using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetApplicationStarterPack
{
    public static class FilePack
    {
        public static long GetFileSizeinKB(this string filePath)
        {
            return new System.IO.FileInfo(filePath).Length/1024;            
        }

        public static string GenerateRandomFileName(this string filePath,bool isAppendToExistingFileName=false)
        {
            int timeStamp =(int) DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            string fileExtention = System.IO.Path.GetExtension(filePath);

            if(isAppendToExistingFileName==true)
            {
                string fileName = System.IO.Path.GetFileNameWithoutExtension(filePath);
                return fileName + "_" + timeStamp + fileExtention;
            }

            return timeStamp + fileExtention;
        }
    }
}
