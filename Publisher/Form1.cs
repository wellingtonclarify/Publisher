using Publisher.Components;
using Publisher.Core;
using Publisher.Core.Helpers;
using Publisher.Core.Extensions;
using System;
using System.Linq;

namespace Publisher
{
    public partial class Form1 : XForm
    {
        private PublisherScheme _currentScheme = null;
        private string _currentFolder = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            New();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New();
        }

        private void New()
        {
            _currentScheme = new PublisherScheme() { Name = "New Project" };
            /*_currentScheme = new PublisherScheme()
            {
                Name = "PRD",
                OutputFolder = @"C:\Users\elton\Desktop\publish",
                Projects = new[]
                {
                    new Project()
                    {
                        Name = "SGO",
                        RootFolder = @"C:\IIS_Publish\LOGA\HMLG\JAGSRVAPI174\webapps\sgo",
                        OutputFolderName = @"app",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"bin\App.dll" },
                            new ProjectFile() { FilePath = @"bin\App.pdb" },
                            new ProjectFile() { FilePath = @"bin\Models.dll" },
                            new ProjectFile() { FilePath = @"bin\Models.pdb" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.dll" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.pdb" },
                        }.ToList(),
                        Folders = new[]
                        {
                            new ProjectFolder() { FolderPath = @"Scripts\app" },
                            new ProjectFolder() { FolderPath = @"Content\RSSSolColModelo1" },
                            new ProjectFolder() { FolderPath = @"Content\RSSSolColModelo2" },
                            new ProjectFolder() { FolderPath = @"Views" },
                        }.ToList()
                    },
                    new Project()
                    {
                        Name = "RSSAUDE",
                        RootFolder = @"C:\IIS_Publish\LOGA\HMLG\JAGSRVAPI174\webapps\rssaude",
                        OutputFolderName = @"RSSAUDE",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"bin\AppAcessoExterno.dll" },
                            new ProjectFile() { FilePath = @"bin\AppAcessoExterno.pdb" },
                            new ProjectFile() { FilePath = @"bin\Models.dll" },
                            new ProjectFile() { FilePath = @"bin\Models.pdb" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.dll" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.pdb" },
                        }.ToList(),
                        Folders = new[]
                        {
                            new ProjectFolder() { FolderPath = @"Scripts\app" },
                            new ProjectFolder() { FolderPath = @"Content\RSSSolColModelo1" },
                            new ProjectFolder() { FolderPath = @"Content\RSSSolColModelo2" },
                            new ProjectFolder() { FolderPath = @"Views" },
                        }.ToList()
                    },
                    new Project()
                    {
                        Name = "API SGO",
                        RootFolder = @"C:\IIS_Publish\LOGA\HMLG\JAGSRVAPI174\webservices\api-sgo",
                        OutputFolderName = @"API-RSS",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"bin\APIsSGO.dll" },
                            new ProjectFile() { FilePath = @"bin\APIsSGO.pdb" },
                            new ProjectFile() { FilePath = @"bin\Models.dll" },
                            new ProjectFile() { FilePath = @"bin\Models.pdb" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.dll" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.pdb" },
                        }.ToList(),
                    },
                    new Project()
                    {
                        Name = "API Interno",
                        RootFolder = @"C:\IIS_Publish\LOGA\HMLG\JAGSRVAPI174\webservices\api-usointerno",
                        OutputFolderName = @"API-UsoInterno",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"bin\API-UsoInterno.dll" },
                            new ProjectFile() { FilePath = @"bin\API-UsoInterno.pdb" },
                            new ProjectFile() { FilePath = @"bin\Models.dll" },
                            new ProjectFile() { FilePath = @"bin\Models.pdb" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.dll" },
                            new ProjectFile() { FilePath = @"bin\MVCBase.pdb" },
                        }.ToList(),
                    },
                    new Project()
                    {
                        Name = "Telemetria",
                        RootFolder = @"C:\Users\elton\source\repos\sgo_v3\D - CONSTRUCAO\SOURCE\Telemetria\TelemetriaMongoDBService\bin\Release",
                        OutputFolderName = @"Telemetria\LOGA",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"TelemetriaMongoDBService.exe" },
                            new ProjectFile() { FilePath = @"TelemetriaMongoDBService.pdb" },
                        }.ToList(),
                    },
                    new Project()
                    {
                        Name = "ScheduledJobs",
                        RootFolder = @"C:\Users\elton\source\repos\sgo_v3\D - CONSTRUCAO\SOURCE\SGOv3\SGOSchedulerJobs\bin\Release",
                        OutputFolderName = @"SGOSchedulerJobs",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"SGOSchedulerJobs.exe" },
                            new ProjectFile() { FilePath = @"SGOSchedulerJobs.pdb" },
                            new ProjectFile() { FilePath = @"Models.dll" },
                            new ProjectFile() { FilePath = @"Models.pdb" },
                            new ProjectFile() { FilePath = @"MVCBase.dll" },
                            new ProjectFile() { FilePath = @"MVCBase.pdb" },
                        }.ToList(),
                    },
                    new Project()
                    {
                        Name = "ServidorRelatorios",
                        RootFolder = @"C:\Users\elton\source\repos\sgo_v3\D - CONSTRUCAO\SOURCE\SGOv3\ServidorRelatorios\bin\Release",
                        OutputFolderName = @"SERV_RELATORIOS",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"ServidorRelatorios.exe" },
                            new ProjectFile() { FilePath = @"ServidorRelatorios.pdb" },
                            new ProjectFile() { FilePath = @"Models.dll" },
                            new ProjectFile() { FilePath = @"Models.pdb" },
                            new ProjectFile() { FilePath = @"MVCBase.dll" },
                            new ProjectFile() { FilePath = @"MVCBase.pdb" },
                        }.ToList(),
                    },
                    new Project()
                    {
                        Name = "ConsultaV2",
                        RootFolder = @"C:\Users\elton\source\repos\sgo_v3\D - CONSTRUCAO\SOURCE\ConsultaColetaV2",
                        OutputFolderName = @"consultaV2",
                        Files = new[]
                        {
                            new ProjectFile() { FilePath = @"index.html" },
                            new ProjectFile() { FilePath = @"assets\js\index.js" },
                        }.ToList(),
                    },
                }.ToList()
            };
            */
            _currentFolder = null;
            RefreshFields();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    _currentFolder = openFileDialog1.FileName;
                    _currentScheme = PublisherScheme.Open(openFileDialog1.FileName);
                    RefreshFields();
                }
                catch (Exception ex)
                {
                    MessageHelper.Error(ex.Message);
                }
            }
        }

        private void RefreshFields()
        {
            this.Text = _currentScheme.Name;
            vfName.FieldContent = _currentScheme.Name;
            vfOutputFolder.FieldContent = _currentScheme.OutputFolder;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshModel();
            try
            {
                _currentScheme.Validate();
            }
            catch (Exception ex)
            {
                MessageHelper.Error(ex.Message);
                return;
            }

            if (_currentFolder != null || saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    var filePath = _currentFolder ?? saveFileDialog1.FileName;
                    _currentScheme.Save(filePath);
                    _currentFolder = filePath;
                    RefreshFields();
                }
                catch (Exception ex)
                {
                    MessageHelper.Error(ex.Message);
                }
            }
        }

        private void RefreshModel()
        {
            _currentScheme.Name = vfName.FieldContent;
            _currentScheme.OutputFolder = vfOutputFolder.FieldContent;
        }

        private void btnSelectOutputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                vfOutputFolder.FieldContent = folderBrowserDialog1.SelectedPath;
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshModel();
            try
            {
                _currentScheme.Validate();
                _currentScheme.Run();
                MessageHelper.Info("Operação realizada com sucesso");
            }
            catch (Exception ex)
            {
                MessageHelper.Error(ex.Message);
                return;
            }
        }
    }
}
