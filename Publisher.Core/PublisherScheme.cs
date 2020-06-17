using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publisher.Core
{
    public class PublisherScheme : IValidable
    {
        public string Name { get; set; }
        //public DateTime CreationDate { get; set; } = DateTime.Now;
        //public DateTime? ModificationDate { get; set; }
        public string OutputFolder { get; set; }

        public List<Project> Projects { get; set; } = new List<Project>();

        public void Validate()
        {

        }

        public void Save(string filePath)
        {
            var dirPath = System.IO.Path.GetDirectoryName(filePath);
            if (!System.IO.Directory.Exists(dirPath))
            {
                System.IO.Directory.CreateDirectory(dirPath);
            }
            var fileContent = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(filePath, fileContent);
        }

        public void Run()
        {
            foreach (var project in Projects)
            {
                project.Run(this);
            }
        }

        public static PublisherScheme Open(string filePath)
        {
            var fileContent = System.IO.File.ReadAllText(filePath);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<PublisherScheme>(fileContent);
        }
    }
}
