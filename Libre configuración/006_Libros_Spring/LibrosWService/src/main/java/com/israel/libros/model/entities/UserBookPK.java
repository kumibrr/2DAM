package com.israel.libros.model.entities;

import javax.persistence.Column;
import javax.persistence.Id;
import java.io.Serializable;
import java.util.Objects;

public class UserBookPK implements Serializable {
    private int user;
    private String book;

    @Column(name = "user")
    @Id
    public int getUser() {
        return user;
    }

    public void setUser(int user) {
        this.user = user;
    }

    @Column(name = "book")
    @Id
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
        UserBookPK that = (UserBookPK) o;
        return user == that.user && Objects.equals(book, that.book);
    }

    @Override
    public int hashCode() {
        return Objects.hash(user, book);
    }
}
