using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public Vector3 TargetPos { get; set; }
    public float Damage { get; set; }

    [field:SerializeField] public float RocketSpeed {  get; set; }
    [SerializeField] private float radius;
    [SerializeField] private LayerMask enemyLayerMask;
    [SerializeField] private ParticleSystem explosionFx;

    private Vector3 targetDir;

    private void Start()
    {
        targetDir = (TargetPos - transform.position).normalized;

        
    }

    private void Update()
    {
        transform.position += targetDir * Time.deltaTime * RocketSpeed;
        transform.forward = Vector3.Lerp(transform.forward, targetDir, 0.05f);
    }

    private void OnTriggerEnter(Collider other)
    {
        List<Collider> collidedObjects = Physics.OverlapSphere(transform.position, radius, enemyLayerMask).ToList();

        foreach (var item in collidedObjects)
        {
            if(item.TryGetComponent<Enemy>(out Enemy enemy))
            {
                enemy.EnemyHealth.TakeDamage(Damage);
                Debug.Log("ROCKET");
            }
        }
        if(!other.TryGetComponent<Aircraft>(out Aircraft aircraft))
        {
            ExplosionEffect();
            Destroy(gameObject);
        }
    }

    private void ExplosionEffect()
    {
        Instantiate(explosionFx,transform.position,Quaternion.identity);
    }

  
}
