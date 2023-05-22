using CerealsApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CerealsApi.Db
{
    public class Repository<T> where T : Model
    {
        /// <summary>
        /// Contexte de base de données
        /// </summary>
        private DbContext ctx;

        /// <summary>
        /// DbSet pour ce repository. Le type utilisé doit être référencé dans le DbContext
        /// </summary>
        private DbSet<T> items;

        /// <summary>
        /// Contstructeur.
        /// </summary>
        /// <param name="context">Le contexte de base de données à utiliser</param>
        public Repository(DbContext context)
        {
            ctx = context;
            items = ctx.Set<T>();
        }

        /// <summary>
        /// Retourne tous les éléments de la table correspondant au Modèle utilisé
        /// </summary>
        /// <returns>Les éléments de la table sous forme de liste énumérable</returns>
        public IEnumerable<T> Get()
        {
            return items.ToList();
        }

        /// <summary>
        /// Retourne le 1er élément de la table correspondant à l'identifiant fourni
        /// </summary>
        /// <param name="id">L'identifiant de l'élément à rechercher</param>
        /// <returns>L'élément trouvé ou null si aucune correspondance</returns>
        public T? Get(int id)
        {
            return items.FirstOrDefault(item => item.Id == id);
        }

        /// <summary>
        /// Ajoute un élément à la table 
        /// </summary>
        /// <param name="value">L'élément à ajouter</param>
        /// <returns>True si l'ajout a réussi. False sinon.</returns>
        public bool Add(T value)
        {
            var result = items.Add(value);

            if(result != null)
            {
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Met à jour un élément existant.
        /// </summary>
        /// <param name="value">L'élément à mettre à jour.</param>
        /// <returns>True si la mise à jour a réussi. False sinon.</returns>
        public bool Update(T value)
        {
            if(Get(value.Id) is T item && item.UpdateFromModel(value))
            {
                ctx.SaveChanges();
                return true;        
            }
            return false;
        }

        /// <summary>
        /// Supprime un élément existant 
        /// </summary>
        /// <param name="id">l'identifiant de l'élément à supprimer</param>
        /// <returns>True si la suppression a réussi. False sinon.</returns>
        public bool Delete(int id)
        {
            if(Get(id) is T item)
            {
                ctx.Remove(item);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
