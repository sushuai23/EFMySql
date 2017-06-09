using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Dao;

namespace WebUI.Areas.Manage.Controllers
{
    public class TestController : Controller
    {
        // GET: Manage/Test
        public ActionResult Index()
        {
            #region foreach file

            string fileDirectory = ConfigurationManager.AppSettings["FileDirectory"];
            fileList=new List<FileFramework>();

            DirectoryFile(new DirectoryInfo(fileDirectory));
            var count = fileList.Count();
            #endregion

            return View(fileList);
        }

        public List<FileFramework> fileList { get; set; }

        public void DirectoryFile(DirectoryInfo fileDirectory)
        {
            foreach (FileSystemInfo next in fileDirectory.GetFileSystemInfos())
            {
                if(next.Attributes== FileAttributes.Directory)
                {
                    string newFileDirectory = fileDirectory.FullName + "/" + next.Name;
                    DirectoryFile(new DirectoryInfo(newFileDirectory));
                }
                else
                {
                    fileList.Add(new FileFramework
                    {
                        FileName = next.Name,
                        FileType = next.Extension.Replace(".",""),
                        FilePath = next.FullName
                    });
                }
            }
        }

    }

    

    public class FileFramework
    {
        public string FileId { get; set; }

        public string FileType { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public int FileParentId { get; set; }
        
    }
}