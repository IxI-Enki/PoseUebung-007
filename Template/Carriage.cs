namespace TrainManager
{
    

    abstract public class Carriage
    {
        public const double AVG_WEIGHT_PER_PASSENGER = 0.06; //Durchschnittsgewicht eines Passagiers (in Tonnen)
        public const int MAX_PASSENGERS_PER_CAR = 200;       //Maximale Anzahl der Passagiere je Passagierwagon
        public const double MAX_CARGOWEIGHT_PER_CAR = 99.0;  //Maximale Fracht in Tonnen je Frachtwagon
        public const double COST_PER_PASSENGER_CAR = 300.0;  //Kosten je Wagon
        public const double COST_PER_CARGO_CAR = 250.0;      //Kosten je Frachtwagon

    }
}
