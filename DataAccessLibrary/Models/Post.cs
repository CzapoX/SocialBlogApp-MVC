﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLibrary.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }

        [Required]
        [MaxLength(16)]
        public string Title { get; set; }

        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public BlogAppUser Author { get; set; }
    }
}
