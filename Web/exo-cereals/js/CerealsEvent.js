class CerealsEvent{
    static cerealsCollection; 
    static sortDirection = true;

    static columnSortEvent(e){
        if(typeof(CerealsEvent.cerealsCollection.data[0][e.target.dataset.name])!="string"){
            CerealsEvent.cerealsCollection.data.sort((x,y)=>x[e.target.dataset.name]-y[e.target.dataset.name]);
        }
        else{
            CerealsEvent.cerealsCollection.data.sort((x,y)=>x[e.target.dataset.name].localeCompare(y[e.target.dataset.name]));
        }
        if(CerealsEvent.sortDirection){
            CerealsEvent.cerealsCollection.data.reverse();
        }
        CerealsEvent.sortDirection=!CerealsEvent.sortDirection;
    }
    static searchCereal(value){
        CerealsEvent.cerealsCollection.searchCereal(value);
    }
    static sortCategory(value){
        CerealsEvent.cerealsCollection.sortCategory(value);
    }
    static sortNutriscore(letters){
        CerealsEvent.cerealsCollection.sortNutriscore(letters);
    }
}
export {CerealsEvent}