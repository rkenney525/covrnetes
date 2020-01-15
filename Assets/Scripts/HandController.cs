using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.XR;

public class HandController : MonoBehaviour {

    [Header("Hand Settings")]
    [Tooltip("Which hand this script controls, left or right")]
    public InputDeviceRole inputDeviceRole;

    [Tooltip("Which hand this script controls, left or right")]
    public XRNode xrNode;

    private InputDevice input;

    // Start is called before the first frame update
    void Start() {
        List<InputDevice> inputDevices = new List<InputDevice>();
        InputDevices.GetDevicesWithRole(inputDeviceRole, inputDevices);

        // TODO if the device doesnt exist yet, wait or display something

        input = inputDevices.First();
    }

    // Update is called once per frame
    void Update() {
        // Get the node
        List<XRNodeState> states = new List<XRNodeState>();
        InputTracking.GetNodeStates(states);

        // Grab the position and rotation
        Vector3 position = Vector3.zero;
        Quaternion rotation = Quaternion.identity;
        XRNodeState nodeState = states.Where(state => state.nodeType == xrNode).First();
        nodeState.TryGetPosition(out position);
        nodeState.TryGetRotation(out rotation);

        // Set the transform's position and rotation
        transform.localPosition = position;
        transform.localRotation = rotation;
    }
}
