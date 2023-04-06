using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{

    public Component keyForDoor;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.transform.gameObject);
            keyForDoor.GetComponent<BoxCollider>().enabled = true;
            Debug.Log("Key Collected");
        }
    }

}
