using System.Reflection;
using File = Day7.Models.File;

var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Input.txt");
var lines = System.IO.File.ReadAllLines(path);

var move = "$ cd";
var moveBack = move + " ..";
var dir = "dir";
var ls = "$ ls";

var root = new File
{
    Name = "root",
    IsDirectory = true,
    ParentDirectory = null
};

var currentDirectory = root;

for (int i = 1; i < lines.Length; i++)
{
    var line = lines[i];
    if(line.Equals(ls))
    {
        continue;
    }

    if(line.StartsWith(dir))
    {
        var name = line.Substring(line.IndexOf(" ") + 1);
        currentDirectory.AddFile(new File { Name = name, IsDirectory = true, ParentDirectory = currentDirectory });
    } 
    else if(line.Equals(moveBack))
    {
        currentDirectory = currentDirectory.ParentDirectory;
    }
    else if(line.StartsWith(move))
    {
        var name = line.Substring(line.LastIndexOf(" ") + 1);
        currentDirectory = currentDirectory.Children.First(x => x.Name == name);
    } 
    else
    {
        var sizeAndName = line.Split(" ");
        var size = int.Parse(sizeAndName[0]);
        var name = sizeAndName[1];
        currentDirectory.AddFile(new File { Name = name, IsDirectory = false, ParentDirectory = currentDirectory, Size = size });
    }
}

var filteredDirectories = new List<File>();
var totalDiskSize = 70000000l;
var sizeToRemove = 30000000 - (totalDiskSize - root.Size);
var directorySizeToDelete = 30000000l;

FilterDirectories(root);

void FilterDirectories(File file)
{
    if(file.IsDirectory)
    {
        if(file.Size <= 100000)
        {
            filteredDirectories.Add(file);
        }
        else if(file.Size >= sizeToRemove && file.Size < directorySizeToDelete) {
            directorySizeToDelete = file.Size;
        }
        file.Children.ForEach(child => FilterDirectories(child));
    }
}

//Part one
Console.WriteLine(filteredDirectories.Sum(_ => _.Size));

//Part two
Console.WriteLine(directorySizeToDelete);



