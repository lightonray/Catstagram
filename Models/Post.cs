using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Catstagram.Models
{
    public class Post 
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "ImageURL")]
        [Required(ErrorMessage = "ImageURL is required for a new post")]
        public string Image { get; set; }

        [Display(Name = "Added by:")]
        [Required(ErrorMessage = "Author name is required for a new post")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string AuthorName { get; set; }

        [EmailAddress]
        public string AuthorEmail { get; set; }

        public string Comments { get; set; }    

        public DateTime DateAdded { get; set; }

        [NotMapped]
        public List<string> Hashtags { get; set; }


        public void ExtractHashtags()
        {
            var regex = new Regex(@"(?<=#)\w+");
            var matches = regex.Matches(Comments);
            Hashtags = matches.Select(match => match.Value).ToList();
        }
    }
}
