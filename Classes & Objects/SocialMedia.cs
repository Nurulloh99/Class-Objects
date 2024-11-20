namespace Classes___Objects;

public class SocialMedia
{
    public string Name { get; set; }
    public string Owner { get; set; }
    public string WhenDiscovered { get; set; }
    public string Popularity { get; set; }
    public string PrivacyAndSecurity { get; set; }
    public string DataOfOpening { get; set; }
    public string Reputation { get; set; }
    public string Address { get; set; }
    public string Advertisement { get; set;
    }
    public string MissionOfSite { get; set; }

    public void DisplayOfSocialMedia()
    {
        string result = $" Name: {Name}\n Owner: {Owner}\n " +
            $"When discovered: {WhenDiscovered}\n Popularity: {Popularity}\n " +
            $"Privacy and security: {PrivacyAndSecurity}\n Data of opening: {DataOfOpening}\n Reputation: {Reputation}\n " +
            $"Address: {Address}\n Advertisement: {Advertisement}\n Mission of site: {MissionOfSite}\n";

        Console.WriteLine(result);
    }
    
}
