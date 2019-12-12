using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class securityNEW : MonoBehaviour
{
    public float speed;



    [SerializeField] GameObject RightAnim;
    [SerializeField] GameObject LeftAnim;
    [SerializeField] GameObject FaceAnim;
    [SerializeField] GameObject EndGame;

    [SerializeField] Transform PositionOne;
    [SerializeField] float timeStopOne = 5.0f;
    [SerializeField] Transform DverOneA;
    [SerializeField] Transform DverOneB;

    [SerializeField] Transform PositionTwo;
    [SerializeField] float timeStopTwo = 10.0f;

    [SerializeField] Transform DverTwoA;
    [SerializeField] Transform DverTwoB;
    [SerializeField] Transform PositionThree;
    [SerializeField] float timeStopThree = 15.0f;

    float timer = 0;
    Coroutine move;
    Vector3 targetMove;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeStopOne;
        targetMove = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0) timer -= Time.deltaTime;
        else if (timer <= 0 && move == null) GoNext();
        if(move != null) transform.position = Vector2.MoveTowards(transform.position, targetMove, speed * Time.deltaTime);
        
    }

    private void GoNext()
    {
        if(Vector2.Distance(transform.position, PositionOne.position) < 0.2f)
        {
            move = StartCoroutine(GoOne_Two());
        }
        
        if(Vector2.Distance(transform.position, PositionTwo.position) < 0.2f)
        {
            move = StartCoroutine(GoTwo_Three());
        }

        if (Vector2.Distance(transform.position, PositionThree.position) < 0.2f)
        {
            move = StartCoroutine(GoTrhee_One());
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("player")) { EndGame.SetActive(true); /*Time.timeScale = 0; ставит игру на паузу*/ }
    }

    private void PlayGoRigthAnim()
    {
       //this.gameObject.transform.lossyScale.Scale(new Vector3(5, 1, 1));
        FaceAnim.SetActive(false);
        LeftAnim.SetActive(false);
        RightAnim.SetActive(true);
    }
    private void PlayStayAnim()
    {
        //transform.localScale.Set(1, 1, 1);
        LeftAnim.SetActive(false);
        RightAnim.SetActive(false);
        FaceAnim.SetActive(true);
    }
    private void PlayGoLeftAnim()
    {
        //transform.localScale.Set(-1, 1, 1);
        FaceAnim.SetActive(false);
        RightAnim.SetActive(false);
        LeftAnim.SetActive(true);
    }
    IEnumerator GoOne_Two()
    {
        PlayGoRigthAnim();
        targetMove = DverOneA.position;
        yield return new WaitWhile(()=>Vector2.Distance(transform.position, targetMove) > 0.02f);
        transform.position = DverOneB.position;
        targetMove = PositionTwo.position;
        yield return new WaitWhile(() => Vector2.Distance(transform.position, targetMove) > 0.02f);
        timer = timeStopTwo;
        PlayStayAnim();
        move = null;
    }


    IEnumerator GoTwo_Three()
    {
        PlayGoRigthAnim();
        targetMove = DverTwoA.position;
        yield return new WaitWhile(()=>Vector2.Distance(transform.position, targetMove) > 0.02f);
        transform.position = DverTwoB.position;
        targetMove = PositionThree.position;
        yield return new WaitWhile(() => Vector2.Distance(transform.position, targetMove) > 0.02f);
        timer = timeStopThree;
        PlayStayAnim();
        move = null;
    }
    IEnumerator GoTrhee_One()
    {
        PlayGoLeftAnim();
        targetMove = DverTwoB.position;
        yield return new WaitWhile(()=>Vector2.Distance(transform.position, targetMove) > 0.02f);
        transform.position = DverTwoA.position;

        targetMove = DverOneB.position;
        yield return new WaitWhile(()=>Vector2.Distance(transform.position, targetMove) > 0.02f);
        transform.position = DverOneA.position;

        targetMove = PositionOne.position;
        yield return new WaitWhile(() => Vector2.Distance(transform.position, targetMove) > 0.02f);
        timer = timeStopOne;
        PlayStayAnim();
        move = null;
    }

}
