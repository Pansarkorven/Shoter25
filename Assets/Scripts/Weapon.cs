using StarterAssets;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    StarterAssetsInputs starterAssetsInputs; 


    private void Awake()
    {
       starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();   
    }

    void Update()
    {

        if (starterAssetsInputs.Shoot)
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
            {
                Debug.Log(hit.collider.name);
                starterAssetsInputs.ShootInput(false);

               
                EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
                
                if (enemyHealth != null)
                {
                    enemyHealth.TakeDamage();
                }
                else
                {
                    Debug.Log("NotFindingEnemyHealth");
                }
            }
        }

            
    }
}
