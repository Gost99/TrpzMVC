using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TrpzMvc.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        [ForeignKey("BackgroundImageId")]
        public Image BackgroundImage { get; set; }
        public int? BackgroundImageId { get; set; }

    }

    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
    }

    public class PageContext : DbContext
    {
        public PageContext() : base("DefaultConnection") {  }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}