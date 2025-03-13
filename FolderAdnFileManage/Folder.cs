namespace FolderAdnFileManage
{
    /// <summary>
    /// composite which can has folders or files
    /// </summary>
    public class Folder : IFileSystemItem
    {
        private string _name;
        private List<IFileSystemItem> _items = new List<IFileSystemItem>();
        public Folder(string name)
        {
            _name = name;
        }


        public void Add(IFileSystemItem item)
        {
            _items.Add(item);   
        }
        public void Display(string indent = "")
        {
            Console.WriteLine(indent + "+ " + _name);
            foreach (var item in _items)
            {
                item.Display(indent + "  ");
            }
        }

    }


}
