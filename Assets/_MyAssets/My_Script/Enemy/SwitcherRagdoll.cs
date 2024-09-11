using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherRagdoll : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rig;
    [SerializeField] private Animator anim;

    [ContextMenu("Retrive Rigbody")]
    private void RetriveRigbody()
    {
        rig = GetComponentsInChildren<Rigidbody>();
    }
    [ContextMenu("Clear Ragdoll")]
    private void ClearRagdoll()
    {
        var characterJoint = GetComponentsInChildren<CharacterJoint>();
        for (int i= characterJoint.Length - 1; i >= 0; i--)
        {
            DestroyImmediate(characterJoint[i]);
        }
        var rigidList = GetComponentsInChildren<Rigidbody>();
        for (int i = rigidList.Length - 1; i >= 0; i--)
        {
            DestroyImmediate(rigidList[i]);
        }
        var colliders = GetComponentsInChildren<Collider>();
        for (int i = colliders.Length - 1; i >= 0; i--)
        {
            DestroyImmediate(colliders[i]);
        }
    }

    [ContextMenu("Enable Ragdoll")]
    public void EnableRagdoll() => SetRagdoll(true);

    [ContextMenu("Disable Ragdoll")]
    public void DisableRagdoll() => SetRagdoll(false);

    private void SetRagdoll(bool ragdollEnable)
    {
        anim.enabled = !ragdollEnable;
        for (int i = 0; i < rig.Length; i++)
        {
            rig[i].isKinematic = !ragdollEnable;
        }
    }
    private void Start()
    {
        
    }
}
