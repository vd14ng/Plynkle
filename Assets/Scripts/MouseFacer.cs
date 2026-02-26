using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class MousePhaser : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // what angle do we need to rotate foward?
        float angle = getAngle();

        angle = ConstrainAngle(angle);
        // rotate the sprite to that angle
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
    
    private float getAngle()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        float angle = CalculatingAngle(mouseWorld);
        
        return angle;
    }

    private float CalculatingAngle(Vector3 targetPosition)
    {
        Vector2 direction = (targetPosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        angle = angle + 90f;
        
        return angle;
    }

    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }

}
