package com.israel.libros.model.entities;

import javax.persistence.*;
import java.io.Serializable;
import java.util.Objects;

@Entity
@Table(name = "user_book", schema = "libros_db")
@IdClass(UserBookPK.class)
public class UserBook implements Serializable {
    private Long id;
    private int user;
    private String book;

    @Id
    @GeneratedValue
    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    @Id
    @Column(name = "user")
    public int getUser() {
        return user;
    }

    public void setUser(int user) {
        this.user = user;
    }

    @Id
    @Column(name = "book")
    public String getBook() {
        return book;
    }

    public void setBook(String book) {
        this.book = book;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        UserBook that = (UserBook) o;
        return user == that.user && Objects.equals(book, that.book);
    }

    @Override
    public int hashCode() {
        return Objects.hash(user, book);
    }
}
