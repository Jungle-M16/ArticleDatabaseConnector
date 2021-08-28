using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleDatabaseConnector.Models
{
    public class Article
    {
        public Guid Id { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
        public int Popularity { get; set; }
        public string Category { get; set; }
    }
}
