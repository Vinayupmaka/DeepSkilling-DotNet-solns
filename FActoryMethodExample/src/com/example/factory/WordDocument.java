package com.example.factory;

public class WordDocument implements Document{
    @Override
    public void open(){
        System.out.println("Opening the word document.");
    }
}
