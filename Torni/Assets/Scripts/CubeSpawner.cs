using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField]
    private TopCube cubePrefab;

    public void SpawnCube()
    {
        var cube = Instantiate(cubePrefab);

        if (TopCube.LastCube != null && TopCube.LastCube.gameObject != GameObject.Find("BaseCube"))
        {
            cube.transform.position = new Vector3(transform.position.x,
                        TopCube.LastCube.transform.position.y + cubePrefab.transform.localScale.y,
                        transform.position.z);
        }
        else
        {
            cube.transform.position = transform.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position, cubePrefab.transform.localScale);
    }
}