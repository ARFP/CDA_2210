using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CerealsApi.Models
{
    [Table("tbl_cereals")]
    public class Cereal : Model
    {
        public int CerealId { get => base.Id; }

        [Required]
        // [Column("nom_de_la_colonne_en_base_de_donnees")]
        public string Name { get; set; }

        [Required]
        public int Calories { get; set; }

        [Required]
        public int Protein { get; set; }

        /// <summary>
        /// Met à jour l'objet actuel à partir d'un autre objet du même type.
        /// </summary>
        /// <param name="toUpdate">L'objet contenant les données mises à jour</param>
        /// <returns>True si la mise à jour a réussi. False sinon.</returns>
        public override bool UpdateFromModel(Model toUpdate)
        {
            Cereal cereal = (Cereal)toUpdate;
            this.Name = cereal.Name;
            this.Calories = cereal.Calories;
            this.Protein = cereal.Protein;
            return true;
        }

    }
}
