
using FolderAdnFileManage;
using File = FolderAdnFileManage.File;

IFileSystemItem file1 = new File("File1.txt");
IFileSystemItem file2 = new File("File2.txt");


Folder root = new Folder("Root");
Folder subFolder = new Folder("SubFolder");
Folder subSubFolder = new Folder("subSubfolder");


root.Add(file1);
root.Add(subFolder);
subFolder.Add(subSubFolder); 
subFolder.Add(file2);


root.Display();
