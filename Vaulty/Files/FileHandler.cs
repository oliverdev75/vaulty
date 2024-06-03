using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaulty.Database.Models;

namespace Vaulty.Files
{
    internal class FileHandler
    {/*
        internal static List<Object> GetImportedData(string imported)
        {
            List<Object> importedData = null;
            string[] data;
            List<string> groupProps = new List<string>();
            StreamReader importedFile = new StreamReader(imported);

            string lineData = importedFile.ReadLine();

            while (lineData != null)
            {
                importedData[importedData.Count()] = new Identity();
                if (lineData != "\n")
                {
                    data = lineData.Split(':');
                    switch (data[0])
                    {
                        case "title":
                            importedData[importedData.Count()].Title = data[1];
                            break;
                        case "username":
                            importedData[importedData.Count()].Username = data[1];
                            break;
                        case "password":
                            importedData[importedData.Count()].Password = data[1];
                            break;
                        case "website":
                            importedData[importedData.Count()].Website = data[1];
                            break;
                        case "note":
                            importedData[importedData.Count()].Note = data[1];
                            break;
                        case "group":
                            groupProps[0] = data[1];
                            break;
                        case "group_icon":
                            groupProps[1] = data[1];
                            importedData[importedData.Count()] = new Group(groupProps[0], int.Parse(groupProps[1]));
                            break;
                    }
                }
                lineData = importedFile.ReadLine();
            }

            importedFile.Close();

            return importedData;
        }

        internal static void ExportData(List<Object> data)
        {
            List<Object> exportedData = null;
            string[] defData;
            List<string> groupProps = new List<string>();
            StreamReader exportedFile = new StreamReader(data);

            string lineData = exportedFile.ReadLine();

            while (lineData != null)
            {
                exportedData[exportedData.Count()] = new Identity();
                if (lineData != "\n")
                {
                    data[0].
                    data = lineData.Split(':');
                    switch (data[0])
                    {
                        case "title":
                            importedData[importedData.Count()].Title = data[1];
                            break;
                        case "username":
                            importedData[importedData.Count()].Username = data[1];
                            break;
                        case "password":
                            importedData[importedData.Count()].Password = data[1];
                            break;
                        case "website":
                            importedData[importedData.Count()].Website = data[1];
                            break;
                        case "note":
                            importedData[importedData.Count()].Note = data[1];
                            break;
                        case "group":
                            groupProps[0] = data[1];
                            break;
                        case "group_icon":
                            groupProps[1] = data[1];
                            importedData[importedData.Count()] = new Group(groupProps[0], int.Parse(groupProps[1]));
                            break;
                    }
                }
                lineData = importedFile.ReadLine();
            }

            importedFile.Close();

            return importedData;
        }
        */
    }
}
