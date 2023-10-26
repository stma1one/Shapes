namespace Parcel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parcel[] parcels = { new Parcel("talsi"), new RegisteredParcel("humi"), new MuchoParcel("Kuku") };
            Console.WriteLine(FindRegistered(parcels));





        }
        public static bool FindRegistered(Parcel[] parcels)
        {

            for (int i = 0; i < parcels.Length; i++)

                //מכיוון שלחבילה בסיסית יש פעולת 
                //DELIVER- הכל עובר קומפילציה
                //עבור תא 0 שבו יש SHAPE
                //תופעל ברירת המחדש
                //עבור תא 1
                //בגלל הOVERRIDE
                //תופעל הפעולה של חבילה רשומה
                //עבור תא 2
                //בגלל שאין אוברייד
                //תופעל הפעולה הרגילה של PARCEL
                //כלומר הVIRTUAL
                Console.WriteLine(parcels[i].Deliver());
            return false;
        }

    }
}
}