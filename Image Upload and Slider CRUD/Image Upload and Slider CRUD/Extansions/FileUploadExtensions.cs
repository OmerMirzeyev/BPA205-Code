namespace Image_Upload_and_Slider_CRUD.Extansions
{
    public static class FileUploadExtensions
    {
        public static string SaveImage(this IFormFile formFile, IWebHostEnvironment environment, string folder)
        {
            string path = Path.Combine(environment.WebRootPath, folder);
            string fileName = Guid.NewGuid() + formFile.FileName;
            string fullPath = Path.Combine(path, fileName);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                formFile.CopyTo(stream);
            }
            return fileName;
        }
    }
}
