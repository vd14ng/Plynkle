using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MouseLauncher : MonoBehaviour
{
    public Launcher Launcher;
    void Update()
    {
        if (Mouse.current == null)
            return;
        
        if (Game.IsGameNotStarted())
            return;
        
        if (Game.IsGameNotStarted())
        {
            // if the mouse is clicked
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                LaunchBall();
            }
        }
    }

    private void LaunchBall()
    {
        // figure out the direction to aim
        Vector2 aimDirection = GetAimDirection();

        // launch in that direction
        Launcher.Launch(aimDirection);
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        return (mouseWorld - transform.position).normalized;
    }
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0f;
        return mouseWorld;
    }
    
}
