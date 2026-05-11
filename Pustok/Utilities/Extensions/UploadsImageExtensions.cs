namespace EF_core_task.Utilities.Extensions
{
    public static class UploadsImageExtensions
    {
        public static string SaveImage(this IFormFile formFile, IWebHostEnvironment environment, string folder)
        {
            string path = Path.Combine(environment.WebRootPath, folder);
            string fileName = Guid.NewGuid() + formFile.FileName;
            string fullPath = Path.Combine(path, fileName);

            using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
            {
                formFile.CopyTo(fileStream);
            }
            return fileName;
        }
    }
}
