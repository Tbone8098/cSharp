

function findObject(items, criteria){
    let result = []
    let keys = Object.keys(criteria)
    let vals = Object.values(criteria)

    for (i=0; i<items.length; i++){
       let found = false;
       for (j=0; j<keys.length; j++){
           if (items[i][keys[j]] === vals[j]){
              found = true;
            }
           else {
              found = false;
              break;
           }
        }
        // satisfied all criteria
        if (found) {
            result.push(items[i]);
        }
    }
    return result;
}


// uses dictionary

function findObject2(items, criteria){

}

var items = [
    { id:1, firstName: "Bob", lastName: "Bobbert", age: 31},
    { id:2, firstName: "John", lastName: "Smith", age: 25},
    { id:3, firstName: "Bob", lastName: "smith", age: 27},
    { id:4, firstName: "Bob", lastName: "White", age: 31},
]

const searchCriteria = {
    id: 3
}
// console.log("******************************");
// console.log(findObject2(items, searchCriteria));

const updateItems = {
    lastName: "Smith",
    age: 40
}

function findAndUpdate(items, searchCriteria, updateItems){
    let obj = findObject(items, searchCriteria)
    let keys = Object.keys(updateItems)
    let vals = Object.values(updateItems)
    for (i=0; i<keys.length; i++){
        obj[0][keys[i]] = vals[i]
    }
    return obj[0];
}

//
// console.log("************* output ***************");
// console.log(findAndUpdate(items, searchCriteria, updateItems));



const d = new Date
console.log(d);