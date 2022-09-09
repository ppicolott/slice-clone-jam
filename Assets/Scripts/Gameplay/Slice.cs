using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slice : MonoBehaviour
{
    public AudioSource sliceAudio;
    private BoxCollider leftBox;
    private Rigidbody leftRB;
    private BoxCollider rightBox;
    private Rigidbody rightRB;

    private void Start()
    {
        leftBox = gameObject.transform.Find("Left").GetComponent<BoxCollider>();
        leftRB = gameObject.transform.Find("Left").GetComponent<Rigidbody>();
        rightBox = gameObject.transform.Find("Right").GetComponent<BoxCollider>();
        rightRB = gameObject.transform.Find("Right").GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name.Contains("Tip"))
        {
            sliceAudio.Play();

            leftBox.enabled = true;
            leftRB.isKinematic = false;
            leftRB.AddTorque(-Vector3.right * 10f, ForceMode.Impulse);

            rightBox.enabled = true;
            rightRB.isKinematic = false;
            rightRB.AddTorque(Vector3.right * 10f, ForceMode.Impulse);

            Destroy(gameObject, 1.5f);
        }
    }
}
