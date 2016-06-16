using System;
using UnityEngine;

namespace EmptyStages
{
    [KSPAddon (KSPAddon.Startup.EditorAny, true)]
    public class EmptystageManager : MonoBehaviour
    {
        public void Start()
        {
            KSP.UI.Screens.StageManager.EnableDeleteEmptyStages = false;
        }
    }
}

