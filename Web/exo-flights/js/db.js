/**
 * Gère l'appel à une API distante 
 */
class Db 
{
    /**
     * Charge les données JSON à partir d'un URL
     * @param {String} _url l'url à appeler avec fetch 
     * @returns {Array} La collection de données brute
     */
    static async getData(_url)
    {
        let res = await fetch(_url);
        let json = await res.json();
        return json;        
    }
}

export {Db}