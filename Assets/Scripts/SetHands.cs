using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Microsoft.MixedReality.Toolkit.UI;
using MagicLeap.MRTK.DeviceManagement.Input;

namespace MagicLeap.MRTK.DeviceManagement.Input
{
    public class SetHands : MonoBehaviour
    {
        void Start()
        {
            GameObject maincam = GameObject.Find("Main Camera");
            GameObject scene = GameObject.Find("SceneContent");
            scene.transform.LookAt(maincam.transform);
            MagicLeapDeviceManager.Instance.CurrentHandSettings = MagicLeapDeviceManager.HandSettings.Both;
        }
    }
}
