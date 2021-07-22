using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


/// <summary>
/// This script is used to control the starting position of the XRRig
/// </summary>
public class MasterController : MonoBehaviour
{
    static MasterController instance = null;

    public static MasterController Instance => instance;

    public XRRig Rig => xRRig;

    [Header("Setup")]
    public bool DisableSetupForDebug = false;
    public Transform StartingPosition;

    private XRRig xRRig;

    void Awake()
    {
        instance = this;
        xRRig= GetComponent<XRRig>();
    }
    void Start()
    {
        if (!DisableSetupForDebug)
        {
            transform.position = StartingPosition.position;
            transform.rotation = StartingPosition.rotation;

        }
    }

}
