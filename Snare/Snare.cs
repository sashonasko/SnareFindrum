
using BLL;
using System.Windows.Forms;
namespace Snare
{
    public partial class Snare : Form
    {
        Audio audio = new Audio();
        LabelsInfo Textss = new LabelsInfo();
        public Snare()
        {
            InitializeComponent();
        }

        private void Snare_Load(object sender, EventArgs e)
        {
            SnareName.Text = null;
            SnareDesc.Text = null;
            SnareSelect.Visible = true;
            SearchButton.Visible = true;
            SnareDesc.Visible = false;
            SnareName.Visible = false;
            PlayButton.Visible = false;
            StopButton.Visible = false;
            SnarePic.Visible = false;


        }
        private void BackButton_Click(object sender, EventArgs e)
        {

            if (SnarePic.Image != null)
            {
                SnarePic.Image.Dispose();
                SnarePic.Image = null;
            }
            audio.EraseAudio();
            SnareName.Text = null;
            SnareDesc.Text = null;
            SnareSelect.Visible = true;
            SearchButton.Visible = true;
            SnareDesc.Visible = false;
            SnareName.Visible = false;
            PlayButton.Visible = false;
            StopButton.Visible = false;
            SnarePic.Visible = false;
        }

        public void SearchButton_Click(object sender, EventArgs e)
        {

            string SlectedSnare = SnareSelect.SelectedItem.ToString();
            SnareSelect.Visible = false;
            SearchButton.Visible = false;
            if (SlectedSnare == null)
            {


                Console.WriteLine("");


            }


            switch (SlectedSnare)
            {

                case "Pearl Export snare 14":
                    audio.n = 0;


                    SnarePic.Image = Image.FromFile(audio.pictures());
                    SnareName.Text = Textss.ExplorerLabelTitle();
                    SnareDesc.Text = Textss.ExplorerLabelDescription();

                    break;
                case "Joey Jordison Signature Snare":
                    audio.n = 1;


                    SnarePic.Image = Image.FromFile(audio.pictures());
                    SnareName.Text = Textss.JJLabelTitle();
                    SnareDesc.Text = Textss.JJLabelDescription();
                    break;
                default:
                    Console.WriteLine("");

                    break;
            }

            SnarePic.Visible = true;
            SnareDesc.Visible = true;
            SnareName.Visible = true;
            PlayButton.Visible = true;
            StopButton.Visible = true;
        }

        public void SnareSelect_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            audio.PlayingSnare();

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            audio.StopAudio();
        }

       
    }
}
