class FileIO
{
    public void CreateFile()
    {
          string FolderPath = "C:\Users\ASUS ZENBOOK\Desktop\Intern\Day8-9\Netstarter\Basics\FileFolderHandling";
          string fileName = "student.txt";
          string filePath = Path.Combine(FolderPath, fileName);
          file.WriteAllText(filePath, "this is first line");
    }
    public void CreateFileWithInFolder()
    {
        string newFolderName  = "Student";
        string newFolderPath = newFolderPath.Combine(newFolderPath, newFolderName);
        Directory.CreateDirectory(newFolderPath);
         string fileName = "student1.txt";
         string filePath = filePath.Combine(newFolderName, fileName);
         FileIO.WriteAllText(filePath, "this is first line"); 
    }
}