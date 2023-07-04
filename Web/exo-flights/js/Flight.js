/**
 * Représente un vol
 */
class Flight 
{
    /**
     * Constructeur
     * @param {Object|Flight} _flight le vol courant
     */
    constructor(_flight)
    {
        // clonage de l'objet reçu en paramètre dans l'objet courant
        // tous les attributs et leurs valeurs seront copiés !
        Object.assign(this, _flight);
    }

    /**
     * Retourne les valeurs de l'objet courant dans un tableau indexé
     * @returns {Array} Les valeurs de l'objet dans un tableau indexé
     */
    getValues()
    {
        // crée un tableau indexé contenant les valeurs de l'objet fourni en paramètre
        return Object.values(this); 
    }
}

export { Flight }