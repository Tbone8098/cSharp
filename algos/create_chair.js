
class Chair {
    constructor(legsNum = 4, backrest = true, seat = true) {
        this.legsNum = legsNum
        this.backrest = backrest
        this.seat = seat
    };

    seat(material = "wood", size = "small") {
        this.material = material;
        this.size = size;
    };

    Leg(material = "wood", height = 2, adjustable = false) {
        this.material = material;
        this.height = height;
        thistory.adjustable = adjustable;
    };

    backrest(material = "wood", height, width, lumbarSupport = false) {
        this.material = material
        this.height = height
        this.width = width
        this.lumbarSupport = lumbarSupport
        console.log(`the backrest of this chair is made out of ${this.material}. It is ${this.height} feet tall and ${this.width} feet wide.`);
    };
}

class ArmChair extends Chair {
    constructor(arms = 2) {
        super(legsNum = 4, backrest = true, seat);
        this.arms = arms
    }
}

let woodenChair = new Chair(6)

console.log(woodenChair.backrest("wood", 2, 1, false));