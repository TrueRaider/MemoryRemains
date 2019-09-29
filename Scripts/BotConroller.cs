using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BotConroller : MonoBehaviour
{
    [SerializeField]
    public NavMeshData data;

    public NavMeshAgent objectTest;
    // Start is called before the first frame update
    void Start()
    {
        var navMeshDatas = (new List<NavMeshData> {data});
        NavMeshPoints.UpdatePositions(navMeshDatas);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objectTest.remainingDistance < 0.1f)
        {
            objectTest.SetDestination(NavMeshPoints.RandomPosition());
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
 
        if (NavMeshPoints._validPositions != null)
        {
            foreach (var pos in NavMeshPoints._validPositions)
            {
                Gizmos.DrawSphere(pos, 0.3f);
            }
        }
        
        if (NavMeshPoints._gridPositions != null)
        {
            Gizmos.color = Color.gray;
            foreach (var pos in NavMeshPoints._gridPositions)
            {
                var halfBox = 2;
                Gizmos.DrawSphere(pos, 0.1f);
                var a = pos - new Vector3(-halfBox, 0, -halfBox);
                var b = pos - new Vector3(-halfBox, 0, halfBox);
                var c = pos - new Vector3(halfBox, 0, halfBox);
                var d = pos - new Vector3(halfBox, 0, -halfBox);
                Gizmos.DrawLine(a, b);
                Gizmos.DrawLine(b, c);
                Gizmos.DrawLine(c, d);
                Gizmos.DrawLine(d, a);
            }
        }
    }  

}
