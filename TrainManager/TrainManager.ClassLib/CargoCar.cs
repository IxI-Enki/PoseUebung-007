namespace TrainManager.ClassLib;

internal class CargoCar : Carriage
{
  #region FIELDS
  private double _cargoWeight;
  private double _pricePerTon;
  #endregion

  #region PROPERTIES
  public double CargoWeight { get => _cargoWeight; set => _cargoWeight = value; }
  public double PricePerTon { get => _pricePerTon; set => _pricePerTon = value; }
  #endregion

  #region CONSTRUCTOR
  public CargoCar(double emptyWeight , int carriageNumber , double cargoWeight , double pricePerTon)
    : base(emptyWeight , carriageNumber)
  {
    _pricePerTon = pricePerTon;
    _cargoWeight = cargoWeight < MAX_CARGOWEIGHT_PER_CAR ? cargoWeight : MAX_CARGOWEIGHT_PER_CAR;
  }
  #endregion

  #region METHODS
  public override double GetFullWeight()
    => EmptyWeight + CargoWeight;

  public override double GetProfit()
    => PricePerTon * CargoWeight - COST_PER_CARGO_CAR;
  #endregion
}