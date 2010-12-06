using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CamViewer
{
    class SonyController : CameraController
    {
        const string MOVE_UP = "8101060101010302FF";
        const string MOVE_DOWN = "8101060101010301FF";
        const string MOVE_LEFT = "8101060101010203FF";
        const string MOVE_RIGHT = "8101060101010103FF";

        const string MOVE_UPLEFT = "8101060101010202FF";
        const string MOVE_UPRIGHT = "8101060101010102FF";
        const string MOVE_DOWNLEFT = "8101060101010201FF";
        const string MOVE_DOWNRIGHT = "8101060101010101FF";

        const string MOVE_STOP = "8101060101010303FF";

        const string TELE = "8101040725FF";
        const string WIDE = "8101040735FF";
        const string ZOOM_STOP = "8101040700FF";
        const string HOME = "81010604FF";
        const string Auto_pan = "8101062402FF";
        const string Preset = "8101043F010";
        const string Recall = "8101043F020"; 
        
        public SonyController(ConnectionConfigData configuration)
            :base(configuration)
        {
        }
            
        public void MoveUp()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_UP);
        }
        public override void Auto_Span()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + Auto_pan);
        } 

        public void StopMove()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_STOP);
        }

        public void MoveDown()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_DOWN);
        }
        public void MoveHome()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + HOME);
        }

        public void MoveDown(int time)
        {
            MoveDown();
            setDelay(time);
            StopMove();
        }


        public void MoveRight()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_RIGHT);
        }


        public void MoveLeft()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_LEFT);
        }
        
        public void MoveUpLeft()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_UPLEFT);
        }

        public void MoveUpRight()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_UPRIGHT);
        }

        public void MoveDownLeft()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_DOWNLEFT);
        }

        public void MoveDownRight()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + MOVE_DOWNRIGHT);
        }
        public void ZoomTele()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + TELE);
        }

        public void ZoomWide()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + WIDE);
        }
        public void ZoomStop ()
        {
            setCommand("/command/visca-ptzf.cgi?visca=" + ZOOM_STOP);
        }

        public void DirectPT(int x, int y)
        {
            setCommand("/command/ptzf.cgi?directPT=" + x.ToString()+","+y.ToString());
        }
         public void ZoomWideRelative (string percent)
        {
            setCommand("/command/ptzf.cgi?relative=10" + percent);
        }
         public void ZoomTeleRelative(string percent)
         {
             setCommand("/command/ptzf.cgi?relative=11" + percent);
         }
         public void CamPreset(string position)
         {
             setCommand("/command/visca-ptzf.cgi?visca="+Preset+position+"FF");
         }
         public void CamRecall(string position)
         {
             setCommand("/command/visca-ptzf.cgi?visca=" + Recall + position + "FF");
         }


    }
}
