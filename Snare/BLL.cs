
using DAL;
using Snare;
using System.Reflection.Metadata.Ecma335;
using WMPLib;
namespace BLL
{


    public class Audio
    {
        public int n;
       
        AdressAu adress = new AdressAu();
      
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        public void PlayingSnare()
        {
           
            player.URL = adress.AudioAdress[n];
            player.controls.play();
         

        }
        public void StopAudio()
        {

            player.controls.stop();


        }
        public void EraseAudio() {
         
            player.URL = "";


        }
        PicAdress pic = new PicAdress();
        public string pictures() {

            return pic.SNPicture[n];
        
        }


    }
    public class LabelsInfo {
        Labels jj = new Labels();
        public string JJLabelTitle() {


            return jj.LabelJJ[0];
           

        }
        public string JJLabelDescription()
        {

            return jj.LabelJJ[1];

        }
        public string ExplorerLabelTitle()
        {

            return jj.Labelexplorer[0];

        }
        public string ExplorerLabelDescription()
        {

            return jj.Labelexplorer[1];

        }



    }
   



}
