﻿namespace TrainManager.ClassLib;

internal class Train(double maxTrainWeight)
{
  #region FIELDS
  private readonly List<Carriage>? _carriageList;
  private readonly double _maxTrainWeight = maxTrainWeight;
  #endregion

  #region PROPERTIES
  public List<Carriage>? CarriageList => _carriageList;
  public double MaxTrainWeight => _maxTrainWeight;
  public int CountOfPassangersCars => GetNumOfPassengerCars();
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
    => CanAddPassengers(carriageNumber , newPassengers);
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

  private bool CanAddPassengers(int carriageNumber , int newPassengers)
  {
    if (CarriageList == null)
      return false;

    foreach (PassengerCar p in CarriageList.Cast<PassengerCar>())
      if (CeckCarriage(carriageNumber , newPassengers , p))
      {
        PassengerCar newLoadedCar = p;
        newLoadedCar.NumberOfPassangers += newPassengers;

        CarriageList.Remove(p);
        AddCarriage(newLoadedCar);

        return true;
      }
    return false;
  }

  private bool CeckCarriage(int carriageNumber , int newPassengers , PassengerCar p)
    => carriageNumber == p.CarriageNumber
    && p.NumberOfPassangers + newPassengers < Carriage.MAX_PASSENGERS_PER_CAR
    && newPassengers * Carriage.AVG_WEIGHT_PER_PASSENGER + GetTrainWeight() < MaxTrainWeight;
  #endregion
}