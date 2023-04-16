// File
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

string path = @"X:\RPO\maxim efimov";
string fileName = "file01.dat";

//File.Create(path + @"\" + fileName);
//File.Move(path + @"\" + fileName, @"X:\" + fileName);
//if(File.Exists(path))
//    File.Delete(path + @"\" + fileName);

//File.Copy(path + @"\" + fileName, @"X:\" + fileName, true);

//string text = "A FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.";

//var fileStream = File.Open(path + "\\" + fileName, FileMode.OpenOrCreate);
//File.WriteAllText(path + "\\" + fileName, text);
//Console.WriteLine(File.ReadAllText(path + "\\" + fileName));


//var lines = File.ReadLines(path + "\\" + fileName);
//foreach (string line in lines)
//    Console.WriteLine(line);

//User user = new User() { Name = "Bob", Age = 34, Phone = "+7 (910) 123-45-67" };
//File.WriteAllBytes(path + "\\" + fileName, ObjectToByteArray(user));

//byte[] buffer = File.ReadAllBytes(path + "\\" + fileName);
//var userRead = (User)ByteArrayToObject(buffer);

//Console.WriteLine($"{userRead.Name} {userRead.Age} {userRead.Phone}");


FileInfo fileInfo = new FileInfo(path + "\\" + fileName);
fileInfo.Create();

var fileStream = fileInfo.Open(FileMode.Open);




byte[] ObjectToByteArray(object obj)
{
    BinaryFormatter bf = new BinaryFormatter();
    using(var ms = new MemoryStream())
    {
        bf.Serialize(ms, obj);
        return ms.ToArray();
    }
}

object ByteArrayToObject(byte[] bytes)
{
    using(var ms = new MemoryStream())
    {
        var bf = new BinaryFormatter();
        ms.Write(bytes, 0, bytes.Length);
        ms.Seek(0, SeekOrigin.Begin);
        var obj = bf.Deserialize(ms);
        return obj;
    }
}


void DriversExample()
{
    var drivers = DriveInfo.GetDrives();

    /*
    foreach (var driver in drivers)
    {
        Console.WriteLine($"Name: {driver.Name}");
        Console.WriteLine($"Type: {driver.DriveType}");
        if(driver.IsReady)
        {
            Console.WriteLine($"Total volume: {driver.TotalSize}");
            Console.WriteLine($"Free volume: {driver.TotalFreeSpace}");
            Console.WriteLine($"Label: {driver.VolumeLabel}");
        }
        Console.WriteLine();
    }
    */

}

void DirectoriesExample()
{

    // Directory;
    // DirectoryInfo;

    //string path = @"X:\RPO\maxim efimov";

    //Directory.CreateDirectory(path + "Work Folder");
    //Directory.Delete(path, true);

    //if (Directory.Exists(path))
    //    Console.WriteLine("Exists");
    //else
    //    Console.WriteLine("Not Exists");

    //string currentPath = Directory.GetCurrentDirectory();
    //Console.WriteLine(currentPath);
    //Console.WriteLine();

    //var dirs = Directory.GetDirectories(path);
    //foreach (var dir in dirs)
    //{
    //    Console.WriteLine($"{dir}");
    //    Console.WriteLine($"\tCreation Time: {Directory.GetCreationTime(dir)}");
    //    Console.WriteLine($"\tLast Write Time: {Directory.GetLastWriteTime(dir)}");
    //    Console.WriteLine($"\tLast Access Time: {Directory.GetLastAccessTime(dir)}");
    //}

    //Console.WriteLine();

    /*
    var files = Directory.GetFiles(path);
    foreach(var file in files)
        Console.WriteLine($"{file}");
    Console.WriteLine();

    var dfs = Directory.GetFileSystemEntries(path);
    foreach (var df in dfs)
        Console.WriteLine($"{df}");
    Console.WriteLine();
    */
    //Directory.Move(path + "Work Folder", path + "Job Folder");

    //Console.WriteLine(Directory.GetParent(path));




    // DirectoryInfo
    string path = @"X:\RPO\maxim efimov";

    DirectoryInfo directory = new DirectoryInfo(path);
    //if(!directory.Exists)
    //    directory.Create();


    Console.WriteLine($"Parent dir: {directory.Parent}");
    Console.WriteLine($"Name: {directory.Name}");
    Console.WriteLine($"Full Name: {directory.FullName}");
    Console.WriteLine($"Creation Time: {directory.CreationTime}");
    Console.WriteLine($"Last Access Time: {directory.LastAccessTime}");
    Console.WriteLine($"Last Write Time: {directory.LastWriteTime}");
    Console.WriteLine();

    var dirs = directory.GetDirectories("*a*");
    foreach (DirectoryInfo dir in dirs)
    {
        Console.WriteLine($"\tName: {dir.Name}");
        Console.WriteLine($"\tFull Name: {dir.FullName}");
        Console.WriteLine($"\tCreation Time: {dir.CreationTime}");
        Console.WriteLine($"\tLast Access Time: {dir.LastAccessTime}");
        Console.WriteLine($"\tLast Write Time: {dir.LastWriteTime}");
        Console.WriteLine();

    }
}

[Serializable]
class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Phone { get; set; }
}