using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabTraining.csharp_codes.ParcelTracker
{
    public class ParcelUtility : IParcel
    {
        private ParcelTrack head;

        public void AddStage(string stage)
        {
            ParcelTrack newNode = new ParcelTrack(stage);

            if (head == null)
            {
                head = newNode;
                return;
            }

            ParcelTrack temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void AddCheckpoint(string afterStage, string newStage)
        {
            ParcelTrack current = head;

            while (current != null)
            {
                if (current.StageName == afterStage)
                {
                    ParcelTrack checkpoint = new ParcelTrack(newStage);
                    checkpoint.Next = current.Next;
                    current.Next = checkpoint;
                    return;
                }
                current = current.Next;
            }
        }

        public void TrackParcel()
        {
            ParcelTrack current = head;

            while (current != null)
            {
                Console.WriteLine("Stage: " + current.StageName);

                if (current.Next == null && current.StageName != "Delivered")
                {
                    Console.WriteLine("Parcel Lost or Missing!");
                    return;
                }

                current = current.Next;
            }
        }
    }
}
