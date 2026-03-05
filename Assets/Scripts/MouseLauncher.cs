using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MouseLauncher : MonoBehaviour
{
    public Launcher Launcher;
    public Sounds Sounds;
    void Update()
    {
        if (Mouse.current == null)
            return;
        
        if (Game.IsGameNotStarted())
            return;

        if (Ball.isBallInPlay)
            return;
        
        if (Game.IsGameStarted())
        {
            if (Mouse.current.leftButton.wasPressedThisFrame)
            {
                LaunchBall();
            }
        }
    }
    private void LaunchBall()
    {
        Vector2 aimDirection = GetAimDirection();
        Sounds.PlayCannonSound();
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
