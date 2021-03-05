package com.israel.libros.security;

import com.israel.libros.model.entities.User;
import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.SignatureAlgorithm;
import io.jsonwebtoken.impl.crypto.MacProvider;

import javax.crypto.KeyGenerator;
import javax.servlet.http.HttpServletRequest;
import java.security.Key;
import java.security.NoSuchAlgorithmException;

public class JwtAuthenticator {

    private static Key secret = null;

    public static String encryptJwt(User user) {
        String jwt = Jwts.builder().setSubject(user.getId().toString()).signWith(SignatureAlgorithm.HS512, regenerateSecret()).compact();
        return jwt;
    }

    public static int getUserIdFromJwt(String jwt) {
        try {
            String userIdString = Jwts.parser().setSigningKey(regenerateSecret()).parseClaimsJws(jwt).getBody().getSubject();
            int userId = Integer.parseInt(userIdString);
            return userId;
        } catch (Exception e) {
            e.printStackTrace();
            return -1;
        }
    }

    public static int getUserIdFromJwtRequest(HttpServletRequest request) {
        String authHeader = request.getHeader("Authorization");
        if (authHeader != null && authHeader.length() > 8) {
            return getUserIdFromJwt(authHeader.substring(7));
        }
        return -1;
    }

    private static Key regenerateSecret() {
        if (secret == null) {
            secret = MacProvider.generateKey();
        }
        return secret;
    }

}
