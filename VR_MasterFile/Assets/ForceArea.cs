using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceArea : MonoBehaviour
{
    public List<GameObject> BlownObjects = new List<GameObject>();
    public Vector3 ForceVector = new Vector3();

    private void OnTriggerEnter(Collider other)
    {
        BlownObjects.Add(other.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        BlownObjects.Remove(other.gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(int i=0; i<BlownObjects.Count; i++)
        {
            BlownObjects[i].gameObject.GetComponent<Rigidbody>().AddForce(ForceVector);
        }
    }
}
