package com.israel.libros.model.repositories;

import com.israel.libros.model.entities.Book;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface BookRepository extends CrudRepository<Book, Integer> {

    @Query(value = "SELECT * WHERE ISBN= ?", nativeQuery = true)
    public Book getBookByIsbn(String ISBN);

}
