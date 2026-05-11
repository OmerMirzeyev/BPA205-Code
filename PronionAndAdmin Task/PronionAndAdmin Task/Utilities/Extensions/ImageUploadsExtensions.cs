namespace PronionAndAdmin_Task.Utilities.Extensions
{
    public static class ImageUploadsExtensions
    {
        public static string SaveImage(this IFormFile imageFile, IWebHostEnvironment env, string folder)
        {
            string path = Path.Combine(env.WebRootPath, folder);
            string fileName = Guid.NewGuid() + imageFile.FileName;
            string fullPath = Path.Combine(path, fileName);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                imageFile.CopyTo(stream);
            }
            return fileName;
        }
    }
}
