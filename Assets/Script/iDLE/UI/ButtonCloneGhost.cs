using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCloneGhost : MonoBehaviour
{
    public GameObject ghostOri;
    public GameObject parentClone;
    [SerializeField] private Transform pos1, pos2;
    GameObject GhostClone;
    GhostBehavio ghost;

    
    // Start is called before the first frame update
    void Start()
    {
        // ghost = GhostClone.GetComponent<GhostBehavio>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(transform.position == pos1.position || GhostClone.position == pos2.position)
        if(GhostClone){
            if(GhostClone.transform.position == pos1.position){
                Destroy(this.gameObject);
            }
        }
        
    }


    public void createGhost(){
        // int numberRandom = Random.Range(1,3);
        // Vector3 posisi;
        // if(numberRandom == 1){
        //     posisi = pos1.position;
        // }
        // else if(numberRandom == 2){
        //     posisi = pos2.position;
        // }
        GhostClone = Instantiate(ghostOri, pos2.position, Quaternion.identity);
        GhostClone.transform.parent = parentClone.transform;
        // Debug.Log("Clone Created" + ghost.getTujuan().x);

    }
}
