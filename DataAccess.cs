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
                var output = connection.Query<PartyMember>("dbo.party_members_GetPartyMembers @Name").ToList();
                return output;
            }
        }

        public List<PartyMember> GetPartyMembersByName(string Name)
        {
            //Fetch connection string from App.config to form connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                //Add sql command to query connection- allows us to TAKE data
                var output = connection.Query<PartyMember>("dbo.party_members_GetByName @Name", new { name = Name }).ToList();
                return output;
            }
        }

        public void InsertPartyMember(string Name, string Weapon, int HP, int mAttack, int mDefence, int rAttack, int rDefence, int mSpeed, int aSpeed)
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
        }
        public List<Part> GetParts()
        {
            //Fetch connection string from App.config to form connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                //Add sql command to query connection- allows us to TAKE data
                var output = connection.Query<Part>("dbo.parts_Get").ToList();
                return output;
            }
        }
        public List<Item> GetItems()
        {
            //Fetch connection string from App.config to form connection
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("VERIS")))
            {
                //Add sql command to query connection- allows us to TAKE data
                var output = connection.Query<Item>("dbo.items_Get").ToList();
                return output;
            }
        }
    }
}
