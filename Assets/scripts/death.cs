using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "enemyBullet")
        {
            if (gameObject.tag == "Player")
                Destroy(gameObject);
            Time.timeScale = 0;
        }
    }
}
