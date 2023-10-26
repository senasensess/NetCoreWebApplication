
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using System.IO;


namespace NetCoreWebApplication.Utils
{
    public class FileHelper
    {
        public static string FileLoader(IFormFile formFile ,string filePath ="/Img/")
        {
            var fileName = "";
            if (formFile != null && formFile.Length>0)
            {
                fileName=formFile.FileName;
                string directory = Directory.GetCurrentDirectory() + "/wwwroot" + filePath + fileName;
                using(var strem=new FileStream(directory,FileMode.Create))
                {
                    formFile.CopyTo(strem);
                }
            }

           
            return fileName;
        }

        public static bool FileTerminator( string fileName, string filePath = "/Img/")
        {
            string deletedFile = Directory.GetCurrentDirectory() + "/wwwroot" + filePath + fileName;
            if (File.Exists(deletedFile))
            {
                File.Delete(deletedFile);
                return true;
            }
            return false;
        }
    }
}
