namespace Classes___Objects;

internal class Program
{
    
    static void Main(string[] args)
    {

        /**
        Console.WriteLine();
        Console.WriteLine("\tCOUNTRIES\n");

        var BeautyOfAdress = new List<Country>();

        Console.WriteLine();
        Console.WriteLine("\tShvetsariya");
        Console.WriteLine("\n");
        Country firstCountry = new Country()
        {
            Place = "               Shvetsariya",
            Appearence = "                Ko'm ko'k osmonu bepayon kengliklarga ega tog'lari mavjud.",
            Construction = "           Tarixiy binolar",
            DiscoveredTime = "       984 yil",
            Culture = "                Zamonaviy va tarixiy hodisalarga uygun bo'lgan madaniyat",
            WellKnowen = "                   Turistik zonaga ega bo'lgan noyob mamlakat",
            Benefits = "                 Musaffo havoga ega",
            Healthy = "          Toza havosi ko'pgina dardga davo bo'lishga sabab bo'ladi",
            Population = "                   40 milliondan oshiq\n",
            Animals = "                 Asosan burgut va uy hayvonlari mavjud bo'lgan mamlakat.\n\n\n\n",
        };
        firstCountry.DisplayOfBeauty();



        var secondCountry = new Country();
        Console.WriteLine("=================================================================================\n");
        Console.WriteLine("\tUzbekistan");

        Console.WriteLine("\n");

        secondCountry.Place = "             Uzbekistan";
        secondCountry.Appearence = "              Kenglklarga boy ko'rinishga ega";
        secondCountry.Construction = "         Tarixiy binolar";
        secondCountry.DiscoveredTime = "     1991 yil";
        secondCountry.Culture = "              Havas qilishga arzigulik madaniyat";
        secondCountry.WellKnowen = "                 Tarixda ilmi bilan mashxur ammo hozirda faqatgina o'rta Osiyoda nomi chiqqan davlat";
        secondCountry.Benefits = "               Ba'zi davlatlarga qaraganda ilmga boy davlat";
        secondCountry.Healthy = "        True/False";
        secondCountry.Population = "                 40 millon";
        secondCountry.Animals = "               Asosan uy hayvonlari lekin yovvoyi hayvonlar mavjud emas";

        secondCountry.DisplayOfBeauty();

        Console.WriteLine("\n=================================================================================\n");
        Console.WriteLine("\tKingdom of Saudia Arabia");

        Console.WriteLine("\n");

        var thirdCountry = new Country()
        {

            Place = "               Saudiya Arabistoni Qirolligi",
            Appearence = "                Asosan chol zonalari.",
            Construction = "           Tarixiy va ko'payib borayotgan zamonaviy binolar",
            DiscoveredTime = "       Miloddan avvalgi yillarda",
            Culture = "                Asosan Islomiy madaniyatga tayyangan mamlakat",
            WellKnowen = "                   Makka va Madina ziyorati",
            Benefits = "                 Ilm",
            Healthy = "          Sog'liqga zarar qiladigan nojo'yi ta'sir mavjud emas",
            Population = "                   80 milliondan ortiq",
            Animals = "                 Asosan burgut va yovvoyi hayvonlari mavjud bo'lgan mamlakat.\n\n\n\n",
        };
        thirdCountry.DisplayOfBeauty();



        Console.WriteLine("==================================================================================================================");
        */



        Console.WriteLine();
        Console.WriteLine("\tCREATURES\n");


        var CreatureofEarth = new List<Creature>();

        Console.WriteLine();
        Console.WriteLine("\tInson (Erkak)");
        Console.WriteLine("\n========================================================================\n");

        var humanMan = new Creature()
        {
            Creatures = "               Erkak inson",
            MentalActivity = "          Mustaqil idrok qila oladi va aqliga tayanadi",
            Living = "               Harakat qilsa hamma muhitga moslashuvchan",
            Homes = "                   Maxsus qurilgan ko'p qavatli bino yoki",
            Intuitions = "              O'rgana olish va ta'lim bera olish intuitsiyasi",
            FeedingBabies = "           Yashashga bo'lgan maqsadlaridan biri",
            Dangers = "                 Asosan yaqin insonlarini yo'qotish",
            Benefits = "                Insoniyatni ko'payishiga sababchi",
            AffectsForTheFuture = "     Ko'pgina sohalarda ulkan foydali o'zgartirishlar kiritish",
            DistinguishingFeature = "   Jiddiy va real voqealikga tayanuvchan",

        };
        humanMan.DisplayOfCreature();

        Console.WriteLine();
        Console.WriteLine("\tInson (Ayol)");
        Console.WriteLine("\n========================================================================\n");

        var humanWoman = new Creature()
        {
            Creatures = "               Ayol inson",
            MentalActivity = "          Mustaqil idrok qila oladi va asosan hissiyotiga tayanadi",
            Living = "               Har bir vaziyatga moslashgan holda yashovchi",
            Homes = "                   Maxsus qurilgan ko'p qavatli bino yoki",
            Intuitions = "              Asosan onalik intuitsiyasi",
            FeedingBabies = "           Yashashga bo'lgan maqsadlaridan biri",
            Dangers = "                 Asosan yaqin insonlarini yo'qotish",
            Benefits = "                Har bir vaziyatda ishona oladigan juft",
            AffectsForTheFuture = "     Kelajak avlodning ulug' olim bo'lib yetishishdagi asosiy sababchi",
            DistinguishingFeature = "   Asosan hissiyotga tayanuvchan",

        };
        humanWoman.DisplayOfCreature();

        Console.WriteLine();
        Console.WriteLine("\tHayvon");
        Console.WriteLine("\n========================================================================\n");

        var aniMal = new Creature()
        {
            Creatures = "               Uy hayvonlari",
            MentalActivity = "          Mustaqil idrok qila olmasdan intuitsiyaga tayanuvchi mavjudodlar",
            Living = "               Insonlar qaramog'ida",
            Homes = "                   Insonlarning uyiga maxsus qurilgan in yoki kichik kulbalarda",
            Intuitions = "              Yashashda asosan suyanchig'i",
            FeedingBabies = "           Insonlar tomonidan",
            Dangers = "                 Kasalliklar",
            Benefits = "                Himoya, ermak va ozuqviy moddalari",
            AffectsForTheFuture = "     Insonlar bilan yashashda va turli-hil tajribalarda",
            DistinguishingFeature = "   Qo'lga o'rganuvchan",
        };
        aniMal.DisplayOfCreature();
    }
    







    









}
