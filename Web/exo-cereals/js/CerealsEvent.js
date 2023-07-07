class CerealsEvent{
    static cerealsCollection; 
    static sortDirection = true;

    static columnSortEvent(e){

        let attributeName = e.target.dataset.name;
        let firstCollectionItem =  CerealsEvent.cerealsCollection.data[0];

        if(typeof(firstCollectionItem[attributeName]) != "string") {
            CerealsEvent.cerealsCollection.data.sort((x,y) => x[e.target.dataset.name] - y[e.target.dataset.name]);

            CerealsEvent.cerealsCollection.data.sort(function (x,y) { return x[attributeName] - y[attributeName] });
        }
        else{
            CerealsEvent.cerealsCollection.data.sort((x,y)=>x[attributeName].localeCompare(y[attributeName]));
        }
        if(CerealsEvent.sortDirection){
            CerealsEvent.cerealsCollection.data.reverse();
        }
        CerealsEvent.sortDirection=!CerealsEvent.sortDirection;
    }
}
export {CerealsEvent}