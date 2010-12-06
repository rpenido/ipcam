using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamViewer
{
    public interface IPanTiltController
    {
        void MoveHome();
        void StopMove();

        void MoveUp();
        void StopMoveUp();

        void MoveDown();        
        void StopMoveDown();



        void MoveRight();
        void StopMoveRight();

        void MoveLeft();
        void StopMoveLeft();

        void MoveUpLeft();
        void StopMoveUpLeft();

        void MoveUpRight();
        void StopMoveUpRight();

        void MoveDownLeft();
        void StopMoveDownLeft();

        void MoveDownRight();
        void StopMoveDownRight();

        void DirectPT(int x, int y);

        void Stop();
    }
}
