using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hp;
    public GameObject timer;
    public GameObject blockManager;
    public GameObject ui_panel; //”’‚¢•Ç
    public GameObject ui_gamestart;@//‚ ‚Æ‚ÍƒeƒLƒXƒg
    public GameObject ui_gameclear;
    public GameObject ui_gameover;

    public bool start;
    public bool gaming;
    public bool gameClear;
    public bool gameOver;

    public float alpha;

    // Start is called before the first frame update
    void Start()
    {
        start = true;
        gaming = false;
        gameClear = false;
        gameOver = false;
        alpha = 1f; //”Z‚ä‚¢@‚O`‚Q‚T‚T[„‚O`‚P
    }

    // Update is called once per frame
    void Update()
    {
        //start‰æ–Ê‚©‚çƒQ[ƒ€‚É‚¢‚­‚Æ‚«
        if( start == true && alpha <= 0f )
        {
            alpha = 1.0f;
            start = false;
            gaming = true;
        }

        if ( gaming && blockManager.GetComponent<BlockManager>().currentBlocks <= 0 )//game‚ğƒNƒŠƒA‚·‚éğŒ‚ğ“ü‚ê‚é
        {
            alpha = 0f;
            gaming = false;
            gameClear = true;
        }

        if ( gaming && hp.GetComponent<HPSlider>().CurrentHP <= 0)
        {
            alpha = 0f;
            gaming = false;
            gameOver = true;
        }

        if( start )
        {
            alpha -= 0.01f;
            //panel‚Ægamestart‚ğ‚·‚±‚µ‚¸‚Â”–‚­‚·‚é
            ui_panel.GetComponent<Image>().color = new Color( 255f,255f,255f,alpha );
            ui_gamestart.GetComponent<Text>().color = new Color( 0f,0f,0f,alpha );
        }
        else if (gaming)
        {

        }
        else if ( gameClear )
        {
            alpha += 0.01f;
            //panel‚Ægamestart‚ğ‚·‚±‚µ‚¸‚Â”Z‚­‚·‚é
            ui_panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, alpha);
            ui_gameclear.GetComponent<Text>().color = new Color(0f, 0f, 0f, alpha);
        }
        else if ( gameOver )
        {
            alpha += 0.01f;
            //panel‚Ægamestart‚ğ‚·‚±‚µ‚¸‚Â”Z‚­‚·‚é
            ui_panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, alpha);
            ui_gameover.GetComponent<Text>().color = new Color(0f, 0f, 0f, alpha);
        }
    }
}
