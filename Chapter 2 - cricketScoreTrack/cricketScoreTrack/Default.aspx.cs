using cricketScoreTrack.BaseClasses;
using cricketScoreTrack.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace cricketScoreTrack
{
    public partial class _Default : Page
    {
        public enum SelectedPlayer { Batsman1 = 1, Batsman2 = 2, Bowler = 3 }
        List<Player> southAfrica;
        List<Player> india;

        protected void Page_Load(object sender, EventArgs e)
        {
            southAfrica = Get_SA_Players();
            india = Get_India_Players();
        }

        private List<Player> Get_SA_Players()
        {
            List<Player> players = new List<Player>();

            #region Batsmen
            Batsman b1 = new Batsman();
            b1.FirstName = "Faf";
            b1.LastName = "du Plessis";
            b1.Age = 33;
            players.Add(b1);

            Batsman b2 = new Batsman();
            b2.FirstName = "Temba";
            b2.LastName = "Bavuma";
            b2.Age = 27;
            players.Add(b2);

            Batsman b3 = new Batsman();
            b3.FirstName = "Stephen";
            b3.LastName = "Cook";
            b3.Age = 34;
            players.Add(b3);


            Batsman b4 = new Batsman();
            b4.FirstName = "Theunis";
            b4.LastName = "de Bruyn";
            b4.Age = 24;
            players.Add(b4);

            Batsman b5 = new Batsman();
            b5.FirstName = "Dean";
            b5.LastName = "Elgar";
            b5.Age = 30;
            players.Add(b5);

            Batsman b6 = new Batsman();
            b6.FirstName = "Reeza";
            b6.LastName = "Hendricks";
            b6.Age = 27;
            players.Add(b6);
            #endregion

            #region All Rounders
            AllRounder ar1 = new AllRounder();
            ar1.FirstName = "Farhaan";
            ar1.LastName = "Behardien";
            ar1.Age = 33;
            players.Add(ar1);

            AllRounder ar2 = new AllRounder();
            ar2.FirstName = "JP";
            ar2.LastName = "Duminy";
            ar2.Age = 33;
            players.Add(ar2);

            AllRounder ar3 = new AllRounder();
            ar3.FirstName = "Chris";
            ar3.LastName = "Morris";
            ar3.Age = 30;
            players.Add(ar3);

            AllRounder ar4 = new AllRounder();
            ar4.FirstName = "Dwaine";
            ar4.LastName = "Pretorius";
            ar4.Age = 28;
            players.Add(ar4);

            AllRounder ar5 = new AllRounder();
            ar5.FirstName = "JJ";
            ar5.LastName = "Smuts";
            ar5.Age = 28;
            players.Add(ar5);
            #endregion

            return players;
        }

        private List<Player> Get_India_Players()
        {
            List<Player> players = new List<Player>();

            #region Batsmen
            Batsman b1 = new Batsman();
            b1.FirstName = "Shikhar";
            b1.LastName = "Dhawan";
            b1.Age = 31;
            players.Add(b1);

            Batsman b2 = new Batsman();
            b2.FirstName = "Gautam";
            b2.LastName = "Gambhir";
            b2.Age = 35;
            players.Add(b2);

            Batsman b3 = new Batsman();
            b3.FirstName = "Abhinav";
            b3.LastName = "Mukund";
            b3.Age = 27;
            players.Add(b3);

            Batsman b4 = new Batsman();
            b4.FirstName = "K. L.";
            b4.LastName = "Rahul";
            b4.Age = 25;
            players.Add(b4);

            Batsman b5 = new Batsman();
            b5.FirstName = "Murali";
            b5.LastName = "Vijay";
            b5.Age = 33;
            players.Add(b5);
            #endregion

            #region All Rounders
            AllRounder ar1 = new AllRounder();
            ar1.FirstName = "Ravichandran";
            ar1.LastName = "Ashwin";
            ar1.Age = 30;
            players.Add(ar1);

            AllRounder ar2 = new AllRounder();
            ar2.FirstName = "Stuart";
            ar2.LastName = "Binny";
            ar2.Age = 33;
            players.Add(ar2);

            AllRounder ar3 = new AllRounder();
            ar3.FirstName = "Ravindra";
            ar3.LastName = "Jadeja";
            ar3.Age = 28;
            players.Add(ar3);

            AllRounder ar4 = new AllRounder();
            ar4.FirstName = "Hardik";
            ar4.LastName = "Pandya";
            ar4.Age = 23;
            players.Add(ar4);

            AllRounder ar5 = new AllRounder();
            ar5.FirstName = "Axar";
            ar5.LastName = "Patel";
            ar5.Age = 23;
            players.Add(ar5);

            AllRounder ar6 = new AllRounder();
            ar6.FirstName = "Parvez";
            ar6.LastName = "Rasool";
            ar6.Age = 28;
            players.Add(ar6);
            #endregion

            return players;
        }

        #region Player Buttons
        protected void btnBatsman1_Click(object sender, EventArgs e)
        {
            BatsmanSelection(SelectedPlayer.Batsman1);
        }

        protected void btnBatsman2_Click(object sender, EventArgs e)
        {
            BatsmanSelection(SelectedPlayer.Batsman2);
        }

        protected void BatsmanSelection(SelectedPlayer selectedPlayer)
        {
            btnSelectPlayer1.CommandArgument = Enum.GetName(typeof(SelectedPlayer), (int)selectedPlayer);
            GeneratePlayerList(southAfrica, typeof(Batsman));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void btnBowler_Click(object sender, EventArgs e)
        {
            btnSelectPlayer1.CommandArgument = nameof(SelectedPlayer.Bowler);
            GeneratePlayerList(india, typeof(AllRounder));
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }
        #endregion


        private void GeneratePlayerList(List<Player> team, Type type)
        {
            List<string> players = new List<string>();

            if (type == typeof(Batsman))
                players = (from r in team.OfType<Batsman>()
                           select $"{r.FirstName} {r.LastName}").ToList();

            if (type == typeof(AllRounder))
                players = (from r in team.OfType<AllRounder>()
                           select $"{r.FirstName} {r.LastName}").ToList();

            int liVal = 0;
            if (ddlPlayersSelect.Items.Count > 0)
                ddlPlayersSelect.Items.Clear();

            foreach (string player in players)
            {
                ListItem li = new ListItem();
                li.Text = player.ToString();
                li.Value = liVal.ToString();
                ddlPlayersSelect.Items.Add(li);

                liVal += 1;
            }
        }


        #region Runs Scored Buttons
        protected void btnRun_0_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_1_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_2_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_3_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_4_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_5plus_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_6_Click(object sender, EventArgs e)
        {

        }

        protected void btnRun_Undo_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Action Buttons
        protected void btnAction_Wide_Click(object sender, EventArgs e)
        {

        }

        protected void btnAction_NoBall_Click(object sender, EventArgs e)
        {

        }

        protected void btnAction_Bye_Click(object sender, EventArgs e)
        {

        }

        protected void btnAction_LegBye_Click(object sender, EventArgs e)
        {

        }

        protected void btnAction_Wicket_Click(object sender, EventArgs e)
        {

        }

        protected void btnAction_EndOver_Click(object sender, EventArgs e)
        {

        }
        #endregion

        protected void btnSelectPlayer1_Click(object sender, EventArgs e)
        {
            string commandArgument = btnSelectPlayer1.CommandArgument;

            switch (commandArgument)
            {
                case nameof(SelectedPlayer.Batsman1):
                    btnBatsman1.Text = ddlPlayersSelect.SelectedItem.ToString();
                    break;
                case nameof(SelectedPlayer.Batsman2):
                    btnBatsman2.Text = ddlPlayersSelect.SelectedItem.ToString();
                    break;
                case nameof(SelectedPlayer.Bowler):
                    btnBowler.Text = ddlPlayersSelect.SelectedItem.ToString();
                    break;
            }
        }

        protected void ddlPlayersSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}