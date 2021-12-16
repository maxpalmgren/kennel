using Kennel.Classes;
using Kennel.Interface;
using Kennel.MOCKDATA;
using System.Collections.Generic;

namespace Kennel
{
    public class Application : IApplication
    {
        public IMainMenu MainMenu { get; set; }
        public IMockData MockData { get; set; }

        public Application(IMainMenu mainMenu, IMockData mockData)
        {
            MainMenu = mainMenu;
            MockData = mockData;
        }
        public void Run()
        {
            MockData.CreateMockData();       
            MainMenu.Menu();
        }
    }
}