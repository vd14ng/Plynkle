using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    
    public void Launch(Vector2 aimDirection)
    {
        // create a ball at the gun
        GameObject projectileObject = Instantiate(projectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
        
        // start the ball moving forward
        LaunchProjectile(projectileObject, aimDirection);
    }

    private void LaunchProjectile(GameObject projectileObject, Vector2 aimDirection)
    {
        Rigidbody2D projectileRigidbody = projectileObject.GetComponent<Rigidbody2D>();
        projectileRigidbody.AddForce(aimDirection * 5f, ForceMode2D.Impulse);
        
    }
}
