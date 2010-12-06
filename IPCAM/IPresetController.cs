using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamView
{
    interface IPresetController
    {
        void CamPreset(string position);
        void CamRecall(string position);

    }
}
