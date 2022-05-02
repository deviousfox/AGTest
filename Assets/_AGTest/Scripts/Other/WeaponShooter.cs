using _AGTestLoot;
using UnityEngine;

public class WeaponShooter : MonoBehaviour
{
   [SerializeField] private FP_Input fpInput;
   
   [SerializeField] private float shootRate;
   [SerializeField] private float damage = 50;
   [SerializeField] private float bulletSpeed = 15;
  
   [SerializeField] private Transform bulletSpawnPoint;
   
   private CubeColor currentColor = CubeColor.red;
   
   private float delay;
   
   private BulletFabric bulletFabric;

   private Camera mainCam;

   private void Awake()
   {
      bulletFabric = FindObjectOfType<BulletFabric>();
      mainCam = Camera.main;
      CubeLoot.OnCubePickup += UpdateCurrentColor;
   }

   private void UpdateCurrentColor(CubeColor cubeColor)
   {
      currentColor = cubeColor;
   }
   private void Update () 
   {
      if(fpInput.Shoot())                        
         if(Time.time > delay)
            Shoot();
   }
   private void Shoot()
   {
      Bullet bullet = bulletFabric.GetBulletByType(currentColor, bulletSpawnPoint.position);
      bullet.InitBullet(mainCam.transform.forward, damage,bulletSpeed);
      delay = Time.time + shootRate;
   }
}
