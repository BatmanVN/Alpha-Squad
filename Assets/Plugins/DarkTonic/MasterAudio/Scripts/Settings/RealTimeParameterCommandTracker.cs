/*! \cond PRIVATE */
using System;
using System.Collections.Generic;
using UnityEngine;

namespace DarkTonic.MasterAudio {
    [Serializable]
    public class RealTimeParameterCommandTracker {
        public bool IsActive = false;
        public ParameterCommand ParameterCommand;
        public Transform Actor;
        public List<PlaySoundResult> ElementResults = new List<PlaySoundResult>(2);
        public Guid InstanceId = Guid.Empty;
        public float? TimeInvoked = null;

        public void Reset(bool stopElements = false) {
            if (stopElements) {
                for (int i = 0; i < ElementResults.Count; i++) {
                    var element = ElementResults[i];
                    if (element == null) {
                        continue;
                    }

                    var actingVariation = element.ActingVariation;
                    if (actingVariation == null) {
                        continue;
                    }

                    actingVariation.Stop();
                }
            }

            IsActive = false;
            ParameterCommand = null;
            Actor = null;
            ElementResults.Clear();
            InstanceId = Guid.Empty;
            TimeInvoked = null;
        }

        public Guid ActivateAndGetInstanceId(ParameterCommand cmd, Transform originObject) {
            IsActive = true;
            ParameterCommand = cmd;
            Actor = originObject;
            InstanceId = Guid.NewGuid();
            TimeInvoked = Time.realtimeSinceStartup;
            cmd.NumberOfTimesInvoked++;
            return InstanceId;
        }
    }
}
/*! \endcond */