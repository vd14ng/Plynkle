using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class MouseFacer : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        float angle = GetAngle();
        // print("Angle: " + angle);
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }

    private float ConstrainAngle (float angle)
    {
        if (angle > 75f)
            angle = 75f;
        if (angle < -75f)
            angle = -75f;
        
        return angle;
    }

    private float GetAngle()
    {
        Vector3 mouseWorldPosition = MouseUtils.GetMouseWorldPosition(Camera.main);
        float angle = DirectionUtils.GetAngle(mouseWorldPosition, transform.position);
        angle = ConstrainAngle(angle);
        return angle;
    }
    
} 
