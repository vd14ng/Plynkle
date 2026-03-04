using UnityEngine;

public static class DirectionUtils
{
    public static Vector2 GetAimDirection(Vector3 targetPosition, Vector3 fromPosition)
    {
        return (targetPosition - fromPosition).normalized;
    }

    public static float GetAngle(Vector3 targetPosition, Vector3 fromPosition, 
        bool faceUpInsteadOfRight = true)
    {
        Vector2 direction = (targetPosition - fromPosition).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (faceUpInsteadOfRight)
            angle += 90f;

        return angle;
    }
}
