using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CamViewer
{
    class FOSCAMController : CameraController, IPanTiltController
    {
        const string MOVE_UP = "0";
        const string STOP_MOVE_UP = "1";

        const string MOVE_DOWN = "2";
        const string STOP_MOVE_DOWN = "3";

        const string MOVE_LEFT = "4";
        const string STOP_MOVE_LEFT = "5";

        const string MOVE_RIGHT = "6";
        const string STOP_MOVE_RIGHT = "7";


        public FOSCAMController(ConnectionConfigData configuration)
            :base(configuration)
        {
        }

        public void MoveUp()
        {
            setCommand("/decoder_control.cgi?command=" + MOVE_UP);
        }

        public void MoveUp(int time)
        {
            MoveUp();
            setDelay(time);
            StopMoveUp();
        }

        public void StopMoveUp()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_UP);
        }

        public void MoveDown()
        {
            setCommand("/decoder_control.cgi?command=" + MOVE_DOWN);
        }

        public void StopMoveDown()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_DOWN);
        }

        public void MoveRight()
        {
            setCommand("/decoder_control.cgi?command=" + MOVE_RIGHT);
        }

        public void StopMoveRight()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_RIGHT);
        }


        public void MoveLeft()
        {
            setCommand("/decoder_control.cgi?command=" + MOVE_LEFT);
        }

        public void StopMoveLeft()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_LEFT);
        }

        public void StopMove()
        {
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_RIGHT);
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_UP);
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_RIGHT);
            setCommand("/decoder_control.cgi?command=" + STOP_MOVE_RIGHT);
        }

        public void MoveHome()
        {
        }


        public void MoveUpLeft()
        {
        }

        public void StopMoveUpLeft()
        {
        }

        public void MoveUpRight()
        {
        }

        public void StopMoveUpRight()
        {
        }

        public void MoveDownLeft()
        {
        }

        public void StopMoveDownLeft()
        {
        }

        public void MoveDownRight()
        {
        }

        public void StopMoveDownRight()
        {
        }

        public void DirectPT(int x, int y)
        {
        }
    }
}
