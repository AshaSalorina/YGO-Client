using System.Net.Sockets;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class SocketClient : MonoBehaviour
{
    private const string IP = "????????";
    private const int PORT = 2333;

    private Socket client;
    private string ip, msg;


    /// <summary>
    /// 开始连接服务器
    /// </summary>
    public void start()
    {
        try
        {
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            client.Connect(IP, PORT);
            Debug.Log("连接服务器成功\r\n");

            Thread threadReceive = new Thread(ReceiveMsg);
            threadReceive.IsBackground = true;
            threadReceive.Start();
        }
        catch
        {
            Debug.Log("连接服务器失败\r\n");
        }
    }

    /// <summary>
    /// 向服务器发送信息
    /// </summary>
    /// <param name="msg">信息</param>
    public void Send(string msg)
    {
        if (client == null)
        {
            start();
        }

        byte[] buffer = Encoding.UTF8.GetBytes("a message from client");
        client.Send(buffer);

    }


    /// <summary>
    /// 接收服务器的信息
    /// </summary>
    private void ReceiveMsg()
    {
        byte[] buffer = new byte[1024 * 1024];
        int len = 0;
        while (true)
        {
            len = client.Receive(buffer);
            msg = Encoding.UTF8.GetString(buffer, 1, len - 1);
        }
        print(msg);
    }

    /// <summary>
    /// 更新日志
    /// </summary>
    void Update()
    {
        if (!string.IsNullOrEmpty(msg))
        {
            Debug.Log("服务器：" + msg + "\r\n");
            msg = "";
        }
        if (!string.IsNullOrEmpty(ip))
        {

            ip = "";
        }
    }

    /// <summary>
    /// 关闭连接
    /// </summary>
    void OnApplicationQuit()
    {
        client.Shutdown(SocketShutdown.Both);
        client.Close();
    }
}