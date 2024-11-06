namespace TrainManager.ClassLib;

internal class PassengerCar : Carriage
{
  #region FIELDS
  private int _numberOfPassangers = 0;
  private double _pricePerTicket;
  #endregion

  #region PROPERTIES
  public int NumberOfPassangers { get => _numberOfPassangers; set => _numberOfPassangers = value; }
  public double PricePerTicket { get => _pricePerTicket; set => _pricePerTicket = value; }
  #endregion

  #region CONSTRUCTOR
  public PassengerCar(double emptyWeight , int carriageNumber , int numberOfPassangers , double pricePerTicket)
    : base(emptyWeight , carriageNumber)
  {
    _numberOfPassangers = numberOfPassangers;
    _pricePerTicket = pricePerTicket;
  }
  #endregion

  #region METHODS
  public override double GetFullWeight()
    => NumberOfPassangers * AVG_WEIGHT_PER_PASSENGER + EmptyWeight;
  public override double GetProfit()
    => NumberOfPassangers * PricePerTicket - COST_PER_PASSENGER_CAR;
  #endregion
}