using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GlobalHealth Health;// this is to keep track of playerHealth, only spawn enemies when health > 0
    public GameObject enemy; // reference to the game object that will be our enemies
    public float spawnTime = 5f; // time between each spawn
    public Transform[] spawnPoints; // an array/list of transforms for spawn points
    // spawnpoints array isn't used in the tutorial, placed there for when you want to expand

    void Start ()
    {//when the game starts this function is invoked, what it does is allow you to not need a timer effectively for something that's going to repeat
        InvokeRepeating ("Spawn", spawnTime, spawnTime);
     //we call the spawn function^ named as a string, with an amount of time to wait before doing it, and wait before repeating it
    }


    void Spawn ()
    {
		if(Health.internalHealth < 0)
        {
            return;
        }
        //when you create an array an integer is used to point to a spot in the array
        int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        ///if the player is still alive we'll instantiate the enemy
        Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        //Three properties, the thing to spawn, the place to spawn it, and what rotation it should have when its created
    }//spawnPoints[spawnPointIndex] is a transform and every transform has a position and a rotation
}
