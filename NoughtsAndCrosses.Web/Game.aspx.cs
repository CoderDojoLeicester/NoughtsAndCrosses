using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NoughtsAndCrosses.Web
{
    public partial class Game : System.Web.UI.Page
    {
        NoughtsAndCrosses.Game game { get { return (NoughtsAndCrosses.Game)Session["Game"]; } }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Session["Game"] = new NoughtsAndCrosses.Game();

            UpdateCurrentPlayer();
        }

        private void UpdateCurrentPlayer()
        {
            LabelOut.Text = string.Format("{0}'s turn", game.CurrentPlayer);
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int row=-1;
            int col=-1;
            switch(button.ID)
            {
                case "Button1":
                    row = 0;
                    col = 0;
                    break;
                case "Button2":
                    row = 0;
                    col = 1;
                    break;
                case "Button3":
                    row = 0;
                    col = 2;
                    break;
                case "Button4":
                    row = 1;
                    col = 0;
                    break;
                case "Button5":
                    row = 1;
                    col = 1;
                    break;
                case "Button6":
                    row = 1;
                    col = 2;
                    break;
                case "Button7":
                    row = 0;
                    col = 0;
                    break;
                case "Button8":
                    row = 2;
                    col = 1;
                    break;
                case "Button9":
                    row = 2;
                    col = 2;
                    break;
            }
            button.Text = game.CurrentPlayer.ToString();
            button.Enabled = false;
            game.Move(game.CurrentPlayer, row, col);
            switch(game.Winner)
            {
                case NoughtsAndCrosses.Game.CellContent.X:
                case NoughtsAndCrosses.Game.CellContent.O:
                    LabelOut.Text = String.Format("Winner: {0}", game.Winner);
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    Button8.Enabled = false;
                    Button9.Enabled = false;
                    break;
                default:
                    UpdateCurrentPlayer();
                    break;
            }
        }
    }
}