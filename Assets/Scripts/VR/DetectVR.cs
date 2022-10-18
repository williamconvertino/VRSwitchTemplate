using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Management;

public class DetectVR : MonoBehaviour
{
    [SerializeField] private GameObject vrPlayer;
    [SerializeField] private GameObject desktopPlayer;
    private void Awake()
    {
        var xrSettings = XRGeneralSettings.Instance;
        if (xrSettings == null)
        {
            Debug.Log("Could not find xrSettings");
            return;
        }
        
        var xrManager = xrSettings.Manager;
        if (xrManager == null)
        {
            Debug.Log("Could not find xrManager");
            return;
        }
        
        var xrLoader = xrManager.activeLoader;
        if (xrLoader == null)
        {
            Debug.Log("Could not find xrLoader");
            vrPlayer.SetActive(false);
            desktopPlayer.SetActive(true);
            return;
        }
        Debug.Log("Loading VR");
        vrPlayer.SetActive(true);
        desktopPlayer.SetActive(false);
    }
}
