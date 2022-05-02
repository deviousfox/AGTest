using _AGTestLoot;
using UnityEngine;

public class BulletFabric : MonoBehaviour
{
   [SerializeField] private Bullet[] availableBullets;
   
   //An extremely stupid idea to implement shooting with the help of a factory,
   //BUT maybe later you will want to add different jokes with bullets, so like this
   public Bullet GetBulletByType(CubeColor colorType, Vector3 spawnPosition)
   {
      //Casting an enum to an array to take an item from it is an extremely shitty idea,
      //but nothing better came to mind
      return Instantiate(availableBullets[(int)colorType], spawnPosition, Quaternion.identity);
   }
}
