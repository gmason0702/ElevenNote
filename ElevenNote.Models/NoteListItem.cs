using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ElevenNote.Models
{
    public class NoteListItem
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }
        public int? CategoryId { get; set; }
    }
}
