using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace EStudy.Domain.Models
{
    public class File
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        [Required, MinLength(10), MaxLength(500)]
        public string Path { get; set; }
        [Required, MinLength(20), MaxLength(40)]
        public string UniqueId { get; set; } = Guid.NewGuid().ToString("N");
        [Required]
        public int Size { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string OriginalName { get; set; }
        [Required, MaxLength(25)]
        public string Extension { get; set; }
        public TypeFile Type { get; set; }
        [Required, MinLength(25), MaxLength(40)]
        public string MD5CheckSum { get; set; }


        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [Required, MinLength(3), MaxLength(30)]
        public string CreatedFromIPAddress { get; set; }
        [Required]
        public int CreatedByUserId { get; set; }
        [Required]
        public bool IsDeleted { get; set; } = false;
        public DateTime? DateDeleted { get; set; }
        public DateTime? MaxDateUpToRecovery { get; set; }
    }


    public enum TypeFile
    {
        Image,
        Document,
        Video,
        File,
        Archive
    }
}