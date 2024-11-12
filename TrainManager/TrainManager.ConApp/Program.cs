using TrainManager.ClassLib;
namespace TrainManager.ConApp;

internal class Program
{
  static void Main()
  {
    Console.Write("\n Train - Manager \n");

    /*
    Train train = new Train(500);
    Carriage newPCar1 = new PassengerCar(60 , 11121111 , 50 , 10);
    Carriage newPCar2 = new PassengerCar(50 , 12121112 , 50 , 10);


    bool isAdded = train.AddCarriage(newPCar2);
    Console.WriteLine($"Full weight: {newPCar2.GetFullWeight()} - [Empty weight: {newPCar2.EmptyWeight}]");
    isAdded = train.AddCarriage(newPCar1);

    Train trainB = new Train(231);
    PassengerCar newPCar1b = new PassengerCar(45 , 11121111 , 50 , 10);
    CargoCar newCCar2b = new CargoCar(41 , 12121112 , 5 , 10);
    PassengerCar newPCar3b = new PassengerCar(40 , 13121113 , 50 , 10);
    PassengerCar newPCar4b = new PassengerCar(40 , 14121114 , 40 , 10);
    PassengerCar newPCar5b = new PassengerCar(40 , 15121115 , 30 , 10);
    trainB.AddCarriage(newPCar3b);
    trainB.AddCarriage(newCCar2b);
    trainB.AddCarriage(newPCar5b);
    trainB.AddCarriage(newPCar1b);
    trainB.AddCarriage(newPCar4b);

    double trainBWeight = trainB.GetTrainWeight();

    double car1bWeight = newPCar1b.GetFullWeight();
    double car2bWeight = newCCar2b.GetFullWeight();
    double car3bWeight = newPCar3b.GetFullWeight();
    double car4bWeight = newPCar4b.GetFullWeight();
    double car5bWeight = newPCar5b.GetFullWeight();

    trainB.AddPassengersToCar(14121114 , 12);
    */

    Console.ReadLine();
  }
}