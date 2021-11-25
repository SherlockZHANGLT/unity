using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shoot : MonoBehaviour
{
    public GameObject bullet;
    public float n = 1.0f;
    public int ball_num = 100;
    public float speed = 30;
    public float maxspeed = 70;
    public float minspeed = 10;
    private float slideSpeed = 1; //滚轮速度
    public delegate void PlayerSpeed(float temp);//定义委托
    public event PlayerSpeed GetSpeed;//定义球速事件，用于发出球速的消息
    public delegate void PlayerBall(int temp);//定义委托
    public event PlayerBall GetBall;//定义得分事件，用于发出得分的消息
    public delegate void PlayerScore(int temp);//定义委托
    public event PlayerScore GetScore;//定义得分事件，用于发出得分的消息

    public AudioClip _AudioClip;//小球发射声效
    AudioSource m_AudioSource;
    public AudioClip _HitClip;//小球碰撞方块声效
    // AudioSource m_HitAudioSource
    // Start is called before the first frame update
    public static int ss=0;
    void Awake()
    {

        int index = SceneManager.GetActiveScene().buildIndex;
        if(index == 3 || index == 5 || index == 7)ss = ss + 100;
        if (GetBall != null)//检查事件是否为空，即有没有接收器订阅它
        {
            GetBall(ball_num);
        }
        ss = ss;
        if (GetScore != null)//检查事件是否为空，即有没有接收器订阅它
        {
            GetScore(ss);//发送得分
        }
    }
    void Start()
    {
        m_AudioSource= gameObject.AddComponent<AudioSource>();
        m_AudioSource.clip = _AudioClip;

    }
    // Update is called once per frame
    void Update()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 1) ss = 0;
        ss = ss;
        GetSpeed(speed);
        Debug.Log("aa");
        float mouseCenter = Input.GetAxis("Mouse ScrollWheel");

        //通过键盘1,2,3选择小球半径大小
        if (Input.GetKey(KeyCode.Alpha1) || (ball_num - 2 * 2 < 0))
        {
            n = 1.0f;
        }
        else if (Input.GetKey(KeyCode.Alpha2) && (ball_num - 2 * 2 >= 0))
        {
            n = 2.0f;
        }
        else if (Input.GetKey(KeyCode.Alpha3) && (ball_num - 3 * 3 < 0))
        {
            n = 1.0f;
        }
        else if (Input.GetKey(KeyCode.Alpha3) && (ball_num - 3 * 3 >= 0))
        {
            n = 3.0f;
        }
        if (mouseCenter < 0)
        {
            //滑动限制
            if (speed > minspeed)
            {
                speed -= slideSpeed * Time.deltaTime * 100;
                if (speed < minspeed)
                {
                    speed = minspeed;
                }
            }
            //mouseCenter >0 = 正数 往前滑动,增加速度
        }
        else if (mouseCenter > 0)
        {
            //滑动限制
            if (speed < maxspeed)
            {
                speed += slideSpeed * Time.deltaTime * 100;
                if (speed > maxspeed)
                {
                    speed = maxspeed;
                }
            }
        }
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("bb");
            m_AudioSource.Play();
            //在前方发射小球
            Vector3 pos = transform.position;
            pos.z = pos.z + (n + 1) * 0.5f;
            transform.position = pos;
            Vector3 scale = transform.localScale;
            scale.x = n;
            scale.y = n;
            scale.z = n;
            transform.localScale = scale;
            GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            b.transform.localScale = transform.localScale;
            b.AddComponent<DestroyBall>();
            
            //给每一个发出去的小球添加碰撞声效组件
            b.AddComponent<Hitted>();
            b.GetComponent<Hitted>()._HitClip = _HitClip;
            Rigidbody rgd = b.GetComponent<Rigidbody>();



            rgd.velocity = transform.forward * speed;
            if (index == 3 || index == 5 || index == 7)
            {
                ball_num = ball_num - (int)(n * n);
                if (ball_num < 0) { SceneManager.LoadScene(8); }
                GetBall(ball_num);
                ss = ss - (int)(n * n);
            }
        }
        GetScore(ss);
    }

}
