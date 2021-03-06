package com.israel.libros;

import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.boot.web.servlet.ServletComponentScan;

@ServletComponentScan
@SpringBootApplication
public class LibrosApplication {

    public static void main(String[] args) {
        SpringApplication.run(LibrosApplication.class, args);
    }

}
