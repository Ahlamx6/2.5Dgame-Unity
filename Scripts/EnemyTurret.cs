using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurret : MonoBehaviour
{
   // Where the enemy bullet will spawn
    [SerializeField] private Transform bulletSpawnPoint;

    // The enemy bullet game object
    [SerializeField] private GameObject bullet;

    // The player's transform
    private Transform player;

    // A bool deciding when the player is detected by the enemy turret
    private bool detected = false;

    // ---------- METHODS ----------

    private void Start()
    {
        player = GameObject.Find("player").transform;
    }

    private void Update()
    {
        transform.LookAt(player);

        DetectingPlayer();
    }

    private void DetectingPlayer()
    {

        float playerDistance = Vector3.Distance(player.transform.position, transform.position); 
        if (playerDistance <= 15 && detected == false)
        {
            detected = true;
            InvokeRepeating("Shooting", 0, 1);
        }
        else if (playerDistance > 15)
        {
            detected = false;
            CancelInvoke("Shooting");
        }
    }

    private void Shooting()
    {
        // Spawns the bullet game object at the bullet spawn Transform
        Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    } 
}
