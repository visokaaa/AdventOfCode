namespace Day7.Models;

internal class File
{
    public string Name { get; set; }
    public bool IsDirectory { get; set; }
    public File ParentDirectory { get; set; }
    public List<File> Children { get; set; } = new List<File>();
    private long size = 0;
    public long Size
    {
        get { return IsDirectory ? Children.Sum(_ => _.Size) : size; }
        set { size = value; }
    }

    public void AddFile(File file)
    {
        if (!Children.Contains(file))
        {
            Children.Add(file);
        }
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        var file = obj as File;

        return Name.Equals(file.Name);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }
}
