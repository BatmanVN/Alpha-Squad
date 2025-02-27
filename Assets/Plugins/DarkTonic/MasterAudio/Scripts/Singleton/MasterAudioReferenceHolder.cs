/*! \cond PRIVATE */
using DarkTonic.MasterAudio;
using UnityEngine;

public static class MasterAudioReferenceHolder
{
    public static MasterAudio MasterAudio;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
    public static void ThisMethodWillBeCalledOnceAtTheStartOfTheProgram()
    {
        MasterAudio = null;
    }
}
/*! \endcond */