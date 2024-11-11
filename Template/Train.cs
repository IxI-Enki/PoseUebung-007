using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrainManager
{
    public class Train
    {
        //Felder und Properties gehören hier implementiert



        

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="maxTrainWeight"></param>
        public Train(int maxTrainWeight)
        {
           
        }

        /// <summary>
        /// Berechnet das Gesamtgewicht des Zugs
        /// </summary>
        /// <returns></returns>
        public double GetTrainWeight()
        {
            return 0;
        }

        /// <summary>
        /// Liefert jenen Wagon zurück, der am meisten Gewinn erzielt
        /// Wenn es keinen Wagon gibt soll null zurückgeliefert werden!
        /// </summary>
        /// <returns></returns>
        public Carriage GetMostProfitableCarriage()
        {

            return null;
        }

        /// <summary>
        /// Liefert die Anzahl aller Passagiere im Zug
        /// </summary>
        /// <returns></returns>
        public int GetAmoutOfPassengersInTrain()
        {
            return 0;
        }

        ///<summary>
        ///Ein neuer Wagon wird (sortiert) in die Liste eingefügt, wenn das maximale Zuggesamtgewicht
        ///(Feld maxTrainWeight) durch den neuen Wagon nicht überschritten wird.
        ///Die Wagons sollen absteigend sortiert nach dem Gewicht in der Liste geführt werden.
        ///Der schwerste Wagon soll ganz vorne stehen! 
        /// </summary>
        /// <param name="newCar">Neuer Wagon</param>
        /// <returns>Die Methode returniert true, wenn neuer Wagon erfolgreich eingefügt wurde, sonst false.</returns>
        public bool AddCarriage(Carriage newCar)
        {
            return false;

        }

        /// <summary>
        /// Diese Methode lässt weitere Passagiere in einen bestimmten Passagierwagon einsteigen.
        /// Als erster Parameter wird die Nummer des Wagons übergeben, in den die Passagiere einsteigen sollen.
        /// Als zweiter Parameter wird die Anzahl der zusäztlichen Passagiere übergeben.
        /// Beachte! Durch die neuen Passagiere erhöht sich das Gewicht des Wagons und er muss möglicherweise
        /// umgereiht werden (schwerere Wagons müssen vor den leichteren gereiht werden!)
        /// Methode returniert true wenn Passagiere erfolgreich eingestiegen sind.
        /// 
        /// Falls nicht alle Passagiere in den Wagon / den Zug passen, so steigt keiner ein und es wird
        /// false zurückgeliefert. (Auch Zuggesamtgewicht beachten!)
        /// Falls Wagon nicht gefunden wird, wird ebenfalls false zurückgeliefert!
        /// 
        /// Es kann davon ausgegangen werden dass die Wagonnr. eindeutig sind!
        /// </summary>
        /// <param name="carriageNumber"></param>
        /// <param name="newPassengers"></param>
        public bool AddPassengersToCar(int carriageNumber, int newPassengers)
        {
            return false;
        }

        /// <summary>
        /// Sucht des Wagon mit der übergebenen Nummer
        /// </summary>
        /// <param name="carriageNumber"></param>
        /// <returns></returns>
        public Carriage GetCarriageByNummber(int carriageNumber)
        {
            return null;
        }
    }
}
