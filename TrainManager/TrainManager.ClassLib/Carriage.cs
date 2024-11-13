namespace TrainManager.ClassLib;

public abstract class Carriage(double emptyWeight , int carNum)
{ 
  #region CONSTANTS
  public const int MAX_PASSENGERS_PER_CAR = 200; //  Max number of Passengers per PassengerCarriage
  public const double
    AVG_WEIGHT_PER_PASSENGER = 0.06, //  Average weight of one Passenger [t]
    COST_PER_PASSENGER_CAR = 300.0,  //  Cost per PassengerCarriage
    MAX_CARGOWEIGHT_PER_CAR = 99.0,  //  Max weight of freight [t] per CargoCarriage
    COST_PER_CARGO_CAR = 250.0;      //  Cost per CargoCarriage
  #endregion

  #region FIELDS
  private readonly double _emptyWeight = emptyWeight;
  private readonly int _carriageNumber = CheckCarNum(carNum);
  #endregion

  #region PROPERTIES
  public double EmptyWeight => _emptyWeight;
  public int CarriageNumber => _carriageNumber;
  #endregion

  #region ABSTRACT METHODS
  public abstract double GetProfit();
  public abstract double GetFullWeight();
  #endregion

  #region PRIVATE HELPER METHODS
  private static int CheckCarNum(int carNum)
    => carNum.ToString().Length == 8 && IsValid(carNum) ? carNum : 1;
  private static bool IsValid(int carNum)
    => CalcSum(GetDigits(carNum)).ToString().EndsWith('0');
  private static int[ ] GetDigits(int number)
    => number.ToString().Select(c => int.Parse(c.ToString())).ToArray();
  private static int CalcSum(int[ ] digits)
  {
    int sum = 0;
    for (int i = 0 ; i < 8 ; i++)
      sum += digits[ i ] * (i + 1);
    return sum;
  }
  #endregion
}