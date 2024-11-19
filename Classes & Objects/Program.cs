namespace Classes___Objects;

internal class Program
{
    static void Main(string[] args)
    {

        var BeautyOfAdress = new List<Beauty>();

        Console.WriteLine();
        Beauty appearance = new Beauty()
        {
            Place = "    Shvetsariya\n",
            Appearence = "         Ko'm ko'k osmonu bepayon kengliklarga ega tog'lari mavjud.\n",
            Construction = "       Tarixiy binolar\n",
            DiscoveredTime = "     984 yil\n",
            Culture = "            Zamonaviy va tarixiy hodisalarga uygun bo'lgan madaniyat\n",
            WellKnowen = "         Turistik zonaga ega bo'lgan noyob mamlakat\n",
            Benefits = "           Musaffo havoga ega\n",
            Healthy = "            Toza havosi ko'pgida dardga davo bo'lishga sabab bo'ladi\n",
            Population = "         40 milliondan oshiq\n",
            Animals = "            Asosan burgut va uy hayvonlari mavjud bo'lgan mamlakat.\n\n\n\n",
        };

        appearance.DisplayOfBeauty();
    }
}
