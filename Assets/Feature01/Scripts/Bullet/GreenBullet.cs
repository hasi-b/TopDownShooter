using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBullet : BulletAbstractClasses
{
  
    
    public override void selectBullet(GameObject bullet)
    {
        bullet.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green ;
        
    }
}
