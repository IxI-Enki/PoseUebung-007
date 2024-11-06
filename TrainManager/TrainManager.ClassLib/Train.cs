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

  #region PRIVATE HELPER METHODS
  // private int GetNumOfPassengerCars() => CarriageList?.Count(c => c is PassengerCar) ?? 0;
  private int GetNumOfPassengerCars()
  {
    int count = 0;
    if (CarriageList != null)
      foreach (Carriage c in CarriageList)
        count += (c is PassengerCar) ? 1 : 0;
    return count;
  }

  private void AddCarInSortedOrder(Carriage newCar)
  {
    int index = 0;
    while (index < CarriageList!.Count && CarriageList[ index ].GetFullWeight() >= newCar.GetFullWeight())
      index++;
    CarriageList.Insert(index , newCar);
  }
  #endregion

  #region METHODS
  // public double GetTrainWeight() => CarriageList?.Sum(c => c.GetFullWeight()) ?? 0;
  public double GetTrainWeight()
  {
    double weight = 0;
    if (CarriageList != null)
      foreach (Carriage c in CarriageList)
        weight += c.GetFullWeight();
    return weight;
  }

  // public Carriage? GetMostProfitableCarriage() => CarriageList?.OrderByDescending(c => c.GetProfit()).FirstOrDefault();
  public Carriage? GetMostProfitableCarriage()
  {
    if (CarriageList == null)
      return null;

    Carriage? mostProfitableCar = CarriageList[ 0 ];
    foreach (Carriage c in CarriageList)
      if (c.GetProfit() > mostProfitableCar.GetProfit())
        mostProfitableCar = c;

    return mostProfitableCar;
  }

  // public int GetAmountOfPassangersInTrain() => CarriageList?.Cast<PassengerCar>().Sum(p => p.NumberOfPassangers) ?? 0;
  public int GetAmountOfPassangersInTrain()
  {
    int numOfPassengers = 0;
    if (CarriageList != null)
      foreach (PassengerCar p in CarriageList.Cast<PassengerCar>())
        numOfPassengers += p.NumberOfPassangers;
    return numOfPassengers;
  }

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

  public bool AddPassangersToCar(int carriageNumber , int newPassengers)
  {
    // LAST MISSING METHOD
    return false;
  }
  #endregion
}