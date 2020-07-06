using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace MenuInterface
{
    public class DataAccess
    {
        //Create class with which we call to access data

        public List<PartyMember> GetPartyMembers()
        {
            //Fetch connection string from App.config to form connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                //Add sql command to query connection- allows us to TAKE data
                var output = connection.Query<PartyMember>("dbo.party_members_GetPartyMembers").ToList();
                return output;
            }
        }

        public List<PartyMember> GetPartyMembersByName(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<PartyMember>("dbo.party_members_GetByName @Name", new { name = Name }).ToList();
                return output;
            }
        }

        public List<Weapon> GetCraftedWeapon(int Value, string Element)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<Weapon>("dbo.weapons_GetByValue @value, @element", new { value = Value, element = Element }).ToList();
                return output;
            }
        }

        public List<PartyMemberCraft> GetCraftingStats()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<PartyMemberCraft>("dbo.crafting_GetPartyMembers").ToList();
                return output;
            }
        }

        public List<Weapon> GetWeapons()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<Weapon>("dbo.inventoryWeapons_GetWeapons").ToList();
                return output;
            }
        }

        public List<PartyMemberCraft> GetCraftingStatsByName(string Name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                //Include specified name
                var output = connection.Query<PartyMemberCraft>("dbo.crafting_GetPartyMembersByName @Name", new { name = Name }).ToList();
                return output;
            }
        }

        /*public void InsertPartyMember(string Name, string Weapon, int HP, int mAttack, int mDefence, int rAttack, int rDefence, int mSpeed, int aSpeed)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            { 
                //use CURLY BRACES to differentiate from regular class argument
                PartyMember newPartyMember = new PartyMember { name = Name, weapon = Weapon, maxHealth = HP, meleeAttack = mAttack, meleeDefence = mDefence, 
                                                                rangedAttack = rAttack, rangedDefence = rDefence, movementSpeed = mSpeed, attackSpeed = aSpeed};
                //Store new party member in list
                List<PartyMember> partyMembers = new List<PartyMember>();

                partyMembers.Add(newPartyMember);

                //Exceute connection stores values in data
                connection.Execute("dbo.party_members_Insert @Name, @Weapon, @HP, @MeleeAttack, @MeleeDefence, @RangedAttack, @RangedDefence, @MovementSpeed, @AttackSpeed", partyMembers);
                //!Can't recognise @ for HP (and possibly all the others)
            }
        }*/

        public void InsertWeapon(string Name, string Type, int Health, int mAttack, int mDefence, int rAttack, int rDefence, int mSpeed, int aSpeed, double Status, string Element)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                //use CURLY BRACES to differentiate from regular class argument
                Weapon newWeapon = new Weapon
                {
                    name = Name,
                    health = Health,
                    meleeAttack = mAttack,
                    meleeDefence = mDefence,
                    rangedAttack = rAttack,
                    rangedDefence = rDefence,
                    movementSpeed = mSpeed,
                    attackSpeed = aSpeed,
                    status = Status,
                };
                //Store new weapon in list
                List<Weapon> weapons = new List<Weapon>();
                weapons.Add(newWeapon);

                //Exceute connection stores values in data
                connection.Execute("dbo.inventoryWeapons_Insert @Name, @Type, @Health, @MeleeAttack, @MeleeDefence, @RangedAttack, @RangedDefence, @MovementSpeed, @AttackSpeed, @Status, @Element", weapons);
            }
        }
        public List<Part> GetParts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<Part>("dbo.parts_GetParts").ToList();
                return output;
            }
        }

        public List<ElementChip> GetChips()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<ElementChip>("dbo.parts_GetChips").ToList();
                return output;
            }
        }

        public List<Item> GetItems()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                var output = connection.Query<Item>("dbo.items_Get").ToList();
                return output;
            }
        }
    }
}
