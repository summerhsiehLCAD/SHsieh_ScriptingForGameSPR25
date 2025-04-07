using UnityEngine;

public class RangedEnemy : Enemy
{
    public GameObject projectilePrefab;

    public Transform projectileSpawnPosition;

    public float projectileForce = 500f;

    protected override void Attack()
    {
        GameObject go = Instantiate(projectilePrefab, projectileSpawnPosition.position, Quaternion.identity);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * projectileForce);
    }

    protected override void Update()
    {
       // this.transform.LookAt(player.transform.position);

        base.Update();
    }
}
