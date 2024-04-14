using System.IO;

class FileIO
{
    string folderPath = @"C:\Users\ASUS ZENBOOK\Desktop\Intern\Day8-9\Netstarter\Basics\FileFolderHandling";
    
    //Create a text file
    public void CreateFile()
    {        
        string fileName = "student.txt";
        string filePath = Path.Combine(folderPath, fileName);
        
        File.WriteAllText(filePath, "this is first line");
    }

    public void CreateFileWithInFolder()
    {
        string newFolderName = "Student";
        string newFolderPath = folderPath.Combine(FolderPath, newFolderName);
        Directory.CreateDirectory(newFolderPath);

        string fileName = "Student1.txt";
        string filePath = Path.Combine(newFolderName, fileName);
        FileIO.WriteAllText(filePath, "this is first line");
    }
}
