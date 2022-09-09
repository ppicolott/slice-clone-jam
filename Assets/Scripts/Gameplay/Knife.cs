using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.SceneManagement;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;

public class Knife : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rb.AddForce(new Vector3(5f, 15f, 0), ForceMode.Force);
            rb.AddTorque(new Vector3(0, 0, -0.5f), ForceMode.Force);
            audioSource.Play();
        }
        else if (Touch.activeFingers.Count == 1)
        {
            Touch activeTouch = Touch.activeFingers[0].currentTouch;
            if(activeTouch.isTap)
            {
                rb.AddForce(new Vector3(5f, 15f, 0), ForceMode.Force);
                rb.AddTorque(new Vector3(0, 0, -0.5f), ForceMode.Force);
                audioSource.Play();
            }
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name.Equals("GroundBoxLimits"))
        {
            SceneManager.LoadScene("LevelOne");
        }
    }
}
