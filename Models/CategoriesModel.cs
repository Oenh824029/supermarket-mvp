using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoriesModel
    {
        [DisplayName("Categorie Id")]
        public int Id { get; set; }

        [DisplayName("Categorie Name")]
        [Required(ErrorMessage = "Name Categorie is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage = "Categorie name must be between 6 and 80 characters")]
        public string  Name { get; set; }

        [DisplayName("Categorie Description")]
        [Required(ErrorMessage = "Categorie Description is Required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Categorie description must be between and 250 characters")]
        public string Description { get; set; }
    }
}
