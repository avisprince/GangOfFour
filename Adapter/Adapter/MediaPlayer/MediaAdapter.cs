using Adapter.AdvancedMediaPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer
{
    public class MediaAdapter : IMediaPlayer
    {
        private IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType == "vlc")
            {
                advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType == "mp4")
            {
                advancedMediaPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (audioType == "vlc")
            {
                advancedMediaPlayer.PlayVlc(fileName);
            }
            else if (audioType == "mp4")
            {
                advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}
