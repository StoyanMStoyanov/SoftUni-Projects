using System.IO;
using BookStore.Interfaces;

namespace BookStore.UI
{
    class FileRenderer:IRenderer
    {
        public string FilePath { get; set; }

        public FileRenderer(string filePath)
        {
            this.FilePath = filePath;
        }

        public void WriteLine(string message, params string[] parameters)
        {
            StreamWriter writer = new StreamWriter(this.FilePath);
            using (writer)
            {
                writer.WriteLine(message, parameters);
            }
        }
    }
}
