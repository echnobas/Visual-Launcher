using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using VSC_Launcher;

namespace VSCLauncher_GUI
{
    public partial class Visual_Launcher : Form
    {
        
        private CommonFileDialog ProjectSelectorDialog;
        private string ProjectName;
        private VSCProject.ProjectType ProjectMode;
        private string ProjectPath;

        public Visual_Launcher()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };
            InitializeComponent();
            this.Text = "Visual Project Manager";
            ModeBox.Text = "NodeJS";
            ProjectSelectorDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                EnsurePathExists = true
            };
            ProjectTextBox.SelectionAlignment = HorizontalAlignment.Center;
            ProjectTextBox.Click += (object sender, EventArgs e) =>
            {
                ProjectTextBox.Clear();
            };
            this.ActiveControl = CurrentFolder;
        }

        private void ProjectBtn_Click(object sender, EventArgs e)
        {
            CommonFileDialogResult Result = ProjectSelectorDialog.ShowDialog();
            if(Result == CommonFileDialogResult.Ok)
            {
                this.ProjectPath = ProjectSelectorDialog.FileName;
                CurrentFolder.Visible = true;
                CurrentFolder.Text = ProjectSelectorDialog.FileName;
            }
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            switch (ModeBox.Text)
            {
                case "NodeJS":
                    this.ProjectMode = VSCProject.ProjectType.Node;
                    break;
                case "Python":
                    this.ProjectMode = VSCProject.ProjectType.Python;
                    break;
                case "C++":
                    this.ProjectMode = VSCProject.ProjectType.CPP;
                    break;
                case "C#":
                    this.ProjectMode = VSCProject.ProjectType.CSharp;
                    break;
            }
            /*
            * NodeJS
            * C#
            * C++
            * Python
            */
            new VSCProject(ProjectMode, ProjectPath, ProjectTextBox.Text);
        }
    }
}
