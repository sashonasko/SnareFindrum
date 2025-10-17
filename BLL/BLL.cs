
using DAL;

using WMPLib;
namespace BLL
{


    public class Audio
    {
        public int n;
       
        AdressAu adress = new AdressAu();
      
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
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
       
      
    }

    // More changes
  
}
