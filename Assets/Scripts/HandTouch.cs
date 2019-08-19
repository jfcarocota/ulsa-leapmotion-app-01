using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandTouch : MonoBehaviour
{
    [SerializeField]
    Text message;

    void OnTriggerStay(Collider other)
    {
        message.text = "This is a Cube";
    }

    private void OnTriggerExit(Collider other) {
        message.text = "";
    }
}
