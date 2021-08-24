using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public GameObject[] blocks;

    public int maxBlocks;
    public int currentBlocks;

    // Start is called before the first frame update
    void Start()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");
        maxBlocks = blocks.Length;//ブロックの数
    }

    // Update is called once per frame
    void Update()
    {
        currentBlocks = 0;//残っているブロックの数を保持している
        for ( int i = 0; i < maxBlocks; i++ )
        {
            if ( blocks[i] == null ) continue;
            currentBlocks++;
        }
    }
}
