using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTestApp.Apartments
{
    internal class Lists
    {
        public string[] RegionsList = new string[] { "Все", "Москва", "Санкт-Петербург", "Московская область", "Ленинградская область", "Тюменская область", "Ростовская область", "Свердловская область", "Новосибирская область", "Ставропольский край", "Республика Башкортостан", "Нижегородская область", "Саратовская область", "Республика Татарстан", "Воронежская область", "Самарская область", "Калининградская область", "Республика Крым", "Челябинская область", "Омская область", "Кемеровская область", "Красноярский край", "Белгородская область", "Иркутская область", "Волгоградская область", "Калужская область", "Владимирская область", "Пермский край", "Оренбургская область", "Ярославская область", "Томская область", "Тульская область", "Пензенская область", "Костромская область", "Вологодская область", "Алтайский край", "Хабаровский край", "Тверская область", "Удмуртская Республика", "Амурская область", "Забайкальский край", "Приморский край", "Ульяновская область", "Чувашская Республика", "Ивановская область", "Рязанская область", "Республика Хакасия", "Брянская область", "Республика Коми", "Республика Саха", "Республика Адыгея", "Архангельская область", "Сахалинская область", "Смоленская область", "Курская область", "Липецкая область", "Кабардино-Балкарская Республика", "Республика Бурятия", "Астраханская область", "Кировская область", "Республика Марий Эл", "Курганская область", "Тамбовская область", "Орловская область", "Республика Дагестан", "Новгородская область", "Республика Мордовия", "Мурманская область", "Республика Тыва", "Республика Карелия", "Псковская область", "Чеченская Республика", "Камчатский край", "Республика Северная Осетия-Алания", "Республика Алтай", "Магаданская область", "Еврейская автономная область" };
        public string[] Years = new string[] { "Все", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2018", "2019", "2020", "2021", "2022", "2023" };
    }

    public class Apartment
    {
        public int Year { get; set; }
        public int Region { get; set; }
        public double Price1Room { get; set; }
        public double Price2Room { get; set; }
        public double Price3Room { get; set; }

        public Apartment() { }
        public Apartment(int Year, int Region, double Price1Room, double Price2Room, double Price3Room)
        {
            this.Year = Year;
            this.Region = Region;
            this.Price1Room = Price1Room;
            this.Price2Room = Price2Room;
            this.Price3Room = Price3Room;
        }

        public static void FindPrices(List<Apartment> aparts, int year, int region, out double Price1R, out double Price2R, out double Price3R)
        {
            int allCount = 0;
            double sum1 = 0, sum2 = 0, sum3 = 0;
            for (int i = 0; i< aparts.Count; i++)
            {
                if ((aparts[i].Year == year) || (year < 1))
                {
                    if ((aparts[i].Region == region) || (region < 1))
                    {
                        allCount++;
                        sum1 += aparts[i].Price1Room;
                        sum2 += aparts[i].Price2Room;
                        sum3 += aparts[i].Price3Room;
                    }
                }
            }
            sum1 /= allCount; sum2 /= allCount; sum3 /= allCount;
            Price1R = sum1;
            Price2R = sum2;
            Price3R = sum3;
        }

        public static List<Apartment> ReadFromFile()
        {
            StreamReader reader = new StreamReader("Apartment/ApartInfo.txt");
            List<Apartment> aparts = new List<Apartment>();
            Apartment apart = new Apartment();
            string str = "";
            char c;

            while (reader.EndOfStream == false)
            {
                c = (char)reader.Read(); str = "";
                do
                {
                    str += c;
                    c = (char)reader.Read();
                } while (c != ' ');
                apart.Year = Convert.ToInt32(str);
                c = (char)reader.Read(); str = "";
                do
                {
                    str += c;
                    c = (char)reader.Read();
                } while (c != ' ');
                apart.Region = Convert.ToInt32(str);
                c = (char)reader.Read(); str = "";
                do
                {
                    str += c;
                    c = (char)reader.Read();
                } while (c != ' ');
                apart.Price1Room = Convert.ToDouble(str);
                c = (char)reader.Read(); str = "";
                do
                {
                    str += c;
                    c = (char)reader.Read();
                } while (c != ' ');
                apart.Price2Room = Convert.ToDouble(str);
                c = (char)reader.Read(); str = "";
                do
                {
                    str += c;
                    c = (char)reader.Read();
                } while ((c != '\n') && (reader.EndOfStream == false));
                apart.Price3Room = Convert.ToDouble(str);

                aparts.Add(new Apartment(apart.Year, apart.Region, apart.Price1Room, apart.Price2Room, apart.Price3Room));
            }
            return aparts;
        }

        public void Grafic(List<Apartment> aparts, int year, int region)
        {

        }

        public static int FindPriciestType(List<Apartment> aparts, int region)
        {
            double pr1rFirst, pr2rFirst, pr3rFirst;
            FindPrices(aparts, 1, region, out pr1rFirst, out pr2rFirst, out pr3rFirst);
            double pr1rLast, pr2rLast, pr3rLast;
            FindPrices(aparts, 15, region, out pr1rLast, out pr2rLast, out pr3rLast);

            if ((pr1rLast / pr1rFirst > pr2rLast / pr2rFirst) && (pr1rLast / pr1rFirst > pr3rLast / pr3rFirst))
                return 1;
            if (pr2rLast / pr2rFirst > pr3rLast / pr3rFirst)
                return 2;
            else
                return 3;
        }

        public static void SetPricesType(TextBox list, List<Apartment> aparts, int region)
        {
            Lists lists = new Lists();
            int check = 0;
            if (region != -1)
                check = region;
            list.Text = "Цены в " + lists.RegionsList[check] + " за последние 15 лет больше всего возросли на " + FindPriciestType(aparts, check) + "-комнатные квартиры.";
        }
    }
}
