using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace VSC_Launcher
{
    class VSCProject
    {
        string CodeBATLocation;
        string FilePath;
        string ProjectName;
        public enum ProjectType
        {
            Python,
            CSharp,
            CPP,
            Node
        }

        public VSCProject(ProjectType ProjectEnum, string FP, string Proj)
        {
            CodeBATLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Programs\Microsoft VS Code\bin\code.cmd";
            FilePath = FP;
            ProjectName = Proj;
            switch (ProjectEnum)
            {
                case ProjectType.Python:
                    CreatePython();
                    break;
                case ProjectType.CSharp:
                    CreateCSharp();
                    break;
                case ProjectType.CPP:
                    CreateCPP();
                    break;
                case ProjectType.Node:
                    CreateNodeJS();
                    break;
            }
        }

        public void CreateNodeJS()
        {
            string BoilerPlate = $@"// {ProjectName}
const http = require('http');
const port = 3000;

const requestHandler = (request, response) => {{
    response.end('Hello World');
}};

const server = http.createServer(requestHandler);

server.listen(port, (err) => {{
    if (err) 
    {{
        return console.log('An Exception occurred: ', err);
    }};

  console.log(`Listening on ${{port}}`);
}});";
            VSCCreateFile(BoilerPlate, "index.js");
        }

        public void CreatePython()
        {
            string BoilerPlate = $@"# {ProjectName}
print(""Hello World!"")";
            VSCCreateFile(BoilerPlate, "main.py");
        }

        public void CreateCSharp()
        {
            Console.WriteLine($@"/c cd ""{FilePath}"" && dotnet new console -n ""{ProjectName}"" && cd {ProjectName} && dotnet new sln -n ""{ProjectName}"" && dotnet sln add {ProjectName}.csproj");
            System.Diagnostics.Process.Start("cmd.exe", $@"/c cd ""{FilePath}"" && dotnet new console -n ""{ProjectName}"" && cd {ProjectName} && dotnet new sln -n ""{ProjectName}"" && dotnet sln add {ProjectName}.csproj").WaitForExit();
            Console.WriteLine($"{FilePath}\\{ProjectName}");
            OpenVSCode($"{FilePath}\\{ProjectName}");    
        }

        public void CreateCPP()
        {
            string BoilerPlate = $@"// {ProjectName}
#include <iostream>
#include <string>
#include <array>
#include <vector>
using namespace std;

int main()
{{
    cout << ""Hello World"" << endl;
}}";
            VSCCreateFile(BoilerPlate, "main.cpp");
        }

        public void VSCCreateFile(string BoilerPlate, string FileName)
        {

            string DirectoryPath = $"{FilePath}\\{ProjectName}";
            string MainFilePath = FilePath + $"\\{ProjectName}\\{FileName}";

            if (!Directory.Exists(DirectoryPath)) Directory.CreateDirectory(DirectoryPath);
            Thread.Sleep(1000);
            if (!File.Exists(MainFilePath))
            {
                File.WriteAllText(MainFilePath, BoilerPlate);
            }
            if (Directory.Exists(DirectoryPath))
            {
                OpenVSCode($"{FilePath}\\{ProjectName}");
            }
            else Console.WriteLine("Error");
        }
        public void OpenVSCode(string DirectoryPath)
        {
            var CMDProcessStartInfo = new ProcessStartInfo();
            CMDProcessStartInfo.FileName = CodeBATLocation;
            CMDProcessStartInfo.Arguments = $"\"{DirectoryPath}\"";
            CMDProcessStartInfo.RedirectStandardOutput = true;
            CMDProcessStartInfo.RedirectStandardError = true;
            CMDProcessStartInfo.UseShellExecute = false;
            CMDProcessStartInfo.CreateNoWindow = true;

            Process CMDProcess = new Process();
            CMDProcess.StartInfo = CMDProcessStartInfo;
            CMDProcess.EnableRaisingEvents = true;
            CMDProcess.Start();
        }
    }
}
