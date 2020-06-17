using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVirtualRealityTagAbstract : MonoBehaviour
{

    public VirtualRealityClassicTags m_toFollow;
    public Transform m_affect;
    Transform m_foundToFollow = null;
    public Transform GetTransform(bool useOverride) {

        if (m_foundToFollow == null || useOverride)
        { 
            bool found;
            VirtualRealityTags.GetClassiVrTag(m_toFollow, out found, out m_foundToFollow);
        }

        return m_foundToFollow;
    }
    private void Reset()
    {
        m_affect = transform;
    }
    private void OnValidate()
    {
        m_foundToFollow = null;
    }
}
