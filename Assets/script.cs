using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class script : MonoBehaviour
{
    [SerializeField] private InputActionReference gripAction;
    [SerializeField] private InputActionReference triggetAction;

    public GameObject TerrainScannerPrefab;
    public float duration = 10;
    public float size = 500;

    // Start is called before the first frame update
    void Start()
    {
        gripAction.action.performed += SpawnTerrainScanner;
    }

    // Update is called once per frame
    void Update()
    {
   //     if (Input.GetKeyDown(KeyCode.Z))
   //     {
   //         SpawnTerrainScanner();
   //     }    
    }

    private void OnDestroy()
    {
        gripAction.action.performed -= SpawnTerrainScanner;
    }

    void SpawnTerrainScanner(InputAction.CallbackContext ctx) 
    {
        GameObject terrainScanner = Instantiate(TerrainScannerPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
        ParticleSystem terrainScannerPS = terrainScanner.transform.GetChild(0).GetComponent<ParticleSystem>();

        if (terrainScannerPS != null) {
            var main = terrainScannerPS.main;
            main.startLifetime = duration;
            main.startSize = size;
        } else {
            Debug.Log("The first child doesn't have a particle system.");
        }

        Destroy(terrainScanner, duration+1);
    }
}
