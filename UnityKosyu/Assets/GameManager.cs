using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hp;
    public GameObject timer;
    public GameObject blockManager;
    public GameObject ui_panel; //������
    public GameObject ui_gamestart;�@//���Ƃ̓e�L�X�g
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
        alpha = 1f; //�Z�䂢�@�O�`�Q�T�T�[���O�`�P
    }

    // Update is called once per frame
    void Update()
    {
        //start��ʂ���Q�[���ɂ����Ƃ�
        if( start == true && alpha <= 0f )
        {
            alpha = 1.0f;
            start = false;
            gaming = true;
        }

        if ( gaming && blockManager.GetComponent<BlockManager>().currentBlocks <= 0 )//game���N���A�������������
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
            //panel��gamestart������������������
            ui_panel.GetComponent<Image>().color = new Color( 255f,255f,255f,alpha );
            ui_gamestart.GetComponent<Text>().color = new Color( 0f,0f,0f,alpha );
        }
        else if (gaming)
        {

        }
        else if ( gameClear )
        {
            alpha += 0.01f;
            //panel��gamestart�����������Z������
            ui_panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, alpha);
            ui_gameclear.GetComponent<Text>().color = new Color(0f, 0f, 0f, alpha);
        }
        else if ( gameOver )
        {
            alpha += 0.01f;
            //panel��gamestart�����������Z������
            ui_panel.GetComponent<Image>().color = new Color(255f, 255f, 255f, alpha);
            ui_gameover.GetComponent<Text>().color = new Color(0f, 0f, 0f, alpha);
        }
    }
}
