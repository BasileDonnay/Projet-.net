using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAi : MonoBehaviour
{
    private GameObject[] targets;
    private List<Transform> positions = new List<Transform>();
    private Transform target;
    public float speed = 200f;
    public float nextWaypointDistance = 3f;
    public string targetTag = "Player";

    Path path;
    int currentWaypoint = 0;
    //bool reachedEndOfPath = false;

    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        targets = GameObject.FindGameObjectsWithTag(targetTag);
        foreach (GameObject gameObject in targets)
        {
            positions.Add(gameObject.transform);
        }

        InvokeRepeating("UpdatePath", 0f, 0.1f);
    }

    void UpdatePath()
    {
        foreach (Transform player in positions)
        {
            if (player != null)
            {
                if (target == null)
                {
                    target = player;
                }
                else
                {
                    if (Vector3.Distance(transform.position, player.transform.position) < Vector3.Distance(transform.position, target.transform.position))
                    {
                        target = player;
                    }
                }
            }
        }
        if (target != null && seeker.IsDone())
        {
            seeker.StartPath(rb.position, target.position, OnPathComplete);
        }

        if(target != null)
        {
            Vector3 targ = target.transform.position;
            targ.z = 0f;

            Vector3 objectPos = transform.position;
            targ.x = targ.x - objectPos.x;
            targ.y = targ.y - objectPos.y;

            float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
            currentWaypoint = 0;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (path == null)
        {
            return;
        }

        if(currentWaypoint >= path.vectorPath.Count)
        {
            //reachedEndOfPath = true;
            return;
        } else
        {
            //reachedEndOfPath = false;
        }

        Vector2 direction = ((Vector2)path.vectorPath[currentWaypoint] - rb.position).normalized;
        Vector2 force = direction * speed * Time.deltaTime;

        rb.AddForce(force);

        float distance = Vector2.Distance(rb.position, path.vectorPath[currentWaypoint]);

        if(distance < nextWaypointDistance)
        {
            currentWaypoint++;
        }
    }
}

