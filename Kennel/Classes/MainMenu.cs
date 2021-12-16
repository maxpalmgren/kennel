using System;
using System.Collections.Generic;
using System.Text;
using Kennel.Interface;
using Kennel.Classes;
using Kennel.Data;
using Kennel.Manager;

namespace Kennel.Classes
{
    public class MainMenu : IMainMenu
    {
        public bool IsRunning { get; set; }
        public ICustomerManager CustomerManager { get; set; }
        public IAnimalManager AnimalManager { get; set; }
        public IKennelManager KennelManager { get; set; }

        public MainMenu(ICustomerManager customerManager,IAnimalManager animalManager, IKennelManager dropOffManager)
        {
            IsRunning = true;
            CustomerManager = customerManager;
            AnimalManager = animalManager;
            KennelManager = dropOffManager;
        }

        public void Menu()
        {
            do
            {
                ShowMenu();
            }
            while (IsRunning);
        }
        public void ShowMenu() {
        Console.WriteLine("Choose an option");
        Console.WriteLine("1) Drop off Animal");
        Console.WriteLine("2) Pick up Animal");
        Console.WriteLine("-----Owner-------");
        Console.WriteLine("3) Register Owner");
        Console.WriteLine("4) List Owners");
        Console.WriteLine("------Animal------");
        Console.WriteLine("5) Register Animal");
        Console.WriteLine("6) List All Animals and their Owners");
        Console.WriteLine("7) List current checked-in Animals and their Owners");
        Console.WriteLine("------Add Extra Services------");
        Console.WriteLine("8) Add Haircut to your animal");
        Console.WriteLine("9) Add Clawcut to your animal");

            switch (Console.ReadLine())
            {
                case "1":
                    KennelManager.DropOffAnimal();
                    break;
                case "2":
                    KennelManager.PickUpAnimal(); //TODO: lägga till kvitto
                    break;
                case "3":
                    CustomerManager.CreatePerson();
                    break;
                case "4":
                    CustomerManager.ListPersons();
                    break;
                case "5":
                    AnimalManager.CreateAnimal();
                    break;
                case "6":
                    AnimalManager.ListAnimal();
                    break;
                case "7":
                    AnimalManager.ListCheckedInAnimalsAndOwners();
                    break;
                case "8":
                    KennelManager.AddHaircut();
                    break;
                case "9":
                    KennelManager.AddClawcut();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid choice \n");
                    ShowMenu();
                    break;
            }
        }
    }
}
