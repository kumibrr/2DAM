package com.israel.libros.controllers;

import com.israel.libros.model.entities.User;
import com.israel.libros.model.repositories.BookRepository;
import com.israel.libros.model.repositories.UserBookRepository;
import com.israel.libros.model.repositories.UserRepository;
import com.israel.libros.security.JwtAuthenticator;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.HashMap;

@RestController
@RequestMapping("/user")
public class UserController {

    @Autowired
    private UserRepository userRepository;

    public UserController(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @PostMapping("/login")
    public HashMap<String, Object> authenticate(@RequestBody userAuthenticationData data) {
        HashMap<String, Object> response = new HashMap<>();
        User user = userRepository.findByUsernameAndPassword(data.username, data.password);
        if (user != null) {
            response.put("username", user.getUsername());
            response.put("jwt", JwtAuthenticator.encryptJwt(user));
        }
        return response;
    }

    static class userAuthenticationData {
        public String username;
        public String password;

        public userAuthenticationData(String username, String password) {
            super();
            this.username = username;
            this.password = password;
        }
    }
}
