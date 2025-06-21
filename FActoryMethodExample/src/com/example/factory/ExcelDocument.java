package com.example.factory;

public class ExcelDocument implements Document{
    @Override
    public void open(){
        System.out.println("Opening the Excel document");
    }
}
