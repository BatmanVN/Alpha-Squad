/*! \cond PRIVATE */
using System;

// ReSharper disable once CheckNamespace
namespace DarkTonic.MasterAudio {
    [Serializable]
    // ReSharper disable once CheckNamespace
    public class RealTimeParameter {
        // ReSharper disable InconsistentNaming
        public string ParameterName = "YourParameter";
        public float Value = 0f;
        public bool IsExpanded = true;
        public bool IsEditing = false;
        public string ProspectiveName;
        public float MinValue = 0f;
        public float MaxValue = 1000f;
        public bool IsTemporary = false;
        // ReSharper restore InconsistentNaming
    }
}
/*! \endcond */