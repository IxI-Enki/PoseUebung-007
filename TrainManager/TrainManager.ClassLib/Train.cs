namespace TrainManager.ClassLib;

internal class Train(double maxTrainWeight)
{
  #region FIELDS
  private List<Carriage>? _carriageList;
  private double _maxTrainWeight = maxTrainWeight;
  #endregion

  #region PROPERTIES
  public List<Carriage>? CarriageList => _carriageList;
  public double MaxTrainWeight => _maxTrainWeight;
  public int CountOfPassangersCars => GetNumOfPassengerCars();
  #endregion

  #region METHODS
  public int GetNumOfPassengerCars() => CarriageList?.Count(c => c is PassengerCar) ?? 0;
  public double GetTrainWeight() => CarriageList?.Sum(c => c.GetFullWeight()) ?? 0;
  public Carriage? GetMostProfitableCarriage() => CarriageList?.OrderByDescending(c => c.GetProfit()).FirstOrDefault();
  public int GetAmountOfPassangersInTrain() => CarriageList?.Cast<PassengerCar>().Sum(p => p.NumberOfPassangers) ?? 0;
  public bool AddCarriage(Carriage newCar)
  {
    bool added = false;
    if (newCar.GetFullWeight() + GetTrainWeight() < MaxTrainWeight)
    {
      AddCarInSortedOrder(newCar);
      added = true;
    }
    return added;
  }
  public bool AddPassangersToCar(int carriageNumber, int newPassengers)
  {
    // LAST MISSING METHOD
    return false;
  }
  #endregion

  #region PRIVATE HELPER METHODS
  private void AddCarInSortedOrder(Carriage newCar)
  {
    int index = 0;
    while (index < CarriageList!.Count && CarriageList[ index ].GetFullWeight() >= newCar.GetFullWeight())
      index++;
    CarriageList.Insert(index , newCar);
  }
  #endregion
}