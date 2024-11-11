namespace TrainManager.ClassLib;

public class CargoCar(double emptyWeight , int carriageNumber , double cargoWeight , double pricePerTon) 
  : Carriage(emptyWeight , carriageNumber)
{
  #region FIELDS
  private double _cargoWeight = cargoWeight < MAX_CARGOWEIGHT_PER_CAR ? cargoWeight : MAX_CARGOWEIGHT_PER_CAR;
  private double _pricePerTon = pricePerTon;
  #endregion

  #region PROPERTIES
  public double CargoWeight { get => _cargoWeight; set => _cargoWeight = value; }
  public double PricePerTon { get => _pricePerTon; set => _pricePerTon = value; }
  #endregion

  #region METHODS
  public override double GetFullWeight() => EmptyWeight + CargoWeight;
  public override double GetProfit() => PricePerTon * CargoWeight - COST_PER_CARGO_CAR;
  #endregion
}