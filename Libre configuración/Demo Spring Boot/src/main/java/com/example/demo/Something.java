package com.example.demo;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class Something {

    @GetMapping("/haha")
    public String doGet() {
        return "GET - HOLAMUNDO";
    }

    @PostMapping("/haha")
    public String doPost() {
        return "GET - HOLAMUNDO";
    }
}
