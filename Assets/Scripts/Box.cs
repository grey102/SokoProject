using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private void Update()
    {
       GameObject[] bombs = GameObject.FindGameObjectsWithTag("Bomb");
       foreach (var bomb in bombs)
       {
          if (transform.position.x == bomb.transform.position.x && transform.position.y == bomb.transform.position.y)
              {
                 GetComponent<SpriteRenderer>().color = Color.red;
                 return;
              }
          else
              {
                GetComponent<SpriteRenderer>().color = Color.white;
              }
        }
    }


}
