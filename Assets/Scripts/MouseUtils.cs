using UnityEngine;
using UnityEngine.InputSystem;

public static class MouseUtils
{
    public static Vector3 GetMouseWorldPosition(Camera camera)
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        MonoBehaviour.print("mouseScreen: " + mouseScreen);
        Vector3 mouseWorld = camera.ScreenToWorldPoint(mouseScreen);
        MonoBehaviour.print("mouseWorld: " + mouseWorld);
        mouseWorld.z = 0f;
        
        return mouseWorld;
    }
}
