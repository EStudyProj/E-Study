using EStudy.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace EStudy.Application.ViewModels.File
{
    public class FileViewModel
    {
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Path { get; set; }
        public string UniqueId { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public string OriginalName { get; set; }
        public string Extension { get; set; }
        public string Type { get; set; }
        public string MD5CheckSum { get; set; }
    }
}