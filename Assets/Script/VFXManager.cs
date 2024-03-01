using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxSource;
    public GameObject vfxSwitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSource, spawnPosition, Quaternion.identity);
    }

    public void PlaySwitchVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitch, spawnPosition, Quaternion.identity);
    }
}
