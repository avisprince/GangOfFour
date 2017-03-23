using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter mediaAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file: " + fileName);
            }
            else if (audioType == "vlc" || audioType == "mp4")
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
