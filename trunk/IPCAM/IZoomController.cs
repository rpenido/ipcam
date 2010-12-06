using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamView
{
    interface IZoomController
    {
        void ZoomTele();

        void ZoomWide();

        void ZoomStop();

        void ZoomWideRelative(string percent);
        void ZoomTeleRelative(string percent);
    }
}
