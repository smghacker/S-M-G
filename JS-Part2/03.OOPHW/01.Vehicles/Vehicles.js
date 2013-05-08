function Vehicle() {
    var self = this;
    var speed;
    var propulsionUnit;
    var numberOfPropulsionUnits = 0;

    self.SetSpeed = function (value) {
        speed = value;
    }

    self.GetSpeed = function () {
        return speed;
    }

    self.SetPropulsionUnit = function (value) {
        propulsionUnit = value;
    }

    self.GetPropulsionUnit = function () {
        return propulsionUnit;
    }

    self.SetNumberOfPropulsionUnit = function (value) {
        numberOfPropulsionUnits = value;
    }

    self.GetNumberOfPropulstionUnits = function () {
        return numberOfPropulsionUnits;
    }
}
function LandVehicle(numberOfPropulsionUnits,radius) {
    Vehicle.call(this);
    var propulsionUnit = this.SetPropulsionUnit(new Wheel(radius));
    this.SetNumberOfPropulsionUnit(numberOfPropulsionUnits);

    
    this.Accelerate = function () {
        this.SetSpeed(this.GetSpeed() + this.GetPropulsionUnit().GetAcc());
    }
}
LandVehicle.prototype = new Vehicle();
LandVehicle.prototype.constructor = LandVehicle;

function AirVehicle(numberOfPropulsionUnits) {
    Vehicle.call(this);
    var self = this;
    var propulsionUnit = self.SetPropulsionUnit(new PropellNozzle(250));
    self.AfterBurnersOn = function (state) {
        if (state != self.GetPropulsionUnit().GetAfterBurnerState()) {
            self.GetPropulsionUnit().SetAfterBurnerState(state);
        }
    }
    self.Accelerate = function () {
        self.SetSpeed(self.GetSpeed() + self.GetPropulsionUnit().GetAcc() * self.GetNumberOfPropulstionUnits());
    }

    self.SetNumberOfPropulsionUnit(numberOfPropulsionUnits);
}
AirVehicle.prototype = new Vehicle();
AirVehicle.prototype.constructor = AirVehicle;

function WaterVehicle(numberOfPropulsionUnits) {
    Vehicle.call(this);
    var self = this;
    var propulsionUnit;
    self.SetPropulsionUnit(new Propeller("clockwise"));

    self.ChangeSpinDirection = function (newDir) {
        self.GetPropulsionUnit().SetSpinDir(newDir);
    }

    self.GetSpinDirection = function () {
        if (self.GetPropulsionUnit().GetSpinDir()) {
            return "clockwise";
        } else {
            return "counter-clockwise";
        }
    }

    self.Accelerate = function () {
        self.SetSpeed(self.GetSpeed() + self.GetPropulsionUnit().GetAcc() * self.GetNumberOfPropulstionUnits());
    }

    self.SetNumberOfPropulsionUnit(numberOfPropulsionUnits);
}
WaterVehicle.prototype = new Vehicle();
WaterVehicle.prototype.constructor = WaterVehicle;

function Amphibius(numberOfPropulsionUnits) {
    Vehicle.call(this);
    var self = this;
    var mode = "land";
    self.SetNumberOfPropulsionUnit(numberOfPropulsionUnits);

    self.GetMode = function () {
        return mode;
    }

    self.SetMode = function (value) {
        mode = value;
    }

    self.ChangeMode = function (newMode) {
        if (newMode === "water" || newMode === "land") {
            if (newMode !== self.GetMode()) {
                self.SetMode(newMode);
                self.SetPropUnitDependingOnMode();
            } else {
                console.log("   Now you are in the wanted mode");
            }
        } else {
            console.log("   There is no such mode");
        }
    }

    self.SetPropUnitDependingOnMode = function () {
        self.SetNumberOfPropulsionUnit(numberOfPropulsionUnits);
        if (self.GetMode() === "water") {            
            self.SetPropulsionUnit(new Propeller("clockwise"));
        } else if (self.GetMode() === "land") {
            self.SetPropulsionUnit(new Wheel(3));
        }
    }

    self.SetPropulsionUnit(self.SetPropUnitDependingOnMode());

    self.ChangeSpinDirection = function (newDir) {
        if (self.GetPropulsionUnit() instanceof Propeller) {
            self.GetPropulsionUnit().SetSpinDir(newDir);
        } else {
            console.log("   You are in a land mode.Fans are disabled");
        }
    }

    self.Accelerate = function () {
        self.SetSpeed(self.GetSpeed() + self.GetPropulsionUnit().GetAcc() * numberOfPropulsionUnits);
    }
}
Amphibius.prototype = new Vehicle();
Amphibius.prototype.constructor = Amphibius;

//I am not sure why i need this class, but i think that through it i reach good abstraction which i can use in Vehicle class
function PropulsionUnit() {
    this.GetAcc = function () {
    }
}

function Wheel(radius) {
    PropulsionUnit.call(this);

    var radius = radius;

    this.GetAcc = function () {
        return 2 * Math.PI * radius;
    }
}
Wheel.prototype = new PropulsionUnit();
Wheel.prototype.constructor = Wheel;

function PropellNozzle(power) {
    PropulsionUnit.call(this);
    var self = this;
    var power = power;
    var afterBurner = false;

    self.SetAfterBurnerState = function (state) {
        afterBurner = state;
    }

    self.GetAfterBurnerState = function () {
        return afterBurner;
    }

    self.GetAcc = function () {
        if (self.GetAfterBurnerState()) {
            return 2 * power;
            }
        return power;
        }
}
PropellNozzle.prototype = new PropulsionUnit();
PropellNozzle.prototype.constructor = PropellNozzle;

function Propeller(spinDirection) {
    PropulsionUnit.call(this);
    var self = this;
    var numberOfFans = 2;
    var spinDirection;
    

    self.SetNumberOfFans = function (value) {
        numberOfFans = value;
    }

    self.GetNumberOfFans = function () {
        return numberOfFans;
    }

    self.SetSpinDir = function (newDir) {
        if (newDir === "clockwise") {
            spinDirection = true;
        } else if (newDir === "counter-clockwise") {
            spinDirection = false;
        }
    }

    self.SetSpinDir(spinDirection);
    self.GetSpinDir = function () {
        return spinDirection;
    }

    self.GetAcc = function () {
        if (self.GetSpinDir()) {
            return self.GetNumberOfFans();
        }
        return -self.GetNumberOfFans();
    }
}
Propeller.prototype = new PropulsionUnit();
Propeller.prototype.constructor = Propeller;