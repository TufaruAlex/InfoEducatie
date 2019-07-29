using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;

public class disableplane : MonoBehaviour
{
    public ARCoreSession m_ARCoreSession;
    public void DisablePlaneTracker()
    {
        m_ARCoreSession.SessionConfig.PlaneFindingMode = DetectedPlaneFindingMode.Disabled;
    }
}
