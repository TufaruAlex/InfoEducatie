using UnityEngine;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class config : MonoBehaviour
{
    void Start()
    {
        if (Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // The user authorized use of the microphone.
        }
        else
        {
            // We do not have permission to use the microphone.
            // Ask for permission or proceed without the functionality enabled.
            Permission.RequestUserPermission(Permission.Camera);
        }
    }
}
