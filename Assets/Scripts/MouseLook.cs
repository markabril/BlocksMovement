using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = .5f;
    public Transform PlayerBody;
    public Transform weaponBody;


    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        //float mouseX = Input.GetAxis("Mouse X") * mouseAdjustedSensitivity * Time.deltaTime;
        //float mouseY = Input.GetAxis("Mouse Y") * mouseAdjustedSensitivity * Time.deltaTime;
        //float mouseX = 0;
        //float mouseY = 0;
        //if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        //{
        //    if (EventSystem.current.IsPointerOverGameObject())
        //        return;
        //    mouseX = Input.GetTouch(0).deltaPosition.x * mouseSensitivity;
        //    mouseY = Input.GetTouch(0).deltaPosition.y * mouseSensitivity;
        //}
        //xRotation -= mouseY * Time.deltaTime;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        //transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //PlayerBody.Rotate(Vector3.up * mouseX * Time.deltaTime);
        //weaponBody.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

    }
}
