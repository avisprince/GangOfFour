using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.MediaPlayer
{
    public interface IMediaPlayer
    {
        void Play(string audioType, string fileName);
    }
}
