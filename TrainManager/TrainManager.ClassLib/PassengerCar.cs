namespace TrainManager.ClassLib;

public class PassengerCar(double emptyWeight , int carriageNumber , int numberOfPassangers , double pricePerTicket)
  : Carriage(emptyWeight , carriageNumber)
{
  #region FIELDS
  private int _numberOfPassangers = numberOfPassangers < MAX_PASSENGERS_PER_CAR ? numberOfPassangers : MAX_PASSENGERS_PER_CAR;
  private double _pricePerTicket = pricePerTicket;
  #endregion

  #region PROPERTIES
  public int NumberOfPassengers { get => _numberOfPassangers; set => _numberOfPassangers = value; }
  public double PricePerTicket { get => _pricePerTicket; set => _pricePerTicket = value; }
  #endregion

  #region METHODS
  public override double GetFullWeight() => NumberOfPassengers * AVG_WEIGHT_PER_PASSENGER + EmptyWeight;
  public override double GetProfit() => NumberOfPassengers * PricePerTicket - COST_PER_PASSENGER_CAR;
  #endregion
}