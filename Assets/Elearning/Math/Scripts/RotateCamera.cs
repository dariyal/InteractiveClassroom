using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public Transform camObj;
    public Transform target;
    public float distance = 1.0f;
    public float xSpeed = 120.0f;
    public float ySpeed = 120.0f;

    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

   // public float distanceMin = .5f;
  //  public float distanceMax = 15f;

    private Rigidbody rigidbody;

    float x = 0.0f;
    float y = 0.0f;

    Vector3 checking;
    // Use this for initialization
    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        rigidbody = GetComponent<Rigidbody>();

        // Make the rigid body not change rotation
        if (rigidbody != null)
        {
            rigidbody.freezeRotation = true;
        }
        checking = camObj.localPosition;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(0))
        {

            float angle = transform.eulerAngles.y;
            Debug.Log(angle);
            if (angle < 45 || angle > 315)
            {
                Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
                transform.RotateAround(pos, Vector3.up, Time.deltaTime * ySpeed);
            }

        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
