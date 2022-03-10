using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ChicknTrigger : MonoBehaviour
{
    float speed = 5.0f;
    // Start is called before the first frame update

    private InputDevice targetDevice;

    void Start()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

       if(devices.Count > 0)
        {
            targetDevice = devices[0];
        }

        

    }

    // Update is called once per frame
    void Update()
    {
       targetDevice.TryGetFeatureValue(CommonUsages.primaryButton,out bool primaryButtonValue);
        if (primaryButtonValue)
        {
            Debug.Log("pressing primary button");
        }
        targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if(triggerValue > 0.1f)
        {
            Debug.Log("Trigger pressed " + triggerValue);
            

        }
    }

    void OnTriggerStay(Collider other)
    {
        targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue);
        if (other.gameObject.tag =="VAC" && primaryButtonValue)
        {
            print("okay.");

            transform.LookAt(GameObject.Find("Main Camera").transform);

            transform.position += transform.forward * speed * Time.deltaTime;

        }
    }
}
