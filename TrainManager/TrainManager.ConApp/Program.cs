
using TrainManager.ClassLib;

namespace TrainManager.ConApp;

internal class Program
{
  static void Main()
  {
    Console.Write("\n Train - Manager \n");

    Train train = new Train(500);
    Carriage newPCar1 = new PassengerCar(60 , 11121111 , 50 , 10);
    Carriage newPCar2 = new PassengerCar(50 , 12121112 , 50 , 10);


    bool isAdded = train.AddCarriage(newPCar2);
    Console.WriteLine($"Full weight: {newPCar2.GetFullWeight()} - [Empty weight: {newPCar2.EmptyWeight}]");
    isAdded = train.AddCarriage(newPCar1);


    Console.ReadLine();
  }
}