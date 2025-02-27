/*! \cond PRIVATE */
using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace DarkTonic.MasterAudio {
    [Serializable]
    // ReSharper disable once CheckNamespace
    public class ParameterCommand {
        // ReSharper disable InconsistentNaming
        public string CommandName = "YourEvent";
        public bool IsExpanded = true;
        public bool IsEditing = false;
        public string ProspectiveName;
        public string ParameterName = MasterAudio.NoGroupName;
        public List<ParameterCommandElement> Elements = new List<ParameterCommandElement>();
        public bool IsTemporary = false;
        public float MinDisplayCurveX = 0f;
        public float MaxDisplayCurveX = 1000f;
        public bool StopCmdOutOfRange = false;
        public float ValidRangeMin = 0f;
        public float ValidRangeMax = 1000f;
        public int NumberOfTimesInvoked = 0;
        // ReSharper restore InconsistentNaming
    }
}
/*! \endcond */