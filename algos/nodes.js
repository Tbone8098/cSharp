// Class for the node of our singly linked list
class SLNode {
    constructor(value) {
        this.value = value;
        this.next = null;
    }
}
// How do we actually create a new node?
// let mynode = new SLNode(10);
// console.log(mynode)

// Class for a singly linked list
class SLList {
    constructor() {
        // The only attribute we actually need is the head of the list
        this.head = null;
    }

    // This method should return a boolean
    // True if the list is empty, false if it is not
    isEmpty() {
        return this.head === null;
    }

    addToBack(value) {
        if (this.isEmpty()) {
            this.head = new SLNode(value);
            return this;
        }
        let runner = this.head;
        while (runner.next != null) {
            runner = runner.next;
        }
        runner.next = new SLNode(value);
        return this;
        // check if it is empty here
    }

    // BONUS:
    // Write a method that takes an array as a parameter, and converts it into a singly linked list

    // EXAMPLE:
    // seedFromArr([1,2,3,4]) would return
    // 1 -> 2 -> 3 -> 4 ->
    seedFromArr(array) {
        array.forEach((value) => {
            this.addToBack(value);
        });
        return this;
    }

    printList() {
        if (this.head == null) {
            console.log("List is empty.");
            return;
        }
        let output = "";
        let runner = this.head;
        while (runner != null) {
            output += `${runner.value} -> `;
            runner = runner.next;
        }
        console.log(output);
    }
}

let myList = new SLList();
myList.seedFromArr([3, 6, 8, 9, 23]);

myList.printList();
