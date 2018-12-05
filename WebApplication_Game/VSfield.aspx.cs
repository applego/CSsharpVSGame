using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_Game
{
    public partial class VSfield : System.Web.UI.Page
    {
        //Player player1 = new Player("player1",1000,200,50,300);
        //Player player2 = new Player("player2",1000,500,10,40);

        Player player1;
        Player player2;
        const string SESSION_PLAYER1_NAME = "p1";
        const string SESSION_PLAYER2_NAME = "p2";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                player1 = new Player("player1", 1000, 200, 50, 300);
                player2 = new Player("player2", 1000, 500, 10, 40);
                SetSessionPlayer();
                SetHPLabel();
            }
        }

        protected void btn1Red_Click(object sender, EventArgs e)
        {
            GetPlayerbySession();
            lbl1Message.Text =
                player1.Attack(player2);
            SetHPLabel();
            SetStatusMsg(player2);
        }

        protected void btn1Purple_Click(object sender, EventArgs e)
        {
            GetPlayerbySession();
            lbl1Message.Text =
                player1.Recover();
            SetHPLabel();
        }

        protected void btn2Red_Click(object sender, EventArgs e)
        {
            GetPlayerbySession();
            lbl2Message.Text =
                player2.Attack(player1);
            SetHPLabel();
            SetStatusMsg(player1);
        }

        protected void btn2Purple_Click(object sender, EventArgs e)
        {
            GetPlayerbySession();
            lbl2Message.Text =
                player2.Recover();
            SetHPLabel();
        }

        protected void SetSessionPlayer()
        {
            Session[SESSION_PLAYER1_NAME] = player1;
            Session[SESSION_PLAYER2_NAME] = player2;
        }
        protected void GetPlayerbySession()
        {
            player1 = (Player)Session[SESSION_PLAYER1_NAME];
            player2 = (Player)Session[SESSION_PLAYER2_NAME];
        }

        protected void SetHPLabel()
        {
            lbl1HP.Text = player1.HP.ToString();
            lbl2HP.Text = player2.HP.ToString();
        }

        protected void SetStatusMsg(Player p)
        {
            if (p.Name == ((WebApplication_Game.Player)Session[SESSION_PLAYER1_NAME]).Name)
            {
                if (p.IsDead)
                {
                    lbl1Message.Text = p.StatusMessage;
                }
            }
            else if (p.Name == ((WebApplication_Game.Player)Session[SESSION_PLAYER2_NAME]).Name)
            {
                if (p.IsDead)
                {
                    lbl2Message.Text = p.StatusMessage;
                }
            }
        }
    }
}