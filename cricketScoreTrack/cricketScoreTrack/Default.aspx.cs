using cricketScoreTrack.BaseClasses;
using cricketScoreTrack.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cricketScoreTrack
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Player> southAfrica = Get_SA_Players();
            List<Player> india = Get_India_Players();
        }

        private List<Player> Get_SA_Players()
        {
            List<Player> players = new List<Player>();

            Batsman b1 = new Batsman();
            b1.FirstName = "Name 1";
            b1.LastName = "Surname 1";
            b1.Age = 25;
            players.Add(b1);

            Batsman b2 = new Batsman();
            b2.FirstName = "Name 2";
            b2.LastName = "Surname 2";
            b2.Age = 27;
            players.Add(b2);

            Batsman b3 = new Batsman();
            b3.FirstName = "Name 3";
            b3.LastName = "Surname 3";
            b3.Age = 22;
            players.Add(b3);

            AllRounder ar1 = new AllRounder();
            ar1.FirstName = "Name 1";
            ar1.LastName = "Surname 1";
            ar1.Age = 27;
            players.Add(ar1);

            return players;
        }

        private List<Player> Get_India_Players()
        {
            List<Player> players = new List<Player>();

            Batsman b1 = new Batsman();
            b1.FirstName = "Name 1";
            b1.LastName = "Surname 1";
            b1.Age = 25;
            players.Add(b1);

            Batsman b2 = new Batsman();
            b2.FirstName = "Name 2";
            b2.LastName = "Surname 2";
            b2.Age = 27;
            players.Add(b2);

            Batsman b3 = new Batsman();
            b3.FirstName = "Name 3";
            b3.LastName = "Surname 3";
            b3.Age = 22;
            players.Add(b3);

            AllRounder ar1 = new AllRounder();
            ar1.FirstName = "Name 1";
            ar1.LastName = "Surname 1";
            ar1.Age = 27;
            players.Add(ar1);

            return players;
        }

        #region Player Buttons
        protected void btnBatsman1_Click(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
        }

        protected void btnBatsman2_Click(object sender, EventArgs e)
        {

        }

        protected void btnBowler_Click(object sender, EventArgs e)
        {

        } 
        #endregion

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
    }
}