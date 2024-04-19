using System.IO;
class FileIO
{
    string folderPath = "C:\Users\ASUS ZENBOOK\Desktop\Intern\Day8-9\Netstarter\Basics\FileFolderHandling";
    public void CreateFile()
    {
          
          string fileName = "student.txt";
          string filePath = Path.Combine(folderPath, fileName);
          file.WriteAllText(filePath, "this is first line");
    }
    public void CreateFileWithInFolder()
    {
        string newFolderName  = "Student";
        string newFolderPath = Path.Combine(FolderPath, newFolderName);
        Directory.CreateDirectory(newFolderPath);
        string fileName = "student1.txt";
        string filePath = Path.Combine(newFolderName, fileName);
        File.WriteAllText(filePath, "this is first line"); 
    }
}