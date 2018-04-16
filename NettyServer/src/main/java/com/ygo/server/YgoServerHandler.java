package com.ygo.server;

import io.netty.channel.ChannelHandler.Sharable;
import io.netty.channel.ChannelHandlerContext;
import io.netty.channel.ChannelInboundHandlerAdapter;

/**
 * 出入站事件处理类
 * @author EganChen
 * @date 2018/4/16 13:49
 */
@Sharable
public class YgoServerHandler extends ChannelInboundHandlerAdapter{
    
    /**
    * 处理接收到的消息
    * @date 2018/4/16
    * @param [ctx, msg]
    * @return
    */
    @Override
    public void channelRead(ChannelHandlerContext ctx, Object msg) throws Exception {

    }

    /**
    * 将未决消息冲刷到远程节点，并关闭连接
    * @date 2018/4/16
    * @param [ctx]
    * @return
    */
    @Override
    public void channelReadComplete(ChannelHandlerContext ctx) throws Exception {

    }

    /**
    * 捕获并打印异常，关闭连接
    * @date 2018/4/16
    * @param [ctx, cause]
    * @return
    */
    @Override
    public void exceptionCaught(ChannelHandlerContext ctx, Throwable cause) throws Exception {
    }
}
