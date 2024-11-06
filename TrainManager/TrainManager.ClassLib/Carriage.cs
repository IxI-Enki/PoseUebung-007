namespace TrainManager.ClassLib;

internal abstract class Carriage(double emptyWeight , int carNum)
{
  // use primary Constructors!

  #region CONSTANTS
  public const int MAX_PASSENGERS_PER_CAR = 200;     //  Maximale Anzahl der Passagiere je Passagierwagon
  public const double
    AVG_WEIGHT_PER_PASSENGER = 0.06,                  //  Durchschnittsgewicht eines Passagiers (in Tonnen)
    COST_PER_PASSENGER_CAR = 300.0,                   //  Kosten je Wagon

    MAX_CARGOWEIGHT_PER_CAR = 99.0,                   //  Maximale Fracht in Tonnen je Frachtwagon
    COST_PER_CARGO_CAR = 250.0;                       //  Kosten je Frachtwagon
  #endregion

  #region FIELDS
  private double _emptyWeight = emptyWeight;
  private int _carriageNumber = CheckCarNum(carNum);
  #endregion

  #region PROPERTIES
  public double EmptyWeight => _emptyWeight;
  public int CarriageNumber => _carriageNumber;
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

  #region ABSTRACT METHODS
  public abstract double GetProfit();
  public abstract double GetFullWeight();
  #endregion
}