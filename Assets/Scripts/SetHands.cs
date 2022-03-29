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
            MagicLeapDeviceManager.Instance.CurrentHandSettings = MagicLeapDeviceManager.HandSettings.Both;
        }
    }
}
