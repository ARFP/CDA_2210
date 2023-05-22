using System.ComponentModel.DataAnnotations;

namespace CerealsApi.Models
{
    abstract public class Model
    {
        /// <summary>
        /// L'identifiant des entités.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Met à jour l'objet actuel à partir d'un autre objet du même type.
        /// </summary>
        /// <param name="toUpdate">L'objet contenant les données mises à jour</param>
        /// <returns>True si la mise à jour a réussi. False sinon.</returns>
        abstract public bool UpdateFromModel(Model toUpdate);
    }
}
