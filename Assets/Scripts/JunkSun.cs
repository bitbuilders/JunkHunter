using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSun : MonoBehaviour
{
    Material m_skyMat = null;

    void Start()
    {
        m_skyMat = RenderSettings.skybox;
    }

    void Update()
    {
        m_skyMat.SetVector("_LightForward", transform.forward);
    }
}
