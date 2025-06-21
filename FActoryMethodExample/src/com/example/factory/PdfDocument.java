package com.example.factory;

public class PdfDocument implements Document{
    @Override
    public void open(){
        System.out.println("Opening the pdf document.");
    }
}
