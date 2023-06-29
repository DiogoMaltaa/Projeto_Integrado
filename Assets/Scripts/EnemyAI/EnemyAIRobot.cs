using UnityEngine;
using UnityEngine.AI;

public class EnemyAIRobot : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public LayerMask isGround, isPlayer;

    //Patroll
    [Header("Patroll Variables")]
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attack
    [Header("Attack Variables")]
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    [Header("Enemy States")]
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;


    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        //check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, isPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, isPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patrolling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();
    }

    void Patrolling()
    {
        if (!walkPointSet) SearchWalkPoint();

        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }

    void SearchWalkPoint()
    {
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

        if(Physics.Raycast(walkPoint, -transform.up, 2f, isGround))
        {
            walkPointSet = true;
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    void AttackPlayer()
    {
        agent.SetDestination(transform.position); //make sure it doesnt move

        Debug.Log("Attacking or something IDK");
    }
}
