using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public ParticleSystem explosionYellowSmall;
    public ParticleSystem explosionRedSmall;
// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlayProyectilYellowExplosionAt(Vector3 position) {
            Instantiate(explosionYellowSmall, position, transform.rotation);
    }
    public void PlayProyectilRedExplosionAt(Vector3 position) {
            Instantiate(explosionRedSmall, position, transform.rotation);
    }
}
