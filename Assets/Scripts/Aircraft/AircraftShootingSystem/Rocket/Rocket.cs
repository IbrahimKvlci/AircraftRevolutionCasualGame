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

    private Vector3 targetDir;

    private void Start()
    {
        targetDir = (TargetPos - transform.position).normalized;

        transform.forward = targetDir;
    }

    private void Update()
    {
        transform.position += targetDir * Time.deltaTime * RocketSpeed;
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

        Destroy(gameObject);
    }

  
}
