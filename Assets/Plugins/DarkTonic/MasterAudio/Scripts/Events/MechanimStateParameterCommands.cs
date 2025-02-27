using UnityEngine;

/*! \cond PRIVATE */
// ReSharper disable once CheckNamespace
namespace DarkTonic.MasterAudio {
    // ReSharper disable once CheckNamespace
    public class MechanimStateParameterCommands : StateMachineBehaviour {
        [Tooltip("Select for parameter command to re-invoke each time animation loops without exiting state")]
        [Header("Retrigger Parameter Commands Each Time Anim Loops w/o Exiting State")]
        public bool RetriggerWhenStateLoops = false;

#if MULTIPLAYER_ENABLED
        [Header("Select For Parameter Commands To Be Received By All Connected Players")]
        public bool MultiplayerBroadcast = false;
#endif

        [Tooltip("Invoke A Parameter Command When State Is Entered")]
        [Header("Enter Parameter Command")]
        public bool invokeEnterCommand = false;
        [ParameterCommand]
        public string enterParameterCommand = MasterAudio.NoGroupName;

        [Tooltip("Invoke a Parameter Command when state is Exited")]
        [Header("Exit Parameter Command")]
        public bool invokeExitCommand = false;
        [ParameterCommand]
        public string exitParameterCommand = MasterAudio.NoGroupName;

        [Tooltip("Invoke a Parameter Command timed to the animation state's normalized time.  " +
            "Normalized time is simply the length in time of the animation.  " +
            "Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  " +
            "Select a Start time from 0 - 1.")]
        [Header("Invoke Parameter Command Timed to Animation")]
        public bool invokeAnimTimeCommand = false; // Invoke a Parameter Command at a specific time in your animation

        [Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
        [Range(0f, 1f)]
        public float whenToInvokeCommand; //Based upon normalizedTime
        [ParameterCommand]
        public string timedParameterCommand = MasterAudio.NoGroupName;

        [Tooltip("Invoke a Parameter Command with timed to the animation.  This allows you to " +
            "time your Parameter Command to the actions in you animation. Select the number of Parameter Commands to be invoked, up to 4. " +
            "Then set the time you want each Parameter Command to invoke with each subsequent time greater than the previous time.")]

        [Header("Invoke Multiple Parameter Commands Timed to Anim")]
        public bool invokeMultiAnimTimeCommand = false;

        [Range(0, 4)]
        public int numOfMultiCommandsToInvoke;
        [Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
        [Range(0f, 1f)]
        public float whenToInvokeMultiCommand1;           //Based upon normalizedTime
        [Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
        [Range(0f, 1f)]
        public float whenToInvokeMultiCommand2;           //Based upon normalizedTime
        [Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
        [Range(0f, 1f)]
        public float whenToInvokeMultiCommand3;           //Based upon normalizedTime
        [Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
        [Range(0f, 1f)]
        public float whenToInvokeMultiCommand4;           //Based upon normalizedTime
        [ParameterCommand]
        public string MultiTimedCommand = MasterAudio.NoGroupName;

        private bool _playMultiCommand1 = true;
        private bool _playMultiCommand2 = true;
        private bool _playMultiCommand3 = true;
        private bool _playMultiCommand4 = true;
        private bool _invokeTimedCommand = true;
        private Transform _actorTrans;
        private int _lastRepetition = -1;

        // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
            _lastRepetition = 0;

            _actorTrans = ActorTrans(animator);

            if (!invokeEnterCommand) {
                return;
            }

            if (enterParameterCommand == MasterAudio.NoGroupName || string.IsNullOrEmpty(enterParameterCommand)) {
                return;
            }

#if MULTIPLAYER_ENABLED
            if (CanTransmitToOtherPlayers) {
                MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, enterParameterCommand);
            } else {
                MasterAudio.InvokeParameterCommand(enterParameterCommand, _actorTrans);
            }
#else
            MasterAudio.InvokeParameterCommand(enterParameterCommand, _actorTrans);
#endif
        }

        // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
        override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
            var animRepetition = (int)stateInfo.normalizedTime;
            var animTime = stateInfo.normalizedTime - animRepetition;

            if (!invokeAnimTimeCommand) {
                goto multicommand;
            }

#region Timed to Anim
            if (!_invokeTimedCommand && RetriggerWhenStateLoops) {
                // change back to true if "re-trigger" checked and anim has looped.

                if (_lastRepetition >= 0 && animRepetition > _lastRepetition) {
                    _invokeTimedCommand = true;
                }
            }

            if (_invokeTimedCommand) {
                if (animTime > whenToInvokeCommand) {
                    _invokeTimedCommand = false;

#if MULTIPLAYER_ENABLED
                    if (CanTransmitToOtherPlayers) {
                        MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, timedParameterCommand);
                    } else {
                        MasterAudio.InvokeParameterCommand(timedParameterCommand, _actorTrans);
                    }
#else
                    MasterAudio.InvokeParameterCommand(timedParameterCommand, _actorTrans);
#endif
                }
            }

#endregion

            multicommand:

            if (!invokeMultiAnimTimeCommand) {
                goto afterMulti;
            }

#region Invoke Multiple Commands Timed To Anim

            if (RetriggerWhenStateLoops) {
                if (!_playMultiCommand1) {
                    // change back to true if "re-trigger" checked and anim has looped.
                    if (_lastRepetition >= 0 && animRepetition > _lastRepetition) {
                        _playMultiCommand1 = true;
                    }
                }
                if (!_playMultiCommand2) {
                    // change back to true if "re-trigger" checked and anim has looped.
                    if (_lastRepetition >= 0 && animRepetition > _lastRepetition) {
                        _playMultiCommand2 = true;
                    }
                }
                if (!_playMultiCommand3) {
                    // change back to true if "re-trigger" checked and anim has looped.
                    if (_lastRepetition >= 0 && animRepetition > _lastRepetition) {
                        _playMultiCommand3 = true;
                    }
                }
                if (!_playMultiCommand4) {
                    // change back to true if "re-trigger" checked and anim has looped.
                    if (_lastRepetition >= 0 && animRepetition > _lastRepetition) {
                        _playMultiCommand4 = true;
                    }
                }
            }

            if (!_playMultiCommand1) {
                goto decideMulti2;
            }
            if (animTime < whenToInvokeMultiCommand1 || numOfMultiCommandsToInvoke < 1) {
                goto decideMulti2;
            }

            _playMultiCommand1 = false;
#if MULTIPLAYER_ENABLED
            if (CanTransmitToOtherPlayers) {
                MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, MultiTimedCommand);
            } else {
                MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
            }
#else
            MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
#endif

            decideMulti2:

            if (!_playMultiCommand2) {
                goto decideMulti3;
            }

            if (animTime < whenToInvokeMultiCommand2 || numOfMultiCommandsToInvoke < 2) {
                goto decideMulti3;
            }

            _playMultiCommand2 = false;
#if MULTIPLAYER_ENABLED
            if (CanTransmitToOtherPlayers) {
                MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, MultiTimedCommand);
            } else {
                MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
            }
#else
            MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
#endif

            decideMulti3:

            if (!_playMultiCommand3) {
                goto decideMulti4;
            }

            if (animTime < whenToInvokeMultiCommand3 || numOfMultiCommandsToInvoke < 3) {
                goto decideMulti4;
            }

            _playMultiCommand3 = false;
#if MULTIPLAYER_ENABLED
            if (CanTransmitToOtherPlayers) {
                MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, MultiTimedCommand);
            } else {
                MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
            }
#else
            MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
#endif

            decideMulti4:

            if (!_playMultiCommand4) {
                goto afterMulti;
            }

            if (animTime < whenToInvokeMultiCommand4 || numOfMultiCommandsToInvoke < 4) {
                goto afterMulti;
            }

            _playMultiCommand4 = false;
#if MULTIPLAYER_ENABLED
            if (CanTransmitToOtherPlayers) {
                MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, MultiTimedCommand);
            } else {
                MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
            }
#else
            MasterAudio.InvokeParameterCommand(MultiTimedCommand, _actorTrans);
#endif

            #endregion

            afterMulti:

            _lastRepetition = animRepetition;
        }

        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
            if (invokeExitCommand && exitParameterCommand != MasterAudio.NoGroupName && !string.IsNullOrEmpty(exitParameterCommand)) {
#if MULTIPLAYER_ENABLED
                if (CanTransmitToOtherPlayers) {
                    MasterAudioMultiplayerAdapter.InvokeParameterCommand(_actorTrans, exitParameterCommand);
                } else {
                    MasterAudio.InvokeParameterCommand(exitParameterCommand, _actorTrans);
                }
#else
                MasterAudio.InvokeParameterCommand(exitParameterCommand, _actorTrans);
#endif
            }

            if (invokeMultiAnimTimeCommand) {
                _playMultiCommand1 = true;
                _playMultiCommand2 = true;
                _playMultiCommand3 = true;
                _playMultiCommand4 = true;
            }

            if (invokeAnimTimeCommand) {
                _invokeTimedCommand = true;
            }
        }

        // OnStateMove is called right after Animator.OnAnimatorMove(). Code that processes and affects root motion should be implemented here
        //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}

        // OnStateIK is called right after Animator.OnAnimatorIK(). Code that sets up animation IK (inverse kinematics) should be implemented here.
        //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        //
        //}

        private Transform ActorTrans(Animator anim) {
            if (_actorTrans != null) {
                return _actorTrans;
            }

            _actorTrans = anim.transform;

            return _actorTrans;
        }

#if MULTIPLAYER_ENABLED
        private bool CanTransmitToOtherPlayers {
            get { return MultiplayerBroadcast && MasterAudioMultiplayerAdapter.CanSendRPCs; }
        }
#endif
    }
}
/*! \endcond */
