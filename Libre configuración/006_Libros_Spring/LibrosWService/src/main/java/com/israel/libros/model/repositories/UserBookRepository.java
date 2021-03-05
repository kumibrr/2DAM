package com.israel.libros.model.repositories;

import com.israel.libros.model.entities.Book;
import com.israel.libros.model.entities.UserBook;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface UserBookRepository extends CrudRepository<UserBook, Integer> {

    @Query(value = "SELECT * FROM book INNER JOIN UserBook ON book.ISBN=UserBook.ISBN WHERE UserBook.user=?", nativeQuery = true)
    public List<Book> getAllByUser(Integer userId);
}
