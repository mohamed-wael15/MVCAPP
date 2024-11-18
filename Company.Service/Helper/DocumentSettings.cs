using Microsoft.AspNetCore.Http;

namespace Company.Service.Helper
{
    public class DocumentSettings
    {
        public static string UploadFile(IFormFile file , string folderName)
        {
            //1- Get Folder Path
            //var folderPath = @"D:\BackEnd.Net\5-MVC\MVCAPP\\Company.Web\\wwwroot\\Files\\Images\\";
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", folderName);

            //2- Get File Name
            var fileName = $"{Guid.NewGuid()}-{file.FileName}";

            //3- Combine FolderPath + FilePath
            var filepath = Path.Combine(folderPath, fileName);

            //4-Save File
            using var fileStream = new FileStream(filepath, FileMode.Create);

            file.CopyTo(fileStream);

            return fileName;
        }

    }
}
