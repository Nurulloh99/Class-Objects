using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes___Objects;

public class Restaurant
{
    public string Name { get; set; }  // Nom
    public string Address { get; set; }  // Manzil
    public string CuisineType { get; set; }  // Taom turi
    public double Rating { get; set; }  // Reyting
    public bool IsOpen { get; set; }  // Ochilish holati
    public string PhoneNumber { get; set; }  // Telefon raqami
    public List<string> MenuItems { get; set; }  // Menyudagi taomlar
    public string Owner { get; set; }  // Egasi
    public DateTime EstablishmentDate { get; set; }  // Asos solingan sana
    public double AverageMealPrice { get; set; }  // O‘rtacha taom narxi

    public void DisplayOfRestaurant()
    {
        string result = $" Name: {Name}\n Address: {Address}\n " +
            $"Cuisine type: {CuisineType}\n Rating: {Rating}\n " +
            $"IsOpen: {IsOpen}\n Phone number: {PhoneNumber}\n Menu items: {MenuItems}\n " +
            $"Owner: {Owner}\n Establishment date: {EstablishmentDate}\n Average meal price: {AverageMealPrice}\n";

        Console.WriteLine(result);
    }
}
