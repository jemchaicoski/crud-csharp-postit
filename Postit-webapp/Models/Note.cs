using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Postit_webapp.Models
{
    [Table("Note")]
    public class Note
    {
        [Column("Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Column("Name")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Column("Description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Column("CreationDate")]
        [Display(Name = "CreationDate")]
        public DateTime CreationDate { get; set; }
        [Column("IsFinished")]
        [Display(Name = "IsFinished")]
        public bool IsFinished { get; set; }
        [Column("IsFavorite")]
        [Display(Name = "IsFavorite")]
        public bool IsFavorite{ get; set; }
    }
}
