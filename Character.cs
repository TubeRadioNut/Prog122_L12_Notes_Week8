using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prog122_L12_Notes_Week8
{
    public class Character
    {
        //Fields
        string _playerName;
        string _characterName;
        public int CharacterLevel {  get; private set; }//this is a field and propertiery at the same time( auto-implemented property )
        int _intelligence;
        int _constitution;
        int _proficiency;
        //Constructor
        public Character(string playerName)
        {
            _playerName = playerName;
        }

        public Character(int proficiency)
        {
            Proficiency = proficiency;
        }

        public Character(string playerName, string characterName)
        {
            _playerName = playerName;
            _characterName = characterName;
        }

        public Character(string playerName, string characterName, int intelligence, int constitution)
        {
            _playerName = playerName;
            _characterName = characterName;
            _intelligence = intelligence;
            _constitution = constitution;
        }

        //Properties
        public string PlayerName { get => _playerName; set => _playerName = value; }
        public string CharacterName { get => _characterName; set => _characterName = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Constitution { get => _constitution; set => _constitution = value; }

        public int Hacking { get => AbilityModifer(_intelligence); }

        public int WillPower { get => AbilityModifer(_constitution); }
        public int Proficiency { get => _proficiency; set => _proficiency = value; }

        //Method
        public int AbilityModifer(int stat)
        {
            return (stat - 10) / 2;
        }

       
        //Stat - 10/2

        //8 - 10 / 2

        //8 - 9 -1

        //10 - 10 / 2

        //

    }//end of class
}//end of namespace
