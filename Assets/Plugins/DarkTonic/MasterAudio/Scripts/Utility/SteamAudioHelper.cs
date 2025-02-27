/*! \cond PRIVATE */
using UnityEngine;

namespace DarkTonic.MasterAudio
{
    public static class SteamAudioHelper
    {
        public static bool SteamAudioOptionExists {
            get {
                return true;
            }
        }

        public static bool DarkTonicSteamAudioPackageInstalled()
        {
            return true;
        }

        public static void AddSteamAudioSourceToVariation(SoundGroupVariation variation)
        {
            return;
        }

        public static void AddSteamAudioSourceToAllVariations()
        {
            return;
        }

        public static void RemoveSteamAudioSourceFromAllVariations()
        {
            return;
        }

        public static void CopySteamAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
        {
            return;
        }

        public static void CopySteamAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
        {
            return;
        }

        public static void CopySteamAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
        {
            return;
        }
    }
}
/*! \endcond */