using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{


    public float mousesensivity=100f;

    public Transform playerbody;

    public float maxrotx,minrotx=0f;


    float xrotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")* mousesensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")* mousesensivity * Time.deltaTime ;


        xrotation -= mouseY;

        xrotation = Mathf.Clamp(xrotation, minrotx, maxrotx );
        transform.localRotation = Quaternion.Euler(xrotation, 0, 0);

        playerbody.Rotate(Vector3.up * mouseX);
        


    }




}
