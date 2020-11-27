using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdD.FFMPEG
{
    class FfmpegHandler
    {
        public static void enviarcmd(string cmd)
        {

            ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c " + cmd)
            {
                CreateNoWindow = true
            };

            Process proc = new System.Diagnostics.Process();
            //ocultar cmd
            procStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo = procStartInfo;
            proc.Start();
        }
    }
}
