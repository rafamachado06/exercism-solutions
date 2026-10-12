class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int minutesInOven) {
        var expectedMinutesInOven = ExpectedMinutesInOven();        
        return expectedMinutesInOven - minutesInOven;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layersAdded) {
        return layersAdded * 2;
    }
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layersAdded, int minutesInOven) {
        var preparationTimeInMinutes = PreparationTimeInMinutes(layersAdded);
        return preparationTimeInMinutes + minutesInOven;
    }
}
