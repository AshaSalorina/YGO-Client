package com.ygo.lobby;

import java.util.LinkedList;
import java.util.List;

/**
 * 房间类
 * @author EganChen
 * @date 2018/4/16 14:11
 */
public class Room {

    private String id;
    private String name;
    private String password;

    private List<User>players = new LinkedList<>();
    private List<User>observers = new LinkedList<>();

    public List<User> getPlayers() {
        return players;
    }

    public void setPlayers(List<User> players) {
        this.players = players;
    }

    public List<User> getObservers() {
        return observers;
    }

    public void setObservers(List<User> observers) {
        this.observers = observers;
    }

    public String getId() {
        return id;
    }

    public void setId(String id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
