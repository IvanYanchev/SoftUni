using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Characters;
using TheSlum.Items;

namespace TheSlum.GameEngine
{
    public class NewEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    this.PrintCharactersStatus(this.characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Character character = null;
            string id = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);
            Team team = (Team)Enum.Parse(typeof(Team), inputParams[5]);

            switch (inputParams[1])
            {
                case "warrior":
                    character = new Warrior(id, x, y, team);
                    break;
                case "mage":
                    character = new Mage(id, x, y, team);
                    break;
                case "healer":
                    character = new Healer(id, x, y, team);
                    break;
            }

            this.characterList.Add(character);
        }

        protected override void AddItem(string[] inputParams)
        {
            Item item = null;
            string id = inputParams[3];

            switch (inputParams[2])
            {
                case "axe":
                    item = new Axe(id);
                    break;
                case "shield":
                    item = new Shield(id);
                    break;
                case "injection":
                    item = new Injection(id);
                    break;
                case "pill":
                    item = new Pill(id);
                    break;
            }

            GetCharacterById(inputParams[1]).AddToInventory(item);
        }
    }
}
