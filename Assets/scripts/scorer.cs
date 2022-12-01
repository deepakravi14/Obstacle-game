using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
   void start(){
      Debug.Log("Finish the game with minimum collision point to win the game");
   }
   int hits=0;

   private void OnCollisionEnter(Collision other)
   {
    if (other.gameObject.tag != "Hit" && other.gameObject.tag != "start")
    {
      hits++;
      Debug.Log("You have collided with a object " + hits +"times");
   }
   }
}
