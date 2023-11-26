using System;

namespace LABA2
{ 
    struct freighttrain
    {
        private string Fname;
        public string fname { get { return Fname; } set { Fname = value; } }
        private int Fnumber;
        public int fnumber { get { return Fnumber; } set { Fnumber = value; } }
        private string Ttime;
        public string ttime { get { return Ttime; } set { Ttime = value; } }
    }
    struct passangertrain
    {
        private string Pname;
        public string pname { get { return Pname; } set { Pname = value; } }
        private int Pnumber;
        public int pnumber { get { return Pnumber; } set { Pnumber = value; } }
        private string Time;
        public string time { get { return Time; } set { Time = value; } }
    }

    class search 
    {
       static void Main()
        {
            passangertrain[] train;
            train = new passangertrain[5];
            train[0].pname = "Москва-Санкт-Петербург";
            train[0].pnumber = 135;
            train[0].time = "06:32";
            train[1].pname = "Курск-Тула";
            train[1].pnumber = 18;
            train[1].time = "09:55";
            train[2].pname = "Анапа-Москва";
            train[2].pnumber = 298;
            train[2].time = "12:11";
            train[3].pname = "Белгород-Казань";
            train[3].pnumber = 277;
            train[3].time = "16:47";
            train[4].pname = "Сочи-Брянск";
            train[4].pnumber = 303;
            train[4].time = "23:31";
            freighttrain[] ttrain;
            ttrain = new freighttrain[5];
            ttrain[0].fname = "Воркута-Хабаровск";
            ttrain[0].fnumber = 1509;
            ttrain[0].ttime = "04:21";
            ttrain[1].fname = "Санкт-Петербург-Новокузнецк";
            ttrain[1].fnumber = 1076;
            ttrain[1].ttime = "09:50";
            ttrain[2].fname = "Нижневартовск-Архангельск";
            ttrain[2].fnumber = 2730;
            ttrain[2].ttime = "13:50";
            ttrain[3].fname = "Магадан-Хасавюрт";
            ttrain[3].fnumber = 2238;
            ttrain[3].ttime = "17:00";
            ttrain[4].fname = "Новосибирск-Орел";
            ttrain[4].fnumber = 3994;
            ttrain[4].ttime = "22:21";
            Console.WriteLine("1) 00:00 - 12:00 \n2) 12:00 - 18:00 \n3) 18:00 - 00:00");
            Console.Write("Введите желаемое время суток:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#############################################");
            Console.WriteLine("1) Товарный \n2) Пассажирский");
            Console.Write("Введите вид поезда:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("#############################################");
            if (a==1 && b==1)
            {
                Console.WriteLine("Тoварные поезда прибывающие с 00:00 до 12:00: ");
                Console.Write($"1) {ttrain[0].fname}, {ttrain[0].fnumber}, время прибытия: {ttrain[0].ttime} \n2) {ttrain[1].fname}, {ttrain[1].fnumber}, время прибытия: {ttrain[1].ttime}");
            }
            if (a == 2 && b == 1)
            {  
                Console.WriteLine("Тoварные поезда прибывающие с 12:00 до 18:00: ");
                Console.WriteLine($"1) {ttrain[2].fname}, {ttrain[2].fnumber}, время прибытия: {ttrain[2].ttime} \n2) {ttrain[3].fname}, {ttrain[3].fnumber}, время прибытия: {ttrain[3].ttime}");                   
            }
            if (a == 3 && b == 1)
            {
                Console.WriteLine("Тoварные поезда прибывающие с 18:00 до 00:00: ");
                Console.WriteLine($"1) {ttrain[4].fname}, {ttrain[4].fnumber}, время прибытия: {ttrain[4].ttime}");
            }
            if (a == 1 && b == 2)
            {
                Console.WriteLine("Пассажирские поезда прибывающие с 00:00 до 12:00: ");
                Console.WriteLine($"1) {ttrain[0].fname}, {ttrain[0].fnumber}, время прибытия: {ttrain[0].ttime} \n2) {ttrain[1].fname}, {ttrain[1].fnumber}, время прибытия: {ttrain[1].ttime}");
            }
            if (a == 2 && b == 2)
            {
                Console.WriteLine("Пассажирские поезда прибывающие с 12:00 до 18:00: ");
                Console.WriteLine($"1) {ttrain[2].fname}, {ttrain[2].fnumber}, время прибытия: {ttrain[2].ttime} \n2) {ttrain[3].fname}, {ttrain[3].fnumber}, время прибытия: {ttrain[3].ttime}");
            }
            if (a == 3 && b == 2)
            {
                Console.WriteLine("Пассажирские поезда прибывающие с 18:00 до 00:00: ");
                Console.WriteLine($"1) {ttrain[4].fname}, {ttrain[4].fnumber}, время прибытия: {ttrain[4].ttime}");
            }
            if (a > 3 || b > 2)
            {
                Console.WriteLine("ВВЕДИТЕ КОРРЕКТНЫЕ ЗНАЧЕНИЯ!");             
            }
            Console.ReadKey();
        }

    }
}
