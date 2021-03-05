package com.israel.libros.controllers;

import com.israel.libros.model.entities.Book;
import com.israel.libros.model.repositories.BookRepository;
import com.israel.libros.model.repositories.UserBookRepository;
import com.israel.libros.model.repositories.UserRepository;
import com.israel.libros.security.JwtAuthenticator;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import javax.servlet.http.HttpServletRequest;
import java.util.ArrayList;
import java.util.List;

@RestController
@RequestMapping("/book")
public class BookController {

    @Autowired
    private UserBookRepository userBookRepository;

    @Autowired
    private BookRepository bookRepository;

    public BookController(
            BookRepository bookRepository,
            UserBookRepository userBookRepository
    ) {
        this.bookRepository = bookRepository;
        this.userBookRepository = userBookRepository;
    }

    @GetMapping ("/getAll")
    public List<Book> getAllUsersBooks(HttpServletRequest request) {
        ArrayList<Book> response = new ArrayList<>();
        int id = JwtAuthenticator.getUserIdFromJwtRequest(request);
        return userBookRepository.getAllByUser(id);
    }

}
